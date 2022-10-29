// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.BillManager
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using Microsoft.CSharp.RuntimeBinder;
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
  public class BillManager : Form
  {
    private Main _parent;
    private DataTable otherTB;
    private IContainer components = (IContainer) null;
    private Button btnPrint;
    private Button btnCancel;
    private SaveFileDialog saveFileDialog1;
    private Button btnExport;
    private GroupBox groupBox3;
    private Label lblCalcu;
    private Label label6;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private GroupBox groupBox4;
    private ComboBox cmbReciever;
    private GroupBox groupBox2;
    private DataGridView grvBillManager;
    private GroupBox groupBox1;
    private DateTimePicker dtpTo;
    private Label label2;
    private Label label3;
    private DateTimePicker dtpByDay;
    private Label label1;
    private ComboBox cmbType;
    private GroupBox groupBox5;
    private DataGridView grvCashBook;
    private ProgressBar progressBar1;
    private TabPage tabPage3;
    private DateTimePicker dtpCashBook;
    private DataGridView dataGridView1;
    private ComboBox cmbTypeCash;

    public BillManager(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
      DateTime date = DateTime.Now.Date;
      this.dtpByDay.CustomFormat = "dd/MM/yyyy";
      this.dtpByDay.Format = DateTimePickerFormat.Custom;
      this.dtpTo.Visible = false;
      this.label2.Visible = false;
      this.cmbType.SelectedIndex = 0;
      this.grvBindData(date, 0);
      this.getReciever();
      this.cmbReciever.SelectedIndex = 0;
    }

    private void getReciever()
    {
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("Name", typeof (string));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("UserID", typeof (int));
      dataTable.Columns.Add(column2);
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType15<string, int>> queryable = smallHotelManager.Users.Where<Users>((Expression<Func<Users, bool>>) (u => u.UserID != 1)).Select(u => new
      {
        Name = u.Name,
        UserID = u.UserID
      });
      DataRow row1 = dataTable.NewRow();
      row1["Name"] = (object) "Tất cả";
      row1["UserID"] = (object) 0;
      dataTable.Rows.Add(row1);
      foreach (var data in queryable)
      {
        DataRow row2 = dataTable.NewRow();
        row2["Name"] = (object) data.Name;
        row2["UserID"] = (object) data.UserID;
        dataTable.Rows.Add(row2);
      }
      this.cmbReciever.DataSource = (object) dataTable;
      this.cmbReciever.DisplayMember = "Name";
      this.cmbReciever.ValueMember = "UserID";
      smallHotelManager.Connection.Close();
    }

    private void grvBindData(DateTime date, int userid)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      BillManager.\u003C\u003Ec__DisplayClass21 cDisplayClass21 = new BillManager.\u003C\u003Ec__DisplayClass21();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass21.date = date;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass21.userid = userid;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass21.loanList = new List<int>();
      List<int> source1 = new List<int>();
      // ISSUE: reference to a compiler-generated field
      DateTime dateTime1 = cDisplayClass21.date.AddDays(1.0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      cDisplayClass21.dt1 = new DateTime(cDisplayClass21.date.Year, cDisplayClass21.date.Month, cDisplayClass21.date.Day, 5, 0, 0);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass21.dt2 = new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day, 5, 0, 0);
      string connection = "Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;";
      // ISSUE: reference to a compiler-generated field
      cDisplayClass21.db = new SmallHotelManager.SmallHotelManager(connection);
      this.grvBillManager.Columns.Clear();
      int num1 = 1;
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("PurchaseID", typeof (int));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("STT", typeof (int));
      dataTable.Columns.Add(column2);
      DataColumn column3 = new DataColumn("Số phòng", typeof (string));
      dataTable.Columns.Add(column3);
      DataColumn column4 = new DataColumn("Giờ vào", typeof (string));
      dataTable.Columns.Add(column4);
      DataColumn column5 = new DataColumn("Giờ ra", typeof (string));
      dataTable.Columns.Add(column5);
      DataColumn column6 = new DataColumn("Dịch vụ", typeof (string));
      dataTable.Columns.Add(column6);
      DataColumn column7 = new DataColumn("Tiền DV", typeof (string));
      dataTable.Columns.Add(column7);
      DataColumn column8 = new DataColumn("Tiền phòng", typeof (string));
      dataTable.Columns.Add(column8);
      DataColumn column9 = new DataColumn("Trả trước", typeof (string));
      dataTable.Columns.Add(column9);
      DataColumn column10 = new DataColumn("Chiết khấu", typeof (string));
      dataTable.Columns.Add(column10);
      DataColumn column11 = new DataColumn("Người thu tiền", typeof (string));
      dataTable.Columns.Add(column11);
      DataColumn column12 = new DataColumn("Ghi chú", typeof (string));
      dataTable.Columns.Add(column12);
      dataTable.Columns[0].ColumnMapping = MappingType.Hidden;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<\u003C\u003Ef__AnonymousType19<int, DateTime?, DateTime?, string, string, string, int, int, int, int, string, int?, int?>> source2 = cDisplayClass21.db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (rpi => cDisplayClass21.db.ServicesPurchaseInfo), (rpi, spi) => new
      {
        rpi = rpi,
        spi = spi
      }).SelectMany(data => cDisplayClass21.db.Services, (data, s) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        s = s
      }).SelectMany(data => cDisplayClass21.db.Users, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifier1 = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.spi.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.spi.ServiceID == (int?) data.\u003C\u003Eh__TransparentIdentifier1.s.ServiceID && data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.UserID == (int?) data.u.UserID && data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.CheckInTime >= (DateTime?) cDisplayClass21.dt1 && data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.CheckInTime <= (DateTime?) cDisplayClass21.dt2 && data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.CheckOutTime.HasValue).Select(data => new
      {
        PurchaseID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.spi.PurchaseID,
        CheckInTime = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.CheckInTime,
        CheckOutTime = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.CheckOutTime,
        RoomNo = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.RoomNo,
        Service = data.\u003C\u003Eh__TransparentIdentifier1.s.Name.ToString() + ":" + data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.spi.Number.ToString(),
        Name = data.u.Name,
        PrePaid = (int) data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.Repaid * 1000,
        RoomCost = (int) data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.Cost * 1000,
        ServiceCost = (int) data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.spi.Cost * 1000,
        Bonus = ((int) data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.RoomDiscount + (int) data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.SerDiscount) * 1000,
        Note = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.Note,
        Loan = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.Loan,
        UserID = data.\u003C\u003Eh__TransparentIdentifier1.\u003C\u003Eh__TransparentIdentifier0.rpi.UserID
      });
      // ISSUE: reference to a compiler-generated field
      if (cDisplayClass21.userid != 0)
      {
        // ISSUE: reference to a compiler-generated field
        source2 = source2.AsQueryable().Where(t => t.UserID == (int?) cDisplayClass21.userid);
      }
      IQueryable<IGrouping<int, \u003C\u003Ef__AnonymousType19<int, DateTime?, DateTime?, string, string, string, int, int, int, int, string, int?, int?>>> queryable1 = source2.GroupBy(u => u.PurchaseID);
      int num2 = 0;
      using (IEnumerator<IGrouping<int, \u003C\u003Ef__AnonymousType19<int, DateTime?, DateTime?, string, string, string, int, int, int, int, string, int?, int?>>> enumerator = queryable1.GetEnumerator())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        BillManager.\u003C\u003Ec__DisplayClass23 cDisplayClass23 = new BillManager.\u003C\u003Ec__DisplayClass23();
        // ISSUE: reference to a compiler-generated field
        cDisplayClass23.CS\u0024\u003C\u003E8__locals22 = cDisplayClass21;
        while (enumerator.MoveNext())
        {
          // ISSUE: reference to a compiler-generated field
          cDisplayClass23.item = enumerator.Current;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          IQueryable<OutExpense> queryable2 = cDisplayClass21.db.OutExpense.Where<OutExpense>((Expression<Func<OutExpense, bool>>) (r => r.PurchaseID == cDisplayClass23.item.Select(u => u.PurchaseID).First<int>()));
          DataRow row = dataTable.NewRow();
          // ISSUE: reference to a compiler-generated field
          row["PurchaseID"] = (object) cDisplayClass23.item.Key;
          row["STT"] = (object) num1;
          // ISSUE: reference to a compiler-generated field
          row["Số phòng"] = (object) cDisplayClass23.item.Select(u => u.RoomNo).First<string>();
          // ISSUE: reference to a compiler-generated field
          row["Giờ vào"] = (object) string.Format("{0:d/M/yy HH:mm}", (object) cDisplayClass23.item.Select(u => u.CheckInTime).First<DateTime?>());
          // ISSUE: reference to a compiler-generated field
          row["Giờ ra"] = (object) string.Format("{0:d/M/yy HH:mm}", (object) cDisplayClass23.item.Select(u => u.CheckOutTime).First<DateTime?>());
          int num3;
          // ISSUE: reference to a compiler-generated field
          foreach (var data in cDisplayClass23.item)
          {
            if (!data.Service.Equals(":0"))
            {
              DataRow dataRow;
              (dataRow = row)["Dịch vụ"] = (object) (dataRow["Dịch vụ"].ToString() + data.Service + ", ");
              int num4 = num2;
              num3 = data.ServiceCost;
              int num5 = int.Parse(num3.ToString());
              num2 = num4 + num5;
            }
          }
          foreach (OutExpense outExpense in (IEnumerable<OutExpense>) queryable2)
          {
            DataRow dataRow;
            (dataRow = row)["Dịch vụ"] = (object) (dataRow["Dịch vụ"].ToString() + outExpense.ExpenseName + ", ");
            num2 += int.Parse(outExpense.Cost.ToString()) * 1000;
          }
          // ISSUE: reference to a compiler-generated field
          num3 = cDisplayClass23.item.Select(u => u.PrePaid).First<int>();
          int num6 = int.Parse(num3.ToString());
          // ISSUE: reference to a compiler-generated field
          num3 = cDisplayClass23.item.Select(u => u.Bonus).First<int>();
          int num7 = int.Parse(num3.ToString());
          row["Trả trước"] = num6 == 0 ? (object) "" : (object) string.Format("{0:0,0}", (object) num6);
          // ISSUE: reference to a compiler-generated field
          num3 = cDisplayClass23.item.Select(u => u.RoomCost).First<int>();
          int num8 = int.Parse(num3.ToString());
          row["Tiền DV"] = (object) string.Format("{0:0,0}", (object) num2);
          row["Tiền phòng"] = (object) string.Format("{0:0,0}", (object) num8);
          row["Chiết khấu"] = num7 == 0 ? (object) "" : (object) string.Format("{0:0,0}", (object) num7);
          // ISSUE: reference to a compiler-generated field
          row["Người thu tiền"] = (object) cDisplayClass23.item.Select(u => u.Name).First<string>();
          // ISSUE: reference to a compiler-generated field
          row["Ghi chú"] = (object) cDisplayClass23.item.Select(u => u.Note).First<string>();
          // ISSUE: reference to a compiler-generated field
          int? nullable1 = cDisplayClass23.item.Select(u => u.Loan).First<int?>();
          int num9;
          if (nullable1.HasValue)
          {
            // ISSUE: reference to a compiler-generated field
            nullable1 = cDisplayClass23.item.Select(u => u.Loan).First<int?>();
            num9 = (nullable1.GetValueOrDefault() != 0 ? 1 : (!nullable1.HasValue ? 1 : 0)) == 0 ? 1 : 0;
          }
          else
            num9 = 1;
          if (num9 == 0)
          {
            // ISSUE: reference to a compiler-generated field
            nullable1 = cDisplayClass23.item.Select(u => u.Loan).First<int?>();
            DateTime dateTime2 = this.CheckLoanRoom(nullable1.Value);
            // ISSUE: reference to a compiler-generated field
            DateTime? nullable2 = cDisplayClass23.item.Select(u => u.CheckOutTime).First<DateTime?>();
            if ((!nullable2.HasValue ? 1 : (dateTime2 != nullable2.GetValueOrDefault() ? 1 : 0)) != 0)
            {
              row["Ghi chú"] = (object) "Lưu";
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              List<int> loanList = cDisplayClass21.loanList;
              // ISSUE: reference to a compiler-generated field
              nullable1 = cDisplayClass23.item.Select(u => u.Loan).First<int?>();
              int num10 = nullable1.Value;
              loanList.Add(num10);
            }
          }
          dataTable.Rows.Add(row);
          ++num1;
          num2 = 0;
        }
      }
      this.grvBillManager.DataSource = (object) dataTable;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      this.groupBox3.Text = "Ngày " + (object) cDisplayClass21.date.Day + " tháng " + (object) cDisplayClass21.date.Month + " năm " + (object) cDisplayClass21.date.Year;
      int num11 = 0;
      int num12 = 0;
      int num13 = 0;
      int num14 = 0;
      int num15 = 0;
      int num16 = 0;
      int num17 = 0;
      int num18 = 0;
      for (int index = 0; index < this.grvBillManager.Rows.Count; ++index)
      {
        num16 += int.Parse(this.grvBillManager.Rows[index].Cells[5].Value.ToString(), NumberStyles.Currency);
        num11 += int.Parse(this.grvBillManager.Rows[index].Cells[6].Value.ToString(), NumberStyles.Currency);
        if (this.grvBillManager.Rows[index].Cells[7].Value.ToString() != "")
          num14 += int.Parse(this.grvBillManager.Rows[index].Cells[7].Value.ToString(), NumberStyles.Currency);
        if (this.grvBillManager.Rows[index].Cells[8].Value.ToString() != "")
          num18 += int.Parse(this.grvBillManager.Rows[index].Cells[8].Value.ToString(), NumberStyles.Currency);
        if (this.grvBillManager.Rows[index].Cells[10].Value.ToString() == "Lưu")
        {
          int num19 = 0;
          if (this.grvBillManager.Rows[index].Cells[8].Value.ToString() != "")
            num19 = int.Parse(this.grvBillManager.Rows[index].Cells[8].Value.ToString(), NumberStyles.Currency);
          num15 += int.Parse(this.grvBillManager.Rows[index].Cells[6].Value.ToString(), NumberStyles.Currency) + int.Parse(this.grvBillManager.Rows[index].Cells[5].Value.ToString(), NumberStyles.Currency) - num19;
        }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<int?> source3 = cDisplayClass21.db.Spending.Where<Spending>((Expression<Func<Spending, bool>>) (s => s.SpendDate >= (DateTime?) cDisplayClass21.dt1 && s.SpendDate <= (DateTime?) cDisplayClass21.dt2)).Select<Spending, int?>((Expression<Func<Spending, int?>>) (s => s.Cost));
      int? nullable;
      if (source3.Any<int?>())
      {
        nullable = Queryable.Sum(source3);
        num12 = nullable.Value * 1000;
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<int?> source4 = cDisplayClass21.db.OutInCome.Where<OutInCome>((Expression<Func<OutInCome, bool>>) (outI => outI.DateIncome == (DateTime?) cDisplayClass21.date)).Select<OutInCome, int?>((Expression<Func<OutInCome, int?>>) (outI => outI.Cost));
      if (source4.Any<int?>())
      {
        nullable = Queryable.Sum(source4);
        num13 = nullable.Value * 1000;
      }
      DataRow row1 = dataTable.NewRow();
      row1["Người thu tiền"] = (object) "";
      dataTable.Rows.Add(row1);
      DataRow row2 = dataTable.NewRow();
      row2["Số phòng"] = (object) "DV đã bán";
      row2["Dịch vụ"] = (object) "Phòng lưu thanh toán";
      row2["Trả trước"] = (object) "Chi";
      dataTable.Rows.Add(row2);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass21.loanList.Distinct<int>().ToList<int>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<Spending> source5 = cDisplayClass21.db.Spending.Where<Spending>((Expression<Func<Spending, bool>>) (s => s.SpendDate >= (DateTime?) cDisplayClass21.dt1 && s.SpendDate <= (DateTime?) cDisplayClass21.dt2));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<\u003C\u003Ef__AnonymousType1b<int?, string, int?, int?, int?>> source6 = cDisplayClass21.db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => cDisplayClass21.db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).SelectMany(data => cDisplayClass21.db.Services, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifier3 = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier3.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier3.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier3.s.ServiceID == (int?) data.u.ServiceID && data.\u003C\u003Eh__TransparentIdentifier3.r.CheckInTime >= (DateTime?) cDisplayClass21.dt1 && data.\u003C\u003Eh__TransparentIdentifier3.r.CheckInTime <= (DateTime?) cDisplayClass21.dt2 && data.\u003C\u003Eh__TransparentIdentifier3.r.CheckOutTime.HasValue).Select(data => new
      {
        ServiceID = data.\u003C\u003Eh__TransparentIdentifier3.s.ServiceID,
        Name = data.u.Name,
        Number = data.\u003C\u003Eh__TransparentIdentifier3.s.Number,
        Cost = data.\u003C\u003Eh__TransparentIdentifier3.s.Cost,
        UserID = data.\u003C\u003Eh__TransparentIdentifier3.r.UserID
      });
      // ISSUE: reference to a compiler-generated field
      if (cDisplayClass21.userid != 0)
      {
        // ISSUE: reference to a compiler-generated field
        source6 = source6.AsQueryable().Where(t => t.UserID == (int?) cDisplayClass21.userid);
      }
      IQueryable<\u003C\u003Ef__AnonymousType8<int?, string, int?, int?>> source7 = source6.GroupBy(r => new
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
      int num20 = 0;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      BillManager.\u003C\u003Ec__DisplayClass25 cDisplayClass25 = new BillManager.\u003C\u003Ec__DisplayClass25();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass25.CS\u0024\u003C\u003E8__locals22 = cDisplayClass21;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      for (cDisplayClass25.k = 0; cDisplayClass25.k < cDisplayClass21.loanList.Count; ++cDisplayClass25.k)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        IQueryable<RoomPurchaseInfo> source8 = cDisplayClass21.db.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (l => l.Loan == (int?) cDisplayClass21.loanList[cDisplayClass25.k]));
        num20 += source8.Count<RoomPurchaseInfo>();
      }
      source1.Add(num20);
      source1.Add(source5.Count<Spending>());
      source1.Add(source7.Count());
      for (int index = 0; index <= source1.Max() + 7; ++index)
      {
        DataRow row3 = dataTable.NewRow();
        row3["Người thu tiền"] = (object) "";
        dataTable.Rows.Add(row3);
      }
      this.grvBillManager.DataSource = (object) dataTable;
      this.grvBillManager.Rows[dataTable.Rows.Count - source1.Max() - 10].Cells[5].Value = (object) string.Format("{0:0,0}", (object) num16);
      this.grvBillManager.Rows[dataTable.Rows.Count - source1.Max() - 10].Cells[6].Value = (object) string.Format("{0:0,0}", (object) num11);
      this.grvBillManager.Rows[dataTable.Rows.Count - source1.Max() - 10].Cells[7].Value = (object) string.Format("{0:0,0}", (object) num14);
      this.grvBillManager.Rows[dataTable.Rows.Count - source1.Max() - 10].Cells[8].Value = (object) string.Format("{0:0,0}", (object) num18);
      int num21 = -1;
      int num22 = 0;
      if (source7.Any())
      {
        foreach (var data in source7)
        {
          if (!data.Name.Equals(""))
          {
            this.grvBillManager.Rows[num21 + this.grvBillManager.RowCount - source1.Max() - 7].Cells[1].Value = (object) data.Name.ToString();
            DataGridViewCell cell = this.grvBillManager.Rows[num21 + this.grvBillManager.RowCount - source1.Max() - 7].Cells[2];
            nullable = data.Number;
            string str1 = nullable.ToString();
            nullable = data.Cost;
            string str2 = string.Format("{0:0,0}", (object) (nullable.HasValue ? new int?(nullable.GetValueOrDefault() * 1000) : new int?()));
            string str3 = str1 + "  -  " + str2;
            cell.Value = (object) str3;
            int num23 = num22;
            nullable = data.Cost;
            int num24 = nullable.Value * 1000;
            num22 = num23 + num24;
            ++num21;
          }
        }
      }
      this.grvBillManager.Rows[num21 + this.grvBillManager.RowCount - source1.Max() - 7].Cells[2].Value = (object) string.Format("{0:0,0}", (object) num22);
      int num25 = -1;
      if (source5.Any<Spending>())
      {
        foreach (Spending spending in (IEnumerable<Spending>) source5)
        {
          this.grvBillManager.Rows[num25 + this.grvBillManager.RowCount - source1.Max() - 7].Cells[7].Value = (object) spending.Reasson.ToString();
          DataGridViewCell cell = this.grvBillManager.Rows[num25 + this.grvBillManager.RowCount - source1.Max() - 7].Cells[8];
          nullable = spending.Cost;
          string str = string.Format("{0:0,0}", (object) (nullable.HasValue ? new int?(nullable.GetValueOrDefault() * 1000) : new int?()));
          cell.Value = (object) str;
          ++num25;
        }
      }
      int num26 = -1;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      BillManager.\u003C\u003Ec__DisplayClass27 cDisplayClass27 = new BillManager.\u003C\u003Ec__DisplayClass27();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass27.CS\u0024\u003C\u003E8__locals22 = cDisplayClass21;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      for (cDisplayClass27.k = 0; cDisplayClass27.k < cDisplayClass21.loanList.Count; ++cDisplayClass27.k)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        IQueryable<IGrouping<\u003C\u003Ef__AnonymousType1e<int>, \u003C\u003Ef__AnonymousType1d<int, string, DateTime, DateTime, int?, int?, int?, int?>>> source9 = cDisplayClass21.db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (l => cDisplayClass21.db.ServicesPurchaseInfo), (l, s) => new
        {
          l = l,
          s = s
        }).Where(data => data.l.Loan == (int?) cDisplayClass21.loanList[cDisplayClass27.k] && data.l.PurchaseID == data.s.PurchaseID).Select(data => new
        {
          PurchaseID = data.l.PurchaseID,
          RoomNo = data.l.RoomNo,
          ChecInTime = data.l.CheckInTime.Value,
          CheckOutTime = data.l.CheckOutTime.Value,
          RoomCost = data.l.Cost,
          ServiceCost = data.s.Cost,
          Prepaid = data.l.Repaid,
          Bonus = data.l.RoomDiscount + data.l.SerDiscount
        }).GroupBy(r => new{ PurchaseID = r.PurchaseID });
        Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType1e<int>, \u003C\u003Ef__AnonymousType1d<int, string, DateTime, DateTime, int?, int?, int?, int?>>, \u003C\u003Ef__AnonymousType1f<int, string, int?, DateTime, DateTime>>> selector = g => new
        {
          PurchaseID = g.Select(r => r.PurchaseID).First<int>(),
          RoomNo = g.Select(r => r.RoomNo).First<string>(),
          TotalCost = g.Sum(r => r.ServiceCost) + g.Select(r => r.RoomCost).First<int?>() - g.Select(r => r.Bonus).First<int?>() - g.Select(r => r.Prepaid).First<int?>(),
          CheckInTime = g.Select(r => r.ChecInTime).First<DateTime>(),
          CheckOutTime = g.Select(r => r.CheckOutTime).First<DateTime>()
        };
        using (IEnumerator<\u003C\u003Ef__AnonymousType1f<int, string, int?, DateTime, DateTime>> enumerator = source9.Select(selector).GetEnumerator())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          BillManager.\u003C\u003Ec__DisplayClass29 cDisplayClass29 = new BillManager.\u003C\u003Ec__DisplayClass29();
          // ISSUE: reference to a compiler-generated field
          cDisplayClass29.CS\u0024\u003C\u003E8__locals28 = cDisplayClass27;
          // ISSUE: reference to a compiler-generated field
          cDisplayClass29.CS\u0024\u003C\u003E8__locals22 = cDisplayClass21;
          while (enumerator.MoveNext())
          {
            // ISSUE: reference to a compiler-generated field
            cDisplayClass29.item = enumerator.Current;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass29.item.CheckOutTime != this.CheckLoanRoom(cDisplayClass21.loanList[cDisplayClass27.k]))
            {
              int num27 = 0;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              IQueryable<OutExpense> source10 = cDisplayClass21.db.OutExpense.SelectMany((Expression<Func<OutExpense, IEnumerable<RoomPurchaseInfo>>>) (r => cDisplayClass21.db.RoomPurchaseInfo), (r, s) => new
              {
                r = r,
                s = s
              }).Where(data => data.r.PurchaseID == data.s.PurchaseID && data.s.PurchaseID == cDisplayClass29.item.PurchaseID).Select(data => data.r);
              if (source10.Any<OutExpense>())
              {
                foreach (OutExpense outExpense in (IEnumerable<OutExpense>) source10)
                {
                  int num28 = num27;
                  nullable = outExpense.Cost;
                  int num29 = nullable.Value;
                  num27 = num28 + num29;
                }
              }
              DateTime dateTime3;
              ref DateTime local = ref dateTime3;
              // ISSUE: reference to a compiler-generated field
              int year = cDisplayClass29.item.CheckInTime.Year;
              // ISSUE: reference to a compiler-generated field
              DateTime dateTime4 = cDisplayClass29.item.CheckInTime;
              int month = dateTime4.Month;
              // ISSUE: reference to a compiler-generated field
              dateTime4 = cDisplayClass29.item.CheckInTime;
              int day = dateTime4.Day;
              local = new DateTime(year, month, day, 5, 0, 0);
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass29.item.CheckInTime <= dateTime3)
              {
                DataGridViewCell cell = this.grvBillManager.Rows[num26 + this.grvBillManager.RowCount - source1.Max() - 6].Cells[4];
                // ISSUE: reference to a compiler-generated field
                string str4 = cDisplayClass29.item.RoomNo.ToString();
                // ISSUE: reference to a compiler-generated field
                dateTime4 = cDisplayClass29.item.CheckInTime;
                dateTime4 = dateTime4.AddDays(-1.0);
                string str5 = string.Format("{0:d/M/yyyy}", (object) dateTime4.Date);
                string str6 = str4 + "  " + str5;
                cell.Value = (object) str6;
              }
              else
              {
                DataGridViewCell cell = this.grvBillManager.Rows[num26 + this.grvBillManager.RowCount - source1.Max() - 6].Cells[4];
                // ISSUE: reference to a compiler-generated field
                string str7 = cDisplayClass29.item.RoomNo.ToString();
                // ISSUE: reference to a compiler-generated field
                dateTime4 = cDisplayClass29.item.CheckInTime;
                string str8 = string.Format("{0:d/M/yyyy}", (object) dateTime4.Date);
                string str9 = str7 + "  " + str8;
                cell.Value = (object) str9;
              }
              DataGridViewCell cell1 = this.grvBillManager.Rows[num26 + this.grvBillManager.RowCount - source1.Max() - 6].Cells[5];
              // ISSUE: reference to a compiler-generated field
              nullable = cDisplayClass29.item.TotalCost;
              int num30 = num27;
              nullable = nullable.HasValue ? new int?(nullable.GetValueOrDefault() + num30) : new int?();
              string str = string.Format("{0:0,0}", (object) (nullable.HasValue ? new int?(nullable.GetValueOrDefault() * 1000) : new int?()));
              cell1.Value = (object) str;
              int num31 = num17;
              // ISSUE: reference to a compiler-generated field
              nullable = cDisplayClass29.item.TotalCost;
              int num32 = (nullable.Value + num27) * 1000;
              num17 = num31 + num32;
              ++num26;
            }
          }
        }
      }
      string str10 = string.Format("{0:0,0}", (object) num13);
      string str11 = string.Format("{0:0,0}", (object) (num11 + num16 + num17 - num18));
      string str12 = string.Format("{0:0,0}", (object) num14);
      string str13 = string.Format("{0:0,0}", (object) num15);
      string str14 = string.Format("{0:0,0}", (object) num12);
      int num33 = num11 + num16 + num14 + num17 + num13 - num12 - num15 - num18;
      this.lblCalcu.Text = "( " + str11 + " + " + str12 + " + " + str10 + " ) - " + str13 + " - " + str14 + " = " + string.Format("{0:0,0}", (object) num33) + " VNĐ";
      this.label6.Text = "(Tổng thu  +  trả trước + VAT)  -  nợ  -  chi  =  thực thu";
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 6].Cells[1].Value = (object) "Tổng thu:";
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 6].Cells[2].Value = (object) str11;
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 5].Cells[1].Value = (object) "Trả trước:";
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 5].Cells[2].Value = (object) str12;
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 4].Cells[1].Value = (object) "VAT:";
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 4].Cells[2].Value = (object) str10;
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 3].Cells[1].Value = (object) "Nợ:";
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 3].Cells[2].Value = (object) str13;
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 2].Cells[1].Value = (object) "Chi";
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 2].Cells[2].Value = (object) str14;
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 1].Cells[1].Value = (object) "Thực thu:";
      this.grvBillManager.Rows[this.grvBillManager.RowCount - 1].Cells[2].Value = (object) string.Format("{0:0,0}", (object) num33);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass21.db.Connection.Close();
    }

    private DataRow getDayInfo(DateTime date, int number)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      BillManager.\u003C\u003Ec__DisplayClass46 cDisplayClass46 = new BillManager.\u003C\u003Ec__DisplayClass46();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass46.loanList = new List<int>();
      DataRow dayInfo = this.otherTB.NewRow();
      DateTime dateTime1 = date.AddDays(1.0);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass46.dt1 = new DateTime(date.Year, date.Month, date.Day, 5, 0, 0);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass46.dt2 = new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day, 5, 0, 0);
      string connection = "Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;";
      // ISSUE: reference to a compiler-generated field
      cDisplayClass46.db = new SmallHotelManager.SmallHotelManager(connection);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<\u003C\u003Ef__AnonymousType22<int, string, int, int, int, int, int?, int?, int?, DateTime?>> queryable1 = cDisplayClass46.db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (rpi => cDisplayClass46.db.ServicesPurchaseInfo), (rpi, spi) => new
      {
        rpi = rpi,
        spi = spi
      }).SelectMany(data => cDisplayClass46.db.Services, (data, s) => new
      {
        \u003C\u003Eh__TransparentIdentifier2b = data,
        s = s
      }).SelectMany(data => cDisplayClass46.db.Users, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifier2c = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.spi.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.spi.ServiceID == (int?) data.\u003C\u003Eh__TransparentIdentifier2c.s.ServiceID && data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.UserID == (int?) data.u.UserID && data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.CheckInTime >= (DateTime?) cDisplayClass46.dt1 && data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.CheckInTime <= (DateTime?) cDisplayClass46.dt2 && data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.CheckOutTime.HasValue && (data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.IsPaid != (int?) 0 || !data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.IsPaid.HasValue)).Select(data => new
      {
        PurchaseID = data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.spi.PurchaseID,
        Service = data.\u003C\u003Eh__TransparentIdentifier2c.s.Name.ToString() + ":" + data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.spi.Number.ToString(),
        PrePaid = (int) data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.Repaid * 1000,
        RoomCost = (int) data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.Cost * 1000,
        ServiceCost = (int) data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.spi.Cost * 1000,
        Bonus = ((int) data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.RoomDiscount + (int) data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.SerDiscount) * 1000,
        UserID = data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.UserID,
        Loan = data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.Loan,
        IsPaid = data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.IsPaid,
        CheckOutTime = data.\u003C\u003Eh__TransparentIdentifier2c.\u003C\u003Eh__TransparentIdentifier2b.rpi.CheckOutTime
      });
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<\u003C\u003Ef__AnonymousType8<int?, string, int?, int?>> source1 = cDisplayClass46.db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => cDisplayClass46.db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).SelectMany(data => cDisplayClass46.db.Services, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifier2e = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier2e.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier2e.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier2e.s.ServiceID == (int?) data.u.ServiceID && data.\u003C\u003Eh__TransparentIdentifier2e.r.CheckInTime >= (DateTime?) cDisplayClass46.dt1 && data.\u003C\u003Eh__TransparentIdentifier2e.r.CheckInTime <= (DateTime?) cDisplayClass46.dt2 && data.\u003C\u003Eh__TransparentIdentifier2e.r.CheckOutTime.HasValue).Select(data => new
      {
        ServiceID = data.\u003C\u003Eh__TransparentIdentifier2e.s.ServiceID,
        Name = data.u.Name,
        Number = data.\u003C\u003Eh__TransparentIdentifier2e.s.Number,
        Cost = data.\u003C\u003Eh__TransparentIdentifier2e.s.Cost
      }).GroupBy(r => new
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
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      dayInfo["STT"] = (object) number;
      dayInfo["Ngày"] = (object) string.Format("{0:d/M/yyyy}", (object) date);
      int num7 = 0;
      if (source1.Any())
      {
        foreach (var data in source1)
        {
          if (!data.Name.Equals(""))
          {
            DataRow dataRow;
            object[] objArray1 = new object[5]
            {
              (dataRow = dayInfo)["Dịch vụ"],
              (object) data.Name.ToString(),
              (object) " ",
              null,
              null
            };
            object[] objArray2 = objArray1;
            int? nullable = data.Number;
            string str1 = nullable.ToString();
            objArray2[3] = (object) str1;
            objArray1[4] = (object) ", ";
            string str2 = string.Concat(objArray1);
            dataRow["Dịch vụ"] = (object) str2;
            int num8 = num7;
            nullable = data.Cost;
            int num9 = nullable.Value * 1000;
            num7 = num8 + num9;
          }
        }
      }
      IQueryable<\u003C\u003Ef__AnonymousType22<int, string, int, int, int, int, int?, int?, int?, DateTime?>> source2 = queryable1;
      Expression<Func<\u003C\u003Ef__AnonymousType22<int, string, int, int, int, int, int?, int?, int?, DateTime?>, int>> keySelector = u => u.PurchaseID;
      using (IEnumerator<IGrouping<int, \u003C\u003Ef__AnonymousType22<int, string, int, int, int, int, int?, int?, int?, DateTime?>>> enumerator = source2.GroupBy(keySelector).GetEnumerator())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        BillManager.\u003C\u003Ec__DisplayClass48 cDisplayClass48 = new BillManager.\u003C\u003Ec__DisplayClass48();
        // ISSUE: reference to a compiler-generated field
        cDisplayClass48.CS\u0024\u003C\u003E8__locals47 = cDisplayClass46;
        while (enumerator.MoveNext())
        {
          // ISSUE: reference to a compiler-generated field
          cDisplayClass48.item = enumerator.Current;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          IQueryable<OutExpense> queryable2 = cDisplayClass46.db.OutExpense.Where<OutExpense>((Expression<Func<OutExpense, bool>>) (r => r.PurchaseID == cDisplayClass48.item.Select(u => u.PurchaseID).First<int>()));
          // ISSUE: reference to a compiler-generated field
          int? nullable1 = cDisplayClass48.item.Select(u => u.IsPaid).First<int?>();
          if ((nullable1.GetValueOrDefault() != 1 ? 0 : (nullable1.HasValue ? 1 : 0)) != 0)
          {
            // ISSUE: reference to a compiler-generated field
            DateTime dateTime2 = this.CheckLoanRoom(cDisplayClass48.item.Select(u => u.Loan).First<int?>().Value);
            // ISSUE: reference to a compiler-generated field
            DateTime? nullable2 = cDisplayClass48.item.Select(u => u.CheckOutTime).First<DateTime?>();
            if ((!nullable2.HasValue ? 0 : (dateTime2 == nullable2.GetValueOrDefault() ? 1 : 0)) != 0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass46.loanList.Add(cDisplayClass48.item.Select(u => u.Loan).First<int?>().Value);
              // ISSUE: reference to a compiler-generated field
              foreach (var data in cDisplayClass48.item)
              {
                if (!data.Service.Equals(":0"))
                  num1 += int.Parse(data.ServiceCost.ToString());
              }
              foreach (OutExpense outExpense in (IEnumerable<OutExpense>) queryable2)
                num1 += int.Parse(outExpense.Cost.ToString()) * 1000;
              // ISSUE: reference to a compiler-generated field
              num2 += int.Parse(cDisplayClass48.item.Select(u => u.PrePaid).First<int>().ToString());
              // ISSUE: reference to a compiler-generated field
              num3 += int.Parse(cDisplayClass48.item.Select(u => u.Bonus).First<int>().ToString());
              // ISSUE: reference to a compiler-generated field
              num4 += int.Parse(cDisplayClass48.item.Select(u => u.RoomCost).First<int>().ToString());
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            foreach (var data in cDisplayClass48.item)
            {
              if (!data.Service.Equals(":0"))
                num1 += int.Parse(data.ServiceCost.ToString());
            }
            foreach (OutExpense outExpense in (IEnumerable<OutExpense>) queryable2)
              num1 += int.Parse(outExpense.Cost.ToString()) * 1000;
            // ISSUE: reference to a compiler-generated field
            num2 += int.Parse(cDisplayClass48.item.Select(u => u.PrePaid).First<int>().ToString());
            // ISSUE: reference to a compiler-generated field
            num3 += int.Parse(cDisplayClass48.item.Select(u => u.Bonus).First<int>().ToString());
            // ISSUE: reference to a compiler-generated field
            num4 += int.Parse(cDisplayClass48.item.Select(u => u.RoomCost).First<int>().ToString());
          }
        }
      }
      // ISSUE: reference to a compiler-generated field
      cDisplayClass46.loanList.Distinct<int>().ToList<int>();
      int num10 = 0;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      BillManager.\u003C\u003Ec__DisplayClass4a cDisplayClass4a = new BillManager.\u003C\u003Ec__DisplayClass4a();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass4a.CS\u0024\u003C\u003E8__locals47 = cDisplayClass46;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      for (cDisplayClass4a.k = 0; cDisplayClass4a.k < cDisplayClass46.loanList.Count; ++cDisplayClass4a.k)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        IQueryable<IGrouping<\u003C\u003Ef__AnonymousType1e<int>, \u003C\u003Ef__AnonymousType1d<int, string, DateTime, DateTime, int?, int?, int?, int?>>> source3 = cDisplayClass46.db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (l => cDisplayClass46.db.ServicesPurchaseInfo), (l, s) => new
        {
          l = l,
          s = s
        }).Where(data => data.l.Loan == (int?) cDisplayClass46.loanList[cDisplayClass4a.k] && data.l.PurchaseID == data.s.PurchaseID).Select(data => new
        {
          PurchaseID = data.l.PurchaseID,
          RoomNo = data.l.RoomNo,
          ChecInTime = data.l.CheckInTime.Value,
          CheckOutTime = data.l.CheckOutTime.Value,
          RoomCost = data.l.Cost,
          ServiceCost = data.s.Cost,
          Prepaid = data.l.Repaid,
          Bonus = data.l.SerDiscount + data.l.RoomDiscount
        }).GroupBy(r => new{ PurchaseID = r.PurchaseID });
        Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType1e<int>, \u003C\u003Ef__AnonymousType1d<int, string, DateTime, DateTime, int?, int?, int?, int?>>, \u003C\u003Ef__AnonymousType1f<int, string, int?, DateTime, DateTime>>> selector = g => new
        {
          PurchaseID = g.Select(r => r.PurchaseID).First<int>(),
          RoomNo = g.Select(r => r.RoomNo).First<string>(),
          TotalCost = g.Sum(r => r.ServiceCost) + g.Select(r => r.RoomCost).First<int?>() + g.Select(r => r.Prepaid).First<int?>() - g.Select(r => r.Bonus).First<int?>(),
          CheckInTime = g.Select(r => r.ChecInTime).First<DateTime>(),
          CheckOutTime = g.Select(r => r.CheckOutTime).First<DateTime>()
        };
        using (IEnumerator<\u003C\u003Ef__AnonymousType1f<int, string, int?, DateTime, DateTime>> enumerator = source3.Select(selector).GetEnumerator())
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          BillManager.\u003C\u003Ec__DisplayClass4c cDisplayClass4c = new BillManager.\u003C\u003Ec__DisplayClass4c();
          // ISSUE: reference to a compiler-generated field
          cDisplayClass4c.CS\u0024\u003C\u003E8__locals4b = cDisplayClass4a;
          // ISSUE: reference to a compiler-generated field
          cDisplayClass4c.CS\u0024\u003C\u003E8__locals47 = cDisplayClass46;
          while (enumerator.MoveNext())
          {
            // ISSUE: reference to a compiler-generated field
            cDisplayClass4c.item = enumerator.Current;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass4c.item.CheckOutTime != this.CheckLoanRoom(cDisplayClass46.loanList[cDisplayClass4a.k]))
            {
              int num11 = 0;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              IQueryable<OutExpense> source4 = cDisplayClass46.db.OutExpense.SelectMany((Expression<Func<OutExpense, IEnumerable<RoomPurchaseInfo>>>) (r => cDisplayClass46.db.RoomPurchaseInfo), (r, s) => new
              {
                r = r,
                s = s
              }).Where(data => data.r.PurchaseID == data.s.PurchaseID && data.s.PurchaseID == cDisplayClass4c.item.PurchaseID).Select(data => data.r);
              if (source4.Any<OutExpense>())
              {
                foreach (OutExpense outExpense in (IEnumerable<OutExpense>) source4)
                  num11 += outExpense.Cost.Value;
              }
              // ISSUE: reference to a compiler-generated field
              num10 += (cDisplayClass4c.item.TotalCost.Value + num11) * 1000;
            }
          }
        }
      }
      dayInfo["Tiền DV"] = (object) string.Format("{0:0,0}", (object) num7);
      dayInfo["Tổng tiền"] = (object) string.Format("{0:0,0}", (object) (num4 + num1 + num2 - num3 + num10));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<Spending> source5 = cDisplayClass46.db.Spending.Where<Spending>((Expression<Func<Spending, bool>>) (o => o.SpendDate >= (DateTime?) cDisplayClass46.dt1 && o.SpendDate <= (DateTime?) cDisplayClass46.dt2));
      Expression<Func<Spending, \u003C\u003Ef__AnonymousType24<int?>>> selector1 = o => new
      {
        Cost = o.Cost * (int?) 1000
      };
      foreach (var data in source5.Select(selector1))
        num5 += data.Cost.Value;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      IQueryable<OutInCome> source6 = cDisplayClass46.db.OutInCome.Where<OutInCome>((Expression<Func<OutInCome, bool>>) (o => o.DateIncome == (DateTime?) cDisplayClass46.dt1.Date));
      Expression<Func<OutInCome, \u003C\u003Ef__AnonymousType24<int?>>> selector2 = o => new
      {
        Cost = o.Cost * (int?) 1000
      };
      foreach (var data in source6.Select(selector2))
        num6 += data.Cost.Value;
      dayInfo["Thu VAT"] = (object) string.Format("{0:0,0}", (object) num6);
      dayInfo["Chi"] = (object) string.Format("{0:0,0}", (object) num5);
      dayInfo["Thực thu"] = (object) string.Format("{0:0,0}", (object) (num4 + num1 + num2 - num3 + num6 - num5 + num10));
      // ISSUE: reference to a compiler-generated field
      cDisplayClass46.db.Connection.Close();
      return dayInfo;
    }

    private void grvBindDataByMonth(DateTime date)
    {
      this.grvBillManager.Columns.Clear();
      int num1 = date.AddMonths(1).Month;
      if (num1 == 1)
        num1 = 13;
      this.otherTB = new DataTable();
      this.otherTB.Columns.Add(new DataColumn("STT", typeof (int)));
      this.otherTB.Columns.Add(new DataColumn("Ngày", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Dịch vụ", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Tiền DV", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Tổng tiền", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Thu VAT", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Chi", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Thực thu", typeof (string)));
      int number = 1;
      for (; date.Month < num1 && !(date > DateTime.Now); date = date.AddDays(1.0))
      {
        this.otherTB.Rows.Add(this.getDayInfo(date, number));
        ++number;
      }
      this.grvBillManager.DataSource = (object) this.otherTB;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      for (int index = 0; index < this.grvBillManager.Rows.Count; ++index)
      {
        num2 += int.Parse(this.grvBillManager.Rows[index].Cells[4].Value.ToString(), NumberStyles.Currency);
        num4 += int.Parse(this.grvBillManager.Rows[index].Cells[5].Value.ToString(), NumberStyles.Currency);
        num3 += int.Parse(this.grvBillManager.Rows[index].Cells[6].Value.ToString(), NumberStyles.Currency);
        num5 += int.Parse(this.grvBillManager.Rows[index].Cells[7].Value.ToString(), NumberStyles.Currency);
      }
      this.lblCalcu.Text = "(" + string.Format("{0:0,0}", (object) num2) + " + " + string.Format("{0:0,0}", (object) num4) + ") - " + string.Format("{0:0,0}", (object) num3) + " = " + string.Format("{0:0,0}", (object) num5);
      this.label6.Text = "(Tổng thu + VAT) - Chi = Thực thu";
      this.groupBox3.Text = "Tháng " + (object) date.Month + " năm " + (object) date.Year;
    }

    private void grvBindDataByDay()
    {
      this.grvBillManager.Columns.Clear();
      this.otherTB = new DataTable();
      this.otherTB.Columns.Add(new DataColumn("STT", typeof (int)));
      this.otherTB.Columns.Add(new DataColumn("Ngày", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Dịch vụ", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Tiền DV", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Tổng tiền", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Thu VAT", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Chi", typeof (string)));
      this.otherTB.Columns.Add(new DataColumn("Thực thu", typeof (string)));
      int number = 1;
      DateTime date1 = this.dtpByDay.Value.Date;
      DateTime dateTime1;
      while (true)
      {
        DateTime dateTime2 = date1;
        dateTime1 = this.dtpTo.Value;
        DateTime date2 = dateTime1.Date;
        if (dateTime2 <= date2 && !(date1 > DateTime.Now))
        {
          this.otherTB.Rows.Add(this.getDayInfo(date1, number));
          ++number;
          date1 = date1.AddDays(1.0);
        }
        else
          break;
      }
      this.grvBillManager.DataSource = (object) this.otherTB;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      for (int index = 0; index < this.grvBillManager.Rows.Count; ++index)
      {
        num1 += int.Parse(this.grvBillManager.Rows[index].Cells[4].Value.ToString(), NumberStyles.Currency);
        num3 += int.Parse(this.grvBillManager.Rows[index].Cells[5].Value.ToString(), NumberStyles.Currency);
        num2 += int.Parse(this.grvBillManager.Rows[index].Cells[6].Value.ToString(), NumberStyles.Currency);
        num4 += int.Parse(this.grvBillManager.Rows[index].Cells[7].Value.ToString(), NumberStyles.Currency);
      }
      this.lblCalcu.Text = "(" + string.Format("{0:0,0}", (object) num1) + " + " + string.Format("{0:0,0}", (object) num3) + ") - " + string.Format("{0:0,0}", (object) num2) + " = " + string.Format("{0:0,0}", (object) num4);
      this.label6.Text = "(Tổng thu + VAT) - Chi = Thực thu";
      GroupBox groupBox3 = this.groupBox3;
      dateTime1 = this.dtpByDay.Value;
      string str1 = string.Format("{0:d/M/yyyy}", (object) dateTime1.Date);
      dateTime1 = this.dtpTo.Value;
      string str2 = string.Format("{0:d/M/yyyy}", (object) dateTime1.Date);
      string str3 = "Từ ngày " + str1 + " đến ngày " + str2;
      groupBox3.Text = str3;
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void btnPrint_Click(object sender, EventArgs e)
    {
      int day = this.dtpByDay.Value.Day;
      int month = this.dtpByDay.Value.Month;
      int year = this.dtpByDay.Value.Year;
      if (this.cmbType.SelectedIndex == 0)
        this.ConvertDGVtoExcel(0, day, month, year);
      else
        this.ConvertDGVtoExcel(0, 0, month, year);
    }

    private int getTotalCash(DateTime date) => 0;

    private void CashBookBindData()
    {
      if (this.cmbTypeCash.SelectedIndex == 0)
      {
        this.grvCashBook.CellPainting -= new DataGridViewCellPaintingEventHandler(this.grvCashBook_CellPainting);
        this.grvCashBook.ColumnWidthChanged -= new DataGridViewColumnEventHandler(this.grvCashBook_ColumnWidthChanged);
        this.grvCashBook.Scroll -= new ScrollEventHandler(this.grvCashBook_Scroll);
        this.grvCashBook.Paint -= new PaintEventHandler(this.grvCashBook_Paint);
      }
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("PurchaseID", typeof (int));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("Date", typeof (string));
      dataTable.Columns.Add(column2);
      DataColumn column3 = new DataColumn("Detail", typeof (string));
      dataTable.Columns.Add(column3);
      DataColumn column4 = new DataColumn("Recieve", typeof (string));
      dataTable.Columns.Add(column4);
      DataColumn column5 = new DataColumn("Expense", typeof (string));
      dataTable.Columns.Add(column5);
      DataColumn column6 = new DataColumn("Cash", typeof (string));
      dataTable.Columns.Add(column6);
      DataColumn column7 = new DataColumn("Note", typeof (string));
      dataTable.Columns.Add(column7);
      dataTable.Columns[0].ColumnMapping = MappingType.Hidden;
      int num = 0;
      num = this.getTotalCash(this.dtpCashBook.Value);
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (rpi => db.ServicesPurchaseInfo), (rpi, spi) => new
      {
        rpi = rpi,
        spi = spi
      }).SelectMany(data => db.Services, (data, s) => new
      {
        \u003C\u003Eh__TransparentIdentifier4e = data,
        s = s
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier4e.rpi.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier4e.spi.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier4e.spi.ServiceID == (int?) data.s.ServiceID && data.\u003C\u003Eh__TransparentIdentifier4e.rpi.CheckOutTime.HasValue && data.\u003C\u003Eh__TransparentIdentifier4e.rpi.CheckInTime.Value.Date <= this.dtpCashBook.Value.Date).Select(data => new
      {
        PurchaseID = data.\u003C\u003Eh__TransparentIdentifier4e.spi.PurchaseID,
        CheckInTime = data.\u003C\u003Eh__TransparentIdentifier4e.rpi.CheckInTime,
        CheckOutTime = data.\u003C\u003Eh__TransparentIdentifier4e.rpi.CheckOutTime,
        RoomNo = data.\u003C\u003Eh__TransparentIdentifier4e.rpi.RoomNo,
        Service = data.s.Name.ToString() + ":" + data.\u003C\u003Eh__TransparentIdentifier4e.spi.Number.ToString(),
        PrePaid = (int) data.\u003C\u003Eh__TransparentIdentifier4e.rpi.Repaid * 1000,
        RoomCost = (int) data.\u003C\u003Eh__TransparentIdentifier4e.rpi.Cost * 1000,
        ServiceCost = (int) data.\u003C\u003Eh__TransparentIdentifier4e.spi.Cost * 1000,
        Bonus = ((int) data.\u003C\u003Eh__TransparentIdentifier4e.rpi.RoomDiscount + (int) data.\u003C\u003Eh__TransparentIdentifier4e.rpi.SerDiscount) * 1000,
        Note = data.\u003C\u003Eh__TransparentIdentifier4e.rpi.Note,
        Loan = data.\u003C\u003Eh__TransparentIdentifier4e.rpi.Loan,
        UserID = data.\u003C\u003Eh__TransparentIdentifier4e.rpi.UserID
      }).GroupBy(r => new{ PurchaseID = r.PurchaseID }).Select(g => new
      {
        Key = g.Key,
        SerCost = g.Sum(r => r.ServiceCost)
      });
    }

    private void ConvertDGVtoExcel(int type, int day, int month, int year)
    {
      try
      {
        string str1;
        string str2;
        if (day == 0)
        {
          if (this.cmbType.SelectedIndex == 1)
          {
            str1 = "Hóa đơn tháng " + month.ToString() + " năm " + year.ToString();
            str2 = "Hoa_don_thang_" + month.ToString() + "_nam_" + year.ToString();
          }
          else
          {
            str1 = "Hóa đơn từ " + string.Format("{0:d/M/yyyy}", (object) this.dtpByDay.Value.Date) + " đến " + string.Format("{0:d/M/yyyy}", (object) this.dtpTo.Value.Date);
            str2 = "Tu_" + string.Format("{0:d_M_yyyy}", (object) this.dtpByDay.Value.Date) + "_den_" + string.Format("{0:d_M_yyyy}", (object) this.dtpTo.Value.Date);
          }
        }
        else
        {
          str1 = "Hóa đơn ngày " + day.ToString() + " tháng " + month.ToString() + " năm " + year.ToString();
          str2 = "Hoa_don_" + day.ToString() + "_" + month.ToString() + "_" + year.ToString();
        }
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
        if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site53 == null)
        {
          // ISSUE: reference to a compiler-generated field
          BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site53 = CallSite<Func<CallSite, object, _Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof (_Worksheet), typeof (BillManager)));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        worksheet1 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site53.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site53, workbook.Sheets[(object) "Sheet1"]);
        // ISSUE: reference to a compiler-generated field
        if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site54 == null)
        {
          // ISSUE: reference to a compiler-generated field
          BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site54 = CallSite<Func<CallSite, object, _Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof (_Worksheet), typeof (BillManager)));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: variable of a compiler-generated type
        _Worksheet worksheet2 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site54.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site54, workbook.ActiveSheet);
        worksheet2.PageSetup.PaperSize = XlPaperSize.xlPaperA4;
        worksheet2.PageSetup.Orientation = XlPageOrientation.xlLandscape;
        // ISSUE: reference to a compiler-generated method
        worksheet2.PageSetup.LeftMargin = instance.Application.InchesToPoints(0.0);
        // ISSUE: reference to a compiler-generated method
        worksheet2.PageSetup.RightMargin = instance.Application.InchesToPoints(0.0);
        // ISSUE: reference to a compiler-generated method
        worksheet2.PageSetup.TopMargin = instance.Application.InchesToPoints(0.0);
        // ISSUE: reference to a compiler-generated method
        worksheet2.PageSetup.BottomMargin = instance.Application.InchesToPoints(0.0);
        if (this.cmbType.SelectedIndex == 0)
        {
          worksheet2.Cells[(object) 1, (object) 5] = (object) str1.ToString();
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site55 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site55 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj1 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site55.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site55, worksheet2.Columns[(object) "A", System.Type.Missing], 3);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site56 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site56 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj2 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site56.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site56, worksheet2.Columns[(object) "B", System.Type.Missing], 8);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site57 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site57 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj3 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site57.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site57, worksheet2.Columns[(object) "C", System.Type.Missing], 15);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site58 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site58 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj4 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site58.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site58, worksheet2.Columns[(object) "D", System.Type.Missing], 15);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site59 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site59 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj5 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site59.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site59, worksheet2.Columns[(object) "E", System.Type.Missing], 40);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5a == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5a = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj6 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5a.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5a, worksheet2.Columns[(object) "F", System.Type.Missing], 10);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5b == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5b = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj7 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5b.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5b, worksheet2.Columns[(object) "G", System.Type.Missing], 10);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5c == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5c = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj8 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5c.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5c, worksheet2.Columns[(object) "H", System.Type.Missing], 8);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5d == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5d = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj9 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5d.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5d, worksheet2.Columns[(object) "I", System.Type.Missing], 9);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5e == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5e = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj10 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5e.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5e, worksheet2.Columns[(object) "J", System.Type.Missing], 10);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5f == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5f = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj11 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5f.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site5f, worksheet2.Columns[(object) "K", System.Type.Missing], 7);
        }
        else
        {
          worksheet2.Cells[(object) 1, (object) 3] = (object) str1.ToString();
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site60 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site60 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj12 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site60.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site60, worksheet2.Columns[(object) "A", System.Type.Missing], 3);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site61 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site61 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj13 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site61.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site61, worksheet2.Columns[(object) "B", System.Type.Missing], 9);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site62 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site62 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj14 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site62.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site62, worksheet2.Columns[(object) "C", System.Type.Missing], 80);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site63 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site63 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj15 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site63.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site63, worksheet2.Columns[(object) "D", System.Type.Missing], 9);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site64 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site64 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj16 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site64.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site64, worksheet2.Columns[(object) "E", System.Type.Missing], 9);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site65 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site65 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj17 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site65.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site65, worksheet2.Columns[(object) "F", System.Type.Missing], 9);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site66 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site66 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj18 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site66.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site66, worksheet2.Columns[(object) "G", System.Type.Missing], 9);
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site67 == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site67 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj19 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site67.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site67, worksheet2.Columns[(object) "H", System.Type.Missing], 9);
        }
        worksheet2.Name = str2.ToString();
        worksheet2.Columns.HorizontalAlignment = (object) XlHAlign.xlHAlignLeft;
        for (int index = 0; index < this.grvBillManager.Columns.Count; ++index)
          worksheet2.Cells[(object) 2, (object) (index + 1)] = (object) this.grvBillManager.Columns[index].HeaderText;
        // ISSUE: reference to a compiler-generated field
        if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site68 == null)
        {
          // ISSUE: reference to a compiler-generated field
          BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site68 = CallSite<Func<CallSite, object, XlBorderWeight, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Weight", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, XlBorderWeight, object> target1 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site68.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, XlBorderWeight, object>> pSite68 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site68;
        // ISSUE: reference to a compiler-generated field
        if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site69 == null)
        {
          // ISSUE: reference to a compiler-generated field
          BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site69 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Borders", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj20 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site69.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site69, worksheet2.Rows[(object) 2, System.Type.Missing]);
        object obj21 = target1((CallSite) pSite68, obj20, XlBorderWeight.xlMedium);
        for (int index1 = 0; index1 < this.grvBillManager.Rows.Count; ++index1)
        {
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site6a == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site6a = CallSite<Func<CallSite, object, XlBorderWeight, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Weight", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, XlBorderWeight, object> target2 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site6a.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, XlBorderWeight, object>> pSite6a = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site6a;
          // ISSUE: reference to a compiler-generated field
          if (BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site6b == null)
          {
            // ISSUE: reference to a compiler-generated field
            BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site6b = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Borders", typeof (BillManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj22 = BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site6b.Target((CallSite) BillManager.\u003CConvertDGVtoExcel\u003Eo__SiteContainer52.\u003C\u003Ep__Site6b, worksheet2.Rows[(object) (index1 + 3), System.Type.Missing]);
          object obj23 = target2((CallSite) pSite6a, obj22, XlBorderWeight.xlMedium);
          for (int index2 = 0; index2 < this.grvBillManager.Columns.Count; ++index2)
            worksheet2.Cells[(object) (index1 + 3), (object) (index2 + 1)] = this.grvBillManager.Rows[index1].Cells[index2].Value;
        }
        if (type == 1)
        {
          this.saveFileDialog1.Filter = "Execl files (*.xls)|*.xls";
          this.saveFileDialog1.FilterIndex = 0;
          this.saveFileDialog1.RestoreDirectory = true;
          this.saveFileDialog1.CreatePrompt = true;
          this.saveFileDialog1.Title = "Lưu thành tệp Excel";
          this.saveFileDialog1.FileName = str2.ToString();
          // ISSUE: reference to a compiler-generated method
          instance.ActiveWorkbook.SaveCopyAs((object) this.saveFileDialog1.ShowDialog());
          FileInfo fileInfo = new FileInfo(this.saveFileDialog1.FileName);
          instance.DisplayAlerts = false;
          // ISSUE: reference to a compiler-generated method
          instance.ActiveWorkbook.SaveAs((object) (fileInfo.DirectoryName + fileInfo.Name), (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, ConflictResolution: ((object) Missing.Value), AddToMru: ((object) Missing.Value), TextCodepage: ((object) Missing.Value), TextVisualLayout: ((object) Missing.Value), Local: ((object) Missing.Value));
          instance.ActiveWorkbook.Saved = true;
          // ISSUE: reference to a compiler-generated method
          instance.Workbooks.Close();
          // ISSUE: reference to a compiler-generated method
          instance.Quit();
        }
        else
        {
          instance.Visible = true;
          // ISSUE: reference to a compiler-generated method
          workbook.PrintPreview((object) true);
          instance.ActiveWorkbook.Saved = true;
          // ISSUE: reference to a compiler-generated method
          instance.Workbooks.Close();
          // ISSUE: reference to a compiler-generated method
          instance.Quit();
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message.ToString());
        return;
      }
      GC.Collect();
      GC.WaitForPendingFinalizers();
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      int day = this.dtpByDay.Value.Day;
      int month = this.dtpByDay.Value.Month;
      int year = this.dtpByDay.Value.Year;
      if (this.cmbType.SelectedIndex == 0)
        this.ConvertDGVtoExcel(1, day, month, year);
      else
        this.ConvertDGVtoExcel(1, 0, month, year);
    }

    private void cmbType_SelectionChangeCommitted(object sender, EventArgs e)
    {
      int userid = int.Parse(this.cmbReciever.SelectedValue.ToString());
      if (this.cmbType.SelectedIndex == 0)
      {
        this.cmbReciever.Enabled = true;
        this.label3.Text = "Ngày";
        this.label2.Visible = false;
        this.dtpTo.Visible = false;
        this.dtpByDay.CustomFormat = "dd/MM/yyyy";
        this.dtpByDay.Format = DateTimePickerFormat.Custom;
        this.grvBindData(this.dtpByDay.Value.Date, userid);
      }
      else if (this.cmbType.SelectedIndex == 1)
      {
        this.cmbReciever.Enabled = false;
        DateTime date = new DateTime(this.dtpByDay.Value.Year, this.dtpByDay.Value.Month, 1, 5, 0, 0);
        this.label3.Text = "Tháng";
        this.label2.Visible = true;
        this.dtpTo.Visible = false;
        this.label2.Text = "Chọn bất kỳ một ngày trong tháng";
        this.dtpByDay.CustomFormat = "MM/yyyy";
        this.dtpByDay.Format = DateTimePickerFormat.Custom;
        this.grvBindDataByMonth(date);
      }
      else
      {
        this.cmbReciever.Enabled = false;
        this.label3.Text = "Từ ngày";
        this.label2.Visible = true;
        this.dtpTo.Visible = true;
        this.label2.Text = "Đến ngày";
        this.dtpByDay.CustomFormat = "dd/MM/yyyy";
        this.dtpByDay.Format = DateTimePickerFormat.Custom;
        this.dtpTo.CustomFormat = "dd/MM/yyyy";
        this.dtpTo.Format = DateTimePickerFormat.Custom;
        this.grvBindDataByDay();
      }
    }

    private void dtpByDay_ValueChanged(object sender, EventArgs e)
    {
      int userid = int.Parse(this.cmbReciever.SelectedValue.ToString());
      DateTime date1 = this.dtpByDay.Value.Date;
      if (this.cmbType.SelectedIndex == 0)
        this.grvBindData(date1, userid);
      else if (this.cmbType.SelectedIndex == 1)
      {
        DateTime date2 = new DateTime(date1.Year, date1.Month, 1, 5, 0, 0);
        this.label3.Text = "Tháng";
        this.label2.Visible = true;
        this.dtpTo.Visible = false;
        this.label2.Text = "Chọn bất kỳ một ngày trong tháng";
        this.dtpByDay.CustomFormat = "MM/yyyy";
        this.dtpByDay.Format = DateTimePickerFormat.Custom;
        this.grvBindDataByMonth(date2);
      }
      else
        this.grvBindDataByDay();
    }

    private void BillManager_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    private void dtpTo_ValueChanged(object sender, EventArgs e) => this.grvBindDataByDay();

    private DateTime CheckLoanRoom(int loanID)
    {
      DateTime dateTime = new DateTime(1990, 8, 30, 0, 0, 0);
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int max = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (s => s.Loan == (int?) loanID)).Max<RoomPurchaseInfo, int>((Expression<Func<RoomPurchaseInfo, int>>) (x => x.PurchaseID));
      RoomPurchaseInfo roomPurchaseInfo = ((IEnumerable<RoomPurchaseInfo>) smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (u => u.PurchaseID == max)).ToArray<RoomPurchaseInfo>()).Single<RoomPurchaseInfo>();
      return roomPurchaseInfo.CheckOutTime.HasValue ? roomPurchaseInfo.CheckOutTime.Value : dateTime;
    }

    private void cmbReciever_SelectionChangeCommitted(object sender, EventArgs e) => this.grvBindData(this.dtpByDay.Value.Date, int.Parse(this.cmbReciever.SelectedValue.ToString()));

    private void grvCashBook_Paint(object sender, PaintEventArgs e)
    {
      Rectangle rectangle = new Rectangle();
      Rectangle displayRectangle = this.grvCashBook.GetCellDisplayRectangle(2, -1, true);
      for (int index = 2; index < 3; ++index)
      {
        int width = this.grvCashBook.GetCellDisplayRectangle(index + 1, -1, true).Width;
        displayRectangle.Width += width;
      }
      ++displayRectangle.X;
      ++displayRectangle.Y;
      displayRectangle.Width -= 2;
      displayRectangle.Height = displayRectangle.Height / 2 - 2;
      e.Graphics.FillRectangle((Brush) new SolidBrush(this.grvCashBook.ColumnHeadersDefaultCellStyle.BackColor), displayRectangle);
      e.Graphics.DrawLine(new Pen(this.grvCashBook.GridColor, 1f), displayRectangle.X, displayRectangle.Bottom, displayRectangle.X + displayRectangle.Width, displayRectangle.Bottom);
      e.Graphics.DrawString("Thu", this.grvCashBook.ColumnHeadersDefaultCellStyle.Font, (Brush) new SolidBrush(this.grvCashBook.ColumnHeadersDefaultCellStyle.ForeColor), (RectangleF) displayRectangle, new StringFormat()
      {
        Alignment = StringAlignment.Center,
        LineAlignment = StringAlignment.Center
      });
    }

    private void grvCashBook_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e) => this.grvCashBook.Invalidate(this.grvCashBook.DisplayRectangle with
    {
      Height = this.grvCashBook.ColumnHeadersHeight / 2
    });

    private void grvCashBook_Scroll(object sender, ScrollEventArgs e) => this.grvCashBook.Invalidate(this.grvCashBook.DisplayRectangle with
    {
      Height = this.grvCashBook.ColumnHeadersHeight / 2
    });

    private void grvCashBook_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      if (e.RowIndex != -1 || e.ColumnIndex <= -1)
        return;
      Rectangle cellBounds1 = e.CellBounds;
      ref Rectangle local1 = ref cellBounds1;
      int y = local1.Y;
      Rectangle cellBounds2 = e.CellBounds;
      int num1 = cellBounds2.Height / 2;
      local1.Y = y + num1;
      ref Rectangle local2 = ref cellBounds1;
      cellBounds2 = e.CellBounds;
      int num2 = cellBounds2.Height / 2;
      local2.Height = num2;
      e.PaintBackground(cellBounds1, true);
      e.PaintContent(cellBounds1);
      e.Handled = true;
    }

    private void BillManager_Load(object sender, EventArgs e)
    {
      this.cmbTypeCash.SelectedIndex = 0;
      this.CashBookBindData();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BillManager));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      this.btnPrint = new Button();
      this.btnCancel = new Button();
      this.saveFileDialog1 = new SaveFileDialog();
      this.btnExport = new Button();
      this.groupBox3 = new GroupBox();
      this.lblCalcu = new Label();
      this.label6 = new Label();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.groupBox4 = new GroupBox();
      this.cmbReciever = new ComboBox();
      this.groupBox2 = new GroupBox();
      this.grvBillManager = new DataGridView();
      this.groupBox1 = new GroupBox();
      this.dtpTo = new DateTimePicker();
      this.label2 = new Label();
      this.label3 = new Label();
      this.dtpByDay = new DateTimePicker();
      this.label1 = new Label();
      this.cmbType = new ComboBox();
      this.tabPage2 = new TabPage();
      this.dtpCashBook = new DateTimePicker();
      this.groupBox5 = new GroupBox();
      this.grvCashBook = new DataGridView();
      this.tabPage3 = new TabPage();
      this.dataGridView1 = new DataGridView();
      this.progressBar1 = new ProgressBar();
      this.cmbTypeCash = new ComboBox();
      this.groupBox3.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.grvBillManager).BeginInit();
      this.groupBox1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox5.SuspendLayout();
      ((ISupportInitialize) this.grvCashBook).BeginInit();
      this.tabPage3.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.btnPrint, "btnPrint");
      this.btnPrint.BackColor = SystemColors.GradientInactiveCaption;
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.UseVisualStyleBackColor = false;
      this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
      componentResourceManager.ApplyResources((object) this.btnCancel, "btnCancel");
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      componentResourceManager.ApplyResources((object) this.btnExport, "btnExport");
      this.btnExport.BackColor = SystemColors.GradientInactiveCaption;
      this.btnExport.Name = "btnExport";
      this.btnExport.UseVisualStyleBackColor = false;
      this.btnExport.Click += new EventHandler(this.btnExport_Click);
      componentResourceManager.ApplyResources((object) this.groupBox3, "groupBox3");
      this.groupBox3.Controls.Add((Control) this.lblCalcu);
      this.groupBox3.Controls.Add((Control) this.label6);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.TabStop = false;
      componentResourceManager.ApplyResources((object) this.lblCalcu, "lblCalcu");
      this.lblCalcu.Name = "lblCalcu";
      componentResourceManager.ApplyResources((object) this.label6, "label6");
      this.label6.Name = "label6";
      componentResourceManager.ApplyResources((object) this.tabControl1, "tabControl1");
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabPage1.BackColor = SystemColors.GradientInactiveCaption;
      this.tabPage1.Controls.Add((Control) this.groupBox4);
      this.tabPage1.Controls.Add((Control) this.groupBox2);
      this.tabPage1.Controls.Add((Control) this.groupBox1);
      componentResourceManager.ApplyResources((object) this.tabPage1, "tabPage1");
      this.tabPage1.Name = "tabPage1";
      this.groupBox4.Controls.Add((Control) this.cmbReciever);
      componentResourceManager.ApplyResources((object) this.groupBox4, "groupBox4");
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.TabStop = false;
      this.cmbReciever.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmbReciever, "cmbReciever");
      this.cmbReciever.FormattingEnabled = true;
      this.cmbReciever.Items.AddRange(new object[1]
      {
        (object) componentResourceManager.GetString("cmbReciever.Items")
      });
      this.cmbReciever.Name = "cmbReciever";
      this.cmbReciever.SelectionChangeCommitted += new EventHandler(this.cmbReciever_SelectionChangeCommitted);
      componentResourceManager.ApplyResources((object) this.groupBox2, "groupBox2");
      this.groupBox2.Controls.Add((Control) this.grvBillManager);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.TabStop = false;
      this.grvBillManager.AllowUserToAddRows = false;
      this.grvBillManager.AllowUserToDeleteRows = false;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.grvBillManager.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      componentResourceManager.ApplyResources((object) this.grvBillManager, "grvBillManager");
      this.grvBillManager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.grvBillManager.BackgroundColor = SystemColors.ButtonHighlight;
      this.grvBillManager.BorderStyle = BorderStyle.None;
      this.grvBillManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvBillManager.Name = "grvBillManager";
      this.grvBillManager.ReadOnly = true;
      this.grvBillManager.RowHeadersVisible = false;
      this.grvBillManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.groupBox1.Controls.Add((Control) this.dtpTo);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.dtpByDay);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Controls.Add((Control) this.cmbType);
      componentResourceManager.ApplyResources((object) this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      componentResourceManager.ApplyResources((object) this.dtpTo, "dtpTo");
      this.dtpTo.Name = "dtpTo";
      this.dtpTo.ValueChanged += new EventHandler(this.dtpTo_ValueChanged);
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.dtpByDay, "dtpByDay");
      this.dtpByDay.Format = DateTimePickerFormat.Custom;
      this.dtpByDay.Name = "dtpByDay";
      this.dtpByDay.ValueChanged += new EventHandler(this.dtpByDay_ValueChanged);
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmbType, "cmbType");
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Items.AddRange(new object[3]
      {
        (object) componentResourceManager.GetString("cmbType.Items"),
        (object) componentResourceManager.GetString("cmbType.Items1"),
        (object) componentResourceManager.GetString("cmbType.Items2")
      });
      this.cmbType.Name = "cmbType";
      this.cmbType.SelectionChangeCommitted += new EventHandler(this.cmbType_SelectionChangeCommitted);
      this.tabPage2.BackColor = SystemColors.GradientInactiveCaption;
      this.tabPage2.Controls.Add((Control) this.cmbTypeCash);
      this.tabPage2.Controls.Add((Control) this.dtpCashBook);
      this.tabPage2.Controls.Add((Control) this.groupBox5);
      componentResourceManager.ApplyResources((object) this.tabPage2, "tabPage2");
      this.tabPage2.Name = "tabPage2";
      componentResourceManager.ApplyResources((object) this.dtpCashBook, "dtpCashBook");
      this.dtpCashBook.Format = DateTimePickerFormat.Short;
      this.dtpCashBook.Name = "dtpCashBook";
      componentResourceManager.ApplyResources((object) this.groupBox5, "groupBox5");
      this.groupBox5.Controls.Add((Control) this.grvCashBook);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.TabStop = false;
      this.grvCashBook.AllowUserToAddRows = false;
      this.grvCashBook.AllowUserToDeleteRows = false;
      gridViewCellStyle2.BackColor = Color.White;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.grvCashBook.AlternatingRowsDefaultCellStyle = gridViewCellStyle2;
      componentResourceManager.ApplyResources((object) this.grvCashBook, "grvCashBook");
      this.grvCashBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.grvCashBook.BackgroundColor = SystemColors.ButtonHighlight;
      this.grvCashBook.BorderStyle = BorderStyle.None;
      this.grvCashBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.BottomCenter;
      gridViewCellStyle3.BackColor = Color.White;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      gridViewCellStyle3.ForeColor = SystemColors.InactiveCaptionText;
      gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
      this.grvCashBook.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
      this.grvCashBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.grvCashBook.GridColor = SystemColors.ActiveBorder;
      this.grvCashBook.MultiSelect = false;
      this.grvCashBook.Name = "grvCashBook";
      this.grvCashBook.ReadOnly = true;
      this.grvCashBook.RowHeadersVisible = false;
      this.grvCashBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvCashBook.CellPainting += new DataGridViewCellPaintingEventHandler(this.grvCashBook_CellPainting);
      this.grvCashBook.ColumnWidthChanged += new DataGridViewColumnEventHandler(this.grvCashBook_ColumnWidthChanged);
      this.grvCashBook.Scroll += new ScrollEventHandler(this.grvCashBook_Scroll);
      this.grvCashBook.Paint += new PaintEventHandler(this.grvCashBook_Paint);
      this.tabPage3.Controls.Add((Control) this.dataGridView1);
      componentResourceManager.ApplyResources((object) this.tabPage3, "tabPage3");
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
      this.dataGridView1.AlternatingRowsDefaultCellStyle = gridViewCellStyle4;
      componentResourceManager.ApplyResources((object) this.dataGridView1, "dataGridView1");
      this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
      this.dataGridView1.BorderStyle = BorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      componentResourceManager.ApplyResources((object) this.progressBar1, "progressBar1");
      this.progressBar1.Name = "progressBar1";
      this.cmbTypeCash.DropDownStyle = ComboBoxStyle.DropDownList;
      componentResourceManager.ApplyResources((object) this.cmbTypeCash, "cmbTypeCash");
      this.cmbTypeCash.FormattingEnabled = true;
      this.cmbTypeCash.Items.AddRange(new object[2]
      {
        (object) componentResourceManager.GetString("cmbTypeCash.Items"),
        (object) componentResourceManager.GetString("cmbTypeCash.Items1")
      });
      this.cmbTypeCash.Name = "cmbTypeCash";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.Controls.Add((Control) this.progressBar1);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.btnExport);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnPrint);
      this.Name = nameof (BillManager);
      this.FormClosing += new FormClosingEventHandler(this.BillManager_FormClosing);
      this.Load += new EventHandler(this.BillManager_Load);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      ((ISupportInitialize) this.grvBillManager).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      ((ISupportInitialize) this.grvCashBook).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
