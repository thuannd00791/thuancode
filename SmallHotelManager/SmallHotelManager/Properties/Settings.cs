// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Properties.Settings
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SmallHotelManager.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }

    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DefaultSettingValue("Data Source=|DataDirectory|\\SmallHotelManager.sdf")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    public string SmallHotelManagerConnectionString => (string) this[nameof (SmallHotelManagerConnectionString)];
  }
}
