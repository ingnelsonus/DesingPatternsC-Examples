
using objectpool.impl.poolable;

/**
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
namespace objectpool.impl.factory{
    public class ExecutorTaskFactory  : IPoolableObjectFactory<ExecutorTask>{
        public ExecutorTask CreateNew(){
            return new ExecutorTask();
        }
    }
} 