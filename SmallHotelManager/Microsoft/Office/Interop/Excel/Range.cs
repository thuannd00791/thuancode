// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Range
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
  [CompilerGenerated]
  [TypeIdentifier]
  [Guid("00020846-0000-0000-C000-000000000046")]
  [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
  [ComImport]
  public interface Range
  {
    [IndexerName("_Default")]
    object this[[MarshalAs(UnmanagedType.Struct), In, Optional] object RowIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnIndex] { [DispId(0), MethodImpl(MethodImplOptions.PreserveSig)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(0), MethodImpl(MethodImplOptions.PreserveSig)] [param: MarshalAs(UnmanagedType.Struct), In, Optional] set; }

    object HorizontalAlignment { [DispId(136), MethodImpl(MethodImplOptions.PreserveSig)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(136), MethodImpl(MethodImplOptions.PreserveSig)] [param: MarshalAs(UnmanagedType.Struct), In] set; }
  }
}
