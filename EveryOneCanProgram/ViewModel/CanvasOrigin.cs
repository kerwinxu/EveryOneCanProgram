using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryOneCanProgram.ViewModel
{
    /// <summary>
    /// 画布原点坐标的
    /// </summary>
    public class CanvasOrigin: ObservableObject
    {
        private int x;
        /// <summary>
        /// x坐标
        /// </summary>
        public int X
        {
            get { return x; }
            set { SetProperty(ref x, value); }
        }


        private int y;
        /// <summary>
        /// y坐标
        /// </summary>
        public int Y
        {
            get { return y; }
            set { SetProperty(ref y, value); }
        }
    }
}
