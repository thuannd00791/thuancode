// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.National
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class National : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _NationalID;
    private string _Nation;
    private int? _IsDelete;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_NationalID")]
    public int NationalID
    {
      get => this._NationalID;
      set
      {
        if (this._NationalID == value)
          return;
        this.SendPropertyChanging();
        this._NationalID = value;
        this.SendPropertyChanged(nameof (NationalID));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_Nation")]
    public string Nation
    {
      get => this._Nation;
      set
      {
        if (!(this._Nation != value))
          return;
        this.SendPropertyChanging();
        this._Nation = value;
        this.SendPropertyChanged(nameof (Nation));
      }
    }

    [Column(DbType = "Int", Storage = "_IsDelete")]
    public int? IsDelete
    {
      get => this._IsDelete;
      set
      {
        int? isDelete = this._IsDelete;
        int? nullable = value;
        if ((isDelete.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (isDelete.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._IsDelete = value;
        this.SendPropertyChanged(nameof (IsDelete));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, National.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
