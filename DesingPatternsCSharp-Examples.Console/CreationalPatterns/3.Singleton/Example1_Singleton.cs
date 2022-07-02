using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace Singleton
{
    internal class Example1_Singleton
    {
        public void Run()
        {
            Usuario usuario = new Usuario();
            usuario.UserName = "prueba";
            usuario.Password = "123";

            try
            {
                SessionManager.Login(usuario);
                SessionManager sess = SessionManager.GetInstance;

                //Solo con esto Borramos la Instancia.
                SessionManager.Logout();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
