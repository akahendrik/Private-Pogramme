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
            MessageBox.Show(Akontoinhaber);
            
        }

        private void Kontostand_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Kontostand {0}", Akontostand);
            MainWindow kontostandclass = new MainWindow
            {
                Kontostand = Akontostand
            };
            //test für die anordnung eines fensters wie kopfzeile und index 
            MessageBox.Show("Kontostandfenster",Akontostand);
        }

        private void Abmelden1_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();

            this.Close();
            secondWindow.Show();


        }
    }
    

}
