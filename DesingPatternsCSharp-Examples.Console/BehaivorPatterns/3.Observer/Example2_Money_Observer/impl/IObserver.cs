using System;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace observer.impl{
    public interface IObserver {
        
        void NotifyObserver(string command, Object source);
    }
}


