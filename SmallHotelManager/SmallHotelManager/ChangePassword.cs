// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.ChangePassword
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
  public class ChangePassword : Form
  {
    private int _userid;
    private IContainer components = (IContainer) null;
    private TextBox textBox2;
    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private Button btnSave;
    private Button btnCancel;
    private ErrorProvider errorProvider1;

    public ChangePassword(int userid)
    {
      this._userid = userid;
      this.InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void btnSave_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      string pass1 = this.textBox1.Text.Trim().ToString();
      string pass2 = this.textBox2.Text.Trim().ToString();
      if (!ChangePassword.checkPass(pass1))
      {
        this.errorProvider1.SetError((Control) this.textBox1, "Độ dài của chuỗi phải từ 6 đến 30 ký tự\n. Và chỉ được phép nhập số và chữ cái");
        this.textBox1.Text = (string) null;
      }
      else
      {
        this.errorProvider1.Dispose();
        if (!ChangePassword.checkPass(pass2))
        {
          this.errorProvider1.SetError((Control) this.textBox2, "Độ dài của chuỗi phải từ 6 đến 30 ký tự\n. Và chỉ được phép nhập số và chữ cái");
          this.textBox2.Text = (string) null;
        }
        else if (!pass1.Equals(pass2))
        {
          this.errorProvider1.SetError((Control) this.textBox2, "Mật khẩu xác nhận phải giống Mật khẩu");
          this.textBox1.Text = (string) null;
          this.textBox2.Text = (string) null;
        }
        else
        {
          this.errorProvider1.Dispose();
          smallHotelManager.Users.Single<Users>((Expression<Func<Users, bool>>) (p => p.UserID == this._userid)).Password = pass1;
          smallHotelManager.SubmitChanges();
          int num = (int) MessageBox.Show("Đổi mật khẩu thành công");
          this.Dispose();
        }
      }
    }

    private static bool checkPass(string pass)
    {
      int length = pass.Length;
      bool flag = new Regex("^[a-zA-Z0-9]+$").IsMatch(pass);
      return length >= 6 && length <= 30 && flag;
    }

    private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ChangePassword));
      this.textBox2 = new TextBox();
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.label2 = new Label();
      this.btnSave = new Button();
      this.btnCancel = new Button();
      this.errorProvider1 = new ErrorProvider(this.components);
      ((ISupportInitialize) this.errorProvider1).BeginInit();
      this.SuspendLayout();
      this.textBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox2.Location = new Point(138, 12);
      this.textBox2.Name = "textBox2";
      this.textBox2.PasswordChar = '*';
      this.textBox2.Size = new Size(124, 22);
      this.textBox2.TabIndex = 1;
      this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(45, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(87, 16);
      this.label1.TabIndex = 68;
      this.label1.Text = "Mật khẩu mới";
      this.textBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox1.Location = new Point(138, 44);
      this.textBox1.Name = "textBox1";
      this.textBox1.PasswordChar = '*';
      this.textBox1.Size = new Size(124, 22);
      this.textBox1.TabIndex = 2;
      this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(12, 47);
      this.label2.Name = "label2";
      this.label2.Size = new Size(120, 16);
      this.label2.TabIndex = 70;
      this.label2.Text = "Xác nhận mật khẩu";
      this.btnSave.BackColor = SystemColors.GradientInactiveCaption;
      this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Location = new Point(48, 77);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(75, 23);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "Lưu";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(138, 77);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 23);
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.errorProvider1.ContainerControl = (ContainerControl) this;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(284, 109);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnSave);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(300, 147);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(300, 147);
      this.Name = nameof (ChangePassword);
      this.Text = "Đổi mật khẩu";
      this.FormClosing += new FormClosingEventHandler(this.ChangePassword_FormClosing);
      ((ISupportInitialize) this.errorProvider1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
