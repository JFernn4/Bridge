using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CanalEmail : Icanal
    {
        // Email devuelve TRUE
        public bool verificarDisponibilidad()
        {
            return true; 
        }

        public void recibirMsg(string destinatario, string mensaje)
        {
            Console.WriteLine($"Email recibido de: {destinatario}: \n {mensaje}");
        }

        public void enviarMsg(string destinatario, string mensaje)
        {
            if (verificarDisponibilidad())
                Console.WriteLine($"EMAIL a {destinatario}: {mensaje}");
            else
                throw new InvalidOperationException("(fallo en Email)");
        }
    }
    class CanalSMS : Icanal
    {
        // SMS devuelve TRUE
        public bool verificarDisponibilidad()
        {
            return true; 
        }

        public void recibirMsg(string destinatario, string mensaje)
        {
            Console.WriteLine($"Tu SMS informa que el numero {destinatario} te ha enviado el siguiente mensaje: \n {mensaje}");
        }

        public void enviarMsg(string destinatario, string mensaje)
        {
            if (verificarDisponibilidad())
                Console.WriteLine($"SMS a {destinatario}: {mensaje}");
            else
                throw new InvalidOperationException("(fallo en SMS)");
        }
    }

    class CanalWhatsApp : Icanal
    {
        // WhatsApp devuelve FALSE (como solicitaste)
        public bool verificarDisponibilidad()
        {
            return false; 
        }

        public void recibirMsg(string destinatario, string mensaje)
        {
            Console.WriteLine($"WHATSAPP para {destinatario}, has recibido: \n{mensaje}");
        }

        public void enviarMsg(string destinatario, string mensaje)
        {
            // Usamos el método de verificación para decidir qué hacer
            if (verificarDisponibilidad())
            {
                Console.WriteLine($"WHATSAPP a {destinatario}: {mensaje}");
            }
            else
            {
                // Si es false, lanza el error exacto que pide la imagen
                throw new InvalidOperationException("(fallo señalado según el contrato)");
            }
        }
    }
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