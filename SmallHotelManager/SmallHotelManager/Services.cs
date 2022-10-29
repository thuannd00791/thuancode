// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Services
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class Services : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ServiceID;
    private string _Name;
    private int? _Price;
    private int? _TotalNumber;
    private DateTime? _LastImport;
    private int? _UserID;
    private int? _DelID;
    private string _OtherName;
    private int? _StoreNum;
    private DateTime? _DateStore;
    private int? _StorePerson;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_ServiceID")]
    public int ServiceID
    {
      get => this._ServiceID;
      set
      {
        if (this._ServiceID == value)
          return;
        this.SendPropertyChanging();
        this._ServiceID = value;
        this.SendPropertyChanged(nameof (ServiceID));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_Name")]
    public string Name
    {
      get => this._Name;
      set
      {
        if (!(this._Name != value))
          return;
        this.SendPropertyChanging();
        this._Name = value;
        this.SendPropertyChanged(nameof (Name));
      }
    }

    [Column(DbType = "Int", Storage = "_Price")]
    public int? Price
    {
      get => this._Price;
      set
      {
        int? price = this._Price;
        int? nullable = value;
        if ((price.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (price.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._Price = value;
        this.SendPropertyChanged(nameof (Price));
      }
    }

    [Column(DbType = "Int", Storage = "_TotalNumber")]
    public int? TotalNumber
    {
      get => this._TotalNumber;
      set
      {
        int? totalNumber = this._TotalNumber;
        int? nullable = value;
        if ((totalNumber.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (totalNumber.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._TotalNumber = value;
        this.SendPropertyChanged(nameof (TotalNumber));
      }
    }

    [Column(DbType = "DateTime", Storage = "_LastImport")]
    public DateTime? LastImport
    {
      get => this._LastImport;
      set
      {
        DateTime? lastImport = this._LastImport;
        DateTime? nullable = value;
        if ((lastImport.HasValue != nullable.HasValue ? 1 : (!lastImport.HasValue ? 0 : (lastImport.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._LastImport = value;
        this.SendPropertyChanged(nameof (LastImport));
      }
    }

    [Column(DbType = "Int", Storage = "_UserID")]
    public int? UserID
    {
      get => this._UserID;
      set
      {
        int? userId = this._UserID;
        int? nullable = value;
        if ((userId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (userId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._UserID = value;
        this.SendPropertyChanged(nameof (UserID));
      }
    }

    [Column(DbType = "Int", Storage = "_DelID")]
    public int? DelID
    {
      get => this._DelID;
      set
      {
        int? delId = this._DelID;
        int? nullable = value;
        if ((delId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (delId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DelID = value;
        this.SendPropertyChanged(nameof (DelID));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_OtherName")]
    public string OtherName
    {
      get => this._OtherName;
      set
      {
        if (!(this._OtherName != value))
          return;
        this.SendPropertyChanging();
        this._OtherName = value;
        this.SendPropertyChanged(nameof (OtherName));
      }
    }

    [Column(DbType = "Int", Storage = "_StoreNum")]
    public int? StoreNum
    {
      get => this._StoreNum;
      set
      {
        int? storeNum = this._StoreNum;
        int? nullable = value;
        if ((storeNum.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (storeNum.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._StoreNum = value;
        this.SendPropertyChanged(nameof (StoreNum));
      }
    }

    [Column(DbType = "DateTime", Storage = "_DateStore")]
    public DateTime? DateStore
    {
      get => this._DateStore;
      set
      {
        DateTime? dateStore = this._DateStore;
        DateTime? nullable = value;
        if ((dateStore.HasValue != nullable.HasValue ? 1 : (!dateStore.HasValue ? 0 : (dateStore.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DateStore = value;
        this.SendPropertyChanged(nameof (DateStore));
      }
    }

    [Column(DbType = "Int", Storage = "_StorePerson")]
    public int? StorePerson
    {
      get => this._StorePerson;
      set
      {
        int? storePerson = this._StorePerson;
        int? nullable = value;
        if ((storePerson.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (storePerson.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._StorePerson = value;
        this.SendPropertyChanged(nameof (StorePerson));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, Services.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
