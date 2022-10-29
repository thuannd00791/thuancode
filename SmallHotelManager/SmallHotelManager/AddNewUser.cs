// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AddNewUser
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class AddNewUser : Form
  {
    private UserManager _parent;
    private IContainer components = (IContainer) null;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label1;
    private TextBox textBox3;
    private Label label2;
    private TextBox textBox4;
    private Label label4;
    private TextBox textBox5;
    private Label label5;
    private ErrorProvider errorProvider1;
    private TextBox textBox6;
    private Label label6;
    private Button btnCancel;
    private Button btnAdd;
    private ComboBox cmbGroup;
    private Label label7;

    public AddNewUser(UserManager parent)
    {
      this._parent = parent;
      this.InitializeComponent();
      this.cmbGetData();
    }

    private void cmbGetData()
    {
      this.cmbGroup.DataSource = (object) new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").GroupUser.Where<GroupUser>((Expression<Func<GroupUser, bool>>) (g => g.GroupID > 1)).Select(g => new
      {
        GroupID = g.GroupID,
        GroupName = g.GroupName
      });
      this.cmbGroup.DisplayMember = "GroupName";
      this.cmbGroup.ValueMember = "GroupID";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      string str1 = this.textBox1.Text.Trim().ToString();
      string pass1 = this.textBox2.Text.Trim().ToString();
      string pass2 = this.textBox3.Text.Trim().ToString();
      string name = !this.textBox4.Text.Equals("") ? this.textBox4.Text.Trim().ToString() : (string) null;
      string str2 = this.textBox5.Text.Trim().ToString();
      if (!str2.Equals(""))
      {
        if (!AddNewUser.checkValidNumber(str2))
        {
          this.errorProvider1.SetError((Control) this.textBox5, "Chỉ được phép nhập số");
          this.textBox5.Text = (string) null;
          return;
        }
        this.errorProvider1.Dispose();
      }
      string str3 = this.textBox6.Text.Trim().ToString();
      if (!str3.Equals(""))
      {
        if (!AddNewUser.checkValidNumber(str3))
        {
          this.errorProvider1.SetError((Control) this.textBox6, "Chỉ được phép nhập số");
          this.textBox6.Text = (string) null;
          return;
        }
        this.errorProvider1.Dispose();
      }
      int selectedValue = (int) this.cmbGroup.SelectedValue;
      if (!AddNewUser.checkUserName(str1))
      {
        this.errorProvider1.SetError((Control) this.textBox1, "Độ dài của chuỗi phải từ 6 đến 30 ký tự\n. Và chỉ được phép nhập số, chữ cái, @, _");
        this.textBox1.Text = (string) null;
      }
      else
      {
        this.errorProvider1.Dispose();
        if (!AddNewUser.checkPass(pass1))
        {
          this.errorProvider1.SetError((Control) this.textBox2, "Độ dài của chuỗi phải từ 6 đến 30 ký tự\n. Và chỉ được phép nhập số và chữ cái");
          this.textBox2.Text = (string) null;
        }
        else
        {
          this.errorProvider1.Dispose();
          if (!AddNewUser.checkPass(pass2))
          {
            this.errorProvider1.SetError((Control) this.textBox3, "Độ dài của chuỗi phải từ 6 đến 30 ký tự\n. Và chỉ được phép nhập số và chữ cái");
            this.textBox3.Text = (string) null;
          }
          else
          {
            this.errorProvider1.Dispose();
            if (!pass1.Equals(pass2))
            {
              this.errorProvider1.SetError((Control) this.textBox3, "Mật khẩu xác nhận phải giống Mật khẩu");
              this.textBox2.Text = (string) null;
              this.textBox3.Text = (string) null;
            }
            else
            {
              this.errorProvider1.Dispose();
              if (!this.IsExistUserName(str1))
              {
                this.AddNew(str1, pass1, name, str3, str2, selectedValue);
                this._parent.FormRefresh();
              }
              else
              {
                int num = (int) MessageBox.Show("Tài khoản này đã tồn tại.\n Xin vui lòng thử lại!!!");
              }
            }
          }
        }
      }
    }

    private void AddNew(
      string userName,
      string pass,
      string name,
      string phoneNum,
      string idNum,
      int groupID)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        Users entity = new Users()
        {
          UserName = userName.ToString(),
          Password = pass,
          GroupID = groupID
        };
        if (name != null)
          entity.Name = name;
        if (idNum != null)
          entity.IDNumber = idNum;
        if (phoneNum != null)
          entity.PhoneNumber = phoneNum;
        smallHotelManager.Users.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num1 = (int) MessageBox.Show("Thêm người dùng thành công!!!");
    }

    private bool IsExistUserName(string userName) => new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").Users.Count<Users>((Expression<Func<Users, bool>>) (q => q.UserName == userName)) > 0;

    private static bool checkUserName(string username)
    {
      int length = username.Length;
      bool flag = new Regex("^[a-zA-Z0-9_@]+$").IsMatch(username);
      return length >= 6 && length <= 30 && flag;
    }

    private static bool checkPass(string pass)
    {
      int length = pass.Length;
      bool flag = new Regex("^[a-zA-Z0-9]+$").IsMatch(pass);
      return length >= 6 && length <= 30 && flag;
    }

    private static bool checkValidNumber(string number)
    {
      int length = number.Length;
      return new Regex("^[0-9 ]+$").IsMatch(number);
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void AddNewUser_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddNewUser));
      this.label3 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.label1 = new Label();
      this.textBox3 = new TextBox();
      this.label2 = new Label();
      this.textBox4 = new TextBox();
      this.label4 = new Label();
      this.textBox5 = new TextBox();
      this.label5 = new Label();
      this.errorProvider1 = new ErrorProvider(this.components);
      this.textBox6 = new TextBox();
      this.label6 = new Label();
      this.label7 = new Label();
      this.cmbGroup = new ComboBox();
      this.btnAdd = new Button();
      this.btnCancel = new Button();
      ((ISupportInitialize) this.errorProvider1).BeginInit();
      this.SuspendLayout();
      this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(56, 12);
      this.label3.Name = "label3";
      this.label3.Size = new Size(68, 16);
      this.label3.TabIndex = 64;
      this.label3.Text = "Tài khoản";
      this.textBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox1.Location = new Point((int) sbyte.MaxValue, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(124, 22);
      this.textBox1.TabIndex = 1;
      this.textBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox2.Location = new Point((int) sbyte.MaxValue, 38);
      this.textBox2.Name = "textBox2";
      this.textBox2.PasswordChar = '*';
      this.textBox2.Size = new Size(124, 22);
      this.textBox2.TabIndex = 2;
      this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(62, 41);
      this.label1.Name = "label1";
      this.label1.Size = new Size(62, 16);
      this.label1.TabIndex = 66;
      this.label1.Text = "Mật khẩu";
      this.textBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox3.Location = new Point((int) sbyte.MaxValue, 64);
      this.textBox3.Name = "textBox3";
      this.textBox3.PasswordChar = '*';
      this.textBox3.Size = new Size(124, 22);
      this.textBox3.TabIndex = 3;
      this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(4, 67);
      this.label2.Name = "label2";
      this.label2.Size = new Size(120, 16);
      this.label2.TabIndex = 68;
      this.label2.Text = "Xác nhận mật khẩu";
      this.textBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox4.Location = new Point((int) sbyte.MaxValue, 90);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(124, 22);
      this.textBox4.TabIndex = 4;
      this.label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(92, 93);
      this.label4.Name = "label4";
      this.label4.Size = new Size(32, 16);
      this.label4.TabIndex = 70;
      this.label4.Text = "Tên";
      this.textBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox5.Location = new Point((int) sbyte.MaxValue, 116);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(124, 22);
      this.textBox5.TabIndex = 5;
      this.label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(47, 119);
      this.label5.Name = "label5";
      this.label5.Size = new Size(77, 16);
      this.label5.TabIndex = 72;
      this.label5.Text = "Số CMTND";
      this.errorProvider1.ContainerControl = (ContainerControl) this;
      this.errorProvider1.DataMember = "textBox1";
      this.textBox6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox6.Location = new Point((int) sbyte.MaxValue, 142);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(124, 22);
      this.textBox6.TabIndex = 6;
      this.label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(38, 145);
      this.label6.Name = "label6";
      this.label6.Size = new Size(86, 16);
      this.label6.TabIndex = 74;
      this.label6.Text = "Số điện thoại";
      this.label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(80, 172);
      this.label7.Name = "label7";
      this.label7.Size = new Size(44, 16);
      this.label7.TabIndex = 76;
      this.label7.Text = "Nhóm";
      this.cmbGroup.BackColor = SystemColors.GradientInactiveCaption;
      this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbGroup.FormattingEnabled = true;
      this.cmbGroup.Location = new Point(128, 169);
      this.cmbGroup.Name = "cmbGroup";
      this.cmbGroup.Size = new Size(110, 24);
      this.cmbGroup.TabIndex = 7;
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Location = new Point(41, 201);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(75, 38);
      this.btnAdd.TabIndex = 8;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Location = new Point(145, 201);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 38);
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(274, 251);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnAdd);
      this.Controls.Add((Control) this.cmbGroup);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.textBox6);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label3);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(290, 289);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(290, 289);
      this.Name = nameof (AddNewUser);
      this.Text = "Thêm người dùng";
      this.FormClosing += new FormClosingEventHandler(this.AddNewUser_FormClosing);
      ((ISupportInitialize) this.errorProvider1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
