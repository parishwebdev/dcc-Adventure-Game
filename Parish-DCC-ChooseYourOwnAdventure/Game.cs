using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class Game
    {
        string introductionText = "This is a adventure spin off of little red riding hod. \n";
        string startOverText = "After getting some sleep, Red trys to get to Grandmas again. ";
        List<Action> pathText = new List<Action>();
        List<Action> pathInput = new List<Action>();
        List<Action> path = new List<Action>();
        UserInterface ui = new UserInterface();
        River river = new River("Great River");
        Waterfall waterfall = new Waterfall("Amazing waterfall");
        Village village = new Village("Tiny Village");
        AbandonCabin abandonCabin = new AbandonCabin("Niagra Falls");

        public Game()
        {
            startOfGame();
            populateActions(path);
            travsereToGrandma2(path);
        }


        public void populateActions(List<Action> path)
        {
            path.Add(() => crossRoadOneText());
            path.Add(() => selector(crossRoadOneInput(),path));
            path.Add(() => crossRoadTwoText());
            path.Add(() => selector(crossRoadTwoInput(),path));
        }

        public void travsereToGrandma2(List<Action> path)
        {
            foreach (Action a in path)
            {
                a.Invoke();
            }
        }

        private void startOfGame()
        {
            ui.OutputText(introductionText);
        }
        private void startOver()
        {
            ui.OutputText(startOverText);
        }
        private void crossRoadOneText()
        {

            String textCR1 = river.GetSettingText() + river.GetPersuasionText() + "On the other hand you see: " + waterfall.GetSettingText() + waterfall.GetPersuasionText();
            ui.OutputText(textCR1);
        }
        private string crossRoadOneInput()
        {
            string result = ui.GetOptionInput(river.GetOptionText(), waterfall.GetOptionText());
            return result;
        }
        private void crossRoadTwoText()
        {

            String textCR2 = abandonCabin.GetSettingText() + abandonCabin.GetPersuasionText() + "On the other hand you see: " +  village.GetSettingText() + village.GetPersuasionText();
            ui.OutputText(textCR2);
        }
        private string crossRoadTwoInput()
        {
            string result = ui.GetOptionInput(abandonCabin.GetOptionText(), village.GetOptionText());
            return result;
        }
        public void selector(string selection, List<Action> path)
        {

            switch (selection)
            {
                case "river":
                case "village":
                    Console.WriteLine("You guess right, you keep moving.");
                    break;
                case "waterfall":
                case "abandon-cabin":
                    Console.WriteLine("You guess wrong, the wolf attacks you. Red runs back to her own house. \n");
                    //counter++
                    startOver();
                    travsereToGrandma2(path);
                    break;
                default:
                    Console.WriteLine("Not a valid selection.");
                    travsereToGrandma2(path);
                    break;
            }

        }





    }
}
