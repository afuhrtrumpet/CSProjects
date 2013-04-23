using System;

namespace PostfixCalculator
{
    /**
* Static methods for processing equations of different formats.
*/
    public class ExpressionUtils
    {
        /// <summary>
        /// Calculates postfix expressions.
        /// </summary>
        /// <param name="expression">A string representing the expression. Operators and operands must be separated by one space.</param>
        /// <returns>The result of the expression.</returns>
        public static double postfixCalc(string expression)
        {
            //TODO: Implement the calculate logic.
            string[] tokens = expression.Split();
            StackADT operands = new StackADT();
            operands.push(double.Parse(tokens[0])); //The first token must be a number, so will throw an exception if it is not.
            double result = Convert.ToDouble(operands.peek()); //Sets the first number as the result.
            for (int i = 1; i < tokens.Length; i++)
            {
                double newNum = 0;
                bool canBeConverted = double.TryParse(tokens[i], out newNum); //Will generate two paths depending on whether token is a double.
                if (canBeConverted)
                {
                    operands.push(newNum);
                }
                else
                {
                    double secondNum = Convert.ToDouble(operands.pop()); //Reverses the order of the two numbers to be in proper postfix form.
                    switch (tokens[i])
                    {
                        case "+": result = Convert.ToDouble(operands.pop()) + secondNum; break;
                        case "-": result = Convert.ToDouble(operands.pop()) - secondNum; break;
                        case "/": if (secondNum == 0) throw new DivideByZeroException();
                            else result = Convert.ToDouble(operands.pop()) / secondNum; break;
                        case "*": result = Convert.ToDouble(operands.pop()) * secondNum; break;
                        case "%": result = Convert.ToDouble(operands.pop()) % secondNum; break;
                        default: throw new FormatException();
                    }
                    operands.push(result); //Adds result back into stack of operands.
                }
            }
            if (!operands.isEmpty()) throw new ArithmeticException(); //No operands should be left at the end.
            return result;
        }

    }

}
