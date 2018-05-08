using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class Game
    {
        string introductionText, gameOverText, spotByWolfText, safeToMoveText, happilyEverAfterText;
        List<Action> path = new List<Action>();
        UserInterface ui = new UserInterface();
        River river = new River("Great River");
        Waterfall waterfall = new Waterfall("Amazing waterfall");
        Village village = new Village("Tiny Village");
        AbandonCabin abandonCabin = new AbandonCabin("Unused cabin");
        Woods woods = new Woods("Happy wayland woods");
        Bridge bridge = new Bridge("Troll bridge");

        public Game()
        {
            ui.OutputText(StartOfAdventure());
            PopulateActions(path);
            TravsereToGrandma(path);
        }
        private string GameOver() {
            gameOverText = "After being going over the bridge, you end up at grandma's house.\nOnly to find out grandma isn't there anymore. The Wolf is there and gets Red. Adventure Over! ";
            return gameOverText;
        }
        private string SpotByWolf()
        {
            spotByWolfText = "You guess wrong, the wolf tries to attacks you, but Red runs fast away. \n";
            return spotByWolfText;
        }
        private string SafeToMove(){
            safeToMoveText = "You guess right, you keep moving without spotting the wolf.";
            return safeToMoveText;
        }
        private string HappilyEverAfter()
        {
            happilyEverAfterText = "You wander through the woods and meet a guy your same age. He ends up being a prince.\nAfter years of knowing the prince, you get married and live happly ever after.";
            return happilyEverAfterText;
        }
        public void PopulateActions(List<Action> path)
        {
            path.Add(() => CrossRoadOneText());
            path.Add(() => Selector(CrossRoadOneInput(),path));
            path.Add(() => CrossRoadTwoText());
            path.Add(() => Selector(CrossRoadTwoInput(), path));
            path.Add(() => CrossRoadThreeText());
            path.Add(() => Selector(CrossRoadThreeInput(), path));
        }
        public void TravsereToGrandma(List<Action> path)
        {

           foreach (Action a in path) {
                    a();
            }

        }
        private string StartOfAdventure()
        {
            introductionText = "This is a adventure spin off of little red riding hood. \n";
            return introductionText;
        }
        private void CrossRoadOneText()
        {
            String textCR1 = river.GetSettingText() + river.GetPersuasionText() + "On the other hand you see: " + waterfall.GetSettingText() + waterfall.GetPersuasionText();
            ui.OutputText(textCR1);
        }
        private string CrossRoadOneInput()
        {
            string result = ui.GetOptionInput(river.GetOptionText(), waterfall.GetOptionText());
            return result;
        }
        private void CrossRoadTwoText()
        {

            String textCR2 = abandonCabin.GetSettingText() + abandonCabin.GetPersuasionText() + "On the other hand you see: " +  village.GetSettingText() + village.GetPersuasionText();
            ui.OutputText(textCR2);
        }
        private string CrossRoadTwoInput()
        {
            string result = ui.GetOptionInput(abandonCabin.GetOptionText(), village.GetOptionText());
            return result;
        }
        private void CrossRoadThreeText()
        {

            String textCR2 = bridge.GetSettingText() + bridge.GetPersuasionText() + "On the other hand you see: " + woods.GetSettingText() + woods.GetPersuasionText();
            ui.OutputText(textCR2);
        }
        private string CrossRoadThreeInput()
        {
            string result = ui.GetOptionInput(bridge.GetOptionText(), woods.GetOptionText());
            return result;
        }
        
        public void Selector(string selection, List<Action> path)
        {

            switch (selection)
            {
                case "woods":
                    ui.OutputText(HappilyEverAfter()); 
                    break;
                case "river":
                case "village":
                    ui.OutputText(SafeToMove());
                    break;
                case "waterfall":
                case "abandon cabin":
                         ui.OutputText(SpotByWolf());
                    break;
                case "bridge":
                    ui.OutputText(GameOver());
                    break;
                default:
                    Console.WriteLine("Not a valid selection.");
                    TravsereToGrandma(path);
                    break;
            }

        }

        
    }
}
