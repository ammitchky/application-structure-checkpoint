using System;
using FluentAssertions;

namespace application_structure_checkpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var example = new exampleClass();
            example.additionMethod();
        }

        public class exampleClass {
            public void additionMethod() {
                var first = 3;
                var second = 7;
                var result = first + second;

                result.Should().Be(10);
            }
        }
    }
}
