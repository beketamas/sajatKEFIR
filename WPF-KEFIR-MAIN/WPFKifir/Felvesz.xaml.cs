//Barizs Márton Dániel
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFKifir
{
    /// <summary>
    /// Interaction logic for Felvesz.xaml
    /// </summary>
    public partial class Felvesz : Window
    {

        public bool hiba_omazon = false;
        public bool hiba_nev = false;
        public bool hiba_email = false;
        public bool hiba_ertcim = false;
        public bool hiba_matekpontszam = false;
        public bool hiba_magyarpontszam = false;

        public Felvesz()
        {
            InitializeComponent();
            //HelpGombok();
            SzuletesiAdatokComboBoxFeltoltes();
            btnFelvetel.Visibility = Visibility.Visible;
            btnmodosit.Visibility = Visibility.Hidden;

            btnFelvetel.Click += (s, e) =>
            {
                if (omazon.Text == "" || nev.Text == "" || email.Text == "" || ertcim.Text == "")
                    MessageBox.Show("Kérem írjon mindehova valamilyen adatot!");
                else
                {
                    if (hiba_omazon == true || hiba_nev == true || hiba_email == true || hiba_ertcim == true || hiba_matekpontszam == true || hiba_magyarpontszam == true)
                        MessageBox.Show("Az egyik megadási mezőben (prossal jelezve) hiba van!");
                    else
                    {
                        Diak ujFelvetelizo = new ($"{omazon.Text};{nev.Text.Trim()};{email.Text};{szulevEV.Text + "-" + szulevHONAP.Text + "-" + szulevNAP.Text};{ertcim.Text};{matekpontok.Text};{magyarpontok.Text}");
                        MainWindow mainWindow = new (ujFelvetelizo);
                    }
                    
                }
               
            };
            
        }
        public Felvesz( Diak kivalasztottDiak)
        {
            InitializeComponent();
            btnFelvetel.Visibility = Visibility.Hidden;
            btnmodosit.Visibility = Visibility.Visible;
            ablakfejlec.Content = "Tanuló adatainak módosítása";
            SzuletesiAdatokComboBoxFeltoltes();
            omazon.Text = kivalasztottDiak.OM_Azonosito;
            omazon.IsEnabled = false;
            nev.Text = kivalasztottDiak.Neve;
            email.Text = kivalasztottDiak.Email;
            ertcim.Text = kivalasztottDiak.ErtesitesiCime;
            matekpontok.Text = kivalasztottDiak.Matematika.ToString();
            magyarpontok.Text = kivalasztottDiak.Magyar.ToString();
            szulevEV.SelectedItem = kivalasztottDiak.SzuletesiDatum.Year.ToString();
            szulevHONAP.SelectedItem = int.Parse(kivalasztottDiak.SzuletesiDatum.Month.ToString()) < 10 ? $"0{kivalasztottDiak.SzuletesiDatum.Month}" : $"{kivalasztottDiak.SzuletesiDatum.Month}";
            szulevNAP.SelectedItem = int.Parse(kivalasztottDiak.SzuletesiDatum.Day.ToString()) < 10 ? $"0{kivalasztottDiak.SzuletesiDatum.Day}" : $"{kivalasztottDiak.SzuletesiDatum.Day}";
            btnmodosit.Click += (s, e) =>
            {
                kivalasztottDiak.OM_Azonosito = omazon.Text;
                kivalasztottDiak.Neve = nev.Text;
                kivalasztottDiak.Email = email.Text;
                kivalasztottDiak.ErtesitesiCime = ertcim.Text;
                kivalasztottDiak.Matematika = int.Parse(matekpontok.Text);
                kivalasztottDiak.Magyar = int.Parse(magyarpontok.Text);
                kivalasztottDiak.SzuletesiDatum = DateTime.Parse($"{szulevEV.SelectedItem}-{szulevHONAP.SelectedItem}-{szulevNAP.SelectedItem}");
                this.Close();
            };
        }
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void SzuletesiAdatokComboBoxFeltoltes()
        {
            
            for (int i = 1999; i < 2025; i++)
                szulevEV.Items.Add(i.ToString());
            szulevEV.SelectedIndex = 0;

            for (int i = 1; i < 13; i++)
            {
                if (i < 10)
                    szulevHONAP.Items.Add("0" + i.ToString());
                else
                    szulevHONAP.Items.Add(i.ToString());
            }
            szulevHONAP.SelectedIndex = 0;

            
        }


        private void matekpontok_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(matekpontok.Text))
            {
                hiba_matekpontszam = true;
                matekpontok.Text = "-1";
                hiba_matekpontszam = false;
                matekpontok.BorderBrush = Brushes.LightGreen;
                matekpontok.BorderThickness = new Thickness(3);
            }
            else
            {
                if (int.Parse(matekpontok.Text) > 50 || int.Parse(matekpontok.Text) < -1)
                {
                    hiba_matekpontszam = true;
                    MessageBox.Show("Nem adhat meg ilyen matematika pontszámot! A pontszámnak 0 és 50 között kell lennie!!");
                    matekpontok.BorderBrush = Brushes.Red;
                    matekpontok.BorderThickness = new Thickness(3);
                }
                else
                {
                    hiba_matekpontszam = false;
                    matekpontok.BorderBrush = Brushes.LightGreen;
                    matekpontok.BorderThickness = new Thickness(3);
                }   
            }
        }

        private void magyarpontok_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(magyarpontok.Text))
            {
                hiba_magyarpontszam = true;
                magyarpontok.Text = "-1";
                hiba_magyarpontszam = false;
                hiba_matekpontszam = false;
                magyarpontok.BorderBrush = Brushes.LightGreen;
                magyarpontok.BorderThickness = new Thickness(3);
            }
            else
            {
                if (int.Parse(magyarpontok.Text) > 50 || int.Parse(magyarpontok.Text) < -1)
                {
                    hiba_magyarpontszam = true;
                    MessageBox.Show("Nem adhat meg ilyen matematika pontszámot! A pontszámnak 0 és 50 között kell lennie!!");
                    magyarpontok.BorderBrush = Brushes.Red;
                    magyarpontok.BorderThickness = new Thickness(3);
                }
                else
                {
                    hiba_magyarpontszam = false;
                    magyarpontok.BorderBrush = Brushes.LightGreen;
                    magyarpontok.BorderThickness = new Thickness(3);
                }
            }
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e) => this.WindowState = WindowState.Minimized;

        private void ButtonWindowState_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
                this.WindowState = WindowState.Maximized;
            else
                this.WindowState = WindowState.Normal;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e) => this.Close();


        private void szulevHONAP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            szulevNAP.Items.Clear();
            int honapNapszama = 31;

            if ((szulevHONAP.SelectedIndex + 1) % 2 == 0)
                honapNapszama = 30;
            if (szulevHONAP.SelectedIndex + 1 == 2)
                honapNapszama = 28;
            for (int i = 1; i < honapNapszama + 1; i++)
            {
                if (i < 10)
                    szulevNAP.Items.Add("0" + i.ToString());
                else
                    szulevNAP.Items.Add(i.ToString());
            }
            szulevNAP.SelectedIndex = 0;
        }


        private void omazon_LostFocus(object sender, RoutedEventArgs e)
        {
            var hibaUzenet = (string szoveg) =>
            {
                hiba_nev = true;
                MessageBox.Show(szoveg);
                nev.BorderBrush = Brushes.Red;
                nev.BorderThickness = new Thickness(3);
            };
            string input = omazon.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                hibaUzenet("Kérem, hogy ne hadja üresen az om azonosito mezot!");
            }
            else
            {
                if (input.Length != 11)
                {
                    hibaUzenet("Kérem, hogy a teljes om azonositot adja meg! (11 karakter)");
                }
                else
                {
                    hiba_omazon = false;
                    omazon.BorderBrush = Brushes.LightGreen;
                    omazon.BorderThickness = new Thickness(3);
                }
            }
            
        }

        private void nev_LostFocus(object sender, RoutedEventArgs e)
        {
            var hibaUzenet = (string szoveg) =>
            {
                hiba_nev = true;
                MessageBox.Show(szoveg);
                nev.BorderBrush = Brushes.Red;
                nev.BorderThickness = new Thickness(3);
            };
            if (string.IsNullOrWhiteSpace(nev.Text))
            {
                hibaUzenet("Ne hadja üresen a névmegadás mezőt!");
            }
            else
            {
                if (!nev.Text.Trim().Contains(" "))
                {
                    hibaUzenet("Kérem, hogy adja meg a teljes nevét!");
                }
                else
                {

                    if (Regex.IsMatch(nev.Text, @"\s{2,}"))
                    {
                        hibaUzenet("Kérem, hogy ne legyen 1nél több space egymás mellett!");
                    }
                    else
                    {
                        foreach (var item in nev.Text.Trim().ToString().Split())
                        {
                            if (char.IsLower(item[0]))
                            {
                                hibaUzenet("Kérem, hogy a nevek nagy betűvel kezdődjenek!");
                                break;
                            }
                            else
                            {
                                hiba_nev = false;
                                nev.BorderBrush = Brushes.LightGreen;
                                nev.BorderThickness = new Thickness(3);
                            }

                        }
                    }

                }
            } 
        }

        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            var hibaUzenet = (string szoveg) =>
            {
                hiba_email = true;
                MessageBox.Show(szoveg);
                nev.BorderBrush = Brushes.Red;
                nev.BorderThickness = new Thickness(3);
            };
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                hibaUzenet("Ne legyen üres az emial megadó mező!");
            }
            else
            {
                if (email.Text.Contains(" "))
                {
                    hibaUzenet("Nem lehet szóköz az emailben!");
                }
                else
                {
                    if (email.Text.ToString().Count(x => x == '@') > 1 || !email.Text.ToString().Contains('@'))
                    {
                        hibaUzenet("Az emailben lennie kell legalább egy @-nak!");
                    }

                    else
                    {
                        if (/*email.Text.ToString().Count(x => x == '.') > 1 ||*/ !email.Text.ToString().Contains('.'))
                        {
                            hibaUzenet("Az emailben lennie kell legalább egy pontnak!");
                        }

                        else
                        {
                            hiba_email = false;
                            email.BorderBrush = Brushes.LightGreen;
                            email.BorderThickness = new Thickness(3);
                        }
                    }

                }

            }
        }

        private void ertcim_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ertcim.Text))
            {
                hiba_ertcim = true;
                MessageBox.Show("Ne hadja üresen az értesítési címet!");
                ertcim.BorderBrush = Brushes.Red;
                ertcim.BorderThickness = new Thickness(3);
            }
            else
            {
                hiba_ertcim = false;
                ertcim.BorderBrush = Brushes.LightGreen;
                ertcim.BorderThickness = new Thickness(3);
            }
        }
    }
}
