using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using objectpool.impl;
using objectpool.impl.factory;
using objectpool.impl.poolable;

namespace ObjectPool
{
    internal class Example1_ObjectPool
    {
        static readonly ExecutorThreadPool pool = new ExecutorThreadPool(2, 6, 1000 * 100, new ExecutorTaskFactory());

        public static void TaskThread()
        {
            try
            {
                ExecutorTask task = pool.GetObject();
                task.Execute();
                pool.ReleaceObject(task);
            }
            catch (PoolException e)
            {
                Console.WriteLine("Error ==> " + e.ToString());
            }
        }

        public void Run()
        {
            for (int c = 0; c < 10; c++)
            {
                ThreadStart childref = new ThreadStart(TaskThread);
                Console.WriteLine("In Main: Creating the Child thread");
                Thread childThread = new Thread(childref);
                childThread.Start();
            }

            try
            {
                //System.in.read();
                Console.ReadKey();
                Console.WriteLine(pool);
            }
            catch (Exception e)
            {
                Console.WriteLine("Out disponible " + e.ToString());
            }
        }


    }
}
