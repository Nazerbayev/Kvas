using CientificosModule.Eventos;
using Kvas.Core;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvas.ViewModels
{
    public class PrincipalViewModel : INotifyPropertyChanged
    {
        private IUnityContainer container;
        private readonly IEventAggregator eventAggregator;

        public event PropertyChangedEventHandler PropertyChanged;

        public event DialogoEventHandler MostrarDialogo;
        public delegate void DialogoEventHandler(String titulo, String mensaje);

        public Boolean FlyOutDesplegado { get; set; }

        public PrincipalViewModel(IUnityContainer container, IEventAggregator eventAggregator)
        {
            this.container = container;
            this.eventAggregator = eventAggregator;
            this.FlyOutDesplegado = false;
            
            this.eventAggregator.GetEvent<FlyOutEvent>().Subscribe(this.ToggleFlyout, true);
            this.eventAggregator.GetEvent<MessageDialogEvent>().Subscribe(this.ShowMessageDialog, true);
        }

        private void ToggleFlyout(String argumento)
        {
            FlyOutDesplegado = true;
            this.NotifyPropertyChanged("FlyOutDesplegado");
        }
        private void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private void ShowMessageDialog(MessageDialogEventArgs e)
        {
            MostrarDialogo(e.Titulo, e.Mensaje);
        }
        



        
    }
}
