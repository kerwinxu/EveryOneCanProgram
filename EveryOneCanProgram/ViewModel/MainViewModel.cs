using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryOneCanProgram.ViewModel
{
    /// <summary>
    /// 主页的,ObservableRecipient相当于MVVMLight 中的 ViewModelBase,不过有Message功能
    /// </summary>
    public class MainViewModel : ObservableRecipient
    {

        // 如下是例子。
        //private string hello = "hello world";
        //public string Hello
        //{
        //    get { return hello; } set { SetProperty(ref hello, value); }
        //}

    }
}
