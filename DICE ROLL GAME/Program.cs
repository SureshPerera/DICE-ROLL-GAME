// See https://aka.ms/new-console-template for more information


AutoNumberGenerator generator = new AutoNumberGenerator();
InputValidateChecker checker = new InputValidateChecker();

generator.RandomNumber();
int genarateNumber = generator.randomNum;
//Console.WriteLine("number : "+ genarateNumber);
checker.checkValidate(genarateNumber);

Console.ReadLine();
