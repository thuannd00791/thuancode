// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AddNewService
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
  public class AddNewService : Form
  {
    private IContainer components = (IContainer) null;
    private Label label4;
    private Button button2;
    private Button btnSave;
    private TextBox txtNumber;
    private TextBox txtPrice;
    private TextBox txtName;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox txtOtherName;
    private Label label5;
    private int _serviceid = 0;
    private ServicesManager _parent;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddNewService));
      this.label4 = new Label();
      this.button2 = new Button();
      this.btnSave = new Button();
      this.txtNumber = new TextBox();
      this.txtPrice = new TextBox();
      this.txtName = new TextBox();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.txtOtherName = new TextBox();
      this.label5 = new Label();
      this.SuspendLayout();
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(188, 69);
      this.label4.Name = "label4";
      this.label4.Size = new Size(71, 16);
      this.label4.TabIndex = 26;
      this.label4.Text = "(.000 VNĐ)";
      this.button2.BackColor = SystemColors.GradientInactiveCaption;
      this.button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.button2.Location = new Point(107, 138);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 32);
      this.button2.TabIndex = 6;
      this.button2.Text = "Hủy";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.btnSave.BackColor = SystemColors.GradientInactiveCaption;
      this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Location = new Point(7, 138);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(75, 33);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "Lưu";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.txtNumber.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNumber.Location = new Point(107, 94);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new Size(75, 22);
      this.txtNumber.TabIndex = 4;
      this.txtPrice.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtPrice.Location = new Point(107, 66);
      this.txtPrice.Name = "txtPrice";
      this.txtPrice.Size = new Size(75, 22);
      this.txtPrice.TabIndex = 3;
      this.txtName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtName.Location = new Point(107, 10);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(152, 22);
      this.txtName.TabIndex = 1;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(13, 100);
      this.label3.Name = "label3";
      this.label3.Size = new Size(73, 16);
      this.label3.TabIndex = 20;
      this.label3.Text = "Số Lượng";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(13, 69);
      this.label2.Name = "label2";
      this.label2.Size = new Size(32, 16);
      this.label2.TabIndex = 19;
      this.label2.Text = "Giá";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(9, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(92, 16);
      this.label1.TabIndex = 18;
      this.label1.Text = "Tên Dịch Vụ";
      this.txtOtherName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtOtherName.Location = new Point(107, 38);
      this.txtOtherName.Name = "txtOtherName";
      this.txtOtherName.Size = new Size(152, 22);
      this.txtOtherName.TabIndex = 2;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(9, 41);
      this.label5.Name = "label5";
      this.label5.Size = new Size(72, 16);
      this.label5.TabIndex = 28;
      this.label5.Text = "Tên khác";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(266, 177);
      this.Controls.Add((Control) this.txtOtherName);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.btnSave);
      this.Controls.Add((Control) this.txtNumber);
      this.Controls.Add((Control) this.txtPrice);
      this.Controls.Add((Control) this.txtName);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(282, 216);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(282, 216);
      this.Name = nameof (AddNewService);
      this.Text = "Quản lý dịch vụ";
      this.FormClosing += new FormClosingEventHandler(this.AddNewService_FormClosing);
      this.Load += new EventHandler(this.AddNewService_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public AddNewService(ServicesManager parent)
    {
      this.InitializeComponent();
      this._parent = parent;
    }

    public int ServiceID
    {
      set => this._serviceid = value;
      get => this._serviceid;
    }

    private void AddNew(string name, string othername, int price, int totalNumber)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      Services entity = new Services()
      {
        Name = name,
        OtherName = othername,
        Price = new int?(price),
        StoreNum = new int?(totalNumber),
        LastImport = new DateTime?(DateTime.Now),
        UserID = new int?(this._parent.UserID)
      };
      smallHotelManager.Services.InsertOnSubmit(entity);
      try
      {
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void Edition(string name, string othername, int price, int number)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        Services services = smallHotelManager.Services.Single<Services>((Expression<Func<Services, bool>>) (p => p.ServiceID == this._serviceid));
        services.Name = name;
        services.OtherName = othername;
        services.Price = new int?(price);
        services.StoreNum = new int?(number);
        services.LastImport = new DateTime?(DateTime.Now);
        services.UserID = new int?(this._parent.UserID);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void button2_Click(object sender, EventArgs e) => this.Dispose();

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.txtName.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập tên Dịch Vụ");
        this.txtName.Focus();
      }
      else if (string.IsNullOrEmpty(this.txtOtherName.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập tên khác");
        this.txtOtherName.Focus();
      }
      else if (string.IsNullOrEmpty(this.txtPrice.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập giá Dịch Vụ");
        this.txtPrice.Focus();
      }
      else if (string.IsNullOrEmpty(this.txtNumber.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập số lượng Dịch Vụ");
        this.txtNumber.Focus();
      }
      else
      {
        try
        {
          if (Convert.ToInt32(this.txtPrice.Text) < 0)
          {
            int num = (int) MessageBox.Show("Vui lòng nhập giá Dịch Vụ > 0");
            this.txtPrice.Focus();
            return;
          }
        }
        catch
        {
          int num = (int) MessageBox.Show("Giá Dịch Vụ chỉ được phép nhập số.\n Xin vui lòng thử lại!!!");
          this.txtPrice.Text = "";
          return;
        }
        try
        {
          if (Convert.ToInt32(this.txtNumber.Text) < 0)
          {
            int num = (int) MessageBox.Show("Vui lòng nhập số lượng Dịch Vụ > 0");
            this.txtNumber.Focus();
            return;
          }
        }
        catch
        {
          int num = (int) MessageBox.Show("Số lượng Dịch Vụ chỉ được phép nhập số.\n Xin vui lòng thử lại!!!");
          this.txtNumber.Text = "";
          return;
        }
        string name = this.txtName.Text.ToString();
        string othername = this.txtOtherName.Text.ToString();
        int price = int.Parse(this.txtPrice.Text.ToString());
        int num1 = int.Parse(this.txtNumber.Text.ToString());
        DateTime now = DateTime.Now;
        int userId = this._parent.UserID;
        if (!this.IsExistRoom(this.ServiceID))
        {
          if (this._serviceid == 0)
            this.AddNew(name, othername, price, num1);
          else
            this.Edition(name, othername, price, num1);
          new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").Connection.Close();
          if (this._serviceid == 0)
          {
            int num2 = (int) MessageBox.Show("Thêm Dịch Vụ thành công!!!");
          }
          else
          {
            int num3 = (int) MessageBox.Show("Chỉnh Sửa Dịch Vụ thành công!!!");
          }
          this.Close();
          this._parent.FormRefresh();
        }
        else
        {
          int num4 = (int) MessageBox.Show("Dịch Vụ này đã tồn tại.\n Xin vui lòng thử lại!!!");
        }
      }
    }

    private void AddNewService_Load(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._serviceid == 0)
        return;
      this.txtName.ReadOnly = true;
      this.Text = "Chỉnh sửa Dịch Vụ";
      this.btnSave.Text = "Lưu";
      Services services = smallHotelManager.Services.Single<Services>((Expression<Func<Services, bool>>) (d => d.ServiceID == this._serviceid));
      this.txtName.Text = services.Name.ToString();
      if (services.OtherName != null)
        this.txtOtherName.Text = services.OtherName.ToString();
      TextBox txtPrice = this.txtPrice;
      int? nullable = services.Price;
      string str1 = nullable.ToString();
      txtPrice.Text = str1;
      TextBox txtNumber = this.txtNumber;
      nullable = services.StoreNum;
      string str2 = nullable.ToString();
      txtNumber.Text = str2;
    }

    private bool IsExistRoom(int serviceID)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._serviceid == 0)
      {
        if (smallHotelManager.Services.Count<Services>((Expression<Func<Services, bool>>) (q => q.ServiceID.Equals(serviceID.ToString()))) > 0)
          return true;
      }
      else if (smallHotelManager.Services.Count<Services>((Expression<Func<Services, bool>>) (q => q.ServiceID.Equals(serviceID.ToString()) && q.ServiceID != this._serviceid)) > 0)
        return true;
      return false;
    }

    private void AddNewService_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();
  }
}
