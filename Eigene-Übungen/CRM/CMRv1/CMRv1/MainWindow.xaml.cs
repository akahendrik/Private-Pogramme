using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace CMRv1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string safename = "CRM";
        private readonly string safepasswort = "0";

        private string name;
        private string passwort;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Abfrage vom eingegebenen Name
            name = name_box.Text;

            //Abfrage vom eingegebenen Passwort
            passwort = passwort_box.Password;

            SecondWindow secondwindow = new SecondWindow();
            



            //wenn Name und Passwort richtig dann weiterleitung zum nächsten Fenster
            if (name == safename && passwort == safepasswort)
            {
                this.Close();
                secondwindow.Show();
            }
            else
            {
                MessageBox.Show("Ungültige eingabe!");
            }
        }

        private void BeendenLogin_Click(object sender, RoutedEventArgs e)
        {
            //Abfrage beim Beenden des Programmes ob es wirklich geschlossen werden soll

            if (MessageBox.Show("Sicher?", "Programm beenden", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            //Funktioniert nicht
            else
            {
                //SecondWindow secondWindow = new SecondWindow();
                //secondWindow.Show();
            }

        }
    }
}
