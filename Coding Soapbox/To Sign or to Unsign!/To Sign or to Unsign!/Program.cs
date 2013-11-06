using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace To_Sign_or_to_Unsign_
{

        /// <summary>
        /// A wrapper for an Array.
        /// </summary>
        /// <typeparam name="T">The type of the Array.</typeparam>
        public class SomeArrayWrapper<T>
        {
            /// <summary>
            /// The backing array.
            /// </summary>
            protected T[] arr;

            /// <summary>
            /// The indexer to get elements within the array.
            /// </summary>
            /// <param name="passedIndex"></param>
            /// <returns></returns>
            public T this[uint passedIndex]
            {
                get { return this.arr[passedIndex]; }
                set { arr[passedIndex] = value; }
            }

            /// <summary>
            /// Initalize an Array of size X. X:passedCapacity.
            /// </summary>
            /// <param name="passedCapacity">The size of the array.</param>
            public SomeArrayWrapper(uint passedCapacity = 1)
            {
                this.arr = new T[passedCapacity];
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
            }

            public static void SomeArrayWrapperExample()
            {
                //Compile Time Problem
                //SomeArrayWrapper<int> intArrayWrapper = new SomeArrayWrapper<int>(-10);

                //No problem
                SomeArrayWrapper<int> intArrayWrapper = new SomeArrayWrapper<int>(10);

                //Compile Time Problem
                //Console.WriteLine(intArrayWrapper[-1]);

                //No Problem
                Console.WriteLine(intArrayWrapper[2]);
            }

            //Clear
            public static void ExplicitArgument(uint passedValue)
            {
            }

            //No Compile Time Problem
            public static void StreamExample()
            {
                Stream s = new MemoryStream();
                s.Position = -1;
            }

            //No Compile Time Problem
            public static void ArrayListExample()
            {
                //I am sorry for using one of the forbidden types in C#.
                ArrayList al = new ArrayList(-1);
            }

            //No Compile Time Problem
            public static void PrintBoolean(object passedObject)
            {
                bool b = (bool)passedObject;
                Console.WriteLine(b);
            }
        }
    }

