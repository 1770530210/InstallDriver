﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstallDriver.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InstallDriver.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] aicusbdisplaydriver {
            get {
                object obj = ResourceManager.GetObject("aicusbdisplaydriver", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] AicUsbDisplayDriver1 {
            get {
                object obj = ResourceManager.GetObject("AicUsbDisplayDriver1", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 ;
        ///; AicUsbDisplayDriver.inf
        ///;
        ///
        ///[Version]
        ///PnpLockDown=1
        ///Signature=&quot;$Windows NT$&quot;
        ///ClassGUID = {4D36E968-E325-11CE-BFC1-08002BE10318}
        ///Class = Display
        ///ClassVer = 2.0
        ///Provider=%ManufacturerName%
        ///CatalogFile=AicUsbDisplayDriver.cat
        ///DriverVer = 07/26/2024,16.11.8.139
        ///
        ///[Manufacturer]
        ///%ManufacturerName%=Standard,NTamd64
        ///
        ///[Standard.NTamd64]
        ///%DeviceName%=MyDevice_Install, USB\VID_33C3&amp;PID_0E01 ;
        ///%DeviceName%=MyDevice_Install, USB\VID_33C3&amp;PID_0E02&amp;MI_00 ;
        ///
        ///[SourceDisksFiles]
        ///AicUsbDisplayDriver.d [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string AicUsbDisplayDriver2 {
            get {
                return ResourceManager.GetString("AicUsbDisplayDriver2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] devcon {
            get {
                object obj = ResourceManager.GetObject("devcon", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] dpinst {
            get {
                object obj = ResourceManager.GetObject("dpinst", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] DriverTrust {
            get {
                object obj = ResourceManager.GetObject("DriverTrust", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
