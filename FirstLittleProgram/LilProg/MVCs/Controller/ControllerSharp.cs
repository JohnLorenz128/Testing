using ConsoleApp1.MVCs.View;
using ConsoleApp1.MVCs.Model;

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
            char operator1 = blankChar;
            double secondNumber = blankInt;
            char? operator2 = null;
            double? thirdNumber = null;
            double answer;
            string? choiceToContinue = blank;

            while (true)
            {
                choiceToContinue = blank;
                mvcV.OpeningMessage();

                firstNumber = ExceptionHandlingDouble(mvcV.FirstNumberMessage);

                while (true)
                {
                    operator1 = ExceptionHandlingChar(mvcV.ChooseOperatorMessage);
                    if (operator1 != '+' && operator1 != '-' && operator1 != '*' && operator1 != '/' && operator1 != '^')
                    {
                        mvcV.InvalidoperatorMessage();
                    }
                    else
                    {
                        break;
                    }
                }

                secondNumber = ExceptionHandlingDouble(mvcV.SecondNumberMessage);

                while (true)
                {
                    operator2 = ExceptionHandlingOptionalChar(mvcV.ChooseOptionalOperatorMessage);
                    if (operator2.HasValue && operator2 != '+' && operator2 != '-' && operator2 != '*' && operator2 != '/' && operator2 != '^')
                    {
                        mvcV.InvalidoperatorMessage();
                    }
                    else
                    {
                        break;
                    }
                }

                if (operator2.HasValue)
                {
                    thirdNumber = ExceptionHandlingDouble(mvcV.ThirdNumberMessage);
                    answer = mvcM.AnswerCalculation(firstNumber, secondNumber, operator1, thirdNumber.Value, operator2.Value);
                }
                else
                {
                    thirdNumber = null;
                    answer = mvcM.AnswerCalculation(firstNumber, secondNumber, operator1);
                }

                mvcV.CalculationMessage(operator1, firstNumber, secondNumber, operator2, thirdNumber, answer);

                choiceToContinue = ExceptionHandlingString(mvcV.AgainMessage);
                if (choiceToContinue != null && choiceToContinue.ToUpper()[0] == 'N')
                {
                    break;
                }
            }
            mvcV.ClosingMessage();
        }

        // Just Exception Handling Overloading Area
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
            } while (excepsyon);
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
                    if (string.IsNullOrEmpty(sx))
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
            } while (excepsyon);
            return x;
        }

        private char? ExceptionHandlingOptionalChar(Action message)
        {
            message();
            string? sx = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(sx))
            {
                return null;
            }

            return sx[0];
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
            } while (excepsyon);
            return sx;
        }
    }
}