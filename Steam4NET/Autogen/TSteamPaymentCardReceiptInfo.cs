// This file is automatically generated.
using System;
using System.Runtime.InteropServices;

namespace Steam4NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct TSteamPaymentCardReceiptInfo
    {
        public ESteamPaymentCardType eCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string szCardLastFourDigits;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string szCardHolderName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string szBillingAddress1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string szBillingAddress2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string szBillingCity;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string szBillingZip;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string szBillingState;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string szBillingCountry;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string szCardApprovalCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string szTransDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        public string szTransTime;
        public UInt32 uPriceWithoutTax;
        public UInt32 uTaxAmount;
        public UInt32 uShippingCost;
    };
}