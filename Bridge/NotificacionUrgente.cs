using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class NotificacionUrgente : Notificacion
    {
        public NotificacionUrgente(ICanal canalPrincipal, ICanal canalRespaldo)
            : base(canalPrincipal, canalRespaldo)
        {
        }
    }
}