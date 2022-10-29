// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.GroupUser
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class GroupUser : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _GroupID;
    private string _GroupName;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_GroupID")]
    public int GroupID
    {
      get => this._GroupID;
      set
      {
        if (this._GroupID == value)
          return;
        this.SendPropertyChanging();
        this._GroupID = value;
        this.SendPropertyChanged(nameof (GroupID));
      }
    }

    [Column(DbType = "NVarChar(50)", Storage = "_GroupName")]
    public string GroupName
    {
      get => this._GroupName;
      set
      {
        if (!(this._GroupName != value))
          return;
        this.SendPropertyChanging();
        this._GroupName = value;
        this.SendPropertyChanged(nameof (GroupName));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, GroupUser.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
