using objectpool.impl.poolable;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace objectpool.impl{
    public interface IObjectPool<T> 
        where T: IPooledObject
    {
        T GetObject() ;
        void ReleaceObject(T pooledObject);
    }
} 