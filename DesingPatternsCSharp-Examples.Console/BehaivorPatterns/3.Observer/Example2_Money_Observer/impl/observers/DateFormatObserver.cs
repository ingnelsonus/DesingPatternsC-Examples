using observer.impl;
using System;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace observer.impl.observers{
    public class DateFormatObserver : IObserver{

        public void NotifyObserver(string command, Object source) {
            if(command.Equals("defaultDateFormat")){
                ConfigurationManager conf = (ConfigurationManager)source;
                Console.WriteLine("Observer ==> DateFormatObserver.dateFormatChange > " + DateTime.Now.ToString(conf.GetDefaultDateFormat()) );
            }
        }   
    }
}


