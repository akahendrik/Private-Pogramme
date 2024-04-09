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
    /// Interaktionslogik für SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        

        private readonly string safename = "Hendrik";
        private readonly string safepasswort = "1234";

        private string name;
        private string passwort;


        public SecondWindow()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = name_box.Text;
            passwort = passwort_box.Password;

            if ( name == safename &&  passwort == safepasswort ) 
            {
                ThirdWindow thirdWindow = new ThirdWindow();
                this.Close();
                thirdWindow.Show();
            }
            else 
            {
                MessageBox.Show("Ungültige eingabe!");
            }
        }

        
    }
}
