﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing.Caching.Core;

namespace Bing.Caching.Options
{
    /// <summary>
    /// Redis 配置基类
    /// </summary>
    public class RedisOptionsBase
    {
        /// <summary>
        /// 获取或设置 用于连接到Redis服务器的密码
        /// </summary>
        public string Password { get; set; } = null;

        /// <summary>
        /// 获取或设置 一个值，该值指示是否使用SSL加密
        /// </summary>
        public bool IsSsl { get; set; } = false;

        /// <summary>
        /// 获取或设置 SSL主机。如果设置，它将在服务器的证书上强制执行这个特定的主机
        /// </summary>
        public string SslHost { get; set; } = null;

        /// <summary>
        /// 获取或设置 连接过期时间
        /// </summary>
        public int ConnectionTimeout { get; set; } = 5000;

        /// <summary>
        /// 获取 用于连接到Redis服务器的端点列表
        /// </summary>
        public IList<ServerEndPoint> EndPoints { get; }=new List<ServerEndPoint>();
    }
}
