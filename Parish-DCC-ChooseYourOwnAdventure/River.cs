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
            optionText = "\"River\": River Option text. ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Setting 1: River Setting text. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Persuasion 1: River Setting text. ";
            return persuasionText;
        }

        public bool IsCorrectChoice()
        {
            return true;
        }

    }
}
