// This file is automatically generated.
using System.Runtime.InteropServices;
using System.Text;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class ISteamInventory001VTable
{
    public IntPtr GetResultStatus0;
    public IntPtr GetResultItems1;
    public IntPtr GetResultTimestamp2;
    public IntPtr CheckResultSteamID3;
    public IntPtr DestroyResult4;
    public IntPtr GetAllItems5;
    public IntPtr GetItemsByID6;
    public IntPtr SerializeResult7;
    public IntPtr DeserializeResult8;
    public IntPtr GenerateItems9;
    public IntPtr GrantPromoItems10;
    public IntPtr AddPromoItem11;
    public IntPtr AddPromoItems12;
    public IntPtr ConsumeItem13;
    public IntPtr ExchangeItems14;
    public IntPtr TransferItemQuantity15;
    public IntPtr SendItemDropHeartbeat16;
    public IntPtr TriggerItemDrop17;
    public IntPtr TradeItems18;
    public IntPtr LoadItemDefinitions19;
    public IntPtr GetItemDefinitionIDs20;
    public IntPtr GetItemDefinitionProperty21;
    private IntPtr DTorISteamInventory00122;
};

public class ISteamInventory001 : InteropHelp.NativeWrapper<ISteamInventory001VTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeGetResultStatusI(IntPtr thisptr, Int32 resultHandle);
    public EResult GetResultStatus(Int32 resultHandle)
    {
        return this.GetFunction<NativeGetResultStatusI>(this.Functions.GetResultStatus0)(this.ObjectAddress, resultHandle);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetResultItemsISU(IntPtr thisptr, Int32 resultHandle, ref SteamItemDetails_t pOutItemsArray, ref UInt32 punOutItemsArraySize);
    public bool GetResultItems(Int32 resultHandle, ref SteamItemDetails_t pOutItemsArray, ref UInt32 punOutItemsArraySize)
    {
        return this.GetFunction<NativeGetResultItemsISU>(this.Functions.GetResultItems1)(this.ObjectAddress, resultHandle, ref pOutItemsArray, ref punOutItemsArraySize);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetResultTimestampI(IntPtr thisptr, Int32 resultHandle);
    public UInt32 GetResultTimestamp(Int32 resultHandle)
    {
        return this.GetFunction<NativeGetResultTimestampI>(this.Functions.GetResultTimestamp2)(this.ObjectAddress, resultHandle);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCheckResultSteamIDIC(IntPtr thisptr, Int32 resultHandle, UInt64 steamIDExpected);
    public bool CheckResultSteamID(Int32 resultHandle, CSteamID steamIDExpected)
    {
        return this.GetFunction<NativeCheckResultSteamIDIC>(this.Functions.CheckResultSteamID3)(this.ObjectAddress, resultHandle, steamIDExpected.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeDestroyResultI(IntPtr thisptr, Int32 resultHandle);
    public void DestroyResult(Int32 resultHandle)
    {
        this.GetFunction<NativeDestroyResultI>(this.Functions.DestroyResult4)(this.ObjectAddress, resultHandle);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAllItemsI(IntPtr thisptr, ref Int32 pResultHandle);
    public bool GetAllItems(ref Int32 pResultHandle)
    {
        return this.GetFunction<NativeGetAllItemsI>(this.Functions.GetAllItems5)(this.ObjectAddress, ref pResultHandle);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetItemsByIDIUU(IntPtr thisptr, ref Int32 pResultHandle, ref UInt64 pInstanceIDs, UInt32 unCountInstanceIDs);
    public bool GetItemsByID(ref Int32 pResultHandle, ref UInt64 pInstanceIDs, UInt32 unCountInstanceIDs)
    {
        return this.GetFunction<NativeGetItemsByIDIUU>(this.Functions.GetItemsByID6)(this.ObjectAddress, ref pResultHandle, ref pInstanceIDs, unCountInstanceIDs);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSerializeResultIBU(IntPtr thisptr, Int32 resultHandle, Byte[] pOutBuffer, ref UInt32 punOutBufferSize);
    public bool SerializeResult(Int32 resultHandle, Byte[] pOutBuffer, ref UInt32 punOutBufferSize)
    {
        return this.GetFunction<NativeSerializeResultIBU>(this.Functions.SerializeResult7)(this.ObjectAddress, resultHandle, pOutBuffer, ref punOutBufferSize);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeDeserializeResultIBUB(IntPtr thisptr, ref Int32 pOutResultHandle, Byte[] pBuffer, UInt32 unBufferSize, [MarshalAs(UnmanagedType.I1)] bool bRESERVED_MUST_BE_FALSE);
    public bool DeserializeResult(ref Int32 pOutResultHandle, Byte[] pBuffer, bool bRESERVED_MUST_BE_FALSE)
    {
        return this.GetFunction<NativeDeserializeResultIBUB>(this.Functions.DeserializeResult8)(this.ObjectAddress, ref pOutResultHandle, pBuffer, (UInt32)pBuffer.Length, bRESERVED_MUST_BE_FALSE);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGenerateItemsIIUU(IntPtr thisptr, ref Int32 pResultHandle, ref Int32 pArrayItemDefs, ref UInt32 punArrayQuantity, UInt32 unArrayLength);
    public bool GenerateItems(ref Int32 pResultHandle, ref Int32 pArrayItemDefs, ref UInt32 punArrayQuantity, UInt32 unArrayLength)
    {
        return this.GetFunction<NativeGenerateItemsIIUU>(this.Functions.GenerateItems9)(this.ObjectAddress, ref pResultHandle, ref pArrayItemDefs, ref punArrayQuantity, unArrayLength);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGrantPromoItemsI(IntPtr thisptr, ref Int32 pResultHandle);
    public bool GrantPromoItems(ref Int32 pResultHandle)
    {
        return this.GetFunction<NativeGrantPromoItemsI>(this.Functions.GrantPromoItems10)(this.ObjectAddress, ref pResultHandle);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAddPromoItemII(IntPtr thisptr, ref Int32 pResultHandle, Int32 itemDef);
    public bool AddPromoItem(ref Int32 pResultHandle, Int32 itemDef)
    {
        return this.GetFunction<NativeAddPromoItemII>(this.Functions.AddPromoItem11)(this.ObjectAddress, ref pResultHandle, itemDef);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAddPromoItemsIIU(IntPtr thisptr, ref Int32 pResultHandle, ref Int32 pArrayItemDefs, UInt32 unArrayLength);
    public bool AddPromoItems(ref Int32 pResultHandle, ref Int32 pArrayItemDefs, UInt32 unArrayLength)
    {
        return this.GetFunction<NativeAddPromoItemsIIU>(this.Functions.AddPromoItems12)(this.ObjectAddress, ref pResultHandle, ref pArrayItemDefs, unArrayLength);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeConsumeItemIUU(IntPtr thisptr, ref Int32 pResultHandle, UInt64 itemConsume, UInt32 unQuantity);
    public bool ConsumeItem(ref Int32 pResultHandle, UInt64 itemConsume, UInt32 unQuantity)
    {
        return this.GetFunction<NativeConsumeItemIUU>(this.Functions.ConsumeItem13)(this.ObjectAddress, ref pResultHandle, itemConsume, unQuantity);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeExchangeItemsIIUUUUU(IntPtr thisptr, ref Int32 pResultHandle, ref Int32 pArrayGenerate, ref UInt32 punArrayGenerateQuantity, UInt32 unArrayGenerateLength, ref UInt64 pArrayDestroy, ref UInt32 punArrayDestroyQuantity, UInt32 unArrayDestroyLength);
    public bool ExchangeItems(ref Int32 pResultHandle, ref Int32 pArrayGenerate, ref UInt32 punArrayGenerateQuantity, UInt32 unArrayGenerateLength, ref UInt64 pArrayDestroy, ref UInt32 punArrayDestroyQuantity, UInt32 unArrayDestroyLength)
    {
        return this.GetFunction<NativeExchangeItemsIIUUUUU>(this.Functions.ExchangeItems14)(this.ObjectAddress, ref pResultHandle, ref pArrayGenerate, ref punArrayGenerateQuantity, unArrayGenerateLength, ref pArrayDestroy, ref punArrayDestroyQuantity, unArrayDestroyLength);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeTransferItemQuantityIUUU(IntPtr thisptr, ref Int32 pResultHandle, UInt64 itemIdSource, UInt32 unQuantity, UInt64 itemIdDest);
    public bool TransferItemQuantity(ref Int32 pResultHandle, UInt64 itemIdSource, UInt32 unQuantity, UInt64 itemIdDest)
    {
        return this.GetFunction<NativeTransferItemQuantityIUUU>(this.Functions.TransferItemQuantity15)(this.ObjectAddress, ref pResultHandle, itemIdSource, unQuantity, itemIdDest);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSendItemDropHeartbeat(IntPtr thisptr);
    public void SendItemDropHeartbeat()
    {
        this.GetFunction<NativeSendItemDropHeartbeat>(this.Functions.SendItemDropHeartbeat16)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeTriggerItemDropII(IntPtr thisptr, ref Int32 pResultHandle, Int32 dropListDefinition);
    public bool TriggerItemDrop(ref Int32 pResultHandle, Int32 dropListDefinition)
    {
        return this.GetFunction<NativeTriggerItemDropII>(this.Functions.TriggerItemDrop17)(this.ObjectAddress, ref pResultHandle, dropListDefinition);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeTradeItemsICUUUUUU(IntPtr thisptr, ref Int32 pResultHandle, UInt64 steamIDTradePartner, ref UInt64 pArrayGive, ref UInt32 pArrayGiveQuantity, UInt32 nArrayGiveLength, ref UInt64 pArrayGet, ref UInt32 pArrayGetQuantity, UInt32 nArrayGetLength);
    public bool TradeItems(ref Int32 pResultHandle, CSteamID steamIDTradePartner, ref UInt64 pArrayGive, ref UInt32 pArrayGiveQuantity, UInt32 nArrayGiveLength, ref UInt64 pArrayGet, ref UInt32 pArrayGetQuantity, UInt32 nArrayGetLength)
    {
        return this.GetFunction<NativeTradeItemsICUUUUUU>(this.Functions.TradeItems18)(this.ObjectAddress, ref pResultHandle, steamIDTradePartner.ConvertToUint64(), ref pArrayGive, ref pArrayGiveQuantity, nArrayGiveLength, ref pArrayGet, ref pArrayGetQuantity, nArrayGetLength);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeLoadItemDefinitions(IntPtr thisptr);
    public bool LoadItemDefinitions()
    {
        return this.GetFunction<NativeLoadItemDefinitions>(this.Functions.LoadItemDefinitions19)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetItemDefinitionIDsIU(IntPtr thisptr, ref Int32 pItemDefIDs, ref UInt32 punItemDefIDsArraySize);
    public bool GetItemDefinitionIDs(ref Int32 pItemDefIDs, ref UInt32 punItemDefIDsArraySize)
    {
        return this.GetFunction<NativeGetItemDefinitionIDsIU>(this.Functions.GetItemDefinitionIDs20)(this.ObjectAddress, ref pItemDefIDs, ref punItemDefIDsArraySize);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetItemDefinitionPropertyISSU(IntPtr thisptr, Int32 iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, ref UInt32 punValueBufferSize);
    public bool GetItemDefinitionProperty(Int32 iDefinition, string pchPropertyName, StringBuilder pchValueBuffer, ref UInt32 punValueBufferSize)
    {
        return this.GetFunction<NativeGetItemDefinitionPropertyISSU>(this.Functions.GetItemDefinitionProperty21)(this.ObjectAddress, iDefinition, pchPropertyName, pchValueBuffer, ref punValueBufferSize);
    }
};