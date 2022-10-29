// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.ServicesManager
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class ServicesManager : Form
  {
    private Main _parent;
    private int _userID;
    private AddNewService rm = (AddNewService) null;
    private StoreTrans st = (StoreTrans) null;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private DataGridView grvServices;
    private Button btnDel;
    private Button btnExit;
    private Button btnEdit;
    private Button btnAdd;
    private GroupBox groupBox2;
    private DataGridView dataGridView1;
    private DateTimePicker dtpTo;
    private Label lblTo;
    private DateTimePicker dtpFrom;
    private Label lblFrom;
    private Label label2;
    private ComboBox cmbList;
    private Label label1;
    private Button button1;
    private DataGridViewTextBoxColumn ServiceID;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Price;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column4;

    public int UserID
    {
      get => this._userID;
      set => this._userID = value;
    }

    public ServicesManager(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
      this.GrvGetData();
      this._userID = parent.USERID;
      this.cmbList.SelectedIndex = 0;
      this.lblFrom.Text = "Ngày";
      this.lblTo.Visible = false;
      this.lblTo.Visible = false;
      this.dtpTo.Visible = false;
      this.dtpFrom.CustomFormat = "dd/MM/yyyy";
      this.dtpFrom.Format = DateTimePickerFormat.Custom;
      this.grvBindDataByOneDay();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      int num = (int) new AddNewService(this).ShowDialog();
    }

    public void FormRefresh() => this.GrvGetData();

    private void GrvGetData()
    {
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.grvServices.DataSource = (object) db.Services.SelectMany((Expression<Func<Services, IEnumerable<Users>>>) (s => db.Users), (s, p) => new
      {
        s = s,
        p = p
      }).Where(data => data.s.DelID == new int?() && data.s.ServiceID != 1 && data.s.UserID == (int?) data.p.UserID).Select(data => new
      {
        ServiceID = data.s.ServiceID,
        ServiceName = data.s.Name,
        Price = string.Format("{0:0,0}", (object) (data.s.Price * (int?) 1000)),
        TotalNumber = data.s.TotalNumber,
        StoreNumber = data.s.StoreNum,
        LastImport = string.Format("{0:d/M/y hh:mm}", (object) data.s.LastImport),
        NameOfUser = data.p.Name
      });
      db.Connection.Close();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (this.rm != null && !this.rm.IsDisposed || this.grvServices.RowCount <= 0)
        return;
      int num1 = int.Parse(this.grvServices.Rows[this.grvServices.CurrentCell.RowIndex].Cells[0].Value.ToString());
      this.rm = new AddNewService(this);
      this.rm.MdiParent = this.MdiParent;
      this.rm.ServiceID = num1;
      int num2 = (int) this.rm.ShowDialog();
    }

    private void btnExit_Click(object sender, EventArgs e) => this.Close();

    private void ServicesManager_FormClosing(object sender, FormClosingEventArgs e)
    {
      this._parent.listServiceData();
      this.Dispose();
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
      if (this.grvServices.RowCount <= 0 || MessageBox.Show("Bạn có chắc muốn xóa Dịch vụ này?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.Edition(int.Parse(this.grvServices.Rows[this.grvServices.CurrentCell.RowIndex].Cells[0].Value.ToString()), 1);
      this.FormRefresh();
    }

    private void Edition(int serviceID, int delID)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      delID = 1;
      serviceID = int.Parse(this.grvServices.Rows[this.grvServices.CurrentCell.RowIndex].Cells[0].Value.ToString());
      try
      {
        smallHotelManager.Services.Single<Services>((Expression<Func<Services, bool>>) (p => p.ServiceID == serviceID)).DelID = new int?(delID);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    public void grvBindDataByMonth()
    {
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("STT", typeof (int));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("Dịch vụ", typeof (string));
      dataTable.Columns.Add(column2);
      DataColumn column3 = new DataColumn("Số lượng", typeof (string));
      dataTable.Columns.Add(column3);
      DataColumn column4 = new DataColumn("Giá", typeof (string));
      dataTable.Columns.Add(column4);
      int num1 = 0;
      int num2 = 1;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>> source = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).SelectMany(data => db.Services, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifier5 = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier5.r.CheckOutTime.Value.Date.Month == this.dtpFrom.Value.Date.Month && data.\u003C\u003Eh__TransparentIdentifier5.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier5.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier5.s.ServiceID == (int?) data.u.ServiceID).Select(data => new
      {
        ServiceID = data.\u003C\u003Eh__TransparentIdentifier5.s.ServiceID,
        Name = data.u.Name,
        Number = data.\u003C\u003Eh__TransparentIdentifier5.s.Number,
        Cost = data.\u003C\u003Eh__TransparentIdentifier5.s.Cost
      }).GroupBy(r => new
      {
        ServiceID = r.ServiceID,
        Name = r.Name
      });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>, \u003C\u003Ef__AnonymousType8<int?, string, int?, int?>>> selector = g => new
      {
        ServiceID = g.Key.ServiceID,
        Name = g.Key.Name,
        Cost = g.Sum(r => r.Cost),
        Number = g.Sum(r => r.Number)
      };
      foreach (var data in source.Select(selector))
      {
        if (data.Name != "")
        {
          DataRow row = dataTable.NewRow();
          row["STT"] = (object) num2;
          row["Dịch vụ"] = (object) data.Name;
          row["Số lượng"] = (object) data.Number;
          DataRow dataRow = row;
          int? cost = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Giá"] = (object) str;
          ++num2;
          dataTable.Rows.Add(row);
        }
      }
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        if (dataTable.Rows[index]["Giá"].ToString() != "")
          num1 += int.Parse(dataTable.Rows[index]["Giá"].ToString(), NumberStyles.Currency);
      }
      DataRow row1 = dataTable.NewRow();
      row1["Số lượng"] = (object) "Tổng:";
      row1["Giá"] = (object) string.Format("{0:0,0}", (object) num1);
      dataTable.Rows.Add(row1);
      this.dataGridView1.DataSource = (object) dataTable;
    }

    public void grvBindDataByOneDay()
    {
      DateTime dateTime1 = this.dtpFrom.Value;
      DateTime dateTime2 = dateTime1.AddDays(1.0);
      DateTime dt1 = new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day, 5, 0, 0);
      DateTime dt2 = new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day, 5, 0, 0);
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("STT", typeof (int));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("Dịch vụ", typeof (string));
      dataTable.Columns.Add(column2);
      DataColumn column3 = new DataColumn("Số lượng", typeof (string));
      dataTable.Columns.Add(column3);
      DataColumn column4 = new DataColumn("Giá", typeof (string));
      dataTable.Columns.Add(column4);
      int num1 = 0;
      int num2 = 1;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>> source = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).SelectMany(data => db.Services, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifier9 = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier9.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifier9.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifier9.s.ServiceID == (int?) data.u.ServiceID && data.\u003C\u003Eh__TransparentIdentifier9.r.CheckInTime >= (DateTime?) dt1 && data.\u003C\u003Eh__TransparentIdentifier9.r.CheckInTime <= (DateTime?) dt2 && data.\u003C\u003Eh__TransparentIdentifier9.r.CheckOutTime.HasValue).Select(data => new
      {
        ServiceID = data.\u003C\u003Eh__TransparentIdentifier9.s.ServiceID,
        Name = data.u.Name,
        Number = data.\u003C\u003Eh__TransparentIdentifier9.s.Number,
        Cost = data.\u003C\u003Eh__TransparentIdentifier9.s.Cost
      }).GroupBy(r => new
      {
        ServiceID = r.ServiceID,
        Name = r.Name
      });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>, \u003C\u003Ef__AnonymousType8<int?, string, int?, int?>>> selector = g => new
      {
        ServiceID = g.Key.ServiceID,
        Name = g.Key.Name,
        Cost = g.Sum(r => r.Cost),
        Number = g.Sum(r => r.Number)
      };
      foreach (var data in source.Select(selector))
      {
        if (data.Name != "")
        {
          DataRow row = dataTable.NewRow();
          row["STT"] = (object) num2;
          row["Dịch vụ"] = (object) data.Name;
          row["Số lượng"] = (object) data.Number;
          DataRow dataRow = row;
          int? cost = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Giá"] = (object) str;
          ++num2;
          dataTable.Rows.Add(row);
        }
      }
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        if (dataTable.Rows[index]["Giá"].ToString() != "")
          num1 += int.Parse(dataTable.Rows[index]["Giá"].ToString(), NumberStyles.Currency);
      }
      if (num1 > 0)
      {
        DataRow row = dataTable.NewRow();
        row["Số lượng"] = (object) "Tổng:";
        row["Giá"] = (object) string.Format("{0:0,0}", (object) num1);
        dataTable.Rows.Add(row);
      }
      this.dataGridView1.DataSource = (object) dataTable;
    }

    public void grvBindDataByDay()
    {
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("STT", typeof (int));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("Dịch vụ", typeof (string));
      dataTable.Columns.Add(column2);
      DataColumn column3 = new DataColumn("Số lượng", typeof (string));
      dataTable.Columns.Add(column3);
      DataColumn column4 = new DataColumn("Giá", typeof (string));
      dataTable.Columns.Add(column4);
      int num1 = 0;
      int num2 = 1;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>> source = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).SelectMany(data => db.Services, (data, u) => new
      {
        \u003C\u003Eh__TransparentIdentifierd = data,
        u = u
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifierd.r.CheckOutTime.Value.Date.Day >= this.dtpFrom.Value.Date.Day && data.\u003C\u003Eh__TransparentIdentifierd.r.CheckOutTime.Value.Date.Day <= this.dtpTo.Value.Date.Day && data.\u003C\u003Eh__TransparentIdentifierd.r.PurchaseID == data.\u003C\u003Eh__TransparentIdentifierd.s.PurchaseID && data.\u003C\u003Eh__TransparentIdentifierd.s.ServiceID == (int?) data.u.ServiceID).Select(data => new
      {
        ServiceID = data.\u003C\u003Eh__TransparentIdentifierd.s.ServiceID,
        Name = data.u.Name,
        Number = data.\u003C\u003Eh__TransparentIdentifierd.s.Number,
        Cost = data.\u003C\u003Eh__TransparentIdentifierd.s.Cost
      }).GroupBy(r => new
      {
        ServiceID = r.ServiceID,
        Name = r.Name
      });
      Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType7<int?, string>, \u003C\u003Ef__AnonymousType6<int?, string, int?, int?>>, \u003C\u003Ef__AnonymousType8<int?, string, int?, int?>>> selector = g => new
      {
        ServiceID = g.Key.ServiceID,
        Name = g.Key.Name,
        Cost = g.Sum(r => r.Cost),
        Number = g.Sum(r => r.Number)
      };
      foreach (var data in source.Select(selector))
      {
        if (data.Name != "")
        {
          DataRow row = dataTable.NewRow();
          row["STT"] = (object) num2;
          row["Dịch vụ"] = (object) data.Name;
          row["Số lượng"] = (object) data.Number;
          DataRow dataRow = row;
          int? cost = data.Cost;
          string str = string.Format("{0:0,0}", (object) (cost.HasValue ? new int?(cost.GetValueOrDefault() * 1000) : new int?()));
          dataRow["Giá"] = (object) str;
          ++num2;
          dataTable.Rows.Add(row);
        }
      }
      for (int index = 0; index < dataTable.Rows.Count; ++index)
      {
        if (dataTable.Rows[index]["Giá"].ToString() != "")
          num1 += int.Parse(dataTable.Rows[index]["Giá"].ToString(), NumberStyles.Currency);
      }
      if (num1 > 0)
      {
        DataRow row = dataTable.NewRow();
        row["Số lượng"] = (object) "Tổng:";
        row["Giá"] = (object) string.Format("{0:0,0}", (object) num1);
        dataTable.Rows.Add(row);
      }
      this.dataGridView1.DataSource = (object) dataTable;
    }

    private void cmbList_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (this.cmbList.SelectedIndex == 1)
      {
        this.lblFrom.Text = "Tháng";
        this.lblTo.Visible = true;
        this.lblTo.Text = "Chọn 1 ngày bất kỳ trong tháng";
        this.dtpTo.Visible = false;
        this.dtpFrom.CustomFormat = "MM/yyyy";
        this.dtpFrom.Format = DateTimePickerFormat.Custom;
        this.grvBindDataByMonth();
      }
      else if (this.cmbList.SelectedIndex == 2)
      {
        this.lblFrom.Text = "Từ ngày";
        this.lblTo.Text = "Đến ngày";
        this.lblTo.Visible = true;
        this.dtpTo.Visible = true;
        this.dtpFrom.CustomFormat = "dd/MM/yyyy";
        this.dtpFrom.Format = DateTimePickerFormat.Custom;
        this.dtpTo.CustomFormat = "dd/MM/yyyy";
        this.dtpTo.Format = DateTimePickerFormat.Custom;
        this.grvBindDataByDay();
      }
      else
      {
        this.lblFrom.Text = "Ngày";
        this.lblTo.Visible = false;
        this.lblTo.Visible = false;
        this.dtpTo.Visible = false;
        this.dtpFrom.CustomFormat = "dd/MM/yyyy";
        this.dtpFrom.Format = DateTimePickerFormat.Custom;
        this.grvBindDataByOneDay();
      }
    }

    private void dtpFrom_ValueChanged(object sender, EventArgs e)
    {
      if (this.cmbList.SelectedIndex == 1)
        this.grvBindDataByMonth();
      else if (this.cmbList.SelectedIndex == 2)
        this.grvBindDataByDay();
      else
        this.grvBindDataByOneDay();
    }

    private void dtpTo_ValueChanged(object sender, EventArgs e)
    {
      if (this.cmbList.SelectedIndex == 1)
        this.grvBindDataByMonth();
      else if (this.cmbList.SelectedIndex == 2)
        this.grvBindDataByDay();
      else
        this.grvBindDataByOneDay();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.st != null && !this.st.IsDisposed || this.grvServices.RowCount <= 0)
        return;
      this.st = new StoreTrans();
      int num = (int) this.st.ShowDialog();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ServicesManager));
      this.groupBox1 = new GroupBox();
      this.grvServices = new DataGridView();
      this.ServiceID = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Price = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.btnDel = new Button();
      this.btnExit = new Button();
      this.btnEdit = new Button();
      this.btnAdd = new Button();
      this.groupBox2 = new GroupBox();
      this.dataGridView1 = new DataGridView();
      this.dtpTo = new DateTimePicker();
      this.lblTo = new Label();
      this.dtpFrom = new DateTimePicker();
      this.lblFrom = new Label();
      this.label2 = new Label();
      this.cmbList = new ComboBox();
      this.label1 = new Label();
      this.button1 = new Button();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.grvServices).BeginInit();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.grvServices);
      this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.Location = new Point(4, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(539, 340);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.grvServices.AllowUserToAddRows = false;
      this.grvServices.AllowUserToDeleteRows = false;
      this.grvServices.BackgroundColor = SystemColors.ControlLightLight;
      this.grvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvServices.Columns.AddRange((DataGridViewColumn) this.ServiceID, (DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Price, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column4);
      this.grvServices.Location = new Point(6, 10);
      this.grvServices.Name = "grvServices";
      this.grvServices.ReadOnly = true;
      this.grvServices.RowHeadersVisible = false;
      this.grvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvServices.Size = new Size(526, 324);
      this.grvServices.TabIndex = 0;
      this.ServiceID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.ServiceID.DataPropertyName = "ServiceID";
      this.ServiceID.HeaderText = "Column2";
      this.ServiceID.Name = "ServiceID";
      this.ServiceID.ReadOnly = true;
      this.ServiceID.Resizable = DataGridViewTriState.False;
      this.ServiceID.Visible = false;
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column1.DataPropertyName = "ServiceName";
      this.Column1.FillWeight = 90f;
      this.Column1.HeaderText = "Tên";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Resizable = DataGridViewTriState.False;
      this.Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Price.DataPropertyName = "Price";
      this.Price.FillWeight = 50f;
      this.Price.HeaderText = "Giá";
      this.Price.Name = "Price";
      this.Price.ReadOnly = true;
      this.Price.Resizable = DataGridViewTriState.False;
      this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column3.DataPropertyName = "TotalNumber";
      this.Column3.FillWeight = 50f;
      this.Column3.HeaderText = "Số Lượng";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Resizable = DataGridViewTriState.False;
      this.Column5.DataPropertyName = "StoreNumber";
      this.Column5.HeaderText = "Tồn kho";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column2.DataPropertyName = "LastImport";
      this.Column2.FillWeight = 90f;
      this.Column2.HeaderText = "Nhập Hàng Lần Cuối";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column4.DataPropertyName = "NameOfUser";
      this.Column4.HeaderText = "Nhân Viên Nhập Hàng";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.btnDel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnDel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnDel.Location = new Point(316, 348);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new Size(96, 39);
      this.btnDel.TabIndex = 11;
      this.btnDel.Text = "Xóa";
      this.btnDel.UseVisualStyleBackColor = false;
      this.btnDel.Click += new EventHandler(this.btnDel_Click);
      this.btnExit.BackColor = SystemColors.GradientInactiveCaption;
      this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnExit.Location = new Point(440, 348);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new Size(96, 39);
      this.btnExit.TabIndex = 12;
      this.btnExit.Text = "Thoát";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new EventHandler(this.btnExit_Click);
      this.btnEdit.BackColor = SystemColors.GradientInactiveCaption;
      this.btnEdit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnEdit.Location = new Point(112, 348);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new Size(96, 39);
      this.btnEdit.TabIndex = 10;
      this.btnEdit.Text = "Nhập kho";
      this.btnEdit.UseVisualStyleBackColor = false;
      this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(10, 348);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(96, 39);
      this.btnAdd.TabIndex = 9;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.groupBox2.Controls.Add((Control) this.dataGridView1);
      this.groupBox2.Controls.Add((Control) this.dtpTo);
      this.groupBox2.Controls.Add((Control) this.lblTo);
      this.groupBox2.Controls.Add((Control) this.dtpFrom);
      this.groupBox2.Controls.Add((Control) this.lblFrom);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.cmbList);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.Location = new Point(549, 2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(243, 385);
      this.groupBox2.TabIndex = 13;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Đã bán";
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
      this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle1.SelectionForeColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle2.ForeColor = SystemColors.ControlText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = gridViewCellStyle2;
      this.dataGridView1.Location = new Point(6, (int) sbyte.MaxValue);
      this.dataGridView1.Margin = new Padding(1, 3, 3, 3);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.Size = new Size(231, 252);
      this.dataGridView1.TabIndex = 4;
      this.dtpTo.Location = new Point(114, 99);
      this.dtpTo.Name = "dtpTo";
      this.dtpTo.Size = new Size(123, 22);
      this.dtpTo.TabIndex = 6;
      this.dtpTo.ValueChanged += new EventHandler(this.dtpTo_ValueChanged);
      this.lblTo.AutoSize = true;
      this.lblTo.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTo.Location = new Point(54, 104);
      this.lblTo.Name = "lblTo";
      this.lblTo.Size = new Size(41, 15);
      this.lblTo.TabIndex = 5;
      this.lblTo.Text = "label3";
      this.dtpFrom.Location = new Point(114, 64);
      this.dtpFrom.Name = "dtpFrom";
      this.dtpFrom.Size = new Size(123, 22);
      this.dtpFrom.TabIndex = 4;
      this.dtpFrom.ValueChanged += new EventHandler(this.dtpFrom_ValueChanged);
      this.lblFrom.AutoSize = true;
      this.lblFrom.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFrom.Location = new Point(54, 69);
      this.lblFrom.Name = "lblFrom";
      this.lblFrom.Size = new Size(41, 15);
      this.lblFrom.TabIndex = 3;
      this.lblFrom.Text = "label3";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(9, 70);
      this.label2.Name = "label2";
      this.label2.Size = new Size(47, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Chọn:";
      this.cmbList.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbList.FormattingEnabled = true;
      this.cmbList.Items.AddRange(new object[3]
      {
        (object) "Ngày ",
        (object) "Tháng",
        (object) "Nhiều ngày"
      });
      this.cmbList.Location = new Point(114, 21);
      this.cmbList.Name = "cmbList";
      this.cmbList.Size = new Size(123, 24);
      this.cmbList.TabIndex = 1;
      this.cmbList.SelectionChangeCommitted += new EventHandler(this.cmbList_SelectionChangeCommitted);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(6, 30);
      this.label1.Name = "label1";
      this.label1.Size = new Size(89, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Hiển thị theo";
      this.button1.BackColor = SystemColors.GradientInactiveCaption;
      this.button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(214, 348);
      this.button1.Name = "button1";
      this.button1.Size = new Size(96, 39);
      this.button1.TabIndex = 14;
      this.button1.Text = "Nhập quầy";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(792, 387);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.btnDel);
      this.Controls.Add((Control) this.btnExit);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.btnEdit);
      this.Controls.Add((Control) this.btnAdd);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(808, 426);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(808, 426);
      this.Name = nameof (ServicesManager);
      this.Text = "Quản lý dịch vụ";
      this.FormClosing += new FormClosingEventHandler(this.ServicesManager_FormClosing);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.grvServices).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
