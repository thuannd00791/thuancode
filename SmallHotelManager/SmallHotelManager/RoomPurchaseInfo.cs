// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.RoomPurchaseInfo
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class RoomPurchaseInfo : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _PurchaseID;
    private string _RoomNo;
    private DateTime? _CheckInTime;
    private DateTime? _CheckOutTime;
    private int? _UserID;
    private int? _Cost;
    private int? _Loan;
    private int? _Repaid;
    private string _Note;
    private int? _CusID;
    private int? _RoomDiscount;
    private int? _SerDiscount;
    private int? _IsPaid;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_PurchaseID")]
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

    [Column(CanBeNull = false, DbType = "NVarChar(20) NOT NULL", Storage = "_RoomNo")]
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

    [Column(DbType = "DateTime", Storage = "_CheckInTime")]
    public DateTime? CheckInTime
    {
      get => this._CheckInTime;
      set
      {
        DateTime? checkInTime = this._CheckInTime;
        DateTime? nullable = value;
        if ((checkInTime.HasValue != nullable.HasValue ? 1 : (!checkInTime.HasValue ? 0 : (checkInTime.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._CheckInTime = value;
        this.SendPropertyChanged(nameof (CheckInTime));
      }
    }

    [Column(DbType = "DateTime", Storage = "_CheckOutTime")]
    public DateTime? CheckOutTime
    {
      get => this._CheckOutTime;
      set
      {
        DateTime? checkOutTime = this._CheckOutTime;
        DateTime? nullable = value;
        if ((checkOutTime.HasValue != nullable.HasValue ? 1 : (!checkOutTime.HasValue ? 0 : (checkOutTime.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._CheckOutTime = value;
        this.SendPropertyChanged(nameof (CheckOutTime));
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

    [Column(DbType = "Int", Storage = "_Loan")]
    public int? Loan
    {
      get => this._Loan;
      set
      {
        int? loan = this._Loan;
        int? nullable = value;
        if ((loan.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (loan.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._Loan = value;
        this.SendPropertyChanged(nameof (Loan));
      }
    }

    [Column(DbType = "Int", Storage = "_Repaid")]
    public int? Repaid
    {
      get => this._Repaid;
      set
      {
        int? repaid = this._Repaid;
        int? nullable = value;
        if ((repaid.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (repaid.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._Repaid = value;
        this.SendPropertyChanged(nameof (Repaid));
      }
    }

    [Column(DbType = "NVarChar(50)", Storage = "_Note")]
    public string Note
    {
      get => this._Note;
      set
      {
        if (!(this._Note != value))
          return;
        this.SendPropertyChanging();
        this._Note = value;
        this.SendPropertyChanged(nameof (Note));
      }
    }

    [Column(DbType = "Int", Storage = "_CusID")]
    public int? CusID
    {
      get => this._CusID;
      set
      {
        int? cusId = this._CusID;
        int? nullable = value;
        if ((cusId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (cusId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._CusID = value;
        this.SendPropertyChanged(nameof (CusID));
      }
    }

    [Column(DbType = "Int", Storage = "_RoomDiscount")]
    public int? RoomDiscount
    {
      get => this._RoomDiscount;
      set
      {
        int? roomDiscount = this._RoomDiscount;
        int? nullable = value;
        if ((roomDiscount.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (roomDiscount.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._RoomDiscount = value;
        this.SendPropertyChanged(nameof (RoomDiscount));
      }
    }

    [Column(DbType = "Int", Storage = "_SerDiscount")]
    public int? SerDiscount
    {
      get => this._SerDiscount;
      set
      {
        int? serDiscount = this._SerDiscount;
        int? nullable = value;
        if ((serDiscount.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (serDiscount.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._SerDiscount = value;
        this.SendPropertyChanged(nameof (SerDiscount));
      }
    }

    [Column(DbType = "Int", Storage = "_IsPaid")]
    public int? IsPaid
    {
      get => this._IsPaid;
      set
      {
        int? isPaid = this._IsPaid;
        int? nullable = value;
        if ((isPaid.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (isPaid.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._IsPaid = value;
        this.SendPropertyChanged(nameof (IsPaid));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, RoomPurchaseInfo.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
