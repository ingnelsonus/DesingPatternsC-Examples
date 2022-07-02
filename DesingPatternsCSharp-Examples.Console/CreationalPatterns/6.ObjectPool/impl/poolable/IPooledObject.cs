/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace objectpool.impl.poolable{
    public interface IPooledObject {
        bool Validate();
        void Invalidate();
    }
} 