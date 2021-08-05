﻿using Furion;
using Furion.DependencyInjection;
using Furion.Extras.DatabaseAccessor.FreeSql.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurionApi.Core.Managers
{
    /// <summary>
    /// Manager父类
    /// </summary>
    public abstract class BaseManager :IScoped
    {
        protected IFreeSql FreeSql = null;

        /// <summary>
        /// 默认使用DefaultConn数据库
        /// </summary>
        public BaseManager() : this(App.Configuration["Connection:0:DbKey"]) { }

        /// <summary>
        /// 根据传入的key使用数据库
        /// </summary>
        /// <param name="connKey"></param>
        public BaseManager(string connKey)
        {
            FreeSql = App.GetRequiredService<IFreeSql>().Change(connKey);
        }

        /// <summary>
        /// 运行期间更改数据库
        /// </summary>
        /// <param name="connKey"></param>
        protected void Change(string connKey)
        {
            FreeSql = App.GetRequiredService<IFreeSql>().Change(connKey);
        }
    }
}
