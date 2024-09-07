using Microsoft.Windows.ApplicationModel.DynamicDependency;

[assembly: WinUITestTarget(typeof(WinUIDemo.App))]

namespace WinUIDemo.Tests.MSTest;

[TestClass]
public class Initialize
{
    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext context)
    {
        // TODO: Initialize the appropriate version of the Windows App SDK.
        // This is required when testing MSIX apps that are framework-dependent on the Windows App SDK.
        Bootstrap.TryInitialize(0x00010001, out var _);
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        Bootstrap.Shutdown();
    }
}
