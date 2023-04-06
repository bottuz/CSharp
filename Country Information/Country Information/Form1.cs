using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country_Information
{
    public partial class Form1 : Form
    {
        Country.CountryInfoServiceSoapTypeClient continenti = new Country.CountryInfoServiceSoapTypeClient("CountryInfoServiceSoap");
        Country.tContinent[] cont;
        Country.tCountryCodeAndNameGroupedByContinent[] paesi;
        
        public Form1()
        {
            InitializeComponent();
            lbPaesi.Hide();
            cont = continenti.ListOfContinentsByCode();
            paesi = continenti.ListOfCountryNamesGroupedByContinent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int i;
                for (i = 0; i < cont.Length; i++) 
                { 
                    lbContinenti.Items.Add(cont[i].sCode.ToString() + " : " + cont[i].sName.ToString());
                }
            }
            catch (InvalidCastException)
            {
            };
        }

        private void lbContinenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbPaesi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbContinenti_Click(object sender, EventArgs e)
        {
            lbPaesi.Show();
            lbPaesi.Items.Clear();
            try
            {
                int i = 0;
                int j = 0;
                for (i = 0; i < paesi.Length; i++)
                {
                    if (paesi[i].Continent.sCode.ToString() == lbContinenti.SelectedItem.ToString().Substring(0, 2))
                        for(j=0;j<paesi[i].CountryCodeAndNames.Length;j++)
                            lbPaesi.Items.Add(paesi[i].CountryCodeAndNames[j].sISOCode + " : " + paesi[i].CountryCodeAndNames[j].sName);
                }
            }
            catch (InvalidCastException)
            {
            };
        }

        private void lbPaesi_Click(object sender, EventArgs e)
        {
            lbLingua.Text = "";
            if (lbPaesi.SelectedItem.ToString() != "")
            {
                string isoCode = continenti.CountryISOCode(lbPaesi.SelectedItem.ToString().Substring(5));
                string urlFlag = continenti.CountryFlag(isoCode);
                string capital = continenti.CapitalCity(isoCode);
                string prefisso = "+ " + continenti.CountryIntPhoneCode(isoCode);

                //string lingua = continenti.FullCountryInfo(isoCode).Languages.ToString();
                //lbLingua.Text = lingua;
                lbCapitale.Text = capital;
                pb1.ImageLocation = urlFlag;
                lbPrefisso.Text = prefisso;
                lbMoneta.Text = continenti.CountryCurrency(isoCode).sName;
                try
                {
                    lbLingua.Text += continenti.FullCountryInfo(isoCode).Languages[0].sName;
                    for (int i = 1; i < continenti.FullCountryInfo(isoCode).Languages.Length; i++)
                    {

                        lbLingua.Text += " - " + continenti.FullCountryInfo(isoCode).Languages[i].sName;
                    }
                }catch(Exception ex)
                {
                    lbLingua.Text = "They don't Speak!";
                };

            }
            else
            {

            }
        }

        private void lbPrefisso_Click(object sender, EventArgs e)
        {

        }
    }
}
