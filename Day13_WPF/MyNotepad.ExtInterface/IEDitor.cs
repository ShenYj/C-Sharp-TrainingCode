using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotepad.ExtInterface
{
    public class IEDitor
    {
        /// <summary>
        /// 当前插件的名称
        /// </summary>
        public string InterfaceName { get; set; }

        /// <summary>
        /// 运行该插件的功能
        /// </summary>
        public bool Run()
        {
            return false;
        }

    }
}
