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
            optionText = " \"Village\": Take the quaint village path? ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "a smaller quaint area with housing with nice people walking around. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "It seemed pleasant, nice and not to crowded. The village was named " + name;
            return persuasionText;
        }


    }
}
