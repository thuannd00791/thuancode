// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.OutInCome
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class OutInCome : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _ID;
    private string _Code;
    private DateTime? _DateIncome;
    private string _Content;
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

    [Column(DbType = "NVarChar(30)", Storage = "_Code")]
    public string Code
    {
      get => this._Code;
      set
      {
        if (!(this._Code != value))
          return;
        this.SendPropertyChanging();
        this._Code = value;
        this.SendPropertyChanged(nameof (Code));
      }
    }

    [Column(DbType = "DateTime", Storage = "_DateIncome")]
    public DateTime? DateIncome
    {
      get => this._DateIncome;
      set
      {
        DateTime? dateIncome = this._DateIncome;
        DateTime? nullable = value;
        if ((dateIncome.HasValue != nullable.HasValue ? 1 : (!dateIncome.HasValue ? 0 : (dateIncome.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._DateIncome = value;
        this.SendPropertyChanged(nameof (DateIncome));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_Content")]
    public string Content
    {
      get => this._Content;
      set
      {
        if (!(this._Content != value))
          return;
        this.SendPropertyChanging();
        this._Content = value;
        this.SendPropertyChanged(nameof (Content));
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
      this.PropertyChanging((object) this, OutInCome.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
