using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Model
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct QQWalletInfoDataList
    {
        //public int index;
        public QQWalletInformation qQWalletInformation;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct QQWalletInformation
    {
        // 余额
        /// <summary>
        /// 余额
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string Balance;
        // 身份证号
        /// <summary>
        /// 身份证号
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string ID;
        // 实名
        /// <summary>
        /// 实名
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string RealName;
        // 银行卡列表
        /// <summary>
        /// 银行卡列表
        /// </summary>
        public CardInfoDataList[] CardList;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CardInfoDataList
    {
        public int index;//数组索引
        public int Amount;//数组元素数量
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]//5000人群 5000/4+8 =1258
        public byte[] pAddrList;//每个元素的指针
    }

    [StructLayout(LayoutKind.Sequential,Pack =1)]
    public struct CardInformation
    {
        // 序列
        /// <summary>
        /// 序列
        /// </summary>
        public int Serial;
        // 尾号
        /// <summary>
        /// 尾号
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string TailNumber;
        // 银行
        /// <summary>
        /// 银行
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string Bank;
        // 绑定手机
        /// <summary>
        /// 绑定手机
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string BindPhone;
        // bind_serial
        /// <summary>
        /// bind_serial
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string BindSerial;
        // bank_type
        /// <summary>
        /// bank_type
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string BankType;
    }

    public struct RetQQWalletInformation
    {
        // 余额
        /// <summary>
        /// 余额
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string Balance;
        // 身份证号
        /// <summary>
        /// 身份证号
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string ID;
        // 实名
        /// <summary>
        /// 实名
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)]
        public string RealName;
        // 银行卡列表
        /// <summary>
        /// 银行卡列表
        /// </summary>
        public List<CardInformation> CardList;
    }
}
