using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ICanal
    {
        void Enviar(string destinatario, string mensaje);
    }
}