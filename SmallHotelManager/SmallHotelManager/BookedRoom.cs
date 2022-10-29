// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.BookedRoom
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class BookedRoom : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _BookingID;
    private string _RoomNo;
    private string _NameOfBooker;
    private DateTime? _BookingDate;
    private string _PhoneNumber;
    private int? _NumOfPersons;
    private int? _Prepaid;
    private DateTime? _CODate;
    private string _BookingNote;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_BookingID")]
    public int BookingID
    {
      get => this._BookingID;
      set
      {
        if (this._BookingID == value)
          return;
        this.SendPropertyChanging();
        this._BookingID = value;
        this.SendPropertyChanged(nameof (BookingID));
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

    [Column(DbType = "NVarChar(100)", Storage = "_NameOfBooker")]
    public string NameOfBooker
    {
      get => this._NameOfBooker;
      set
      {
        if (!(this._NameOfBooker != value))
          return;
        this.SendPropertyChanging();
        this._NameOfBooker = value;
        this.SendPropertyChanged(nameof (NameOfBooker));
      }
    }

    [Column(DbType = "DateTime", Storage = "_BookingDate")]
    public DateTime? BookingDate
    {
      get => this._BookingDate;
      set
      {
        DateTime? bookingDate = this._BookingDate;
        DateTime? nullable = value;
        if ((bookingDate.HasValue != nullable.HasValue ? 1 : (!bookingDate.HasValue ? 0 : (bookingDate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._BookingDate = value;
        this.SendPropertyChanged(nameof (BookingDate));
      }
    }

    [Column(DbType = "NVarChar(20)", Storage = "_PhoneNumber")]
    public string PhoneNumber
    {
      get => this._PhoneNumber;
      set
      {
        if (!(this._PhoneNumber != value))
          return;
        this.SendPropertyChanging();
        this._PhoneNumber = value;
        this.SendPropertyChanged(nameof (PhoneNumber));
      }
    }

    [Column(DbType = "Int", Storage = "_NumOfPersons")]
    public int? NumOfPersons
    {
      get => this._NumOfPersons;
      set
      {
        int? numOfPersons = this._NumOfPersons;
        int? nullable = value;
        if ((numOfPersons.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (numOfPersons.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._NumOfPersons = value;
        this.SendPropertyChanged(nameof (NumOfPersons));
      }
    }

    [Column(DbType = "Int", Storage = "_Prepaid")]
    public int? Prepaid
    {
      get => this._Prepaid;
      set
      {
        int? prepaid = this._Prepaid;
        int? nullable = value;
        if ((prepaid.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (prepaid.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._Prepaid = value;
        this.SendPropertyChanged(nameof (Prepaid));
      }
    }

    [Column(DbType = "DateTime", Storage = "_CODate")]
    public DateTime? CODate
    {
      get => this._CODate;
      set
      {
        DateTime? coDate = this._CODate;
        DateTime? nullable = value;
        if ((coDate.HasValue != nullable.HasValue ? 1 : (!coDate.HasValue ? 0 : (coDate.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._CODate = value;
        this.SendPropertyChanged(nameof (CODate));
      }
    }

    [Column(DbType = "NVarChar(100)", Storage = "_BookingNote")]
    public string BookingNote
    {
      get => this._BookingNote;
      set
      {
        if (!(this._BookingNote != value))
          return;
        this.SendPropertyChanging();
        this._BookingNote = value;
        this.SendPropertyChanged(nameof (BookingNote));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, BookedRoom.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
