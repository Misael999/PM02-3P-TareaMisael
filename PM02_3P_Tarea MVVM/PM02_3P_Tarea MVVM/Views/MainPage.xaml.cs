using PM02_3P_Tarea_MVVM.Models;
using PM02_3P_Tarea_MVVM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM02_3P_Tarea_MVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btnguardar_Clicked(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Empleado person = new Empleado
                {


                    nombre = txtnombre.Text,
                    apellido = txtapellido.Text,
                    edad = Convert.ToInt32(txtedad.Text),
                    direccion = txtdireccion.Text,
                    puesto = txtpuesto.Text

                };
                await App.SQLiteDB.SavePersona(person);

                await DisplayAlert("Registro", "Datos agregados de manera correcta", "ok");
                await Navigation.PushAsync(new ListaEmp());
            }
            else
            {
                await DisplayAlert("Advertencia", "Ingresar todos los datos", "ok");
            }
        }


        public bool ValidarDatos()
        {
            bool respuesta;

            if (String.IsNullOrEmpty(txtnombre.Text))
            {
                respuesta = false;
            }

            else if (String.IsNullOrEmpty(txtapellido.Text))
            {
                respuesta = false;
            }
            else if (String.IsNullOrEmpty(txtedad.Text))
            {
                respuesta = false;
            }
            else if (String.IsNullOrEmpty(txtpuesto.Text))
            {
                respuesta = false;
            }
            else if (String.IsNullOrEmpty(txtdireccion.Text))
            {
                respuesta = false;
            }

            else
            {
                respuesta = true;
            }
            return respuesta;

        }

        private async void BtnLista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaEmp());
        }
    }
}
