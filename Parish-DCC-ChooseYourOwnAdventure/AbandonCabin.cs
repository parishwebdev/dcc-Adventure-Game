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
            optionText = "\"Abandon Cabin\": Take the brown and worn abandoned cabin path? ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Next, Red sees a washed out brown cabin with parts of worn down.";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Red was wondering that the " + name + " was once a cool place to visit.";
            return persuasionText;
        }

    }
}
