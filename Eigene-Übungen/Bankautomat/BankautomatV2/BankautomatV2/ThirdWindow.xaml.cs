using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
             ThirdWindow thirdWindow = new ThirdWindow();
        }

        private void Kontoinformation_Click(object sender, RoutedEventArgs e)
        {
            MainWindow kontostandclass = new MainWindow();
            kontostandclass.Kontostand = Akontostand;
            MessageBox.Show(Akontoinhaber);
            
        }

        private void Kontostand_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Kontostand {0}", Akontostand);
            MainWindow kontostandclass = new MainWindow();
            kontostandclass.Kontostand = Akontostand;
            MessageBox.Show(Akontostand);
        }

        private void abmelden1_Click(object sender, RoutedEventArgs e)
        {
            bool fensterAuf = true;
            ThirdWindow thirdWindow = new ThirdWindow();
            SecondWindow secondWindow = new SecondWindow();

            secondWindow.Show();

            if (fensterAuf)
            {
                thirdWindow.Close();
            }
            else
            {
                fensterAuf = false;
            }

            if (fensterAuf == false)
            {
                secondWindow.Show();
            }

            
        }
    }
    

}
