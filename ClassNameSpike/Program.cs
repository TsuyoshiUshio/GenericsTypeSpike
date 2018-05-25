using System;

namespace ClassNameSpike
{
    public interface IClass
    {
        string Name { get; set; }
    }

    public abstract class BaseSomeClass : IClass
    {
        public string Name { get; set; }
        public abstract string Hello();
    }

    public class SomeClass : BaseSomeClass
    {
        public override string Hello()
        {
            return "Hello from SomeClass";
        }
    }
    public class GenericSome
    {
        public string HelloByNameOf<T>()
        {
            return $"Hello! The parameter is {nameof(T)}";
        }
        public string HelloByTypeOf<T>()
        {
            return $"Hello! The parameter is {typeof(T)}";
        }

        public string HelloByGetType<T>()
        {
            var type = typeof(T);
            return $"Hello! The parameter is {type.GetType()}";

        }

        public string HelloByNameAndNamespace<T>()
        {
            var type = typeof(T);
            return $"Hello! The parameter is Name: {type.Name} Namespace: {type.Namespace}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"nameof(\"SomeClass\"):" +
                $"{nameof(SomeClass)}");
            var gsome = new GenericSome();
            Console.WriteLine($"Generic method nameof: {gsome.HelloByNameOf<SomeClass>()}");
            Console.WriteLine($"Generic method typeof: {gsome.HelloByTypeOf<SomeClass>()}");
            Console.WriteLine($"Generic method GetType: {gsome.HelloByGetType<SomeClass>()}");
            Console.WriteLine($"Generic method GetType: {gsome.HelloByNameAndNamespace<SomeClass>()}");

            Console.ReadLine();
        }
    }
}
