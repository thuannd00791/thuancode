// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.LoginForm
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class LoginForm : Form
  {
    private Main _parent;
    private IContainer components = (IContainer) null;
    private TextBox txtUserName;
    private TextBox txtPassword;
    private Label label1;
    private Label label2;
    private Button btnLogin;
    private Button btnCancel;
    private Label lblError;
    private PictureBox pictureBox1;
    private Label label3;
    private Label label4;
    private Label label6;

    public LoginForm(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
    }

    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.Dispose();
      this.pictureBox1.Image.Dispose();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Dispose();
      this.pictureBox1.Image.Dispose();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      string userName = (string) null;
      userName = this.txtUserName.Text.ToString();
      string str = this.txtPassword.Text.ToString();
      IQueryable<Users> source = smallHotelManager.Users.Where<Users>((Expression<Func<Users, bool>>) (u => u.UserName == userName));
      Expression<Func<Users, \u003C\u003Ef__AnonymousType4d<string, string, int, int>>> selector = u => new
      {
        Name = u.Name,
        Password = u.Password,
        GroupID = u.GroupID,
        UserID = u.UserID
      };
      foreach (var data in source.Select(selector))
      {
        if (data.Password.Trim().Equals(str))
        {
          this._parent.IsLogin = 1;
          this._parent.USERID = data.UserID;
          this._parent.UserType = data.GroupID;
          this._parent.NAME = data.Name;
          this._parent.getLogin();
          this.Dispose();
        }
        else
          this.lblError.Visible = true;
      }
    }

    private static string GetMd5Hash(MD5 md5Hash, string input)
    {
      byte[] hash = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 0; index < hash.Length; ++index)
        stringBuilder.Append(hash[index].ToString("x2"));
      return stringBuilder.ToString();
    }

    private static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash) => 0 == StringComparer.OrdinalIgnoreCase.Compare(LoginForm.GetMd5Hash(md5Hash, input), hash);

    private void LoginForm_Load(object sender, EventArgs e)
    {
      this.pictureBox1.Visible = true;
      string filename = Directory.GetCurrentDirectory() + "\\Logo\\logo.png";
      this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox1.Image = Image.FromFile(filename);
      HotelInformation hotelInformation = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").HotelInformation.Single<HotelInformation>((Expression<Func<HotelInformation, bool>>) (d => d.ID == 1));
      this.label6.Text = hotelInformation.HotelName.ToString();
      this.label3.Text = hotelInformation.Adress.ToString();
      this.label4.Text = hotelInformation.PhoneNumber1.ToString() + " - " + hotelInformation.PhoneNumber2.ToString();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LoginForm));
      this.txtUserName = new TextBox();
      this.txtPassword = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.btnLogin = new Button();
      this.btnCancel = new Button();
      this.lblError = new Label();
      this.pictureBox1 = new PictureBox();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label6 = new Label();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.txtUserName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtUserName.Location = new Point(305, 53);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new Size(140, 22);
      this.txtUserName.TabIndex = 1;
      this.txtPassword.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPassword.Location = new Point(305, 88);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new Size(140, 22);
      this.txtPassword.TabIndex = 2;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(204, 56);
      this.label1.Name = "label1";
      this.label1.Size = new Size(99, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Tên đăng nhập";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(204, 94);
      this.label2.Name = "label2";
      this.label2.Size = new Size(62, 16);
      this.label2.TabIndex = 3;
      this.label2.Text = "Mật khẩu";
      this.btnLogin.BackColor = SystemColors.GradientInactiveCaption;
      this.btnLogin.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnLogin.Location = new Point(214, 134);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new Size(89, 33);
      this.btnLogin.TabIndex = 3;
      this.btnLogin.Text = "Đăng nhập";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(354, 134);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(89, 33);
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.lblError.AutoSize = true;
      this.lblError.ForeColor = Color.Red;
      this.lblError.Location = new Point(211, 118);
      this.lblError.Name = "lblError";
      this.lblError.Size = new Size(219, 13);
      this.lblError.TabIndex = 6;
      this.lblError.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
      this.lblError.Visible = false;
      this.pictureBox1.Location = new Point(12, 44);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(180, 134);
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(12, 181);
      this.label3.Name = "label3";
      this.label3.Size = new Size(66, 16);
      this.label3.TabIndex = 8;
      this.label3.Text = "lblName";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(12, 206);
      this.label4.Name = "label4";
      this.label4.Size = new Size(69, 16);
      this.label4.TabIndex = 9;
      this.label4.Text = "lblPhone";
      this.label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Ravie", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.Red;
      this.label6.Location = new Point(121, 11);
      this.label6.Name = "label6";
      this.label6.Size = new Size(104, 30);
      this.label6.TabIndex = 11;
      this.label6.Text = "label6";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(462, 230);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.lblError);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnLogin);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.txtPassword);
      this.Controls.Add((Control) this.txtUserName);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(478, 269);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(478, 269);
      this.Name = nameof (LoginForm);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Đăng nhập";
      this.FormClosing += new FormClosingEventHandler(this.LoginForm_FormClosing);
      this.Load += new EventHandler(this.LoginForm_Load);
      this.DragEnter += new DragEventHandler(this.btnLogin_Click);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
