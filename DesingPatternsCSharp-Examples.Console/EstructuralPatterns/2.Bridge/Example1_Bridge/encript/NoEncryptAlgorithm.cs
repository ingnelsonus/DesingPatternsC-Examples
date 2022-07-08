/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace bridge.encript{
    public class NoEncryptAlgorithm : IEncryptAlgorithm{
        public string Encrypt(string message, string password)  {
            return message;
        }
    }
}