using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02_3P_Tarea_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modificar : ContentPage
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private async void BtnBorrar_Clicked(object sender, EventArgs e)
        {
            var person = new Models.Empleado
            {


                IdEmp = Convert.ToInt32(idSitio.Text),
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                direccion = txtdireccion.Text,
                puesto = txtpuesto.Text

            };
            if (await App.SQLiteDB.DropPersonaAsync(person) != 0)
            {
                await DisplayAlert("Registro", "Datos Borrados de manera correcta", "ok");
                await Navigation.PushAsync(new ListaEmp());

            }
            else
            {
                await DisplayAlert("Registro", "Ha ocurrido un problema", "ok");
            }
        }

        private async void Btnmodificar_Clicked(object sender, EventArgs e)
        {
            var person = new Models.Empleado
          {

             IdEmp = Convert.ToInt32(idSitio.Text),
              nombre = txtnombre.Text,
              apellido = txtapellido.Text,
              edad = Convert.ToInt32(txtedad.Text),
              direccion = txtdireccion.Text,
              puesto = txtpuesto.Text

          };
            if (await App.SQLiteDB.Grabarpersona(person) != 0)
            {
                await DisplayAlert("Registro", "Datos Modificados de manera correcta", "ok");
                await Navigation.PushAsync(new ListaEmp());

            }
            else
            {
                await DisplayAlert("Registro", "Ha ocurrido un problema", "ok");
            }
        }
    }
}