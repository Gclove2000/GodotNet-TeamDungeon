﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team_Dungeon.SceneModels;
using Team_Dungeon.Utils;

namespace Team_Dungeon
{
    public class Program
    {
        /// <summary>
        /// IOC容器
        /// </summary>
        public static IServiceProvider Services = ConfigureServices();
        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var builder = new ServiceCollection();
            AddSingleton(builder);
            AddTransient(builder);
            return builder.BuildServiceProvider();
        }
        /// <summary>
        /// 添加服务，应以Singleton形式添加
        /// </summary>
        /// <param name="service"></param>
        public static void AddSingleton(ServiceCollection builder)
        {

            builder.AddSingleton<NlogHelper>();
            builder.AddSingleton<MainSceneModel>();
            builder.AddSingleton<FreeSqlHelper>();
        }
        /// <summary>
        /// 添加SceneModel，应以Transient添加
        /// </summary>
        /// <param name="service"></param>
        public static void AddTransient(ServiceCollection builder)
        {
            builder.AddTransient<PrintHelper>();
        }
    }

}
