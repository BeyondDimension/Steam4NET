// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class IClientProductBuilderVTable
{
    public IntPtr SignInstallScript0;
    public IntPtr DRMWrap1;
    public IntPtr CEGWrap2;
    private IntPtr DTorIClientProductBuilder3;
};

[InteropHelp.InterfaceVersion("CLIENTDEPOTBUILDER_INTERFACE_VERSION001")]
public class IClientProductBuilder : InteropHelp.NativeWrapper<IClientProductBuilderVTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSignInstallScriptUSS(IntPtr thisptr, UInt32 arg0, string arg1, string arg2);
    public UInt64 SignInstallScript(UInt32 arg0, string arg1, string arg2)
    {
        return this.GetFunction<NativeSignInstallScriptUSS>(this.Functions.SignInstallScript0)(this.ObjectAddress, arg0, arg1, arg2);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDRMWrapUSSSU(IntPtr thisptr, UInt32 arg0, string arg1, string arg2, string arg3, UInt32 arg4);
    public UInt64 DRMWrap(UInt32 arg0, string arg1, string arg2, string arg3, UInt32 arg4)
    {
        return this.GetFunction<NativeDRMWrapUSSSU>(this.Functions.DRMWrap1)(this.ObjectAddress, arg0, arg1, arg2, arg3, arg4);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCEGWrapUSSS(IntPtr thisptr, UInt32 arg0, string arg1, string arg2, string arg3);
    public UInt64 CEGWrap(UInt32 arg0, string arg1, string arg2, string arg3)
    {
        return this.GetFunction<NativeCEGWrapUSSS>(this.Functions.CEGWrap2)(this.ObjectAddress, arg0, arg1, arg2, arg3);
    }
};