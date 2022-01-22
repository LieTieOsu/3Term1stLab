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
