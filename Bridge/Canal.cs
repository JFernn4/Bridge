using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ICanal
    {
        void recibirMsg(string destinatario, string mensaje);
        void enviarMsg(string destinatario, string mensaje);
        
        // NUEVO MÉTODO OBLIGATORIO EN LA INTERFAZ
        bool verificarDisponibilidad(); 
    }
}