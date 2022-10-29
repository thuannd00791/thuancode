// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Workbooks
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
  [Guid("000208DB-0000-0000-C000-000000000046")]
  [TypeIdentifier]
  [DefaultMember("_Default")]
  [CompilerGenerated]
  [ComImport]
  public interface Workbooks : IEnumerable
  {
    [SpecialName]
    sealed extern void _VtblGap1_3();

    [LCIDConversion(1)]
    [DispId(181)]
    [return: MarshalAs(UnmanagedType.Interface)]
    Workbook Add([MarshalAs(UnmanagedType.Struct), In, Optional] object Template);

    [LCIDConversion(0)]
    [DispId(277)]
    void Close();
  }
}
