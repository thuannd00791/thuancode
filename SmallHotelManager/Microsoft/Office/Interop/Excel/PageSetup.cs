// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.PageSetup
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
  [TypeIdentifier]
  [CompilerGenerated]
  [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
  [Guid("000208B4-0000-0000-C000-000000000046")]
  [ComImport]
  public interface PageSetup
  {
    double BottomMargin { [DispId(1002), MethodImpl(MethodImplOptions.PreserveSig)] get; [DispId(1002), MethodImpl(MethodImplOptions.PreserveSig)] [param: In] set; }

    double LeftMargin { [DispId(999), MethodImpl(MethodImplOptions.PreserveSig)] get; [DispId(999), MethodImpl(MethodImplOptions.PreserveSig)] [param: In] set; }

    XlPageOrientation Orientation { [DispId(134), MethodImpl(MethodImplOptions.PreserveSig)] get; [DispId(134), MethodImpl(MethodImplOptions.PreserveSig)] [param: In] set; }

    XlPaperSize PaperSize { [DispId(1007), MethodImpl(MethodImplOptions.PreserveSig)] get; [DispId(1007), MethodImpl(MethodImplOptions.PreserveSig)] [param: In] set; }

    double RightMargin { [DispId(1000), MethodImpl(MethodImplOptions.PreserveSig)] get; [DispId(1000), MethodImpl(MethodImplOptions.PreserveSig)] [param: In] set; }

    double TopMargin { [DispId(1001), MethodImpl(MethodImplOptions.PreserveSig)] get; [DispId(1001), MethodImpl(MethodImplOptions.PreserveSig)] [param: In] set; }

    object Zoom { [DispId(663), MethodImpl(MethodImplOptions.PreserveSig)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(663), MethodImpl(MethodImplOptions.PreserveSig)] [param: MarshalAs(UnmanagedType.Struct), In] set; }
  }
}
