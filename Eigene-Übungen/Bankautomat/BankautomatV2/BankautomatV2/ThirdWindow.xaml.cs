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

        public string Akontostand = "500";
        public string Akontoinhaber = "Hendrik Massel";
        
        public ThirdWindow()
        {

            
            InitializeComponent();
             
        }
       
        private void Kontoinformation_Click(object sender, RoutedEventArgs e)
        {
            MainWindow kontostandclass = new MainWindow
            {
                Kontostand = Akontostand

            };
            string inform = "Kontoinformation";
            MessageBox.Show(Akontoinhaber, inform);
            
        }

        private void Kontostand_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Kontostand {0}", Akontostand);
            MainWindow kontostandclass = new MainWindow
            {
                Kontostand = Akontostand
            };
            string index = "Kontostand: ";
            string kontoindex = "Dein Kontostand beträgt " + Akontostand + " €";
            MessageBox.Show(kontoindex,index);
        }

        private void Abmelden1_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();

            this.Close();
            secondWindow.Show();


        }

        public void ButtonEinzahlen_Click(object sender, RoutedEventArgs e)
        {
            string input;
            input = TextBoxEinzahlung.Text;
            int inputint = Int32.Parse(input);
            int kontostandint = Int32.Parse(Akontostand);
            char inputchar = 'a';
            

            if (inputint >= 1)
            {
                kontostandint += inputint;
            }
            else if (inputint == inputchar)
            {
                MessageBox.Show("ERROR keine Buchstaben");//geht noch nicht
            }
            else
            {
                MessageBox.Show("!!ERROR!!");
            }

            Akontostand = Convert.ToString(kontostandint);

            MainWindow kontostandclass = new MainWindow
            {
                Kontostand = Akontostand
            };
            

        }

        private void Button_ClickAuszahlen(object sender, RoutedEventArgs e)
        {
            string input;
            input = TextBoxAuszahlung.Text;
            int inputint = Int32.Parse(input);
            int kontostandint = Int32.Parse(Akontostand);


            if (inputint >= 1)
            {
                kontostandint -= inputint;
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            Akontostand = Convert.ToString(kontostandint);

            MainWindow kontostandclass = new MainWindow
            {
                Kontostand = Akontostand
            };
        }
    }
}
