﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ik.Framework.DataAccess
{
    [XmlRoot(DataSourcesConfigurationSectionHandler.ConfigSectionName)]
    public class DataSourcesConfig
    {
        [XmlElement("dataSource")]
        public List<DataSource> DataSources { get; set; }
    }

    public class DataSource
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("provider")]
        public DataSourceProvider Provider { get; set; }

        /// <summary>
        /// 可读写连接
        /// </summary>
        [XmlElement("readWriteConnection")]
        public ConnectionSettingConfig ReadWriteConnectionString { get; set; }
        /// <summary>
        /// 只读连接
        /// </summary>
        [XmlElement("readOnlyConnection")]
        public ConnectionSettingConfig ReadOnlyConnectionString { get; set; }
    }

    /// <summary>
    /// 连接信息
    /// </summary>
    public class ConnectionSettingConfig
    {
        [XmlAttribute("connectionString")]
        public string ConnectionString { get; set; }
    }

    public enum DataSourceProvider
    {
        SQLServer, MySQL
    }
}

#region copyright
/*
*.NET基础开发框架
*Copyright (C) 。。。
*地址：git@github.com:gangzaicd/Ik.Framework.git
*作者：到大叔碗里来（大叔）
*QQ：397754531
*eMail：gangzaicd@163.com
*/
#endregion copyright
