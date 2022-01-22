using System.Globalization;
using Stack = Task.Stack;
using Queue = Task.Queue;


Console.Write(">");
var input = Console.ReadLine();
var tokens = Tokenizer(input);
var postfixTokens = ShuntingYard(tokens);
var result = Calculate(postfixTokens); 
Console.Write("<"); 
Console.WriteLine(result);

bool OperatorCheck(String element)
    {
        if (element == "+" || element == "-" || element == "/" || element == "*" || element == "x")
            return true;
        return false;
    }
    string UniteNumbers(Queue queue)
    {
        string result = "";
        while (!queue.IsEmpty())
        {
            result += queue.Dequeue();
        }
        return = result;
    } 
int Priority(string element)
    {
        if (element == "+" || element == "-")
        {
            return 0;
        }
        if (element == "*" || element == "/" || element == "x")
        {
            return 1;
        }
        return 2;
    }

Queue Tokenizer(string expression)
{
    var tokenized = new Queue();
    var num = new Queue();
      for (int index = 0; index < expression.Length; index++)
    {
        if (char.IsDigit(expression[index]) || expression[index] == ',')
        {
            num.Enqueue(expression[index].ToString());
        }
        else if (expression[index] == ' ')
        {
            if (!num.IsEmpty())
                tokenized.Enqueue(UniteNumbers(num));
        }
        else
        {
            if (!num.IsEmpty())
                tokenized.Enqueue(UniteNumbers(num));
            tokenized.Enqueue(expression[index].ToString());
        }
    }

    if (!num.IsEmpty())
        tokenized.Enqueue(UniteNumbers(num));
    
   return tokenized;
}


Queue ShuntingYard(Queue tokenized)
{
    var operatorStack = new Stack();
    var output = new Queue();
    while (!tokenized.IsEmpty())
    {
        var token = tokenized.Dequeue();
        bool checkIfNumber = double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
        if (checkIfNumber)
        {
            output.Enqueue(token);
        }
        else if (OperatorCheck(token))
        {
            while (!operatorStack.IsEmpty() && Priority(operatorStack.Pop()) > Priority(token))
            {

            }

            operatorStack.Push(token);
        }
    }
    while (!operatorStack.IsEmpty())
    {
        output.Enqueue(operatorStack.Get);
    }
  
  return output;
}

String Calculate(Queue postfixTokenQueue)
{
    var set = new Stack();
    while (!postfixTokenQueue.IsEmpty())
    {
        var token = postfixTokenQueue.Dequeue();
        if (double.TryParse(token, out  _))
        {
            set.Push(token);
        }
        else
        {
            var secondNum = set.Get();
            var firstNum = set.Get();
            set.Push(Count(firstNum, secondNum, token));
        }
    }
    var result = set.Get();
  
  return result;
}
  
  string Count(string firstNum, string secondNum, string element)
{ 
    double result;
    switch (element)
    {
        case "+":
            result = double.Parse(firstNum) + double.Parse(secondNum);
            break;
        case "-":
            result = double.Parse(firstNum) - double.Parse(secondNum);
            break;
        case "/":
            result = double.Parse(firstNum) / double.Parse(secondNum);
            break;
        case "*":
            result = double.Parse(firstNum) * double.Parse(secondNum);
            break;
        case "x":
            result = double.Parse(firstNum) * double.Parse(secondNum);
            break;
        default:
            throw new Exception("Error, use only +,-,/,*(x)");
    }

    return result.ToString();
} 
