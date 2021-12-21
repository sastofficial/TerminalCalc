double num1;
double num2;
char calcmethod;
double answer;
Console.Write("Input a number: ");
num1 = Convert.ToDouble(Console.ReadLine() );

Console.Write ("Input another number: ");
num2 = Convert.ToDouble( Console.ReadLine() );

Console.Write ("What calculation method are you using? (+,-,/ or x) ");
 calcmethod = Console.ReadLine();
 

if (calcmethod = '+'){
	 answer = num1 + num2;
 Console.WriteLine(num1 + " + " + num2 + " = " + answer); } 
	else{ Console.WriteLine("hello");
 } 
