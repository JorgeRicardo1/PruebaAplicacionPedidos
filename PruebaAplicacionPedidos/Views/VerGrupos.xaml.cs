using PruebaAplicacionPedidos.VIewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaAplicacionPedidos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerGrupos : ContentView
    {
        public VerGrupos()
        {
            InitializeComponent();

        }

        

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as ViewModelVerGrupo;
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                lstGrupos.ItemsSource = _container.LstmodelGrupos;
            }
            else
            {
                lstGrupos.ItemsSource = _container.LstmodelGrupos.Where(i => i.nombre== e.NewTextValue);
            }
        }
    }
}