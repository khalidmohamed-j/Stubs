// <assemblyHash>4db90aa5</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=16.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias mqttf;
extern alias si;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("SpacecraftInterface", false)]
[assembly: global::System.Reflection.AssemblyCompany("SpacecraftInterface")]
[assembly: global::System.Reflection.AssemblyConfiguration("Debug")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyInformationalVersion("1.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("SpacecraftInterface")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace SpacecraftInterface.Fakes
{
    /// <summary>Shim type of SpacecraftInterface.Telemetry</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(si::SpacecraftInterface.Telemetry))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of Telemetry")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public sealed partial class ShimTelemetry
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase
    {
        /// <summary>Initializes a new shim instance</summary>
        private ShimTelemetry()
        : base(typeof(si::SpacecraftInterface.Telemetry))
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::SpacecraftInterface.Fakes.ShimTelemetry.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::SpacecraftInterface.Fakes.ShimTelemetry.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(si::SpacecraftInterface.Telemetry), value);
            }
        }

        /// <summary>Sets the Shim of Telemetry.GetTempFromSpacecraft()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<double> GetTempFromSpacecraft
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("GetTempFromSpacecraft", 24)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicStatic
                    ((global::System.Delegate)value, typeof(si::SpacecraftInterface.Telemetry), 
                     "GetTempFromSpacecraft", typeof(double), new global::System.Type[]{});
            }
        }
    }
}
