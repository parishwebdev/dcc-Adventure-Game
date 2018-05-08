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
            optionText = " \"Waterfall\": Take the aquarium-blue waterfall path? ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "an aquarium-blue stream of water tumbleing down the small mountain. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "It seemed great to Red, given it was called " + name + " it seemed like a amazing option. ";
            return persuasionText;
        }

    }
}
