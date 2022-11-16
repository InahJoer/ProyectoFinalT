using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoFinalT
{
    internal class archivos : Usuarios
    {
        public List<Usuarios> usuarios = new List<Usuarios>();
        private string DBFile;

        public void CargarDatos(string pfile)
        {
            DBFile = pfile;
            string[] lineas = File.ReadAllLines(pfile);
            foreach (string linea in lineas)
            {
                Usuarios user = JsonSerializer.Deserialize<Usuarios>(linea);
                usuarios.Add(user);
            }
        }

        public Usuarios BuscarUsuario(Usuarios pUser)
        {
            Usuarios vacio = new Usuarios();
            foreach (Usuarios user in usuarios)
            {
                if (user.cedula == pUser.cedula || user.Usuarioname == pUser.Usuarioname)
                {
                    return user;
                }
            }
            return vacio;
        }

        private void GuardarDatos()
        {
            using (StreamWriter fs = new StreamWriter(DBFile))
            {
                foreach (Usuarios user in usuarios)
                {
                    string line = JsonSerializer.Serialize(user);
                    fs.WriteLine(line);
                }
                fs.Close();
            }
        }

        public bool AgregarUsuario(string pPass, string pUsername, string pDocucel, double pSaldo, double pPuntos)
        {
            CargarDatos("OUTPUTS/users.txt");
            Usuarios user = new Usuarios
            {
                contrasena = pPass,
                Usuarioname = pUsername,
                cedula = pDocucel,
                saldo = pSaldo,
                puntos = pPuntos
            };
            Usuarios buscar = BuscarUsuario(user);
            if (buscar.Usuarioname == null || buscar.cedula == null)
            {
                usuarios.Add(user);
                GuardarDatos();
                Thread.Sleep(5000);
            }
            else
            {
                Thread.Sleep(5000);
                return false;
            }
            return true;
        }


        public Usuarios ValidarUsuario(string pPass, string pUsername)
        {
            Usuarios vacio = new Usuarios
            {
                contrasena = "",
                Usuarioname = "",
            };
            Usuarios user = new Usuarios
            {
                contrasena = pPass,
                Usuarioname = pUsername,
                saldo = saldo
            };
            if (BuscarUsuario(user).Usuarioname == pUsername && BuscarUsuario(user).contrasena == pPass)
            {
                return user;
            }
            return vacio;
        }

        public void ActualizarUsuario(Usuarios user)
        {
            usuarios.Remove(user);
            usuarios.Add(user);
            GuardarDatos();
        }
        public void EliminarUsuario()
        {

        }
        public string GuardarSaldo()
        {
            string Asaldo = saldo.ToString();
            return Asaldo;
        }


    }
}
