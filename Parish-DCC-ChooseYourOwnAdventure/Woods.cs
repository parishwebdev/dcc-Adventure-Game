using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parish_DCC_ChooseYourOwnAdventure
{
    class Woods
    {
        public string name;
        public string optionText;
        public string settingText;
        public string persuasionText;

        public Woods(string name)
        {
            this.name = name;
        }

        public string GetOptionText()
        {
            optionText = "\"Woods\": Woods Option text. ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Setting 2: Woods Setting text. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Persuasion 2: Woods Persuasion text. ";
            return persuasionText;
        }

    }
}
