﻿


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal static class Application
    {
        public static global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Current
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::Microsoft.LightSwitch.Framework.Base.ApplicationProvider.Current;
            }
        }
    }
}
namespace LightSwitchApplication
{
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Model.IModuleDefinitionLoader))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
    [global::Microsoft.LightSwitch.Model.ModuleDefinitionLoader("LightSwitchCommonModule")]
    public class CommonModuleLoader : global::Microsoft.LightSwitch.Model.IModuleDefinitionLoader
    {
        public global::System.Resources.ResourceManager GetModelResourceManager()
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerable<global::System.IO.Stream> LoadModelFragments()
        {
            global::System.Reflection.Assembly assembly = global::System.Reflection.Assembly.GetExecutingAssembly();
            global::System.Collections.Generic.List<global::System.IO.Stream> streams = new global::System.Collections.Generic.List<global::System.IO.Stream>();

            foreach (string resourceName in assembly.GetManifestResourceNames())
            {
                if (resourceName.EndsWith(".lsml", global::System.StringComparison.OrdinalIgnoreCase))
                {
                    streams.Add(assembly.GetManifestResourceStream(resourceName));
                }
            }

            return streams;
        }
    }
}
