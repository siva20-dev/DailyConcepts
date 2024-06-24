using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts.ExceptionTypesConcepts
{
    public class ExceptionType
    {
        public static int Arithmetic(int number1, int number2)
        {
            int value= Divide(number1, number2);
            return value;
        }
        
        public static int Divide(int number1, int number2)
        {
            int num3 = (number1 / number2);
            return num3;
        }

        public static int Divide2(int number1, int number2)
        {
            if ((number1 < 0) || (number2 < 0))
            {
                throw new Exception("Negative Numbers not allowed");
            }
            int num3 = (number1 / number2);
            return num3;
        }


        public static int Arithmetic2(int number1, int number2)
        {
            int value = Divide3(number1, number2);
            return value;
        }


        public static int Divide3(int number1, int number2)
        {
            if ((number1 < 0) || (number2 < 0))
            {
                throw new Exception("Negative Numbers not allowed");
            }

            if (number1==number2)
            {
                throw new NumDenoEqualException("Numerator and Denominator are same");
            }
            int num3 = (number1 / number2);
            return num3;
        }

        public static int Arithmetic3(int number1, int number2)
        {
            try
            {
                int value = Divide3(number1, number2);
                return value;
            }
            catch (Exception ex) 
            {
                //throw new Exception("Something Bad Happend"); //Swallows all the other child Exceptions or other exceptions are overridden


                //throw new Exception("Something Bad Happend"+ ex.Message);

                //or

                throw ex;

            }
        }
    }

    public class NumDenoEqualException : Exception
    {
        public NumDenoEqualException(string message) : base(message)
        {

        }
    }

    public class ExceptionTypes
    {
        public static void ExceptionTypesExample1()
        {
            try
            {
                Console.WriteLine(ExceptionType.Divide(10, 0));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividing by Zero Not Possible: Correct it to 1"); //this will print the message we mention

                Console.WriteLine(ExceptionType.Divide(10, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //It will show what is the actual error
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }

        public static void ExceptionTypesExample2()
        {
            try
            {
                Console.WriteLine(ExceptionType.Arithmetic(10, 0));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Has Occured Sorry"); //this will print the message we mention

                //or

                Console.WriteLine(ex.StackTrace); //It will show what is the actual error
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }

        public static void ExceptionTypesExample3()
        {
            try
            {
                Console.WriteLine(ExceptionType.Divide2(-1, 0));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Has Occured Sorry"); //this will print the message we mention

                //or

                Console.WriteLine(ex.Message); //It will show what is the actual error
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }

        public static void ExceptionTypesExample4()
        {
            try
            {
                Console.WriteLine(ExceptionType.Arithmetic2(-1, 1));
            }

            catch (NumDenoEqualException ex)
            {
                Console.WriteLine(1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividing by Zero Not Possible: Correct it to 1"); //this will print the message we mention

                Console.WriteLine(ExceptionType.Divide(10, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //It will show what is the actual error
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }

        public static void ExceptionTypesExample5()
        {
            try
            {
                Console.WriteLine(ExceptionType.Arithmetic3(-1, 1));

            }

            catch (NumDenoEqualException ex)
            {
                Console.WriteLine(1);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividing by Zero Not Possible: Correct it to 1"); //this will print the message we mention

                Console.WriteLine(ExceptionType.Divide(10, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //It will show what is the actual error
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }
    }
}
