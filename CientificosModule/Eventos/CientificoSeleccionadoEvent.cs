using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CientificosModule.Core.Objetos;
using Microsoft.Practices.Prism.PubSubEvents;

namespace CientificosModule.Eventos
{
    public class CientificoSeleccionadoEvent : PubSubEvent<Cientifico>
    {
    }
}
