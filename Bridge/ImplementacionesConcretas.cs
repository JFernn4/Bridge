using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Canal funcional concreto
    public class CanalEmail : ICanal
    {
        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"[EMAIL] a {destinatario}: {mensaje}");
        }
    }

    // Canal falso que simula una falla constante (lanzando excepción)
    public class CanalFalsoFalla : ICanal
    {
        public void Enviar(string destinatario, string mensaje)
        {
            throw new Exception("Error de conexión con el proveedor del canal.");
        }
    }
}