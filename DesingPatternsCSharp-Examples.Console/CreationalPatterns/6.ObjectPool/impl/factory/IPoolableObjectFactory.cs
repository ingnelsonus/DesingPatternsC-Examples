using objectpool.impl.poolable;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace objectpool.impl.factory{
    public interface IPoolableObjectFactory<T> {
        T CreateNew();
    }
} 