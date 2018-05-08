using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class River
    {
        public string name;
        public string optionText;
        public string settingText;
        public string persuasionText;

        public River(string name)
        {
            this.name = name;
        }

        public string GetOptionText()
        {
            optionText = "\"River\": Take the jewel-blue river path? ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Red sees a jewel-blue stream with a family of ducks floating along.";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "It seemed big to Red, given it was called " + name + " it seemed like a good option. ";
            return persuasionText;
        }


    }
}
