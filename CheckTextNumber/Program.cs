using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTextNumber
{

    //https://www.exercisescsharp.com/functions-c/function-check-text-is-number
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Input text here: ");
            text = Console.ReadLine();

            CheckTextNumber myCheckTextNumber = new CheckTextNumber();

            Console.WriteLine(myCheckTextNumber.IsNumber(text));

            Console.ReadLine();

        }
    }

    public class CheckTextNumber
    {

        public string IsNumber(string inputText)
        {
            string checkText = inputText.ToString();
            string response = "";

                bool x = int.TryParse(checkText, out int res);
                if (x)
                    response = "True";
                else
                    response = "False";

            return response;
        }
        
    }
}
