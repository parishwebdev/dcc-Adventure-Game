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
            optionText = "\"Bridge\": Take the broken down, midevil bridge path? ";
            return optionText;
        }
        public string GetSettingText()
        {
            settingText = "Next, Red sees a broken down, cobblestone and midevil looking bridge. ";
            return settingText;
        }
        public string GetPersuasionText()
        {
            persuasionText = "Despite being named " + name + "she believes it look like many people have gone across it. ";
            return persuasionText;
        }

    }
}
