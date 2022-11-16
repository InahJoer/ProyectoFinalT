using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalT.Clases
{
    internal class Saldo12 : Usuarios
    {
        public double ObtenerSaldo(string pPass, string pUsername, string pDocucel, double pSaldo, double pPuntos)
        {
            archivos arch = new archivos();
            arch.CargarDatos("OUTPUTS/users.txt");
            Usuarios user = new Usuarios
            {
                contrasena = pPass,
                Usuarioname = pUsername,
                cedula = pDocucel,
                saldo = pSaldo,
                puntos = pPuntos
            };
            return saldo;
        }
    }
}
