using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
   
   
        public sealed class SafeSingleton
        {
            //This variable value will be increment by 1 each time the object of the class is created
            private static int Counter = 0;

            //This variable is going to store the Singleton Instance
            private static SafeSingleton Instance = null;

            //To use the lock, we need to create one variable
            private static readonly object Instancelock = new object();

            //The following Static Method is going to return the Singleton Instance
            public static SafeSingleton GetInstance()
            {
                //This is thread-Safe
                if (Instance == null)
                {
                    //As long as one thread locks the resource, no other thread can access the resource
                    //As long as one thread enters into the Critical Section, 
                    //no other threads are allowed to enter the critical section
                    lock (Instancelock)
                    { //Critical Section Start
                        if (Instance == null)
                        {
                            Instance = new SafeSingleton();
                        }
                    } //Critical Section End
                      //Once the thread releases the lock, the other thread allows entering into the critical section
                      //But only one thread is allowed to enter the critical section
                }

                //Return the Singleton Instance
                return Instance;
            }

            private SafeSingleton()
            {
                //Each Time the Constructor is called, increment the Counter value by 1
                Counter++;
                Console.WriteLine("Counter Value " + Counter.ToString());
            }

            //The following method can be accessed from outside of the class by using the Singleton Instance
            public void PrintDetails(string message)
            {
                Console.WriteLine(message);
            }
        }
    
}
