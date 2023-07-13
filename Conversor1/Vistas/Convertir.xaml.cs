using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;
        public Convertir()
        {
            InitializeComponent();
        }
        private void calcular()
        {
            cm =Convert.ToDouble(txtcm.Text);
            m = cm / 100;
            lblres.Text = m.ToString() + " m";
        }
        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtcm.Text))
            {
                calcular();

            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
    }
        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }

        private void btncalcular_Clicked_1(object sender, EventArgs e)
        {
            calcular();
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }
    }
}

