using objectpool.impl.poolable;
using objectpool.impl.factory;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace objectpool.impl
{
    public class ExecutorThreadPool : AbstractObjectPool<ExecutorTask>{

        public ExecutorThreadPool(int minInstances, int maxInstances, int waitTime, IPoolableObjectFactory<ExecutorTask> poolableObjectFactory) 
            : base(minInstances, maxInstances, waitTime, poolableObjectFactory)
         {
            
        }
    }
} 