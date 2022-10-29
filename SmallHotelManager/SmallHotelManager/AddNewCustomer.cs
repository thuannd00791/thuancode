// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AddNewCustomer
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
  public class AddNewCustomer : Form
  {
    private CustomerReport _parent;
    private int _cusid = 0;
    private IContainer components = (IContainer) null;
    private Label label22;
    private TextBox txtPhoneNum;
    private Button btnCancel;
    private Button btnSave;
    private Label label20;
    private ComboBox comboBox2;
    private Label label18;
    private TextBox txtIdNo;
    private TextBox txtAddress;
    private TextBox txtCompany;
    private TextBox txtName;
    private Label label17;
    private Label label16;
    private Label label15;
    private ErrorProvider errorProvider1;
    private Label label1;
    private TextBox txtRoomNo;
    private Label label2;
    private DateTimePicker dateTimePicker1;

    public int CusId
    {
      get => this._cusid;
      set => this._cusid = value;
    }

    public AddNewCustomer(CustomerReport parent)
    {
      this.InitializeComponent();
      this._parent = parent;
      this.GetNational();
    }

    private void AddNewCustomer_Load(object sender, EventArgs e)
    {
      if (this._cusid == 0)
        return;
      this.Text = "Chỉnh sửa thông tin khách hàng";
      this.btnSave.Text = "Lưu";
      this.GetCusInfo();
    }

    private void GetCusInfo()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      try
      {
        Customer customer = smallHotelManager.Customer.Where<Customer>((Expression<Func<Customer, bool>>) (x => x.CusID == this._cusid)).Single<Customer>();
        this.txtName.Text = customer.CusName.ToString();
        this.comboBox2.SelectedValue = (object) customer.NationalID;
        this.txtAddress.Text = customer.Address.ToString();
        this.txtCompany.Text = customer.Company.ToString();
        this.txtIdNo.Text = customer.IdNo.ToString();
        this.txtPhoneNum.Text = customer.CusPhone.ToString();
        this.txtRoomNo.Text = customer.RoomNo.ToString();
        this.dateTimePicker1.Value = customer.CITime.Value;
      }
      catch (Exception ex)
      {
        return;
      }
      smallHotelManager.Connection.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._cusid == 0)
      {
        Customer entity = new Customer()
        {
          CusName = this.txtName.Text.ToString(),
          NationalID = new int?((int) this.comboBox2.SelectedValue),
          Company = this.txtCompany.Text.ToString(),
          Address = this.txtAddress.Text.ToString(),
          IdNo = this.txtIdNo.Text.ToString(),
          CusPhone = this.txtPhoneNum.Text.ToString(),
          RoomNo = this.txtRoomNo.Text.ToString(),
          CITime = new DateTime?(this.dateTimePicker1.Value.Date)
        };
        smallHotelManager.Customer.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
        this.Close();
      }
      else
      {
        Customer customer = smallHotelManager.Customer.Single<Customer>((Expression<Func<Customer, bool>>) (r => r.CusID == this._cusid));
        customer.CusName = this.txtName.Text.ToString();
        customer.NationalID = new int?((int) this.comboBox2.SelectedValue);
        customer.Company = this.txtCompany.Text.ToString();
        customer.Address = this.txtAddress.Text.ToString();
        customer.IdNo = this.txtIdNo.Text.ToString();
        customer.CusPhone = this.txtPhoneNum.Text.ToString();
        customer.RoomNo = this.txtRoomNo.Text.ToString();
        customer.CITime = new DateTime?(this.dateTimePicker1.Value.Date);
        smallHotelManager.SubmitChanges();
        this.Close();
      }
      smallHotelManager.Connection.Close();
    }

    private void GetNational()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.comboBox2.DataSource = (object) smallHotelManager.National.Where<National>((Expression<Func<National, bool>>) (n => n.IsDelete == (int?) 0)).Select(n => new
      {
        Nation = n.Nation,
        NationalID = n.NationalID
      });
      this.comboBox2.DisplayMember = "Nation";
      this.comboBox2.ValueMember = "NationalID";
      smallHotelManager.Connection.Close();
    }

    private void AddNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
    {
      this._parent.performRefresh();
      this.Dispose();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddNewCustomer));
      this.label22 = new Label();
      this.txtPhoneNum = new TextBox();
      this.btnCancel = new Button();
      this.btnSave = new Button();
      this.label20 = new Label();
      this.comboBox2 = new ComboBox();
      this.label18 = new Label();
      this.txtIdNo = new TextBox();
      this.txtAddress = new TextBox();
      this.txtCompany = new TextBox();
      this.txtName = new TextBox();
      this.label17 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      this.errorProvider1 = new ErrorProvider(this.components);
      this.label1 = new Label();
      this.txtRoomNo = new TextBox();
      this.dateTimePicker1 = new DateTimePicker();
      this.label2 = new Label();
      ((ISupportInitialize) this.errorProvider1).BeginInit();
      this.SuspendLayout();
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.Location = new Point(15, 157);
      this.label22.Name = "label22";
      this.label22.Size = new Size(35, 16);
      this.label22.TabIndex = 41;
      this.label22.Text = "SĐT";
      this.txtPhoneNum.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhoneNum.Location = new Point(73, 154);
      this.txtPhoneNum.Name = "txtPhoneNum";
      this.txtPhoneNum.Size = new Size(149, 22);
      this.txtPhoneNum.TabIndex = 33;
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(183, 239);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(100, 26);
      this.btnCancel.TabIndex = 37;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnSave.BackColor = SystemColors.GradientInactiveCaption;
      this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Location = new Point(18, 239);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(96, 26);
      this.btnSave.TabIndex = 36;
      this.btnSave.Text = "Lưu";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.Location = new Point(15, 43);
      this.label20.Name = "label20";
      this.label20.Size = new Size(63, 16);
      this.label20.TabIndex = 40;
      this.label20.Text = "Quốc tịch";
      this.comboBox2.BackColor = SystemColors.GradientInactiveCaption;
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(82, 40);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(140, 24);
      this.comboBox2.TabIndex = 29;
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.Location = new Point(15, 129);
      this.label18.Name = "label18";
      this.label18.Size = new Size(57, 16);
      this.label18.TabIndex = 39;
      this.label18.Text = "CMTND";
      this.txtIdNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtIdNo.Location = new Point(73, 126);
      this.txtIdNo.Name = "txtIdNo";
      this.txtIdNo.Size = new Size(149, 22);
      this.txtIdNo.TabIndex = 32;
      this.txtAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAddress.Location = new Point(73, 98);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new Size(210, 22);
      this.txtAddress.TabIndex = 31;
      this.txtCompany.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCompany.Location = new Point(73, 70);
      this.txtCompany.Name = "txtCompany";
      this.txtCompany.Size = new Size(210, 22);
      this.txtCompany.TabIndex = 30;
      this.txtName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtName.Location = new Point(73, 11);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(210, 22);
      this.txtName.TabIndex = 28;
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.Location = new Point(15, 101);
      this.label17.Name = "label17";
      this.label17.Size = new Size(48, 16);
      this.label17.TabIndex = 38;
      this.label17.Text = "Địa chỉ";
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.Location = new Point(15, 73);
      this.label16.Name = "label16";
      this.label16.Size = new Size(53, 16);
      this.label16.TabIndex = 37;
      this.label16.Text = "Công ty";
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.Location = new Point(15, 14);
      this.label15.Name = "label15";
      this.label15.Size = new Size(47, 16);
      this.label15.TabIndex = 36;
      this.label15.Text = "Họ tên";
      this.errorProvider1.ContainerControl = (ContainerControl) this;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(15, 185);
      this.label1.Name = "label1";
      this.label1.Size = new Size(47, 16);
      this.label1.TabIndex = 43;
      this.label1.Text = "Phòng";
      this.txtRoomNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRoomNo.Location = new Point(73, 182);
      this.txtRoomNo.Name = "txtRoomNo";
      this.txtRoomNo.Size = new Size(149, 22);
      this.txtRoomNo.TabIndex = 34;
      this.dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.dateTimePicker1.Format = DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new Point(89, 211);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new Size(133, 22);
      this.dateTimePicker1.TabIndex = 35;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(16, 216);
      this.label2.Name = "label2";
      this.label2.Size = new Size(67, 16);
      this.label2.TabIndex = 45;
      this.label2.Text = "Ngày vào";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(313, 270);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.dateTimePicker1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.txtRoomNo);
      this.Controls.Add((Control) this.label22);
      this.Controls.Add((Control) this.txtPhoneNum);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnSave);
      this.Controls.Add((Control) this.label20);
      this.Controls.Add((Control) this.comboBox2);
      this.Controls.Add((Control) this.label18);
      this.Controls.Add((Control) this.txtIdNo);
      this.Controls.Add((Control) this.txtAddress);
      this.Controls.Add((Control) this.txtCompany);
      this.Controls.Add((Control) this.txtName);
      this.Controls.Add((Control) this.label17);
      this.Controls.Add((Control) this.label16);
      this.Controls.Add((Control) this.label15);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(329, 309);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(329, 309);
      this.Name = nameof (AddNewCustomer);
      this.Text = "Thêm mới khách hàng";
      this.FormClosing += new FormClosingEventHandler(this.AddNewCustomer_FormClosing);
      this.Load += new EventHandler(this.AddNewCustomer_Load);
      ((ISupportInitialize) this.errorProvider1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
