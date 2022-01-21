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
            static void Values(IEnumerable myCollection)
            {
                foreach (Object obj in myCollection)
                    Console.Write(obj);
                Console.WriteLine();
            }
            Values(operators);
            Values(numbers);    
            }
        }
    }
