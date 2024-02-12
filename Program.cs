namespace ConsoleApp_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            do
            {
                int firstNumber = GetNumberInput("Please put first number: ");
                int secondNumber = GetNumberInput("Please put second number: ");
                string operation = GetOperationType();
            
                int calculatedValue = 0;
                switch (operation)
                {
                    case "+":
                        calculatedValue = firstNumber + secondNumber;
                        break;
                    case "-":
                        calculatedValue = firstNumber - secondNumber;
                        break;
                    case "/":
                        calculatedValue = firstNumber / secondNumber;
                        break;
                    case "*":
                        calculatedValue = firstNumber * secondNumber;
                        break;
                    default:
                        Console.WriteLine("Invalid operation type!");
                        break;
                }
            
                Console.WriteLine($"Result = {calculatedValue}");
                Console.WriteLine("If you would like to continue, please press 'Y'.");
                string userInput = Console.ReadLine().Trim();
                if (userInput.ToLower() != "y")
                {
                    shouldContinue = false;
                }
            } while (shouldContinue);
        }
        
        private static int GetNumberInput(string textMessage)
        {
            bool isNumber = false;
            int number = 0;

            do {
                Console.WriteLine(textMessage);
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);

                if (!isNumber || number == 0)
                    Console.WriteLine("Please enter a valid number.");
            } while (!isNumber);

            return number;
        }

        private static string GetOperationType()
        {
            bool isValidOperationType = false;
            string operationType = "";
            Console.WriteLine("Please choose the type of operation: ");
            do
            {
                 operationType = Console.ReadLine();

                operationType = operationType.Trim();

                if (operationType != "+" && operationType != "-" && operationType != "*" && operationType != "/")
                    Console.WriteLine("Please enter a valid operator.");
                else
                    isValidOperationType = true;
            } while (!isValidOperationType);

            return operationType;
        }
    }
}

