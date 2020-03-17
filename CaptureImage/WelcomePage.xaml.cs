using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CaptureImage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public ImageSource src;
        public WelcomePage()
        {
            InitializeComponent();
            
          
            
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //your code here;

            img.Source = "a.png";
            img.Source = src;
        }

    }
}