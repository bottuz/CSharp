using System;
using System.IO;
using System.Net;
using HtmlAgilityPack;

class Program
{
    static void Main(string[] args)
    {
        string url = "https://elearning15.unibg.it/course/view.php?id=3282";                  //INSERISCI LINK DI UN SITO
        string downloadFolder = @"C:\Users\botta\OneDrive\Desktop\Elettrotecnica\preparazioneESAME";       //SELEZIONA UN PERCORSO DOVE SALVARE I PDF

        // Invia una richiesta HTTP alla pagina web
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string htmlCode = reader.ReadToEnd();

        // Analizza il codice HTML della pagina web
        HtmlDocument htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(htmlCode);

        // Trova tutti i link che puntano a file PDF
        foreach (HtmlNode link in htmlDoc.DocumentNode.SelectNodes("//a[@href]"))
        {
            string href = link.GetAttributeValue("href", string.Empty);
            if (href.EndsWith(".pdf"))
            {
                // Scarica il file PDF e salvalo nella cartella desiderata
                using (WebClient client = new WebClient())
                {
                    string fileName = Path.GetFileName(href);
                    string filePath = Path.Combine(downloadFolder, fileName);
                    client.DownloadFile(href, filePath);
                }
            }
        }
    }
}

