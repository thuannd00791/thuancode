// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.HotelInformation
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class HotelInformation : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ID;
    private string _HotelName;
    private string _PhoneNumber1;
    private string _PhoneNumber2;
    private string _Adress;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_ID")]
    public int ID
    {
      get => this._ID;
      set
      {
        if (this._ID == value)
          return;
        this.SendPropertyChanging();
        this._ID = value;
        this.SendPropertyChanged(nameof (ID));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_HotelName")]
    public string HotelName
    {
      get => this._HotelName;
      set
      {
        if (!(this._HotelName != value))
          return;
        this.SendPropertyChanging();
        this._HotelName = value;
        this.SendPropertyChanged(nameof (HotelName));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_PhoneNumber1")]
    public string PhoneNumber1
    {
      get => this._PhoneNumber1;
      set
      {
        if (!(this._PhoneNumber1 != value))
          return;
        this.SendPropertyChanging();
        this._PhoneNumber1 = value;
        this.SendPropertyChanged(nameof (PhoneNumber1));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_PhoneNumber2")]
    public string PhoneNumber2
    {
      get => this._PhoneNumber2;
      set
      {
        if (!(this._PhoneNumber2 != value))
          return;
        this.SendPropertyChanging();
        this._PhoneNumber2 = value;
        this.SendPropertyChanged(nameof (PhoneNumber2));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_Adress")]
    public string Adress
    {
      get => this._Adress;
      set
      {
        if (!(this._Adress != value))
          return;
        this.SendPropertyChanging();
        this._Adress = value;
        this.SendPropertyChanged(nameof (Adress));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, HotelInformation.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
