// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.HotelInfo
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class HotelInfo : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private Button button2;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private Button button3;
    private GroupBox groupBox1;
    private PictureBox pictureBox1;

    public HotelInfo() => this.InitializeComponent();

    private void HotelInfo_Load(object sender, EventArgs e)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        this.Text = "Chỉnh sửa thông tin";
        HotelInformation hotelInformation = smallHotelManager.HotelInformation.Single<HotelInformation>((Expression<Func<HotelInformation, bool>>) (d => d.ID == 1));
        this.textBox1.Text = hotelInformation.HotelName.ToString();
        this.textBox2.Text = hotelInformation.Adress.ToString();
        this.textBox3.Text = hotelInformation.PhoneNumber1.ToString();
        this.textBox4.Text = hotelInformation.PhoneNumber2.ToString();
        string currentDirectory = Directory.GetCurrentDirectory();
        string sourceFileName = currentDirectory + "\\Logo\\logo.png";
        string str = currentDirectory + "\\Logo\\fileOpen.png";
        File.Delete(str);
        File.Copy(sourceFileName, str);
        this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        this.pictureBox1.Image = Image.FromFile(str);
      }
      catch
      {
        int num = (int) MessageBox.Show("Bạn cần khởi động lại chương trình");
        this.Dispose();
      }
    }

    public Image resizeImage(Image img, int width, int height)
    {
      Bitmap bitmap = new Bitmap(width, height);
      Graphics graphics = Graphics.FromImage((Image) bitmap);
      graphics.InterpolationMode = InterpolationMode.Bicubic;
      graphics.DrawImage(img, 0, 0, width, height);
      graphics.Dispose();
      return (Image) bitmap;
    }

    private void Edition(string name, string address, string phone1, string phone2)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        HotelInformation hotelInformation = smallHotelManager.HotelInformation.Single<HotelInformation>((Expression<Func<HotelInformation, bool>>) (p => p.ID == 1));
        hotelInformation.HotelName = name;
        hotelInformation.Adress = address;
        hotelInformation.PhoneNumber1 = phone1;
        hotelInformation.PhoneNumber2 = phone2;
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.textBox1.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập tên Khách Sạn");
        this.textBox1.Focus();
      }
      else if (string.IsNullOrEmpty(this.textBox2.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập địa chỉ ");
        this.textBox2.Focus();
      }
      else if (string.IsNullOrEmpty(this.textBox3.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập số điện thoại cố định");
        this.textBox3.Focus();
      }
      else if (string.IsNullOrEmpty(this.textBox4.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập số điện thoại di động");
        this.textBox4.Focus();
      }
      else
      {
        this.Edition(this.textBox1.Text.ToString(), this.textBox2.Text.ToString(), this.textBox3.Text.ToString(), this.textBox4.Text.ToString());
        this.pictureBox1.Image = this.resizeImage(this.pictureBox1.Image, 256, 256);
        string currentDirectory = Directory.GetCurrentDirectory();
        string str1 = currentDirectory + "\\Logo\\logo.png";
        string str2 = currentDirectory + "\\Logo\\fileSave.png";
        File.Delete(str2);
        this.pictureBox1.Image.Save(str2, ImageFormat.Png);
        File.Delete(str1);
        File.Copy(str2, str1);
        int num = (int) MessageBox.Show("Chỉnh sửa thông tin thành công!!!");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Dispose();
      this.pictureBox1.Image.Dispose();
    }

    private void HotelInfo_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    private void button3_Click(object sender, EventArgs e)
    {
      string currentDirectory = Directory.GetCurrentDirectory();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = "Libraries\\Pictures";
      openFileDialog.Filter = "Image Files (*.JPG,*.PNG)|*.jpg;*.png";
      openFileDialog.RestoreDirectory = true;
      string str = currentDirectory + "\\Logo\\logo.png";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        string fileName = openFileDialog.FileName;
        if (str == fileName)
        {
          int num = (int) MessageBox.Show("Logo đang được sử dụng");
        }
        else
        {
          this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
          this.pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }
      }
      openFileDialog.Dispose();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HotelInfo));
      this.button1 = new Button();
      this.button2 = new Button();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox3 = new TextBox();
      this.textBox4 = new TextBox();
      this.button3 = new Button();
      this.groupBox1 = new GroupBox();
      this.pictureBox1 = new PictureBox();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.button1.BackColor = SystemColors.GradientInactiveCaption;
      this.button1.Location = new Point(113, 192);
      this.button1.Margin = new Padding(4);
      this.button1.Name = "button1";
      this.button1.Size = new Size(100, 28);
      this.button1.TabIndex = 0;
      this.button1.Text = "Lưu";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.BackColor = SystemColors.GradientInactiveCaption;
      this.button2.Location = new Point(371, 193);
      this.button2.Margin = new Padding(4);
      this.button2.Name = "button2";
      this.button2.Size = new Size(79, 28);
      this.button2.TabIndex = 1;
      this.button2.Text = "Thoát";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(6, 23);
      this.label1.Margin = new Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(99, 16);
      this.label1.TabIndex = 3;
      this.label1.Text = "Tên Khách Sạn";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(6, 74);
      this.label2.Margin = new Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(48, 16);
      this.label2.TabIndex = 4;
      this.label2.Text = "Địa chỉ";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(6, 119);
      this.label3.Margin = new Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(74, 16);
      this.label3.TabIndex = 5;
      this.label3.Text = "ĐT Cố định";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(6, 169);
      this.label4.Margin = new Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(76, 16);
      this.label4.TabIndex = 6;
      this.label4.Text = "ĐT Di động";
      this.textBox1.Location = new Point(113, 17);
      this.textBox1.Margin = new Padding(4);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(158, 22);
      this.textBox1.TabIndex = 7;
      this.textBox2.Location = new Point(113, 68);
      this.textBox2.Margin = new Padding(4);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(158, 22);
      this.textBox2.TabIndex = 8;
      this.textBox3.Location = new Point(113, 113);
      this.textBox3.Margin = new Padding(4);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(158, 22);
      this.textBox3.TabIndex = 9;
      this.textBox4.Location = new Point(113, 163);
      this.textBox4.Margin = new Padding(4);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(158, 22);
      this.textBox4.TabIndex = 10;
      this.button3.BackColor = SystemColors.GradientInactiveCaption;
      this.button3.Location = new Point(278, 192);
      this.button3.Margin = new Padding(4);
      this.button3.Name = "button3";
      this.button3.Size = new Size(85, 28);
      this.button3.TabIndex = 12;
      this.button3.Text = "Chọn Logo";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.groupBox1.Controls.Add((Control) this.pictureBox1);
      this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.Location = new Point(278, 7);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(172, 178);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.pictureBox1.Location = new Point(6, 16);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(158, 156);
      this.pictureBox1.TabIndex = 14;
      this.pictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(463, 234);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(479, 272);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(479, 272);
      this.Name = nameof (HotelInfo);
      this.Text = "Thông tin Khách Sạn";
      this.FormClosing += new FormClosingEventHandler(this.HotelInfo_FormClosing);
      this.Load += new EventHandler(this.HotelInfo_Load);
      this.groupBox1.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
