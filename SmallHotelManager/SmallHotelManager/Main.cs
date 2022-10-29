// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.Main
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using Microsoft.Win32;
using SmallHotelManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
  public class Main : Form
  {
    private IContainer components = (IContainer) null;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem hicToolStripMenuItem;
    private Panel plRoom;
    private Button btnBookingRoom;
    private Button btnRoomMan;
    private Button button3;
    private Button button4;
    private GroupBox groupBox1;
    private Button button5;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private Button btnCancel;
    private TextBox textBox2;
    private TextBox textBox1;
    private Label label3;
    private Label label4;
    private TextBox textBox3;
    private TextBox textBox4;
    private Label label2;
    private Label label1;
    private ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
    private ToolStripMenuItem dịchVụToolStripMenuItem;
    private ToolStripMenuItem quảnLýDịchVụToolStripMenuItem;
    private ToolStripMenuItem thoátToolStripMenuItem;
    private ToolStripMenuItem quảnLýDịchVụToolStripMenuItem1;
    private Button btnLogin;
    private Label lblLongin;
    private ToolStripMenuItem khácToolStripMenuItem;
    private ToolStripMenuItem dịchToolStripMenuItem;
    private ToolStripMenuItem hóaĐơnToolStripMenuItem;
    private ToolStripMenuItem hóaĐơnToolStripMenuItem1;
    private ToolStripMenuItem ngườiDùngToolStripMenuItem;
    private ToolStripMenuItem trợGiúpToolStripMenuItem;
    private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
    private ToolStripMenuItem thôngTinToolStripMenuItem;
    private ToolStripMenuItem hệThốngToolStripMenuItem;
    private ToolStripMenuItem đăngNhậpToolStripMenuItem;
    private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    private ToolStripMenuItem thoátToolStripMenuItem1;
    private ToolStripMenuItem phòngToolStripMenuItem;
    private ToolStripMenuItem đặtPhòngToolStripMenuItem;
    private ToolStripMenuItem quảnLýPhòngToolStripMenuItem1;
    private ToolStripMenuItem quảnLýToolStripMenuItem;
    private ToolStripMenuItem dịchVụToolStripMenuItem1;
    private ToolStripMenuItem hóaĐơnToolStripMenuItem2;
    private ToolStripMenuItem ngườiDùngToolStripMenuItem1;
    private ToolStripMenuItem trợGiúpToolStripMenuItem1;
    private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem1;
    private ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
    private Timer timer1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private ToolTip ttdatpong;
    private ComboBox cmbErrorRoom;
    private Button button1;
    private TabControl tabControl2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem hệThốngToolStripMenuItem1;
    private ToolStripMenuItem đăngNhậpToolStripMenuItem1;
    private ToolStripMenuItem đăngXuấtToolStripMenuItem1;
    private ToolStripMenuItem thoátToolStripMenuItem2;
    private ToolStripMenuItem phòngToolStripMenuItem1;
    private ToolStripMenuItem quảnLýPhòngToolStripMenuItem2;
    private ToolStripMenuItem đặtPhòngToolStripMenuItem1;
    private ToolStripMenuItem quảnLýChungToolStripMenuItem;
    private ToolStripMenuItem dịchVụToolStripMenuItem2;
    private ToolStripMenuItem ngườiDùngToolStripMenuItem2;
    private ToolStripMenuItem trợGiúpToolStripMenuItem2;
    private ToolStripMenuItem thôngTinSảnPhẩmToolStripMenuItem;
    private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem2;
    private ToolStripMenuItem đăngNhậpToolStripMenuItem2;
    private ToolStripMenuItem thoátToolStripMenuItem3;
    private DataGridView grvBooking;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private ToolStripMenuItem nângCaoToolStripMenuItem;
    private Button btnVAT;
    private DataGridView grvSpending;
    private ToolStripMenuItem thôngTinKháchSạnToolStripMenuItem;
    private DataGridView grvCrSer;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private Button button2;
    private Button button6;
    private FlowLayoutPanel tlp;
    private ToolStripMenuItem hóaĐơnToolStripMenuItem3;
    private ToolStripMenuItem kháchHàngToolStripMenuItem;
    private TabPage tabPage2;
    private DataGridView grvLoan;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column3;
    private Button btnRoom;
    private int _userId = 0;
    private int _isLogin = 0;
    private int _userType = 0;
    private string _name = "";
    private int _isReg = 0;
    public string roomId = "";
    private int _AttendID = 0;
    private RoomInf rmf = (RoomInf) null;
    private LoginForm lg = (LoginForm) null;
    private SortInfo si = (SortInfo) null;
    private int count = 0;
    private AddSpending sp = (AddSpending) null;
    private BookingRoom br = (BookingRoom) null;
    private ServicesManager sm = (ServicesManager) null;
    private AddNewError ar = (AddNewError) null;
    private SortInfo sif = (SortInfo) null;
    private CustomerReport adm = (CustomerReport) null;
    private VAT va = (VAT) null;
    private HotelInfo hi = (HotelInfo) null;
    private NationalManager nm;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Main));
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.hicToolStripMenuItem = new ToolStripMenuItem();
      this.quảnLýPhòngToolStripMenuItem = new ToolStripMenuItem();
      this.thoátToolStripMenuItem = new ToolStripMenuItem();
      this.dịchVụToolStripMenuItem = new ToolStripMenuItem();
      this.quảnLýDịchVụToolStripMenuItem = new ToolStripMenuItem();
      this.quảnLýDịchVụToolStripMenuItem1 = new ToolStripMenuItem();
      this.khácToolStripMenuItem = new ToolStripMenuItem();
      this.dịchToolStripMenuItem = new ToolStripMenuItem();
      this.hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
      this.hóaĐơnToolStripMenuItem1 = new ToolStripMenuItem();
      this.ngườiDùngToolStripMenuItem = new ToolStripMenuItem();
      this.trợGiúpToolStripMenuItem = new ToolStripMenuItem();
      this.hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
      this.thôngTinToolStripMenuItem = new ToolStripMenuItem();
      this.plRoom = new Panel();
      this.tlp = new FlowLayoutPanel();
      this.groupBox1 = new GroupBox();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.grvCrSer = new DataGridView();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.groupBox2 = new GroupBox();
      this.tabControl2 = new TabControl();
      this.tabPage4 = new TabPage();
      this.button2 = new Button();
      this.grvBooking = new DataGridView();
      this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.tabPage3 = new TabPage();
      this.button6 = new Button();
      this.grvSpending = new DataGridView();
      this.groupBox3 = new GroupBox();
      this.label3 = new Label();
      this.label4 = new Label();
      this.textBox3 = new TextBox();
      this.textBox4 = new TextBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.textBox2 = new TextBox();
      this.textBox1 = new TextBox();
      this.groupBox4 = new GroupBox();
      this.btnLogin = new Button();
      this.lblLongin = new Label();
      this.hệThốngToolStripMenuItem = new ToolStripMenuItem();
      this.đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
      this.đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
      this.thoátToolStripMenuItem1 = new ToolStripMenuItem();
      this.phòngToolStripMenuItem = new ToolStripMenuItem();
      this.đặtPhòngToolStripMenuItem = new ToolStripMenuItem();
      this.quảnLýPhòngToolStripMenuItem1 = new ToolStripMenuItem();
      this.quảnLýToolStripMenuItem = new ToolStripMenuItem();
      this.dịchVụToolStripMenuItem1 = new ToolStripMenuItem();
      this.hóaĐơnToolStripMenuItem2 = new ToolStripMenuItem();
      this.ngườiDùngToolStripMenuItem1 = new ToolStripMenuItem();
      this.trợGiúpToolStripMenuItem1 = new ToolStripMenuItem();
      this.hướngDẫnSửDụngToolStripMenuItem1 = new ToolStripMenuItem();
      this.thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
      this.timer1 = new Timer(this.components);
      this.ttdatpong = new ToolTip(this.components);
      this.btnCancel = new Button();
      this.button5 = new Button();
      this.button4 = new Button();
      this.button3 = new Button();
      this.btnRoomMan = new Button();
      this.btnBookingRoom = new Button();
      this.cmbErrorRoom = new ComboBox();
      this.button1 = new Button();
      this.menuStrip1 = new MenuStrip();
      this.hệThốngToolStripMenuItem1 = new ToolStripMenuItem();
      this.đăngNhậpToolStripMenuItem1 = new ToolStripMenuItem();
      this.đăngXuấtToolStripMenuItem1 = new ToolStripMenuItem();
      this.thoátToolStripMenuItem2 = new ToolStripMenuItem();
      this.đăngNhậpToolStripMenuItem2 = new ToolStripMenuItem();
      this.thoátToolStripMenuItem3 = new ToolStripMenuItem();
      this.phòngToolStripMenuItem1 = new ToolStripMenuItem();
      this.quảnLýPhòngToolStripMenuItem2 = new ToolStripMenuItem();
      this.đặtPhòngToolStripMenuItem1 = new ToolStripMenuItem();
      this.hóaĐơnToolStripMenuItem3 = new ToolStripMenuItem();
      this.quảnLýChungToolStripMenuItem = new ToolStripMenuItem();
      this.dịchVụToolStripMenuItem2 = new ToolStripMenuItem();
      this.ngườiDùngToolStripMenuItem2 = new ToolStripMenuItem();
      this.nângCaoToolStripMenuItem = new ToolStripMenuItem();
      this.kháchHàngToolStripMenuItem = new ToolStripMenuItem();
      this.trợGiúpToolStripMenuItem2 = new ToolStripMenuItem();
      this.thôngTinSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
      this.hướngDẫnSửDụngToolStripMenuItem2 = new ToolStripMenuItem();
      this.thôngTinKháchSạnToolStripMenuItem = new ToolStripMenuItem();
      this.btnVAT = new Button();
      this.grvLoan = new DataGridView();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.tabPage2 = new TabPage();
      this.plRoom.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((ISupportInitialize) this.grvCrSer).BeginInit();
      this.groupBox2.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage4.SuspendLayout();
      ((ISupportInitialize) this.grvBooking).BeginInit();
      this.tabPage3.SuspendLayout();
      ((ISupportInitialize) this.grvSpending).BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((ISupportInitialize) this.grvLoan).BeginInit();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      this.fileToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.hicToolStripMenuItem,
        (ToolStripItem) this.quảnLýPhòngToolStripMenuItem,
        (ToolStripItem) this.thoátToolStripMenuItem
      });
      this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(69, 20);
      this.fileToolStripMenuItem.Text = "Hệ thống";
      this.hicToolStripMenuItem.Name = "hicToolStripMenuItem";
      this.hicToolStripMenuItem.Size = new Size(132, 22);
      this.hicToolStripMenuItem.Text = "Đăng nhập";
      this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
      this.quảnLýPhòngToolStripMenuItem.Size = new Size(132, 22);
      this.quảnLýPhòngToolStripMenuItem.Text = "Đăng xuất";
      this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
      this.thoátToolStripMenuItem.Size = new Size(132, 22);
      this.thoátToolStripMenuItem.Text = "Thoát";
      this.dịchVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.quảnLýDịchVụToolStripMenuItem,
        (ToolStripItem) this.quảnLýDịchVụToolStripMenuItem1
      });
      this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
      this.dịchVụToolStripMenuItem.Size = new Size(54, 20);
      this.dịchVụToolStripMenuItem.Text = "Phòng";
      this.quảnLýDịchVụToolStripMenuItem.Name = "quảnLýDịchVụToolStripMenuItem";
      this.quảnLýDịchVụToolStripMenuItem.Size = new Size(153, 22);
      this.quảnLýDịchVụToolStripMenuItem.Text = "Đặt phòng";
      this.quảnLýDịchVụToolStripMenuItem1.Name = "quảnLýDịchVụToolStripMenuItem1";
      this.quảnLýDịchVụToolStripMenuItem1.Size = new Size(153, 22);
      this.quảnLýDịchVụToolStripMenuItem1.Text = "Quản lý phòng";
      this.khácToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.dịchToolStripMenuItem,
        (ToolStripItem) this.hóaĐơnToolStripMenuItem,
        (ToolStripItem) this.hóaĐơnToolStripMenuItem1,
        (ToolStripItem) this.ngườiDùngToolStripMenuItem
      });
      this.khácToolStripMenuItem.Name = "khácToolStripMenuItem";
      this.khácToolStripMenuItem.Size = new Size(60, 20);
      this.khácToolStripMenuItem.Text = "Quản lý";
      this.dịchToolStripMenuItem.Name = "dịchToolStripMenuItem";
      this.dịchToolStripMenuItem.Size = new Size(138, 22);
      this.dịchToolStripMenuItem.Text = "Giá";
      this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
      this.hóaĐơnToolStripMenuItem.Size = new Size(138, 22);
      this.hóaĐơnToolStripMenuItem.Text = "Dịch vụ";
      this.hóaĐơnToolStripMenuItem1.Name = "hóaĐơnToolStripMenuItem1";
      this.hóaĐơnToolStripMenuItem1.Size = new Size(138, 22);
      this.hóaĐơnToolStripMenuItem1.Text = "Hóa đơn";
      this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
      this.ngườiDùngToolStripMenuItem.Size = new Size(138, 22);
      this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
      this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.hướngDẫnSửDụngToolStripMenuItem,
        (ToolStripItem) this.thôngTinToolStripMenuItem
      });
      this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
      this.trợGiúpToolStripMenuItem.Size = new Size(64, 20);
      this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
      this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
      this.hướngDẫnSửDụngToolStripMenuItem.Size = new Size(180, 22);
      this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
      this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
      this.thôngTinToolStripMenuItem.Size = new Size(180, 22);
      this.thôngTinToolStripMenuItem.Text = "Thông tin...";
      this.plRoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.plRoom.AutoScroll = true;
      this.plRoom.BackColor = SystemColors.ControlLightLight;
      this.plRoom.BackgroundImageLayout = ImageLayout.Stretch;
      this.plRoom.BorderStyle = BorderStyle.Fixed3D;
      this.plRoom.Controls.Add((Control) this.tlp);
      this.plRoom.Enabled = false;
      this.plRoom.Location = new Point(244, 105);
      this.plRoom.Margin = new Padding(3, 2, 3, 2);
      this.plRoom.Name = "plRoom";
      this.plRoom.Size = new Size(802, 456);
      this.plRoom.TabIndex = 0;
      this.tlp.AutoScroll = true;
      this.tlp.Dock = DockStyle.Fill;
      this.tlp.Location = new Point(0, 0);
      this.tlp.Name = "tlp";
      this.tlp.Size = new Size(798, 452);
      this.tlp.TabIndex = 0;
      this.groupBox1.Controls.Add((Control) this.tabControl1);
      this.groupBox1.Enabled = false;
      this.groupBox1.Location = new Point(0, 27);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(238, 294);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(3, 18);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(232, 273);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tabPage1.BackColor = SystemColors.GradientInactiveCaption;
      this.tabPage1.Controls.Add((Control) this.grvCrSer);
      this.tabPage1.Location = new Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(224, 244);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Dịch vụ";
      this.grvCrSer.AllowUserToAddRows = false;
      this.grvCrSer.AllowUserToDeleteRows = false;
      this.grvCrSer.AllowUserToResizeRows = false;
      this.grvCrSer.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.grvCrSer.BorderStyle = BorderStyle.Fixed3D;
      this.grvCrSer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle1.SelectionForeColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.grvCrSer.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.grvCrSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvCrSer.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2);
      this.grvCrSer.GridColor = SystemColors.Control;
      this.grvCrSer.Location = new Point(3, 3);
      this.grvCrSer.MultiSelect = false;
      this.grvCrSer.Name = "grvCrSer";
      this.grvCrSer.ReadOnly = true;
      this.grvCrSer.RowHeadersVisible = false;
      this.grvCrSer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvCrSer.Size = new Size(218, 238);
      this.grvCrSer.TabIndex = 0;
      this.ttdatpong.SetToolTip((Control) this.grvCrSer, "Dịch vụ hiện có");
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column1.DataPropertyName = "Name";
      gridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
      this.Column1.DefaultCellStyle = gridViewCellStyle2;
      this.Column1.HeaderText = "Tên";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.Column2.DataPropertyName = "TotalNumber";
      gridViewCellStyle3.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
      this.Column2.DefaultCellStyle = gridViewCellStyle3;
      this.Column2.HeaderText = "Số lượng";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 94;
      this.groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.groupBox2.Controls.Add((Control) this.tabControl2);
      this.groupBox2.Enabled = false;
      this.groupBox2.Location = new Point(0, 324);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(238, 304);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Thống kê trong ngày";
      this.tabControl2.Controls.Add((Control) this.tabPage4);
      this.tabControl2.Controls.Add((Control) this.tabPage3);
      this.tabControl2.Dock = DockStyle.Fill;
      this.tabControl2.Location = new Point(3, 18);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new Size(232, 283);
      this.tabControl2.TabIndex = 0;
      this.tabControl2.SelectedIndexChanged += new EventHandler(this.tabControl2_SelectedIndexChanged);
      this.tabPage4.BackColor = SystemColors.GradientInactiveCaption;
      this.tabPage4.Controls.Add((Control) this.button2);
      this.tabPage4.Controls.Add((Control) this.grvBooking);
      this.tabPage4.Location = new Point(4, 25);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(224, 254);
      this.tabPage4.TabIndex = 1;
      this.tabPage4.Text = "Đặt phòng";
      this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button2.BackColor = SystemColors.GradientInactiveCaption;
      this.button2.Location = new Point(3, 218);
      this.button2.Name = "button2";
      this.button2.Size = new Size(218, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Làm mới";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.grvBooking.AllowUserToAddRows = false;
      this.grvBooking.AllowUserToDeleteRows = false;
      this.grvBooking.AllowUserToResizeRows = false;
      this.grvBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.grvBooking.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.grvBooking.BorderStyle = BorderStyle.Fixed3D;
      this.grvBooking.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      this.grvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvBooking.Columns.AddRange((DataGridViewColumn) this.dataGridViewTextBoxColumn1, (DataGridViewColumn) this.dataGridViewTextBoxColumn4);
      this.grvBooking.GridColor = SystemColors.Control;
      this.grvBooking.Location = new Point(3, 3);
      this.grvBooking.MultiSelect = false;
      this.grvBooking.Name = "grvBooking";
      this.grvBooking.ReadOnly = true;
      this.grvBooking.RowHeadersVisible = false;
      this.grvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvBooking.Size = new Size(218, 209);
      this.grvBooking.TabIndex = 1;
      this.ttdatpong.SetToolTip((Control) this.grvBooking, "Dịch vụ hiện có");
      this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "NameOfBooker";
      gridViewCellStyle4.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
      this.dataGridViewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle4;
      this.dataGridViewTextBoxColumn1.HeaderText = "Tên";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
      gridViewCellStyle5.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle5.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
      this.dataGridViewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle5;
      this.dataGridViewTextBoxColumn4.HeaderText = "SĐT";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 5;
      this.tabPage3.BackColor = SystemColors.GradientInactiveCaption;
      this.tabPage3.Controls.Add((Control) this.button6);
      this.tabPage3.Controls.Add((Control) this.grvSpending);
      this.tabPage3.Location = new Point(4, 25);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(224, 254);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "Thu chi";
      this.button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button6.BackColor = SystemColors.GradientInactiveCaption;
      this.button6.Location = new Point(3, 228);
      this.button6.Name = "button6";
      this.button6.Size = new Size(218, 23);
      this.button6.TabIndex = 3;
      this.button6.Text = "Làm mới";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.grvSpending.AllowDrop = true;
      this.grvSpending.AllowUserToAddRows = false;
      this.grvSpending.AllowUserToDeleteRows = false;
      this.grvSpending.AllowUserToResizeRows = false;
      gridViewCellStyle6.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle6.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
      this.grvSpending.AlternatingRowsDefaultCellStyle = gridViewCellStyle6;
      this.grvSpending.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.grvSpending.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.grvSpending.BorderStyle = BorderStyle.Fixed3D;
      this.grvSpending.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      this.grvSpending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.grvSpending.ColumnHeadersVisible = false;
      this.grvSpending.GridColor = SystemColors.Control;
      this.grvSpending.Location = new Point(3, 3);
      this.grvSpending.MultiSelect = false;
      this.grvSpending.Name = "grvSpending";
      this.grvSpending.ReadOnly = true;
      this.grvSpending.RowHeadersVisible = false;
      this.grvSpending.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.grvSpending.Size = new Size(218, 219);
      this.grvSpending.TabIndex = 0;
      this.grvSpending.CellContentClick += new DataGridViewCellEventHandler(this.grvSpending_CellClick);
      this.groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Controls.Add((Control) this.label4);
      this.groupBox3.Controls.Add((Control) this.textBox3);
      this.groupBox3.Controls.Add((Control) this.textBox4);
      this.groupBox3.Controls.Add((Control) this.label2);
      this.groupBox3.Controls.Add((Control) this.label1);
      this.groupBox3.Controls.Add((Control) this.textBox2);
      this.groupBox3.Controls.Add((Control) this.textBox1);
      this.groupBox3.Enabled = false;
      this.groupBox3.Location = new Point(244, 565);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(390, 62);
      this.groupBox3.TabIndex = 9;
      this.groupBox3.TabStop = false;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(220, 41);
      this.label3.Name = "label3";
      this.label3.Size = new Size(162, 16);
      this.label3.TabIndex = 0;
      this.label3.Text = "Phòng tạm ngưng sử dụng";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(220, 15);
      this.label4.Name = "label4";
      this.label4.Size = new Size(105, 16);
      this.label4.TabIndex = 0;
      this.label4.Text = "Phòng chưa dọn";
      this.textBox3.BackColor = System.Drawing.Color.Red;
      this.textBox3.Enabled = false;
      this.textBox3.Location = new Point(194, 37);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(22, 22);
      this.textBox3.TabIndex = 0;
      this.textBox4.BackColor = System.Drawing.Color.Orange;
      this.textBox4.Enabled = false;
      this.textBox4.Location = new Point(194, 12);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(22, 22);
      this.textBox4.TabIndex = 0;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(34, 41);
      this.label2.Name = "label2";
      this.label2.Size = new Size(131, 16);
      this.label2.TabIndex = 0;
      this.label2.Text = "Phòng đang sử dụng";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(34, 15);
      this.label1.Name = "label1";
      this.label1.Size = new Size(80, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Phòng trống";
      this.textBox2.BackColor = System.Drawing.Color.GreenYellow;
      this.textBox2.Enabled = false;
      this.textBox2.Location = new Point(6, 37);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(22, 22);
      this.textBox2.TabIndex = 0;
      this.textBox1.BackColor = System.Drawing.Color.White;
      this.textBox1.Enabled = false;
      this.textBox1.Location = new Point(6, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(22, 22);
      this.textBox1.TabIndex = 0;
      this.groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.groupBox4.Controls.Add((Control) this.btnLogin);
      this.groupBox4.Controls.Add((Control) this.lblLongin);
      this.groupBox4.Location = new Point(782, 27);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(262, 73);
      this.groupBox4.TabIndex = 0;
      this.groupBox4.TabStop = false;
      this.btnLogin.BackColor = SystemColors.GradientInactiveCaption;
      this.btnLogin.ForeColor = System.Drawing.Color.LimeGreen;
      this.btnLogin.Location = new Point(178, 12);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new Size(76, 54);
      this.btnLogin.TabIndex = 0;
      this.btnLogin.Text = "Đăng nhập";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
      this.lblLongin.AutoSize = true;
      this.lblLongin.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblLongin.ForeColor = System.Drawing.Color.Red;
      this.lblLongin.Location = new Point(8, 12);
      this.lblLongin.Name = "lblLongin";
      this.lblLongin.Size = new Size(142, 32);
      this.lblLongin.TabIndex = 0;
      this.lblLongin.Text = "Hãy đăng nhập\r\nđể có thể sử dụng!!!";
      this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
      this.hệThốngToolStripMenuItem.Size = new Size(74, 21);
      this.hệThốngToolStripMenuItem.Text = "Hệ thống";
      this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
      this.đăngNhậpToolStripMenuItem.Size = new Size(152, 22);
      this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
      this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
      this.đăngXuấtToolStripMenuItem.Size = new Size(152, 22);
      this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
      this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
      this.thoátToolStripMenuItem1.Size = new Size(152, 22);
      this.thoátToolStripMenuItem1.Text = "Thoát";
      this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
      this.phòngToolStripMenuItem.Size = new Size(57, 21);
      this.phòngToolStripMenuItem.Text = "Phòng";
      this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
      this.đặtPhòngToolStripMenuItem.Size = new Size(229, 22);
      this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
      this.quảnLýPhòngToolStripMenuItem1.Name = "quảnLýPhòngToolStripMenuItem1";
      this.quảnLýPhòngToolStripMenuItem1.Size = new Size(229, 22);
      this.quảnLýPhòngToolStripMenuItem1.Text = "Quản lý phòng, giá phòng";
      this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
      this.quảnLýToolStripMenuItem.Size = new Size(68, 21);
      this.quảnLýToolStripMenuItem.Text = "Quản lý ";
      this.dịchVụToolStripMenuItem1.Name = "dịchVụToolStripMenuItem1";
      this.dịchVụToolStripMenuItem1.Size = new Size(152, 22);
      this.dịchVụToolStripMenuItem1.Text = "Dịch vụ";
      this.hóaĐơnToolStripMenuItem2.Name = "hóaĐơnToolStripMenuItem2";
      this.hóaĐơnToolStripMenuItem2.Size = new Size(152, 22);
      this.hóaĐơnToolStripMenuItem2.Text = "Hóa đơn";
      this.ngườiDùngToolStripMenuItem1.Name = "ngườiDùngToolStripMenuItem1";
      this.ngườiDùngToolStripMenuItem1.Size = new Size(152, 22);
      this.ngườiDùngToolStripMenuItem1.Text = "Người dùng";
      this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
      this.trợGiúpToolStripMenuItem1.Size = new Size(70, 21);
      this.trợGiúpToolStripMenuItem1.Text = "Trợ giúp";
      this.hướngDẫnSửDụngToolStripMenuItem1.Name = "hướngDẫnSửDụngToolStripMenuItem1";
      this.hướngDẫnSửDụngToolStripMenuItem1.Size = new Size(197, 22);
      this.hướngDẫnSửDụngToolStripMenuItem1.Text = "Hướng dẫn sử dụng";
      this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
      this.thôngTinPhầnMềmToolStripMenuItem.Size = new Size(197, 22);
      this.thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.BackgroundImage = (Image) componentResourceManager.GetObject("btnCancel.BackgroundImage");
      this.btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.ImageAlign = ContentAlignment.TopLeft;
      this.btnCancel.Location = new Point(982, 571);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(62, 55);
      this.btnCancel.TabIndex = 0;
      this.ttdatpong.SetToolTip((Control) this.btnCancel, "Thoát");
      this.btnCancel.UseCompatibleTextRendering = true;
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.button5.BackColor = SystemColors.GradientInactiveCaption;
      this.button5.BackgroundImage = (Image) componentResourceManager.GetObject("button5.BackgroundImage");
      this.button5.BackgroundImageLayout = ImageLayout.Zoom;
      this.button5.Enabled = false;
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.ForeColor = SystemColors.WindowText;
      this.button5.Location = new Point(692, 30);
      this.button5.Name = "button5";
      this.button5.Size = new Size(84, 71);
      this.button5.TabIndex = 0;
      this.ttdatpong.SetToolTip((Control) this.button5, "Quản lý Người Dùng");
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button4.BackColor = SystemColors.GradientInactiveCaption;
      this.button4.BackgroundImage = (Image) componentResourceManager.GetObject("button4.BackgroundImage");
      this.button4.BackgroundImageLayout = ImageLayout.Zoom;
      this.button4.Enabled = false;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.ForeColor = System.Drawing.Color.Gold;
      this.button4.Location = new Point(361, 27);
      this.button4.Name = "button4";
      this.button4.Size = new Size(84, 71);
      this.button4.TabIndex = 0;
      this.ttdatpong.SetToolTip((Control) this.button4, "Báo cáo tài chính");
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button3.BackColor = SystemColors.GradientInactiveCaption;
      this.button3.BackgroundImage = (Image) componentResourceManager.GetObject("button3.BackgroundImage");
      this.button3.BackgroundImageLayout = ImageLayout.Zoom;
      this.button3.Enabled = false;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = System.Drawing.Color.Gold;
      this.button3.Location = new Point(468, 30);
      this.button3.Name = "button3";
      this.button3.Size = new Size(84, 71);
      this.button3.TabIndex = 0;
      this.ttdatpong.SetToolTip((Control) this.button3, "Quản lý Dịch Vụ");
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.btnRoomMan.BackColor = SystemColors.GradientInactiveCaption;
      this.btnRoomMan.BackgroundImage = (Image) componentResourceManager.GetObject("btnRoomMan.BackgroundImage");
      this.btnRoomMan.BackgroundImageLayout = ImageLayout.Zoom;
      this.btnRoomMan.Enabled = false;
      this.btnRoomMan.FlatAppearance.BorderSize = 0;
      this.btnRoomMan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
      this.btnRoomMan.FlatStyle = FlatStyle.Flat;
      this.btnRoomMan.ForeColor = System.Drawing.Color.Gold;
      this.btnRoomMan.Location = new Point(575, 27);
      this.btnRoomMan.Name = "btnRoomMan";
      this.btnRoomMan.Size = new Size(84, 71);
      this.btnRoomMan.TabIndex = 0;
      this.ttdatpong.SetToolTip((Control) this.btnRoomMan, "Quản lý phòng");
      this.btnRoomMan.UseVisualStyleBackColor = false;
      this.btnRoomMan.Click += new EventHandler(this.btnRoomMan_Click);
      this.btnBookingRoom.BackColor = SystemColors.GradientInactiveCaption;
      this.btnBookingRoom.BackgroundImage = (Image) componentResourceManager.GetObject("btnBookingRoom.BackgroundImage");
      this.btnBookingRoom.BackgroundImageLayout = ImageLayout.Zoom;
      this.btnBookingRoom.Enabled = false;
      this.btnBookingRoom.FlatAppearance.BorderSize = 0;
      this.btnBookingRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
      this.btnBookingRoom.FlatStyle = FlatStyle.Flat;
      this.btnBookingRoom.ForeColor = System.Drawing.Color.Gold;
      this.btnBookingRoom.Location = new Point(244, 30);
      this.btnBookingRoom.Name = "btnBookingRoom";
      this.btnBookingRoom.Size = new Size(84, 71);
      this.btnBookingRoom.TabIndex = 0;
      this.ttdatpong.SetToolTip((Control) this.btnBookingRoom, "Đặt Phòng");
      this.btnBookingRoom.UseVisualStyleBackColor = false;
      this.btnBookingRoom.Click += new EventHandler(this.btnBookingRoom_Click);
      this.cmbErrorRoom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.cmbErrorRoom.BackColor = SystemColors.GradientInactiveCaption;
      this.cmbErrorRoom.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbErrorRoom.Enabled = false;
      this.cmbErrorRoom.FormattingEnabled = true;
      this.cmbErrorRoom.Location = new Point(640, 572);
      this.cmbErrorRoom.Name = "cmbErrorRoom";
      this.cmbErrorRoom.Size = new Size(121, 24);
      this.cmbErrorRoom.TabIndex = 0;
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.button1.BackColor = SystemColors.GradientInactiveCaption;
      this.button1.Enabled = false;
      this.button1.Location = new Point(640, 601);
      this.button1.Name = "button1";
      this.button1.Size = new Size(121, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Báo hỏng";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
      this.menuStrip1.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.hệThốngToolStripMenuItem1,
        (ToolStripItem) this.phòngToolStripMenuItem1,
        (ToolStripItem) this.hóaĐơnToolStripMenuItem3,
        (ToolStripItem) this.quảnLýChungToolStripMenuItem,
        (ToolStripItem) this.trợGiúpToolStripMenuItem2
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1046, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      this.hệThốngToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.đăngNhậpToolStripMenuItem1,
        (ToolStripItem) this.đăngXuấtToolStripMenuItem1,
        (ToolStripItem) this.thoátToolStripMenuItem2,
        (ToolStripItem) this.đăngNhậpToolStripMenuItem2,
        (ToolStripItem) this.thoátToolStripMenuItem3
      });
      this.hệThốngToolStripMenuItem1.Name = "hệThốngToolStripMenuItem1";
      this.hệThốngToolStripMenuItem1.Size = new Size(90, 20);
      this.hệThốngToolStripMenuItem1.Text = "Chương trình";
      this.đăngNhậpToolStripMenuItem1.Name = "đăngNhậpToolStripMenuItem1";
      this.đăngNhậpToolStripMenuItem1.Size = new Size(203, 22);
      this.đăngNhậpToolStripMenuItem1.Text = "Tạo mới dữ liệu";
      this.đăngNhậpToolStripMenuItem1.Click += new EventHandler(this.đăngNhậpToolStripMenuItem1_Click);
      this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
      this.đăngXuấtToolStripMenuItem1.Size = new Size(203, 22);
      this.đăngXuấtToolStripMenuItem1.Text = "Thêm/Khôi phục dữ liệu";
      this.đăngXuấtToolStripMenuItem1.Click += new EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
      this.thoátToolStripMenuItem2.Name = "thoátToolStripMenuItem2";
      this.thoátToolStripMenuItem2.Size = new Size(203, 22);
      this.thoátToolStripMenuItem2.Text = "Sao/Lưu dữ liệu";
      this.thoátToolStripMenuItem2.Click += new EventHandler(this.thoátToolStripMenuItem2_Click);
      this.đăngNhậpToolStripMenuItem2.Name = "đăngNhậpToolStripMenuItem2";
      this.đăngNhậpToolStripMenuItem2.Size = new Size(203, 22);
      this.đăngNhậpToolStripMenuItem2.Text = "Đăng nhập";
      this.đăngNhậpToolStripMenuItem2.Click += new EventHandler(this.btnLogin_Click);
      this.thoátToolStripMenuItem3.Name = "thoátToolStripMenuItem3";
      this.thoátToolStripMenuItem3.Size = new Size(203, 22);
      this.thoátToolStripMenuItem3.Text = "Thoát";
      this.thoátToolStripMenuItem3.Click += new EventHandler(this.btnCancel_Click);
      this.phòngToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.quảnLýPhòngToolStripMenuItem2,
        (ToolStripItem) this.đặtPhòngToolStripMenuItem1
      });
      this.phòngToolStripMenuItem1.Name = "phòngToolStripMenuItem1";
      this.phòngToolStripMenuItem1.Size = new Size(54, 20);
      this.phòngToolStripMenuItem1.Text = "Phòng";
      this.quảnLýPhòngToolStripMenuItem2.Name = "quảnLýPhòngToolStripMenuItem2";
      this.quảnLýPhòngToolStripMenuItem2.Size = new Size(153, 22);
      this.quảnLýPhòngToolStripMenuItem2.Text = "Quản lý phòng";
      this.quảnLýPhòngToolStripMenuItem2.Click += new EventHandler(this.btnRoomMan_Click);
      this.đặtPhòngToolStripMenuItem1.Name = "đặtPhòngToolStripMenuItem1";
      this.đặtPhòngToolStripMenuItem1.Size = new Size(153, 22);
      this.đặtPhòngToolStripMenuItem1.Text = "Đặt Phòng";
      this.đặtPhòngToolStripMenuItem1.Click += new EventHandler(this.btnBookingRoom_Click);
      this.hóaĐơnToolStripMenuItem3.Enabled = false;
      this.hóaĐơnToolStripMenuItem3.Name = "hóaĐơnToolStripMenuItem3";
      this.hóaĐơnToolStripMenuItem3.Size = new Size(61, 20);
      this.hóaĐơnToolStripMenuItem3.Text = "Báo cáo";
      this.hóaĐơnToolStripMenuItem3.Click += new EventHandler(this.button4_Click);
      this.quảnLýChungToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.dịchVụToolStripMenuItem2,
        (ToolStripItem) this.ngườiDùngToolStripMenuItem2,
        (ToolStripItem) this.nângCaoToolStripMenuItem,
        (ToolStripItem) this.kháchHàngToolStripMenuItem
      });
      this.quảnLýChungToolStripMenuItem.Name = "quảnLýChungToolStripMenuItem";
      this.quảnLýChungToolStripMenuItem.Size = new Size(60, 20);
      this.quảnLýChungToolStripMenuItem.Text = "Quản lý";
      this.dịchVụToolStripMenuItem2.Name = "dịchVụToolStripMenuItem2";
      this.dịchVụToolStripMenuItem2.Size = new Size(138, 22);
      this.dịchVụToolStripMenuItem2.Text = "Dịch vụ";
      this.dịchVụToolStripMenuItem2.Click += new EventHandler(this.button3_Click);
      this.ngườiDùngToolStripMenuItem2.Name = "ngườiDùngToolStripMenuItem2";
      this.ngườiDùngToolStripMenuItem2.Size = new Size(138, 22);
      this.ngườiDùngToolStripMenuItem2.Text = "Người dùng";
      this.ngườiDùngToolStripMenuItem2.Click += new EventHandler(this.button5_Click);
      this.nângCaoToolStripMenuItem.Name = "nângCaoToolStripMenuItem";
      this.nângCaoToolStripMenuItem.Size = new Size(138, 22);
      this.nângCaoToolStripMenuItem.Text = "Khách hàng";
      this.nângCaoToolStripMenuItem.Click += new EventHandler(this.nângCaoToolStripMenuItem_Click);
      this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
      this.kháchHàngToolStripMenuItem.Size = new Size(138, 22);
      this.kháchHàngToolStripMenuItem.Text = "Quốc tịch";
      this.kháchHàngToolStripMenuItem.Click += new EventHandler(this.kháchHàngToolStripMenuItem_Click);
      this.trợGiúpToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.thôngTinSảnPhẩmToolStripMenuItem,
        (ToolStripItem) this.hướngDẫnSửDụngToolStripMenuItem2,
        (ToolStripItem) this.thôngTinKháchSạnToolStripMenuItem
      });
      this.trợGiúpToolStripMenuItem2.Name = "trợGiúpToolStripMenuItem2";
      this.trợGiúpToolStripMenuItem2.Size = new Size(64, 20);
      this.trợGiúpToolStripMenuItem2.Text = "Trợ giúp";
      this.thôngTinSảnPhẩmToolStripMenuItem.Name = "thôngTinSảnPhẩmToolStripMenuItem";
      this.thôngTinSảnPhẩmToolStripMenuItem.Size = new Size(182, 22);
      this.thôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm";
      this.thôngTinSảnPhẩmToolStripMenuItem.Click += new EventHandler(this.thôngTinSảnPhẩmToolStripMenuItem_Click);
      this.hướngDẫnSửDụngToolStripMenuItem2.Name = "hướngDẫnSửDụngToolStripMenuItem2";
      this.hướngDẫnSửDụngToolStripMenuItem2.Size = new Size(182, 22);
      this.hướngDẫnSửDụngToolStripMenuItem2.Text = "Hướng dẫn sử dụng";
      this.hướngDẫnSửDụngToolStripMenuItem2.Click += new EventHandler(this.hướngDẫnSửDụngToolStripMenuItem2_Click);
      this.thôngTinKháchSạnToolStripMenuItem.Name = "thôngTinKháchSạnToolStripMenuItem";
      this.thôngTinKháchSạnToolStripMenuItem.Size = new Size(182, 22);
      this.thôngTinKháchSạnToolStripMenuItem.Text = "Thông tin khách sạn";
      this.thôngTinKháchSạnToolStripMenuItem.Click += new EventHandler(this.thôngTinKháchSạnToolStripMenuItem_Click);
      this.btnVAT.AccessibleDescription = "";
      this.btnVAT.AccessibleName = "";
      this.btnVAT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnVAT.BackColor = SystemColors.GradientInactiveCaption;
      this.btnVAT.Enabled = false;
      this.btnVAT.Location = new Point(767, 572);
      this.btnVAT.Name = "btnVAT";
      this.btnVAT.Size = new Size(93, 52);
      this.btnVAT.TabIndex = 10;
      this.btnVAT.Text = "VAT";
      this.btnVAT.UseVisualStyleBackColor = false;
      this.btnVAT.Click += new EventHandler(this.btnVAT_Click);
      this.grvLoan.AllowDrop = true;
      this.grvLoan.AllowUserToAddRows = false;
      this.grvLoan.AllowUserToDeleteRows = false;
      this.grvLoan.AllowUserToResizeRows = false;
      gridViewCellStyle7.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle7.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
      this.grvLoan.AlternatingRowsDefaultCellStyle = gridViewCellStyle7;
      this.grvLoan.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.grvLoan.BorderStyle = BorderStyle.Fixed3D;
      this.grvLoan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      this.grvLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.grvLoan.Dock = DockStyle.Fill;
      this.grvLoan.GridColor = SystemColors.Control;
      this.grvLoan.Location = new Point(3, 3);
      this.grvLoan.MultiSelect = false;
      this.grvLoan.Name = "grvLoan";
      this.grvLoan.ReadOnly = true;
      this.grvLoan.RowHeadersVisible = false;
      this.grvLoan.SelectionMode = DataGridViewSelectionMode.CellSelect;
      this.grvLoan.Size = new Size(218, 238);
      this.grvLoan.TabIndex = 2;
      this.Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.Column4.DataPropertyName = "Cost";
      gridViewCellStyle8.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle8.ForeColor = SystemColors.WindowText;
      gridViewCellStyle8.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle8.SelectionForeColor = SystemColors.WindowText;
      this.Column4.DefaultCellStyle = gridViewCellStyle8;
      this.Column4.HeaderText = "Nợ";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Resizable = DataGridViewTriState.False;
      this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column3.DataPropertyName = "RoomNo";
      gridViewCellStyle9.BackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle9.ForeColor = SystemColors.WindowText;
      gridViewCellStyle9.SelectionBackColor = SystemColors.GradientInactiveCaption;
      gridViewCellStyle9.SelectionForeColor = SystemColors.WindowText;
      this.Column3.DefaultCellStyle = gridViewCellStyle9;
      this.Column3.HeaderText = "Phòng";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Resizable = DataGridViewTriState.False;
      this.tabPage2.BackColor = SystemColors.GradientInactiveCaption;
      this.tabPage2.Controls.Add((Control) this.grvLoan);
      this.tabPage2.Location = new Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(224, 244);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Khách nợ";
      this.AutoScaleDimensions = new SizeF(9f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.BackgroundImageLayout = ImageLayout.Center;
      this.ClientSize = new Size(1046, 629);
      this.Controls.Add((Control) this.btnVAT);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.cmbErrorRoom);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.btnRoomMan);
      this.Controls.Add((Control) this.btnBookingRoom);
      this.Controls.Add((Control) this.plRoom);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MinimumSize = new Size(1062, 650);
      this.Name = nameof (Main);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Phần mềm quản lý khách sạn, nhà nghỉ - Version 3.0 - Developed by Cgroup";
      this.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
      this.Load += new EventHandler(this.Main_Load);
      this.plRoom.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((ISupportInitialize) this.grvCrSer).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      ((ISupportInitialize) this.grvBooking).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((ISupportInitialize) this.grvSpending).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((ISupportInitialize) this.grvLoan).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public int AttendID
    {
      get => this._AttendID;
      set => this._AttendID = value;
    }

    public int IsReg
    {
      get => this._isReg;
      set => this._isReg = value;
    }

    public string NAME
    {
      get => this._name;
      set => this._name = value;
    }

    public int UserType
    {
      get => this._userType;
      set => this._userType = value;
    }

    public int IsLogin
    {
      get => this._isLogin;
      set => this._isLogin = value;
    }

    public int USERID
    {
      set => this._userId = value;
      get => this._userId;
    }

    public Main() => this.InitializeComponent();

    private void CreateNewAttendance()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      Attendance entity = new Attendance()
      {
        UserID = new int?(this._userId),
        StartTime = new DateTime?(DateTime.Now)
      };
      smallHotelManager.Attendance.InsertOnSubmit(entity);
      smallHotelManager.SubmitChanges();
      this.AttendID = smallHotelManager.Attendance.Max<Attendance, int>((Expression<Func<Attendance, int>>) (p => p.AttendID));
      smallHotelManager.Connection.Close();
    }

    private void UpdateAttendance()
    {
      if (this.AttendID == 0)
        return;
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      Attendance attendance = smallHotelManager.Attendance.Where<Attendance>((Expression<Func<Attendance, bool>>) (x => x.AttendID == this.AttendID)).Single<Attendance>();
      attendance.EndTime = new DateTime?(DateTime.Now);
      attendance.TotalTime = new int?((int) DateTime.Now.Subtract(attendance.StartTime.Value).TotalMinutes);
      smallHotelManager.SubmitChanges();
      smallHotelManager.Connection.Close();
    }

    public void getLogin()
    {
      this.roomId = "";
      if (this._isLogin == 1)
      {
        this.CreateNewAttendance();
        this.đăngNhậpToolStripMenuItem2.Text = "Đăng xuất";
        this.hóaĐơnToolStripMenuItem3.Enabled = true;
        this.nângCaoToolStripMenuItem.Enabled = true;
        this.timer1.Stop();
        this.lblLongin.ForeColor = System.Drawing.Color.SaddleBrown;
        this.btnLogin.ForeColor = System.Drawing.Color.Red;
        this.btnLogin.Text = "Đăng xuất";
        this.PerformRefresh();
        this.btnBookingRoom.Enabled = true;
        this.cmbErrorRoom.Enabled = true;
        this.button1.Enabled = true;
        this.btnVAT.Enabled = true;
        this.btnBookingRoom.BackgroundImage = (Image) Resources.bookColor;
        this.button4.Enabled = true;
        this.button4.BackgroundImage = (Image) Resources.billColor;
        if (this._userType == 2)
        {
          this.phòngToolStripMenuItem1.Enabled = true;
          this.quảnLýChungToolStripMenuItem.Enabled = true;
          this.đăngNhậpToolStripMenuItem1.Enabled = true;
          this.đăngXuấtToolStripMenuItem1.Enabled = true;
          this.thoátToolStripMenuItem2.Enabled = true;
          this.dịchVụToolStripMenuItem2.Enabled = true;
          this.ngườiDùngToolStripMenuItem2.Enabled = true;
          this.lblLongin.Text = this._name + "\nQuản lý";
          this.button3.Enabled = true;
          this.button3.BackgroundImage = (Image) Resources.serviceColor;
          this.btnRoomMan.Enabled = true;
          this.btnRoomMan.BackgroundImage = (Image) Resources.roomColor;
          this.button5.Enabled = true;
          this.button5.BackgroundImage = (Image) Resources.userColor;
          this.plRoom.Enabled = true;
          this.groupBox1.Enabled = true;
          this.groupBox2.Enabled = true;
          this.groupBox3.Enabled = true;
        }
        if (this._userType != 3)
          return;
        this.phòngToolStripMenuItem1.Enabled = true;
        this.quảnLýChungToolStripMenuItem.Enabled = true;
        this.quảnLýPhòngToolStripMenuItem2.Enabled = false;
        this.ngườiDùngToolStripMenuItem2.Enabled = false;
        this.dịchVụToolStripMenuItem2.Enabled = false;
        this.lblLongin.Text = this._name + "\nNhân viên";
        this.plRoom.Enabled = true;
        this.groupBox1.Enabled = true;
        this.groupBox2.Enabled = true;
        this.groupBox3.Enabled = true;
      }
      else
      {
        this.hóaĐơnToolStripMenuItem3.Enabled = false;
        this.btnVAT.Enabled = false;
        this.phòngToolStripMenuItem1.Enabled = false;
        this.quảnLýChungToolStripMenuItem.Enabled = false;
        this.đăngNhậpToolStripMenuItem1.Enabled = false;
        this.đăngXuấtToolStripMenuItem1.Enabled = false;
        this.thoátToolStripMenuItem2.Enabled = false;
        this.ngườiDùngToolStripMenuItem2.Enabled = false;
        this.nângCaoToolStripMenuItem.Enabled = false;
        this.timer1.Start();
        this.đăngNhậpToolStripMenuItem2.Text = "Đăng nhập";
        this.lblLongin.ForeColor = System.Drawing.Color.Red;
        this.btnLogin.ForeColor = System.Drawing.Color.LimeGreen;
        this.btnLogin.Text = "Đăng nhập";
        this.tlp.Controls.Clear();
        this.grvCrSer.Rows.Clear();
        this.grvBooking.Rows.Clear();
        this.grvSpending.DataSource = (object) null;
        this.cmbErrorRoom.DataSource = (object) null;
        this.lblLongin.Text = "Hãy đăng nhập\nđể có thể sử dụng!!!";
        this.cmbErrorRoom.Enabled = false;
        this.button1.Enabled = false;
        this.btnRoomMan.Enabled = false;
        this.btnRoomMan.BackgroundImage = (Image) Resources.room;
        this.btnBookingRoom.Enabled = false;
        this.btnBookingRoom.BackgroundImage = (Image) Resources.book;
        this.button3.Enabled = false;
        this.button3.BackgroundImage = (Image) Resources.service;
        this.button4.Enabled = false;
        this.button4.BackgroundImage = (Image) Resources.bill;
        this.button5.Enabled = false;
        this.button5.BackgroundImage = (Image) Resources.user;
        this.plRoom.Enabled = false;
        this.groupBox1.Enabled = false;
        this.groupBox2.Enabled = false;
        this.groupBox3.Enabled = false;
        this.tabControl1.SelectedIndex = 0;
        this.tabControl2.SelectedIndex = 0;
        this.UpdateAttendance();
      }
    }

    public void listServiceData()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.grvCrSer.Rows.Clear();
      this.grvCrSer.DataSource = (object) smallHotelManager.Services.Where<Services>((Expression<Func<Services, bool>>) (s => s.ServiceID != 1 && s.DelID == new int?())).Select(s => new
      {
        Name = s.Name,
        TotalNumber = s.TotalNumber
      });
    }

    public void listBookingData()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.grvBooking.Rows.Clear();
      DateTime date = DateTime.Now.Date;
      IQueryable<\u003C\u003Ef__AnonymousType29<string, string>> source = smallHotelManager.BookedRoom.Where<BookedRoom>((Expression<Func<BookedRoom, bool>>) (b => b.BookingDate.Value.Date == date)).Select(b => new
      {
        NameOfBooker = b.NameOfBooker,
        PhoneNumber = b.PhoneNumber
      });
      if (source.Any())
        this.grvBooking.DataSource = (object) source;
      else
        this.grvBooking.ColumnHeadersVisible = false;
    }

    public int getLoanRoomCost(int loanid)
    {
      DateTime sd;
      ref DateTime local = ref sd;
      DateTime now = DateTime.Now;
      int year = now.Year;
      now = DateTime.Now;
      int month = now.Month;
      now = DateTime.Now;
      int day = now.Day;
      DateTime dateTime = new DateTime(year, month, day, 5, 0, 0);
      local = dateTime;
      DateTime ed = sd.AddDays(1.0);
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<IGrouping<int, \u003C\u003Ef__AnonymousType2a<int, int?, int?, int?, int?>>> source1 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).Where(data => data.r.CheckInTime >= (DateTime?) sd && data.r.CheckInTime <= (DateTime?) ed && data.r.PurchaseID == data.s.PurchaseID && data.r.Loan == (int?) loanid).Select(data => new
      {
        PurchaseID = data.r.PurchaseID,
        RoomCost = data.r.Cost * (int?) 1000,
        ServiceCost = data.s.Cost * (int?) 1000,
        Loan = data.r.Loan,
        Prepaid = data.r.Repaid * (int?) 1000
      }).GroupBy(x => x.PurchaseID);
      if (source1.Any<IGrouping<int, \u003C\u003Ef__AnonymousType2a<int, int?, int?, int?, int?>>>())
      {
        foreach (IGrouping<int, \u003C\u003Ef__AnonymousType2a<int, int?, int?, int?, int?>> source2 in source1)
        {
          int num5 = num1;
          int? nullable = source2.Select(u => u.RoomCost).First<int?>();
          int num6 = int.Parse(nullable.ToString());
          num1 = num5 + num6;
          foreach (var data in source2)
          {
            int num7 = num2;
            nullable = data.ServiceCost;
            int num8 = int.Parse(nullable.ToString());
            num2 = num7 + num8;
          }
          int num9 = num3;
          nullable = source2.Select(u => u.Prepaid).First<int?>();
          int num10 = int.Parse(nullable.ToString());
          num3 = num9 + num10;
        }
      }
      IQueryable<IGrouping<int, \u003C\u003Ef__AnonymousType2b<int, int?, int?>>> source3 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<OutExpense>>>) (r => db.OutExpense), (r, s) => new
      {
        r = r,
        s = s
      }).Where(data => data.r.CheckInTime >= (DateTime?) sd && data.r.CheckInTime <= (DateTime?) ed && data.r.PurchaseID == data.s.PurchaseID && data.r.Loan == (int?) loanid).Select(data => new
      {
        PurchaseID = data.r.PurchaseID,
        outCost = data.s.Cost * (int?) 1000,
        Loan = data.r.Loan
      }).GroupBy(x => x.PurchaseID);
      if (source3.Any<IGrouping<int, \u003C\u003Ef__AnonymousType2b<int, int?, int?>>>())
      {
        foreach (IEnumerable<\u003C\u003Ef__AnonymousType2b<int, int?, int?>> datas in source3)
        {
          foreach (var data in datas)
            num4 += int.Parse(data.outCost.ToString());
        }
      }
      return num1 + num2 + num4 + num3;
    }

    public void grvSpendingData()
    {
      DateTime sd;
      ref DateTime local = ref sd;
      DateTime now = DateTime.Now;
      int year = now.Year;
      now = DateTime.Now;
      int month = now.Month;
      now = DateTime.Now;
      int day = now.Day;
      DateTime dateTime1 = new DateTime(year, month, day, 5, 0, 0);
      local = dateTime1;
      DateTime ed = sd.AddDays(1.0);
      if (this._isLogin != 1)
        return;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.grvSpending.DataSource = (object) null;
      DataGridViewTextBoxColumn viewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      DataGridViewTextBoxCell gridViewTextBoxCell = new DataGridViewTextBoxCell();
      viewTextBoxColumn1.DataPropertyName = "Name";
      viewTextBoxColumn1.DefaultCellStyle.BackColor = this.BackColor;
      viewTextBoxColumn1.CellTemplate = (DataGridViewCell) gridViewTextBoxCell;
      viewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      viewTextBoxColumn1.DefaultCellStyle.SelectionBackColor = this.BackColor;
      viewTextBoxColumn1.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
      this.grvSpending.Columns.Add((DataGridViewColumn) viewTextBoxColumn1);
      DataGridViewTextBoxColumn viewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      viewTextBoxColumn2.CellTemplate = (DataGridViewCell) gridViewTextBoxCell;
      viewTextBoxColumn2.DataPropertyName = "Cost";
      viewTextBoxColumn2.DefaultCellStyle.BackColor = this.BackColor;
      viewTextBoxColumn2.DefaultCellStyle.SelectionBackColor = this.BackColor;
      viewTextBoxColumn2.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
      this.grvSpending.Columns.Add((DataGridViewColumn) viewTextBoxColumn2);
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("Name", typeof (string));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("Cost", typeof (string));
      dataTable.Columns.Add(column2);
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      List<int> source1 = new List<int>();
      IQueryable<IGrouping<int, \u003C\u003Ef__AnonymousType2a<int, int?, int?, int?, int?>>> source2 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).Where(data => data.r.CheckInTime >= (DateTime?) sd && data.r.CheckInTime <= (DateTime?) ed && data.r.CheckOutTime.HasValue && data.r.PurchaseID == data.s.PurchaseID).Select(data => new
      {
        PurchaseID = data.r.PurchaseID,
        RoomCost = data.r.Cost * (int?) 1000,
        ServiceCost = data.s.Cost * (int?) 1000,
        Loan = data.r.Loan,
        Prepaid = data.r.Repaid * (int?) 1000
      }).GroupBy(x => x.PurchaseID);
      DateTime dateTime2 = new DateTime(1990, 8, 30, 0, 0, 0);
      if (source2.Any<IGrouping<int, \u003C\u003Ef__AnonymousType2a<int, int?, int?, int?, int?>>>())
      {
        foreach (IGrouping<int, \u003C\u003Ef__AnonymousType2a<int, int?, int?, int?, int?>> source3 in source2)
        {
          int? nullable = source3.Select(u => u.Loan).First<int?>();
          if (nullable.Value == 0)
          {
            int num6 = num1;
            nullable = source3.Select(u => u.RoomCost).First<int?>();
            int num7 = int.Parse(nullable.ToString());
            num1 = num6 + num7;
            foreach (var data in source3)
            {
              int num8 = num3;
              nullable = data.ServiceCost;
              int num9 = int.Parse(nullable.ToString());
              num3 = num8 + num9;
            }
          }
          else
          {
            nullable = source3.Select(u => u.Loan).First<int?>();
            int loanID = nullable.Value;
            if (this.CheckLoanRoomByDate(loanID) != dateTime2 && this.CheckLoanRoomByDate(loanID) >= sd && this.CheckLoanRoomByDate(loanID) <= ed)
              source1.Add(loanID);
          }
          int num10 = num4;
          nullable = source3.Select(u => u.Prepaid).First<int?>();
          int num11 = int.Parse(nullable.ToString());
          num4 = num10 + num11;
        }
      }
      else
        num1 = 0;
      IQueryable<IGrouping<int, \u003C\u003Ef__AnonymousType2b<int, int?, int?>>> source4 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<OutExpense>>>) (r => db.OutExpense), (r, s) => new
      {
        r = r,
        s = s
      }).Where(data => data.r.CheckInTime >= (DateTime?) sd && data.r.CheckInTime <= (DateTime?) ed && data.r.CheckOutTime.HasValue && data.r.PurchaseID == data.s.PurchaseID).Select(data => new
      {
        PurchaseID = data.r.PurchaseID,
        outCost = data.s.Cost * (int?) 1000,
        Loan = data.r.Loan
      }).GroupBy(x => x.PurchaseID);
      if (source4.Any<IGrouping<int, \u003C\u003Ef__AnonymousType2b<int, int?, int?>>>())
      {
        foreach (IGrouping<int, \u003C\u003Ef__AnonymousType2b<int, int?, int?>> source5 in source4)
        {
          int? nullable = source5.Select(u => u.Loan).First<int?>();
          if (nullable.Value == 0)
          {
            foreach (var data in source5)
            {
              int num12 = num5;
              nullable = data.outCost;
              int num13 = int.Parse(nullable.ToString());
              num5 = num12 + num13;
            }
          }
        }
      }
      foreach (int loanid in source1.Distinct<int>().ToList<int>())
        num1 += this.getLoanRoomCost(loanid);
      DataRow row1 = dataTable.NewRow();
      row1["Name"] = (object) "Thực thu ";
      row1["Cost"] = (object) string.Format("{0:0,0}", (object) (num1 + num3 + num4 + num5));
      dataTable.Rows.Add(row1);
      DataRow row2 = dataTable.NewRow();
      row2["Name"] = (object) "Chi";
      row2["Cost"] = (object) "";
      dataTable.Rows.Add(row2);
      IQueryable<Spending> source6 = db.Spending.Where<Spending>((Expression<Func<Spending, bool>>) (s => s.SpendDate >= (DateTime?) sd && s.SpendDate <= (DateTime?) ed));
      if (source6.Any<Spending>())
      {
        foreach (Spending spending in (IEnumerable<Spending>) source6)
        {
          DataRow row3 = dataTable.NewRow();
          row3["Name"] = (object) ("    " + spending.Reasson);
          DataRow dataRow = row3;
          int? cost = spending.Cost;
          string str = string.Format("{0:0,0}", (object) (cost.Value * 1000));
          dataRow["Cost"] = (object) str;
          dataTable.Rows.Add(row3);
          int num14 = num2;
          cost = spending.Cost;
          int num15 = cost.Value * 1000;
          num2 = num14 + num15;
        }
      }
      DataRow row4 = dataTable.NewRow();
      row4["Name"] = (object) "Còn lại ";
      row4["Cost"] = (object) string.Format("{0:0,0}", (object) (num1 + num3 + num4 + num5 - num2));
      dataTable.Rows.Add(row4);
      IQueryable<OutInCome> queryable = db.OutInCome.Where<OutInCome>((Expression<Func<OutInCome, bool>>) (v => v.DateIncome.Value.Date == DateTime.Now.Date));
      int num16 = 0;
      foreach (OutInCome outInCome in (IEnumerable<OutInCome>) queryable)
        num16 += outInCome.Cost.Value * 1000;
      DataRow row5 = dataTable.NewRow();
      row5["Name"] = (object) "Thu VAT ";
      row5["Cost"] = (object) string.Format("{0:0,0}", (object) num16);
      dataTable.Rows.Add(row5);
      this.grvSpending.DataSource = (object) dataTable;
      DataGridViewButtonCell gridViewButtonCell = new DataGridViewButtonCell();
      this.grvSpending.Rows[1].Cells[0] = (DataGridViewCell) gridViewButtonCell;
      gridViewButtonCell.Style.BackColor = System.Drawing.Color.LightSeaGreen;
      gridViewButtonCell.ToolTipText = "Thêm chi phí";
      gridViewButtonCell.UseColumnTextForButtonValue = true;
      this.grvSpending.ResumeLayout();
      this.Refresh();
    }

    public void PerformRefresh()
    {
      this.RoomCreating();
      this.listBookingData();
      this.listServiceData();
      this.grvSpendingData();
      this.bindToErrorRoom();
      this.bindLoanData();
    }

    public void RoomCreating()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this.roomId == "")
      {
        IQueryable<\u003C\u003Ef__AnonymousType2c<int, string, int, int?, string, int>> source = smallHotelManager.Room.OrderBy<Room, string>((Expression<Func<Room, string>>) (r => r.RoomNo)).Select(r => new
        {
          RoomID = r.RoomID,
          RoomNo = r.RoomNo,
          StatusID = r.StatusID,
          PurchaseID = r.PurchaseID,
          Not = r.Not,
          TypeID = r.TypeID
        });
        this.tlp.Controls.Clear();
        if (source.Count() <= 0)
          return;
        DataTable dt = new DataTable();
        DataColumn column1 = new DataColumn("RoomID", typeof (int));
        dt.Columns.Add(column1);
        DataColumn column2 = new DataColumn("RoomNo", typeof (string));
        dt.Columns.Add(column2);
        DataColumn column3 = new DataColumn("Status", typeof (int));
        dt.Columns.Add(column3);
        DataColumn column4 = new DataColumn("Type", typeof (int));
        dt.Columns.Add(column4);
        DataColumn column5 = new DataColumn("PurchaseID", typeof (int));
        dt.Columns.Add(column5);
        DataColumn column6 = new DataColumn("Note", typeof (string));
        dt.Columns.Add(column6);
        foreach (var data in source)
        {
          DataRow row = dt.NewRow();
          row["RoomID"] = (object) data.RoomID;
          row["RoomNo"] = (object) data.RoomNo;
          row["Status"] = (object) data.StatusID;
          if (data.PurchaseID.HasValue)
            row["PurchaseID"] = (object) data.PurchaseID;
          if (data.Not.Any<char>())
            row["Note"] = (object) data.Not;
          row["Type"] = (object) data.TypeID;
          dt.Rows.Add(row);
        }
        int countRoom = 0;
        for (int index = 0; index < dt.Rows.Count; ++index)
        {
          int num = (int) dt.Rows[countRoom]["Status"];
          int typ = (int) dt.Rows[countRoom]["Type"];
          this.btnRoom = new Button();
          this.btnRoom.Height = 75;
          this.btnRoom.Width = 150;
          this.btnRoom.FlatStyle = FlatStyle.Flat;
          this.btnRoom.FlatAppearance.BorderSize = 1;
          this.btnRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
          this.btnRoom.Cursor = Cursors.Hand;
          this.btnRoom.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Pixel);
          RoomType roomType = smallHotelManager.RoomType.Single<RoomType>((Expression<Func<RoomType, bool>>) (u => u.TypeID == typ));
          this.btnRoom.Text = dt.Rows[countRoom]["RoomNo"].ToString();
          this.btnRoom.Tag = (object) dt.Rows[countRoom]["Status"].ToString();
          this.btnRoom.Name = dt.Rows[countRoom]["RoomNo"].ToString();
          this.btnRoom.AccessibleDescription = "";
          switch (num)
          {
            case 2:
              this.ttdatpong.SetToolTip((Control) this.btnRoom, "Phòng trống\nLoại phòng:" + roomType.TypeName);
              this.btnRoom.BackColor = System.Drawing.Color.White;
              break;
            case 3:
              if (smallHotelManager.RoomPurchaseInfo.Single<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == (int) dt.Rows[countRoom]["PurchaseID"])).Loan.HasValue)
                this.btnRoom.Text += "\n(lưu)";
              this.ttdatpong.SetToolTip((Control) this.btnRoom, "Phòng đang sử dụng\nLoại phòng:" + roomType.TypeName);
              this.btnRoom.BackColor = System.Drawing.Color.GreenYellow;
              this.btnRoom.AccessibleDescription = dt.Rows[countRoom]["PurchaseID"].ToString();
              break;
            case 4:
              this.ttdatpong.SetToolTip((Control) this.btnRoom, "Phòng cần được dọn dẹp\nLoại phòng: " + roomType.TypeName);
              this.btnRoom.BackColor = System.Drawing.Color.Orange;
              break;
            case 5:
              this.ttdatpong.SetToolTip((Control) this.btnRoom, dt.Rows[countRoom]["Note"].ToString() + "\nLoại phòng:" + roomType.TypeName);
              this.btnRoom.BackColor = System.Drawing.Color.Red;
              break;
          }
          this.btnRoom.Click += new EventHandler(this.btnRoom_Click);
          this.tlp.Controls.Add((Control) this.btnRoom);
          ++countRoom;
        }
      }
      else
      {
        Room ro = smallHotelManager.Room.Where<Room>((Expression<Func<Room, bool>>) (x => x.RoomNo == this.roomId)).Single<Room>();
        int statusId = ro.StatusID;
        int typ = ro.TypeID;
        Button button = ((IEnumerable<Control>) this.tlp.Controls.Find(this.roomId, true)).FirstOrDefault<Control>() as Button;
        RoomType roomType = smallHotelManager.RoomType.Single<RoomType>((Expression<Func<RoomType, bool>>) (u => u.TypeID == typ));
        button.Text = ro.RoomNo.ToString();
        button.Tag = (object) statusId.ToString();
        button.Name = ro.RoomNo.ToString();
        button.AccessibleDescription = "";
        switch (statusId)
        {
          case 2:
            this.ttdatpong.SetToolTip((Control) this.btnRoom, "Phòng trống\nLoại phòng:" + roomType.TypeName);
            button.BackColor = System.Drawing.Color.White;
            break;
          case 3:
            if (smallHotelManager.RoomPurchaseInfo.Single<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == (int) ro.PurchaseID)).Loan.HasValue)
              button.Text += "\n(lưu)";
            this.ttdatpong.SetToolTip((Control) this.btnRoom, "Phòng đang sử dụng\nLoại phòng:" + roomType.TypeName);
            button.BackColor = System.Drawing.Color.GreenYellow;
            button.AccessibleDescription = ro.PurchaseID.ToString();
            break;
          case 4:
            this.ttdatpong.SetToolTip((Control) this.btnRoom, "Phòng cần được dọn dẹp\nLoại phòng: " + roomType.TypeName);
            button.BackColor = System.Drawing.Color.Orange;
            break;
          case 5:
            this.ttdatpong.SetToolTip((Control) this.btnRoom, ro.Not.ToString() + "\nLoại phòng:" + roomType.TypeName);
            button.BackColor = System.Drawing.Color.Red;
            break;
        }
        this.tlp.Refresh();
      }
    }

    public void bindLoanData()
    {
      if (this.tabControl1.SelectedIndex != 1)
        return;
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      DataTable dataTable = new DataTable();
      DataColumn column1 = new DataColumn("RoomNo", typeof (string));
      dataTable.Columns.Add(column1);
      DataColumn column2 = new DataColumn("Cost", typeof (string));
      dataTable.Columns.Add(column2);
      IQueryable<\u003C\u003Ef__AnonymousType2d<int, string, int?, int?, int?>> source1 = db.RoomPurchaseInfo.SelectMany((Expression<Func<RoomPurchaseInfo, IEnumerable<ServicesPurchaseInfo>>>) (r => db.ServicesPurchaseInfo), (r, s) => new
      {
        r = r,
        s = s
      }).Where(data => data.r.Loan.HasValue && data.r.Loan.Value != 0 && data.r.Cost.HasValue && data.r.PurchaseID == data.s.PurchaseID && data.r.IsPaid == (int?) 0).Select(data => new
      {
        PurchaseID = data.r.PurchaseID,
        RoomNo = data.r.RoomNo,
        RoomCost = data.r.Cost - data.r.RoomDiscount - data.r.SerDiscount,
        ServiceCost = data.s.Cost,
        Loan = data.r.Loan
      });
      if (source1.Any())
      {
        IQueryable<\u003C\u003Ef__AnonymousType2e<string, int?, int?>> source2 = source1.GroupBy(r => new
        {
          PurchaseID = r.PurchaseID
        }).Select(g => new
        {
          RoomNo = g.Select(r => r.RoomNo).First<string>(),
          TotalCost = g.Sum(r => r.ServiceCost) + g.Select(r => r.RoomCost).First<int?>(),
          Loan = g.Select(r => r.Loan).First<int?>()
        });
        IQueryable<IGrouping<\u003C\u003Ef__AnonymousType2f<int?>, \u003C\u003Ef__AnonymousType2e<string, int?, int?>>> source3 = source2.GroupBy(r => new
        {
          Loan = r.Loan
        });
        Expression<Func<IGrouping<\u003C\u003Ef__AnonymousType2f<int?>, \u003C\u003Ef__AnonymousType2e<string, int?, int?>>, \u003C\u003Ef__AnonymousType2e<string, int?, int?>>> selector = g => new
        {
          RoomNo = g.Select(r => r.RoomNo).First<string>(),
          TotalCost = g.Sum(r => r.TotalCost),
          Loan = g.Select(r => r.Loan).First<int?>()
        };
        using (IEnumerator<\u003C\u003Ef__AnonymousType2e<string, int?, int?>> enumerator = source3.Select(selector).GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            var item = enumerator.Current;
            int num1 = 0;
            IQueryable<IGrouping<string, \u003C\u003Ef__AnonymousType2e<string, int?, int?>>> queryable1 = source2.Where(x => x.Loan == item.Loan).GroupBy(r => r.RoomNo);
            IQueryable<int?> queryable2 = db.OutExpense.SelectMany((Expression<Func<OutExpense, IEnumerable<RoomPurchaseInfo>>>) (r => db.RoomPurchaseInfo), (r, s) => new
            {
              r = r,
              s = s
            }).Where(data => data.r.PurchaseID == data.s.PurchaseID && data.s.Loan == item.Loan).Select(data => data.r.Cost);
            DataRow row = dataTable.NewRow();
            foreach (IGrouping<string, \u003C\u003Ef__AnonymousType2e<string, int?, int?>> grouping in queryable1)
            {
              DataRow dataRow;
              (dataRow = row)["RoomNo"] = (object) (dataRow["RoomNo"].ToString() + grouping.Key + " ");
            }
            foreach (int? nullable in (IEnumerable<int?>) queryable2)
              num1 += nullable.Value;
            DataRow dataRow1 = row;
            int? nullable1 = item.TotalCost;
            int num2 = num1;
            nullable1 = nullable1.HasValue ? new int?(nullable1.GetValueOrDefault() + num2) : new int?();
            string str = string.Format("{0:0,0}", (object) (nullable1.HasValue ? new int?(nullable1.GetValueOrDefault() * 1000) : new int?()));
            dataRow1["Cost"] = (object) str;
            dataTable.Rows.Add(row);
          }
        }
      }
      this.grvLoan.DataSource = (object) dataTable;
      db.Connection.Close();
    }

    private void btnRoom_Click(object sender, EventArgs e)
    {
      if (this.rmf != null && !this.rmf.IsDisposed || !(sender is Button))
        return;
      int num1 = int.Parse(((Control) sender).Tag.ToString());
      string str = ((Control) sender).Name.ToString();
      int num2 = !(((Control) sender).AccessibleDescription != "") ? 0 : int.Parse(((Control) sender).AccessibleDescription.ToString());
      this.roomId = ((Control) sender).Name;
      this.rmf = new RoomInf(this);
      this.rmf.MdiParent = this.MdiParent;
      this.rmf.STATUS = num1;
      this.rmf.ROOMNO = str;
      this.rmf.PURCHASEID = num2;
      this.rmf.USERID = this._userId;
      this.rmf.UserType = this._userType;
      int num3 = (int) this.rmf.ShowDialog();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void btnRoomMan_Click(object sender, EventArgs e)
    {
      this.roomId = "";
      int num = (int) new RoomManger(this).ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      int num = (int) new BillManager(this).ShowDialog();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      int num = (int) new UserManager(this).ShowDialog();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      if (this._isLogin == 0)
      {
        if (this.lg != null && !this.lg.IsDisposed)
          return;
        this.lg = new LoginForm(this);
        this.lg.MdiParent = this.MdiParent;
        int num = (int) this.lg.ShowDialog();
      }
      else if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        this.IsLogin = 0;
        this.USERID = 0;
        this.NAME = "";
        this.UserType = 0;
        this.getLogin();
      }
    }

    private void Main_Load(object sender, EventArgs e)
    {
      using (MD5 md5Hash = MD5.Create())
      {
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\\\regSMK\\\\regSMK");
        if (registryKey == null)
        {
          this.si = new SortInfo(this);
          this.si.MdiParent = this.MdiParent;
          this.si.IsReg = 0;
          this.si.IsFirst = 1;
          int num = (int) this.si.ShowDialog();
        }
        else
        {
          string hash = (string) registryKey.GetValue("Reged");
          string uniqueId = this.getUniqueID("C");
          if (Main.VerifyMd5Hash(md5Hash, uniqueId, hash))
          {
            this.si = new SortInfo(this);
            this.si.MdiParent = this.MdiParent;
            this.si.IsFirst = 1;
            this.si.IsReg = 1;
            int num = (int) this.si.ShowDialog();
            this.IsReg = 1;
            this.getLogin();
          }
          else
          {
            this.IsReg = 0;
            this.si = new SortInfo(this);
            this.si.MdiParent = this.MdiParent;
            this.si.IsFirst = 1;
            this.si.IsReg = 0;
            int num = (int) this.si.ShowDialog();
          }
        }
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (this.count % 2 == 0)
        this.lblLongin.Text = (string) null;
      else
        this.lblLongin.Text = "Hãy đăng nhập\nđể có thể sử dụng!!!";
      ++this.count;
      if (this.count != 100)
        return;
      this.count = 1;
    }

    private void grvSpending_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (!((string) this.grvSpending.CurrentCell.Value == "Chi") || this.sp != null && !this.sp.IsDisposed)
        return;
      this.sp = new AddSpending(this);
      this.sp.MdiParent = this.MdiParent;
      int num = (int) this.sp.ShowDialog();
    }

    public void bindToErrorRoom()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.cmbErrorRoom.DataSource = (object) null;
      this.cmbErrorRoom.DataSource = (object) smallHotelManager.Room.Where<Room>((Expression<Func<Room, bool>>) (r => r.StatusID == 2 || r.StatusID == 4)).OrderBy<Room, string>((Expression<Func<Room, string>>) (r => r.RoomNo));
      this.cmbErrorRoom.DisplayMember = "RoomNo";
      this.cmbErrorRoom.ValueMember = "RoomID";
      smallHotelManager.Dispose();
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

    private static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash) => 0 == StringComparer.OrdinalIgnoreCase.Compare(Main.GetMd5Hash(md5Hash, input), hash);

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this._isReg == 0)
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        RegistryKey currentUser = Registry.CurrentUser;
        RegistryKey subKey = currentUser.CreateSubKey("Software\\\\regSMK\\\\regSMK");
        string times = subKey.GetValue("Times").ToString();
        int t = 0;
        IQueryable<UsingTime> source1 = smallHotelManager.UsingTime.Where<UsingTime>((Expression<Func<UsingTime, bool>>) (u => u.KeyName.Equals(times)));
        if (source1.Any<UsingTime>())
        {
          foreach (UsingTime usingTime in (IEnumerable<UsingTime>) source1)
            t = usingTime.ID;
          --t;
          IQueryable<UsingTime> source2 = smallHotelManager.UsingTime.Where<UsingTime>((Expression<Func<UsingTime, bool>>) (tu => tu.ID == t));
          if (source2.Any<UsingTime>())
          {
            foreach (UsingTime usingTime in (IEnumerable<UsingTime>) source2)
              subKey.SetValue("Times", (object) usingTime.KeyName.ToString());
          }
          else
            subKey.SetValue("Times", (object) "ooo");
        }
        currentUser.Close();
        subKey.Close();
      }
      this.Dispose();
    }

    private void btnBookingRoom_Click(object sender, EventArgs e)
    {
      this.br = new BookingRoom(this);
      int num = (int) this.br.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.sm = new ServicesManager(this);
      int num = (int) this.sm.ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.ar != null && !this.ar.IsDisposed || this.cmbErrorRoom.Items.Count <= 0)
        return;
      this.roomId = "";
      this.ar = new AddNewError(this);
      this.ar.MdiParent = this.MdiParent;
      this.ar.Roomid = int.Parse(this.cmbErrorRoom.SelectedValue.ToString());
      int num = (int) this.ar.ShowDialog();
    }

    private void thôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.sif != null && !this.sif.IsDisposed)
        return;
      this.sif = new SortInfo(this);
      this.sif.MdiParent = this.MdiParent;
      this.sif.IsReg = this._isReg;
      this.sif.IsFirst = 0;
      int num = (int) this.sif.ShowDialog();
    }

    private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Bạn có chắc muốn tạo mới dữ liệu?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      string currentDirectory = Directory.GetCurrentDirectory();
      string str1 = "SmallHotelManager.sdf";
      string str2 = currentDirectory + "\\" + str1;
      string sourceFileName = currentDirectory + "\\Backup" + "\\" + "SmallHotelManager.sdf";
      try
      {
        File.Delete(str2);
        File.Copy(sourceFileName, str2);
        int num = (int) MessageBox.Show("Tạo mới dữ liệu thành công!");
        this.PerformRefresh();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void hướngDẫnSửDụngToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(Directory.GetCurrentDirectory() + "\\" + "HelpSHMCg.chm");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Không tìm thấy file hướng dẫn");
      }
    }

    private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      string currentDirectory = Directory.GetCurrentDirectory();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = currentDirectory + "\\Data\\";
      openFileDialog.Filter = "SDF Files (*.sdf)|*.sdf";
      openFileDialog.RestoreDirectory = true;
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        string fileName = openFileDialog.FileName;
        string str1 = "SmallHotelManager.sdf";
        string str2 = currentDirectory + "\\" + str1;
        try
        {
          File.Delete(str2);
          File.Copy(fileName, str2);
          int num = (int) MessageBox.Show("Khôi phục dữ liệu thành công");
          this.PerformRefresh();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show(ex.Message);
        }
      }
      openFileDialog.Dispose();
    }

    private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Bạn có chắc muốn lưu dữ liệu?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      string currentDirectory = Directory.GetCurrentDirectory();
      string str1 = "SmallHotelManager.sdf";
      string sourceFileName = currentDirectory + "\\" + str1;
      DateTime now = DateTime.Now;
      int num1 = now.Day;
      string str2 = num1.ToString();
      now = DateTime.Now;
      num1 = now.Month;
      string str3 = num1.ToString();
      now = DateTime.Now;
      num1 = now.Year;
      string str4 = num1.ToString();
      string str5 = str2 + "_" + str3 + "_" + str4;
      string path = currentDirectory + "\\Data\\" + str5;
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      string str6 = "SmallHotelManager.sdf";
      string str7 = path + "\\" + str6;
      try
      {
        File.Delete(str7);
        File.Copy(sourceFileName, str7);
        int num2 = (int) MessageBox.Show("Lưu dữ liệu thành công");
      }
      catch (Exception ex)
      {
        int num3 = (int) MessageBox.Show(ex.Message);
      }
    }

    private void nângCaoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.adm != null && !this.adm.IsDisposed)
        return;
      this.adm = new CustomerReport();
      int num = (int) this.adm.ShowDialog();
    }

    private void btnVAT_Click(object sender, EventArgs e)
    {
      if (this.va != null && !this.va.IsDisposed)
        return;
      this.va = new VAT(this);
      int num = (int) this.va.ShowDialog();
    }

    private void tabControl2_SelectedIndexChanged(object sender, EventArgs e) => this.grvSpendingData();

    private void thôngTinKháchSạnToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.hi != null && !this.hi.IsDisposed)
        return;
      this.hi = new HotelInfo();
      int num = (int) this.hi.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e) => this.listBookingData();

    private void button6_Click(object sender, EventArgs e) => this.grvSpendingData();

    private DateTime CheckLoanRoomByDate(int loanID)
    {
      DateTime dateTime = new DateTime(1990, 8, 30, 0, 0, 0);
      RoomPurchaseInfo roomPurchaseInfo = ((IEnumerable<RoomPurchaseInfo>) new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (u => u.Loan == (int?) loanID)).ToArray<RoomPurchaseInfo>()).Last<RoomPurchaseInfo>();
      return roomPurchaseInfo.CheckOutTime.HasValue ? roomPurchaseInfo.CheckInTime.Value : dateTime;
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.tabControl1.SelectedIndex != 1)
        return;
      this.bindLoanData();
    }

    private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.nm != null && !this.nm.IsDisposed)
        return;
      this.nm = new NationalManager();
      int num = (int) this.nm.ShowDialog();
    }
  }
}
