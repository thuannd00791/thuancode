// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Spending
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class Spending : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ID;
    private string _Reasson;
    private int? _Cost;
    private DateTime? _SpendDate;

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

    [Column(DbType = "NVarChar(200)", Storage = "_Reasson")]
    public string Reasson
    {
      get => this._Reasson;
      set
      {
        if (!(this._Reasson != value))
          return;
        this.SendPropertyChanging();
        this._Reasson = value;
        this.SendPropertyChanged(nameof (Reasson));
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

    [Column(DbType = "DateTime", Storage = "_SpendDate")]
    public DateTime? SpendDate
    {
      get => this._SpendDate;
      set
      {
        DateTime? spendDate = this._SpendDate;
        DateTime? nullable = value;
        if ((spendDate.HasValue != nullable.HasValue ? 1 : (!spendDate.HasValue ? 0 : (spendDate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._SpendDate = value;
        this.SendPropertyChanged(nameof (SpendDate));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, Spending.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
