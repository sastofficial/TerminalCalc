double num1;
double num2;
int calcmethod;
double answer;
Console.Write("Input a number: ");
num1 = Convert.ToDouble(Console.ReadLine() );

Console.Write ("Input another number: ");
num2 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("What calculation method are you using?");
Console.WriteLine("1.+");
Console.WriteLine("2.-");
Console.WriteLine("3.x");
Console.WriteLine("4.÷");
calcmethod = Convert.ToInt32( Console.ReadLine() );

if (calcmethod = 1){
	 answer = num1 + num2;
 Console.WriteLine(num1 + " + " + num2 + " = " + answer); } 
	
