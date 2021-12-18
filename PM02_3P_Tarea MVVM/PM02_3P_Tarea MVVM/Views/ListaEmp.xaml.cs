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
    public partial class ListaEmp : ContentPage
    {
        public ListaEmp()
        {
            InitializeComponent();
            LlenarDatos();
        }

        private async void lstdatos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.Empleado item = (Models.Empleado)e.Item;

            var page = new Modificar();
            page.BindingContext = item;
            await Navigation.PushAsync(page);
        }

        public async void LlenarDatos()
        {
            var personlist = await App.SQLiteDB.GetPersonasAync();
            if (personlist != null)
            {
                lstdatos.ItemsSource = personlist;
            }
            else
            {

            }
        }

    }
}