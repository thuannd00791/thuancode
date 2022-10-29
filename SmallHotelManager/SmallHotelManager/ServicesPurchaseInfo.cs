// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.ServicesPurchaseInfo
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class ServicesPurchaseInfo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ID;
    private int _PurchaseID;
    private int? _ServiceID;
    private int? _Number;
    private int? _Cost;

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

    [Column(DbType = "Int NOT NULL", Storage = "_PurchaseID")]
    public int PurchaseID
    {
      get => this._PurchaseID;
      set
      {
        if (this._PurchaseID == value)
          return;
        this.SendPropertyChanging();
        this._PurchaseID = value;
        this.SendPropertyChanged(nameof (PurchaseID));
      }
    }

    [Column(DbType = "Int", Storage = "_ServiceID")]
    public int? ServiceID
    {
      get => this._ServiceID;
      set
      {
        int? serviceId = this._ServiceID;
        int? nullable = value;
        if ((serviceId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (serviceId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._ServiceID = value;
        this.SendPropertyChanged(nameof (ServiceID));
      }
    }

    [Column(DbType = "Int", Storage = "_Number")]
    public int? Number
    {
      get => this._Number;
      set
      {
        int? number = this._Number;
        int? nullable = value;
        if ((number.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (number.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._Number = value;
        this.SendPropertyChanged(nameof (Number));
      }
    }

    [Column(DbType = "Int", Storage = "_Cost")]
    public int? Cost
    {
      get => this._Cost;
      set
      {
        int? cost = this._Cost;
        int? nullable = value;
        if ((cost.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cost.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._Cost = value;
        this.SendPropertyChanged(nameof (Cost));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, ServicesPurchaseInfo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
