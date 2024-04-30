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

            //string filePath = @"C:\Users\Hendrik\Documents\CRM\Kundendaten\Kunde1.txt";
            //string importedText = File.ReadAllText(filePath);
            //txtImport.Text = importedText;

            //Pfad für PC
            //StreamReader kundensr = new StreamReader(@"C:\Users\Hendrik\Documents\CRM\Kundendaten\Kunde1.txt");
            //StreamWriter kundenSchreiben = new StreamWriter(@"C:\Users\Hendrik\Documents\CRM\Kundendaten\Kunde1.txt",false);

            //Pfad für Laptop
            StreamReader kundensr = new StreamReader(@"C:\Users\hendr\Documents\CRM\Kunde1.txt");
            //StreamWriter kundenSchreiben = new StreamWriter(@"C:\Users\hendr\Documents\CRM\Kunde1.txt", false);


            txtImport.Text = kundensr.ReadToEnd();
            //kundenSchreiben.Write(txtImport.Text);


            kundensr.Close();
        }


        



    }
}
