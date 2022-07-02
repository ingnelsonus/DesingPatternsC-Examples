using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SessionManager
    {
        
        private static SessionManager _session;

        private SessionManager()
        {
            
        }

        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        private static object _lock = new object();

        public static SessionManager GetInstance
        {
            get 
            {
                if(_session == null) throw new Exception("Session no iniciada");
                    //_session = new SessionManager();                 

                return _session;
            }
        }

        public static void Login(Usuario usuario)
        {
            lock(_lock)
            {
                if (_session == null)
                {
                    _session = new SessionManager();
                    _session.Usuario = usuario;
                    _session.FechaInicio = DateTime.Now;
                }
                else
                    throw new Exception("Session ya iniciada");
            }

        }

        public static void Logout()
        {
            if (_session != null)
                _session = null;
            else
                throw new Exception("Session ya iniciada");
        }

    }
}
