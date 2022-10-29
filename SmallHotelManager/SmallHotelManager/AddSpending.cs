// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AddSpending
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
  public class AddSpending : Form
  {
    private Main _parent;
    private Spending rm = (Spending) null;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private Label label3;
    private Button button2;
    private Button btnSave;
    private TextBox txtPrice;
    private TextBox txtChi;
    private Label label2;
    private Label label1;
    private DataGridView grvSpen;
    private Label label4;
    private GroupBox groupBox2;
    private DateTimePicker dateTimePicker1;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;

    public AddSpending(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
    }

    private void grvSpeningData()
    {
      DateTime dateTime1 = this.dateTimePicker1.Value;
      DateTime dateTime2 = dateTime1.AddDays(1.0);
      DateTime dt1 = new DateTime(dateTime1.Year, dateTime1.Month, dateTime1.Day, 5, 0, 0);
      DateTime dt2 = new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day, 5, 0, 0);
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.grvSpen.DataSource = (object) smallHotelManager.Spending.Where<Spending>((Expression<Func<Spending, bool>>) (s => s.SpendDate >= (DateTime?) dt1 && s.SpendDate <= (DateTime?) dt2 && s.SpendDate.HasValue)).Select(s => new
      {
        reas = s.Reasson,
        cost = (int) s.Cost * 1000
      });
      smallHotelManager.Connection.Close();
    }

    private void AddNew(string reason, int cost, DateTime date)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.rm = new Spending()
      {
        Reasson = reason,
        Cost = new int?(cost),
        SpendDate = new DateTime?(date)
      };
      smallHotelManager.Spending.InsertOnSubmit(this.rm);
      try
      {
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
      smallHotelManager.Connection.Close();
    }

    private void AddSpending_FormClosing(object sender, FormClosingEventArgs e)
    {
      this._parent.grvSpendingData();
      this.Dispose();
    }

    private void AddSpending_Load(object sender, EventArgs e) => this.grvSpeningData();

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        string reason = this.txtChi.Text.ToString();
        int cost = int.Parse(this.txtPrice.Text.ToString());
        if (cost < 0)
          throw new Exception();
        DateTime now = DateTime.Now;
        this.AddNew(reason, cost, now);
        int num = (int) MessageBox.Show("Thêm khoản chi thành công!!!");
        this.grvSpeningData();
      }
      catch
      {
        int num = (int) MessageBox.Show("Số tiền chỉ được phép nhập số và phải lớn hơn 0.\n Xin vui lòng thử lại!!!");
        this.txtPrice.Text = "";
      }
    }

    private void button2_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddSpending));
      this.groupBox1 = new GroupBox();
      this.label3 = new Label();
      this.button2 = new Button();
      this.btnSave = new Button();
      this.txtPrice = new TextBox();
      this.txtChi = new TextBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.grvSpen = new DataGridView();
      this.label4 = new Label();
      this.groupBox2 = new GroupBox();
      this.dateTimePicker1 = new DateTimePicker();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.grvSpen).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.button2);
      this.groupBox1.Controls.Add((Control) this.btnSave);
      this.groupBox1.Controls.Add((Control) this.txtPrice);
      this.groupBox1.Controls.Add((Control) this.txtChi);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(12, 15);
      this.groupBox1.Margin = new Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new Padding(4, 4, 4, 4);
      this.groupBox1.Size = new Size(444, 252);
      this.groupBox1.TabIndex = 26;
      this.groupBox1.TabStop = false;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(305, 108);
      this.label3.Margin = new Padding(7, 0, 7, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(71, 16);
      this.label3.TabIndex = 27;
      this.label3.Text = "(.000 VNĐ)";
      this.button2.BackColor = SystemColors.GradientInactiveCaption;
      this.button2.Location = new Point(256, 185);
      this.button2.Margin = new Padding(7, 6, 7, 6);
      this.button2.Name = "button2";
      this.button2.Size = new Size(177, 57);
      this.button2.TabIndex = 24;
      this.button2.Text = "Thoát";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.btnSave.BackColor = SystemColors.GradientInactiveCaption;
      this.btnSave.Location = new Point(16, 185);
      this.btnSave.Margin = new Padding(7, 6, 7, 6);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(177, 57);
      this.btnSave.TabIndex = 23;
      this.btnSave.Text = "Lưu";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.txtPrice.Location = new Point(136, 108);
      this.txtPrice.Margin = new Padding(7, 6, 7, 6);
      this.txtPrice.Name = "txtPrice";
      this.txtPrice.Size = new Size(155, 22);
      this.txtPrice.TabIndex = 22;
      this.txtChi.Location = new Point(136, 23);
      this.txtChi.Margin = new Padding(7, 6, 7, 6);
      this.txtChi.Name = "txtChi";
      this.txtChi.Size = new Size(296, 22);
      this.txtChi.TabIndex = 21;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(13, 108);
      this.label2.Margin = new Padding(7, 0, 7, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(55, 16);
      this.label2.TabIndex = 26;
      this.label2.Text = "Số Tiền";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(13, 23);
      this.label1.Margin = new Padding(7, 0, 7, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(68, 16);
      this.label1.TabIndex = 25;
      this.label1.Text = "Khoản Chi";
      this.grvSpen.BackgroundColor = SystemColors.ButtonHighlight;
      this.grvSpen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvSpen.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2);
      this.grvSpen.Location = new Point(9, 52);
      this.grvSpen.Margin = new Padding(5, 5, 5, 5);
      this.grvSpen.Name = "grvSpen";
      this.grvSpen.RowHeadersVisible = false;
      this.grvSpen.Size = new Size(298, 191);
      this.grvSpen.TabIndex = 25;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(19, 23);
      this.label4.Margin = new Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(72, 16);
      this.label4.TabIndex = 26;
      this.label4.Text = "Chọn ngày";
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Controls.Add((Control) this.grvSpen);
      this.groupBox2.Controls.Add((Control) this.dateTimePicker1);
      this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.Location = new Point(464, 15);
      this.groupBox2.Margin = new Padding(4, 4, 4, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new Padding(4, 4, 4, 4);
      this.groupBox2.Size = new Size(316, 252);
      this.groupBox2.TabIndex = 27;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Thống kê";
      this.dateTimePicker1.CustomFormat = "dd/MM/yy";
      this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker1.Location = new Point(142, 21);
      this.dateTimePicker1.Margin = new Padding(5, 5, 5, 5);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new Size(153, 22);
      this.dateTimePicker1.TabIndex = 24;
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column1.DataPropertyName = "reas";
      this.Column1.HeaderText = "Khoản Chi";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column2.DataPropertyName = "cost";
      this.Column2.HeaderText = "Số tiền";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(788, 275);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox2);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(804, 314);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(804, 314);
      this.Name = nameof (AddSpending);
      this.Text = "Khoản chi trong ngày";
      this.FormClosing += new FormClosingEventHandler(this.AddSpending_FormClosing);
      this.Load += new EventHandler(this.AddSpending_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.grvSpen).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
