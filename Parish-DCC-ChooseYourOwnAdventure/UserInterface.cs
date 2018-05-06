using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class UserInterface
    {
 
        public void OutputText(string param)
        {
            Console.WriteLine(param); 
        }

        public string GetOptionInput(string option1, string option2)
        {
            Console.WriteLine(option1 + "or " + option2 + "(Type exact \"Name\" of place to make your selection)");
            string output = Console.ReadLine();
            if (validateOptionInput(output))
            {
                output = sanitizeOptionInput(output);
                return output;
            }
                return GetOptionInput(option1, option2);
        }

        private string sanitizeOptionInput(string input)
        {
            string sanitized = input.ToLower();
            return sanitized;
        }
        private Boolean validateOptionInput(string input)
        {
            string[] acceptedStrings = new string[] { "waterfall","river","abandon-cabin","village" };
            if (input == "" || input == null)
            {
                OutputText("Please enter a value in: ");
                return false;
            }
            if (int.TryParse(input, out int n) )
            {
                OutputText("Please don't enter a number in: ");
                return false;
            }
            if (acceptedStrings.Contains(input) == false)
            {
                OutputText("Please enter the corrert word in: ");
                return false;
            }

            return true;
        }

    }
}
