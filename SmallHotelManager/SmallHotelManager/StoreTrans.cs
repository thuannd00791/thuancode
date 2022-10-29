// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.StoreTrans
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using SmallHotelManager.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class StoreTrans : Form
  {
    private IContainer components = (IContainer) null;
    private Label label6;
    private Label label5;
    private DataGridView grvCrSer;
    private Button btnSub;
    private Button btnAdd;
    private DataGridView grvStoreSer;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private ComboBox comboBox1;
    private DataTable dtCrSer;
    private DataTable dtStoreSer;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (StoreTrans));
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      this.label6 = new Label();
      this.label5 = new Label();
      this.grvCrSer = new DataGridView();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column6 = new DataGridViewTextBoxColumn();
      this.btnSub = new Button();
      this.btnAdd = new Button();
      this.grvStoreSer = new DataGridView();
      this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.comboBox1 = new ComboBox();
      ((ISupportInitialize) this.grvCrSer).BeginInit();
      ((ISupportInitialize) this.grvStoreSer).BeginInit();
      this.SuspendLayout();
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(200, 9);
      this.label6.Name = "label6";
      this.label6.Size = new Size(66, 16);
      this.label6.TabIndex = 23;
      this.label6.Text = "Hàng kho";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(12, 9);
      this.label5.Name = "label5";
      this.label5.Size = new Size(74, 16);
      this.label5.TabIndex = 22;
      this.label5.Text = "Hàng quầy";
      this.grvCrSer.AllowUserToAddRows = false;
      this.grvCrSer.AllowUserToDeleteRows = false;
      this.grvCrSer.AllowUserToResizeRows = false;
      this.grvCrSer.BackgroundColor = SystemColors.ControlLightLight;
      this.grvCrSer.CellBorderStyle = DataGridViewCellBorderStyle.None;
      this.grvCrSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvCrSer.ColumnHeadersVisible = false;
      this.grvCrSer.Columns.AddRange((DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column6);
      this.grvCrSer.GridColor = SystemColors.Control;
      this.grvCrSer.Location = new Point(12, 28);
      this.grvCrSer.MultiSelect = false;
      this.grvCrSer.Name = "grvCrSer";
      this.grvCrSer.ReadOnly = true;
      this.grvCrSer.RowHeadersVisible = false;
      this.grvCrSer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvCrSer.Size = new Size(154, 289);
      this.grvCrSer.TabIndex = 20;
      this.Column3.DataPropertyName = "ServiceID";
      this.Column3.HeaderText = "ServiceID";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Resizable = DataGridViewTriState.False;
      this.Column3.Visible = false;
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column1.DataPropertyName = "Name";
      gridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
      this.Column1.DefaultCellStyle = gridViewCellStyle1;
      this.Column1.HeaderText = "Name";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Resizable = DataGridViewTriState.False;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.Column2.DataPropertyName = "TotalNumber";
      gridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
      this.Column2.DefaultCellStyle = gridViewCellStyle2;
      this.Column2.HeaderText = "Number";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Resizable = DataGridViewTriState.False;
      this.Column2.Width = 5;
      this.Column6.DataPropertyName = "Price";
      this.Column6.HeaderText = "Price";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column6.Resizable = DataGridViewTriState.False;
      this.Column6.Visible = false;
      this.btnSub.BackgroundImage = (Image) Resources.agt_back;
      this.btnSub.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnSub.FlatAppearance.BorderSize = 0;
      this.btnSub.FlatStyle = FlatStyle.Flat;
      this.btnSub.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSub.Location = new Point(182, 192);
      this.btnSub.Name = "btnSub";
      this.btnSub.Size = new Size(25, 25);
      this.btnSub.TabIndex = 19;
      this.btnSub.UseVisualStyleBackColor = true;
      this.btnSub.Click += new EventHandler(this.btnSub_Click);
      this.btnAdd.BackgroundImage = (Image) componentResourceManager.GetObject("btnAdd.BackgroundImage");
      this.btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnAdd.FlatAppearance.BorderSize = 0;
      this.btnAdd.FlatStyle = FlatStyle.Flat;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(182, 108);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(25, 25);
      this.btnAdd.TabIndex = 18;
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.grvStoreSer.AllowUserToAddRows = false;
      this.grvStoreSer.AllowUserToDeleteRows = false;
      this.grvStoreSer.AllowUserToResizeRows = false;
      this.grvStoreSer.BackgroundColor = SystemColors.ControlLightLight;
      this.grvStoreSer.CellBorderStyle = DataGridViewCellBorderStyle.None;
      this.grvStoreSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvStoreSer.ColumnHeadersVisible = false;
      this.grvStoreSer.Columns.AddRange((DataGridViewColumn) this.dataGridViewTextBoxColumn1, (DataGridViewColumn) this.dataGridViewTextBoxColumn2, (DataGridViewColumn) this.dataGridViewTextBoxColumn3, (DataGridViewColumn) this.dataGridViewTextBoxColumn4);
      this.grvStoreSer.GridColor = SystemColors.Control;
      this.grvStoreSer.Location = new Point(222, 28);
      this.grvStoreSer.MultiSelect = false;
      this.grvStoreSer.Name = "grvStoreSer";
      this.grvStoreSer.ReadOnly = true;
      this.grvStoreSer.RowHeadersVisible = false;
      this.grvStoreSer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvStoreSer.Size = new Size(154, 289);
      this.grvStoreSer.TabIndex = 24;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "ServiceID";
      this.dataGridViewTextBoxColumn1.HeaderText = "ServiceID";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn1.Visible = false;
      this.dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
      gridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
      this.dataGridViewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle3;
      this.dataGridViewTextBoxColumn2.HeaderText = "Name";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.dataGridViewTextBoxColumn3.DataPropertyName = "TotalNumber";
      gridViewCellStyle4.BackColor = SystemColors.ControlLightLight;
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle4;
      this.dataGridViewTextBoxColumn3.HeaderText = "Number";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn3.Width = 5;
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
      this.dataGridViewTextBoxColumn4.HeaderText = "Price";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn4.Visible = false;
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[2]
      {
        (object) "1",
        (object) "10"
      });
      this.comboBox1.Location = new Point(172, 151);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(44, 24);
      this.comboBox1.TabIndex = 25;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(388, 329);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.grvStoreSer);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.grvCrSer);
      this.Controls.Add((Control) this.btnSub);
      this.Controls.Add((Control) this.btnAdd);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(404, 368);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(404, 368);
      this.Name = nameof (StoreTrans);
      this.Text = "Xuất, nhập hàng";
      this.FormClosing += new FormClosingEventHandler(this.StoreTrans_FormClosing);
      this.Load += new EventHandler(this.StoreTrans_Load);
      ((ISupportInitialize) this.grvCrSer).EndInit();
      ((ISupportInitialize) this.grvStoreSer).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public StoreTrans() => this.InitializeComponent();

    private void listCurrenServiceData() => this.grvCrSer.DataSource = (object) this.dtCrSer;

    private void listStoreServiceData() => this.grvStoreSer.DataSource = (object) this.dtStoreSer;

    private void binddtCrSer()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousTypef<int, string, int?, int?>> queryable = smallHotelManager.Services.Where<Services>((Expression<Func<Services, bool>>) (s => s.ServiceID != 1 && s.DelID == new int?())).Select(s => new
      {
        ServiceID = s.ServiceID,
        Name = s.Name,
        TotalNumber = s.TotalNumber,
        Price = s.Price
      });
      this.dtCrSer = new DataTable();
      this.dtCrSer.Columns.Add(new DataColumn("ServiceID", typeof (int)));
      this.dtCrSer.Columns.Add(new DataColumn("Name", typeof (string)));
      this.dtCrSer.Columns.Add(new DataColumn("TotalNumber", typeof (int)));
      this.dtCrSer.Columns.Add(new DataColumn("Price", typeof (int)));
      IQueryable<\u003C\u003Ef__AnonymousTypef<int, string, int?, int?>> source = queryable;
      Expression<Func<\u003C\u003Ef__AnonymousTypef<int, string, int?, int?>, string>> keySelector = x => x.Name;
      foreach (var data in source.OrderBy(keySelector))
      {
        DataRow row = this.dtCrSer.NewRow();
        row["ServiceID"] = (object) data.ServiceID;
        row["Name"] = (object) data.Name;
        int? totalNumber = data.TotalNumber;
        row["TotalNumber"] = !totalNumber.HasValue ? (object) 0 : (object) data.TotalNumber;
        row["Price"] = (object) data.Price;
        this.dtCrSer.Rows.Add(row);
      }
      smallHotelManager.Connection.Close();
    }

    private void binddtStoreSer()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType39<int, string, int?, int?>> queryable = smallHotelManager.Services.Where<Services>((Expression<Func<Services, bool>>) (s => s.ServiceID != 1 && s.DelID == new int?())).Select(s => new
      {
        ServiceID = s.ServiceID,
        Name = s.Name,
        StoreNum = s.StoreNum,
        Price = s.Price
      });
      this.dtStoreSer = new DataTable();
      this.dtStoreSer.Columns.Add(new DataColumn("ServiceID", typeof (int)));
      this.dtStoreSer.Columns.Add(new DataColumn("Name", typeof (string)));
      this.dtStoreSer.Columns.Add(new DataColumn("TotalNumber", typeof (int)));
      this.dtStoreSer.Columns.Add(new DataColumn("Price", typeof (int)));
      IQueryable<\u003C\u003Ef__AnonymousType39<int, string, int?, int?>> source = queryable;
      Expression<Func<\u003C\u003Ef__AnonymousType39<int, string, int?, int?>, string>> keySelector = x => x.Name;
      foreach (var data in source.OrderBy(keySelector))
      {
        DataRow row = this.dtStoreSer.NewRow();
        row["ServiceID"] = (object) data.ServiceID;
        row["Name"] = (object) data.Name;
        int? storeNum = data.StoreNum;
        row["TotalNumber"] = !storeNum.HasValue ? (object) 0 : (object) data.StoreNum;
        row["Price"] = (object) data.Price;
        this.dtStoreSer.Rows.Add(row);
      }
      smallHotelManager.Connection.Close();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      int num1 = int.Parse(this.comboBox1.Text.ToString());
      if (this.grvCrSer.Rows.Count == 0)
        return;
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int num2 = 0;
      int rowIndex = this.grvCrSer.CurrentCell.RowIndex;
      int num3 = (int) this.dtCrSer.Rows[rowIndex][2];
      if (num3 > 0)
      {
        int num4 = (int) this.dtCrSer.Rows[rowIndex][0];
        string str = (string) this.dtCrSer.Rows[rowIndex][1];
        int num5 = (int) this.dtCrSer.Rows[rowIndex][3];
        int num6 = num3 - num1;
        this.dtCrSer.Rows[rowIndex][2] = (object) num6;
        this.listCurrenServiceData();
        for (int index = 0; index < this.dtStoreSer.Rows.Count; ++index)
        {
          if (this.dtStoreSer.Rows[index][0].ToString().Equals(num4.ToString()))
          {
            this.dtStoreSer.Rows[index][2] = (object) ((int) this.dtStoreSer.Rows[index][2] + num1);
            ++num2;
          }
        }
        this.listStoreServiceData();
      }
      else
      {
        int num7 = (int) MessageBox.Show("[" + (string) this.dtCrSer.Rows[rowIndex][1] + "] đã hết!!");
      }
      smallHotelManager.Connection.Close();
    }

    private void btnSub_Click(object sender, EventArgs e)
    {
      int num1 = int.Parse(this.comboBox1.Text.ToString());
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int num2 = 0;
      int rowIndex = this.grvStoreSer.CurrentCell.RowIndex;
      int num3 = (int) this.dtStoreSer.Rows[rowIndex][2];
      if (num3 > 0)
      {
        int num4 = (int) this.dtStoreSer.Rows[rowIndex][0];
        string str = (string) this.dtStoreSer.Rows[rowIndex][1];
        int num5 = (int) this.dtStoreSer.Rows[rowIndex][3];
        int num6 = num3 - num1;
        this.dtStoreSer.Rows[rowIndex][2] = (object) num6;
        this.listCurrenServiceData();
        for (int index = 0; index < this.dtCrSer.Rows.Count; ++index)
        {
          if (this.dtStoreSer.Rows[index][0].ToString().Equals(num4.ToString()))
          {
            this.dtCrSer.Rows[index][2] = (object) ((int) this.dtCrSer.Rows[index][2] + num1);
            ++num2;
          }
        }
        this.listStoreServiceData();
      }
      else
      {
        int num7 = (int) MessageBox.Show("[" + (string) this.dtCrSer.Rows[rowIndex][1] + "] đã hết!!");
      }
      smallHotelManager.Connection.Close();
    }

    private void StoreTrans_Load(object sender, EventArgs e)
    {
      this.comboBox1.SelectedIndex = 0;
      this.binddtCrSer();
      this.listCurrenServiceData();
      this.binddtStoreSer();
      this.listStoreServiceData();
    }

    private void StoreTrans_FormClosing(object sender, FormClosingEventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      for (int i = 0; i < this.dtCrSer.Rows.Count; ++i)
      {
        if ((int) this.dtCrSer.Rows[i][0] != 0)
        {
          smallHotelManager.Services.Single<Services>((Expression<Func<Services, bool>>) (r => r.ServiceID == (int) this.dtCrSer.Rows[i][0])).TotalNumber = new int?((int) this.dtCrSer.Rows[i][2]);
          smallHotelManager.SubmitChanges();
        }
      }
      for (int i = 0; i < this.dtStoreSer.Rows.Count; ++i)
      {
        if ((int) this.dtStoreSer.Rows[i][0] != 0)
        {
          smallHotelManager.Services.Single<Services>((Expression<Func<Services, bool>>) (r => r.ServiceID == (int) this.dtStoreSer.Rows[i][0])).StoreNum = new int?((int) this.dtStoreSer.Rows[i][2]);
          smallHotelManager.SubmitChanges();
        }
      }
      smallHotelManager.Connection.Close();
      this.Dispose();
    }
  }
}
