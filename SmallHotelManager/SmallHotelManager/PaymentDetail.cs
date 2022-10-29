// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.PaymentDetail
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class PaymentDetail : Form
  {
    private bool isLoan;
    private int temp;
    private int method;
    private int cusid;
    private int dis1;
    private int isVietnam;
    private int dis2;
    private CalculatorCost cc;
    private IContainer components = (IContainer) null;
    private DataGridView grvDetails;
    private Button btnCancel;
    private DataGridViewTextBoxColumn Detail;
    private DataGridViewTextBoxColumn Cosy;
    private Label label1;
    private ComboBox comboBox1;

    public int IsVietnam
    {
      get => this.isVietnam;
      set => this.isVietnam = value;
    }

    public int Dis1
    {
      get => this.dis1;
      set => this.dis1 = value;
    }

    public int Dis2
    {
      get => this.dis2;
      set => this.dis2 = value;
    }

    public int Cusid
    {
      get => this.cusid;
      set => this.cusid = value;
    }

    public int Method
    {
      get => this.method;
      set => this.method = value;
    }

    public int Temp
    {
      get => this.temp;
      set => this.temp = value;
    }

    public bool IsLoan
    {
      get => this.isLoan;
      set => this.isLoan = value;
    }

    public PaymentDetail()
    {
      this.cc = new CalculatorCost();
      this.InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void PaymentDetail_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    private void PaymentDetail_Load(object sender, EventArgs e)
    {
      this.comboBox1.SelectedIndex = 0;
      this.isVietnam = 0;
      this.cc = new CalculatorCost();
      this.bindDataGRV();
    }

    public void bindDataGRV() => this.CreateBill();

    public void CreateBill()
    {
      if (!this.IsLoan)
        this.CreateByNonLoan();
      else
        this.CreateBillByLoan();
    }

    private void CreateBillByLoan()
    {
      if (this.isVietnam == 0)
      {
        DataTable dataTable = new DataTable();
        DataColumn column1 = new DataColumn("Detail", typeof (string));
        dataTable.Columns.Add(column1);
        DataColumn column2 = new DataColumn("Cost", typeof (string));
        dataTable.Columns.Add(column2);
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        IQueryable<RoomPurchaseInfo> queryable = db.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.Loan == (int?) this.temp));
        if (this.cusid != 0)
        {
          var data1 = db.Customer.SelectMany((Expression<Func<Customer, IEnumerable<National>>>) (c => db.National), (c, n) => new
          {
            c = c,
            n = n
          }).Where(data => data.c.CusID == this.cusid && data.c.NationalID == (int?) data.n.NationalID).Select(data => new
          {
            CusName = data.c.CusName,
            Nation = data.n.Nation
          }).Single();
          DataRow row1 = dataTable.NewRow();
          row1["Detail"] = (object) ("Tên khách hàng: " + data1.CusName);
          row1["Cost"] = (object) "";
          dataTable.Rows.Add(row1);
          DataRow row2 = dataTable.NewRow();
          row2["Detail"] = (object) ("Quốc tịch: " + data1.Nation);
          row2["Cost"] = (object) "";
          dataTable.Rows.Add(row2);
        }
        DataRow row3 = dataTable.NewRow();
        row3["Detail"] = (object) "Phòng";
        row3["Cost"] = (object) "";
        dataTable.Rows.Add(row3);
        foreach (RoomPurchaseInfo roomPurchaseInfo in (IEnumerable<RoomPurchaseInfo>) queryable)
        {
          int? nullable1 = roomPurchaseInfo.RoomDiscount;
          if (nullable1.HasValue)
          {
            int num5 = num3;
            nullable1 = roomPurchaseInfo.RoomDiscount;
            int num6 = nullable1.Value * 1000;
            num3 = num5 + num6;
          }
          nullable1 = roomPurchaseInfo.SerDiscount;
          if (nullable1.HasValue)
          {
            int num7 = num4;
            nullable1 = roomPurchaseInfo.SerDiscount;
            int num8 = nullable1.Value * 1000;
            num4 = num7 + num8;
          }
          DataRow row4 = dataTable.NewRow();
          DateTime? nullable2 = roomPurchaseInfo.CheckOutTime;
          if (nullable2.HasValue)
          {
            row4["Detail"] = (object) ("    " + roomPurchaseInfo.RoomNo + "   Vào: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckInTime) + "   Ra: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckOutTime));
            DataRow dataRow = row4;
            nullable1 = roomPurchaseInfo.Cost;
            string str = string.Format("{0:0,0}", (object) (nullable1.HasValue ? new int?(nullable1.GetValueOrDefault() * 1000) : new int?()));
            dataRow["Cost"] = (object) str;
          }
          else
          {
            row4["Detail"] = (object) ("    " + roomPurchaseInfo.RoomNo + "   Vào: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckInTime) + "   Ra: " + string.Format("{0:d/M/yy HH:mm}", (object) DateTime.Now));
            CalculatorCost cc = this.cc;
            string roomNo = roomPurchaseInfo.RoomNo;
            DateTime now = DateTime.Now;
            nullable2 = roomPurchaseInfo.CheckInTime;
            DateTime inTime = nullable2.Value;
            cc.GetData(roomNo, now, inTime, true);
            row4["Cost"] = (object) string.Format("{0:0,0}", (object) (this.cc.CalcuCost() * 1000));
          }
          dataTable.Rows.Add(row4);
        }
        DataRow row5 = dataTable.NewRow();
        row5["Detail"] = (object) "Dịch vụ";
        row5["Cost"] = (object) "";
        dataTable.Rows.Add(row5);
        IQueryable<\u003C\u003Ef__AnonymousType46<int?, string, int?, int?, DateTime?>> source1 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
        {
          r = r,
          s = s
        }).SelectMany(data => db.Services, (data, u) => new
        {
          \u003C\u003Eh__TransparentIdentifier1 = data,
          u = u
        }).Where(data => data.\u003C\u003Eh__TransparentIdentifier1.r.Loan == (int?) this.temp && data.\u003C\u003Eh__TransparentIdentifier1.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier1.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier1.s.ServiceID == (int?) data.u.ServiceID).Select(data => new
        {
          ServiceID = data.\u003C\u003Eh__TransparentIdentifier1.s.ServiceID,
          Name = data.u.Name,
          Number = data.\u003C\u003Eh__TransparentIdentifier1.s.Number,
          Cost = data.\u003C\u003Eh__TransparentIdentifier1.s.Cost,
          CheckInTime = data.\u003C\u003Eh__TransparentIdentifier1.r.CheckInTime
        });
        source1.GroupBy(r => new
        {
          ServiceID = r.ServiceID,
          Name = r.Name
        }).Select(g => new
        {
          ServiceID = g.Key.ServiceID,
          Name = g.Key.Name,
          Cost = g.Sum(r => r.Cost),
          Number = g.Sum(r => r.Number)
        });
        foreach (var data in source1)
        {
          if (data.Name != "")
          {
            DataRow row6 = dataTable.NewRow();
            row6["Detail"] = (object) ("    " + string.Format("{0:d/M/yy}", (object) data.CheckInTime.Value.Date) + "     " + data.Name + "  " + (object) data.Number);
            DataRow dataRow = row6;
            int? cost = data.Cost;
            string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
            dataRow["Cost"] = (object) str;
            dataTable.Rows.Add(row6);
          }
        }
        DataRow row7 = dataTable.NewRow();
        row7["Detail"] = (object) "Thu thêm";
        row7["Cost"] = (object) "";
        dataTable.Rows.Add(row7);
        IQueryable<\u003C\u003Ef__AnonymousType4<RoomPurchaseInfo, OutExpense>> source2 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<OutExpense>>>) (r => db.OutExpense), (r, s) => new
        {
          r = r,
          s = s
        }).Where(data => data.r.Loan == (int?) this.temp && data.s.PurchaseID == data.r.PurchaseID);
        Expression<Func<\u003C\u003Ef__AnonymousType4<RoomPurchaseInfo, OutExpense>, \u003C\u003Ef__AnonymousType12<string, int?>>> selector = data => new
        {
          ExpenseName = data.s.ExpenseName,
          Cost = data.s.Cost
        };
        foreach (var data in source2.Select(selector))
        {
          DataRow row8 = dataTable.NewRow();
          row8["Detail"] = (object) ("    " + data.ExpenseName + "  1");
          DataRow dataRow = row8;
          int? cost = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Cost"] = (object) str;
          dataTable.Rows.Add(row8);
        }
        foreach (RoomPurchaseInfo roomPurchaseInfo in (IEnumerable<RoomPurchaseInfo>) queryable)
          num2 += roomPurchaseInfo.Repaid.Value;
        DataRow row9 = dataTable.NewRow();
        row9["Detail"] = (object) "Trả trước";
        row9["Cost"] = (object) string.Format("{0:0,0}", (object) (num2 * 1000));
        dataTable.Rows.Add(row9);
        DataRow row10 = dataTable.NewRow();
        row10["Detail"] = (object) "Chiết khấu";
        row10["Cost"] = (object) "";
        dataTable.Rows.Add(row10);
        DataRow row11 = dataTable.NewRow();
        row11["Detail"] = (object) "    Tiền phòng: ";
        row11["Cost"] = (object) string.Format("{0:0,0}", (object) (this.dis1 * 1000 + num3));
        dataTable.Rows.Add(row11);
        DataRow row12 = dataTable.NewRow();
        row12["Detail"] = (object) "    Tiền dịch vụ: ";
        row12["Cost"] = (object) string.Format("{0:0,0}", (object) (this.dis2 * 1000 + num4));
        dataTable.Rows.Add(row12);
        for (int index = 0; index < dataTable.Rows.Count - 4; ++index)
        {
          if (dataTable.Rows[index]["Cost"].ToString() != "")
            num1 += int.Parse(dataTable.Rows[index]["Cost"].ToString(), NumberStyles.Currency);
        }
        DataRow row13 = dataTable.NewRow();
        row13["Detail"] = (object) "Tổng tiền";
        row13["Cost"] = (object) string.Format("{0:0,0}", (object) (num1 - this.dis1 * 1000 - this.dis2 * 1000 - num3 - num4 - num2 * 1000));
        dataTable.Rows.Add(row13);
        this.grvDetails.DataSource = (object) dataTable;
      }
      else
      {
        DataTable dataTable = new DataTable();
        DataColumn column3 = new DataColumn("Detail", typeof (string));
        dataTable.Columns.Add(column3);
        DataColumn column4 = new DataColumn("Cost", typeof (string));
        dataTable.Columns.Add(column4);
        int num9 = 0;
        int num10 = 0;
        int num11 = 0;
        int num12 = 0;
        SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        IQueryable<RoomPurchaseInfo> queryable = db.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.Loan == (int?) this.temp));
        if (this.cusid != 0)
        {
          var data2 = db.Customer.SelectMany((Expression<Func<Customer, IEnumerable<National>>>) (c => db.National), (c, n) => new
          {
            c = c,
            n = n
          }).Where(data => data.c.CusID == this.cusid && data.c.NationalID == (int?) data.n.NationalID).Select(data => new
          {
            CusName = data.c.CusName,
            Nation = data.n.Nation
          }).Single();
          DataRow row14 = dataTable.NewRow();
          row14["Detail"] = (object) ("Customer: " + data2.CusName);
          row14["Cost"] = (object) "";
          dataTable.Rows.Add(row14);
          DataRow row15 = dataTable.NewRow();
          row15["Detail"] = (object) ("National: " + data2.Nation);
          row15["Cost"] = (object) "";
          dataTable.Rows.Add(row15);
        }
        DataRow row16 = dataTable.NewRow();
        row16["Detail"] = (object) "Room Cost";
        row16["Cost"] = (object) "";
        dataTable.Rows.Add(row16);
        foreach (RoomPurchaseInfo roomPurchaseInfo in (IEnumerable<RoomPurchaseInfo>) queryable)
        {
          int? nullable3 = roomPurchaseInfo.RoomDiscount;
          if (nullable3.HasValue)
          {
            int num13 = num11;
            nullable3 = roomPurchaseInfo.RoomDiscount;
            int num14 = nullable3.Value * 1000;
            num11 = num13 + num14;
          }
          nullable3 = roomPurchaseInfo.SerDiscount;
          if (nullable3.HasValue)
          {
            int num15 = num12;
            nullable3 = roomPurchaseInfo.SerDiscount;
            int num16 = nullable3.Value * 1000;
            num12 = num15 + num16;
          }
          DataRow row17 = dataTable.NewRow();
          DateTime? nullable4 = roomPurchaseInfo.CheckOutTime;
          if (nullable4.HasValue)
          {
            row17["Detail"] = (object) ("    " + roomPurchaseInfo.RoomNo + "   In: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckInTime) + "   Out: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckOutTime));
            DataRow dataRow = row17;
            nullable3 = roomPurchaseInfo.Cost;
            string str = string.Format("{0:0,0}", (object) (nullable3.HasValue ? new int?(nullable3.GetValueOrDefault() * 1000) : new int?()));
            dataRow["Cost"] = (object) str;
          }
          else
          {
            row17["Detail"] = (object) ("    " + roomPurchaseInfo.RoomNo + "   In: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckInTime) + "   Out: " + string.Format("{0:d/M/yy HH:mm}", (object) DateTime.Now));
            CalculatorCost cc = this.cc;
            string roomNo = roomPurchaseInfo.RoomNo;
            DateTime now = DateTime.Now;
            nullable4 = roomPurchaseInfo.CheckInTime;
            DateTime inTime = nullable4.Value;
            cc.GetData(roomNo, now, inTime, true);
            row17["Cost"] = (object) string.Format("{0:0,0}", (object) (this.cc.CalcuCost() * 1000));
          }
          dataTable.Rows.Add(row17);
        }
        DataRow row18 = dataTable.NewRow();
        row18["Detail"] = (object) "Services Cost";
        row18["Cost"] = (object) "";
        dataTable.Rows.Add(row18);
        IQueryable<\u003C\u003Ef__AnonymousType47<int?, string, string, int?, int?, DateTime?>> source3 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
        {
          r = r,
          s = s
        }).SelectMany(data => db.Services, (data, u) => new
        {
          \u003C\u003Eh__TransparentIdentifier5 = data,
          u = u
        }).Where(data => data.\u003C\u003Eh__TransparentIdentifier5.r.Loan == (int?) this.temp && data.\u003C\u003Eh__TransparentIdentifier5.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier5.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier5.s.ServiceID == (int?) data.u.ServiceID).Select(data => new
        {
          ServiceID = data.\u003C\u003Eh__TransparentIdentifier5.s.ServiceID,
          Name = data.u.Name,
          OtherName = data.u.OtherName,
          Number = data.\u003C\u003Eh__TransparentIdentifier5.s.Number,
          Cost = data.\u003C\u003Eh__TransparentIdentifier5.s.Cost,
          CheckInTime = data.\u003C\u003Eh__TransparentIdentifier5.r.CheckInTime
        });
        source3.GroupBy(r => new
        {
          ServiceID = r.ServiceID,
          OtherName = r.OtherName
        }).Select(g => new
        {
          ServiceID = g.Key.ServiceID,
          OtherName = g.Key.OtherName,
          Cost = g.Sum(r => r.Cost),
          Number = g.Sum(r => r.Number)
        });
        foreach (var data in source3)
        {
          if (data.Name != "")
          {
            DataRow row19 = dataTable.NewRow();
            row19["Detail"] = (object) ("    " + string.Format("{0:d/M/yy}", (object) data.CheckInTime.Value.Date) + "     " + data.OtherName + "  " + (object) data.Number);
            DataRow dataRow = row19;
            int? cost = data.Cost;
            string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
            dataRow["Cost"] = (object) str;
            dataTable.Rows.Add(row19);
          }
        }
        DataRow row20 = dataTable.NewRow();
        row20["Detail"] = (object) "Other Services";
        row20["Cost"] = (object) "";
        dataTable.Rows.Add(row20);
        IQueryable<\u003C\u003Ef__AnonymousType4<RoomPurchaseInfo, OutExpense>> source4 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<OutExpense>>>) (r => db.OutExpense), (r, s) => new
        {
          r = r,
          s = s
        }).Where(data => data.r.Loan == (int?) this.temp && data.s.PurchaseID == data.r.PurchaseID);
        Expression<Func<\u003C\u003Ef__AnonymousType4<RoomPurchaseInfo, OutExpense>, \u003C\u003Ef__AnonymousType12<string, int?>>> selector = data => new
        {
          ExpenseName = data.s.ExpenseName,
          Cost = data.s.Cost
        };
        foreach (var data in source4.Select(selector))
        {
          DataRow row21 = dataTable.NewRow();
          row21["Detail"] = (object) ("    " + data.ExpenseName + "  1");
          DataRow dataRow = row21;
          int? cost = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Cost"] = (object) str;
          dataTable.Rows.Add(row21);
        }
        foreach (RoomPurchaseInfo roomPurchaseInfo in (IEnumerable<RoomPurchaseInfo>) queryable)
          num10 += roomPurchaseInfo.Repaid.Value;
        DataRow row22 = dataTable.NewRow();
        row22["Detail"] = (object) "Prepaid";
        row22["Cost"] = (object) string.Format("{0:0,0}", (object) (num10 * 1000));
        dataTable.Rows.Add(row22);
        DataRow row23 = dataTable.NewRow();
        row23["Detail"] = (object) "Discount";
        row23["Cost"] = (object) "";
        dataTable.Rows.Add(row23);
        DataRow row24 = dataTable.NewRow();
        row24["Detail"] = (object) "    Room discount: ";
        row24["Cost"] = (object) string.Format("{0:0,0}", (object) (this.dis1 * 1000 + num11));
        dataTable.Rows.Add(row24);
        DataRow row25 = dataTable.NewRow();
        row25["Detail"] = (object) "    Services discount: ";
        row25["Cost"] = (object) string.Format("{0:0,0}", (object) (this.dis2 * 1000 + num12));
        dataTable.Rows.Add(row25);
        for (int index = 0; index < dataTable.Rows.Count - 4; ++index)
        {
          if (dataTable.Rows[index]["Cost"].ToString() != "")
            num9 += int.Parse(dataTable.Rows[index]["Cost"].ToString(), NumberStyles.Currency);
        }
        DataRow row26 = dataTable.NewRow();
        row26["Detail"] = (object) "Total";
        row26["Cost"] = (object) string.Format("{0:0,0}", (object) (num9 - this.dis1 * 1000 - this.dis2 * 1000 - num11 - num12 - num10 * 1000));
        dataTable.Rows.Add(row26);
        this.grvDetails.DataSource = (object) dataTable;
      }
    }

    private void CreateByNonLoan()
    {
      if (this.isVietnam == 0)
      {
        DataTable dataTable = new DataTable();
        DataColumn column1 = new DataColumn("Detail", typeof (string));
        dataTable.Columns.Add(column1);
        DataColumn column2 = new DataColumn("Cost", typeof (string));
        dataTable.Columns.Add(column2);
        int num1 = 0;
        SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        RoomPurchaseInfo roomPurchaseInfo = db.RoomPurchaseInfo.Single<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this.temp));
        if (this.cusid != 0)
        {
          var data1 = db.Customer.SelectMany((Expression<Func<Customer, IEnumerable<National>>>) (c => db.National), (c, n) => new
          {
            c = c,
            n = n
          }).Where(data => data.c.CusID == this.cusid && data.c.NationalID == (int?) data.n.NationalID).Select(data => new
          {
            CusName = data.c.CusName,
            Nation = data.n.Nation
          }).Single();
          DataRow row1 = dataTable.NewRow();
          row1["Detail"] = (object) ("Tên khách hàng: " + data1.CusName);
          row1["Cost"] = (object) "";
          dataTable.Rows.Add(row1);
          DataRow row2 = dataTable.NewRow();
          row2["Detail"] = (object) ("Quốc tịch: " + data1.Nation);
          row2["Cost"] = (object) "";
          dataTable.Rows.Add(row2);
        }
        DataRow row3 = dataTable.NewRow();
        row3["Detail"] = (object) "Phòng";
        row3["Cost"] = (object) "";
        dataTable.Rows.Add(row3);
        DataRow row4 = dataTable.NewRow();
        DateTime? nullable1 = roomPurchaseInfo.CheckOutTime;
        int? cost1;
        if (nullable1.HasValue)
        {
          row4["Detail"] = (object) ("    " + roomPurchaseInfo.RoomNo + "   Vào: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckInTime) + "   Ra: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckOutTime));
          DataRow dataRow = row4;
          cost1 = roomPurchaseInfo.Cost;
          string str = string.Format("{0:0,0}", (object) (cost1.HasValue ? new int?(cost1.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Cost"] = (object) str;
        }
        else
        {
          row4["Detail"] = (object) ("    " + roomPurchaseInfo.RoomNo + "   Vào: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckInTime) + "   Ra: " + string.Format("{0:d/M/yy HH:mm}", (object) DateTime.Now));
          CalculatorCost cc = this.cc;
          string roomNo = roomPurchaseInfo.RoomNo;
          DateTime now = DateTime.Now;
          nullable1 = roomPurchaseInfo.CheckInTime;
          DateTime inTime = nullable1.Value;
          cc.GetData(roomNo, now, inTime, false);
          row4["Cost"] = (object) string.Format("{0:0,0}", (object) (this.cc.CalcuCost() * 1000));
        }
        dataTable.Rows.Add(row4);
        DataRow row5 = dataTable.NewRow();
        row5["Detail"] = (object) "Dịch vụ";
        row5["Cost"] = (object) "";
        dataTable.Rows.Add(row5);
        IQueryable<\u003C\u003Ef__AnonymousType4a<ServicesPurchaseInfo, Services>> source1 = db.ServicesPurchaseInfo.SelectMany((Expression<Func<ServicesPurchaseInfo, IEnumerable<Services>>>) (s => db.Services), (s, t) => new
        {
          s = s,
          t = t
        }).Where(data => data.s.PurchaseID == this.temp && data.s.ServiceID == (int?) data.t.ServiceID);
        Expression<Func<\u003C\u003Ef__AnonymousType4a<ServicesPurchaseInfo, Services>, \u003C\u003Ef__AnonymousType4b<int?, int?, string>>> selector1 = data => new
        {
          Number = data.s.Number,
          Cost = data.s.Cost,
          Name = data.t.Name
        };
        foreach (var data in source1.Select(selector1))
        {
          if (data.Name != "")
          {
            DataRow row6 = dataTable.NewRow();
            row6["Detail"] = (object) ("    " + data.Name + "  " + (object) data.Number);
            DataRow dataRow = row6;
            cost1 = data.Cost;
            string str = string.Format("{0:0,0}", (object) (cost1.HasValue ? new int?(cost1.GetValueOrDefault() * 1000) : new int?()));
            dataRow["Cost"] = (object) str;
            dataTable.Rows.Add(row6);
          }
        }
        DataRow row7 = dataTable.NewRow();
        row7["Detail"] = (object) "Thu thêm";
        row7["Cost"] = (object) "";
        dataTable.Rows.Add(row7);
        IQueryable<OutExpense> source2 = db.OutExpense.Where<OutExpense>((Expression<Func<OutExpense, bool>>) (s => s.PurchaseID == this.temp));
        Expression<Func<OutExpense, \u003C\u003Ef__AnonymousType12<string, int?>>> selector2 = s => new
        {
          ExpenseName = s.ExpenseName,
          Cost = s.Cost
        };
        foreach (var data in source2.Select(selector2))
        {
          DataRow row8 = dataTable.NewRow();
          row8["Detail"] = (object) ("    " + data.ExpenseName + "  1");
          DataRow dataRow = row8;
          int? cost2 = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost2.HasValue ? new int?(cost2.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Cost"] = (object) str;
          dataTable.Rows.Add(row8);
        }
        for (int index = 0; index < dataTable.Rows.Count; ++index)
        {
          if (dataTable.Rows[index]["Cost"].ToString() != "")
            num1 += int.Parse(dataTable.Rows[index]["Cost"].ToString(), NumberStyles.Currency);
        }
        DataRow row9 = dataTable.NewRow();
        row9["Detail"] = (object) "Trả trước";
        DataRow dataRow1 = row9;
        int? nullable2 = roomPurchaseInfo.Repaid;
        string str1 = string.Format("{0:0,0}", (object) (nullable2.HasValue ? new int?(nullable2.GetValueOrDefault() * 1000) : new int?()));
        dataRow1["Cost"] = (object) str1;
        dataTable.Rows.Add(row9);
        DataRow row10 = dataTable.NewRow();
        row10["Detail"] = (object) "Chiết khấu";
        row10["Cost"] = (object) "";
        dataTable.Rows.Add(row10);
        DataRow row11 = dataTable.NewRow();
        row11["Detail"] = (object) "    Tiền phòng: ";
        row11["Cost"] = (object) string.Format("{0:0,0}", (object) (this.dis1 * 1000));
        dataTable.Rows.Add(row11);
        DataRow row12 = dataTable.NewRow();
        row12["Detail"] = (object) "    Tiền dịch vụ: ";
        row12["Cost"] = (object) string.Format("{0:0,0}", (object) (this.dis2 * 1000));
        dataTable.Rows.Add(row12);
        DataRow row13 = dataTable.NewRow();
        row13["Detail"] = (object) "Tổng tiền";
        DataRow dataRow2 = row13;
        int num2 = num1 - this.dis1 * 1000 - this.dis2 * 1000;
        nullable2 = roomPurchaseInfo.Repaid;
        nullable2 = nullable2.HasValue ? new int?(nullable2.GetValueOrDefault() * 1000) : new int?();
        string str2 = string.Format("{0:0,0}", (object) (nullable2.HasValue ? new int?(num2 - nullable2.GetValueOrDefault()) : new int?()));
        dataRow2["Cost"] = (object) str2;
        dataTable.Rows.Add(row13);
        this.grvDetails.DataSource = (object) dataTable;
      }
      else
      {
        DataTable dataTable = new DataTable();
        DataColumn column3 = new DataColumn("Detail", typeof (string));
        dataTable.Columns.Add(column3);
        DataColumn column4 = new DataColumn("Cost", typeof (string));
        dataTable.Columns.Add(column4);
        int num3 = 0;
        SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        RoomPurchaseInfo roomPurchaseInfo = db.RoomPurchaseInfo.Single<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this.temp));
        if (this.cusid != 0)
        {
          var data2 = db.Customer.SelectMany((Expression<Func<Customer, IEnumerable<National>>>) (c => db.National), (c, n) => new
          {
            c = c,
            n = n
          }).Where(data => data.c.CusID == this.cusid && data.c.NationalID == (int?) data.n.NationalID).Select(data => new
          {
            CusName = data.c.CusName,
            Nation = data.n.Nation
          }).Single();
          DataRow row14 = dataTable.NewRow();
          row14["Detail"] = (object) ("Customer: " + data2.CusName);
          row14["Cost"] = (object) "";
          dataTable.Rows.Add(row14);
          DataRow row15 = dataTable.NewRow();
          row15["Detail"] = (object) ("National: " + data2.Nation);
          row15["Cost"] = (object) "";
          dataTable.Rows.Add(row15);
        }
        DataRow row16 = dataTable.NewRow();
        row16["Detail"] = (object) "Room Cost";
        row16["Cost"] = (object) "";
        dataTable.Rows.Add(row16);
        DataRow row17 = dataTable.NewRow();
        DateTime? nullable3 = roomPurchaseInfo.CheckOutTime;
        int? cost3;
        if (nullable3.HasValue)
        {
          row17["Detail"] = (object) ("    " + roomPurchaseInfo.RoomNo + "   In: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckInTime) + "   Out: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckOutTime));
          DataRow dataRow = row17;
          cost3 = roomPurchaseInfo.Cost;
          string str = string.Format("{0:0,0}", (object) (cost3.HasValue ? new int?(cost3.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Cost"] = (object) str;
        }
        else
        {
          row17["Detail"] = (object) ("    " + roomPurchaseInfo.RoomNo + "   In: " + string.Format("{0:d/M/yy HH:mm}", (object) roomPurchaseInfo.CheckInTime) + "   Out: " + string.Format("{0:d/M/yy HH:mm}", (object) DateTime.Now));
          CalculatorCost cc = this.cc;
          string roomNo = roomPurchaseInfo.RoomNo;
          DateTime now = DateTime.Now;
          nullable3 = roomPurchaseInfo.CheckInTime;
          DateTime inTime = nullable3.Value;
          cc.GetData(roomNo, now, inTime, false);
          row17["Cost"] = (object) string.Format("{0:0,0}", (object) (this.cc.CalcuCost() * 1000));
        }
        dataTable.Rows.Add(row17);
        DataRow row18 = dataTable.NewRow();
        row18["Detail"] = (object) "Service Cost";
        row18["Cost"] = (object) "";
        dataTable.Rows.Add(row18);
        IQueryable<\u003C\u003Ef__AnonymousType4a<ServicesPurchaseInfo, Services>> source3 = db.ServicesPurchaseInfo.SelectMany((Expression<Func<ServicesPurchaseInfo, IEnumerable<Services>>>) (s => db.Services), (s, t) => new
        {
          s = s,
          t = t
        }).Where(data => data.s.PurchaseID == this.temp && data.s.ServiceID == (int?) data.t.ServiceID);
        Expression<Func<\u003C\u003Ef__AnonymousType4a<ServicesPurchaseInfo, Services>, \u003C\u003Ef__AnonymousType4c<int?, int?, string>>> selector3 = data => new
        {
          Number = data.s.Number,
          Cost = data.s.Cost,
          OtherName = data.t.OtherName
        };
        foreach (var data in source3.Select(selector3))
        {
          if (data.OtherName != "")
          {
            DataRow row19 = dataTable.NewRow();
            row19["Detail"] = (object) ("    " + data.OtherName + "  " + (object) data.Number);
            DataRow dataRow = row19;
            cost3 = data.Cost;
            string str = string.Format("{0:0,0}", (object) (cost3.HasValue ? new int?(cost3.GetValueOrDefault() * 1000) : new int?()));
            dataRow["Cost"] = (object) str;
            dataTable.Rows.Add(row19);
          }
        }
        DataRow row20 = dataTable.NewRow();
        row20["Detail"] = (object) "Other Services";
        row20["Cost"] = (object) "";
        dataTable.Rows.Add(row20);
        IQueryable<OutExpense> source4 = db.OutExpense.Where<OutExpense>((Expression<Func<OutExpense, bool>>) (s => s.PurchaseID == this.temp));
        Expression<Func<OutExpense, \u003C\u003Ef__AnonymousType12<string, int?>>> selector4 = s => new
        {
          ExpenseName = s.ExpenseName,
          Cost = s.Cost
        };
        foreach (var data in source4.Select(selector4))
        {
          DataRow row21 = dataTable.NewRow();
          row21["Detail"] = (object) ("    " + data.ExpenseName + "  1");
          DataRow dataRow = row21;
          int? cost4 = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost4.HasValue ? new int?(cost4.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Cost"] = (object) str;
          dataTable.Rows.Add(row21);
        }
        for (int index = 0; index < dataTable.Rows.Count; ++index)
        {
          if (dataTable.Rows[index]["Cost"].ToString() != "")
            num3 += int.Parse(dataTable.Rows[index]["Cost"].ToString(), NumberStyles.Currency);
        }
        DataRow row22 = dataTable.NewRow();
        row22["Detail"] = (object) "Prepaid";
        DataRow dataRow3 = row22;
        int? nullable4 = roomPurchaseInfo.Repaid;
        string str3 = string.Format("{0:0,0}", (object) (nullable4.HasValue ? new int?(nullable4.GetValueOrDefault() * 1000) : new int?()));
        dataRow3["Cost"] = (object) str3;
        dataTable.Rows.Add(row22);
        DataRow row23 = dataTable.NewRow();
        row23["Detail"] = (object) "Discount";
        row23["Cost"] = (object) "";
        dataTable.Rows.Add(row23);
        DataRow row24 = dataTable.NewRow();
        row24["Detail"] = (object) "    Room discount: ";
        row24["Cost"] = (object) string.Format("{0:0,0}", (object) (this.dis1 * 1000));
        dataTable.Rows.Add(row24);
        DataRow row25 = dataTable.NewRow();
        row25["Detail"] = (object) "    Service discount: ";
        row25["Cost"] = (object) string.Format("{0:0,0}", (object) (this.dis2 * 1000));
        dataTable.Rows.Add(row25);
        DataRow row26 = dataTable.NewRow();
        row26["Detail"] = (object) "Total";
        DataRow dataRow4 = row26;
        int num4 = num3 - this.dis1 * 1000 - this.dis2 * 1000;
        nullable4 = roomPurchaseInfo.Repaid;
        nullable4 = nullable4.HasValue ? new int?(nullable4.GetValueOrDefault() * 1000) : new int?();
        string str4 = string.Format("{0:0,0}", (object) (nullable4.HasValue ? new int?(num4 - nullable4.GetValueOrDefault()) : new int?()));
        dataRow4["Cost"] = (object) str4;
        dataTable.Rows.Add(row26);
        this.grvDetails.DataSource = (object) dataTable;
      }
    }

    public void ConvertDGVtoExcel()
    {
      try
      {
        HotelInformation hotelInformation = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").HotelInformation.Single<HotelInformation>((Expression<Func<HotelInformation, bool>>) (x => x.ID == 1));
        object obj1 = (object) Missing.Value;
        string str1 = "                      " + hotelInformation.HotelName + "\n                      " + hotelInformation.Adress + "\n                      " + hotelInformation.PhoneNumber1 + "-" + hotelInformation.PhoneNumber2;
        string str2 = "                           HÓA ĐƠN THANH TOÁN";
        // ISSUE: variable of a compiler-generated type
        _Application instance = (_Application) Activator.CreateInstance(System.Type.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
        if (instance == null)
          throw new Exception("Cần phải cài [Microsoft Office] để thực hiện công việc này!");
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        _Workbook workbook = (_Workbook) instance.Workbooks.Add(System.Type.Missing);
        // ISSUE: variable of a compiler-generated type
        _Worksheet worksheet1 = (_Worksheet) null;
        // ISSUE: reference to a compiler-generated field
        if (PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site15 == null)
        {
          // ISSUE: reference to a compiler-generated field
          PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site15 = CallSite<Func<CallSite, object, _Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof (_Worksheet), typeof (PaymentDetail)));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        worksheet1 = PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site15.Target((CallSite) PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site15, workbook.Sheets[(object) "Sheet1"]);
        // ISSUE: reference to a compiler-generated field
        if (PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site16 == null)
        {
          // ISSUE: reference to a compiler-generated field
          PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site16 = CallSite<Func<CallSite, object, _Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof (_Worksheet), typeof (PaymentDetail)));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: variable of a compiler-generated type
        _Worksheet worksheet2 = PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site16.Target((CallSite) PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site16, workbook.ActiveSheet);
        string currentDirectory = Directory.GetCurrentDirectory();
        // ISSUE: reference to a compiler-generated method
        worksheet2.Shapes.AddPicture(currentDirectory + "\\Logo\\logo.png", MsoTriState.msoFalse, MsoTriState.msoCTrue, 5f, 5f, 40f, 40f);
        worksheet2.Cells[(object) 1, (object) 1] = (object) str1.ToString();
        worksheet2.Cells[(object) 3, (object) 1] = (object) str2.ToString();
        // ISSUE: reference to a compiler-generated field
        if (PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site17 == null)
        {
          // ISSUE: reference to a compiler-generated field
          PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site17 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (PaymentDetail), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj2 = PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site17.Target((CallSite) PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site17, worksheet2.Columns[(object) "A", System.Type.Missing], 40);
        // ISSUE: reference to a compiler-generated field
        if (PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site18 == null)
        {
          // ISSUE: reference to a compiler-generated field
          PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site18 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (PaymentDetail), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj3 = PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site18.Target((CallSite) PaymentDetail.\u003CConvertDGVtoExcel\u003Eo__SiteContainer14.\u003C\u003Ep__Site18, worksheet2.Columns[(object) "B", System.Type.Missing], 15);
        worksheet2.Columns.HorizontalAlignment = (object) XlHAlign.xlHAlignLeft;
        // ISSUE: variable of a compiler-generated type
        PageSetup pageSetup = worksheet2.PageSetup;
        pageSetup.PaperSize = XlPaperSize.xlPaperB5;
        // ISSUE: reference to a compiler-generated method
        pageSetup.LeftMargin = instance.Application.InchesToPoints(1.85);
        // ISSUE: reference to a compiler-generated method
        pageSetup.RightMargin = instance.Application.InchesToPoints(0.0);
        // ISSUE: reference to a compiler-generated method
        pageSetup.TopMargin = instance.Application.InchesToPoints(0.0);
        // ISSUE: reference to a compiler-generated method
        pageSetup.BottomMargin = instance.Application.InchesToPoints(0.0);
        pageSetup.Zoom = (object) 100;
        int num = 0;
        for (int index1 = 0; index1 < this.grvDetails.Rows.Count; ++index1)
        {
          for (int index2 = 0; index2 < this.grvDetails.Columns.Count; ++index2)
          {
            worksheet2.Cells[(object) (index1 + 5), (object) (index2 + 1)] = this.grvDetails.Rows[index1].Cells[index2].Value;
            ++num;
          }
        }
        worksheet2.Cells[(object) (num / 2 + 6), (object) 1] = (object) "Khách hàng";
        worksheet2.Cells[(object) (num / 2 + 6), (object) 2] = (object) "Thu Ngân";
        worksheet2.Cells[(object) (num / 2 + 11), (object) 1] = (object) "Xin chân thành cảm ơn quý khách!";
        instance.Visible = true;
        // ISSUE: reference to a compiler-generated method
        workbook.PrintPreview((object) true);
        instance.DisplayAlerts = false;
        instance.ActiveWorkbook.Saved = true;
        // ISSUE: reference to a compiler-generated method
        instance.Workbooks.Close();
        // ISSUE: reference to a compiler-generated method
        instance.Quit();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message.ToString());
      }
    }

    private void btnPrint_Click(object sender, EventArgs e) => this.ConvertDGVtoExcel();

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (this.comboBox1.SelectedIndex == 0)
      {
        this.isVietnam = 0;
        this.CreateBill();
      }
      else
      {
        this.isVietnam = 1;
        this.CreateBill();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PaymentDetail));
      this.grvDetails = new DataGridView();
      this.Detail = new DataGridViewTextBoxColumn();
      this.Cosy = new DataGridViewTextBoxColumn();
      this.btnCancel = new Button();
      this.label1 = new Label();
      this.comboBox1 = new ComboBox();
      ((ISupportInitialize) this.grvDetails).BeginInit();
      this.SuspendLayout();
      this.grvDetails.AllowUserToAddRows = false;
      this.grvDetails.AllowUserToDeleteRows = false;
      this.grvDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.grvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.grvDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.grvDetails.BackgroundColor = SystemColors.ControlLightLight;
      this.grvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvDetails.ColumnHeadersVisible = false;
      this.grvDetails.Columns.AddRange((DataGridViewColumn) this.Detail, (DataGridViewColumn) this.Cosy);
      this.grvDetails.GridColor = SystemColors.ControlLightLight;
      this.grvDetails.Location = new Point(0, 40);
      this.grvDetails.Margin = new Padding(4);
      this.grvDetails.MultiSelect = false;
      this.grvDetails.Name = "grvDetails";
      this.grvDetails.ReadOnly = true;
      this.grvDetails.RowHeadersVisible = false;
      this.grvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvDetails.Size = new Size(377, 387);
      this.grvDetails.TabIndex = 0;
      this.Detail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Detail.DataPropertyName = "Detail";
      gridViewCellStyle1.SelectionBackColor = Color.White;
      gridViewCellStyle1.SelectionForeColor = Color.Black;
      this.Detail.DefaultCellStyle = gridViewCellStyle1;
      this.Detail.HeaderText = "Detail";
      this.Detail.Name = "Detail";
      this.Detail.ReadOnly = true;
      this.Detail.Resizable = DataGridViewTriState.False;
      this.Cosy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.Cosy.DataPropertyName = "Cost";
      gridViewCellStyle2.SelectionBackColor = Color.White;
      gridViewCellStyle2.SelectionForeColor = Color.Black;
      this.Cosy.DefaultCellStyle = gridViewCellStyle2;
      this.Cosy.HeaderText = "Cost";
      this.Cosy.Name = "Cosy";
      this.Cosy.ReadOnly = true;
      this.Cosy.Resizable = DataGridViewTriState.False;
      this.Cosy.Width = 5;
      this.btnCancel.Anchor = AnchorStyles.Bottom;
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Location = new Point(258, 435);
      this.btnCancel.Margin = new Padding(4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(106, 37);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Red;
      this.label1.Location = new Point(12, 5);
      this.label1.Name = "label1";
      this.label1.Size = new Size(352, 31);
      this.label1.TabIndex = 2;
      this.label1.Text = " HÓA ĐƠN THANH TOÁN";
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[2]
      {
        (object) "Tiếng Việt",
        (object) "Tiếng Anh"
      });
      this.comboBox1.Location = new Point(13, 435);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(121, 24);
      this.comboBox1.TabIndex = 3;
      this.comboBox1.SelectionChangeCommitted += new EventHandler(this.comboBox1_SelectionChangeCommitted);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(378, 475);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.grvDetails);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximumSize = new Size(394, 513);
      this.MinimumSize = new Size(394, 513);
      this.Name = nameof (PaymentDetail);
      this.Text = "Thông tin thanh toán chi tiết";
      this.FormClosing += new FormClosingEventHandler(this.PaymentDetail_FormClosing);
      this.Load += new EventHandler(this.PaymentDetail_Load);
      ((ISupportInitialize) this.grvDetails).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
