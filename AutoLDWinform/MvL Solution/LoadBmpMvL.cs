using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLDWinform
{
    //Load image of MvL app
    class LoadBmpMvL
    {
        public static Bitmap mainActivity = (Bitmap)Bitmap.FromFile(@"MvL/mainActivity.png");
        //Hourly claim
        public Bitmap spinWin { get; set; }
        public Bitmap roll { get; set; }
        public Bitmap saveYourPrize { get; set; }
        public Bitmap nextClaim { get; set; }

        //Bonus claim
        public Bitmap bonusClaim { get; set; }
        public Bitmap rollBonus { get; set; }
        public Bitmap saveTheWin { get; set; }
        public Bitmap nextBonus { get; set; }

        public LoadBmpMvL()
        {
            //Hourly claim
            spinWin = (Bitmap)Bitmap.FromFile(@"MvL/spinWin.png");
            roll = (Bitmap)Bitmap.FromFile(@"MvL/roll.png");
            saveYourPrize = (Bitmap)Bitmap.FromFile(@"MvL/saveYourPrize.png");
            nextClaim = (Bitmap)Bitmap.FromFile(@"MvL/nextClaim.png");

            //Bonus claim
            bonusClaim = (Bitmap)Bitmap.FromFile(@"MvL/bonusClaim.png");
            rollBonus = (Bitmap)Bitmap.FromFile(@"MvL/rollBonus.png");
            saveTheWin = (Bitmap)Bitmap.FromFile(@"MvL/saveTheWin.png");
            nextBonus = (Bitmap)Bitmap.FromFile(@"MvL/nextBonus.png");
        }

        public LoadBmpMvL(int type)
        {
            switch (type)
            {
                case 0:
                    //Hourly claim
                    spinWin = (Bitmap)Bitmap.FromFile(@"MvL/spinWin.png");
                    roll = (Bitmap)Bitmap.FromFile(@"MvL/roll.png");
                    saveYourPrize = (Bitmap)Bitmap.FromFile(@"MvL/saveYourPrize.png");
                    nextClaim = (Bitmap)Bitmap.FromFile(@"MvL/nextClaim.png");
                    break;
                case 1:
                    //Bonus claim
                    bonusClaim = (Bitmap)Bitmap.FromFile(@"MvL/bonusClaim.png");
                    rollBonus = (Bitmap)Bitmap.FromFile(@"MvL/rollBonus.png");
                    saveTheWin = (Bitmap)Bitmap.FromFile(@"MvL/saveTheWin.png");
                    nextBonus = (Bitmap)Bitmap.FromFile(@"MvL/nextBonus.png");
                    break;
                default:
                    break;
            }
        }

        ~LoadBmpMvL()
        {

        }
    }
}
