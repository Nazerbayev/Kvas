using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Kvas.ViewModels;
using Kvas.Core;
using MahApps.Metro.Controls.Dialogs;

namespace Kvas.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Principal : MetroWindow
    {
        public Principal(PrincipalViewModel model)
        {
            InitializeComponent();
            this.DataContext = model;

            //No es lo ideal pero es la mejor forma de ejecutar un metodo de MetroWindow desde el ViewModel y conservar la separacion de intereses
            model.MostrarDialogo += MostrarMensaje;
        }
        private async void MostrarMensaje(String titulo, String mensaje)
        {
            await this.ShowMessageAsync(titulo, mensaje);
        }
    }
}
