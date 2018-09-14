﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/8/18 1:02:23 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.Basic.Device;
using AutumnBox.OpenFramework.Open;

namespace AutumnBox.OpenFramework.Extension
{
    partial class AutumnBoxExtension
    {
        /// <summary>
        /// 无关
        /// </summary>
        public const DeviceState NoMatter = (DeviceState)(1<<24);
        /// <summary>
        /// 所有状态
        /// </summary>
        public const DeviceState AllState = (DeviceState)0b11111111;
        /// <summary>
        /// 完全成功
        /// </summary>
        public const int OK = 0;
        /// <summary>
        /// 发生错误
        /// </summary>
        public const int ERR = 1;
        /// <summary>
        /// 被用户在执行过程中的某个步骤取消
        /// </summary>
        public const int ERR_CANCLLED_BY_USER = 2;
    }
}
