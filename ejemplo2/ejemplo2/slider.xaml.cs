using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejemplo2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class slider : ContentPage
    {
        public slider()
        {
            InitializeComponent();
        }


        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Numero:{0:F2}", e.NewValue);
        }
    }
}