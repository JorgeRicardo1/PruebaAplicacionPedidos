using PruebaAplicacionPedidos.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaAplicacionPedidos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View1();
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
