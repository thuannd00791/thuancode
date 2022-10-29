// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.SortInfo
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using Microsoft.Win32;
using SmallHotelManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class SortInfo : Form
  {
    private int _isReg = 0;
    private int _time = 1;
    private int _isFirst = 0;
    private Main _parent;
    private IContainer components = (IContainer) null;
    private Label label1;
    private ProgressBar progressBar1;
    private Label label2;
    private TextBox txtKey;
    private GroupBox groupBox1;
    private Button btnReg;
    private Button btnContinu;
    private Button btnCancel;
    private Panel panel1;
    private ImageList imageList1;
    private Label label3;

    public int IsFirst
    {
      get => this._isFirst;
      set => this._isFirst = value;
    }

    public int TIMES
    {
      get => this._time;
      set => this._time = value;
    }

    public int IsReg
    {
      get => this._isReg;
      set => this._isReg = value;
    }

    public SortInfo(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
    }

    private static void CreateRegis()
    {
      using (MD5 md5Hash = MD5.Create())
      {
        RegistryKey subKey = Registry.CurrentUser.CreateSubKey("Software\\regSMK\\regSMK");
        subKey.SetValue("Reged", (object) SortInfo.GetMd5Hash(md5Hash, "chua"));
        subKey.SetValue("Times", (object) "34173cb38f07f89ddbebc2ac9128303f");
      }
    }

    private string getUniqueID(string drive)
    {
      if (drive == string.Empty)
      {
        foreach (DriveInfo drive1 in DriveInfo.GetDrives())
        {
          if (drive1.IsReady)
          {
            drive = drive1.RootDirectory.ToString();
            break;
          }
        }
      }
      if (drive.EndsWith(":\\"))
        drive = drive.Substring(0, drive.Length - 2);
      string volumeSerial = this.getVolumeSerial(drive);
      string cpuid = this.getCPUID();
      return cpuid.Substring(13) + cpuid.Substring(2, 5) + volumeSerial + cpuid.Substring(7, 7);
    }

    private string getVolumeSerial(string drive)
    {
      ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
      managementObject.Get();
      string volumeSerial = managementObject["VolumeSerialNumber"].ToString();
      managementObject.Dispose();
      return volumeSerial;
    }

    private string getCPUID()
    {
      string cpuid = "";
      foreach (ManagementObject instance in new ManagementClass("win32_processor").GetInstances())
      {
        if (cpuid == "")
        {
          cpuid = instance.Properties["processorID"].Value.ToString();
          break;
        }
      }
      return cpuid;
    }

    private static string GetMd5Hash(MD5 md5Hash, string input)
    {
      byte[] hash = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 0; index < hash.Length; ++index)
        stringBuilder.Append(hash[index].ToString("x2"));
      return stringBuilder.ToString();
    }

    private static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash) => 0 == StringComparer.OrdinalIgnoreCase.Compare(SortInfo.GetMd5Hash(md5Hash, input), hash);

    private void btnReg_Click(object sender, EventArgs e)
    {
      using (MD5 md5Hash = MD5.Create())
      {
        string hash = this.txtKey.Text.Trim();
        if (SortInfo.VerifyMd5Hash(md5Hash, this.getUniqueID("C"), hash))
        {
          int num = (int) MessageBox.Show("Đăng ký thành công");
          this.label1.ForeColor = System.Drawing.Color.YellowGreen;
          this.btnContinu.Enabled = false;
          this.progressBar1.Value = 30;
          this.progressBar1.Enabled = false;
          this.label2.Text = "Số lần sử dụng không giới hạn!";
          this.label1.Text = "Bạn đang sử dụng phiên bản đầy đủ.\nMọi thắc mắc về phần mềm xin liên hệ với chúng tôi\nLiên hệ: 012.05.07.08.09 hoặc 01688.778.394";
          this.groupBox1.Enabled = false;
          this.btnReg.Enabled = false;
          RegistryKey subKey = Registry.CurrentUser.CreateSubKey("Software\\\\regSMK\\\\regSMK");
          subKey.SetValue("Reged", (object) hash);
          subKey.Close();
          this.IsReg = 1;
          this._parent.IsReg = 1;
          this.Dispose();
        }
        else
        {
          int num1 = (int) MessageBox.Show("Đăng ký không thành công!");
        }
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      if (this.IsFirst == 1)
      {
        this.Dispose();
        this._parent.Dispose();
      }
      else
        this.Dispose();
    }

    private void SortInfo_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.IsFirst == 1 && this.TIMES == 0 && this._isReg == 0)
      {
        this.Dispose();
        this._parent.Dispose();
      }
      else
        this.Dispose();
    }

    private void SortInfo_Load(object sender, EventArgs e)
    {
      this.ControlBox = false;
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._isReg == 0)
      {
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\\\regSMK\\\\regSMK");
        if (registryKey == null)
        {
          SortInfo.CreateRegis();
          this.progressBar1.Value = 30;
          this.label2.Text = "Còn 30 lần sử dụng";
        }
        else
        {
          string times = registryKey.GetValue("Times").ToString();
          IQueryable<UsingTime> source = smallHotelManager.UsingTime.Where<UsingTime>((Expression<Func<UsingTime, bool>>) (u => u.KeyName.Equals(times)));
          if (source.Any<UsingTime>())
          {
            foreach (UsingTime usingTime in (IEnumerable<UsingTime>) source)
            {
              this.TIMES = usingTime.ID;
              this.progressBar1.Value = this.TIMES;
              this.label2.Text = "Còn " + (object) this.TIMES + " lần sử dụng";
            }
          }
          else
          {
            this.TIMES = 0;
            this.progressBar1.Value = 0;
            this.btnContinu.Enabled = false;
            this.label2.Text = "Đã hết số lần sử dụng miễn phí!";
          }
        }
      }
      else
      {
        this.label1.ForeColor = System.Drawing.Color.Green;
        this.btnContinu.Enabled = false;
        this.progressBar1.Value = 30;
        this.progressBar1.Enabled = false;
        this.label2.Text = "Số lần sử dụng không giới hạn!";
        this.label1.Text = "Bạn đang sử dụng phiên bản đầy đủ.\nMọi thắc mắc về phần mềm xin liên hệ với chúng tôi\nLiên hệ: 012.05.07.08.09 hoặc 01688.778.394";
        this.groupBox1.Enabled = false;
        this.btnReg.Enabled = false;
        if (this._isFirst == 1)
          this.Dispose();
      }
    }

    private void btnContinu_Click(object sender, EventArgs e) => this.Dispose();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SortInfo));
      this.label1 = new Label();
      this.progressBar1 = new ProgressBar();
      this.label2 = new Label();
      this.txtKey = new TextBox();
      this.groupBox1 = new GroupBox();
      this.btnReg = new Button();
      this.btnContinu = new Button();
      this.btnCancel = new Button();
      this.panel1 = new Panel();
      this.imageList1 = new ImageList(this.components);
      this.label3 = new Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Palatino Linotype", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(7, 13);
      this.label1.Name = "label1";
      this.label1.Size = new Size(388, 88);
      this.label1.TabIndex = 0;
      this.label1.Text = "Bạn đang sử dụng phiên bản giới hạn số lần sử dụng. \r\nĐể sử dụng phiên bản đầy đủ hãy liên hệ với chúng tôi.\r\nLiên hệ: 012.05.07.08.09 hoặc 01688.778.394\r\n\r\n";
      this.progressBar1.Location = new Point(11, 185);
      this.progressBar1.Maximum = 30;
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(379, 29);
      this.progressBar1.TabIndex = 1;
      this.progressBar1.Value = 1;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Palatino Linotype", 12f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(12, 157);
      this.label2.Name = "label2";
      this.label2.Size = new Size(61, 23);
      this.label2.TabIndex = 2;
      this.label2.Text = "Bạn còn";
      this.txtKey.Font = new Font("Palatino Linotype", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtKey.Location = new Point(15, 23);
      this.txtKey.Name = "txtKey";
      this.txtKey.Size = new Size(358, 28);
      this.txtKey.TabIndex = 3;
      this.groupBox1.Controls.Add((Control) this.txtKey);
      this.groupBox1.Font = new Font("Palatino Linotype", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.Location = new Point(11, 94);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(379, 57);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Nhập mã để kích hoạt";
      this.btnReg.Font = new Font("Palatino Linotype", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnReg.Location = new Point(402, 123);
      this.btnReg.Name = "btnReg";
      this.btnReg.Size = new Size(100, 28);
      this.btnReg.TabIndex = 4;
      this.btnReg.Text = "Đăng ký";
      this.btnReg.UseVisualStyleBackColor = true;
      this.btnReg.Click += new EventHandler(this.btnReg_Click);
      this.btnContinu.Font = new Font("Palatino Linotype", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnContinu.Location = new Point(402, 157);
      this.btnContinu.Name = "btnContinu";
      this.btnContinu.Size = new Size(100, 57);
      this.btnContinu.TabIndex = 5;
      this.btnContinu.Text = "Tiếp tục sử dụng";
      this.btnContinu.UseVisualStyleBackColor = true;
      this.btnContinu.Click += new EventHandler(this.btnContinu_Click);
      this.btnCancel.Font = new Font("Palatino Linotype", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(401, 216);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(101, 29);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.panel1.BackgroundImage = (Image) Resources.icon;
      this.panel1.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel1.Location = new Point(402, 13);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(100, 100);
      this.panel1.TabIndex = 7;
      this.imageList1.ColorDepth = ColorDepth.Depth8Bit;
      this.imageList1.ImageSize = new Size(16, 16);
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Palatino Linotype", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(7, 223);
      this.label3.Name = "label3";
      this.label3.Size = new Size(254, 22);
      this.label3.TabIndex = 8;
      this.label3.Text = "Version 3.0  -  Developed by Cgroup";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(514, 248);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.btnReg);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnContinu);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.progressBar1);
      this.Controls.Add((Control) this.label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximumSize = new Size(530, 287);
      this.MinimumSize = new Size(530, 287);
      this.Name = nameof (SortInfo);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Thông tin phần mềm";
      this.FormClosing += new FormClosingEventHandler(this.SortInfo_FormClosing);
      this.Load += new EventHandler(this.SortInfo_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
