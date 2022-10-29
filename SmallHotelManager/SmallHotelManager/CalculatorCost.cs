// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.CalculatorCost
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SmallHotelManager
{
  internal class CalculatorCost
  {
    private int _loan;
    private int _purchaseID;
    private int _priceByHour;
    private int _priceByNight;
    private int _priceByDay;
    private int _pricePerNexHour;
    private int _timeForByHour;
    private int _byNightEndTime;
    private int _byDayEndTime;
    private int _byNightStartTime;
    private int _byDayStartTime;
    private int _minuteOver;
    private string _roomNo;
    private int _typeId;
    private int _method;
    private DateTime _outTime;
    private DateTime _inTime;
    private bool _isLoan;

    public int PurchaseID
    {
      get => this._purchaseID;
      set => this._purchaseID = value;
    }

    public int Loan
    {
      get => this._loan;
      set => this._loan = value;
    }

    public int MinuteOver
    {
      get => this._minuteOver;
      set => this._minuteOver = value;
    }

    public int ByDayStartTime
    {
      get => this._byDayStartTime;
      set => this._byDayStartTime = value;
    }

    public int ByNightStartTime
    {
      get => this._byNightStartTime;
      set => this._byNightStartTime = value;
    }

    public bool IsLoan
    {
      get => this._isLoan;
      set => this._isLoan = value;
    }

    public DateTime InTime
    {
      get => this._inTime;
      set => this._inTime = value;
    }

    public int Method
    {
      get => this._method;
      set => this._method = value;
    }

    public DateTime OutTime
    {
      get => this._outTime;
      set => this._outTime = value;
    }

    public int TypeId
    {
      get => this._typeId;
      set => this._typeId = value;
    }

    public string RoomNo
    {
      get => this._roomNo;
      set => this._roomNo = value;
    }

    public int ByDayEndTime
    {
      get => this._byDayEndTime;
      set => this._byDayEndTime = value;
    }

    public int ByNightEndTime
    {
      get => this._byNightEndTime;
      set => this._byNightEndTime = value;
    }

    public int TimeForByHour
    {
      get => this._timeForByHour;
      set => this._timeForByHour = value;
    }

    public int PricePerNexHour
    {
      get => this._pricePerNexHour;
      set => this._pricePerNexHour = value;
    }

    public int PriceByDay
    {
      get => this._priceByDay;
      set => this._priceByDay = value;
    }

    public int PriceByNight
    {
      get => this._priceByNight;
      set => this._priceByNight = value;
    }

    public int PriceByHour
    {
      get => this._priceByHour;
      set => this._priceByHour = value;
    }

    public void GetData(string roomNo, DateTime outTime, DateTime inTime, bool isLoan)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.RoomNo = roomNo;
      this.OutTime = outTime;
      this.InTime = inTime;
      this.IsLoan = isLoan;
      this.TypeId = smallHotelManager.Room.Where<Room>((Expression<Func<Room, bool>>) (rp => rp.RoomNo == roomNo)).Single<Room>().TypeID;
      RoomType roomType = smallHotelManager.RoomType.Where<RoomType>((Expression<Func<RoomType, bool>>) (rp => rp.TypeID == this._typeId)).Single<RoomType>();
      this.PriceByHour = roomType.PriceByHour;
      this.PriceByNight = roomType.PriceByNight;
      this.PriceByDay = roomType.PriceByDay;
      this.PricePerNexHour = roomType.PriceByNextHour;
      this.ByDayEndTime = roomType.ByDayEndTime;
      this.ByNightEndTime = roomType.ByNightEndTime;
      this.ByDayStartTime = roomType.ByDayStartTime;
      this.ByNightStartTime = roomType.ByNightStartTime;
      this.TimeForByHour = roomType.TimeForByHourMethod;
      this.MinuteOver = roomType.MinuteOver;
    }

    public int CalcuCost()
    {
      TimeSpan timeSpan = this._outTime.Subtract(this._inTime);
      int num1 = this.CostByHour();
      int num2 = this.CostByNight();
      int num3 = this.CostByDay();
      int totalHours = (int) timeSpan.TotalHours;
      DateTime dateTime1 = new DateTime(2012, 1, 2, this._byNightEndTime, 0, 0);
      DateTime dateTime2 = new DateTime(2012, 1, 1, this._byNightStartTime, 0, 0);
      DateTime dateTime3 = new DateTime(this._inTime.Year, this._inTime.Month, this._inTime.Day, 17, 30, 0);
      DateTime dateTime4 = new DateTime(this._inTime.Year, this._inTime.Month, this._inTime.Day, 5, 0, 0);
      DateTime dateTime5 = new DateTime(this._outTime.Year, this._outTime.Month, this._outTime.Day, 1, 0, 0);
      dateTime1.Subtract(dateTime2);
      if (timeSpan.Minutes > this._minuteOver)
        ++totalHours;
      int num4 = totalHours * this.PricePerNexHour;
      List<int> source = new List<int>();
      if (this._inTime.Date == this._outTime.Date)
      {
        if (this.InTime < dateTime4 && this.OutTime > dateTime5)
          num1 = num2;
        source.Add(num1);
      }
      if (this.InTime < dateTime3 && this.InTime.Date != this.OutTime.Date)
        num2 = num3;
      if (timeSpan.TotalHours <= 16.5)
        source.Add(num2);
      if (timeSpan.TotalHours > 12.0)
        source.Add(num3);
      if (this.IsLoan && this._inTime.Date == this._outTime.Date)
        source.Add(num4);
      int num5 = source.Min();
      GC.Collect();
      return num5;
    }

    private int CostByHour()
    {
      int num1 = 0;
      int num2 = 0;
      TimeSpan timeSpan = this._outTime.Subtract(this._inTime);
      int num3 = num1 + timeSpan.Days * 24 + timeSpan.Hours;
      if (num3 >= this._timeForByHour)
      {
        num2 = num3 - this._timeForByHour;
        if (timeSpan.Minutes > this._minuteOver)
          ++num2;
      }
      return this._priceByHour + num2 * this._pricePerNexHour;
    }

    private int CostByNight()
    {
      int num = 0;
      if (this._inTime.Date != this._outTime.Date)
      {
        DateTime dateTime1 = new DateTime(this._outTime.Year, this._outTime.Month, this._outTime.Day, this._byNightEndTime, 0, 0);
        if (dateTime1 < this._outTime)
        {
          TimeSpan timeSpan = this._outTime.Subtract(dateTime1);
          num += timeSpan.Hours;
          if (timeSpan.Minutes > this._minuteOver)
            ++num;
        }
        DateTime dateTime2 = new DateTime(this._inTime.Year, this._inTime.Month, this._inTime.Day, this._byNightStartTime, 0, 0);
        if (dateTime2 > this._inTime)
        {
          TimeSpan timeSpan = dateTime2.Subtract(this._inTime);
          num += timeSpan.Hours;
          if (timeSpan.Minutes > this._minuteOver)
            ++num;
        }
      }
      else
      {
        DateTime dateTime = new DateTime(this._outTime.Year, this._outTime.Month, this._outTime.Day, this._byNightEndTime, 0, 0);
        if (dateTime < this._outTime)
        {
          TimeSpan timeSpan = this._outTime.Subtract(dateTime);
          num += timeSpan.Hours;
          if (timeSpan.Minutes > this._minuteOver)
            ++num;
        }
      }
      return this._priceByNight + num * this._pricePerNexHour;
    }

    private int CostByDay()
    {
      int num1 = 0;
      int num2 = 0;
      DateTime dateTime1 = new DateTime(this._outTime.Year, this._outTime.Month, this._outTime.Day, this._byDayEndTime, 0, 0);
      DateTime dateTime2 = new DateTime(this._inTime.Year, this._inTime.Month, this._inTime.Day, this._byDayStartTime, 0, 0);
      num2 = this._outTime.Subtract(this._inTime).Days;
      int num3;
      if (this._inTime.Date != this._outTime.Date)
      {
        if (dateTime1 < this._outTime)
        {
          TimeSpan timeSpan = this._outTime.Subtract(dateTime1);
          num1 += timeSpan.Hours;
          if (timeSpan.Minutes > this._minuteOver)
            ++num1;
        }
        if (dateTime2 > this._inTime)
        {
          TimeSpan timeSpan = dateTime2.Subtract(this._inTime);
          num1 += timeSpan.Hours;
          if (timeSpan.Minutes > this._minuteOver)
            ++num1;
        }
        num3 = this._priceByDay + num1 * this._pricePerNexHour;
      }
      else
        num3 = this._priceByDay;
      return num3;
    }
  }
}
