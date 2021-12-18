using PM02_3P_Tarea_MVVM.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02_3P_Tarea_MVVM
{
    public partial class App : Application
    {

        static SQLiteHelper db;
        public App()
        {
            InitializeComponent();

            MainPage = MainPage = new NavigationPage(new MainPage());
        }

        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CPagos.db3"));
                }
                return db;
            }

        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
