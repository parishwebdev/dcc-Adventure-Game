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
            optionText = " \"Woods\": take the dense and dark woods path? ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "a tall and dense woods, that looks dark and visibility is low. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Red is unsure if is the right path. Although its name " + name + "makes her think otherwise";
            return persuasionText;
        }

    }
}
