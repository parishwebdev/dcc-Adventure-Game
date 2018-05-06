using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class AbandonCabin
    {
        public string name;
        public string optionText;
        public string settingText;
        public string persuasionText;

        public AbandonCabin(string name)
        {
            this.name = name;
        }

        public string GetOptionText()
        {
            optionText = "\"Abandon-Cabin\": AbandonCabin text. ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Setting 2: AbandonCabin Setting text. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Persuasion 2: AbandonCabin Setting text. ";
            return persuasionText;
        }

        public bool IsCorrectChoice()
        {
            return false;
        }
    }
}
