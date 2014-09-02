using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using CientificosModule.Core.Objetos;
using CientificosModule.Eventos;
using CientificosModule.Servicios;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;

namespace CientificosModule.ViewModels
{
    public class CientificosListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IEventAggregator eventAggregator;
        private IUnityContainer container;
        public ICommand SendMessage { get; set; }
        public ICommand OpenFlyout { get; set; }
        public ICollectionView Cientificos { get; private set; }
        private Cientificos _listado;

        public CientificosListViewModel(IUnityContainer container, ICientificosDataService dataService, IEventAggregator eventAggregator)
        {
            if (dataService == null) throw new ArgumentNullException("Falta el data Service");
            if (eventAggregator == null) throw new ArgumentNullException("Falta el agregador de Eventos");
            if (container == null) throw new ArgumentNullException("Falta el contenedor de DI");
            this.eventAggregator = eventAggregator;
            this.container = container;

            _listado = dataService.obtenerCientificos();
            this.Cientificos = new ListCollectionView(_listado);

            this.Cientificos.CurrentChanged += new EventHandler(this.SeleccionCientificoChanged);

            SendMessage = new DelegateCommand<String>(SendMessageExecute, SendMessageCanExecute);
            OpenFlyout = new DelegateCommand(OpenFlyoutExecute);
        }
        private void OpenFlyoutExecute()
        {
            this.eventAggregator.GetEvent<FlyOutEvent>().Publish("GO");
        }
        private void SendMessageExecute(String argumento)
        {

            var serializador = container.Resolve<ISerializador>();
            if (serializador == null) throw new Exception("Error con el DI");
            serializador.SerializeObject<Cientificos>("salida.xml", _listado);
            
            this.eventAggregator.GetEvent<MessageDialogEvent>().Publish(new MessageDialogEventArgs() { Titulo="Exportar Lista de Cientificos", Mensaje="Se ha exportado la lista de Cientificos" });
        }
        private bool SendMessageCanExecute(String argumento)
        {
            return true;
        }



        private void SeleccionCientificoChanged(object sender, EventArgs e)
        {
            Cientifico cientifico = this.Cientificos.CurrentItem as Cientifico;
            if (cientifico != null)
            {
                this.eventAggregator.GetEvent<CientificoSeleccionadoEvent>().Publish(cientifico);
            }
        }

        #region PropertyChanged Events

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
