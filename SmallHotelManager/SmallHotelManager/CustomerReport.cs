// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.CustomerReport
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
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class CustomerReport : Form
  {
    private IContainer components = (IContainer) null;
    private ComboBox comboBox1;
    private Label label1;
    private Label label2;
    private DateTimePicker dateTimePicker1;
    private ComboBox comboBox2;
    private Button btnExit;
    private ComboBox comboBox3;
    private Label label4;
    private SaveFileDialog saveFileDialog1;
    private Button btnIn;
    private Button button1;
    private Button btnAdd;
    private Button button2;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn Column7;
    private DataGridViewTextBoxColumn Column8;
    private DataGridViewTextBoxColumn Column10;
    private DataGridViewTextBoxColumn Column9;
    private AddNewCustomer ac = (AddNewCustomer) null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CustomerReport));
      this.dataGridView1 = new DataGridView();
      this.comboBox1 = new ComboBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.dateTimePicker1 = new DateTimePicker();
      this.comboBox2 = new ComboBox();
      this.btnExit = new Button();
      this.comboBox3 = new ComboBox();
      this.label4 = new Label();
      this.saveFileDialog1 = new SaveFileDialog();
      this.btnIn = new Button();
      this.button1 = new Button();
      this.btnAdd = new Button();
      this.button2 = new Button();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column6 = new DataGridViewTextBoxColumn();
      this.Column7 = new DataGridViewTextBoxColumn();
      this.Column8 = new DataGridViewTextBoxColumn();
      this.Column10 = new DataGridViewTextBoxColumn();
      this.Column9 = new DataGridViewTextBoxColumn();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column8, (DataGridViewColumn) this.Column10, (DataGridViewColumn) this.Column9);
      this.dataGridView1.EnableHeadersVisualStyles = false;
      this.dataGridView1.Location = new Point(13, 114);
      this.dataGridView1.Margin = new Padding(4);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(767, 341);
      this.dataGridView1.TabIndex = 0;
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[3]
      {
        (object) "Tháng",
        (object) "Quý",
        (object) "Năm"
      });
      this.comboBox1.Location = new Point(117, 22);
      this.comboBox1.Margin = new Padding(4);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(184, 24);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.SelectionChangeCommitted += new EventHandler(this.comboBox1_SelectionChangeCommitted);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(16, 25);
      this.label1.Name = "label1";
      this.label1.Size = new Size(94, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Thống kê theo";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(19, 72);
      this.label2.Name = "label2";
      this.label2.Size = new Size(45, 16);
      this.label2.TabIndex = 3;
      this.label2.Text = "label2";
      this.dateTimePicker1.Location = new Point(117, 66);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new Size(140, 22);
      this.dateTimePicker1.TabIndex = 4;
      this.dateTimePicker1.ValueChanged += new EventHandler(this.dateTimePicker1_ValueChanged);
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[4]
      {
        (object) "Quý I",
        (object) "Quý II",
        (object) "Quý III",
        (object) "Quý IV"
      });
      this.comboBox2.Location = new Point(117, 64);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(184, 24);
      this.comboBox2.TabIndex = 6;
      this.comboBox2.SelectionChangeCommitted += new EventHandler(this.comboBox2_SelectionChangeCommitted);
      this.btnExit.BackColor = SystemColors.GradientInactiveCaption;
      this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnExit.Location = new Point(684, 462);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new Size(96, 39);
      this.btnExit.TabIndex = 13;
      this.btnExit.Text = "Thoát";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new EventHandler(this.btnExit_Click);
      this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new Point(442, 22);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(183, 24);
      this.comboBox3.TabIndex = 14;
      this.comboBox3.SelectionChangeCommitted += new EventHandler(this.comboBox3_SelectionChangeCommitted);
      this.label4.AutoSize = true;
      this.label4.Location = new Point(350, 30);
      this.label4.Name = "label4";
      this.label4.Size = new Size(63, 16);
      this.label4.TabIndex = 15;
      this.label4.Text = "Quốc tịch";
      this.btnIn.BackColor = SystemColors.GradientInactiveCaption;
      this.btnIn.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnIn.Location = new Point(228, 462);
      this.btnIn.Name = "btnIn";
      this.btnIn.Size = new Size(96, 39);
      this.btnIn.TabIndex = 16;
      this.btnIn.Text = "In";
      this.btnIn.UseVisualStyleBackColor = false;
      this.btnIn.Click += new EventHandler(this.btnIn_Click);
      this.button1.BackColor = SystemColors.GradientInactiveCaption;
      this.button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(339, 462);
      this.button1.Name = "button1";
      this.button1.Size = new Size(134, 39);
      this.button1.TabIndex = 17;
      this.button1.Text = "Xuất Ra Văn Bản";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(12, 462);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(96, 39);
      this.btnAdd.TabIndex = 18;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.button2.BackColor = SystemColors.GradientInactiveCaption;
      this.button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button2.Location = new Point(117, 462);
      this.button2.Name = "button2";
      this.button2.Size = new Size(96, 39);
      this.button2.TabIndex = 19;
      this.button2.Text = "Chỉnh sửa";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column1.DataPropertyName = "CusName";
      this.Column1.HeaderText = "Khách Hàng";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column2.DataPropertyName = "Nation";
      this.Column2.HeaderText = "Quốc Tịch";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column3.DataPropertyName = "Company";
      this.Column3.HeaderText = "Công Ty";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column4.DataPropertyName = "Address";
      this.Column4.HeaderText = "Địa Chỉ";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column5.DataPropertyName = "IdNo";
      this.Column5.HeaderText = "Số CMT";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column6.DataPropertyName = "CusPhone";
      this.Column6.HeaderText = "Điện Thoại";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column7.DataPropertyName = "CITime";
      this.Column7.HeaderText = "Ngày Vào";
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column8.DataPropertyName = "RoomNo";
      this.Column8.HeaderText = "Phòng";
      this.Column8.Name = "Column8";
      this.Column8.ReadOnly = true;
      this.Column9.DataPropertyName = "NationalID";
      this.Column9.HeaderText = "NationalID";
      this.Column9.Name = "Column9";
      this.Column9.ReadOnly = true;
      this.Column9.Visible = false;
      this.Column10.DataPropertyName = "CusID";
      this.Column10.HeaderText = "cusid";
      this.Column10.Name = "Column10";
      this.Column10.ReadOnly = true;
      this.Column10.Visible = false;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(793, 504);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.btnAdd);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.btnIn);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.comboBox3);
      this.Controls.Add((Control) this.btnExit);
      this.Controls.Add((Control) this.comboBox2);
      this.Controls.Add((Control) this.dateTimePicker1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.dataGridView1);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(809, 543);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(809, 543);
      this.Name = nameof (CustomerReport);
      this.Text = "Thông Tin Khách Hàng";
      this.FormClosing += new FormClosingEventHandler(this.CustomerReport_FormClosing);
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public CustomerReport()
    {
      this.InitializeComponent();
      this.getReciever();
      DateTime now = DateTime.Now;
      this.comboBox1.SelectedIndex = 0;
      this.comboBox3.SelectedValue = (object) 0;
      this.dateTimePicker1.Visible = true;
      this.dateTimePicker1.CustomFormat = "MM/yyyy";
      this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
      this.comboBox2.Visible = false;
      this.label2.Text = "Chọn Tháng";
      this.GrvGetDataByMonth(now);
    }

    private void getReciever()
    {
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("Nation", typeof (string));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("NationalID", typeof (int));
      dataTable.Columns.Add(column2);
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType33<int, string>> queryable = smallHotelManager.National.Select(u => new
      {
        NationalID = u.NationalID,
        Nation = u.Nation
      });
      DataRow row1 = dataTable.NewRow();
      row1["Nation"] = (object) "Tất cả";
      row1["NationalID"] = (object) 0;
      dataTable.Rows.Add(row1);
      foreach (var data in queryable)
      {
        DataRow row2 = dataTable.NewRow();
        row2["Nation"] = (object) data.Nation;
        row2["NationalID"] = (object) data.NationalID;
        dataTable.Rows.Add(row2);
      }
      this.comboBox3.DataSource = (object) dataTable;
      this.comboBox3.DisplayMember = "Nation";
      this.comboBox3.ValueMember = "NationalID";
      smallHotelManager.Connection.Close();
    }

    public void GrvGetDataByMonth(DateTime date)
    {
      int userid = (int) this.comboBox3.SelectedValue;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType35<int, string, int, string, string, string, string, DateTime?, string, string>> source = db.Customer.SelectMany((Expression<Func<Customer, IEnumerable<National>>>) (s => db.National), (s, n) => new
      {
        s = s,
        n = n
      }).Where(data => (int?) data.n.NationalID == data.s.NationalID && date.Month == data.s.CITime.Value.Month && date.Year == data.s.CITime.Value.Year).Select(data => new
      {
        CusID = data.s.CusID,
        CusName = data.s.CusName,
        NationalID = data.n.NationalID,
        Nation = data.n.Nation,
        Company = data.s.Company,
        CusPhone = data.s.CusPhone,
        Address = data.s.Address,
        CITime = data.s.CITime,
        RoomNo = data.s.RoomNo,
        IdNo = data.s.IdNo
      });
      if (userid != 0)
        source = source.AsQueryable().Where(n => n.NationalID == userid);
      this.dataGridView1.DataSource = (object) source;
      db.Connection.Close();
    }

    public void GrvGetDataByQuy(DateTime date, int dt1, int dt2)
    {
      int userid = (int) this.comboBox3.SelectedValue;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType36<int, int, string, string, string, string, string, DateTime?, string, string>> source = db.Customer.SelectMany((Expression<Func<Customer, IEnumerable<National>>>) (s => db.National), (s, n) => new
      {
        s = s,
        n = n
      }).Where(data => (int?) data.n.NationalID == data.s.NationalID && data.s.CITime.Value.Month >= dt1 && data.s.CITime.Value.Month <= dt2 && date.Year == data.s.CITime.Value.Year).Select(data => new
      {
        CusID = data.s.CusID,
        NationalID = data.n.NationalID,
        CusName = data.s.CusName,
        Nation = data.n.Nation,
        Company = data.s.Company,
        CusPhone = data.s.CusPhone,
        Address = data.s.Address,
        CITime = data.s.CITime,
        RoomNo = data.s.RoomNo,
        IdNo = data.s.IdNo
      });
      if (userid != 0)
        source = source.AsQueryable().Where(n => n.NationalID == userid);
      this.dataGridView1.DataSource = (object) source;
      db.Connection.Close();
    }

    public void GrvGetDataByYear(DateTime date)
    {
      int userid = (int) this.comboBox3.SelectedValue;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType36<int, int, string, string, string, string, string, DateTime?, string, string>> source = db.Customer.SelectMany((Expression<Func<Customer, IEnumerable<National>>>) (s => db.National), (s, n) => new
      {
        s = s,
        n = n
      }).Where(data => (int?) data.n.NationalID == data.s.NationalID && date.Year == data.s.CITime.Value.Year).Select(data => new
      {
        CusID = data.s.CusID,
        NationalID = data.n.NationalID,
        CusName = data.s.CusName,
        Nation = data.n.Nation,
        Company = data.s.Company,
        CusPhone = data.s.CusPhone,
        Address = data.s.Address,
        CITime = data.s.CITime,
        RoomNo = data.s.RoomNo,
        IdNo = data.s.IdNo
      });
      if (userid != 0)
        source = source.AsQueryable().Where(n => n.NationalID == userid);
      this.dataGridView1.DataSource = (object) source;
      db.Connection.Close();
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      DateTime date = this.dateTimePicker1.Value;
      if (this.comboBox1.SelectedIndex == 0)
      {
        this.comboBox2.Visible = false;
        this.label2.Text = "Tháng";
        this.dateTimePicker1.Visible = true;
        this.dateTimePicker1.CustomFormat = "MM/yyyy";
        this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
        this.GrvGetDataByMonth(date);
      }
      if (this.comboBox1.SelectedIndex != 2)
        return;
      this.comboBox2.Visible = false;
      this.dateTimePicker1.Visible = true;
      this.label2.Text = "Năm";
      this.dateTimePicker1.CustomFormat = "yyyy";
      this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
      this.GrvGetDataByYear(date);
    }

    private void btnExit_Click(object sender, EventArgs e) => this.Dispose();

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
    {
      DateTime date = this.dateTimePicker1.Value;
      if (this.comboBox1.SelectedIndex == 0)
      {
        this.comboBox2.Visible = false;
        this.label2.Text = "Tháng";
        this.dateTimePicker1.Visible = true;
        this.dateTimePicker1.CustomFormat = "MM/yyyy";
        this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
        this.GrvGetDataByMonth(date);
      }
      else if (this.comboBox1.SelectedIndex == 2)
      {
        this.comboBox2.Visible = false;
        this.label2.Text = "Năm";
        this.dateTimePicker1.Visible = true;
        this.dateTimePicker1.CustomFormat = "yyyy";
        this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
        this.GrvGetDataByYear(date);
      }
      else
      {
        this.dateTimePicker1.Visible = false;
        this.comboBox2.Visible = true;
        this.label2.Text = "Chọn Quý";
        this.comboBox2.SelectedIndex = 0;
        if (this.comboBox2.SelectedIndex == 0)
          this.GrvGetDataByQuy(date, 1, 3);
        else if (this.comboBox2.SelectedIndex == 1)
          this.GrvGetDataByQuy(date, 4, 6);
        else if (this.comboBox2.SelectedIndex == 2)
          this.GrvGetDataByQuy(date, 7, 9);
        else if (this.comboBox2.SelectedIndex == 3)
          this.GrvGetDataByQuy(date, 10, 12);
      }
    }

    private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
    {
      DateTime date = this.dateTimePicker1.Value;
      if (this.comboBox1.SelectedIndex == 0)
        this.GrvGetDataByMonth(date);
      if (this.comboBox1.SelectedIndex == 2)
        this.GrvGetDataByYear(date);
      else if (this.comboBox2.SelectedIndex == 0)
        this.GrvGetDataByQuy(date, 1, 3);
      else if (this.comboBox2.SelectedIndex == 1)
        this.GrvGetDataByQuy(date, 4, 6);
      else if (this.comboBox2.SelectedIndex == 2)
        this.GrvGetDataByQuy(date, 7, 9);
      else if (this.comboBox2.SelectedIndex == 3)
        this.GrvGetDataByQuy(date, 10, 12);
    }

    private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
    {
      DateTime date = this.dateTimePicker1.Value;
      if (this.comboBox1.SelectedIndex == 0)
      {
        this.comboBox2.Visible = false;
        this.label2.Text = "Tháng";
        this.dateTimePicker1.Visible = true;
        this.dateTimePicker1.CustomFormat = "MM/yyyy";
        this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
        this.GrvGetDataByMonth(date);
      }
      if (this.comboBox1.SelectedIndex == 2)
      {
        this.comboBox2.Visible = false;
        this.label2.Text = "Năm";
        this.dateTimePicker1.Visible = true;
        this.dateTimePicker1.CustomFormat = "yyyy";
        this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
        this.GrvGetDataByYear(date);
      }
      else
      {
        this.dateTimePicker1.Visible = false;
        this.comboBox2.Visible = true;
        this.label2.Text = "Chọn Quý";
        if (this.comboBox2.SelectedIndex == 0)
          this.GrvGetDataByQuy(date, 1, 3);
        else if (this.comboBox2.SelectedIndex == 1)
          this.GrvGetDataByQuy(date, 4, 6);
        else if (this.comboBox2.SelectedIndex == 2)
          this.GrvGetDataByQuy(date, 7, 9);
        else if (this.comboBox2.SelectedIndex == 3)
          this.GrvGetDataByQuy(date, 10, 12);
      }
    }

    private void ConvertDGVtoExcel(int type)
    {
      string str1 = this.dateTimePicker1.Value.Month.ToString();
      string str2 = this.dateTimePicker1.Value.Year.ToString();
      string str3 = this.comboBox2.SelectedIndex.ToString();
      try
      {
        string str4;
        string str5;
        if (this.comboBox1.SelectedIndex == 0)
        {
          str4 = "Thông tin khách hàng tháng " + str1 + " năm " + str2;
          str5 = "Khach_hang_thang_" + str1 + "_nam_" + str2;
        }
        else if (this.comboBox1.SelectedIndex == 1)
        {
          str4 = "Thông tin khách hàng" + str3 + " năm " + str2.ToString();
          str5 = "Khach_hang_thang_" + str3 + "_nam_" + str2.ToString();
        }
        else
        {
          str4 = "Thông tin khách hàng năm " + str2;
          str5 = "Khach_hang_nam_" + str2;
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
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitea == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitea = CallSite<Func<CallSite, object, _Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof (_Worksheet), typeof (CustomerReport)));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        worksheet1 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitea.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitea, workbook.Sheets[(object) "Sheet1"]);
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Siteb == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Siteb = CallSite<Func<CallSite, object, _Worksheet>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof (_Worksheet), typeof (CustomerReport)));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: variable of a compiler-generated type
        _Worksheet worksheet2 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Siteb.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Siteb, workbook.ActiveSheet);
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
        worksheet2.Cells[(object) 1, (object) 3] = (object) str4.ToString();
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitec == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitec = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj1 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitec.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitec, worksheet2.Columns[(object) "A", System.Type.Missing], 20);
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sited == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sited = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj2 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sited.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sited, worksheet2.Columns[(object) "B", System.Type.Missing], 12);
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitee == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitee = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj3 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitee.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitee, worksheet2.Columns[(object) "C", System.Type.Missing], 15);
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitef == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitef = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj4 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitef.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Sitef, worksheet2.Columns[(object) "D", System.Type.Missing], 10);
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site10 == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site10 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj5 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site10.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site10, worksheet2.Columns[(object) "E", System.Type.Missing], 40);
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site11 == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site11 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj6 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site11.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site11, worksheet2.Columns[(object) "F", System.Type.Missing], 15);
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site12 == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site12 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj7 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site12.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site12, worksheet2.Columns[(object) "G", System.Type.Missing], 8);
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site13 == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site13 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ColumnWidth", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj8 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site13.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site13, worksheet2.Columns[(object) "H", System.Type.Missing], 10);
        worksheet2.Name = str5.ToString();
        worksheet2.Columns.HorizontalAlignment = (object) XlHAlign.xlHAlignLeft;
        for (int index = 1; index < this.dataGridView1.Columns.Count; ++index)
          worksheet2.Cells[(object) 2, (object) index] = (object) this.dataGridView1.Columns[index].HeaderText;
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site14 == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site14 = CallSite<Func<CallSite, object, XlBorderWeight, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Weight", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, XlBorderWeight, object> target1 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site14.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, XlBorderWeight, object>> pSite14 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site14;
        // ISSUE: reference to a compiler-generated field
        if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site15 == null)
        {
          // ISSUE: reference to a compiler-generated field
          CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site15 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Borders", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj9 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site15.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site15, worksheet2.Rows[(object) 2, System.Type.Missing]);
        object obj10 = target1((CallSite) pSite14, obj9, XlBorderWeight.xlMedium);
        for (int index1 = 0; index1 < this.dataGridView1.Rows.Count; ++index1)
        {
          // ISSUE: reference to a compiler-generated field
          if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site16 == null)
          {
            // ISSUE: reference to a compiler-generated field
            CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site16 = CallSite<Func<CallSite, object, XlBorderWeight, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Weight", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, XlBorderWeight, object> target2 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site16.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, XlBorderWeight, object>> pSite16 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site16;
          // ISSUE: reference to a compiler-generated field
          if (CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site17 == null)
          {
            // ISSUE: reference to a compiler-generated field
            CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site17 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Borders", typeof (CustomerReport), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj11 = CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site17.Target((CallSite) CustomerReport.\u003CConvertDGVtoExcel\u003Eo__SiteContainer9.\u003C\u003Ep__Site17, worksheet2.Rows[(object) (index1 + 3), System.Type.Missing]);
          object obj12 = target2((CallSite) pSite16, obj11, XlBorderWeight.xlMedium);
          for (int index2 = 1; index2 < this.dataGridView1.Columns.Count; ++index2)
            worksheet2.Cells[(object) (index1 + 3), (object) index2] = this.dataGridView1.Rows[index1].Cells[index2].Value;
        }
        if (type == 1)
        {
          this.saveFileDialog1.Filter = "Execl files (*.xls)|*.xls";
          this.saveFileDialog1.FilterIndex = 0;
          this.saveFileDialog1.RestoreDirectory = true;
          this.saveFileDialog1.CreatePrompt = true;
          this.saveFileDialog1.Title = "Lưu thành tệp Excel";
          this.saveFileDialog1.FileName = str5.ToString();
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

    private void btnIn_Click(object sender, EventArgs e) => this.ConvertDGVtoExcel(0);

    private void button1_Click(object sender, EventArgs e) => this.ConvertDGVtoExcel(1);

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (this.ac != null && !this.ac.IsDisposed)
        return;
      this.ac = new AddNewCustomer(this);
      int num = (int) this.ac.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.ac != null && !this.ac.IsDisposed || this.dataGridView1.RowCount <= 0)
        return;
      int num1 = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
      this.ac = new AddNewCustomer(this);
      this.ac.MdiParent = this.MdiParent;
      this.ac.CusId = num1;
      int num2 = (int) this.ac.ShowDialog();
    }

    public void performRefresh()
    {
      DateTime date = this.dateTimePicker1.Value;
      if (this.comboBox1.SelectedIndex == 0)
      {
        this.comboBox2.Visible = false;
        this.label2.Text = "Tháng";
        this.dateTimePicker1.Visible = true;
        this.dateTimePicker1.CustomFormat = "MM/yyyy";
        this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
        this.GrvGetDataByMonth(date);
      }
      else if (this.comboBox1.SelectedIndex == 2)
      {
        this.comboBox2.Visible = false;
        this.label2.Text = "Năm";
        this.dateTimePicker1.Visible = true;
        this.dateTimePicker1.CustomFormat = "yyyy";
        this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
        this.GrvGetDataByYear(date);
      }
      else
      {
        this.dateTimePicker1.Visible = false;
        this.comboBox2.Visible = true;
        this.label2.Text = "Chọn Quý";
        this.comboBox2.SelectedIndex = 0;
        if (this.comboBox2.SelectedIndex == 0)
          this.GrvGetDataByQuy(date, 1, 3);
        else if (this.comboBox2.SelectedIndex == 1)
          this.GrvGetDataByQuy(date, 4, 6);
        else if (this.comboBox2.SelectedIndex == 2)
          this.GrvGetDataByQuy(date, 7, 9);
        else if (this.comboBox2.SelectedIndex == 3)
          this.GrvGetDataByQuy(date, 10, 12);
      }
    }

    private void CustomerReport_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();
  }
}
