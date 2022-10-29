// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Sheets
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
  [TypeIdentifier]
  [CompilerGenerated]
  [Guid("000208D7-0000-0000-C000-000000000046")]
  [ComImport]
  public interface Sheets : IEnumerable
  {
    [SpecialName]
    sealed extern void _VtblGap1_18();

    [IndexerName("_Default")]
    object this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [DispId(0)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }
  }
}
