// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.VAT
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class VAT : Form
  {
    private Main _parent;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private Label label5;
    private DateTimePicker dateTimePicker1;
    private Button btnClose;
    private Button btnAdd;
    private TextBox txtContent;
    private TextBox txtCost;
    private TextBox txtCode;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private DataGridView dataGridView1;
    private Button btnDel;
    private GroupBox groupBox2;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;

    public VAT(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
      this.GrvGetData();
    }

    public void GrvGetData()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.dataGridView1.DataSource = (object) smallHotelManager.OutInCome.Select(s => new
      {
        GRID = s.ID,
        GRCode = s.Code,
        GRCost = string.Format("{0:0,0}", (object) (s.Cost * (int?) 1000)),
        GRCon = s.Content,
        GRDate = string.Format("{0:d/M/yyyy}", (object) s.DateIncome.Value.Date)
      });
      smallHotelManager.Connection.Close();
    }

    private void AddNew(string code, DateTime dat, int cost, string content)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        OutInCome entity = new OutInCome()
        {
          Code = code,
          DateIncome = new DateTime?(dat),
          Cost = new int?(cost),
          Content = content
        };
        smallHotelManager.OutInCome.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num1 = (int) MessageBox.Show("Thêm thành công!!!");
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.txtCode.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập tên Khách Hàng");
        this.txtCode.Focus();
      }
      else
      {
        try
        {
          if (Convert.ToInt32(this.txtCost.Text) < 0)
          {
            int num = (int) MessageBox.Show("Vui lòng nhập số tiền > 0");
            this.txtCost.Focus();
            return;
          }
        }
        catch
        {
          int num = (int) MessageBox.Show("Số tiền chỉ được phép nhập số.\n Xin vui lòng thử lại!!!");
          this.txtCost.Text = "";
          return;
        }
        string code = this.txtCode.Text.ToString();
        string content = this.txtContent.Text.ToString();
        int int32 = Convert.ToInt32(this.txtCost.Text.ToString());
        DateTime date = this.dateTimePicker1.Value.Date;
        this.AddNew(code, date, int32, content);
        this.GrvGetData();
      }
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this.dataGridView1.RowCount <= 0 || MessageBox.Show("Bạn có chắc muốn xóa?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      int roomID = int.Parse(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
      OutInCome entity = smallHotelManager.OutInCome.Single<OutInCome>((Expression<Func<OutInCome, bool>>) (x => x.ID == roomID));
      smallHotelManager.OutInCome.DeleteOnSubmit(entity);
      smallHotelManager.SubmitChanges();
      this.GrvGetData();
    }

    private void VAT_FormClosing(object sender, FormClosingEventArgs e)
    {
      this._parent.grvSpendingData();
      this.Dispose();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (VAT));
      this.groupBox1 = new GroupBox();
      this.label5 = new Label();
      this.dateTimePicker1 = new DateTimePicker();
      this.btnClose = new Button();
      this.btnAdd = new Button();
      this.txtContent = new TextBox();
      this.txtCost = new TextBox();
      this.txtCode = new TextBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.dataGridView1 = new DataGridView();
      this.btnDel = new Button();
      this.groupBox2 = new GroupBox();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.dateTimePicker1);
      this.groupBox1.Controls.Add((Control) this.btnClose);
      this.groupBox1.Controls.Add((Control) this.btnAdd);
      this.groupBox1.Controls.Add((Control) this.txtContent);
      this.groupBox1.Controls.Add((Control) this.txtCost);
      this.groupBox1.Controls.Add((Control) this.txtCode);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(7, 5);
      this.groupBox1.Margin = new Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new Padding(4);
      this.groupBox1.Size = new Size(304, 352);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(222, 129);
      this.label5.Margin = new Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(71, 16);
      this.label5.TabIndex = 22;
      this.label5.Text = "(.000 VNĐ)";
      this.dateTimePicker1.Format = DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new Point(92, 67);
      this.dateTimePicker1.Margin = new Padding(4);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new Size(201, 22);
      this.dateTimePicker1.TabIndex = 21;
      this.btnClose.BackColor = SystemColors.GradientInactiveCaption;
      this.btnClose.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Location = new Point(182, 305);
      this.btnClose.Margin = new Padding(5);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(101, 34);
      this.btnClose.TabIndex = 20;
      this.btnClose.Text = "Thoát";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(25, 305);
      this.btnAdd.Margin = new Padding(5);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(101, 34);
      this.btnAdd.TabIndex = 19;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.txtContent.Location = new Point(92, 175);
      this.txtContent.Margin = new Padding(5);
      this.txtContent.Multiline = true;
      this.txtContent.Name = "txtContent";
      this.txtContent.Size = new Size(201, 114);
      this.txtContent.TabIndex = 18;
      this.txtCost.Location = new Point(92, 123);
      this.txtCost.Margin = new Padding(5);
      this.txtCost.Name = "txtCost";
      this.txtCost.Size = new Size(112, 22);
      this.txtCost.TabIndex = 17;
      this.txtCode.Location = new Point(92, 20);
      this.txtCode.Margin = new Padding(5);
      this.txtCode.Name = "txtCode";
      this.txtCode.Size = new Size(201, 22);
      this.txtCode.TabIndex = 15;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(9, 178);
      this.label4.Margin = new Padding(5, 0, 5, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(52, 16);
      this.label4.TabIndex = 14;
      this.label4.Text = "Ghi chú";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(9, 126);
      this.label3.Margin = new Padding(5, 0, 5, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(49, 16);
      this.label3.TabIndex = 13;
      this.label3.Text = "Số tiền";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(9, 73);
      this.label2.Margin = new Padding(5, 0, 5, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(41, 16);
      this.label2.TabIndex = 12;
      this.label2.Text = "Ngày";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(9, 20);
      this.label1.Margin = new Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(79, 16);
      this.label1.TabIndex = 11;
      this.label1.Text = "Mã hóa đơn";
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange((DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4);
      this.dataGridView1.Location = new Point(8, 20);
      this.dataGridView1.Margin = new Padding(4);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new Size(456, 277);
      this.dataGridView1.TabIndex = 0;
      this.btnDel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnDel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnDel.Location = new Point(8, 305);
      this.btnDel.Margin = new Padding(5);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new Size(456, 34);
      this.btnDel.TabIndex = 21;
      this.btnDel.Text = "Xóa";
      this.btnDel.UseVisualStyleBackColor = false;
      this.btnDel.Click += new EventHandler(this.btnDel_Click);
      this.groupBox2.Controls.Add((Control) this.btnDel);
      this.groupBox2.Controls.Add((Control) this.dataGridView1);
      this.groupBox2.Location = new Point(319, 5);
      this.groupBox2.Margin = new Padding(4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new Padding(4);
      this.groupBox2.Size = new Size(475, 352);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.Column5.DataPropertyName = "GRID";
      this.Column5.HeaderText = "GRID";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Visible = false;
      this.Column1.DataPropertyName = "GRCode";
      this.Column1.HeaderText = "Mã Số";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column2.DataPropertyName = "GRDate";
      this.Column2.HeaderText = "Ngày";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column3.DataPropertyName = "GRCost";
      this.Column3.HeaderText = "Số Tiền";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column4.DataPropertyName = "GRCon";
      this.Column4.HeaderText = "Ghi Chú";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(800, 364);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox2);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(816, 402);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(816, 402);
      this.Name = nameof (VAT);
      this.Text = nameof (VAT);
      this.FormClosing += new FormClosingEventHandler(this.VAT_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
