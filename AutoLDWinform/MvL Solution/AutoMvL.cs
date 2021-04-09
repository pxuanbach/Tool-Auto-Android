using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using KAutoHelper;
using System.Threading;
using System.Windows.Forms;

namespace AutoLDWinform
{
    public class AutoMvL
    {
        public static Bitmap appImageLTC;
        public static Bitmap appImageDOGE;
        public static Bitmap appImageBCH;

        #region M&L
        public static void Load_BMP()
        {
            try
            {
                appImageLTC = (Bitmap)Bitmap.FromFile(@"MvL/appImageLTC.png");
                appImageDOGE = (Bitmap)Bitmap.FromFile(@"MvL/appImageDOGE.png");
                appImageBCH = (Bitmap)Bitmap.FromFile(@"MvL/appImageBCH.png");
            }
            catch
            {
                MessageBox.Show("File doesn't load!");
            }
        }

        public static void Start(string deviceID, DataGridViewRow row, List<Bitmap> closeAD)
        {
            Load_BMP();
            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
            var appLtcPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, appImageLTC);
            var appDogePoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, appImageDOGE);
            var appBchPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, appImageBCH);
            AutoMvL auto = new AutoMvL();
            Task t = new Task(() =>
            {
                if (appLtcPoint != null)
                {
                    //Click open app
                    row.Cells["Status"].Value = "Click open app";
                    KAutoHelper.ADBHelper.Tap(deviceID, appLtcPoint.Value.X, appLtcPoint.Value.Y);
                    Delay(3);
                    auto.runTask(deviceID, row, LoadBmpMvL.mainActivity, closeAD);
                }
                else if (appDogePoint != null)
                {
                    //Click open app
                    row.Cells["Status"].Value = "Click open app";
                    KAutoHelper.ADBHelper.Tap(deviceID, appDogePoint.Value.X, appDogePoint.Value.Y);
                    Delay(3);
                    auto.runTask(deviceID, row, LoadBmpMvL.mainActivity, closeAD);
                }
                else if (appBchPoint != null)
                {
                    //Click open app
                    row.Cells["Status"].Value = "Click open app";
                    KAutoHelper.ADBHelper.Tap(deviceID, appBchPoint.Value.X, appBchPoint.Value.Y);
                    Delay(3);
                    auto.runTask(deviceID, row, LoadBmpMvL.mainActivity, closeAD);
                }
                else
                {
                    row.Cells["Status"].Value = "No app found!";
                    return;
                }

            });
            t.Start();
        }

        void runTask(string deviceID, DataGridViewRow row, Bitmap res, List<Bitmap> closeAD)
        {
            //App loading
            while (true)
            {
                row.Cells["Status"].Value = "App loading...";
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var resPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, res);
                if (resPoint == null)
                    Delay(4);
                else
                {
                    Delay(1);
                    break;
                }
            }
            checkHourlyClaim(deviceID, row);
            Delay(2);
            checkBonusClaim(deviceID, closeAD, row);

            //Exit app
            row.Cells["Status"].Value = "Task completed!";
            KAutoHelper.ADBHelper.Key(deviceID, ADBKeyEvent.KEYCODE_APP_SWITCH);
            Delay(1);
            KAutoHelper.ADBHelper.SwipeByPercent(deviceID, 45.9, 15, 38.7, 82);
            Delay(1);
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 87.7, 5.6);
        }

        void checkHourlyClaim(string deviceID, DataGridViewRow row)
        {
            LoadBmpMvL bmp = new LoadBmpMvL(0);
            while (true)
            {
                Delay(4);
                row.Cells["Status"].Value = "Check hourly claim...";
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var nextClaimPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.nextClaim);
                var spinWinPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.spinWin);
                if (spinWinPoint != null)
                {
                    //Click Spin Win
                    row.Cells["Status"].Value = "Click Spin Win";
                    KAutoHelper.ADBHelper.Tap(deviceID, spinWinPoint.Value.X, spinWinPoint.Value.Y);
                    Delay(6);
                    while (true)
                    {
                        //Check roll point
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                        var rollPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.roll);
                        if (rollPoint != null)
                        {
                            //Click roll
                            row.Cells["Status"].Value = "Click roll";
                            KAutoHelper.ADBHelper.Tap(deviceID, rollPoint.Value.X, rollPoint.Value.Y);
                            Delay(3);
                            break;
                        }
                        else
                        {
                            Delay(1);
                        }
                    }

                    while (true)
                    {
                        //check "Save Your Prize" point
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                        var savePoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.saveYourPrize);
                        if (savePoint != null)
                        {
                            //Click "Save Your Prize"
                            row.Cells["Status"].Value = "Click 'Save Your Prize'";
                            KAutoHelper.ADBHelper.Tap(deviceID, savePoint.Value.X, savePoint.Value.Y);
                            KAutoHelper.ADBHelper.Tap(deviceID, savePoint.Value.X, savePoint.Value.Y);
                            Delay(8);
                            break;
                        }
                        else
                        {
                            Delay(2);
                        }
                    }
                }
                else if (nextClaimPoint != null)
                {
                    Delay(1);
                    break;
                }
                else
                {
                    Delay(3);
                }
            }
        }

        void checkBonusClaim(string deviceID, List<Bitmap> closeAD, DataGridViewRow row)
        {
            LoadBmpMvL bmp = new LoadBmpMvL(1);
            Delay(2);
            while (true)
            {
                row.Cells["Status"].Value = "Check bonus claim...";
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var bonusClaimPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.bonusClaim);
                var nextBonusPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.nextBonus);

                if (nextBonusPoint != null)
                {
                    //No bonus to claim
                    row.Cells["Status"].Value = "There is no reward. Task completed!";
                    Delay(1);
                    break;
                }
                else if (bonusClaimPoint != null)
                {
                    //Click Bonus Claim!
                    row.Cells["Status"].Value = "Click 'Bonus Claim!'";
                    KAutoHelper.ADBHelper.Tap(deviceID, bonusClaimPoint.Value.X, bonusClaimPoint.Value.Y);
                    Delay(4);
                    while (true)
                    {
                        //Check roll point
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                        var rollPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.rollBonus);
                        if (rollPoint != null)
                        {
                            //Click roll
                            row.Cells["Status"].Value = "Click roll";
                            KAutoHelper.ADBHelper.Tap(deviceID, rollPoint.Value.X, rollPoint.Value.Y);
                            Delay(1);
                            row.Cells["Status"].Value = "Waiting...";
                            Delay(25);
                            break;
                        }
                        else
                        {
                            Delay(1);
                        }
                    }

                    //Press Key BACK to return app
                    row.Cells["Status"].Value = "Send Key BACK";
                    KAutoHelper.ADBHelper.Key(deviceID, ADBKeyEvent.KEYCODE_BACK);
                    Delay(2);

                    //Waiting to exit AD
                    row.Cells["Status"].Value = "Waiting to exit AD";
                    while (true)
                    {
                        screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                        var savePoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.saveTheWin);

                        if (savePoint == null)
                        {
                            for (int j = 0; j < closeAD.Count - 1; j++)
                            {
                                var closeADPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, closeAD[j]);
                                if (closeADPoint != null)
                                {
                                    row.Cells["Status"].Value = "Check " + j;
                                    KAutoHelper.ADBHelper.Tap(deviceID, closeADPoint.Value.X, closeADPoint.Value.Y);
                                    Delay(2);
                                    break;
                                }
                            }
                            row.Cells["Status"].Value = "Waiting to exit AD";
                            KAutoHelper.ADBHelper.Key(deviceID, ADBKeyEvent.KEYCODE_BACK);
                            Delay(2);
                        }
                        else
                        {
                            Delay(1);
                            //Click Save The Winnings
                            row.Cells["Status"].Value = "Click 'Save The Winnings'";
                            KAutoHelper.ADBHelper.Tap(deviceID, savePoint.Value.X, savePoint.Value.Y);
                            Delay(8);
                            break;
                        }
                    }
                }
                else
                {
                    Delay(5);
                }
            }
        }
        
        #endregion

        static void Delay(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                delay--;
            }
        }

        ~AutoMvL() { }
    }
}
