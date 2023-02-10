using System.Reflection;

namespace Steam4NET;

class CallbackIdentities
{
    public static int GetCallbackIdentity(Type callbackStruct)
    {
        foreach (var attribute in callbackStruct.GetCustomAttributes<InteropHelp.CallbackIdentityAttribute>(false))
        {
            return attribute.Identity;
        }

        throw new Exception("Callback number not found for struct " + callbackStruct);
    }
}