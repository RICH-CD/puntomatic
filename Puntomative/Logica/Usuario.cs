using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puntomative
{
    public class Usuario
    {
        private string _user;
        private string _password;

        public Usuario(string User, string Password) { _user = User; _password = Password; }

        public bool validateCredentials()
        {
            /*agrega logica de validacion de usuario */
            return true;
        }
    }
}
