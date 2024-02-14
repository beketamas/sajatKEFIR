//Beke Tamás
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace WPFKifir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly ObservableCollection<IFelvetelizo> listaDiakok = new ();
        readonly string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kifir;";
        MySqlConnection connection = new();
        public MainWindow(Diak jelentkezo) => listaDiakok.Add(jelentkezo);
        public MainWindow()
        {
            InitializeComponent();
            listaDiakok.Clear();
            dgTablazat.ItemsSource = listaDiakok;

            btnImport.Click += (s, e) =>
            {

                OpenFileDialog openFile = new();
                if (dgTablazat.Items.Count != 0 && MessageBox.Show("Felül akarja írni?", "?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    listaDiakok.Clear();
                if (openFile.ShowDialog() == true)  
                {
                    if (System.IO.Path.GetExtension(openFile.FileName).ToLower() == ".json")
                        JsonSerializer.Deserialize<List<Diak>>(File.ReadAllText(openFile.FileName)).ToList().ForEach(x => listaDiakok.Add(x));
                    else if (System.IO.Path.GetExtension(openFile.FileName).ToLower() == ".csv")
                        File.ReadAllLines(openFile.FileName).Skip(1).ToList().ForEach(x => listaDiakok.Add(new Diak(x)));
                    else
                        MessageBox.Show("Az állomány kiterjesztése nem megfelelő!");
                }

            };

            btnFelvetel.Click += (s, e) =>
            {
                Felvesz felvesz = new();
                felvesz.ShowDialog();
            };

            btnExport.Click += (s, e) =>
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Json files (*.json)|*.json";
                
                if (saveFileDialog.ShowDialog() == true)
                {
                    var fejlec = (string path, string text) =>
                    {
                        string content = File.ReadAllText(path);
                        content = text + "\n" + content;
                        File.WriteAllText(path, content);
                    };
                    switch (System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower())
                    {
                        case ".csv":
                            File.WriteAllLines(saveFileDialog.FileName, listaDiakok.Select(x => x.CSVSortAdVissza()));
                            fejlec(saveFileDialog.FileName, "azonosito;nev;email;szuletesi_ev;ertcim;matek_pontszam;magyar_pontszam");
                            break;
                        case ".json":
                            var opciok = new JsonSerializerOptions();
                            opciok.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                            opciok.WriteIndented = true;
                            string adatokSorai = JsonSerializer.Serialize(listaDiakok, opciok);
                            var lista = new List<String>();
                            lista.Add(adatokSorai);
                            File.WriteAllLines(saveFileDialog.FileName,lista);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            };

            btnTorol.Click += (s, e) => 
            {
                if (dgTablazat.SelectedIndex != -1)
                    foreach (var item in dgTablazat.SelectedItems.Cast<Diak>().ToList())
                        listaDiakok.Remove(item);
                else
                    MessageBox.Show("Nincs kiválasztva semmi a táblázatból!", "Súgó", MessageBoxButton.OK);
            };

            btnModosit.Click += (s, e) =>
            {
                Diak kivalasztottDiak;
                if (dgTablazat.SelectedItem is Diak && dgTablazat.SelectedItems.Count == 1)
                {
                    kivalasztottDiak = dgTablazat.SelectedItem as Diak;
                    Felvesz felvesz = new(kivalasztottDiak);
                    felvesz.ShowDialog();
                    dgTablazat.Items.Refresh();
                }
                else
                    MessageBox.Show("Nem megfelelő adatot választott ki, vagy nincs adat betöltve, vagy több adatot jelölt ki egyszerre");
            };

            btnAdatbazisExport.Click += (s, e) =>
            {
                try
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM diakok",connection);
                    cmd.ExecuteNonQuery();
                    listaDiakok.ToList().ForEach(x =>
                    {
                        MySqlCommand mySql = new MySqlCommand($"INSERT INTO diakok (OM_Azonosito,Neve,Email,SzuletesiDatum,ErtesitesiCime,Matematika,Magyar) VALUES ('{x.OM_Azonosito}', '{x.Neve}', '{x.Email}', " +
                            $"'{x.SzuletesiDatum.Year}-{x.SzuletesiDatum.Month}-{x.SzuletesiDatum.Day}'," +
                            $"'{x.ErtesitesiCime}', '{x.Matematika}', '{x.Magyar}')", connection);
                        mySql.ExecuteNonQuery();
                    });
                }
                catch (Exception m)
                {

                    MessageBox.Show(m.Message);
                }
                
            };

            btnAdatbazisImport.Click += (s, e) =>
            {
                try
                {
                    listaDiakok.Clear();
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM diakok", connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listaDiakok.Add(new Diak($"{reader.GetString(0)};{reader.GetString(1)};{reader.GetString(2)};{reader.GetDateTime(3)};{reader.GetString(4)};{reader.GetInt32(5)};{reader.GetInt32(6)}"));
                    }
                    reader.Close();
                }
                catch (Exception m)
                {

                    MessageBox.Show(m.Message);
                }

            };
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void ButtonWindowState_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
                this.WindowState = WindowState.Maximized;
            else
                this.WindowState = WindowState.Normal;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

        private void BtnKeszitok_Click(object sender, RoutedEventArgs e)
        {
            Keszitok keszitok = new();
            keszitok.ShowDialog();
        }
    }

}

