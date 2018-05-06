using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class Waterfall
    {
        public string name;
        public string optionText;
        public string settingText;
        public string persuasionText;

        public Waterfall(string name)
        {
            this.name = name;
        }

        public string GetOptionText()
        {
            optionText = " \"Waterfall\": Waterfall text. ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Setting 2: Waterfall Setting text. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Persuasion 2: Waterfall Setting text. ";
            return persuasionText;
        }

        public bool IsCorrectChoice()
        {
            return false;
        }
    }
}
