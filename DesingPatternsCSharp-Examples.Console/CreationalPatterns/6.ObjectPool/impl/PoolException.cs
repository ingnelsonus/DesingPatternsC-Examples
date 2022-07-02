using System;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace objectpool.impl{
    public class PoolException : Exception {

        public PoolException(string message) : base(message)
        {
            
        }
    }
} 