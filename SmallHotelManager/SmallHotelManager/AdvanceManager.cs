// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AdvanceManager
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class AdvanceManager : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private DataGridView grvRoomCost;
    private DataGridViewTextBoxColumn Detail;
    private DataGridViewTextBoxColumn Cosy;
    private GroupBox groupBox2;
    private DataGridView grvServicesCost;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private GroupBox groupBox3;
    private DataGridView grvSpending;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private GroupBox groupBox4;
    private DataGridView grvOutIncome;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private GroupBox groupBox5;
    private ComboBox cmbType;
    private Label label1;
    private Label label2;
    private Label lblOutIncome;
    private Label label11;
    private Label lblSpending;
    private Label label9;
    private Label lblServicesCost;
    private Label label7;
    private Label lblRoomCost;
    private Label label4;
    private Label label3;
    private DateTimePicker dtpDate;
    private Button button1;

    public AdvanceManager() => this.InitializeComponent();

    private void AdvanceManager_Load(object sender, EventArgs e)
    {
      this.dtpDate.CustomFormat = "MM/yyyy";
      this.dtpDate.Format = DateTimePickerFormat.Custom;
      this.cmbType.SelectedIndex = 0;
      this.BindDataByMonth();
    }

    private void BindDataByMonth()
    {
      DateTime date = this.dtpDate.Value;
      DataTable dataTable1 = new DataTable();
      DataColumn column1 = new DataColumn("Detail", typeof (string));
      dataTable1.Columns.Add(column1);
      DataColumn column2 = new DataColumn("Cost", typeof (string));
      dataTable1.Columns.Add(column2);
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType3a<DateTime, int?>> source1 = db.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.CheckOutTime.Value.Month == date.Month && r.CheckOutTime.Value.Year == date.Year && r.Loan == (int?) 0)).Select(r => new
      {
        CheckOutTime = r.CheckOutTime.Value.Date,
        Cost = r.Cost
      }).GroupBy(r => new{ CheckOutTime = r.CheckOutTime }).Select(g => new
      {
        CheckOutTime = g.Key.CheckOutTime,
        Cost = g.Sum(r => r.Cost)
      });
      foreach (var data in source1)
      {
        Debug.WriteLine("hehe  " + (object) source1.Count());
        DataRow row = dataTable1.NewRow();
        row["Detail"] = (object) string.Format("{0:d/M/yyyy}", (object) data.CheckOutTime);
        DataRow dataRow = row;
        int? cost = data.Cost;
        string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
        dataRow["Cost"] = (object) str;
        dataTable1.Rows.Add(row);
        int num5 = num1;
        cost = data.Cost;
        int num6 = cost.Value * 1000;
        num1 = num5 + num6;
      }
      this.lblRoomCost.Text = string.Format("{0:0,0}", (object) num1);
      this.grvRoomCost.DataSource = (object) dataTable1;
      DataTable dataTable2 = new DataTable();
      DataColumn column3 = new DataColumn("Detail", typeof (string));
      dataTable2.Columns.Add(column3);
      DataColumn column4 = new DataColumn("Cost", typeof (string));
      dataTable2.Columns.Add(column4);
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>> source2 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).SelectMany(data => db.Services, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifier0 = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier0.r.CheckOutTime.Value.Month == date.Month && data.\u003C\u003Eh__TransparentIdentifier0.r.CheckOutTime.Value.Year == date.Year && data.\u003C\u003Eh__TransparentIdentifier0.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier0.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier0.s.ServiceID == (int?) data.u.ServiceID && data.\u003C\u003Eh__TransparentIdentifier0.r.Loan == (int?) 0).Select(data => new
      {
        ServiceID = data.\u003C\u003Eh__TransparentIdentifier0.s.ServiceID,
        Name = data.u.Name,
        Number = data.\u003C\u003Eh__TransparentIdentifier0.s.Number,
        Cost = data.\u003C\u003Eh__TransparentIdentifier0.s.Cost
      }).GroupBy(r => new
      {
        ServiceID = r.ServiceID,
        Name = r.Name
      });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>, \u003C\u003Ef__AnonymousType8<int?, string, int?, int?>>> selector1 = g => new
      {
        ServiceID = g.Key.ServiceID,
        Name = g.Key.Name,
        Cost = g.Sum(r => r.Cost),
        Number = g.Sum(r => r.Number)
      };
      foreach (var data in source2.Select(selector1))
      {
        if (data.Name != "")
        {
          DataRow row = dataTable2.NewRow();
          row["Detail"] = (object) ("    " + data.Name + "  " + (object) data.Number);
          DataRow dataRow = row;
          int? cost = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Cost"] = (object) str;
          dataTable2.Rows.Add(row);
          num2 += data.Cost.Value * 1000;
        }
      }
      this.lblServicesCost.Text = string.Format("{0:0,0}", (object) num2);
      this.grvServicesCost.DataSource = (object) dataTable2;
      DataTable dataTable3 = new DataTable();
      DataColumn column5 = new DataColumn("Detail", typeof (string));
      dataTable3.Columns.Add(column5);
      DataColumn column6 = new DataColumn("Cost", typeof (string));
      dataTable3.Columns.Add(column6);
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType3e<DateTime>, \u003C\u003Ef__AnonymousType3d<DateTime, int?>>> source3 = db.Spending.Where<Spending>((Expression<Func<Spending, bool>>) (r => r.SpendDate.Value.Month == date.Month && r.SpendDate.Value.Year == date.Year)).Select(r => new
      {
        SpendDate = r.SpendDate.Value.Date,
        Cost = r.Cost
      }).GroupBy(r => new{ SpendDate = r.SpendDate });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType3e<DateTime>, \u003C\u003Ef__AnonymousType3d<DateTime, int?>>, \u003C\u003Ef__AnonymousType3d<DateTime, int?>>> selector2 = g => new
      {
        SpendDate = g.Key.SpendDate,
        Cost = g.Sum(r => r.Cost)
      };
      foreach (var data in source3.Select(selector2))
      {
        DataRow row = dataTable3.NewRow();
        row["Detail"] = (object) string.Format("{0:d/M/yyyy}", (object) data.SpendDate);
        DataRow dataRow = row;
        int? cost = data.Cost;
        string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
        dataRow["Cost"] = (object) str;
        dataTable3.Rows.Add(row);
        num3 += data.Cost.Value * 1000;
      }
      this.lblSpending.Text = string.Format("{0:0,0}", (object) num3);
      this.grvSpending.DataSource = (object) dataTable3;
      DataTable dataTable4 = new DataTable();
      DataColumn column7 = new DataColumn("Detail", typeof (string));
      dataTable4.Columns.Add(column7);
      DataColumn column8 = new DataColumn("Cost", typeof (string));
      dataTable4.Columns.Add(column8);
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType40<DateTime>, \u003C\u003Ef__AnonymousType3f<DateTime, int?>>> source4 = db.OutInCome.Where<OutInCome>((Expression<Func<OutInCome, bool>>) (r => r.DateIncome.Value.Month == date.Month && r.DateIncome.Value.Year == date.Year)).Select(r => new
      {
        DateIncome = r.DateIncome.Value.Date,
        Cost = r.Cost
      }).GroupBy(r => new{ DateIncome = r.DateIncome });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType40<DateTime>, \u003C\u003Ef__AnonymousType3f<DateTime, int?>>, \u003C\u003Ef__AnonymousType3f<DateTime, int?>>> selector3 = g => new
      {
        DateIncome = g.Key.DateIncome,
        Cost = g.Sum(r => r.Cost)
      };
      foreach (var data in source4.Select(selector3))
      {
        DataRow row = dataTable4.NewRow();
        row["Detail"] = (object) string.Format("{0:d/M/yyyy}", (object) data.DateIncome);
        DataRow dataRow = row;
        int? cost = data.Cost;
        string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
        dataRow["Cost"] = (object) str;
        dataTable4.Rows.Add(row);
        num4 += data.Cost.Value * 1000;
      }
      this.lblOutIncome.Text = string.Format("{0:0,0}", (object) num4);
      this.grvOutIncome.DataSource = (object) dataTable4;
    }

    private void BindDataByYear()
    {
      DateTime date = this.dtpDate.Value;
      DataTable dataTable1 = new DataTable();
      DataColumn column1 = new DataColumn("Detail", typeof (string));
      dataTable1.Columns.Add(column1);
      DataColumn column2 = new DataColumn("Cost", typeof (string));
      dataTable1.Columns.Add(column2);
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType42<int, int?>> source1 = db.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.CheckOutTime.Value.Year == date.Year && r.Loan == (int?) 0)).Select(r => new
      {
        CheckOutTime = r.CheckOutTime.Value.Date,
        Cost = r.Cost
      }).GroupBy(r => new{ Month = r.CheckOutTime.Month }).Select(g => new
      {
        Month = g.Key.Month,
        Cost = g.Sum(r => r.Cost)
      });
      foreach (var data in source1)
      {
        Debug.WriteLine("hehe  " + (object) source1.Count());
        DataRow row = dataTable1.NewRow();
        row["Detail"] = (object) (data.Month.ToString() + "/" + (object) date.Year);
        DataRow dataRow = row;
        int? cost = data.Cost;
        string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
        dataRow["Cost"] = (object) str;
        dataTable1.Rows.Add(row);
        int num5 = num1;
        cost = data.Cost;
        int num6 = cost.Value * 1000;
        num1 = num5 + num6;
      }
      this.lblRoomCost.Text = string.Format("{0:0,0}", (object) num1);
      this.grvRoomCost.DataSource = (object) dataTable1;
      DataTable dataTable2 = new DataTable();
      DataColumn column3 = new DataColumn("Detail", typeof (string));
      dataTable2.Columns.Add(column3);
      DataColumn column4 = new DataColumn("Cost", typeof (string));
      dataTable2.Columns.Add(column4);
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>> source2 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).SelectMany(data => db.Services, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifier4 = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier4.r.CheckOutTime.Value.Year == date.Year && data.\u003C\u003Eh__TransparentIdentifier4.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier4.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier4.s.ServiceID == (int?) data.u.ServiceID && data.\u003C\u003Eh__TransparentIdentifier4.r.Loan == (int?) 0).Select(data => new
      {
        ServiceID = data.\u003C\u003Eh__TransparentIdentifier4.s.ServiceID,
        Name = data.u.Name,
        Number = data.\u003C\u003Eh__TransparentIdentifier4.s.Number,
        Cost = data.\u003C\u003Eh__TransparentIdentifier4.s.Cost
      }).GroupBy(r => new
      {
        ServiceID = r.ServiceID,
        Name = r.Name
      });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>, \u003C\u003Ef__AnonymousType8<int?, string, int?, int?>>> selector1 = g => new
      {
        ServiceID = g.Key.ServiceID,
        Name = g.Key.Name,
        Cost = g.Sum(r => r.Cost),
        Number = g.Sum(r => r.Number)
      };
      foreach (var data in source2.Select(selector1))
      {
        if (data.Name != "")
        {
          DataRow row = dataTable2.NewRow();
          row["Detail"] = (object) ("    " + data.Name + "  " + (object) data.Number);
          DataRow dataRow = row;
          int? cost = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Cost"] = (object) str;
          dataTable2.Rows.Add(row);
          num2 += data.Cost.Value * 1000;
        }
      }
      this.lblServicesCost.Text = string.Format("{0:0,0}", (object) num2);
      this.grvServicesCost.DataSource = (object) dataTable2;
      DataTable dataTable3 = new DataTable();
      DataColumn column5 = new DataColumn("Detail", typeof (string));
      dataTable3.Columns.Add(column5);
      DataColumn column6 = new DataColumn("Cost", typeof (string));
      dataTable3.Columns.Add(column6);
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType3e<DateTime>, \u003C\u003Ef__AnonymousType3d<DateTime, int?>>> source3 = db.Spending.Where<Spending>((Expression<Func<Spending, bool>>) (r => r.SpendDate.Value.Year == date.Year)).Select(r => new
      {
        SpendDate = r.SpendDate.Value.Date,
        Cost = r.Cost
      }).GroupBy(r => new{ SpendDate = r.SpendDate });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType3e<DateTime>, \u003C\u003Ef__AnonymousType3d<DateTime, int?>>, \u003C\u003Ef__AnonymousType3d<DateTime, int?>>> selector2 = g => new
      {
        SpendDate = g.Key.SpendDate,
        Cost = g.Sum(r => r.Cost)
      };
      foreach (var data in source3.Select(selector2))
      {
        DataRow row = dataTable3.NewRow();
        row["Detail"] = (object) string.Format("{0:M/yyyy}", (object) data.SpendDate);
        DataRow dataRow = row;
        int? cost = data.Cost;
        string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
        dataRow["Cost"] = (object) str;
        dataTable3.Rows.Add(row);
        num3 += data.Cost.Value * 1000;
      }
      this.lblSpending.Text = string.Format("{0:0,0}", (object) num3);
      this.grvSpending.DataSource = (object) dataTable3;
      DataTable dataTable4 = new DataTable();
      DataColumn column7 = new DataColumn("Detail", typeof (string));
      dataTable4.Columns.Add(column7);
      DataColumn column8 = new DataColumn("Cost", typeof (string));
      dataTable4.Columns.Add(column8);
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType40<DateTime>, \u003C\u003Ef__AnonymousType3f<DateTime, int?>>> source4 = db.OutInCome.Where<OutInCome>((Expression<Func<OutInCome, bool>>) (r => r.DateIncome.Value.Year == date.Year)).Select(r => new
      {
        DateIncome = r.DateIncome.Value.Date,
        Cost = r.Cost
      }).GroupBy(r => new{ DateIncome = r.DateIncome });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType40<DateTime>, \u003C\u003Ef__AnonymousType3f<DateTime, int?>>, \u003C\u003Ef__AnonymousType3f<DateTime, int?>>> selector3 = g => new
      {
        DateIncome = g.Key.DateIncome,
        Cost = g.Sum(r => r.Cost)
      };
      foreach (var data in source4.Select(selector3))
      {
        DataRow row = dataTable4.NewRow();
        row["Detail"] = (object) string.Format("{0:M/yyyy}", (object) data.DateIncome);
        DataRow dataRow = row;
        int? cost = data.Cost;
        string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
        dataRow["Cost"] = (object) str;
        dataTable4.Rows.Add(row);
        num4 += data.Cost.Value * 1000;
      }
      this.lblOutIncome.Text = string.Format("{0:0,0}", (object) num4);
      this.grvOutIncome.DataSource = (object) dataTable4;
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void AdvanceManager_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    private void cmbType_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (this.cmbType.SelectedIndex == 0)
      {
        this.dtpDate.CustomFormat = "MM/yyyy";
        this.dtpDate.Format = DateTimePickerFormat.Custom;
        this.label3.Text = "(Chọn bất kỳ một ngày trong tháng)";
        this.BindDataByMonth();
      }
      else
      {
        this.dtpDate.CustomFormat = "yyyy";
        this.dtpDate.Format = DateTimePickerFormat.Custom;
        this.label3.Text = "(Chọn bất kỳ một ngày trong năm)";
        this.BindDataByYear();
      }
    }

    private void dtpDate_ValueChanged(object sender, EventArgs e)
    {
      if (this.cmbType.SelectedIndex == 0)
      {
        this.dtpDate.CustomFormat = "MM/yyyy";
        this.dtpDate.Format = DateTimePickerFormat.Custom;
        this.label3.Text = "(Chọn bất kỳ một ngày trong tháng)";
        this.BindDataByMonth();
      }
      else
      {
        this.dtpDate.CustomFormat = "yyyy";
        this.dtpDate.Format = DateTimePickerFormat.Custom;
        this.label3.Text = "(Chọn bất kỳ một ngày trong năm)";
        this.BindDataByYear();
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
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AdvanceManager));
      this.groupBox1 = new GroupBox();
      this.grvRoomCost = new DataGridView();
      this.Detail = new DataGridViewTextBoxColumn();
      this.Cosy = new DataGridViewTextBoxColumn();
      this.groupBox2 = new GroupBox();
      this.grvServicesCost = new DataGridView();
      this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.groupBox3 = new GroupBox();
      this.grvSpending = new DataGridView();
      this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.groupBox4 = new GroupBox();
      this.grvOutIncome = new DataGridView();
      this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
      this.groupBox5 = new GroupBox();
      this.lblOutIncome = new Label();
      this.label11 = new Label();
      this.lblSpending = new Label();
      this.label9 = new Label();
      this.lblServicesCost = new Label();
      this.label7 = new Label();
      this.lblRoomCost = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.dtpDate = new DateTimePicker();
      this.label2 = new Label();
      this.cmbType = new ComboBox();
      this.label1 = new Label();
      this.button1 = new Button();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.grvRoomCost).BeginInit();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.grvServicesCost).BeginInit();
      this.groupBox3.SuspendLayout();
      ((ISupportInitialize) this.grvSpending).BeginInit();
      this.groupBox4.SuspendLayout();
      ((ISupportInitialize) this.grvOutIncome).BeginInit();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.grvRoomCost);
      this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.Location = new Point(2, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(279, 323);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tiền phòng";
      this.grvRoomCost.AllowUserToAddRows = false;
      this.grvRoomCost.AllowUserToDeleteRows = false;
      this.grvRoomCost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.grvRoomCost.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.grvRoomCost.BackgroundColor = SystemColors.ControlLightLight;
      this.grvRoomCost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvRoomCost.ColumnHeadersVisible = false;
      this.grvRoomCost.Columns.AddRange((DataGridViewColumn) this.Detail, (DataGridViewColumn) this.Cosy);
      this.grvRoomCost.Dock = DockStyle.Fill;
      this.grvRoomCost.GridColor = SystemColors.ControlLightLight;
      this.grvRoomCost.Location = new Point(3, 18);
      this.grvRoomCost.Margin = new Padding(4);
      this.grvRoomCost.MultiSelect = false;
      this.grvRoomCost.Name = "grvRoomCost";
      this.grvRoomCost.ReadOnly = true;
      this.grvRoomCost.RowHeadersVisible = false;
      this.grvRoomCost.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvRoomCost.Size = new Size(273, 302);
      this.grvRoomCost.TabIndex = 2;
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
      this.groupBox2.Controls.Add((Control) this.grvServicesCost);
      this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.Location = new Point(296, 2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(279, 323);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Tiền dịch vụ";
      this.grvServicesCost.AllowUserToAddRows = false;
      this.grvServicesCost.AllowUserToDeleteRows = false;
      this.grvServicesCost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.grvServicesCost.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.grvServicesCost.BackgroundColor = SystemColors.ControlLightLight;
      this.grvServicesCost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvServicesCost.ColumnHeadersVisible = false;
      this.grvServicesCost.Columns.AddRange((DataGridViewColumn) this.dataGridViewTextBoxColumn1, (DataGridViewColumn) this.dataGridViewTextBoxColumn2);
      this.grvServicesCost.Dock = DockStyle.Fill;
      this.grvServicesCost.GridColor = SystemColors.ControlLightLight;
      this.grvServicesCost.Location = new Point(3, 18);
      this.grvServicesCost.Margin = new Padding(4);
      this.grvServicesCost.MultiSelect = false;
      this.grvServicesCost.Name = "grvServicesCost";
      this.grvServicesCost.ReadOnly = true;
      this.grvServicesCost.RowHeadersVisible = false;
      this.grvServicesCost.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvServicesCost.Size = new Size(273, 302);
      this.grvServicesCost.TabIndex = 2;
      this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Detail";
      gridViewCellStyle3.SelectionBackColor = Color.White;
      gridViewCellStyle3.SelectionForeColor = Color.Black;
      this.dataGridViewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle3;
      this.dataGridViewTextBoxColumn1.HeaderText = "Detail";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Cost";
      gridViewCellStyle4.SelectionBackColor = Color.White;
      gridViewCellStyle4.SelectionForeColor = Color.Black;
      this.dataGridViewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle4;
      this.dataGridViewTextBoxColumn2.HeaderText = "Cost";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn2.Width = 5;
      this.groupBox3.Controls.Add((Control) this.grvSpending);
      this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox3.Location = new Point(2, 331);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(279, 323);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Tiền chi phí";
      this.grvSpending.AllowUserToAddRows = false;
      this.grvSpending.AllowUserToDeleteRows = false;
      this.grvSpending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.grvSpending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.grvSpending.BackgroundColor = SystemColors.ControlLightLight;
      this.grvSpending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvSpending.ColumnHeadersVisible = false;
      this.grvSpending.Columns.AddRange((DataGridViewColumn) this.dataGridViewTextBoxColumn3, (DataGridViewColumn) this.dataGridViewTextBoxColumn4);
      this.grvSpending.Dock = DockStyle.Fill;
      this.grvSpending.GridColor = SystemColors.ControlLightLight;
      this.grvSpending.Location = new Point(3, 18);
      this.grvSpending.Margin = new Padding(4);
      this.grvSpending.MultiSelect = false;
      this.grvSpending.Name = "grvSpending";
      this.grvSpending.ReadOnly = true;
      this.grvSpending.RowHeadersVisible = false;
      this.grvSpending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvSpending.Size = new Size(273, 302);
      this.grvSpending.TabIndex = 2;
      this.dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Detail";
      gridViewCellStyle5.SelectionBackColor = Color.White;
      gridViewCellStyle5.SelectionForeColor = Color.Black;
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle5;
      this.dataGridViewTextBoxColumn3.HeaderText = "Detail";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost";
      gridViewCellStyle6.SelectionBackColor = Color.White;
      gridViewCellStyle6.SelectionForeColor = Color.Black;
      this.dataGridViewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle6;
      this.dataGridViewTextBoxColumn4.HeaderText = "Cost";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn4.Width = 5;
      this.groupBox4.Controls.Add((Control) this.grvOutIncome);
      this.groupBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox4.Location = new Point(296, 331);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(279, 323);
      this.groupBox4.TabIndex = 3;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Tiền thu VAT";
      this.grvOutIncome.AllowUserToAddRows = false;
      this.grvOutIncome.AllowUserToDeleteRows = false;
      this.grvOutIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.grvOutIncome.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.grvOutIncome.BackgroundColor = SystemColors.ControlLightLight;
      this.grvOutIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvOutIncome.ColumnHeadersVisible = false;
      this.grvOutIncome.Columns.AddRange((DataGridViewColumn) this.dataGridViewTextBoxColumn5, (DataGridViewColumn) this.dataGridViewTextBoxColumn6);
      this.grvOutIncome.Dock = DockStyle.Fill;
      this.grvOutIncome.GridColor = SystemColors.ControlLightLight;
      this.grvOutIncome.Location = new Point(3, 18);
      this.grvOutIncome.Margin = new Padding(4);
      this.grvOutIncome.MultiSelect = false;
      this.grvOutIncome.Name = "grvOutIncome";
      this.grvOutIncome.ReadOnly = true;
      this.grvOutIncome.RowHeadersVisible = false;
      this.grvOutIncome.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvOutIncome.Size = new Size(273, 302);
      this.grvOutIncome.TabIndex = 2;
      this.dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Detail";
      gridViewCellStyle7.SelectionBackColor = Color.White;
      gridViewCellStyle7.SelectionForeColor = Color.Black;
      this.dataGridViewTextBoxColumn5.DefaultCellStyle = gridViewCellStyle7;
      this.dataGridViewTextBoxColumn5.HeaderText = "Detail";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.dataGridViewTextBoxColumn6.DataPropertyName = "Cost";
      gridViewCellStyle8.SelectionBackColor = Color.White;
      gridViewCellStyle8.SelectionForeColor = Color.Black;
      this.dataGridViewTextBoxColumn6.DefaultCellStyle = gridViewCellStyle8;
      this.dataGridViewTextBoxColumn6.HeaderText = "Cost";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn6.Width = 5;
      this.groupBox5.Controls.Add((Control) this.lblOutIncome);
      this.groupBox5.Controls.Add((Control) this.label11);
      this.groupBox5.Controls.Add((Control) this.lblSpending);
      this.groupBox5.Controls.Add((Control) this.label9);
      this.groupBox5.Controls.Add((Control) this.lblServicesCost);
      this.groupBox5.Controls.Add((Control) this.label7);
      this.groupBox5.Controls.Add((Control) this.lblRoomCost);
      this.groupBox5.Controls.Add((Control) this.label4);
      this.groupBox5.Controls.Add((Control) this.label3);
      this.groupBox5.Controls.Add((Control) this.dtpDate);
      this.groupBox5.Controls.Add((Control) this.label2);
      this.groupBox5.Controls.Add((Control) this.cmbType);
      this.groupBox5.Controls.Add((Control) this.label1);
      this.groupBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox5.Location = new Point(581, 2);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(236, 212);
      this.groupBox5.TabIndex = 4;
      this.groupBox5.TabStop = false;
      this.lblOutIncome.AutoSize = true;
      this.lblOutIncome.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblOutIncome.Location = new Point(116, 179);
      this.lblOutIncome.Name = "lblOutIncome";
      this.lblOutIncome.Size = new Size(0, 16);
      this.lblOutIncome.TabIndex = 12;
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(9, 179);
      this.label11.Name = "label11";
      this.label11.Size = new Size(101, 16);
      this.label11.TabIndex = 11;
      this.label11.Text = "Tiền thu VAT:";
      this.lblSpending.AutoSize = true;
      this.lblSpending.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblSpending.Location = new Point(116, 153);
      this.lblSpending.Name = "lblSpending";
      this.lblSpending.Size = new Size(0, 16);
      this.lblSpending.TabIndex = 10;
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(9, 153);
      this.label9.Name = "label9";
      this.label9.Size = new Size(92, 16);
      this.label9.TabIndex = 9;
      this.label9.Text = "Tiền chi phí:";
      this.lblServicesCost.AutoSize = true;
      this.lblServicesCost.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblServicesCost.Location = new Point(116, 128);
      this.lblServicesCost.Name = "lblServicesCost";
      this.lblServicesCost.Size = new Size(0, 16);
      this.lblServicesCost.TabIndex = 8;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(9, 128);
      this.label7.Name = "label7";
      this.label7.Size = new Size(96, 16);
      this.label7.TabIndex = 7;
      this.label7.Text = "Tiền dịch vụ:";
      this.lblRoomCost.AutoSize = true;
      this.lblRoomCost.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblRoomCost.Location = new Point(116, 103);
      this.lblRoomCost.Name = "lblRoomCost";
      this.lblRoomCost.Size = new Size(0, 16);
      this.lblRoomCost.TabIndex = 6;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(9, 103);
      this.label4.Name = "label4";
      this.label4.Size = new Size(90, 16);
      this.label4.TabIndex = 5;
      this.label4.Text = "Tiền phòng:";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(14, 74);
      this.label3.Name = "label3";
      this.label3.Size = new Size(213, 16);
      this.label3.TabIndex = 4;
      this.label3.Text = "(Chọn bất kỳ một ngày trong tháng)";
      this.dtpDate.Format = DateTimePickerFormat.Custom;
      this.dtpDate.Location = new Point(60, 49);
      this.dtpDate.Name = "dtpDate";
      this.dtpDate.Size = new Size(170, 22);
      this.dtpDate.TabIndex = 3;
      this.dtpDate.ValueChanged += new EventHandler(this.dtpDate_ValueChanged);
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(6, 54);
      this.label2.Name = "label2";
      this.label2.Size = new Size(47, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Chọn:";
      this.cmbType.BackColor = SystemColors.GradientInactiveCaption;
      this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Items.AddRange(new object[2]
      {
        (object) "Tháng",
        (object) "Năm"
      });
      this.cmbType.Location = new Point(119, 15);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new Size(111, 24);
      this.cmbType.TabIndex = 1;
      this.cmbType.SelectionChangeCommitted += new EventHandler(this.cmbType_SelectionChangeCommitted);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(6, 18);
      this.label1.Name = "label1";
      this.label1.Size = new Size(107, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Thống kê theo";
      this.button1.BackColor = SystemColors.GradientInactiveCaption;
      this.button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(581, 606);
      this.button1.Name = "button1";
      this.button1.Size = new Size(236, 48);
      this.button1.TabIndex = 5;
      this.button1.Text = "Thoát";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(820, 657);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox5);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(836, 695);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(836, 695);
      this.Name = nameof (AdvanceManager);
      this.Text = "Quản lý nâng cao";
      this.FormClosing += new FormClosingEventHandler(this.AdvanceManager_FormClosing);
      this.Load += new EventHandler(this.AdvanceManager_Load);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.grvRoomCost).EndInit();
      this.groupBox2.ResumeLayout(false);
      ((ISupportInitialize) this.grvServicesCost).EndInit();
      this.groupBox3.ResumeLayout(false);
      ((ISupportInitialize) this.grvSpending).EndInit();
      this.groupBox4.ResumeLayout(false);
      ((ISupportInitialize) this.grvOutIncome).EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
