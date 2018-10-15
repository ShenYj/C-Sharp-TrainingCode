using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ListView练习
{

    class CheckUSBDeviceTool
    {
        /// <summary>
        /// 设备检查轮询器
        /// </summary>
        private System.Windows.Threading.DispatcherTimer _tmrECGDeviceFind;

        static private CheckUSBDeviceTool _instancyType = null;

        private CheckUSBDeviceTool()
        {
            
        }

        //[STAThread]
        public static CheckUSBDeviceTool SharedUSBDeviceTool()
        {
            if (_instancyType == null)
            {
                _instancyType = new CheckUSBDeviceTool();
            }
            return _instancyType;
        }

        public void CheckUSBDeviceTimer()
        {
            _tmrECGDeviceFind = new System.Windows.Threading.DispatcherTimer();
            _tmrECGDeviceFind.Interval = new TimeSpan(0, 0, 0, 3, 0);
            _tmrECGDeviceFind.Tick += StartTimer;
            _tmrECGDeviceFind.IsEnabled = true;
            StartTimer(null, null);
        }

        private void StartTimer(object sender, EventArgs e)
        {
            // 异步检查USB外设
            BackgroundWorker checkUSBDeviceBGWorker = new BackgroundWorker();
            checkUSBDeviceBGWorker.DoWork += checkUSBDeviceBGWorker_DoWork;
            checkUSBDeviceBGWorker.WorkerReportsProgress = true;
            checkUSBDeviceBGWorker.ProgressChanged += checkUSBDeviceBGWorkerr_ProgressChanged;
            checkUSBDeviceBGWorker.RunWorkerCompleted += checkUSBDeviceBGWorkerr_RunWorkerCompleted;
            checkUSBDeviceBGWorker.WorkerSupportsCancellation = true;
            checkUSBDeviceBGWorker.RunWorkerAsync();
            //checkUSBDeviceBGWorker.RunWorkerAsync(3);
        }

        /// <summary>
        /// 检查USB设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkUSBDeviceBGWorker_DoWork(object sender, EventArgs e)
        {
            try
            {
                // USB 路径集合
                List<USBDevice> usbPathList = CheckUSBDriveInfoList();
                Thread.Sleep(1000);
                List<object> usbDeviceList = new List<object>();
                foreach (USBDevice usbDevice in usbPathList)
                {
                    //ECGDeviceInfo ecgdi = _fileAccess.CheckECGDeviceInfo(usbPath);
                    //if (ecgdi != null) usbDeviceList.Add(ecgdi);
                    Thread.Sleep(1000);
                    Console.WriteLine("USB设备路径：" + usbDevice.Path);
                    Thread.Sleep(1000);
                }
            }
            catch
            { }
        }

        /// <summary>
        /// 操作进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkUSBDeviceBGWorkerr_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("操作进度：" + e.ProgressPercentage);
        }

        /// <summary>
        /// 检查USB设备操作执行完毕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkUSBDeviceBGWorkerr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Operation Cancelled");
            }
            else
            {
                //MessageBox.Show("OperationCompleted");
            }
        }
        /// <summary>
        /// 加载磁盘信息
        /// </summary>
        private List<USBDevice> CheckUSBDriveInfoList()
        {
            List<USBDevice> allDevices = new List<USBDevice>();
            DriveInfo[] allDirves = DriveInfo.GetDrives();
            //检索计算机上的所有逻辑驱动器名称
            foreach (DriveInfo item in allDirves)
            {
                if (item.DriveType == DriveType.Removable && item.IsReady)
                {
                    USBDevice device = new USBDevice(item.Name, item.DriveType);
                    allDevices.Add(device);
                }
            }
            return allDevices;
        }
    }
}
