using ConsoleApp1.MVCs.View;
using ConsoleApp1.MVCs.Model;
using System.Runtime.ExceptionServices;
using System.Runtime.CompilerServices;

namespace ConsoleApp1.MVCs.Controller
{
    internal class ControllerSharp
    {
        ViewSharp mvcV = new ViewSharp();
        ModelSharp mvcM = new ModelSharp();

        String blank = "\0";
        const char blankChar = '\0';
        const int blankInt = 0;
        
        public void Run()
        {
            double firstNumber = blankInt;
            char operato = blankChar;
            double secondNumber = blankInt;
            double answer;
            string? choiceToContinue = blank;

            while (true)
            {
                choiceToContinue = blank;
                mvcV.OpeningMessage();
                firstNumber = ExceptionHandlingDouble(mvcV.FirstNumberMessage);
                while (true)
                {
                    operato = ExceptionHandlingChar(mvcV.ChooseOperatorMessage);
                    if (operato != '+' && operato != '-' && operato != '*' && operato != '/' && operato != '^')
                    {
                        mvcV.InvalidoperatorMessage();
                    }
                    else
                    {
                        break;
                    }
                }
                secondNumber = ExceptionHandlingDouble(mvcV.SecondNumberMessage);
                answer = mvcM.AnswerCalculation(firstNumber, secondNumber, operato);
                mvcV.CalculationMessage(operato, firstNumber, secondNumber, answer);
                choiceToContinue = ExceptionHandlingString(mvcV.AgainMessage);
                if (choiceToContinue != null && choiceToContinue.ToUpper()[0] == 'N')
                {
                    break;
                }
            }
            mvcV.ClosingMessage();
        }




        //Just Exception Handling Overloading Area
        private double ExceptionHandlingDouble(Action message)
        {

            double x = blankInt;
            bool excepsyon;
            do
            {
                excepsyon = false;
                message();
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    mvcV.ExceptionMessage();
                    excepsyon = true;
                }  
            } while(excepsyon);
            return x;
        }

        private char ExceptionHandlingChar(Action message)
        {
            char x = blankChar;
            string? sx;
            bool excepsyon;
            do
            {
                excepsyon = false;
                message();
                try
                {
                    sx = Console.ReadLine();
                    if (sx == null)
                    {
                        mvcV.ItIsNullMessage();
                        excepsyon = true;
                    }
                    else
                    {
                        x = sx[0];
                    }
                }
                catch
                {
                    mvcV.ExceptionMessage();
                    excepsyon = true;
                }  
            } while(excepsyon);
            return x;
        }

        private string? ExceptionHandlingString(Action message)
        {
            string? sx = blank;
            bool excepsyon;
            do
            {
                excepsyon = false;
                message();
                try
                {
                    sx = Console.ReadLine();
                    if (sx == null)
                    {
                        mvcV.ItIsNullMessage();
                        excepsyon = true;
                    }
                }
                catch
                {
                    mvcV.ExceptionMessage();
                    excepsyon = true;
                }  
            } while(excepsyon);
            return sx;
        }
    }
}