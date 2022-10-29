// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Room
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class Room : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _RoomID;
    private string _RoomNo;
    private int? _PurchaseID;
    private int _StatusID;
    private int _TypeID;
    private string _Not;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_RoomID")]
    public int RoomID
    {
      get => this._RoomID;
      set
      {
        if (this._RoomID == value)
          return;
        this.SendPropertyChanging();
        this._RoomID = value;
        this.SendPropertyChanged(nameof (RoomID));
      }
    }

    [Column(CanBeNull = false, DbType = "NVarChar(10) NOT NULL", Storage = "_RoomNo")]
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

    [Column(DbType = "Int", Storage = "_PurchaseID")]
    public int? PurchaseID
    {
      get => this._PurchaseID;
      set
      {
        int? purchaseId = this._PurchaseID;
        int? nullable = value;
        if ((purchaseId.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (purchaseId.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._PurchaseID = value;
        this.SendPropertyChanged(nameof (PurchaseID));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_StatusID")]
    public int StatusID
    {
      get => this._StatusID;
      set
      {
        if (this._StatusID == value)
          return;
        this.SendPropertyChanging();
        this._StatusID = value;
        this.SendPropertyChanged(nameof (StatusID));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_TypeID")]
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

    [Column(DbType = "NVarChar(100)", Storage = "_Not")]
    public string Not
    {
      get => this._Not;
      set
      {
        if (!(this._Not != value))
          return;
        this.SendPropertyChanging();
        this._Not = value;
        this.SendPropertyChanged(nameof (Not));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, Room.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
