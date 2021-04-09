using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLDWinform
{
    //Load image close ads
    class LoadBmpCloseAD
    {       
        public List<Bitmap> imageClose { get; set; }

        public LoadBmpCloseAD()
        {
            imageClose = new List<Bitmap>();
            try
            {
                int fileCount = Directory.GetFiles(@"closeAD/", "*.png", SearchOption.TopDirectoryOnly).Length;
                for (int i = 0; i < fileCount; i++)
                {
                    imageClose.Add(new Bitmap(Bitmap.FromFile(@"closeAD/" + i + ".png")));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        ~LoadBmpCloseAD()
        {

        }
    }
}
