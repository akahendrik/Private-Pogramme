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
using System.Windows.Shapes;

namespace BankautomatV2
{
    /// <summary>
    /// Interaktionslogik für ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {

        private string Akontostand = "500";
        private string Akontoinhaber = "Hendrik Massel";
        
        public ThirdWindow()
        {

            
            InitializeComponent();

        }

        private void Kontoinformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kontoinhaber {0}",Akontoinhaber);
            MessageBox.Show("Kontostand {0}", Akontostand);
        }

        private void Kontostand_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Kontostand {0}", Akontostand);
            MainWindow myKlasse = new MainWindow();
            myKlasse.Kontostand = Akontostand;
            MessageBox.Show(Akontostand);
        }

        private void abmelden1_Click(object sender, RoutedEventArgs e)
        {
            
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();
            ThirdWindow thirdWindow = new ThirdWindow();
            thirdWindow.Close();
        }test
    }kfgkjj
    

}fkhjfkh
