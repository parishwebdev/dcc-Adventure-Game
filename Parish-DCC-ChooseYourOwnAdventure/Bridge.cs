using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class Bridge
    {
        public string name;
        public string optionText;
        public string settingText;
        public string persuasionText;

        public Bridge(string name)
        {
            this.name = name;
        }

        public string GetOptionText()
        {
            optionText = "\"Bridge\": Bridge Option text. ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Setting 1: Bridge Setting text. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Persuasion 1: Bridge Persuasion text. ";
            return persuasionText;
        }

    }
}
