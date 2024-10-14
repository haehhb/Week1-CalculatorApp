Console.WriteLine("Type in the first number followed by the Enter key");
//ask user to type in first numer 
//we converted because the console read line reads thing as a string ans this is being stored in an int 
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in the second number followed by the Enter key");
//ask user to type second number 
int secondNumber = Convert.ToInt32(Console.ReadLine());
//perform the calculation 
int result = firstNumber + secondNumber; 
//Output to answer line 
Console.WriteLine("The addition of {0} and {1} give the answer {2}", firstNumber, secondNumber, result);