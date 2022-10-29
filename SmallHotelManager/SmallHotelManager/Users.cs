// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Users
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  [Table]
  public class Users : INotifyPropertyChanging, INotifyPropertyChanged
  {
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);
    private int _UserID;
    private string _UserName;
    private string _Password;
    private string _Name;
    private string _PhoneNumber;
    private string _IDNumber;
    private int _GroupID;
    private int? _DelIDUs;

    [Column(AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true, Storage = "_UserID")]
    public int UserID
    {
      get => this._UserID;
      set
      {
        if (this._UserID == value)
          return;
        this.SendPropertyChanging();
        this._UserID = value;
        this.SendPropertyChanged(nameof (UserID));
      }
    }

    [Column(CanBeNull = false, DbType = "NVarChar(100) NOT NULL", Storage = "_UserName")]
    public string UserName
    {
      get => this._UserName;
      set
      {
        if (!(this._UserName != value))
          return;
        this.SendPropertyChanging();
        this._UserName = value;
        this.SendPropertyChanged(nameof (UserName));
      }
    }

    [Column(CanBeNull = false, DbType = "NVarChar(100) NOT NULL", Storage = "_Password")]
    public string Password
    {
      get => this._Password;
      set
      {
        if (!(this._Password != value))
          return;
        this.SendPropertyChanging();
        this._Password = value;
        this.SendPropertyChanged(nameof (Password));
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

    [Column(DbType = "NVarChar(100)", Storage = "_PhoneNumber")]
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

    [Column(DbType = "NVarChar(100)", Storage = "_IDNumber")]
    public string IDNumber
    {
      get => this._IDNumber;
      set
      {
        if (!(this._IDNumber != value))
          return;
        this.SendPropertyChanging();
        this._IDNumber = value;
        this.SendPropertyChanged(nameof (IDNumber));
      }
    }

    [Column(DbType = "Int NOT NULL", Storage = "_GroupID")]
    public int GroupID
    {
      get => this._GroupID;
      set
      {
        if (this._GroupID == value)
          return;
        this.SendPropertyChanging();
        this._GroupID = value;
        this.SendPropertyChanged(nameof (GroupID));
      }
    }

    [Column(DbType = "Int", Storage = "_DelIDUs")]
    public int? DelIDUs
    {
      get => this._DelIDUs;
      set
      {
        int? delIdUs = this._DelIDUs;
        int? nullable = value;
        if ((delIdUs.GetValueOrDefault() != nullable.GetValueOrDefault() ? 1 : (delIdUs.HasValue != nullable.HasValue ? 1 : 0)) == 0)
          return;
        this.SendPropertyChanging();
        this._DelIDUs = value;
        this.SendPropertyChanged(nameof (DelIDUs));
      }
    }

    public event PropertyChangingEventHandler PropertyChanging;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanging()
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, Users.emptyChangingEventArgs);
    }

    protected virtual void SendPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
