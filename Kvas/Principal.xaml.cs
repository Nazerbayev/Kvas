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
using Kvas.Core.Objetos;
using MahApps.Metro.Controls;

namespace Kvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Principal
    {
        public Principal()
        {
            InitializeComponent();
            ProbandoItemsDummy();
        }
        private void ProbandoItemsDummy()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona() { Nombre = "Alfred R. Wallace",      Imagen = "/Resources/a.png", Merito = "Descubrió la Evolución por Selección Natural" });
            personas.Add(new Persona() { Nombre = "Gregor Mendel",          Imagen = "/Resources/g.png", Merito = "Fundador de la Genética" });
            personas.Add(new Persona() { Nombre = "Albert Einstein",        Imagen = "/Resources/a.png", Merito = "Preparaba un café bien sabroso" });
            personas.Add(new Persona() { Nombre = "Nikola Tesla",           Imagen = "/Resources/n.png", Merito = "Descubrió la Energía Alterna (AC)" });
            personas.Add(new Persona() { Nombre = "James Watt",             Imagen = "/Resources/j.png", Merito = "Padre de la revolución Industrial" });
            personas.Add(new Persona() { Nombre = "Stephanie Kwolek",       Imagen = "/Resources/s.png", Merito = "Inventó el Kevlar" });
            personas.Add(new Persona() { Nombre = "James Clerk Maxwell",    Imagen = "/Resources/j.png", Merito = "Unificó Magnetismo, Luz y Electricidad" });
            lbPersonas.ItemsSource = personas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ToggleFlyout(0);
            
        }
        private void ToggleFlyout(int index)
        {
            var flyout = this.Flyouts.Items[index] as Flyout;
            if (flyout == null)
            {
                return;
            }

            flyout.IsOpen = !flyout.IsOpen;
        }
    }
}
