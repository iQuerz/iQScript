﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iQScript_Configurator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("iQScript_Configurator.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap CapsLock {
            get {
                object obj = ResourceManager.GetObject("CapsLock", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap folder {
            get {
                object obj = ResourceManager.GetObject("folder", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #SingleInstance Force
        ///SetWorkingDir %A_ScriptDir%
        ///
        ///Gui, Color, 49B854
        ///Gui +LastFound +AlwaysOnTop +ToolWindow -Caption
        ///Gui, Add, Picture, w160 h72, ..\Tools-Data\CapsLock\Capslock.png
        ///WinSet, TransColor, 49B854
        ///Gui, Show, x0 y930
        ///SendInput !{Escape}
        ///
        ///CapsLock::
        ///	SetCapsLockState, Off
        ///	ExitApp.
        /// </summary>
        public static string iQcaps {
            get {
                return ResourceManager.GetString("iQcaps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #SingleInstance Force
        ///
        ///Gui, Font, cBlack
        ///Gui, Add, Text,, New version of script is available. Would you like to update?
        ///Gui, Add, Link,, &lt;a href=&quot;https://github.com/iQuerz/MyAHKScript&quot;&gt;Read about new version&lt;/a&gt;
        ///Gui, Font, cBlack
        ///Gui, Add, Button, Default gClose,  I&apos;ll Update myself
        ///Gui, Show, CenterAutosize, Update
        ///Return
        ///
        ///Update:
        ///	request := ComObjCreate(&quot;Msxml2.XMLHTTP&quot;)
        ///	request.Open(&quot;GET&quot;, &quot;https://raw.githubusercontent.com/iQuerz/MyAHKScript/main/script.ahk&quot;, true)
        ///	request.Send()
        ///	while [rest of string was truncated]&quot;;.
        /// </summary>
        public static string iQdialog {
            get {
                return ResourceManager.GetString("iQdialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #SingleInstance Force
        ///SetWorkingDir %A_ScriptDir%
        ///
        ///Gui, Color, 49B854
        ///Gui +LastFound +AlwaysOnTop +ToolWindow -Caption
        ///Gui, Add, Picture, w160 h72, ..\Tools-Data\NumPad\NumPad.png
        ///WinSet, TransColor, 49B854
        ///Gui, Show, x160 y930
        ///SendInput !{Escape}
        ///
        ///~^CapsLock::
        ///	ExitApp.
        /// </summary>
        public static string iQnumpad {
            get {
                return ResourceManager.GetString("iQnumpad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SetWorkingDir %A_ScriptDir%
        ///currentVersion = 2.0
        ///
        ///request := ComObjCreate(&quot;Msxml2.XMLHTTP&quot;)
        ///	request.Open(&quot;GET&quot;, &quot;https://raw.githubusercontent.com/iQuerz/MyAHKScript/main/ver.txt&quot;, true)
        ///	request.Send()
        ///	while (request.readyState != 4 &amp;&amp; A_Index &lt;= 50)    ; Wait for response 5s max (50*100 = 5000ms).
        ///		sleep 100
        ///	if request.readyState != 4 {
        ///		Goto Continue
        ///	}
        ///  	version := request.ResponseText
        ///
        ///If(currentVersion != version){
        ///	Run iQdialog.ahk
        ///}
        ///
        ///Continue:	; Continues to the script if upda [rest of string was truncated]&quot;;.
        /// </summary>
        public static string iQscript {
            get {
                return ResourceManager.GetString("iQscript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap NumPad {
            get {
                object obj = ResourceManager.GetObject("NumPad", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}