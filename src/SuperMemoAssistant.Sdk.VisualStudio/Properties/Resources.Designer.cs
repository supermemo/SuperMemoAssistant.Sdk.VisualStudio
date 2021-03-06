﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperMemoAssistant.Sdk.VisualStudio.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SuperMemoAssistant.Sdk.VisualStudio.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Visual Studio automation (DTE2) object is null. Aborting.
        /// </summary>
        internal static string Error_InvalidDTE {
            get {
                return ResourceManager.GetString("Error_InvalidDTE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Visual Studio solution (Solution4) object is null. Aborting.
        /// </summary>
        internal static string Error_InvalidDTESolution {
            get {
                return ResourceManager.GetString("Error_InvalidDTESolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: You can only this template inside a SMA solution. Use the &apos;SuperMemoAssistant Plugin (Solution + Project)&apos; template instead..
        /// </summary>
        internal static string Error_InvalidSolution {
            get {
                return ResourceManager.GetString("Error_InvalidSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: This solution doesn&apos;t contain a &apos;global.json&apos; file under its &apos;src&apos; folder. Bootstrap a new solution with the &apos;SuperMemoAssistant Plugin (Solution + Project)&apos; template instead.
        ///&apos;src&apos; folder resolved to: {0}..
        /// </summary>
        internal static string Error_NoGlobalJson {
            get {
                return ResourceManager.GetString("Error_NoGlobalJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: This solution doesn&apos;t contain a &apos;src&apos; folder, or it doesn&apos;t contain any SMA plugin. Bootstrap a new solution with the &apos;SuperMemoAssistant Plugin (Solution + Project)&apos; template instead..
        /// </summary>
        internal static string Error_NoSrcFolder {
            get {
                return ResourceManager.GetString("Error_NoSrcFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: _smaSolution is null but the wizard is creating a new solution. Aborting..
        /// </summary>
        internal static string Error_SmaSolutionNull {
            get {
                return ResourceManager.GetString("Error_SmaSolutionNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: This template can only be used to create a new SMA solution..
        /// </summary>
        internal static string Error_SolutionAlreadyExists {
            get {
                return ResourceManager.GetString("Error_SolutionAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: Template folder &apos;{0}&apos; doesn&apos;t exist. Your Visual Studio SMA Sdk might be corrupted. Aborting.
        /// </summary>
        internal static string Error_TemplateMissing {
            get {
                return ResourceManager.GetString("Error_TemplateMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: customParams[0] is &apos;{0}&apos;. Expected a path to the template instead. Aborting..
        /// </summary>
        internal static string Error_TemplateParamMissing {
            get {
                return ResourceManager.GetString("Error_TemplateParamMissing", resourceCulture);
            }
        }
    }
}
