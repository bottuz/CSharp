using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omdb_film_bottagisi
{
    public partial class Form1 : Form
    {
        static HttpClient cliente = new HttpClient();
        static List<Movie> movies = new List<Movie>();
        const string apikey = "ea53e094";
        static IDictionary<string, string> dizionario = new Dictionary<string, string> { { "movie", "film" }, { "series", "serie" }, { "episode", "episodio" }, { "game", "gioco" } };

        public Form1()
        {
            InitializeComponent();
            cliente.BaseAddress = new Uri("http://omdbapi.com/");
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            NResult.SelectedIndex = 1;
            pictureBox.Image = Properties.Resources.no_image;
            lvMovie.View = View.LargeIcon;
        }

        public static async Task<MoviesSearch> searchMovies(string title, int page)
        {
            MoviesSearch movies = null;
            try
            {
                HttpResponseMessage response = await cliente.GetAsync("/?apikey=" + apikey + "&s=" + title + "&page=" + page.ToString());
                if (response.IsSuccessStatusCode)
                {
                    movies = await response.Content.ReadAsAsync<MoviesSearch>();
                }
            }
            catch { }
            return movies;
        }

        public static async Task<MovieDetails> getMovieDetails(string id)
        {
            MovieDetails movie = null;
            try
            {
                HttpResponseMessage response = await cliente.GetAsync("/?apikey=" + apikey + "&i=" + id);
                if (response.IsSuccessStatusCode)
                {
                    movie = await response.Content.ReadAsAsync<MovieDetails>();
                }
            }
            catch { }
            return movie;
        }

        public Image getImage(string url)
        {
            Image img;
            try
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(url);
                MemoryStream ms = new MemoryStream(bytes);
                img = Image.FromStream(ms);
            }
            catch
            {
                img = Properties.Resources.no_image;
            }
            return img;
        }

        private void disableSearch()
        {
            btnSearch.Enabled = false;
            txtSearch.Enabled = false;
            lvMovie.Enabled = false;
            NResult.Enabled = false;
        }

        private void enableSearch()
        {
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;
            lvMovie.Enabled = true;
            NResult.Enabled = true;
        }

        private void RefreshMovieList()
        {
            lvMovie.Items.Clear();
            movieImageList.Images.Clear();
            foreach (Movie movie in movies)
            {
                try
                {
                    movieImageList.Images.Add(movie.imdbID, getImage(movie.Poster));
                    lvMovie.Items.Add(movie.Title, movie.imdbID);
                    lvMovie.Items[lvMovie.Items.Count - 1].SubItems.Add(movie.Year);
                    lvMovie.Items[lvMovie.Items.Count - 1].SubItems.Add(dizionario[movie.Type]);
                    lvMovie.Items[lvMovie.Items.Count - 1].SubItems.Add(movie.Poster);
                }
                catch
                {
                    Image img = Properties.Resources.buttonSearch;
                    movieImageList.Images.Add(movie.imdbID, img);
                    lvMovie.Items.Add(movie.Title, movie.imdbID);
                    lvMovie.Items[lvMovie.Items.Count - 1].SubItems.Add(movie.Year);
                    lvMovie.Items[lvMovie.Items.Count - 1].SubItems.Add(dizionario[movie.Type]);
                    lvMovie.Items[lvMovie.Items.Count - 1].SubItems.Add(movie.Poster);
                }
            }
            lvMovie.Focus();
            lvMovie.Items[0].Selected = true;
        }

        private async void lvMovie_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
                return;
            pictureBox.Image = getImage(e.Item.SubItems[3].Text);
            MovieDetails result = await getMovieDetails(e.Item.ImageKey);
            if (result == null)
            {
                MessageBox.Show("Impossibile comunicare con il server", "Errore");
                return;
            }
            Titolo.Text = result.Title;
            Produzione.Text = result.Production;
            Regia.Text = result.Director;
            Stato.Text = result.Country;
            Anno.Text = result.Year;
            DVD.Text = result.DVD;
            Tipo.Text = result.Type;
            Durata.Text = result.Runtime;
            Trama.Text = result.Plot;


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private async void NResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {

            }
            else
            {
                int totalResults = 20, gotResults = 0, page = 1, toGet = int.Parse(NResult.SelectedItem.ToString());
                disableSearch();
                movies = new List<Movie>();
                while (gotResults < Math.Min(totalResults, toGet))
                {
                    MoviesSearch result = await searchMovies(txtSearch.Text, page++);
                    if (result == null)
                    {
                        MessageBox.Show("Impossibile comunicare con il server", "Errore");
                        enableSearch();
                        return;
                    }
                    else if (result.Search == null)
                    {
                        MessageBox.Show("Nessun film trovato", "Errore");
                        enableSearch();
                        return;
                    }
                    gotResults += result.Search.Count();
                    totalResults = int.Parse(result.totalResults);
                    movies.AddRange(result.Search);
                }
                enableSearch();
                RefreshMovieList();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Inserisci il titolo del film che vuoi cercare", "Errore");
                return;
            }
            int totalResults = 20, gotResults = 0, page = 1, toGet = int.Parse(NResult.SelectedItem.ToString());
            disableSearch();
            movies = new List<Movie>();
            while (gotResults < Math.Min(totalResults, toGet))
            {
                MoviesSearch result = await searchMovies(txtSearch.Text, page++);
                if (result == null)
                {
                    MessageBox.Show("Impossibile comunicare con il server", "Errore");
                    enableSearch();
                    return;
                }
                else if (result.Search == null)
                {
                    MessageBox.Show("Nessun film trovato", "Errore");
                    enableSearch();
                    return;
                }
                gotResults += result.Search.Count();
                totalResults = int.Parse(result.totalResults);
                movies.AddRange(result.Search);
            }
            enableSearch();
            RefreshMovieList();
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

