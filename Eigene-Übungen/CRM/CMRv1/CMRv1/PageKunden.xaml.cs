using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaktionslogik für PageKunden.xaml
    /// </summary>
    public partial class PageKunden : Page
    {
        public PageKunden()
        {
            InitializeComponent();
        }

        private void LoadFileNames()
        {
            //ComboBoxItem selectetItem = new ComboBoxItem();

            string directoryPath = @"\C:\Users\Hendrik\Documents\CRM\Kundendaten\"; // Passe den Pfad zu dem Verzeichnis an, das die Dateien enthält
            string[] fileNames = Directory.GetFiles(directoryPath);

            foreach (string fileName in fileNames)
            {
                string name = System.IO.Path.GetFileName(fileName);
                ComboBoxKunden.Items.Add(name);
            }



            //string selectetValue = selectetItem.Content.ToString();
            //MessageBox.Show("Selectet Value :" + selectetValue);
        }







        //private void BtnInputKunden_Click(object sender, RoutedEventArgs e)
        //{
        //    //geht

        //    StreamReader sr = new StreamReader(@"C:\Users\Hendrik\Documents\CRM\Kundendaten\Kunde1.txt");
        //    string input = sr.ReadToEnd();
        //    KundenLabel.Content = input;
        //    sr.Close();

        //}
    }
}
