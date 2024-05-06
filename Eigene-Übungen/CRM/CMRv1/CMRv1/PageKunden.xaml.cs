using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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

        public void BtnShowKunden_Click(object sender, RoutedEventArgs e)
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Hendrik\Documents\CRM\Kundendaten");

            FileInfo[] fileInfos = directoryInfo.GetFiles();
            
            foreach (FileInfo file in fileInfos) 
            {
                ComboBoxKunden.SelectedItem.ToString();
                
            }

            ThirdWindow thirdwindow = new ThirdWindow();
            thirdwindow.Show();

           
           
            
        }
        public string ComboBoxReturn()
        {
            return ComboBoxKunden.SelectedItem as string;
        }



        private void LoadFilesFromFolder(string kundenpath)
        {

            string[] files = Directory.GetFiles(kundenpath);

            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                ComboBoxKunden.Items.Add(fileName);
            }
            
        }

        

            




        
    }
}
