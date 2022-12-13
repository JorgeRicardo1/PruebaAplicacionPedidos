using PruebaAplicacionPedidos.Data;
using PruebaAplicacionPedidos.Models;
using PruebaAplicacionPedidos.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PruebaAplicacionPedidos.VIewsModels
{
    internal class ViewModelVerGrupo : BaseViewModel
    {
        #region VARIABLES
        List<ModelGrupo> _lstmodelGrupos;

        #endregion
        #region CONSTRUCTOR
        public ViewModelVerGrupo()
        {
            Mostrar();
        }
        #endregion
        #region OBJETOS
      
        public List<ModelGrupo> LstmodelGrupos
        {
            get { return _lstmodelGrupos; }
            set { SetValue(ref _lstmodelGrupos, value); }
        }
        #endregion
        #region PROCESPS
        public async Task obtenerCliente()
        {

        }

        public void Mostrar()
        {
            var f = new ServicesGrupo();
            _lstmodelGrupos = f.obtenerLista();
        }
        
        #endregion
        #region COMANDOS
        public ICommand obtenerClientecommand => new Command(async () => await obtenerCliente());
        public ICommand Mostrarcommand => new Command(Mostrar);
        #endregion
    }
}
