using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaS3VargasCristian9B
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            if (txtUser.Text == "estudiante2021" && txtPassword.Text == "israel2021")
            {

               await  Navigation.PushAsync(new Pagina_inicial(user, password));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("ERROR", "Usuario o Contraseña Incorrecta", "Registrarse", "Cancelar"); 
            }

        }
    }

         
    }





   
    

