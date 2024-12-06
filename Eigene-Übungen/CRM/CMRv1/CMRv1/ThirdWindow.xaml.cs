using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CMRv1
{
    /// <summary>
    /// Interaktionslogik für ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        private readonly string selectedFilePath;

        public ThirdWindow()
        {

            InitializeComponent();
            ShowFilesFromFolder();


            FileStream fileStream = new FileStream(selectedFilePath, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
                
            string fileContent = streamReader.ReadToEnd();
            txtImport.Text = fileContent;
            fileStream.Close();
                
            
        }


        public string ShowFilesFromFolder()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFilePath = openFileDialog.FileName;
                //neuer test
                
                
            }
            return selectedFilePath;
        }



        public void BtnÜberschreiben_Click(object sender, RoutedEventArgs e)
        {


            string selectedFilePath = @"C:\Users\Hendrik\Documents\CRM\Kundendaten";

            ////FileStream fileStream = new FileStream(selectedFilePath,FileMode.OpenOrCreate);
            {
            StreamWriter streamWriter = new StreamWriter(selectedFilePath);
            streamWriter.WriteLine(txtImport.Text);
            streamWriter.Close();
            this.Close();
            }
        }
    }
}
