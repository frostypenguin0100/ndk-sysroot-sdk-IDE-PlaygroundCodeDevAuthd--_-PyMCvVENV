﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.TemplateEngine.Cli.Commands {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SymbolStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SymbolStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.TemplateEngine.Cli.Commands.SymbolStrings", typeof(SymbolStrings).Assembly);
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
        ///   Looks up a localized string similar to Creates or displays defined aliases..
        /// </summary>
        internal static string Command_Alias_Description {
            get {
                return ResourceManager.GetString("Command_Alias_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creates an alias for instantiate command with a certain set of arguments..
        /// </summary>
        internal static string Command_AliasAdd_Description {
            get {
                return ResourceManager.GetString("Command_AliasAdd_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays defined aliases..
        /// </summary>
        internal static string Command_AliasShow_Description {
            get {
                return ResourceManager.GetString("Command_AliasShow_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet package ID or path to folder or NuGet package to install. 
        ///To install the NuGet package of certain version, use &lt;package ID&gt;::&lt;version&gt;.
        ///.
        /// </summary>
        internal static string Command_Install_Argument_Package {
            get {
                return ResourceManager.GetString("Command_Install_Argument_Package", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installs a template package..
        /// </summary>
        internal static string Command_Install_Description {
            get {
                return ResourceManager.GetString("Command_Install_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A short name of the template to create..
        /// </summary>
        internal static string Command_Instantiate_Argument_ShortName {
            get {
                return ResourceManager.GetString("Command_Instantiate_Argument_ShortName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template specific options to use..
        /// </summary>
        internal static string Command_Instantiate_Argument_TemplateOptions {
            get {
                return ResourceManager.GetString("Command_Instantiate_Argument_TemplateOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instantiates a template with given short name..
        /// </summary>
        internal static string Command_Instantiate_Description {
            get {
                return ResourceManager.GetString("Command_Instantiate_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checks the currently installed template packages for updates..
        /// </summary>
        internal static string Command_Legacy_Update_Check_Description {
            get {
                return ResourceManager.GetString("Command_Legacy_Update_Check_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, only the templates matching the name will be shown..
        /// </summary>
        internal static string Command_List_Argument_Name {
            get {
                return ResourceManager.GetString("Command_List_Argument_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lists templates containing the specified template name. If no name is specified, lists all templates..
        /// </summary>
        internal static string Command_List_Description {
            get {
                return ResourceManager.GetString("Command_List_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template Instantiation Commands for .NET CLI..
        /// </summary>
        internal static string Command_New_Description {
            get {
                return ResourceManager.GetString("Command_New_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, only the templates matching the name will be shown..
        /// </summary>
        internal static string Command_Search_Argument_Name {
            get {
                return ResourceManager.GetString("Command_Search_Argument_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Searches for the templates on NuGet.org..
        /// </summary>
        internal static string Command_Search_Description {
            get {
                return ResourceManager.GetString("Command_Search_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet package ID (without version) or path to folder to uninstall. 
        ///If command is specified without the argument, it lists all the template packages installed..
        /// </summary>
        internal static string Command_Uninstall_Argument_Package {
            get {
                return ResourceManager.GetString("Command_Uninstall_Argument_Package", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstalls a template package..
        /// </summary>
        internal static string Command_Uninstall_Description {
            get {
                return ResourceManager.GetString("Command_Uninstall_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checks the currently installed template packages for update, and install the updates..
        /// </summary>
        internal static string Command_Update_Description {
            get {
                return ResourceManager.GetString("Command_Update_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only check for updates and display the template packages to be updated without applying update..
        /// </summary>
        internal static string Command_Update_Option_CheckOnly {
            get {
                return ResourceManager.GetString("Command_Update_Option_CheckOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disables checking if the template meets the constraints to be run..
        /// </summary>
        internal static string ListCommand_Option_IgnoreConstraints {
            get {
                return ResourceManager.GetString("ListCommand_Option_IgnoreConstraints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies a NuGet source to use during install..
        /// </summary>
        internal static string Option_AddSource {
            get {
                return ResourceManager.GetString("Option_AddSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filters the templates based on the template author..
        /// </summary>
        internal static string Option_AuthorFilter {
            get {
                return ResourceManager.GetString("Option_AuthorFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filters the templates based on baseline defined in the template..
        /// </summary>
        internal static string Option_BaselineFilter {
            get {
                return ResourceManager.GetString("Option_BaselineFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the columns to display in the output. .
        /// </summary>
        internal static string Option_Columns {
            get {
                return ResourceManager.GetString("Option_Columns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display all columns in the output..
        /// </summary>
        internal static string Option_ColumnsAll {
            get {
                return ResourceManager.GetString("Option_ColumnsAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows to pause execution in order to attach to the process for debug purposes..
        /// </summary>
        internal static string Option_Debug_Attach {
            get {
                return ResourceManager.GetString("Option_Debug_Attach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets custom settings location..
        /// </summary>
        internal static string Option_Debug_CustomSettings {
            get {
                return ResourceManager.GetString("Option_Debug_CustomSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, removes the template cache prior to command execution..
        /// </summary>
        internal static string Option_Debug_RebuildCache {
            get {
                return ResourceManager.GetString("Option_Debug_RebuildCache", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, resets the settings prior to command execution..
        /// </summary>
        internal static string Option_Debug_Reinit {
            get {
                return ResourceManager.GetString("Option_Debug_Reinit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, shows the template engine config prior to command execution..
        /// </summary>
        internal static string Option_Debug_ShowConfig {
            get {
                return ResourceManager.GetString("Option_Debug_ShowConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified, the settings will be not preserved on file system..
        /// </summary>
        internal static string Option_Debug_VirtualSettings {
            get {
                return ResourceManager.GetString("Option_Debug_VirtualSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows installing template packages from the specified sources even if they would override a template package from another source..
        /// </summary>
        internal static string Option_Install_Force {
            get {
                return ResourceManager.GetString("Option_Install_Force", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allows the command to stop and wait for user input or action (for example to complete authentication)..
        /// </summary>
        internal static string Option_Interactive {
            get {
                return ResourceManager.GetString("Option_Interactive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filters templates based on language..
        /// </summary>
        internal static string Option_LanguageFilter {
            get {
                return ResourceManager.GetString("Option_LanguageFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location to place the generated output..
        /// </summary>
        internal static string Option_Output {
            get {
                return ResourceManager.GetString("Option_Output", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filters the templates based on NuGet package ID..
        /// </summary>
        internal static string Option_PackageFilter {
            get {
                return ResourceManager.GetString("Option_PackageFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project that should be used for context evaluation..
        /// </summary>
        internal static string Option_ProjectPath {
            get {
                return ResourceManager.GetString("Option_ProjectPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filters the templates based on the tag..
        /// </summary>
        internal static string Option_TagFilter {
            get {
                return ResourceManager.GetString("Option_TagFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filters templates based on available types. Predefined values are &quot;project&quot; and &quot;item&quot;..
        /// </summary>
        internal static string Option_TypeFilter {
            get {
                return ResourceManager.GetString("Option_TypeFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies if post action scripts should run..
        /// </summary>
        internal static string TemplateCommand_Option_AllowScripts {
            get {
                return ResourceManager.GetString("TemplateCommand_Option_AllowScripts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the baseline to instantiate..
        /// </summary>
        internal static string TemplateCommand_Option_Baseline {
            get {
                return ResourceManager.GetString("TemplateCommand_Option_Baseline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays a summary of what would happen if the given command line were run if it would result in a template creation..
        /// </summary>
        internal static string TemplateCommand_Option_DryRun {
            get {
                return ResourceManager.GetString("TemplateCommand_Option_DryRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forces content to be generated even if it would change existing files..
        /// </summary>
        internal static string TemplateCommand_Option_Force {
            get {
                return ResourceManager.GetString("TemplateCommand_Option_Force", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the template language to instantiate..
        /// </summary>
        internal static string TemplateCommand_Option_Language {
            get {
                return ResourceManager.GetString("TemplateCommand_Option_Language", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name for the output being created. If no name is specified, the name of the output directory is used..
        /// </summary>
        internal static string TemplateCommand_Option_Name {
            get {
                return ResourceManager.GetString("TemplateCommand_Option_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disables checking for the template package updates when instantiating a template..
        /// </summary>
        internal static string TemplateCommand_Option_NoUpdateCheck {
            get {
                return ResourceManager.GetString("TemplateCommand_Option_NoUpdateCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the template type to instantiate..
        /// </summary>
        internal static string TemplateCommand_Option_Type {
            get {
                return ResourceManager.GetString("TemplateCommand_Option_Type", resourceCulture);
            }
        }
    }
}