using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //int[] myNumbers = { 1, 2, 3 };
                //Console.WriteLine(myNumbers[10]); 

                int a = 10;
                int b = 0;
                var res = a/b;

                throw new CustomException("This is my custom Exception");

            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            catch (IndexOutOfRangeException ex)
            { 
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"HelpLink: {ex.HelpLink}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"HelpLink: {ex.HelpLink}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }        
            finally
            {
                Console.WriteLine("Finally");
            }


         

            Console.ReadLine();
        }
    }
}
