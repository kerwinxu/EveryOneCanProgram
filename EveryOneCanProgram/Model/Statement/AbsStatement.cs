using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryOneCanProgram.Model
{
    /// <summary>
    /// 语句类
    /// </summary>
    public class AbsStatement: ObservableObject
    {

        // todo 这个坐标没有考虑画布移动的情况，这里可以用IOC取得CanvasOrigin画布原点的

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
