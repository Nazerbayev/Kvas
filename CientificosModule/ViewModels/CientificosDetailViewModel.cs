using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CientificosModule.Core.Objetos;
using CientificosModule.Eventos;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;

namespace CientificosModule.ViewModels
{
    public class CientificosDetailViewModel : INotifyPropertyChanged
    {
        private IUnityContainer container;
        private readonly IEventAggregator eventAggregator;
        public Cientifico Seleccionado { get; set; }

        public CientificosDetailViewModel(IUnityContainer container, IEventAggregator eventAggregator)
        {
            if (container == null) throw new ArgumentNullException("Falta el container");
            if (eventAggregator == null) throw new ArgumentNullException("Falta el agregador de eventos");
            this.eventAggregator = eventAggregator;
            this.container = container;

            this.eventAggregator.GetEvent<CientificoSeleccionadoEvent>().Subscribe(this.CientificoSeleccionado, true);
        }
        private void CientificoSeleccionado(Cientifico persona)
        {
            if (persona == null) return;
            this.Seleccionado = persona;
            this.NotifyPropertyChanged("Seleccionado");
        }






        #region Notificacion de cambio de Propiedades
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion


    }
}
