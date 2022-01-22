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
                tokenized.Enqueue(UniteNumber(num));
        }
        else
        {
            if (!num.IsEmpty())
                tokenized.Enqueue(UniteNumber(num));
            tokenized.Enqueue(expression[index].ToString());
        }
    }

    if (!num.IsEmpty())
        tokenized.Enqueue(UniteNumber(num));
    
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
        output.Enqueue(operatorStack.Pull());
    }
  
  return output;
}

String Calculate(Queue postfixTokenQueue)
{
    var set = new Stack();
String Calculate(Queue postfixTokenQueue)
{
    var set = new Stack();
  
  
  
  
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
