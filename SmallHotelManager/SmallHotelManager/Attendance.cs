// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Attendance
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class Attendance : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _AttendID;
    private int? _UserID;
    private DateTime? _StartTime;
    private DateTime? _EndTime;
    private int? _TotalTime;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_AttendID")]
    public int AttendID
    {
      get => this._AttendID;
      set
      {
        if (this._AttendID == value)
          return;
        this.SendPropertyChanging();
        this._AttendID = value;
        this.SendPropertyChanged(nameof (AttendID));
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

    [Column(DbType = "DateTime", Storage = "_StartTime")]
    public DateTime? StartTime
    {
      get => this._StartTime;
      set
      {
        DateTime? startTime = this._StartTime;
        DateTime? nullable = value;
        if ((startTime.HasValue != nullable.HasValue ? 1 : (!startTime.HasValue ? 0 : (startTime.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._StartTime = value;
        this.SendPropertyChanged(nameof (StartTime));
      }
    }

    [Column(DbType = "DateTime", Storage = "_EndTime")]
    public DateTime? EndTime
    {
      get => this._EndTime;
      set
      {
        DateTime? endTime = this._EndTime;
        DateTime? nullable = value;
        if ((endTime.HasValue != nullable.HasValue ? 1 : (!endTime.HasValue ? 0 : (endTime.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : 0))) == 0)
          return;
        this.SendPropertyChanging();
        this._EndTime = value;
        this.SendPropertyChanged(nameof (EndTime));
      }
    }

    [Column(DbType = "Int", Storage = "_TotalTime")]
    public int? TotalTime
    {
      get => this._TotalTime;
      set
      {
        int? totalTime = this._TotalTime;
        int? nullable = value;
        if ((totalTime.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (totalTime.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._TotalTime = value;
        this.SendPropertyChanged(nameof (TotalTime));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, Attendance.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
