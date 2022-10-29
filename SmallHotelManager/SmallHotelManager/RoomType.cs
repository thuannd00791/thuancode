// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.RoomType
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class RoomType : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _TypeID;
    private string _TypeName;
    private int _PriceByHour;
    private int _PriceByNight;
    private int _PriceByDay;
    private int _PriceByNextHour;
    private int _TimeForByHourMethod;
    private int _ByDayEndTime;
    private int _ByNightEndTime;
    private int _ByDayStartTime;
    private int _ByNightStartTime;
    private int _MinuteOver;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_TypeID")]
    public int TypeID
    {
      get => this._TypeID;
      set
      {
        if (this._TypeID == value)
          return;
        this.SendPropertyChanging();
        this._TypeID = value;
        this.SendPropertyChanged(nameof (TypeID));
      }
    }

    [Column(CanBeNull = false, DbType = "NVarChar(50) NOT NULL", Storage = "_TypeName")]
    public string TypeName
    {
      get => this._TypeName;
      set
      {
        if (!(this._TypeName != value))
          return;
        this.SendPropertyChanging();
        this._TypeName = value;
        this.SendPropertyChanged(nameof (TypeName));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_PriceByHour")]
    public int PriceByHour
    {
      get => this._PriceByHour;
      set
      {
        if (this._PriceByHour == value)
          return;
        this.SendPropertyChanging();
        this._PriceByHour = value;
        this.SendPropertyChanged(nameof (PriceByHour));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_PriceByNight")]
    public int PriceByNight
    {
      get => this._PriceByNight;
      set
      {
        if (this._PriceByNight == value)
          return;
        this.SendPropertyChanging();
        this._PriceByNight = value;
        this.SendPropertyChanged(nameof (PriceByNight));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_PriceByDay")]
    public int PriceByDay
    {
      get => this._PriceByDay;
      set
      {
        if (this._PriceByDay == value)
          return;
        this.SendPropertyChanging();
        this._PriceByDay = value;
        this.SendPropertyChanged(nameof (PriceByDay));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_PriceByNextHour")]
    public int PriceByNextHour
    {
      get => this._PriceByNextHour;
      set
      {
        if (this._PriceByNextHour == value)
          return;
        this.SendPropertyChanging();
        this._PriceByNextHour = value;
        this.SendPropertyChanged(nameof (PriceByNextHour));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_TimeForByHourMethod")]
    public int TimeForByHourMethod
    {
      get => this._TimeForByHourMethod;
      set
      {
        if (this._TimeForByHourMethod == value)
          return;
        this.SendPropertyChanging();
        this._TimeForByHourMethod = value;
        this.SendPropertyChanged(nameof (TimeForByHourMethod));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_ByDayEndTime")]
    public int ByDayEndTime
    {
      get => this._ByDayEndTime;
      set
      {
        if (this._ByDayEndTime == value)
          return;
        this.SendPropertyChanging();
        this._ByDayEndTime = value;
        this.SendPropertyChanged(nameof (ByDayEndTime));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_ByNightEndTime")]
    public int ByNightEndTime
    {
      get => this._ByNightEndTime;
      set
      {
        if (this._ByNightEndTime == value)
          return;
        this.SendPropertyChanging();
        this._ByNightEndTime = value;
        this.SendPropertyChanged(nameof (ByNightEndTime));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_ByDayStartTime")]
    public int ByDayStartTime
    {
      get => this._ByDayStartTime;
      set
      {
        if (this._ByDayStartTime == value)
          return;
        this.SendPropertyChanging();
        this._ByDayStartTime = value;
        this.SendPropertyChanged(nameof (ByDayStartTime));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_ByNightStartTime")]
    public int ByNightStartTime
    {
      get => this._ByNightStartTime;
      set
      {
        if (this._ByNightStartTime == value)
          return;
        this.SendPropertyChanging();
        this._ByNightStartTime = value;
        this.SendPropertyChanged(nameof (ByNightStartTime));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_MinuteOver")]
    public int MinuteOver
    {
      get => this._MinuteOver;
      set
      {
        if (this._MinuteOver == value)
          return;
        this.SendPropertyChanging();
        this._MinuteOver = value;
        this.SendPropertyChanged(nameof (MinuteOver));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, RoomType.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
