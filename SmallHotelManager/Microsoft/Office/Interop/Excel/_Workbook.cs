// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel._Workbook
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
  [CompilerGenerated]
  [TypeIdentifier]
  [Guid("000208DA-0000-0000-C000-000000000046")]
  [ComImport]
  public interface _Workbook
  {
    [SpecialName]
    sealed extern void _VtblGap1_7();

    object ActiveSheet { [DispId(307)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

    [SpecialName]
    sealed extern void _VtblGap2_71();

    [DispId(281)]
    [LCIDConversion(1)]
    void PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

    [SpecialName]
    sealed extern void _VtblGap3_17();

    [LCIDConversion(1)]
    [DispId(175)]
    void SaveCopyAs([MarshalAs(UnmanagedType.Struct), In, Optional] object Filename);

    bool Saved { [DispId(298), LCIDConversion(0)] get; [LCIDConversion(0), DispId(298)] [param: In] set; }

    [SpecialName]
    sealed extern void _VtblGap4_5();

    Sheets Sheets { [DispId(485)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    sealed extern void _VtblGap5_59();

    [DispId(1925)]
    [LCIDConversion(12)]
    void SaveAs(
      [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
      [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object ConflictResolution,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout,
      [MarshalAs(UnmanagedType.Struct), In, Optional] object Local);
  }
}
