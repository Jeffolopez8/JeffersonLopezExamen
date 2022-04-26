using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JeffersonLopezExamen
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double cuota = 0;
        double totalapagar = 0;

        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario conectado: "+usuario;           
        }

        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            double monto = Convert.ToDouble(txtMonto.Text);

            if (monto <= 0 || monto > 1800)
            {
                DisplayAlert("Error", "El monto debe estar entre $1 y $1800", "salir");
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtMonto.Text);

            if (monto <1 || monto > 1800)
            {
                DisplayAlert("Error", "El monto debe estar entre $1 y $1800", "salir");
            }

            else
            {
                double saldo = (1800 - monto);
                cuota = (saldo / 3)+((1800*0.05));
                totalapagar = monto+(cuota * 3);


               txtpagomensual.Text=cuota.ToString();    

            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {


            if (txtNombre.Text.Length > 0)
            {
                await Navigation.PushAsync(new Resumen(lblUsuario.Text,txtNombre.Text,totalapagar));

            }
           else
            {
                await DisplayAlert("Error", "Debe ingresar un Nombre", "salir");

            }
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}