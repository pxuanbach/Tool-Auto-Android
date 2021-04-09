using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoLDWinform
{
    class LoadBmpBprogram
    {
        public Bitmap mainActivity { get; set; }
        public Bitmap go { get; set; }
        public Bitmap ok { get; set; }

        public LoadBmpBprogram()
        {
            ok = (Bitmap)Bitmap.FromFile(@"BProgram/ok.png");
        }

        public LoadBmpBprogram(int type)
        {
            ok = (Bitmap)Bitmap.FromFile(@"BProgram/ok.png");
            switch (type)
            {
                case 0:
                    mainActivity = (Bitmap)Bitmap.FromFile(@"BProgram/mainActivityBTC.png");
                    go = (Bitmap)Bitmap.FromFile(@"BProgram/goBTC.png");
                    break;
                case 1:
                    mainActivity = (Bitmap)Bitmap.FromFile(@"BProgram/mainActivityETH.png");
                    go = (Bitmap)Bitmap.FromFile(@"BProgram/goETH.png");
                    break;
                default:
                    break;
            }
        }

        ~LoadBmpBprogram()
        {

        }
    }
}
