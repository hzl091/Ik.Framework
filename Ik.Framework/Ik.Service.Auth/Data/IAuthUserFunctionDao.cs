﻿using Ik.Framework.DataAccess;
using Ik.Framework.DependencyManagement;
using Ik.Service.Auth.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Service.Auth.Data
{
    public interface IAuthUserFunctionDao
    {
        IList<AuthUserGroupFunction> GetUserGroupFunctionListByRefUserCode(string refUserCode);

        IList<AuthUserFunction> GetUserFunctionListByRefUserCode(string refUserCode);


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
