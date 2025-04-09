using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    
    /*
     * sealed restricts the inheritance
     */
   public sealed class Singleton
    {
        private static int counter = 0;
       // private static readonly object obj = new object();
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                //double varification of null instance chcking is called double check locking
                //if (instance == null)//just remove this to get lazy loading
                //{
                //    lock (obj)
                //    {
                //        if (instance == null)
                //            instance = new Singleton();
                //    }
                //}
                    return instance.Value;
                }
            

        }
        /*
         * private constructor ensures that
         * object is not instantiated other than with in the class
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value "+counter.ToString());
        }
        /*
         * public propertyis used to return only one instance of the class
         * leveraging on the private property
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        
    }
}
