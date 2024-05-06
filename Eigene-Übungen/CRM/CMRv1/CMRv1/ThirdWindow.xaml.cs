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
        public ThirdWindow()
        {
            InitializeComponent();
            //DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Hendrik\Documents\CRM\Kundendaten");
            //StreamReader  readerKunden = new StreamReader(@"C:\Users\Hendrik\Documents\CRM\Kundendaten");



            //txtImport.Text = kundenreader.ReadToEnd();
            //kundenSchreiben.Write(txtImport.Text);
            //kundenreader.Close();
            LoadFilesFromFolder(@"C:\Users\Hendrik\Documents\CRM\Kundendaten\");
        }


        private void LoadFilesFromFolder(string kundenpath)
        {
            PageKunden pageKundenHilfe = new PageKunden();
            string fileConent = pageKundenHilfe.ComboBoxKunden.SelectedItem as string;
            


            string[] files = Directory.GetFiles(kundenpath);

            foreach (string file in files)
            {
                if (fileConent == file)
                {
                    StreamReader readerKunden = new StreamReader(kundenpath) ; //<- muss geändert werden
                    txtImport.Text = readerKunden.ReadToEnd();
                    readerKunden.Close();
                }
            }
            

           
            
            

        }


        private void BtnÜberschreiben_Click(object sender, RoutedEventArgs e)
        {

             //StreamWriter kundenSchreiben = new StreamWriter(@"C:\Users\Hendrik\Documents\CRM\Kundendaten\");



             //kundenSchreiben.Write(txtImport.Text);

             //kundenSchreiben.Close();
            
             //this.Close();
        }
    }
}
