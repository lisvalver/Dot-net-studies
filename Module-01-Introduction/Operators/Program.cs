using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic operators and variable declarations

            string firstName;
            firstName = "Lisvalver";

            string lastName = "Lopes";
            int age = 28;
            bool isStudent = true;

            Console.WriteLine($"Hello {firstName} {lastName}!");

            var sum = 2 + 3;
            var subtraction = 10 - 3;
            var multiplication = 3 * 3;
            var division = 15 / 3;
            var module = 5 % 2;

            Console.WriteLine($"Sum result {sum}");
            Console.WriteLine($"Subtraction result {subtraction}");
            Console.WriteLine($"Multiplication {multiplication}");
            Console.WriteLine($"Division result {division}");
            Console.WriteLine($"Module result {module}");


            // Logical operators

            // Truth table
            var isTrue = true && true;
            var isFalse1 = true && false;
            var isFalse2 = false && true;
            var isFalse3 = false && false;

            var orTrue1 = true || true;
            var orTrue2 = true || false;
            var orTrue3 = false || true;
            var orFalse = false || false;

            Console.WriteLine($"true && true = {isTrue}");
            Console.WriteLine($"true && false = {isFalse1}");
            Console.WriteLine($"false && true = {isFalse2}");
            Console.WriteLine($"false && false = {isFalse3}");

            Console.WriteLine($"true || true = {orTrue1}");
            Console.WriteLine($"true || false = {orTrue2}");
            Console.WriteLine($"false || true = {orTrue3}");
            Console.WriteLine($"false || falsee = {orFalse}");

            // Negation operator
            var notFalse = !orFalse;
            var notTrue = !orTrue1;

            Console.WriteLine($"It is not false: {notFalse}");
            Console.WriteLine($"It is not true: {notTrue}");

        }
    }
}
