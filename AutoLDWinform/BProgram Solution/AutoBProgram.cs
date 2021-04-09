using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KAutoHelper;

namespace AutoLDWinform
{
    class AutoBProgram
    {
        public static Bitmap appImageBTC;
        public static Bitmap appImageETH;

        public static void Load_BMP()
        {
            try
            {
                appImageBTC = (Bitmap)Bitmap.FromFile(@"BProgram/appImageBTC.png");
                appImageETH = (Bitmap)Bitmap.FromFile(@"BProgram/appImageETH.png");
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
            var appBtcPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, appImageBTC);
            var appEthPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, appImageETH);

            AutoBProgram auto = new AutoBProgram();
            Task t = new Task(() =>
            {
                if (appBtcPoint != null)
                {
                    //Click open app
                    row.Cells["Status"].Value = "Click open app";
                    KAutoHelper.ADBHelper.Tap(deviceID, appBtcPoint.Value.X, appBtcPoint.Value.Y);
                    Delay(3);
                    auto.runTask(deviceID, row, closeAD, 0);
                }
                else if (appEthPoint != null)
                {
                    //Click open app
                    row.Cells["Status"].Value = "Click open app";
                    KAutoHelper.ADBHelper.Tap(deviceID, appEthPoint.Value.X, appEthPoint.Value.Y);
                    Delay(3);
                    auto.runTask(deviceID, row, closeAD, 1);
                }
                else
                {
                    row.Cells["Status"].Value = "No app found!";
                    return;
                }

            });
            t.Start();
        }

        void runTask(string deviceID, DataGridViewRow row, List<Bitmap> closeAD, int type)
        {
            LoadBmpBprogram bmp = new LoadBmpBprogram(type);
            Delay(10);
            close_Ad(deviceID, bmp.mainActivity, closeAD, row);
            //App loading
            while (true)
            {
                row.Cells["Status"].Value = "App loading...";
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var resPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.mainActivity);
                if (resPoint == null)
                    Delay(4);
                else
                {
                    Delay(1);
                    break;
                }
            }

            //Auto Click 16 time
            for (int i = 0; i < 16; i++)
            {
                //Waiting screen app
                while (true)
                {
                    var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                    var resPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.mainActivity);
                    if (resPoint == null)
                        Delay(2);
                    else
                    {
                        Delay(1);
                        break;
                    }

                }

                checkEnergyOK(deviceID, bmp, row);

                Delay(2);

                //Sleep 27s
                row.Cells["Status"].Value = "Waiting...";
                Delay(25);


                //Press Key BACK to return app
                row.Cells["Status"].Value = "Send Key BACK";
                KAutoHelper.ADBHelper.Key(deviceID, ADBKeyEvent.KEYCODE_BACK);
                Delay(2);

                //Waiting to exit AD
                row.Cells["Status"].Value = "Waiting to exit AD";
                while (true)
                {
                    var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                    var resPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.mainActivity);

                    if (resPoint == null)
                    {
                        for (int j = 0; j < closeAD.Count - 1; j++)
                        {
                            var closeADPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, closeAD[j]);
                            row.Cells["Status"].Value = "Check " + j;
                            if (closeADPoint != null)
                            {
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
                        Delay(2);
                        break;
                    }
                }
            }

            //Exit app
            row.Cells["Status"].Value = "Task completed!";
            KAutoHelper.ADBHelper.Key(deviceID, ADBKeyEvent.KEYCODE_APP_SWITCH);
            Delay(1);
            KAutoHelper.ADBHelper.SwipeByPercent(deviceID, 49.8, 8.7, 48.6, 86.5);
            Delay(1);
            KAutoHelper.ADBHelper.TapByPercent(deviceID, 87.7, 5.6);
        }

        void close_Ad(string deviceID, Bitmap res, List<Bitmap> closeAD, DataGridViewRow row)
        {
            //Press Key BACK to return app
            row.Cells["Status"].Value = "Send Key BACK";
            KAutoHelper.ADBHelper.Key(deviceID, ADBKeyEvent.KEYCODE_BACK);
            Delay(2);

            //Waiting to exit AD
            row.Cells["Status"].Value = "Waiting to exit AD";
            while (true)
            {
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var resPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, res);

                if (resPoint == null)
                {
                    for (int j = 0; j < closeAD.Count - 1; j++)
                    {
                        var closeADPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, closeAD[j]);
                        row.Cells["Status"].Value = "Check " + j;
                        if (closeADPoint != null)
                        {
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
                    Delay(2);
                    break;
                }
            }
        }

        void checkEnergyOK(string deviceID, LoadBmpBprogram bmp, DataGridViewRow row)
        {
            while (true)
            {
                //Click GO
                var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var goPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.go);
                if (goPoint != null)
                {
                    row.Cells["Status"].Value = "Click GO";
                    KAutoHelper.ADBHelper.Tap(deviceID, goPoint.Value.X, goPoint.Value.Y);
                }

                Delay(2);

                row.Cells["Status"].Value = "Check OK";
                screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                var okPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.ok);
                //var okkPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, okk);
                if (okPoint != null)
                {
                    row.Cells["Status"].Value = "Click OK";
                    KAutoHelper.ADBHelper.Tap(deviceID, okPoint.Value.X, okPoint.Value.Y);
                    Delay(8);
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                    var resPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.mainActivity);
                    if (resPoint == null)
                    {
                        return;
                    }
                }/*
                else if (okkPoint != null)
                {
                    row.Cells["Status"].Value = "Click OKK";
                    KAutoHelper.ADBHelper.Tap(deviceID, okkPoint.Value.X, okkPoint.Value.Y);
                    Delay(8);
                    screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                    var resPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, bmp.mainActivity);
                    if (resPoint == null)
                    {
                        return;
                    }
                }*/
                else
                {
                    return;
                }
            }
        }

        static void Delay(int delay)
        {
            while (delay > 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                delay--;
            }
        }
    }
}
