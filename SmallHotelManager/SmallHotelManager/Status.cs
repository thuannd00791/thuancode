// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Status
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class Status : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _StatusID;
    private string _StatusName;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_StatusID")]
    public int StatusID
    {
      get => this._StatusID;
      set
      {
        if (this._StatusID == value)
          return;
        this.SendPropertyChanging();
        this._StatusID = value;
        this.SendPropertyChanged(nameof (StatusID));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_StatusName")]
    public string StatusName
    {
      get => this._StatusName;
      set
      {
        if (!(this._StatusName != value))
          return;
        this.SendPropertyChanging();
        this._StatusName = value;
        this.SendPropertyChanged(nameof (StatusName));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, Status.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
