using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS3VargasCristian9B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina_inicial : ContentPage
    {
        public Pagina_inicial(string user, string password)
        {
            InitializeComponent();

            
        }
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double datoUno = Convert.ToDouble(txtDatoUno.Text);
                double datoDos = Convert.ToDouble(txtDatoDos.Text);
                double datoTres = Convert.ToDouble(txtDatoTres.Text);
                double datoCuatro = Convert.ToDouble(txtDatoCuatro.Text);
                double dato1 = datoUno * 30 / 100;
                double dato2 = datoDos * 20 / 100;
                double dato3 = datoTres * 30 / 100;
                double dato4 = datoCuatro * 20 / 100;
                double promedio = dato1 + dato2;
                double calculo = dato3 + dato4;
                double final = promedio + calculo;
                txtResultado.Text = promedio.ToString();
                txtCalculo.Text = calculo.ToString();


                string resultado = "";
                if (promedio + calculo >= 7)
                {
                    resultado = "APROBADO";
                }
                else if (promedio + calculo <= 6.9)
                {
                    resultado = "REPROBADO";
                }
                else if (dato1 > 10)
                {
                    resultado = "Error Nota /10";
                }
                DisplayAlert("SU NOTA FINAL ES:" + final + "", resultado, "ACEPTAR");
            }

            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "cerrar");
            }
        }
    }
}