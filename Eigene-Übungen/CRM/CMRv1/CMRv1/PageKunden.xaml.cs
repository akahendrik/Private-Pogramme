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
using System.Xml.Linq;

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

            LoadFilesFromFolder(@"C:\Users\Hendrik\Documents\CRM\Kundendaten");

        }

        private void LoadFilesFromFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                ComboBoxKunden.Items.Add(fileName);
            }
            
        }

        private void ComboBoxKundenSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedFileName = ComboBoxKunden.SelectedItem.ToString();
            //string kunde1 = "Kunde1";
            //if (selectedFileName == kunde1)
            //{
            //    ThirdWindow thirdwindow = new ThirdWindow();
            //    thirdwindow.Show();
            //}
        }

        private void BtnShowKunden_Click(object sender, RoutedEventArgs e)
        {
            string selectedFileName = ComboBoxKunden.SelectedItem.ToString();
            string kunde1 = "Kunde1.txt";

            if (selectedFileName == kunde1)
            {
                ThirdWindow thirdwindow = new ThirdWindow();
                thirdwindow.Show();
            }
        }
    }
}
