﻿using AutumnBox.OpenFramework.Content;
using AutumnBox.OpenFramework.Extension;
using AutumnBox.OpenFramework.Management;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.CoreModules.Extensions
{
    [ExtName("安装拓展模块")]
    [ExtAuth("zsh2401")]
    [ExtMinApi(8)]
    [ExtPriority(ExtPriority.HIGH)]
    [ExtIcon("Icons.add.png")]
    [ExtTargetApi(8)]
    [ContextPermission(CtxPer.High)]
    [ExtRegions("zh-cn")]
    [ExtRequiredDeviceStates(NoMatter)]
    class EInstallExtension : SharpExtension
    {
        protected override void Processing(Dictionary<string, object> data)
        {
            RunOnUIThread(()=> {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Reset();
                fileDialog.Title = "选择你要安装的拓展模块文件";
                fileDialog.Filter = "秋之盒拓展模块文件|*.dll;*.atmb;*.odll;*.adll";
                fileDialog.Multiselect = false;
                if (fileDialog.ShowDialog() == true) {
                    FileInfo result = new FileInfo(fileDialog.FileName);
                    string target = Path.Combine(Manager.InternalManager.ExtensionPath,result.Name);
                    File.Copy(result.FullName,target);
                }
                bool shouldReboot = Ux.DoYN("重启秋之盒才能使安装的模块生效,是否这么做?","重启秋之盒","不是现在");
                NewExtensionThread(typeof(ERestartApp)).Start();
            });
        }
    }
}
