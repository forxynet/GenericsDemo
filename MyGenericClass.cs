using System;

namespace GenericsDemo {
    public class MyGenericClass<T> {
        //generic variable
        //type fate type is generic

        private T genericMemberVariable;
        public MyGenericClass(T value) {
            genericMemberVariable = value;
        }

        //generic method
        //method accept one generic type paramater
        //method return type also generic
        public T genericMethod(T generekParamater) {
            Console.WriteLine($"Parameter type {typeof(T)} value {generekParamater}");
            Console.WriteLine($"Retun type {typeof(T)} value {genericMemberVariable}");
            return genericMemberVariable;
        }

        //generic property
        //the data type is generic
        public T genericProperty { get; set; }
    }
}
