using ConsoleApp1.MVCs.Controller;

namespace ConsoleApp1.MVCs.Model
{
    internal class ModelSharp
    {
        public double AnswerCalculation(double firstNumber, double secondNumber, char symbolOperator)
        {
            double answer = 0;
            switch (symbolOperator)
            {
                case '+':
                    answer = firstNumber + secondNumber;
                    break;
                case '-':
                    answer = firstNumber - secondNumber;
                    break;
                case '*':
                    answer = firstNumber * secondNumber;
                    break;
                case '/':
                    answer = firstNumber / secondNumber;
                    break;
                case '^':
                    answer = Math.Pow(firstNumber, secondNumber);
                    break;
                default:
                    break;
            }
            return answer;
        }

        public double AnswerCalculation(double firstNumber, double secondNumber, char operator1, double thirdNumber, char operator2)
        {
            double firstResult = AnswerCalculation(firstNumber, secondNumber, operator1);
            return AnswerCalculation(firstResult, thirdNumber, operator2);
        }
    }
}