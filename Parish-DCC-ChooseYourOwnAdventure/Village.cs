using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class Village
    {
        public string name;
        public string optionText;
        public string settingText;
        public string persuasionText;

        public Village(string name)
        {
            this.name = name;
        }

        public string GetOptionText()
        {
            optionText = "\"Village\": Village Option text. ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Setting 1: Village Setting text. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Persuasion 1: Village Setting text. ";
            return persuasionText;
        }

        public bool IsCorrectChoice()
        {
            return true;
        }

    }
}
