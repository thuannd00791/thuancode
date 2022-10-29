// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel._Worksheet
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
  [TypeIdentifier]
  [Guid("000208D8-0000-0000-C000-000000000046")]
  [CompilerGenerated]
  [ComImport]
  public interface _Worksheet
  {
    [SpecialName]
    sealed extern void _VtblGap1_11();

    string Name { [DispId(110)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(110)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

    [SpecialName]
    sealed extern void _VtblGap2_7();

    PageSetup PageSetup { [DispId(998)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    sealed extern void _VtblGap3_13();

    Shapes Shapes { [DispId(1377)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    sealed extern void _VtblGap4_10();

    Range Cells { [DispId(238)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    sealed extern void _VtblGap5_5();

    Range Columns { [DispId(241)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    sealed extern void _VtblGap6_43();

    Range Rows { [DispId(258)] [return: MarshalAs(UnmanagedType.Interface)] get; }
  }
}
