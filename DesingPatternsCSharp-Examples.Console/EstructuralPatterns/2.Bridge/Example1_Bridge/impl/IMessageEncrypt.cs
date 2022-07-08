/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace bridge.impl{
    public interface IMessageEncrypt {
        string EncryptMessage(string message, string password);
    }
}