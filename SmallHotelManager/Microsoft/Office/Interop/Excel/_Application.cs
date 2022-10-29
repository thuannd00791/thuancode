// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel._Application
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
  [TypeIdentifier]
  [Guid("000208D5-0000-0000-C000-000000000046")]
  [CompilerGenerated]
  [DefaultMember("_Default")]
  [ComImport]
  public interface _Application
  {
    Application Application { [DispId(148)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    sealed extern void _VtblGap1_10();

    Workbook ActiveWorkbook { [DispId(308)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    sealed extern void _VtblGap2_33();

    Workbooks Workbooks { [DispId(572)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    sealed extern void _VtblGap3_66();

    bool DisplayAlerts { [DispId(343), LCIDConversion(0)] get; [LCIDConversion(0), DispId(343)] [param: In] set; }

    [SpecialName]
    sealed extern void _VtblGap4_45();

    [LCIDConversion(1)]
    [DispId(1087)]
    double InchesToPoints([In] double Inches);

    [SpecialName]
    sealed extern void _VtblGap5_63();

    [DispId(302)]
    void Quit();

    [SpecialName]
    sealed extern void _VtblGap6_51();

    bool Visible { [DispId(558), LCIDConversion(0)] get; [LCIDConversion(0), DispId(558)] [param: In] set; }
  }
}
