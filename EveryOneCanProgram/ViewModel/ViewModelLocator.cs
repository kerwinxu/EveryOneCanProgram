using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryOneCanProgram.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            // 注册各个窗口
            serviceProvider = configService();
            Ioc.Default.ConfigureServices(serviceProvider);


        }

        public IServiceProvider serviceProvider { get; set; }

        /// <summary>
        /// 注册放在这里边
        /// </summary>
        /// <returns></returns>
        private static IServiceProvider configService()
        {
            var service = new ServiceCollection();
            // 如下注册窗口
            service.AddSingleton<MainViewModel>();
            service.AddSingleton<CanvasOrigin>();

            return service.BuildServiceProvider();
        }

        /// <summary>
        /// 主窗口的ViewModel
        /// </summary>
        public MainViewModel Main {
            get
            {
                return  Ioc.Default.GetService<MainViewModel>();
            }
        }

        public CanvasOrigin CanvasOrigin
        {
            get
            {
                return Ioc.Default.GetService<CanvasOrigin>();
            }
        }

    }
}
