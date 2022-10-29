// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Customer
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class Customer : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _CusID;
    private string _CusName;
    private string _Company;
    private int? _NationalID;
    private string _Address;
    private string _IdNo;
    private string _CusPhone;
    private string _RoomNo;
    private DateTime? _CITime;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_CusID")]
    public int CusID
    {
      get => this._CusID;
      set
      {
        if (this._CusID == value)
          return;
        this.SendPropertyChanging();
        this._CusID = value;
        this.SendPropertyChanged(nameof (CusID));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_CusName")]
    public string CusName
    {
      get => this._CusName;
      set
      {
        if (!(this._CusName != value))
          return;
        this.SendPropertyChanging();
        this._CusName = value;
        this.SendPropertyChanged(nameof (CusName));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_Company")]
    public string Company
    {
      get => this._Company;
      set
      {
        if (!(this._Company != value))
          return;
        this.SendPropertyChanging();
        this._Company = value;
        this.SendPropertyChanged(nameof (Company));
      }
    }

    [Column(DbType = "Int", Storage = "_NationalID")]
    public int? NationalID
    {
      get => this._NationalID;
      set
      {
        int? nationalId = this._NationalID;
        int? nullable = value;
        if ((nationalId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (nationalId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._NationalID = value;
        this.SendPropertyChanged(nameof (NationalID));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_Address")]
    public string Address
    {
      get => this._Address;
      set
      {
        if (!(this._Address != value))
          return;
        this.SendPropertyChanging();
        this._Address = value;
        this.SendPropertyChanged(nameof (Address));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_IdNo")]
    public string IdNo
    {
      get => this._IdNo;
      set
      {
        if (!(this._IdNo != value))
          return;
        this.SendPropertyChanging();
        this._IdNo = value;
        this.SendPropertyChanged(nameof (IdNo));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_CusPhone")]
    public string CusPhone
    {
      get => this._CusPhone;
      set
      {
        if (!(this._CusPhone != value))
          return;
        this.SendPropertyChanging();
        this._CusPhone = value;
        this.SendPropertyChanged(nameof (CusPhone));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_RoomNo")]
    public string RoomNo
    {
      get => this._RoomNo;
      set
      {
        if (!(this._RoomNo != value))
          return;
        this.SendPropertyChanging();
        this._RoomNo = value;
        this.SendPropertyChanged(nameof (RoomNo));
      }
    }

    [Column(DbType = "DateTime", Storage = "_CITime")]
    public DateTime? CITime
    {
      get => this._CITime;
      set
      {
        DateTime? ciTime = this._CITime;
        DateTime? nullable = value;
        if ((ciTime.HasValue != nullable.HasValue ? 1 : (!ciTime.HasValue ? 0 : (ciTime.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._CITime = value;
        this.SendPropertyChanged(nameof (CITime));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, Customer.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
