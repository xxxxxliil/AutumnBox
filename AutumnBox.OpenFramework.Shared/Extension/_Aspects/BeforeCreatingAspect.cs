﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/10/18 20:00:56 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.Basic.Device;
using AutumnBox.OpenFramework.Content;
using System;

namespace AutumnBox.OpenFramework.Extension
{
    /// <summary>
    /// 创建前切面的参数
    /// </summary>
    public class BeforeCreatingAspectArgs
    {
        /// <summary>
        /// 上下文
        /// </summary>
        public Context Context { get;  }
        /// <summary>
        /// 拓展模块的Type
        /// </summary>
        public Type ExtensionType { get;  }
        /// <summary>
        /// 构建
        /// </summary>
        /// <param name="context"></param>
        /// <param name="extensionType"></param>
        public BeforeCreatingAspectArgs(Context context, Type extensionType) {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            ExtensionType = extensionType ?? throw new ArgumentNullException(nameof(extensionType));
        }
    }
    /// <summary>
    /// 创建前切面的基础实现
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public abstract class BeforeCreatingAspect : Attribute,IBeforeCreatingAspect
    {
        /// <summary>
        /// 具体实现
        /// </summary>
        /// <param name="args"></param>
        /// <param name="canContinue"></param>
        public abstract void BeforeCreating(BeforeCreatingAspectArgs args, ref bool canContinue);
    }
}
