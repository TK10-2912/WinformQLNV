using QLNSMay10.ConnectSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNSMay10.Classes
{
    public class Session
    {
        private static Session _init=null;
        public static Session instance()
        {
            if (_init == null) { 
                _init= new Session();
            }
            return _init;
        }
        public User userLogin { get; set; }
        private Session() { }
        
        
    }
}
