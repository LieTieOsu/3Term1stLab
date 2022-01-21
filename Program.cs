using System.Collections;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print your expression:");
            string expression = Console.ReadLine();

            Queue<char> numbers = new Queue<char>();
            Queue<char> operators = new Queue<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (Char.IsDigit(expression[i]))
                    numbers.Enqueue(expression[i]);
                else
                    operators.Enqueue(expression[i]);
            }
        }
    }
