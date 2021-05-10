using System;


namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var variable = MyClass<int>.FacrotyMethod(5);
            Console.WriteLine(variable);
            var variable1 = MyClass<string>.FacrotyMethod("Hello World");
            Console.WriteLine(variable1);
            var variable2 = MyClass<Program>.FacrotyMethod(new Program());
            Console.WriteLine(variable2);
            Console.ReadKey();
        }

    }
       
}
