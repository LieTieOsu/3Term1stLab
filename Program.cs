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
  
  
  
  
   return tokenized;
}


Queue ShuntingYard(Queue tokenized)
{
    var operatorStack = new Stack();
    var output = new Queue();
  
  
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
