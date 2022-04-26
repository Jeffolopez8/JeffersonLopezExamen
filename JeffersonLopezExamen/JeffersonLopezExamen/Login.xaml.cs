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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string contraseña = txtPass.Text;
          

            if (usuario == "jlopez" && contraseña=="jlopez8")
            {
                await Navigation.PushAsync(new Registro(usuario));
                
            }

            else
            {

                await DisplayAlert("Advertencia", "Usuario o contraseña incorrectos", "Salir");
                txtuser.Text = "";
                txtPass.Text = "";

               
            }
                   

        }
    }
}