using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Notificacion
    {
        protected ICanal CanalActual;
        protected ICanal CanalRespaldo;

        protected Notificacion(ICanal canalPrincipal, ICanal canalRespaldo)
        {
            CanalActual = canalPrincipal;
            CanalRespaldo = canalRespaldo;
        }

        public virtual void Enviar(string destinatario, string mensaje)
        {
            try
            {
                CanalActual.Enviar(destinatario, mensaje);
            }
            catch (Exception)
            {
                // Si el canal actual falla y existe un respaldo diferente
                if (CanalRespaldo != null && CanalActual != CanalRespaldo)
                {
                    Console.WriteLine("canal no disponible, usando respaldo");

                    // desde ahora solo se usa el respaldo
                    CanalActual = CanalRespaldo;

                    // Reenvío inmediato por el nuevo canal
                    CanalActual.Enviar(destinatario, mensaje);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}