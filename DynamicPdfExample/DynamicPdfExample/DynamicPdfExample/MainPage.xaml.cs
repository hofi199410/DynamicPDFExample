using ceTe.DynamicPDF.HtmlConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicPdfExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void printButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                byte[] pdfByteArray = Converter.Convert(new Uri("https://www.google.com"));
            }catch(Exception ex)
            {
                Debug.WriteLine("---------Bug---------");
                Debug.WriteLine("---------Message---------");
                Debug.WriteLine(ex.Message);

                Debug.WriteLine("---------Stacktrace---------");
                Debug.WriteLine(ex.StackTrace);
            }
        }
    }
}
