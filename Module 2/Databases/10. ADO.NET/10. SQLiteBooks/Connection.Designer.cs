﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLiteBooks {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Connection : global::System.Configuration.ApplicationSettingsBase {
        
        private static Connection defaultInstance = ((Connection)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Connection())));
        
        public static Connection Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=../../db.sqlite;Version=3;")]
        public string SqLite {
            get {
                return ((string)(this["SqLite"]));
            }
            set {
                this["SqLite"] = value;
            }
        }
    }
}
