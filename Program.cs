using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo {
    class Program {
        static void Main(string[] args) {
            //calculatewithgeneric();

            MyGenericClass<float> integerGenericClass = new MyGenericClass<float>(10.1f);
            var var = integerGenericClass.genericMethod(10.5f);
            Console.ReadKey();
        }

        private static void calculatewithgeneric() {
            int x = 10;
            int y = 10;

            bool IsEquel = ClsCalculator.AreEqual<double>(x, y);
            if (IsEquel) {
                Console.WriteLine("Both are Equel");
            }
            else {
                Console.WriteLine("Both are not Equal");
            }
        }

        public class ClsCalculator {
            public static bool AreEqual<T>(T x, T y) {
                return x.Equals(y);
            }      
        }
    }
}
