/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace proxy.impl{
    public class ServiceFactory {
        
        public static IProcessEjecutor CreateProcessEjecutor(){
            return new ProcessEjecutorProxy();
        }
    }
}


