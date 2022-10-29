// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.EditUser
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
  public class EditUser : Form
  {
    private UserManager _parent;
    private int _userid = 0;
    private IContainer components = (IContainer) null;
    private Button btnCancel;
    private Button btnAdd;
    private ComboBox cmbGroup;
    private Label label7;
    private TextBox textBox6;
    private Label label6;
    private TextBox textBox5;
    private Label label5;
    private TextBox textBox4;
    private Label label4;
    private TextBox textBox1;
    private Label label3;
    private Button btnChangePass;
    private ErrorProvider errorProvider1;

    public int UserID
    {
      get => this._userid;
      set => this._userid = value;
    }

    public EditUser(UserManager parent)
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
      try
      {
        int selectedValue = (int) this.cmbGroup.SelectedValue;
        string name = this.textBox4.Text.Trim().ToString();
        string str1 = this.textBox5.Text.ToString();
        if (!str1.Equals(""))
        {
          if (!EditUser.checkValidNumber(str1))
          {
            this.errorProvider1.SetError((Control) this.textBox5, "Chỉ được phép nhập số");
            this.textBox5.Text = (string) null;
            return;
          }
          this.errorProvider1.Dispose();
        }
        string str2 = this.textBox6.Text.ToString();
        if (!str1.Equals(""))
        {
          if (!EditUser.checkValidNumber(str2))
          {
            this.errorProvider1.SetError((Control) this.textBox6, "Chỉ được phép nhập số");
            this.textBox6.Text = (string) null;
            return;
          }
          this.errorProvider1.Dispose();
        }
        this.Edition(name, str1, str2, selectedValue);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
        return;
      }
      this._parent.FormRefresh();
    }

    private void Edition(string name, string idNum, string phoneNum, int groupId)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        Users users = smallHotelManager.Users.Single<Users>((Expression<Func<Users, bool>>) (p => p.UserID == this._userid));
        users.Name = name;
        users.IDNumber = idNum;
        users.PhoneNumber = phoneNum;
        users.GroupID = (int) this.cmbGroup.SelectedValue;
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num1 = (int) MessageBox.Show("Chỉnh sửa thành công!!!");
    }

    private void btnChangePass_Click(object sender, EventArgs e)
    {
      int num = (int) new ChangePassword(this._userid).ShowDialog();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void EditUser_Load(object sender, EventArgs e)
    {
      Users users = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").Users.Single<Users>((Expression<Func<Users, bool>>) (u => u.UserID == this._userid));
      this.textBox1.Text = users.UserName.ToString();
      this.textBox4.Text = users.Name;
      this.textBox5.Text = users.IDNumber;
      this.textBox6.Text = users.PhoneNumber;
    }

    private static bool checkValidNumber(string number)
    {
      int length = number.Length;
      return new Regex("^[0-9 ]+$").IsMatch(number);
    }

    private void EditUser_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EditUser));
      this.btnCancel = new Button();
      this.btnAdd = new Button();
      this.cmbGroup = new ComboBox();
      this.label7 = new Label();
      this.textBox6 = new TextBox();
      this.label6 = new Label();
      this.textBox5 = new TextBox();
      this.label5 = new Label();
      this.textBox4 = new TextBox();
      this.label4 = new Label();
      this.textBox1 = new TextBox();
      this.label3 = new Label();
      this.btnChangePass = new Button();
      this.errorProvider1 = new ErrorProvider(this.components);
      ((ISupportInitialize) this.errorProvider1).BeginInit();
      this.SuspendLayout();
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(183, 148);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 40);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(21, 148);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(75, 40);
      this.btnAdd.TabIndex = 6;
      this.btnAdd.Text = "Lưu";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbGroup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbGroup.FormattingEnabled = true;
      this.cmbGroup.Location = new Point(135, 116);
      this.cmbGroup.Name = "cmbGroup";
      this.cmbGroup.Size = new Size(110, 24);
      this.cmbGroup.TabIndex = 5;
      this.label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(87, 119);
      this.label7.Name = "label7";
      this.label7.Size = new Size(44, 16);
      this.label7.TabIndex = 92;
      this.label7.Text = "Nhóm";
      this.textBox6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox6.Location = new Point(134, 89);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(124, 22);
      this.textBox6.TabIndex = 4;
      this.label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(45, 92);
      this.label6.Name = "label6";
      this.label6.Size = new Size(86, 16);
      this.label6.TabIndex = 90;
      this.label6.Text = "Số điện thoại";
      this.textBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox5.Location = new Point(134, 63);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(124, 22);
      this.textBox5.TabIndex = 3;
      this.label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(54, 66);
      this.label5.Name = "label5";
      this.label5.Size = new Size(77, 16);
      this.label5.TabIndex = 88;
      this.label5.Text = "Số CMTND";
      this.textBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox4.Location = new Point(134, 37);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(124, 22);
      this.textBox4.TabIndex = 2;
      this.label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(99, 40);
      this.label4.Name = "label4";
      this.label4.Size = new Size(32, 16);
      this.label4.TabIndex = 86;
      this.label4.Text = "Tên";
      this.textBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox1.Location = new Point(134, 9);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new Size(124, 22);
      this.textBox1.TabIndex = 1;
      this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(63, 9);
      this.label3.Name = "label3";
      this.label3.Size = new Size(68, 16);
      this.label3.TabIndex = 80;
      this.label3.Text = "Tài khoản";
      this.btnChangePass.BackColor = SystemColors.GradientInactiveCaption;
      this.btnChangePass.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnChangePass.Location = new Point(102, 148);
      this.btnChangePass.Name = "btnChangePass";
      this.btnChangePass.Size = new Size(75, 40);
      this.btnChangePass.TabIndex = 7;
      this.btnChangePass.Text = "Đổi mật khẩu";
      this.btnChangePass.UseVisualStyleBackColor = false;
      this.btnChangePass.Click += new EventHandler(this.btnChangePass_Click);
      this.errorProvider1.ContainerControl = (ContainerControl) this;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(284, 200);
      this.Controls.Add((Control) this.btnChangePass);
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
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label3);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(300, 238);
      this.MinimumSize = new Size(300, 238);
      this.Name = nameof (EditUser);
      this.Text = "Sửa thông tin người dùng";
      this.FormClosing += new FormClosingEventHandler(this.EditUser_FormClosing);
      this.Load += new EventHandler(this.EditUser_Load);
      ((ISupportInitialize) this.errorProvider1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
