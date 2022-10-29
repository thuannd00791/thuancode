// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.SmallHotelManager
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SmallHotelManager
{
  public class SmallHotelManager : DataContext
  {
    private static MappingSource mappingSource = (MappingSource) new AttributeMappingSource();

    public SmallHotelManager(string connection)
      : base(connection, SmallHotelManager.SmallHotelManager.mappingSource)
    {
    }

    public SmallHotelManager(IDbConnection connection)
      : base(connection, SmallHotelManager.SmallHotelManager.mappingSource)
    {
    }

    public SmallHotelManager(string connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public SmallHotelManager(IDbConnection connection, MappingSource mappingSource)
      : base(connection, mappingSource)
    {
    }

    public Table<SmallHotelManager.Attendance> Attendance => this.GetTable<SmallHotelManager.Attendance>();

    public Table<SmallHotelManager.BookedRoom> BookedRoom => this.GetTable<SmallHotelManager.BookedRoom>();

    public Table<SmallHotelManager.Customer> Customer => this.GetTable<SmallHotelManager.Customer>();

    public Table<SmallHotelManager.GroupUser> GroupUser => this.GetTable<SmallHotelManager.GroupUser>();

    public Table<SmallHotelManager.HotelInformation> HotelInformation => this.GetTable<SmallHotelManager.HotelInformation>();

    public Table<SmallHotelManager.National> National => this.GetTable<SmallHotelManager.National>();

    public Table<SmallHotelManager.OutExpense> OutExpense => this.GetTable<SmallHotelManager.OutExpense>();

    public Table<SmallHotelManager.OutInCome> OutInCome => this.GetTable<SmallHotelManager.OutInCome>();

    public Table<SmallHotelManager.Room> Room => this.GetTable<SmallHotelManager.Room>();

    public Table<SmallHotelManager.RoomPurchaseInfo> RoomPurchaseInfo => this.GetTable<SmallHotelManager.RoomPurchaseInfo>();

    public Table<SmallHotelManager.RoomType> RoomType => this.GetTable<SmallHotelManager.RoomType>();

    public Table<SmallHotelManager.Services> Services => this.GetTable<SmallHotelManager.Services>();

    public Table<SmallHotelManager.ServicesPurchaseInfo> ServicesPurchaseInfo => this.GetTable<SmallHotelManager.ServicesPurchaseInfo>();

    public Table<SmallHotelManager.Spending> Spending => this.GetTable<SmallHotelManager.Spending>();

    public Table<SmallHotelManager.Status> Status => this.GetTable<SmallHotelManager.Status>();

    public Table<SmallHotelManager.Users> Users => this.GetTable<SmallHotelManager.Users>();

    public Table<SmallHotelManager.UsingTime> UsingTime => this.GetTable<SmallHotelManager.UsingTime>();
  }
}
