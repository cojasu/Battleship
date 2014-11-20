using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BattleshipTest
{

    public class Menu
    {
        public string difficulty;
        public bool humanGoesFirst;
        public bool debugMode;
        public Menu()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            userOps myMenu = new userOps();
            Application.Run(myMenu);
            difficulty = myMenu.difficulty;
            humanGoesFirst = myMenu.humanGoesFirst;
            debugMode = myMenu.debugMode;
        }

      
    }
}
