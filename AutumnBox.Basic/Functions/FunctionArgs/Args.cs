﻿/*
 @zsh2401
 2017/9/6
 一些功能模块所需的参数
 */
using AutumnBox.Basic.Devices;
using AutumnBox.Basic.Functions.FunctionArgs;
using System;

namespace AutumnBox.Basic.Functions
{

    /// <summary>
    /// 用于文件发送器和自定义REC刷入器
    /// </summary>
    public class FileArgs : FMArgs
    {
        public string[] files;
    }
    /// <summary>
    /// 用于重启器的参数
    /// </summary>
    public class RebootArgs : FMArgs
    {
        public RebootOptions rebootOption;
        public DeviceStatus nowStatus;
    }
    /// <summary>
    /// 用于活动启动器的参数
    /// </summary>
    public class ActivityLaunchArgs : FMArgs
    {
        public string PackageName;
        public string ActivityName;
    }
}