// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.RoomInf
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using SmallHotelManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class RoomInf : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private ToolTip toolTip1;
    private Button btnPrint;
    private GroupBox groupBox5;
    private Label label4;
    private RadioButton btnNo;
    private RadioButton btnYes;
    private Button btnDestroyBill;
    private Button btnChangeRoom;
    private ComboBox cmbChangeRoom;
    private GroupBox groupBox4;
    private LinkLabel linkLabel1;
    private Label lblCost;
    private Button btnCancel;
    private Button btnOK;
    private TabPage tabPage2;
    private GroupBox groupBox7;
    private GroupBox groupBox6;
    private Button button2;
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
    private TabPage tabPage1;
    private GroupBox groupBox3;
    private Button button1;
    private Label label14;
    private TextBox txtCost;
    private Label label13;
    private TextBox txtReason;
    private Label label11;
    private Label label10;
    private TextBox txtPrepaid;
    private Label label9;
    private GroupBox groupBox2;
    private Label label6;
    private Label label5;
    private DataGridView grvBuySer;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn Column5;
    private DataGridView grvCrSer;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column6;
    private Button btnSub;
    private Button btnAdd;
    private GroupBox groupBox1;
    private ComboBox comboBox1;
    private CheckBox cbGetInTime;
    private Label lblPrePaid;
    private Label label12;
    private Label lblCITime;
    private Label lblRoomType;
    private Label label8;
    private Label lblStatus;
    private Label label7;
    private Label lblCOTime;
    private Label label3;
    private Label label2;
    private TabControl tabControl1;
    private GroupBox groupBox8;
    private Label lblUnit2;
    private Label lblUnit1;
    private Label label21;
    private TextBox txtDisService;
    private Label label19;
    private TextBox txtDisRoom;
    private Button btnDiscount;
    private Label lblDiscount;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private Label label22;
    private TextBox txtPhoneNum;
    private int _userId;
    private string _roomNo;
    private int _status;
    private int _purchaseId = 0;
    private Main _parent;
    private DataTable dtCrSer = (DataTable) null;
    private DataTable dtBuySer = (DataTable) null;
    private int _prepaid = 0;
    private int _cusId = 0;
    private int _discount1 = 0;
    private int _discount2 = 0;
    private int _userType = 0;
    private DateTime _ciTime = DateTime.Now;
    private PaymentDetail pd = (PaymentDetail) null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (RoomInf));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      this.label1 = new Label();
      this.toolTip1 = new ToolTip(this.components);
      this.linkLabel1 = new LinkLabel();
      this.btnAdd = new Button();
      this.btnSub = new Button();
      this.button1 = new Button();
      this.btnPrint = new Button();
      this.groupBox5 = new GroupBox();
      this.label4 = new Label();
      this.btnNo = new RadioButton();
      this.btnYes = new RadioButton();
      this.btnDestroyBill = new Button();
      this.btnChangeRoom = new Button();
      this.cmbChangeRoom = new ComboBox();
      this.groupBox4 = new GroupBox();
      this.lblCost = new Label();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.tabPage2 = new TabPage();
      this.groupBox7 = new GroupBox();
      this.lblDiscount = new Label();
      this.btnDiscount = new Button();
      this.lblUnit2 = new Label();
      this.lblUnit1 = new Label();
      this.label21 = new Label();
      this.txtDisService = new TextBox();
      this.label19 = new Label();
      this.txtDisRoom = new TextBox();
      this.groupBox8 = new GroupBox();
      this.radioButton2 = new RadioButton();
      this.radioButton1 = new RadioButton();
      this.groupBox6 = new GroupBox();
      this.label22 = new Label();
      this.txtPhoneNum = new TextBox();
      this.button2 = new Button();
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
      this.tabPage1 = new TabPage();
      this.groupBox3 = new GroupBox();
      this.label14 = new Label();
      this.txtCost = new TextBox();
      this.label13 = new Label();
      this.txtReason = new TextBox();
      this.label11 = new Label();
      this.label10 = new Label();
      this.txtPrepaid = new TextBox();
      this.label9 = new Label();
      this.groupBox2 = new GroupBox();
      this.label6 = new Label();
      this.label5 = new Label();
      this.grvBuySer = new DataGridView();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.grvCrSer = new DataGridView();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column6 = new DataGridViewTextBoxColumn();
      this.groupBox1 = new GroupBox();
      this.comboBox1 = new ComboBox();
      this.cbGetInTime = new CheckBox();
      this.lblPrePaid = new Label();
      this.label12 = new Label();
      this.lblCITime = new Label();
      this.lblRoomType = new Label();
      this.label8 = new Label();
      this.lblStatus = new Label();
      this.label7 = new Label();
      this.lblCOTime = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.tabControl1 = new TabControl();
      this.groupBox5.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.grvBuySer).BeginInit();
      ((ISupportInitialize) this.grvCrSer).BeginInit();
      this.groupBox1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.OrangeRed;
      this.label1.Location = new Point(92, -2);
      this.label1.Name = "label1";
      this.label1.Size = new Size(108, 55);
      this.label1.TabIndex = 5;
      this.label1.Text = "101";
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new Point(224, 42);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(47, 16);
      this.linkLabel1.TabIndex = 7;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Chi tiết";
      this.toolTip1.SetToolTip((Control) this.linkLabel1, "Chi tiết thanh toán");
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.btnAdd.BackgroundImage = (Image) componentResourceManager.GetObject("btnAdd.BackgroundImage");
      this.btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnAdd.FlatAppearance.BorderSize = 0;
      this.btnAdd.FlatStyle = FlatStyle.Flat;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(126, 83);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(25, 25);
      this.btnAdd.TabIndex = 10;
      this.toolTip1.SetToolTip((Control) this.btnAdd, "Sử dụng thêm");
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.btnSub.BackgroundImage = (Image) Resources.agt_back;
      this.btnSub.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnSub.FlatAppearance.BorderSize = 0;
      this.btnSub.FlatStyle = FlatStyle.Flat;
      this.btnSub.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSub.Location = new Point(126, 131);
      this.btnSub.Name = "btnSub";
      this.btnSub.Size = new Size(25, 25);
      this.btnSub.TabIndex = 11;
      this.toolTip1.SetToolTip((Control) this.btnSub, "Trả lại");
      this.btnSub.UseVisualStyleBackColor = true;
      this.btnSub.Click += new EventHandler(this.btnSub_Click);
      this.button1.BackgroundImage = (Image) Resources.Add;
      this.button1.BackgroundImageLayout = ImageLayout.Stretch;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(243, 46);
      this.button1.Name = "button1";
      this.button1.Size = new Size(25, 25);
      this.button1.TabIndex = 27;
      this.toolTip1.SetToolTip((Control) this.button1, "Thêm");
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.btnPrint.BackColor = SystemColors.GradientInactiveCaption;
      this.btnPrint.Enabled = false;
      this.btnPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnPrint.Location = new Point(12, 645);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new Size(85, 24);
      this.btnPrint.TabIndex = 49;
      this.btnPrint.Text = "In hóa đơn";
      this.btnPrint.UseVisualStyleBackColor = false;
      this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
      this.groupBox5.Controls.Add((Control) this.label4);
      this.groupBox5.Controls.Add((Control) this.btnNo);
      this.groupBox5.Controls.Add((Control) this.btnYes);
      this.groupBox5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox5.Location = new Point(12, 518);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(277, 54);
      this.groupBox5.TabIndex = 48;
      this.groupBox5.TabStop = false;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(9, 18);
      this.label4.Name = "label4";
      this.label4.Size = new Size(106, 16);
      this.label4.TabIndex = 2;
      this.label4.Text = "Khách có ở tiếp?";
      this.btnNo.AutoSize = true;
      this.btnNo.Checked = true;
      this.btnNo.Location = new Point(121, 16);
      this.btnNo.Name = "btnNo";
      this.btnNo.Size = new Size(64, 20);
      this.btnNo.TabIndex = 1;
      this.btnNo.TabStop = true;
      this.btnNo.Text = "Không";
      this.btnNo.UseVisualStyleBackColor = true;
      this.btnNo.CheckedChanged += new EventHandler(this.btnNo_CheckedChanged);
      this.btnYes.AutoSize = true;
      this.btnYes.Location = new Point(212, 16);
      this.btnYes.Name = "btnYes";
      this.btnYes.Size = new Size(43, 20);
      this.btnYes.TabIndex = 0;
      this.btnYes.Text = "Có";
      this.btnYes.UseVisualStyleBackColor = true;
      this.btnYes.CheckedChanged += new EventHandler(this.btnYes_CheckedChanged);
      this.btnDestroyBill.BackColor = SystemColors.GradientInactiveCaption;
      this.btnDestroyBill.Enabled = false;
      this.btnDestroyBill.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnDestroyBill.Location = new Point(109, 675);
      this.btnDestroyBill.Name = "btnDestroyBill";
      this.btnDestroyBill.Size = new Size(77, 42);
      this.btnDestroyBill.TabIndex = 47;
      this.btnDestroyBill.Text = "Hủy thanh toán";
      this.btnDestroyBill.UseVisualStyleBackColor = false;
      this.btnDestroyBill.Click += new EventHandler(this.btnDestroyBill_Click);
      this.btnChangeRoom.BackColor = SystemColors.GradientInactiveCaption;
      this.btnChangeRoom.Enabled = false;
      this.btnChangeRoom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnChangeRoom.Location = new Point(201, 645);
      this.btnChangeRoom.Name = "btnChangeRoom";
      this.btnChangeRoom.Size = new Size(85, 24);
      this.btnChangeRoom.TabIndex = 46;
      this.btnChangeRoom.Text = "Đổi phòng";
      this.btnChangeRoom.UseVisualStyleBackColor = false;
      this.btnChangeRoom.Click += new EventHandler(this.btnChangeRoom_Click);
      this.cmbChangeRoom.BackColor = SystemColors.ButtonHighlight;
      this.cmbChangeRoom.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbChangeRoom.Enabled = false;
      this.cmbChangeRoom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbChangeRoom.FormattingEnabled = true;
      this.cmbChangeRoom.Location = new Point(105, 645);
      this.cmbChangeRoom.Name = "cmbChangeRoom";
      this.cmbChangeRoom.Size = new Size(90, 24);
      this.cmbChangeRoom.TabIndex = 45;
      this.groupBox4.Controls.Add((Control) this.linkLabel1);
      this.groupBox4.Controls.Add((Control) this.lblCost);
      this.groupBox4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox4.Location = new Point(12, 578);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(277, 63);
      this.groupBox4.TabIndex = 44;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Thành tiền";
      this.lblCost.AutoSize = true;
      this.lblCost.Font = new Font("Microsoft Sans Serif", 27.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblCost.ForeColor = Color.Orange;
      this.lblCost.Location = new Point(29, 16);
      this.lblCost.Name = "lblCost";
      this.lblCost.Size = new Size(133, 42);
      this.lblCost.TabIndex = 6;
      this.lblCost.Text = "0 VNĐ";
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(211, 675);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 42);
      this.btnCancel.TabIndex = 43;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnOK.BackColor = SystemColors.GradientInactiveCaption;
      this.btnOK.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnOK.Location = new Point(12, 675);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(84, 42);
      this.btnOK.TabIndex = 42;
      this.btnOK.Text = "Vào phòng";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.tabPage2.BackColor = SystemColors.GradientInactiveCaption;
      this.tabPage2.Controls.Add((Control) this.groupBox7);
      this.tabPage2.Controls.Add((Control) this.groupBox6);
      this.tabPage2.Location = new Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(289, 444);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "T.tin khách hàng / Chiết khấu";
      this.groupBox7.Controls.Add((Control) this.lblDiscount);
      this.groupBox7.Controls.Add((Control) this.btnDiscount);
      this.groupBox7.Controls.Add((Control) this.lblUnit2);
      this.groupBox7.Controls.Add((Control) this.lblUnit1);
      this.groupBox7.Controls.Add((Control) this.label21);
      this.groupBox7.Controls.Add((Control) this.txtDisService);
      this.groupBox7.Controls.Add((Control) this.label19);
      this.groupBox7.Controls.Add((Control) this.txtDisRoom);
      this.groupBox7.Controls.Add((Control) this.groupBox8);
      this.groupBox7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox7.Location = new Point(4, 234);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(279, 200);
      this.groupBox7.TabIndex = 1;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Chiết khấu";
      this.lblDiscount.AutoSize = true;
      this.lblDiscount.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblDiscount.ForeColor = Color.Red;
      this.lblDiscount.Location = new Point(76, 114);
      this.lblDiscount.Name = "lblDiscount";
      this.lblDiscount.Size = new Size(105, 33);
      this.lblDiscount.TabIndex = 29;
      this.lblDiscount.Text = "0 VNĐ";
      this.btnDiscount.BackColor = SystemColors.GradientInactiveCaption;
      this.btnDiscount.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnDiscount.Location = new Point(6, 158);
      this.btnDiscount.Name = "btnDiscount";
      this.btnDiscount.Size = new Size(266, 36);
      this.btnDiscount.TabIndex = 28;
      this.btnDiscount.Text = "Chiết khấu";
      this.btnDiscount.UseVisualStyleBackColor = false;
      this.btnDiscount.Click += new EventHandler(this.btnDiscount_Click);
      this.lblUnit2.AutoSize = true;
      this.lblUnit2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblUnit2.Location = new Point(181, 84);
      this.lblUnit2.Name = "lblUnit2";
      this.lblUnit2.Size = new Size(71, 16);
      this.lblUnit2.TabIndex = 27;
      this.lblUnit2.Text = ".000 (VNĐ)";
      this.lblUnit1.AutoSize = true;
      this.lblUnit1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblUnit1.Location = new Point(181, 56);
      this.lblUnit1.Name = "lblUnit1";
      this.lblUnit1.Size = new Size(71, 16);
      this.lblUnit1.TabIndex = 26;
      this.lblUnit1.Text = ".000 (VNĐ)";
      this.label21.AutoSize = true;
      this.label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label21.Location = new Point(5, 84);
      this.label21.Name = "label21";
      this.label21.Size = new Size(80, 16);
      this.label21.TabIndex = 25;
      this.label21.Text = "Tiền dịch vụ";
      this.txtDisService.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDisService.Location = new Point(87, 81);
      this.txtDisService.Name = "txtDisService";
      this.txtDisService.Size = new Size(89, 22);
      this.txtDisService.TabIndex = 24;
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.Location = new Point(5, 56);
      this.label19.Name = "label19";
      this.label19.Size = new Size(76, 16);
      this.label19.TabIndex = 23;
      this.label19.Text = "Tiền phòng";
      this.txtDisRoom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDisRoom.Location = new Point(87, 53);
      this.txtDisRoom.Name = "txtDisRoom";
      this.txtDisRoom.Size = new Size(89, 22);
      this.txtDisRoom.TabIndex = 22;
      this.groupBox8.Controls.Add((Control) this.radioButton2);
      this.groupBox8.Controls.Add((Control) this.radioButton1);
      this.groupBox8.Location = new Point(9, 13);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new Size(264, 34);
      this.groupBox8.TabIndex = 0;
      this.groupBox8.TabStop = false;
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new Point(105, 11);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(86, 20);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Phần trăm";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.radioButton1.AutoSize = true;
      this.radioButton1.Checked = true;
      this.radioButton1.Location = new Point(7, 11);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(78, 20);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Tiền mặt";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.groupBox6.Controls.Add((Control) this.label22);
      this.groupBox6.Controls.Add((Control) this.txtPhoneNum);
      this.groupBox6.Controls.Add((Control) this.button2);
      this.groupBox6.Controls.Add((Control) this.btnSave);
      this.groupBox6.Controls.Add((Control) this.label20);
      this.groupBox6.Controls.Add((Control) this.comboBox2);
      this.groupBox6.Controls.Add((Control) this.label18);
      this.groupBox6.Controls.Add((Control) this.txtIdNo);
      this.groupBox6.Controls.Add((Control) this.txtAddress);
      this.groupBox6.Controls.Add((Control) this.txtCompany);
      this.groupBox6.Controls.Add((Control) this.txtName);
      this.groupBox6.Controls.Add((Control) this.label17);
      this.groupBox6.Controls.Add((Control) this.label16);
      this.groupBox6.Controls.Add((Control) this.label15);
      this.groupBox6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox6.Location = new Point(3, 7);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(280, 224);
      this.groupBox6.TabIndex = 0;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Thông tin khách hàng";
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.Location = new Point(6, 168);
      this.label22.Name = "label22";
      this.label22.Size = new Size(35, 16);
      this.label22.TabIndex = 27;
      this.label22.Text = "SĐT";
      this.txtPhoneNum.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhoneNum.Location = new Point(64, 165);
      this.txtPhoneNum.Name = "txtPhoneNum";
      this.txtPhoneNum.Size = new Size(149, 22);
      this.txtPhoneNum.TabIndex = 6;
      this.button2.BackColor = SystemColors.GradientInactiveCaption;
      this.button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.Location = new Point(174, 192);
      this.button2.Name = "button2";
      this.button2.Size = new Size(100, 26);
      this.button2.TabIndex = 8;
      this.button2.Text = "Sửa";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.btnSave.BackColor = SystemColors.GradientInactiveCaption;
      this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Location = new Point(9, 192);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(96, 26);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "Lưu";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.Location = new Point(6, 54);
      this.label20.Name = "label20";
      this.label20.Size = new Size(63, 16);
      this.label20.TabIndex = 23;
      this.label20.Text = "Quốc tịch";
      this.comboBox2.BackColor = SystemColors.GradientInactiveCaption;
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(73, 51);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(140, 24);
      this.comboBox2.TabIndex = 2;
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.Location = new Point(6, 140);
      this.label18.Name = "label18";
      this.label18.Size = new Size(57, 16);
      this.label18.TabIndex = 21;
      this.label18.Text = "CMTND";
      this.txtIdNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtIdNo.Location = new Point(64, 137);
      this.txtIdNo.Name = "txtIdNo";
      this.txtIdNo.Size = new Size(149, 22);
      this.txtIdNo.TabIndex = 5;
      this.txtAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtAddress.Location = new Point(64, 109);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new Size(210, 22);
      this.txtAddress.TabIndex = 4;
      this.txtCompany.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCompany.Location = new Point(64, 81);
      this.txtCompany.Name = "txtCompany";
      this.txtCompany.Size = new Size(210, 22);
      this.txtCompany.TabIndex = 3;
      this.txtName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtName.Location = new Point(64, 22);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(210, 22);
      this.txtName.TabIndex = 1;
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.Location = new Point(6, 112);
      this.label17.Name = "label17";
      this.label17.Size = new Size(48, 16);
      this.label17.TabIndex = 19;
      this.label17.Text = "Địa chỉ";
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.Location = new Point(6, 84);
      this.label16.Name = "label16";
      this.label16.Size = new Size(53, 16);
      this.label16.TabIndex = 17;
      this.label16.Text = "Công ty";
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.Location = new Point(6, 25);
      this.label15.Name = "label15";
      this.label15.Size = new Size(47, 16);
      this.label15.TabIndex = 15;
      this.label15.Text = "Họ tên";
      this.tabPage1.BackColor = SystemColors.GradientInactiveCaption;
      this.tabPage1.Controls.Add((Control) this.groupBox3);
      this.tabPage1.Controls.Add((Control) this.label10);
      this.tabPage1.Controls.Add((Control) this.txtPrepaid);
      this.tabPage1.Controls.Add((Control) this.label9);
      this.tabPage1.Controls.Add((Control) this.groupBox2);
      this.tabPage1.Controls.Add((Control) this.groupBox1);
      this.tabPage1.Location = new Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(289, 444);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Cơ bản";
      this.groupBox3.Controls.Add((Control) this.button1);
      this.groupBox3.Controls.Add((Control) this.label14);
      this.groupBox3.Controls.Add((Control) this.txtCost);
      this.groupBox3.Controls.Add((Control) this.label13);
      this.groupBox3.Controls.Add((Control) this.txtReason);
      this.groupBox3.Controls.Add((Control) this.label11);
      this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox3.Location = new Point(3, 363);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(277, 75);
      this.groupBox3.TabIndex = 40;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Thu thêm";
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.Location = new Point(160, 52);
      this.label14.Name = "label14";
      this.label14.Size = new Size(72, 16);
      this.label14.TabIndex = 26;
      this.label14.Text = ".000 (VND)";
      this.txtCost.Location = new Point(73, 49);
      this.txtCost.Name = "txtCost";
      this.txtCost.Size = new Size(81, 22);
      this.txtCost.TabIndex = 5;
      this.label13.AutoSize = true;
      this.label13.Location = new Point(9, 52);
      this.label13.Name = "label13";
      this.label13.Size = new Size(49, 16);
      this.label13.TabIndex = 4;
      this.label13.Text = "Sô tiền";
      this.txtReason.Location = new Point(73, 21);
      this.txtReason.Name = "txtReason";
      this.txtReason.Size = new Size(198, 22);
      this.txtReason.TabIndex = 3;
      this.label11.AutoSize = true;
      this.label11.Location = new Point(9, 24);
      this.label11.Name = "label11";
      this.label11.Size = new Size(41, 16);
      this.label11.TabIndex = 2;
      this.label11.Text = "Lý do";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(183, 344);
      this.label10.Name = "label10";
      this.label10.Size = new Size(72, 16);
      this.label10.TabIndex = 39;
      this.label10.Text = ".000 (VND)";
      this.txtPrepaid.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPrepaid.Location = new Point(77, 341);
      this.txtPrepaid.Name = "txtPrepaid";
      this.txtPrepaid.Size = new Size(100, 22);
      this.txtPrepaid.TabIndex = 38;
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(10, 344);
      this.label9.Name = "label9";
      this.label9.Size = new Size(61, 16);
      this.label9.TabIndex = 37;
      this.label9.Text = "Trả trước";
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Controls.Add((Control) this.grvBuySer);
      this.groupBox2.Controls.Add((Control) this.grvCrSer);
      this.groupBox2.Controls.Add((Control) this.btnSub);
      this.groupBox2.Controls.Add((Control) this.btnAdd);
      this.groupBox2.Location = new Point(3, 129);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(277, 206);
      this.groupBox2.TabIndex = 31;
      this.groupBox2.TabStop = false;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(163, 16);
      this.label6.Name = "label6";
      this.label6.Size = new Size(75, 16);
      this.label6.TabIndex = 17;
      this.label6.Text = "Đã sử dụng";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(9, 16);
      this.label5.Name = "label5";
      this.label5.Size = new Size(52, 16);
      this.label5.TabIndex = 16;
      this.label5.Text = "Dịch vụ";
      this.grvBuySer.AllowUserToAddRows = false;
      this.grvBuySer.AllowUserToDeleteRows = false;
      this.grvBuySer.AllowUserToResizeRows = false;
      this.grvBuySer.BackgroundColor = SystemColors.Window;
      this.grvBuySer.CellBorderStyle = DataGridViewCellBorderStyle.None;
      this.grvBuySer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvBuySer.ColumnHeadersVisible = false;
      this.grvBuySer.Columns.AddRange((DataGridViewColumn) this.Column4, (DataGridViewColumn) this.dataGridViewTextBoxColumn1, (DataGridViewColumn) this.dataGridViewTextBoxColumn2, (DataGridViewColumn) this.Column5);
      this.grvBuySer.Location = new Point(157, 35);
      this.grvBuySer.MultiSelect = false;
      this.grvBuySer.Name = "grvBuySer";
      this.grvBuySer.ReadOnly = true;
      this.grvBuySer.RowHeadersVisible = false;
      this.grvBuySer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvBuySer.Size = new Size(114, 164);
      this.grvBuySer.TabIndex = 15;
      this.Column4.DataPropertyName = "ServiceID";
      this.Column4.HeaderText = "ServiceID";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Resizable = DataGridViewTriState.False;
      this.Column4.Visible = false;
      this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn1.HeaderText = "Name";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Number";
      this.dataGridViewTextBoxColumn2.HeaderText = "Number";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn2.Width = 5;
      this.Column5.DataPropertyName = "Price";
      this.Column5.HeaderText = "Price";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Resizable = DataGridViewTriState.False;
      this.Column5.Visible = false;
      this.grvCrSer.AllowUserToAddRows = false;
      this.grvCrSer.AllowUserToDeleteRows = false;
      this.grvCrSer.AllowUserToResizeRows = false;
      this.grvCrSer.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.grvCrSer.CellBorderStyle = DataGridViewCellBorderStyle.None;
      this.grvCrSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grvCrSer.ColumnHeadersVisible = false;
      this.grvCrSer.Columns.AddRange((DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column6);
      this.grvCrSer.GridColor = SystemColors.Control;
      this.grvCrSer.Location = new Point(6, 34);
      this.grvCrSer.MultiSelect = false;
      this.grvCrSer.Name = "grvCrSer";
      this.grvCrSer.ReadOnly = true;
      this.grvCrSer.RowHeadersVisible = false;
      this.grvCrSer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvCrSer.Size = new Size(114, 164);
      this.grvCrSer.TabIndex = 14;
      this.Column3.DataPropertyName = "ServiceID";
      this.Column3.HeaderText = "ServiceID";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Resizable = DataGridViewTriState.False;
      this.Column3.Visible = false;
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column1.DataPropertyName = "Name";
      gridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
      this.Column1.DefaultCellStyle = gridViewCellStyle1;
      this.Column1.HeaderText = "Name";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Resizable = DataGridViewTriState.False;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      this.Column2.DataPropertyName = "TotalNumber";
      gridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
      this.Column2.DefaultCellStyle = gridViewCellStyle2;
      this.Column2.HeaderText = "Number";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Resizable = DataGridViewTriState.False;
      this.Column2.Width = 5;
      this.Column6.DataPropertyName = "Price";
      this.Column6.HeaderText = "Price";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column6.Resizable = DataGridViewTriState.False;
      this.Column6.Visible = false;
      this.groupBox1.Controls.Add((Control) this.comboBox1);
      this.groupBox1.Controls.Add((Control) this.cbGetInTime);
      this.groupBox1.Controls.Add((Control) this.lblPrePaid);
      this.groupBox1.Controls.Add((Control) this.label12);
      this.groupBox1.Controls.Add((Control) this.lblCITime);
      this.groupBox1.Controls.Add((Control) this.lblRoomType);
      this.groupBox1.Controls.Add((Control) this.label8);
      this.groupBox1.Controls.Add((Control) this.lblStatus);
      this.groupBox1.Controls.Add((Control) this.label7);
      this.groupBox1.Controls.Add((Control) this.lblCOTime);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Location = new Point(3, -1);
      this.groupBox1.MinimumSize = new Size(277, 82);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(277, 124);
      this.groupBox1.TabIndex = 30;
      this.groupBox1.TabStop = false;
      this.comboBox1.BackColor = SystemColors.GradientInactiveCaption;
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.Enabled = false;
      this.comboBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(190, 94);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(81, 24);
      this.comboBox1.TabIndex = 46;
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.comboBox1.SelectionChangeCommitted += new EventHandler(this.comboBox1_SelectionChangeCommitted);
      this.cbGetInTime.AutoSize = true;
      this.cbGetInTime.Enabled = false;
      this.cbGetInTime.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cbGetInTime.Location = new Point(10, 96);
      this.cbGetInTime.Name = "cbGetInTime";
      this.cbGetInTime.Size = new Size(184, 20);
      this.cbGetInTime.TabIndex = 25;
      this.cbGetInTime.Text = "Lấy giờ vào của phòng";
      this.cbGetInTime.UseVisualStyleBackColor = true;
      this.cbGetInTime.CheckedChanged += new EventHandler(this.cbGetInTime_CheckedChanged);
      this.lblPrePaid.AutoSize = true;
      this.lblPrePaid.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblPrePaid.Location = new Point(97, 43);
      this.lblPrePaid.Name = "lblPrePaid";
      this.lblPrePaid.Size = new Size(0, 16);
      this.lblPrePaid.TabIndex = 24;
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(6, 43);
      this.label12.Name = "label12";
      this.label12.Size = new Size(91, 16);
      this.label12.TabIndex = 23;
      this.label12.Text = "Đã trả trước:";
      this.lblCITime.AutoSize = true;
      this.lblCITime.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblCITime.Location = new Point(79, 59);
      this.lblCITime.Name = "lblCITime";
      this.lblCITime.Size = new Size(0, 16);
      this.lblCITime.TabIndex = 22;
      this.lblRoomType.AutoSize = true;
      this.lblRoomType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblRoomType.Location = new Point(93, 27);
      this.lblRoomType.Name = "lblRoomType";
      this.lblRoomType.Size = new Size(45, 16);
      this.lblRoomType.TabIndex = 21;
      this.lblRoomType.Text = "label4";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(6, 27);
      this.label8.Name = "label8";
      this.label8.Size = new Size(89, 16);
      this.label8.TabIndex = 20;
      this.label8.Text = "Loại phòng:";
      this.lblStatus.AutoSize = true;
      this.lblStatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblStatus.Location = new Point(93, 11);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new Size(51, 16);
      this.lblStatus.TabIndex = 19;
      this.lblStatus.Text = "label6";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(6, 11);
      this.label7.Name = "label7";
      this.label7.Size = new Size(81, 16);
      this.label7.TabIndex = 18;
      this.label7.Text = "Tình trạng:";
      this.lblCOTime.AutoSize = true;
      this.lblCOTime.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lblCOTime.Location = new Point(79, 76);
      this.lblCOTime.Name = "lblCOTime";
      this.lblCOTime.Size = new Size(0, 16);
      this.lblCOTime.TabIndex = 17;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(7, 76);
      this.label3.Name = "label3";
      this.label3.Size = new Size(54, 16);
      this.label3.TabIndex = 15;
      this.label3.Text = "Giờ ra:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(7, 59);
      this.label2.Name = "label2";
      this.label2.Size = new Size(66, 16);
      this.label2.TabIndex = 14;
      this.label2.Text = "Giờ vào:";
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Location = new Point(-1, 46);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(297, 470);
      this.tabControl1.TabIndex = 6;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(294, 721);
      this.Controls.Add((Control) this.btnPrint);
      this.Controls.Add((Control) this.groupBox5);
      this.Controls.Add((Control) this.btnDestroyBill);
      this.Controls.Add((Control) this.btnChangeRoom);
      this.Controls.Add((Control) this.cmbChangeRoom);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.tabControl1);
      this.Controls.Add((Control) this.label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(310, 760);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(310, 760);
      this.Name = nameof (RoomInf);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Phòng";
      this.FormClosing += new FormClosingEventHandler(this.RoomInf_FormClosing);
      this.Load += new EventHandler(this.RoomInf_Load);
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((ISupportInitialize) this.grvBuySer).EndInit();
      ((ISupportInitialize) this.grvCrSer).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public int UserType
    {
      get => this._userType;
      set => this._userType = value;
    }

    public int CusId
    {
      get => this._cusId;
      set => this._cusId = value;
    }

    public int Prepaid
    {
      get => this._prepaid;
      set => this._prepaid = value;
    }

    public int USERID
    {
      set => this._userId = value;
      get => this._userId;
    }

    public int PURCHASEID
    {
      set => this._purchaseId = value;
      get => this._purchaseId;
    }

    public int STATUS
    {
      set => this._status = value;
      get => this._status;
    }

    public string ROOMNO
    {
      get => this._roomNo;
      set => this._roomNo = value;
    }

    public RoomInf(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
    }

    private void binddtCrSer()
    {
      IQueryable<\u003C\u003Ef__AnonymousTypef<int, string, int?, int?>> queryable = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").Services.Where<Services>((Expression<Func<Services, bool>>) (s => s.ServiceID != 1 && s.DelID == new int?())).Select(s => new
      {
        ServiceID = s.ServiceID,
        Name = s.Name,
        TotalNumber = s.TotalNumber,
        Price = s.Price
      });
      this.dtCrSer = new DataTable();
      this.dtCrSer.Columns.Add(new DataColumn("ServiceID", typeof (int)));
      this.dtCrSer.Columns.Add(new DataColumn("Name", typeof (string)));
      this.dtCrSer.Columns.Add(new DataColumn("TotalNumber", typeof (int)));
      this.dtCrSer.Columns.Add(new DataColumn("Price", typeof (int)));
      IQueryable<\u003C\u003Ef__AnonymousTypef<int, string, int?, int?>> source = queryable;
      Expression<Func<\u003C\u003Ef__AnonymousTypef<int, string, int?, int?>, string>> keySelector = x => x.Name;
      foreach (var data in source.OrderBy(keySelector))
      {
        DataRow row = this.dtCrSer.NewRow();
        row["ServiceID"] = (object) data.ServiceID;
        row["Name"] = (object) data.Name;
        int? totalNumber = data.TotalNumber;
        row["TotalNumber"] = !totalNumber.HasValue ? (object) 0 : (object) data.TotalNumber;
        row["Price"] = (object) data.Price;
        this.dtCrSer.Rows.Add(row);
      }
    }

    private void binddtBuySer(int prId)
    {
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType11<int?, string, int?, int?>> queryable = db.ServicesPurchaseInfo.SelectMany((Expression<Func<ServicesPurchaseInfo, IEnumerable<Services>>>) (sp => db.Services), (sp, s) => new
      {
        sp = sp,
        s = s
      }).Where(data => data.sp.PurchaseID == prId && data.sp.ServiceID == (int?) data.s.ServiceID).Select(data => new
      {
        ServiceID = data.sp.ServiceID,
        Name = data.s.Name,
        Number = data.sp.Number,
        Price = data.s.Price
      });
      IQueryable<\u003C\u003Ef__AnonymousType12<string, int?>> source = db.OutExpense.Where<OutExpense>((Expression<Func<OutExpense, bool>>) (s => s.PurchaseID == prId)).Select(s => new
      {
        ExpenseName = s.ExpenseName,
        Cost = s.Cost
      });
      this.CreatColumnBuySer();
      foreach (var data in queryable)
      {
        int? serviceId = data.ServiceID;
        if ((serviceId.GetValueOrDefault() != 1 ? 1 : (!serviceId.HasValue ? 1 : 0)) != 0)
        {
          DataRow row = this.dtBuySer.NewRow();
          row["ServiceID"] = (object) data.ServiceID;
          row["Name"] = (object) data.Name;
          row["Number"] = (object) data.Number;
          row["Price"] = (object) data.Price;
          this.dtBuySer.Rows.Add(row);
        }
      }
      if (source.Any())
      {
        foreach (var data in source)
        {
          DataRow row = this.dtBuySer.NewRow();
          row["ServiceID"] = (object) 0;
          row["Name"] = (object) data.ExpenseName;
          row["Number"] = (object) 1;
          row["Price"] = (object) data.Cost;
          this.dtBuySer.Rows.Add(row);
        }
      }
      db.Connection.Close();
    }

    private void CreatColumnBuySer()
    {
      this.dtBuySer = new DataTable();
      this.dtBuySer.Columns.Add(new DataColumn("ServiceID", typeof (int)));
      this.dtBuySer.Columns.Add(new DataColumn("Name", typeof (string)));
      this.dtBuySer.Columns.Add(new DataColumn("Number", typeof (int)));
      this.dtBuySer.Columns.Add(new DataColumn("Price", typeof (int)));
    }

    private void getUsingRoom()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.comboBox1.DataSource = (object) smallHotelManager.Room.Where<Room>((Expression<Func<Room, bool>>) (r => r.StatusID == 3)).Select(r => new
      {
        RoomNo = r.RoomNo,
        PurchaseID = r.PurchaseID
      });
      this.comboBox1.DisplayMember = "RoomNo";
      this.comboBox1.ValueMember = "PurchaseID";
      smallHotelManager.Connection.Close();
    }

    private void RoomInf_Load(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      string str = db.Room.SelectMany((Expression<Func<Room, IEnumerable<RoomType>>>) (r => db.RoomType), (r, t) => new
      {
        r = r,
        t = t
      }).Where(data => data.r.RoomNo.ToString() == this._roomNo.ToString() && data.r.TypeID == data.t.TypeID).Select(data => data.t.TypeName).Single<string>();
      if (this._status == 2)
      {
        DateTime now = DateTime.Now;
        this.lblStatus.Text = "Trống";
        this.lblRoomType.Text = str.ToString();
        this.lblCITime.Text = (this._ciTime.Hour.ToString() + "h" + (object) this._ciTime.Minute + "'              (" + (object) this._ciTime.Day + "/" + (object) this._ciTime.Month + "/" + (object) this._ciTime.Year + ")").ToString();
        this.label1.Text = this._roomNo.ToString();
        this.binddtCrSer();
        this.listCurrenServiceData();
        this.CreatColumnBuySer();
        this.GetNational();
        this.getUsingRoom();
        if (this.comboBox1.Items.Count > 0)
          this.cbGetInTime.Enabled = true;
        this.groupBox3.Enabled = false;
        this.groupBox4.Enabled = false;
        this.groupBox5.Enabled = false;
        this.groupBox7.Enabled = false;
      }
      else if (this._status == 3)
      {
        DateTime now = DateTime.Now;
        RoomPurchaseInfo roompur = db.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (rp => rp.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>();
        DateTime dateTime = roompur.CheckInTime.Value;
        int? nullable = roompur.Loan;
        if (nullable.HasValue)
        {
          nullable = Queryable.Sum(db.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.Loan == roompur.Loan)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Repaid)));
          this.Prepaid = int.Parse(nullable.ToString());
        }
        else
        {
          nullable = roompur.Repaid;
          this.Prepaid = nullable.Value;
        }
        this.lblPrePaid.Text = string.Format("{0:0,0}", (object) (this._prepaid * 1000));
        this.lblStatus.Text = "Đang sử dụng";
        this.lblRoomType.Text = str.ToString();
        this.lblStatus.ForeColor = Color.Green;
        this.lblCITime.Text = (dateTime.Hour.ToString() + "h" + (object) dateTime.Minute + "'              (" + (object) dateTime.Day + "/" + (object) dateTime.Month + "/" + (object) dateTime.Year + ")").ToString();
        this.lblCOTime.Text = (now.Hour.ToString() + "h" + (object) now.Minute + "'              (" + (object) now.Day + "/" + (object) now.Month + "/" + (object) now.Year + ")").ToString();
        nullable = roompur.CusID;
        if (nullable.HasValue)
        {
          nullable = roompur.CusID;
          this.CusId = nullable.Value;
        }
        this.GetNational();
        this.GetCusInfo();
        if (this._userType == 2)
          this.btnPrint.Enabled = true;
        this.cmbChangeRoom.Enabled = true;
        this.btnChangeRoom.Enabled = true;
        this.btnDestroyBill.Enabled = true;
        this.btnCancel.Text = "Tiếp tục sử dụng";
        this.comboChangeRoom();
        this.label1.Text = this._roomNo.ToString();
        this.binddtCrSer();
        this.listCurrenServiceData();
        this.binddtBuySer(this._purchaseId);
        this.listBuyServiceData();
        this.btnOK.Text = "Thanh toán";
        if (!db.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>().HasValue)
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
        else
          this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
      }
      else if (this._status == 4)
      {
        this.lblStatus.Text = "Chưa dọn dẹp";
        this.lblRoomType.Text = str.ToString();
        this.lblStatus.ForeColor = Color.Orange;
        this.label1.Text = this._roomNo.ToString();
        this.groupBox2.Enabled = false;
        this.groupBox3.Enabled = false;
        this.groupBox4.Enabled = false;
        this.groupBox5.Enabled = false;
        this.txtPrepaid.Enabled = false;
        this.btnOK.Text = "Đã dọn dẹp";
      }
      else if (this._status == 5)
      {
        this.lblStatus.Text = "Tạm ngưng sử dụng";
        this.lblRoomType.Text = str.ToString();
        this.lblStatus.ForeColor = Color.Red;
        this.label1.Text = this._roomNo.ToString();
        this.groupBox2.Enabled = false;
        this.groupBox3.Enabled = false;
        this.groupBox4.Enabled = false;
        this.groupBox5.Enabled = false;
        this.txtPrepaid.Enabled = false;
        this.btnOK.Text = "Đã sửa";
      }
      db.Connection.Close();
    }

    private void listCurrenServiceData() => this.grvCrSer.DataSource = (object) this.dtCrSer;

    private void listBuyServiceData() => this.grvBuySer.DataSource = (object) this.dtBuySer;

    private void RoomInf_FormClosing(object sender, FormClosingEventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._status == 3 && this.btnOK.Enabled)
      {
        if (this.txtPrepaid.Text != "" && this.checkValidNumber(this.txtPrepaid.Text.Trim().ToString()))
        {
          smallHotelManager.RoomPurchaseInfo.Single<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (u => u.PurchaseID == this._purchaseId)).Repaid = new int?(int.Parse(this.txtPrepaid.Text.Trim().ToString()));
          smallHotelManager.SubmitChanges();
        }
        this.AddNewSerPur();
        this.UpdateCurSer();
      }
      if (this._status == 3 && !this.btnOK.Enabled)
      {
        int? rpl = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>();
        if (rpl.HasValue)
        {
          Table<RoomPurchaseInfo> roomPurchaseInfo1 = smallHotelManager.RoomPurchaseInfo;
          Expression<Func<RoomPurchaseInfo, bool>> predicate = (Expression<Func<RoomPurchaseInfo, bool>>) (r => r.Loan == (int?) rpl.Value);
          foreach (RoomPurchaseInfo roomPurchaseInfo2 in (IEnumerable<RoomPurchaseInfo>) roomPurchaseInfo1.Where<RoomPurchaseInfo>(predicate))
            roomPurchaseInfo2.IsPaid = new int?(1);
          smallHotelManager.SubmitChanges();
        }
        else
        {
          RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Single<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (y => y.PurchaseID == this._purchaseId));
          roomPurchaseInfo.Loan = new int?(0);
          roomPurchaseInfo.Repaid = new int?(0);
          smallHotelManager.SubmitChanges();
        }
      }
      this._parent.RoomCreating();
      this._parent.bindToErrorRoom();
      this._parent.listServiceData();
      smallHotelManager.Connection.Close();
      this.Dispose();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (this.grvCrSer.Rows.Count == 0)
        return;
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int num1 = 0;
      int rowIndex = this.grvCrSer.CurrentCell.RowIndex;
      int num2 = (int) this.dtCrSer.Rows[rowIndex][2];
      if (num2 > 0)
      {
        int num3 = (int) this.dtCrSer.Rows[rowIndex][0];
        string str = (string) this.dtCrSer.Rows[rowIndex][1];
        int num4 = (int) this.dtCrSer.Rows[rowIndex][3];
        int num5 = num2 - 1;
        this.dtCrSer.Rows[rowIndex][2] = (object) num5;
        this.listCurrenServiceData();
        for (int index = 0; index < this.dtBuySer.Rows.Count; ++index)
        {
          if (this.dtBuySer.Rows[index][0].ToString().Equals(num3.ToString()))
          {
            this.dtBuySer.Rows[index][2] = (object) ((int) this.dtBuySer.Rows[index][2] + 1);
            ++num1;
          }
        }
        if (num1 == 0)
        {
          DataRow row = this.dtBuySer.NewRow();
          row["ServiceID"] = (object) num3;
          row["Name"] = (object) str;
          row["Number"] = (object) 1;
          row["Price"] = (object) num4;
          this.dtBuySer.Rows.Add(row);
        }
        this.listBuyServiceData();
      }
      else
      {
        int num6 = (int) MessageBox.Show("[" + (string) this.dtCrSer.Rows[rowIndex][1] + "] đã hết!!");
      }
      if (this._status == 3)
      {
        int? nullable = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>();
        if (this.btnNo.Checked)
        {
          if (nullable.HasValue)
          {
            this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
            this.Refresh();
          }
          else
          {
            this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
            this.Refresh();
          }
        }
        else
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
          this.Refresh();
        }
      }
      smallHotelManager.Connection.Close();
    }

    private void btnSub_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this.dtBuySer.Rows.Count != 0)
      {
        int rowIndex = this.grvBuySer.CurrentCell.RowIndex;
        int num1 = (int) this.dtBuySer.Rows[rowIndex][0];
        int num2 = (int) this.dtBuySer.Rows[rowIndex][2];
        if (num1 != 0)
        {
          int num3 = num2 - 1;
          this.dtBuySer.Rows[rowIndex][2] = (object) num3;
        }
        this.listCurrenServiceData();
        for (int index = 0; index < this.dtCrSer.Rows.Count; ++index)
        {
          if (this.dtCrSer.Rows[index][0].ToString().Equals(num1.ToString()))
            this.dtCrSer.Rows[index][2] = (object) ((int) this.dtCrSer.Rows[index][2] + 1);
        }
        if (this.dtBuySer.Rows[rowIndex][2].ToString().Equals("0"))
          this.grvBuySer.Rows.RemoveAt(rowIndex);
        this.listBuyServiceData();
      }
      if (this._status == 3)
      {
        int? nullable = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>();
        if (this.btnNo.Checked)
        {
          if (nullable.HasValue)
          {
            this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
            this.Refresh();
          }
          else
          {
            this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
            this.Refresh();
          }
        }
        else
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService()) * 1000));
          this.Refresh();
        }
      }
      smallHotelManager.Connection.Close();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._status != 2 && this._status != 3)
      {
        Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (r => r.RoomNo.Equals(this._roomNo.ToString())));
        room.StatusID = 2;
        room.Not = "";
        smallHotelManager.SubmitChanges();
        this.Dispose();
      }
      else if (this._status == 2)
      {
        this.CreateNewRomPur(this._ciTime, -1);
        this.AddNewSerPur();
        this.UpdateCurSer();
        this.Dispose();
      }
      else if (this._status == 3)
      {
        int? nullable = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>();
        if (this.btnYes.Checked)
        {
          if (nullable.HasValue)
          {
            RoomType roomType = smallHotelManager.RoomType.Where<RoomType>((Expression<Func<RoomType, bool>>) (t => t.TypeID == this.GetTypeIdByRoomNo())).Single<RoomType>();
            DateTime ciTime;
            ref DateTime local = ref ciTime;
            DateTime now = DateTime.Now;
            int year = now.Year;
            now = DateTime.Now;
            int month = now.Month;
            now = DateTime.Now;
            int day = now.Day;
            int byDayEndTime = roomType.ByDayEndTime;
            local = new DateTime(year, month, day, byDayEndTime, 0, 0);
            RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>();
            roomPurchaseInfo.CheckOutTime = new DateTime?(ciTime);
            roomPurchaseInfo.Cost = new int?(this.CalculateCost());
            roomPurchaseInfo.UserID = new int?(this._userId);
            roomPurchaseInfo.RoomDiscount = new int?(this._discount1);
            roomPurchaseInfo.SerDiscount = new int?(this._discount2);
            roomPurchaseInfo.IsPaid = new int?(0);
            smallHotelManager.SubmitChanges();
            this.CreateNewRomPur(ciTime, nullable.Value);
            this.AddNewSerPur();
            this.UpdateCurSer();
            this.Dispose();
          }
          else
          {
            RoomType roomType = smallHotelManager.RoomType.Where<RoomType>((Expression<Func<RoomType, bool>>) (t => t.TypeID == this.GetTypeIdByRoomNo())).Single<RoomType>();
            DateTime ciTime;
            ref DateTime local = ref ciTime;
            DateTime now = DateTime.Now;
            int year = now.Year;
            now = DateTime.Now;
            int month = now.Month;
            now = DateTime.Now;
            int day = now.Day;
            int byDayEndTime = roomType.ByDayEndTime;
            local = new DateTime(year, month, day, byDayEndTime, 0, 0);
            RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>();
            roomPurchaseInfo.CheckOutTime = new DateTime?(ciTime);
            roomPurchaseInfo.Loan = new int?(this._purchaseId);
            roomPurchaseInfo.UserID = new int?(this._userId);
            roomPurchaseInfo.Cost = new int?(this.CalculateCost());
            roomPurchaseInfo.RoomDiscount = new int?(this._discount1);
            roomPurchaseInfo.SerDiscount = new int?(this._discount2);
            roomPurchaseInfo.IsPaid = new int?(0);
            smallHotelManager.SubmitChanges();
            this.CreateNewRomPur(ciTime, this._purchaseId);
            this.AddNewSerPur();
            this.UpdateCurSer();
            this.Dispose();
          }
        }
        else if (MessageBox.Show("Bạn có chắc muốn thanh toán phòng này?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          if (nullable.HasValue)
          {
            Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (r => r.PurchaseID == (int?) this._purchaseId));
            room.PurchaseID = new int?();
            room.StatusID = 4;
            RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>();
            roomPurchaseInfo.CheckOutTime = new DateTime?(DateTime.Now);
            roomPurchaseInfo.UserID = new int?(this._userId);
            roomPurchaseInfo.Cost = new int?(this.CalculateCost());
            roomPurchaseInfo.RoomDiscount = new int?(this._discount1);
            roomPurchaseInfo.SerDiscount = new int?(this._discount2);
            roomPurchaseInfo.IsPaid = new int?(1);
            smallHotelManager.SubmitChanges();
            this.AddNewSerPur();
            this.UpdateCurSer();
            this.binddtCrSer();
            smallHotelManager.SubmitChanges();
            this.btnOK.Enabled = false;
            this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.groupBox5.Enabled = false;
            this.groupBox6.Enabled = false;
            this.groupBox7.Enabled = false;
            this.txtPrepaid.Enabled = false;
            this.btnChangeRoom.Enabled = false;
            this.btnPrint.Enabled = true;
            this.btnCancel.Text = "Thoát";
          }
          else
          {
            Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (r => r.PurchaseID == (int?) this._purchaseId));
            room.PurchaseID = new int?();
            room.StatusID = 4;
            RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>();
            roomPurchaseInfo.CheckOutTime = new DateTime?(DateTime.Now);
            roomPurchaseInfo.UserID = new int?(this._userId);
            roomPurchaseInfo.Cost = new int?(this.CalculateCost());
            roomPurchaseInfo.RoomDiscount = new int?(this._discount1);
            roomPurchaseInfo.SerDiscount = new int?(this._discount2);
            smallHotelManager.SubmitChanges();
            this.AddNewSerPur();
            this.UpdateCurSer();
            this.binddtCrSer();
            this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid - this._discount1 - this._discount2) * 1000));
            this.btnOK.Enabled = false;
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.groupBox5.Enabled = false;
            this.groupBox6.Enabled = false;
            this.groupBox7.Enabled = false;
            this.txtPrepaid.Enabled = false;
            this.btnChangeRoom.Enabled = false;
            this.btnPrint.Enabled = true;
            this.btnCancel.Text = "Thoát";
          }
        }
      }
      smallHotelManager.Connection.Close();
    }

    public int GetTypeIdByRoomNo() => new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").Room.Where<Room>((Expression<Func<Room, bool>>) (r => r.RoomNo.Equals(this._roomNo))).Single<Room>().TypeID;

    public void CreateNewRomPur(DateTime ciTime, int loan)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int num1 = 0;
      if (this.txtPrepaid.Text != "" && this.checkValidNumber(this.txtPrepaid.Text.Trim().ToString()))
        num1 = int.Parse(this.txtPrepaid.Text.ToString());
      if (loan == -1)
      {
        RoomPurchaseInfo entity;
        if (this._cusId != 0)
        {
          entity = new RoomPurchaseInfo()
          {
            RoomNo = this._roomNo,
            CheckInTime = new DateTime?(ciTime),
            Repaid = new int?(num1),
            CusID = new int?(this._cusId)
          };
          Customer customer = smallHotelManager.Customer.Where<Customer>((Expression<Func<Customer, bool>>) (x => x.CusID == this._cusId)).Single<Customer>();
          customer.CITime = new DateTime?(ciTime);
          customer.RoomNo = this._roomNo;
          smallHotelManager.SubmitChanges();
        }
        else
          entity = new RoomPurchaseInfo()
          {
            RoomNo = this._roomNo,
            CheckInTime = new DateTime?(ciTime),
            Repaid = new int?(num1)
          };
        smallHotelManager.RoomPurchaseInfo.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
      }
      else
      {
        RoomPurchaseInfo entity;
        if (this._cusId != 0)
        {
          entity = new RoomPurchaseInfo()
          {
            RoomNo = this._roomNo,
            CheckInTime = new DateTime?(ciTime),
            Loan = new int?(loan),
            Repaid = new int?(num1),
            CusID = new int?(this._cusId)
          };
          Customer customer = smallHotelManager.Customer.Where<Customer>((Expression<Func<Customer, bool>>) (x => x.CusID == this._cusId)).Single<Customer>();
          customer.CITime = new DateTime?(ciTime);
          customer.RoomNo = this._roomNo;
          smallHotelManager.SubmitChanges();
        }
        else
          entity = new RoomPurchaseInfo()
          {
            RoomNo = this._roomNo,
            CheckInTime = new DateTime?(ciTime),
            Loan = new int?(loan),
            Repaid = new int?(num1)
          };
        smallHotelManager.RoomPurchaseInfo.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
      }
      int num2 = smallHotelManager.RoomPurchaseInfo.Max<RoomPurchaseInfo, int>((Expression<Func<RoomPurchaseInfo, int>>) (p => p.PurchaseID));
      Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (r => r.RoomNo.Equals(this._roomNo.ToString())));
      room.PurchaseID = new int?(num2);
      room.StatusID = 3;
      smallHotelManager.SubmitChanges();
      smallHotelManager.Connection.Close();
    }

    public int CalculateCost()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      DateTime now1 = DateTime.Now;
      RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (rp => rp.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>();
      CalculatorCost calculatorCost = new CalculatorCost();
      if (this.btnYes.Checked)
      {
        RoomType roomType = smallHotelManager.RoomType.Where<RoomType>((Expression<Func<RoomType, bool>>) (t => t.TypeID == this.GetTypeIdByRoomNo())).Single<RoomType>();
        DateTime outTime;
        ref DateTime local = ref outTime;
        DateTime now2 = DateTime.Now;
        int year = now2.Year;
        now2 = DateTime.Now;
        int month = now2.Month;
        now2 = DateTime.Now;
        int day = now2.Day;
        int byDayEndTime = roomType.ByDayEndTime;
        local = new DateTime(year, month, day, byDayEndTime, 0, 0);
        calculatorCost.GetData(this._roomNo, outTime, roomPurchaseInfo.CheckInTime.Value, false);
      }
      else if (roomPurchaseInfo.Loan.HasValue)
        calculatorCost.GetData(this._roomNo, DateTime.Now, roomPurchaseInfo.CheckInTime.Value, true);
      else
        calculatorCost.GetData(this._roomNo, DateTime.Now, roomPurchaseInfo.CheckInTime.Value, false);
      return calculatorCost.CalcuCost();
    }

    private void UpdateCurSer()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      for (int i = 0; i < this.dtCrSer.Rows.Count; ++i)
      {
        if ((int) this.dtCrSer.Rows[i][0] != 0)
        {
          smallHotelManager.Services.Single<Services>((Expression<Func<Services, bool>>) (r => r.ServiceID == (int) this.dtCrSer.Rows[i][0])).TotalNumber = new int?((int) this.dtCrSer.Rows[i][2]);
          smallHotelManager.SubmitChanges();
        }
      }
      smallHotelManager.Connection.Close();
    }

    private void AddNewSerPur()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._status == 2)
        this._purchaseId = smallHotelManager.RoomPurchaseInfo.Max<RoomPurchaseInfo, int>((Expression<Func<RoomPurchaseInfo, int>>) (p => p.PurchaseID));
      IQueryable<ServicesPurchaseInfo> entities1 = smallHotelManager.ServicesPurchaseInfo.Where<ServicesPurchaseInfo>((Expression<Func<ServicesPurchaseInfo, bool>>) (spr => spr.PurchaseID == this._purchaseId));
      smallHotelManager.ServicesPurchaseInfo.DeleteAllOnSubmit<ServicesPurchaseInfo>((IEnumerable<ServicesPurchaseInfo>) entities1);
      smallHotelManager.SubmitChanges();
      List<ServicesPurchaseInfo> entities2 = new List<ServicesPurchaseInfo>();
      int num = 0;
      for (int index = 0; index < this.dtBuySer.Rows.Count; ++index)
      {
        if ((int) this.dtBuySer.Rows[index][0] != 0)
          ++num;
      }
      if (num == 0)
      {
        ServicesPurchaseInfo servicesPurchaseInfo = new ServicesPurchaseInfo()
        {
          PurchaseID = this._purchaseId,
          ServiceID = new int?(1),
          Number = new int?(0),
          Cost = new int?(0)
        };
        entities2.Add(servicesPurchaseInfo);
      }
      else
      {
        for (int index = 0; index < this.dtBuySer.Rows.Count; ++index)
        {
          if ((int) this.dtBuySer.Rows[index][0] != 0)
          {
            ServicesPurchaseInfo servicesPurchaseInfo = new ServicesPurchaseInfo()
            {
              PurchaseID = this._purchaseId,
              ServiceID = new int?((int) this.dtBuySer.Rows[index][0]),
              Number = new int?((int) this.dtBuySer.Rows[index][2]),
              Cost = new int?((int) this.dtBuySer.Rows[index][3] * (int) this.dtBuySer.Rows[index][2])
            };
            entities2.Add(servicesPurchaseInfo);
          }
        }
      }
      smallHotelManager.ServicesPurchaseInfo.InsertAllOnSubmit<ServicesPurchaseInfo>((IEnumerable<ServicesPurchaseInfo>) entities2);
      smallHotelManager.SubmitChanges();
      smallHotelManager.Connection.Close();
    }

    public int getCostByDay(int dis1, int dis2)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      RoomPurchaseInfo x = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (rp => rp.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>();
      Table<RoomPurchaseInfo> roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo;
      Expression<Func<RoomPurchaseInfo, bool>> predicate = (Expression<Func<RoomPurchaseInfo, bool>>) (rom => rom.Loan == x.Loan && rom.Cost.HasValue);
      using (IEnumerator<RoomPurchaseInfo> enumerator = roomPurchaseInfo.Where<RoomPurchaseInfo>(predicate).GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          RoomPurchaseInfo item = enumerator.Current;
          int num4 = num1;
          int? nullable = item.Cost;
          int num5 = nullable.Value;
          nullable = item.RoomDiscount;
          int num6 = nullable.Value;
          int num7 = num5 - num6;
          nullable = item.SerDiscount;
          int num8 = nullable.Value;
          int num9 = num7 - num8;
          num1 = num4 + num9;
          IQueryable<ServicesPurchaseInfo> queryable1 = smallHotelManager.ServicesPurchaseInfo.Where<ServicesPurchaseInfo>((Expression<Func<ServicesPurchaseInfo, bool>>) (s => s.PurchaseID == item.PurchaseID));
          IQueryable<OutExpense> queryable2 = smallHotelManager.OutExpense.Where<OutExpense>((Expression<Func<OutExpense, bool>>) (s => s.PurchaseID == item.PurchaseID));
          foreach (ServicesPurchaseInfo servicesPurchaseInfo in (IEnumerable<ServicesPurchaseInfo>) queryable1)
          {
            int num10 = num2;
            nullable = servicesPurchaseInfo.Cost;
            int num11 = nullable.Value;
            num2 = num10 + num11;
          }
          foreach (OutExpense outExpense in (IEnumerable<OutExpense>) queryable2)
            num3 += outExpense.Cost.Value;
        }
      }
      if (this.btnOK.Enabled)
      {
        num1 += this.CalculateCost();
        num2 += this.CalcuCostService();
      }
      if (dis1 != 0)
      {
        this._discount1 = dis1 * num1 / 100;
        num1 -= this._discount1;
      }
      if (dis2 != 0)
      {
        this._discount2 = dis2 * num2 / 100;
        num2 -= this._discount2;
      }
      this.lblDiscount.Text = string.Format("{0:0,0}", (object) ((this._discount1 + this._discount2) * 1000));
      return num1 + num2 + num3 - this._prepaid;
    }

    public int CalcuCostService()
    {
      int num = 0;
      for (int index = 0; index < this.dtBuySer.Rows.Count; ++index)
        num += (int) this.dtBuySer.Rows[index][3] * (int) this.dtBuySer.Rows[index][2];
      return num;
    }

    private void rdHour_CheckedChanged(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int? nullable = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>();
      if (this.btnYes.Checked)
      {
        this.linkLabel1.Enabled = false;
        this.btnOK.Text = "Lưu";
        this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService()) * 1000));
        this.Refresh();
      }
      else
      {
        this.linkLabel1.Enabled = true;
        this.btnOK.Text = "Thanh toán";
        if (nullable.HasValue)
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
          this.Refresh();
        }
        else
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
          this.Refresh();
        }
      }
      smallHotelManager.Connection.Close();
    }

    private void rdNight_CheckedChanged(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int? nullable = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>();
      if (this.btnYes.Checked)
      {
        this.linkLabel1.Enabled = false;
        this.btnOK.Text = "Lưu";
        this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService()) * 1000));
        this.Refresh();
      }
      else
      {
        this.linkLabel1.Enabled = true;
        this.btnOK.Text = "Thanh toán";
        if (nullable.HasValue)
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
          this.Refresh();
        }
        else
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
          this.Refresh();
        }
      }
      smallHotelManager.Connection.Close();
    }

    private void rdDay_CheckedChanged(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int? nullable = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>();
      if (this.btnYes.Checked)
      {
        this.linkLabel1.Enabled = false;
        this.btnOK.Text = "Lưu";
        this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService()) * 1000));
        this.Refresh();
      }
      else
      {
        this.linkLabel1.Enabled = true;
        this.btnOK.Text = "Thanh toán";
        if (nullable.HasValue)
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
          this.Refresh();
        }
        else
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
          this.Refresh();
        }
      }
      smallHotelManager.Connection.Close();
    }

    private void comboChangeRoom()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.cmbChangeRoom.DataSource = (object) smallHotelManager.Room.Where<Room>((Expression<Func<Room, bool>>) (r => r.StatusID == 2)).OrderBy<Room, string>((Expression<Func<Room, string>>) (r => r.RoomNo)).Select<Room, string>((Expression<Func<Room, string>>) (r => r.RoomNo));
      this.cmbChangeRoom.DisplayMember = "RoomNo";
      smallHotelManager.Connection.Close();
    }

    private void btnChangeRoom_Click(object sender, EventArgs e)
    {
      if (this.cmbChangeRoom.Items.Count <= 0)
        return;
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      string roomno = this.cmbChangeRoom.SelectedItem.ToString();
      Room room1 = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (r => r.RoomNo == roomno));
      room1.PurchaseID = new int?(this._purchaseId);
      room1.StatusID = 3;
      smallHotelManager.RoomPurchaseInfo.Single<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).RoomNo = roomno;
      Room room2 = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (r => r.RoomNo == this._roomNo));
      room2.PurchaseID = new int?();
      room2.StatusID = 4;
      smallHotelManager.SubmitChanges();
      this.comboChangeRoom();
      this.label1.Text = roomno.ToString();
      this._parent.roomId = "";
      smallHotelManager.Connection.Close();
      this.Dispose();
    }

    private void btnDestroyBill_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.lblCost.Text = string.Format("{0:0,0}", (object) (this.CalcuCostService() * 1000));
      if (MessageBox.Show("Bạn có chắc muốn xóa loại phòng này?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        RoomPurchaseInfo roompur = smallHotelManager.RoomPurchaseInfo.Single<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId));
        if (roompur.Loan.HasValue)
        {
          Table<RoomPurchaseInfo> roomPurchaseInfo1 = smallHotelManager.RoomPurchaseInfo;
          Expression<Func<RoomPurchaseInfo, bool>> predicate = (Expression<Func<RoomPurchaseInfo, bool>>) (x => x.Loan == roompur.Loan);
          foreach (RoomPurchaseInfo roomPurchaseInfo2 in (IEnumerable<RoomPurchaseInfo>) roomPurchaseInfo1.Where<RoomPurchaseInfo>(predicate))
          {
            if (roomPurchaseInfo2.PurchaseID == roompur.PurchaseID)
              roompur.CheckOutTime = new DateTime?(DateTime.Now);
            roomPurchaseInfo2.UserID = new int?(this._userId);
            roomPurchaseInfo2.Loan = new int?(0);
            roomPurchaseInfo2.IsPaid = new int?(1);
            roomPurchaseInfo2.Cost = new int?(0);
            roomPurchaseInfo2.RoomDiscount = new int?(0);
            roomPurchaseInfo2.SerDiscount = new int?(0);
            roomPurchaseInfo2.Note = "Hủy TT";
          }
          Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (r => r.RoomNo == this._roomNo));
          room.PurchaseID = new int?();
          room.StatusID = 4;
          smallHotelManager.SubmitChanges();
        }
        else
        {
          roompur.CheckOutTime = new DateTime?(DateTime.Now);
          roompur.UserID = new int?(this._userId);
          roompur.Cost = new int?(0);
          roompur.Note = "Hủy TT";
          roompur.Loan = new int?(0);
          roompur.Repaid = new int?(0);
          roompur.RoomDiscount = new int?(0);
          roompur.SerDiscount = new int?(0);
          Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (r => r.RoomNo == this._roomNo));
          room.PurchaseID = new int?();
          room.StatusID = 4;
          smallHotelManager.SubmitChanges();
        }
        this.Dispose();
      }
      else
        this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService()) * 1000));
      smallHotelManager.Connection.Close();
    }

    private void btnYes_CheckedChanged(object sender, EventArgs e)
    {
      this.linkLabel1.Enabled = false;
      this.btnOK.Text = "Lưu";
      this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService()) * 1000));
      this.Refresh();
    }

    private void btnNo_CheckedChanged(object sender, EventArgs e)
    {
      this.linkLabel1.Enabled = true;
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.btnOK.Text = "Thanh toán";
      if (smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>().HasValue)
      {
        this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
        this.Refresh();
      }
      else
      {
        this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
        this.Refresh();
      }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.AddNewSerPur();
      this.UpdateCurSer();
      RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).SingleOrDefault<RoomPurchaseInfo>();
      if (this.pd == null || this.pd.IsDisposed)
      {
        this.pd = new PaymentDetail();
        this.pd.Cusid = this._cusId;
        this.pd.Dis1 = this._discount1;
        this.pd.Dis2 = this._discount2;
        int? loan = roomPurchaseInfo.Loan;
        int num1;
        if (loan.HasValue)
        {
          loan = roomPurchaseInfo.Loan;
          num1 = loan.Value != 0 ? 1 : 0;
        }
        else
          num1 = 0;
        if (num1 == 0)
        {
          this.pd.Temp = this._purchaseId;
          this.pd.IsLoan = false;
        }
        else
        {
          PaymentDetail pd = this.pd;
          loan = roomPurchaseInfo.Loan;
          int num2 = loan.Value;
          pd.Temp = num2;
          this.pd.IsLoan = true;
        }
        int num3 = (int) this.pd.ShowDialog();
      }
      smallHotelManager.Connection.Close();
    }

    private bool checkValidNumber(string number)
    {
      int length = number.Length;
      return new Regex("^[0-9]+$").IsMatch(number);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.AddNewSerPur();
      this.UpdateCurSer();
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      try
      {
        string text = this.txtReason.Text;
        int num = this.checkValidNumber(this.txtCost.Text.Trim().ToString()) ? int.Parse(this.txtCost.Text) : throw new Exception();
        OutExpense entity = new OutExpense()
        {
          PurchaseID = this._purchaseId,
          ExpenseName = text.ToString(),
          Cost = new int?(num)
        };
        smallHotelManager.OutExpense.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Số tiền phải là số!");
        return;
      }
      finally
      {
        this.txtCost.Text = "";
        this.txtReason.Text = "";
        this.binddtBuySer(this._purchaseId);
        this.listBuyServiceData();
        if (smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>().HasValue)
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(0, 0) * 1000));
          this.Refresh();
        }
        else
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid) * 1000));
          this.Refresh();
        }
      }
      smallHotelManager.Connection.Close();
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Bạn muốn In hóa đơn bằng Tiếng Anh?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).SingleOrDefault<RoomPurchaseInfo>();
        this.pd = new PaymentDetail();
        this.pd.Cusid = this._cusId;
        this.pd.Dis1 = this._discount1;
        this.pd.Dis2 = this._discount2;
        this.pd.IsVietnam = 1;
        int? loan = roomPurchaseInfo.Loan;
        int num1;
        if (loan.HasValue)
        {
          loan = roomPurchaseInfo.Loan;
          num1 = loan.Value != 0 ? 1 : 0;
        }
        else
          num1 = 0;
        if (num1 == 0)
        {
          this.pd.Temp = this._purchaseId;
          this.pd.IsLoan = false;
        }
        else
        {
          PaymentDetail pd = this.pd;
          loan = roomPurchaseInfo.Loan;
          int num2 = loan.Value;
          pd.Temp = num2;
          this.pd.IsLoan = true;
        }
        this.pd.CreateBill();
        this.pd.ConvertDGVtoExcel();
        this.pd.Dispose();
        smallHotelManager.Connection.Close();
      }
      else
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).SingleOrDefault<RoomPurchaseInfo>();
        this.pd = new PaymentDetail();
        this.pd.Cusid = this._cusId;
        this.pd.Dis1 = this._discount1;
        this.pd.Dis2 = this._discount2;
        this.pd.IsVietnam = 0;
        int? loan = roomPurchaseInfo.Loan;
        int num3;
        if (loan.HasValue)
        {
          loan = roomPurchaseInfo.Loan;
          num3 = loan.Value != 0 ? 1 : 0;
        }
        else
          num3 = 0;
        if (num3 == 0)
        {
          this.pd.Temp = this._purchaseId;
          this.pd.IsLoan = false;
        }
        else
        {
          PaymentDetail pd = this.pd;
          loan = roomPurchaseInfo.Loan;
          int num4 = loan.Value;
          pd.Temp = num4;
          this.pd.IsLoan = true;
        }
        this.pd.CreateBill();
        this.pd.ConvertDGVtoExcel();
        this.pd.Dispose();
        smallHotelManager.Connection.Close();
      }
    }

    private void GetCusInfo()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._status == 3)
      {
        try
        {
          Customer customer = smallHotelManager.Customer.Where<Customer>((Expression<Func<Customer, bool>>) (x => x.CusID == this.CusId)).Single<Customer>();
          if (customer != null)
          {
            this.txtName.Text = customer.CusName.ToString();
            this.comboBox2.SelectedValue = (object) customer.NationalID;
            this.txtAddress.Text = customer.Address.ToString();
            this.txtCompany.Text = customer.Company.ToString();
            this.txtIdNo.Text = customer.IdNo.ToString();
            this.txtPhoneNum.Text = customer.CusPhone.ToString();
            this.txtName.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtCompany.Enabled = false;
            this.txtIdNo.Enabled = false;
            this.txtPhoneNum.Enabled = false;
            this.comboBox2.Enabled = false;
            this.btnSave.Enabled = false;
          }
          else
          {
            this.txtName.Enabled = true;
            this.txtAddress.Enabled = true;
            this.txtCompany.Enabled = true;
            this.txtIdNo.Enabled = true;
            this.txtPhoneNum.Enabled = true;
            this.comboBox2.Enabled = true;
            this.btnSave.Enabled = true;
          }
        }
        catch (Exception ex)
        {
          return;
        }
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

    private void GetInTime(int prID)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this._ciTime = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == prID)).Single<RoomPurchaseInfo>().CheckInTime.Value;
      this.lblCITime.Text = (this._ciTime.Hour.ToString() + "h" + (object) this._ciTime.Minute + "'              (" + (object) this._ciTime.Day + "/" + (object) this._ciTime.Month + "/" + (object) this._ciTime.Year + ")").ToString();
      smallHotelManager.Connection.Close();
    }

    private void cbGetInTime_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cbGetInTime.Checked)
      {
        this.comboBox1.Enabled = true;
        this.GetInTime((int) this.comboBox1.SelectedValue);
      }
      else
        this.comboBox1.Enabled = false;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._status == 2)
      {
        Customer entity = new Customer()
        {
          CusName = this.txtName.Text.ToString(),
          NationalID = new int?((int) this.comboBox2.SelectedValue),
          Company = this.txtCompany.Text.ToString(),
          Address = this.txtAddress.Text.ToString(),
          IdNo = this.txtIdNo.Text.ToString(),
          CusPhone = this.txtPhoneNum.Text.ToString()
        };
        smallHotelManager.Customer.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
        this.CusId = smallHotelManager.Customer.Max<Customer, int>((Expression<Func<Customer, int>>) (x => x.CusID));
      }
      else if (this._status == 3)
      {
        if (this._cusId == 0)
        {
          RoomPurchaseInfo roomPurchaseInfo = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>();
          Customer entity = new Customer()
          {
            CusName = this.txtName.Text.ToString(),
            NationalID = new int?((int) this.comboBox2.SelectedValue),
            Company = this.txtCompany.Text.ToString(),
            Address = this.txtAddress.Text.ToString(),
            IdNo = this.txtIdNo.Text.ToString(),
            CusPhone = this.txtPhoneNum.Text.ToString(),
            RoomNo = this._roomNo,
            CITime = roomPurchaseInfo.CheckInTime
          };
          smallHotelManager.Customer.InsertOnSubmit(entity);
          smallHotelManager.SubmitChanges();
          int num = smallHotelManager.Customer.Select<Customer, int>((Expression<Func<Customer, int>>) (x => x.CusID)).Max<int>();
          this.CusId = num;
          smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (x => x.PurchaseID == this._purchaseId)).Single<RoomPurchaseInfo>().CusID = new int?(num);
          smallHotelManager.SubmitChanges();
        }
        else
        {
          Customer customer = smallHotelManager.Customer.Single<Customer>((Expression<Func<Customer, bool>>) (r => r.CusID == this._cusId));
          customer.CusName = this.txtName.Text.ToString();
          customer.NationalID = new int?((int) this.comboBox2.SelectedValue);
          customer.Company = this.txtCompany.Text.ToString();
          customer.Address = this.txtAddress.Text.ToString();
          customer.IdNo = this.txtIdNo.Text.ToString();
          customer.CusPhone = this.txtPhoneNum.Text.ToString();
          smallHotelManager.SubmitChanges();
        }
      }
      this.txtName.Enabled = false;
      this.txtAddress.Enabled = false;
      this.txtCompany.Enabled = false;
      this.txtIdNo.Enabled = false;
      this.txtPhoneNum.Enabled = false;
      this.comboBox2.Enabled = false;
      this.btnSave.Enabled = false;
      smallHotelManager.Connection.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.txtName.Enabled = true;
      this.txtAddress.Enabled = true;
      this.txtCompany.Enabled = true;
      this.txtIdNo.Enabled = true;
      this.txtPhoneNum.Enabled = true;
      this.comboBox2.Enabled = true;
      this.btnSave.Enabled = true;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      this.lblUnit1.Text = ".000 (VNĐ)";
      this.lblUnit2.Text = ".000 (VNĐ)";
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      this.lblUnit1.Text = "%";
      this.lblUnit2.Text = "%";
    }

    private void btnDiscount_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int dis1 = 0;
      int dis2 = 0;
      if (this.checkValidNumber(this.txtDisRoom.Text.Trim().ToString()))
      {
        dis1 = int.Parse(this.txtDisRoom.Text.ToString());
      }
      else
      {
        int num1 = (int) MessageBox.Show("Tiền phòng phải là số");
      }
      if (this.checkValidNumber(this.txtDisService.Text.Trim().ToString()))
      {
        dis2 = int.Parse(this.txtDisService.Text.ToString());
      }
      else
      {
        int num2 = (int) MessageBox.Show("Tiền dịch vụ phải là số");
      }
      int? nullable = smallHotelManager.RoomPurchaseInfo.Where<RoomPurchaseInfo>((Expression<Func<RoomPurchaseInfo, bool>>) (r => r.PurchaseID == this._purchaseId)).Select<RoomPurchaseInfo, int?>((Expression<Func<RoomPurchaseInfo, int?>>) (r => r.Loan)).Single<int?>();
      if (this.btnNo.Checked)
      {
        if (this.radioButton1.Checked)
        {
          if (!nullable.HasValue)
            this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid - dis1 - dis2) * 1000));
          else
            this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.getCostByDay(0, 0) - dis1 - dis2) * 1000));
          this._discount1 = dis1;
          this._discount2 = dis2;
          this.lblDiscount.Text = string.Format("{0:0,0}", (object) ((dis1 + dis2) * 1000));
        }
        else if (this.radioButton2.Checked)
        {
          if (!nullable.HasValue)
          {
            int num3 = dis1 * this.CalculateCost() / 100;
            int num4 = dis2 * this.CalcuCostService() / 100;
            this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid - num3 - num4) * 1000));
            this._discount1 = num3;
            this._discount2 = num4;
            this.lblDiscount.Text = string.Format("{0:0,0}", (object) ((num3 + num4) * 1000));
          }
          else
            this.lblCost.Text = string.Format("{0:0,0}", (object) (this.getCostByDay(dis1, dis2) * 1000));
        }
      }
      else
      {
        if (this.radioButton1.Checked)
        {
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid - dis1 - dis2) * 1000));
          this._discount1 = dis1;
          this._discount2 = dis2;
        }
        else
        {
          dis1 = dis1 * this.CalculateCost() / 100;
          dis2 = dis2 * this.CalcuCostService() / 100;
          this.lblCost.Text = string.Format("{0:0,0}", (object) ((this.CalculateCost() + this.CalcuCostService() - this._prepaid - dis1 - dis2) * 1000));
          this._discount1 = dis1;
          this._discount2 = dis2;
        }
        this.lblDiscount.Text = string.Format("{0:0,0}", (object) ((dis1 + dis2) * 1000));
      }
      smallHotelManager.Connection.Close();
    }

    private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) => this.GetInTime((int) this.comboBox1.SelectedValue);
  }
}
