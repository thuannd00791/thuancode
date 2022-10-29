// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Shapes
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using Microsoft.Office.Core;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
  [TypeIdentifier]
  [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
  [CompilerGenerated]
  [DefaultMember("_Default")]
  [Guid("0002443A-0000-0000-C000-000000000046")]
  [ComImport]
  public interface Shapes
  {
    [DispId(1723)]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    [return: MarshalAs(UnmanagedType.Interface)]
    Shape AddPicture(
      [MarshalAs(UnmanagedType.BStr), In] string Filename,
      [In] MsoTriState LinkToFile,
      [In] MsoTriState SaveWithDocument,
      [In] float Left,
      [In] float Top,
      [In] float Width,
      [In] float Height);
  }
}
