using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView练习
{
    public class USBDevice
    {
        public enum DeviceState
        {
            //
            // 摘要:
            //     驱动器类型未知。
            Unknown = 0,
            //
            // 摘要:
            //     此驱动器没有根目录。
            NoRootDirectory = 1,
            //
            // 摘要:
            //     此驱动器是一个可移动存储设备，如软盘驱动器或 USB 闪存驱动器。
            Removable = 2,
            //
            // 摘要:
            //     此驱动器是一个固定磁盘。
            Fixed = 3,
            //
            // 摘要:
            //     此驱动器是一个网络驱动器。
            Network = 4,
            //
            // 摘要:
            //     此驱动器是一个光盘设备，如 CD 或 DVD-ROM。
            CDRom = 5,
            //
            // 摘要:
            //     此驱动器是一个 RAM 磁盘。
            Ram = 6
        }
        /// <summary>
        /// 盘符
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public DriveType DeviceType { get; set; }

        public USBDevice(string Path, DriveType type)
        {
            this.Path = Path;
            this.DeviceType = type;
        }

    }
}
