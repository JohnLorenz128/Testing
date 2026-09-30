using System.Runtime.InteropServices;
using ConsoleApp1.MVCs.Controller;

namespace ConsoleApp1.MVCs.View
{
    internal class ViewSharp
    {
        public void NewLine()
        {
            System.Console.WriteLine();
        }

        public void OpeningMessage()
        {
            System.Console.WriteLine("\n==== Calculator ====\n");
        }

        public void FirstNumberMessage()
        {
            Console.Write("\nFirst Number: ");
        }

        public void SecondNumberMessage()
        {
            Console.Write("\nSecond Number: ");
        }

        public void ThirdNumberMessage()
        {
            Console.Write("\nThird Number: ");
        }

        public void ChooseOperatorMessage()
        {
            Console.Write("\nChoose Operation:\n\tADDITION: '+'\n\tSUBTRACTION: '-'\n\tMULTIPLICATION: '*'\n\tDIVISION: '/'\n\tPOWER: '^'\nEnter Symbol: ");
        }

        public void ChooseOptionalOperatorMessage()
        {
            Console.Write("\nChoose Second Operation (Press ENTER to skip):\n\tADDITION: '+'\n\tSUBTRACTION: '-'\n\tMULTIPLICATION: '*'\n\tDIVISION: '/'\n\tPOWER: '^'\nEnter Symbol: ");
        }

        public void CalculationMessage(char operate1, double firstnumber, double secondnumber, char? operate2, double? thirdnumber, double answer)
        {
            if (operate2.HasValue && thirdnumber.HasValue)
            {
                System.Console.WriteLine($"\nANSWER\n{firstnumber} {operate1} {secondnumber} {operate2.Value} {thirdnumber.Value} = {answer}\n\n");
            }
            else
            {
                System.Console.WriteLine($"\nANSWER\n{firstnumber} {operate1} {secondnumber} = {answer}\n\n");
            }
        }

        public void AgainMessage()
        {
            Console.Write("New Calculation?(y/N): ");
        }

        public void ClosingMessage()
        {
            System.Console.WriteLine("\n\n...Closing Calculator\n");
        }

        public void ExceptionMessage()
        {
            System.Console.WriteLine("Exception Detected in Input, Redoing Input...");
        }

        public void ItIsNullMessage()
        {
            System.Console.WriteLine("Value Received Is Null, Redoing Input...");
        }

        public void InvalidoperatorMessage()
        {
            System.Console.WriteLine("Invalid Operator, Redoing Input...");
        }
    }
}