// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.RoomManger
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class RoomManger : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private ComboBox cmbType;
    private Label label2;
    private ComboBox cmbStatus;
    private Label label1;
    private GroupBox groupBox2;
    private DataGridView grvRoomManager;
    private GroupBox groupBox3;
    private ComboBox cmbType1;
    private Label label3;
    private Label label11;
    private TextBox txtEndByNight;
    private Label label12;
    private Label label9;
    private Label label8;
    private TextBox txtNumOfHour;
    private Label label7;
    private TextBox txtByNight;
    private Label label5;
    private TextBox txtByHour;
    private Label label4;
    private Button btnDel;
    private Button btnEdit;
    private Button btnCancel;
    private Button btnAdd;
    private Label label20;
    private TextBox txtStartByDay;
    private Label label14;
    private Label label18;
    private Label label17;
    private Button btbDelType;
    private Button btnEditType;
    private Button btnAddType;
    private Label label15;
    private TextBox txtNextHour;
    private Label label16;
    private Label label13;
    private TextBox txtEndByday;
    private Label label10;
    private TextBox txtByDay;
    private Label label6;
    private TextBox txtStartByNight;
    private Label label19;
    private Label label21;
    private TextBox txtMinutes;
    private Label label22;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn TypeID;
    private DataGridViewTextBoxColumn StatusID;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column5;
    private Main _parent;
    private AddNewRoom rm = (AddNewRoom) null;
    private AddNewRoomType rtp = (AddNewRoomType) null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (RoomManger));
      this.groupBox1 = new GroupBox();
      this.cmbType = new ComboBox();
      this.label2 = new Label();
      this.cmbStatus = new ComboBox();
      this.label1 = new Label();
      this.groupBox2 = new GroupBox();
      this.btnDel = new Button();
      this.btnEdit = new Button();
      this.btnAdd = new Button();
      this.grvRoomManager = new DataGridView();
      this.btnCancel = new Button();
      this.groupBox3 = new GroupBox();
      this.label21 = new Label();
      this.txtMinutes = new TextBox();
      this.label22 = new Label();
      this.label20 = new Label();
      this.txtStartByDay = new TextBox();
      this.label14 = new Label();
      this.label18 = new Label();
      this.label17 = new Label();
      this.btbDelType = new Button();
      this.btnEditType = new Button();
      this.btnAddType = new Button();
      this.label15 = new Label();
      this.txtNextHour = new TextBox();
      this.label16 = new Label();
      this.label13 = new Label();
      this.txtEndByday = new TextBox();
      this.label10 = new Label();
      this.txtByDay = new TextBox();
      this.label6 = new Label();
      this.txtStartByNight = new TextBox();
      this.label19 = new Label();
      this.label11 = new Label();
      this.txtEndByNight = new TextBox();
      this.label12 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.txtNumOfHour = new TextBox();
      this.label7 = new Label();
      this.txtByNight = new TextBox();
      this.label5 = new Label();
      this.txtByHour = new TextBox();
      this.label4 = new Label();
      this.cmbType1 = new ComboBox();
      this.label3 = new Label();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.TypeID = new DataGridViewTextBoxColumn();
      this.StatusID = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.grvRoomManager).BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.groupBox1.Controls.Add((Control) this.cmbType);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.cmbStatus);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.Location = new Point(1, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(661, 49);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Hiển thị theo";
      this.cmbType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbType.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Location = new Point(115, 16);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new Size(153, 28);
      this.cmbType.TabIndex = 12;
      this.cmbType.SelectionChangeCommitted += new EventHandler(this.cmbType_SelectionChangeCommitted);
      this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(11, 19);
      this.label2.Name = "label2";
      this.label2.Size = new Size(98, 20);
      this.label2.TabIndex = 11;
      this.label2.Text = "Loại phòng";
      this.cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbStatus.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbStatus.FormattingEnabled = true;
      this.cmbStatus.Location = new Point(385, 16);
      this.cmbStatus.Name = "cmbStatus";
      this.cmbStatus.Size = new Size(153, 28);
      this.cmbStatus.TabIndex = 10;
      this.cmbStatus.SelectionChangeCommitted += new EventHandler(this.cmbStatus_SelectionChangeCommitted);
      this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(289, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(90, 20);
      this.label1.TabIndex = 9;
      this.label1.Text = "Tình trạng";
      this.groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.groupBox2.Controls.Add((Control) this.btnDel);
      this.groupBox2.Controls.Add((Control) this.btnEdit);
      this.groupBox2.Controls.Add((Control) this.btnAdd);
      this.groupBox2.Controls.Add((Control) this.grvRoomManager);
      this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.Location = new Point(1, 67);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(661, 452);
      this.groupBox2.TabIndex = 10;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Danh sách phòng";
      this.btnDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnDel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnDel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnDel.Location = new Point(269, 404);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new Size(108, 40);
      this.btnDel.TabIndex = 8;
      this.btnDel.Text = "Xóa";
      this.btnDel.UseVisualStyleBackColor = false;
      this.btnDel.Click += new EventHandler(this.btnDel_Click);
      this.btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnEdit.BackColor = SystemColors.GradientInactiveCaption;
      this.btnEdit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEdit.Location = new Point(141, 404);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new Size(108, 40);
      this.btnEdit.TabIndex = 7;
      this.btnEdit.Text = "Chỉnh sửa";
      this.btnEdit.UseVisualStyleBackColor = false;
      this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
      this.btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(14, 404);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(108, 40);
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.grvRoomManager.AllowUserToAddRows = false;
      this.grvRoomManager.AllowUserToDeleteRows = false;
      this.grvRoomManager.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.grvRoomManager.BackgroundColor = SystemColors.ControlLightLight;
      this.grvRoomManager.BorderStyle = BorderStyle.Fixed3D;
      this.grvRoomManager.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
      this.grvRoomManager.ColumnHeadersHeight = 30;
      this.grvRoomManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.grvRoomManager.Columns.AddRange((DataGridViewColumn) this.Column4, (DataGridViewColumn) this.TypeID, (DataGridViewColumn) this.StatusID, (DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column5);
      this.grvRoomManager.Location = new Point(6, 23);
      this.grvRoomManager.MultiSelect = false;
      this.grvRoomManager.Name = "grvRoomManager";
      this.grvRoomManager.ReadOnly = true;
      this.grvRoomManager.RowHeadersVisible = false;
      this.grvRoomManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvRoomManager.Size = new Size(649, 375);
      this.grvRoomManager.TabIndex = 1;
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(853, 471);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(108, 40);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.groupBox3.Controls.Add((Control) this.label21);
      this.groupBox3.Controls.Add((Control) this.txtMinutes);
      this.groupBox3.Controls.Add((Control) this.label22);
      this.groupBox3.Controls.Add((Control) this.label20);
      this.groupBox3.Controls.Add((Control) this.txtStartByDay);
      this.groupBox3.Controls.Add((Control) this.label14);
      this.groupBox3.Controls.Add((Control) this.label18);
      this.groupBox3.Controls.Add((Control) this.label17);
      this.groupBox3.Controls.Add((Control) this.btbDelType);
      this.groupBox3.Controls.Add((Control) this.btnEditType);
      this.groupBox3.Controls.Add((Control) this.btnAddType);
      this.groupBox3.Controls.Add((Control) this.label15);
      this.groupBox3.Controls.Add((Control) this.txtNextHour);
      this.groupBox3.Controls.Add((Control) this.label16);
      this.groupBox3.Controls.Add((Control) this.label13);
      this.groupBox3.Controls.Add((Control) this.txtEndByday);
      this.groupBox3.Controls.Add((Control) this.label10);
      this.groupBox3.Controls.Add((Control) this.txtByDay);
      this.groupBox3.Controls.Add((Control) this.label6);
      this.groupBox3.Controls.Add((Control) this.txtStartByNight);
      this.groupBox3.Controls.Add((Control) this.label19);
      this.groupBox3.Controls.Add((Control) this.label11);
      this.groupBox3.Controls.Add((Control) this.txtEndByNight);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Controls.Add((Control) this.label9);
      this.groupBox3.Controls.Add((Control) this.label8);
      this.groupBox3.Controls.Add((Control) this.txtNumOfHour);
      this.groupBox3.Controls.Add((Control) this.label7);
      this.groupBox3.Controls.Add((Control) this.txtByNight);
      this.groupBox3.Controls.Add((Control) this.label5);
      this.groupBox3.Controls.Add((Control) this.txtByHour);
      this.groupBox3.Controls.Add((Control) this.label4);
      this.groupBox3.Controls.Add((Control) this.cmbType1);
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox3.Location = new Point(669, 13);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(292, 452);
      this.groupBox3.TabIndex = 11;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Bảng giá";
      this.label21.AutoSize = true;
      this.label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label21.Location = new Point(111, 220);
      this.label21.Name = "label21";
      this.label21.Size = new Size(141, 16);
      this.label21.TabIndex = 61;
      this.label21.Text = "phút sẽ tính thành 1 giờ";
      this.txtMinutes.Location = new Point(78, 217);
      this.txtMinutes.Name = "txtMinutes";
      this.txtMinutes.ReadOnly = true;
      this.txtMinutes.Size = new Size(27, 22);
      this.txtMinutes.TabIndex = 60;
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.Location = new Point(10, 220);
      this.label22.Name = "label22";
      this.label22.Size = new Size(62, 16);
      this.label22.TabIndex = 59;
      this.label22.Text = "Nếu quá ";
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.Location = new Point(81, 164);
      this.label20.Name = "label20";
      this.label20.Size = new Size(55, 16);
      this.label20.TabIndex = 58;
      this.label20.Text = "h00 đến";
      this.txtStartByDay.Location = new Point(53, 161);
      this.txtStartByDay.Name = "txtStartByDay";
      this.txtStartByDay.ReadOnly = true;
      this.txtStartByDay.Size = new Size(25, 22);
      this.txtStartByDay.TabIndex = 57;
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.Location = new Point(10, 164);
      this.label14.Name = "label14";
      this.label14.Size = new Size(41, 16);
      this.label14.TabIndex = 56;
      this.label14.Text = "tính từ";
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label18.Location = new Point(50, 315);
      this.label18.Name = "label18";
      this.label18.Size = new Size(239, 96);
      this.label18.TabIndex = 55;
      this.label18.Text = "1. Thời gian ở trên phải được đặt theo \r\nđịnh dạng '24h' (VD: 10h00, 22h00,...).\r\n\r\n2. Bảng giá trên chỉ áp dụng cho những \r\nphòng nào thuộc loại phòng mà bạn \r\nđang chọn.";
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label17.Location = new Point(3, 315);
      this.label17.Name = "label17";
      this.label17.Size = new Size(52, 16);
      this.label17.TabIndex = 54;
      this.label17.Text = "*Chú ý: ";
      this.btbDelType.BackColor = SystemColors.GradientInactiveCaption;
      this.btbDelType.Location = new Point(169, 263);
      this.btbDelType.Name = "btbDelType";
      this.btbDelType.Size = new Size(63, 49);
      this.btbDelType.TabIndex = 53;
      this.btbDelType.Text = "Xóa";
      this.btbDelType.UseVisualStyleBackColor = false;
      this.btbDelType.Click += new EventHandler(this.btbDelType_Click);
      this.btnEditType.BackColor = SystemColors.GradientInactiveCaption;
      this.btnEditType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEditType.Location = new Point(91, 263);
      this.btnEditType.Name = "btnEditType";
      this.btnEditType.Size = new Size(72, 49);
      this.btnEditType.TabIndex = 52;
      this.btnEditType.Text = "Chỉnh giá";
      this.btnEditType.UseVisualStyleBackColor = false;
      this.btnEditType.Click += new EventHandler(this.btnEditType_Click);
      this.btnAddType.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAddType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAddType.Location = new Point(6, 263);
      this.btnAddType.Name = "btnAddType";
      this.btnAddType.Size = new Size(79, 49);
      this.btnAddType.TabIndex = 51;
      this.btnAddType.Text = "Thêm loại phòng";
      this.btnAddType.UseVisualStyleBackColor = false;
      this.btnAddType.Click += new EventHandler(this.btnAddType_Click);
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.Location = new Point(223, 192);
      this.label15.Name = "label15";
      this.label15.Size = new Size(56, 16);
      this.label15.TabIndex = 50;
      this.label15.Text = ".000 / 1h";
      this.txtNextHour.Location = new Point(171, 189);
      this.txtNextHour.Name = "txtNextHour";
      this.txtNextHour.ReadOnly = true;
      this.txtNextHour.Size = new Size(46, 22);
      this.txtNextHour.TabIndex = 49;
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.Location = new Point(10, 192);
      this.label16.Name = "label16";
      this.label16.Size = new Size(155, 16);
      this.label16.TabIndex = 48;
      this.label16.Text = "Giá cho mỗi giờ tiếp theo";
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(167, 164);
      this.label13.Name = "label13";
      this.label13.Size = new Size(116, 16);
      this.label13.TabIndex = 47;
      this.label13.Text = "h00 ngày hôm sau";
      this.txtEndByday.Location = new Point(137, 161);
      this.txtEndByday.Name = "txtEndByday";
      this.txtEndByday.ReadOnly = true;
      this.txtEndByday.Size = new Size(25, 22);
      this.txtEndByday.TabIndex = 46;
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(192, 136);
      this.label10.Name = "label10";
      this.label10.Size = new Size(72, 16);
      this.label10.TabIndex = 44;
      this.label10.Text = ".000 / ngày";
      this.txtByDay.Location = new Point(96, 133);
      this.txtByDay.Name = "txtByDay";
      this.txtByDay.ReadOnly = true;
      this.txtByDay.Size = new Size(90, 22);
      this.txtByDay.TabIndex = 43;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(10, 136);
      this.label6.Name = "label6";
      this.label6.Size = new Size(88, 16);
      this.label6.TabIndex = 42;
      this.label6.Text = "Giá qua ngày";
      this.txtStartByNight.Location = new Point(53, 105);
      this.txtStartByNight.Name = "txtStartByNight";
      this.txtStartByNight.ReadOnly = true;
      this.txtStartByNight.Size = new Size(25, 22);
      this.txtStartByNight.TabIndex = 41;
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.Location = new Point(10, 108);
      this.label19.Name = "label19";
      this.label19.Size = new Size(41, 16);
      this.label19.TabIndex = 40;
      this.label19.Text = "tính từ";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(168, 108);
      this.label11.Name = "label11";
      this.label11.Size = new Size(116, 16);
      this.label11.TabIndex = 28;
      this.label11.Text = "h00 ngày hôm sau";
      this.txtEndByNight.Location = new Point(137, 105);
      this.txtEndByNight.Name = "txtEndByNight";
      this.txtEndByNight.ReadOnly = true;
      this.txtEndByNight.Size = new Size(25, 22);
      this.txtEndByNight.TabIndex = 27;
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(81, 108);
      this.label12.Name = "label12";
      this.label12.Size = new Size(55, 16);
      this.label12.TabIndex = 26;
      this.label12.Text = "h00 đến";
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(192, 80);
      this.label9.Name = "label9";
      this.label9.Size = new Size(69, 16);
      this.label9.TabIndex = 24;
      this.label9.Text = ".000 / đêm";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(237, 54);
      this.label8.Name = "label8";
      this.label8.Size = new Size(41, 16);
      this.label8.TabIndex = 23;
      this.label8.Text = "h đầu";
      this.txtNumOfHour.Location = new Point(212, 51);
      this.txtNumOfHour.Name = "txtNumOfHour";
      this.txtNumOfHour.ReadOnly = true;
      this.txtNumOfHour.Size = new Size(23, 22);
      this.txtNumOfHour.TabIndex = 22;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(167, 54);
      this.label7.Name = "label7";
      this.label7.Size = new Size(39, 16);
      this.label7.TabIndex = 21;
      this.label7.Text = ".000 /";
      this.txtByNight.Location = new Point(96, 77);
      this.txtByNight.Name = "txtByNight";
      this.txtByNight.ReadOnly = true;
      this.txtByNight.Size = new Size(90, 22);
      this.txtByNight.TabIndex = 18;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(10, 80);
      this.label5.Name = "label5";
      this.label5.Size = new Size(85, 16);
      this.label5.TabIndex = 17;
      this.label5.Text = "Giá qua đêm";
      this.txtByHour.Location = new Point(96, 51);
      this.txtByHour.Name = "txtByHour";
      this.txtByHour.ReadOnly = true;
      this.txtByHour.Size = new Size(66, 22);
      this.txtByHour.TabIndex = 16;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(10, 54);
      this.label4.Name = "label4";
      this.label4.Size = new Size(80, 16);
      this.label4.TabIndex = 15;
      this.label4.Text = "Giá theo giờ";
      this.cmbType1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.cmbType1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbType1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbType1.FormattingEnabled = true;
      this.cmbType1.Location = new Point(111, 15);
      this.cmbType1.Name = "cmbType1";
      this.cmbType1.Size = new Size(167, 28);
      this.cmbType1.TabIndex = 14;
      this.cmbType1.SelectionChangeCommitted += new EventHandler(this.cmbType1_SelectionChangeCommitted);
      this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(7, 18);
      this.label3.Name = "label3";
      this.label3.Size = new Size(98, 20);
      this.label3.TabIndex = 13;
      this.label3.Text = "Loại phòng";
      this.Column4.DataPropertyName = "RoomID";
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column4.DefaultCellStyle = gridViewCellStyle1;
      this.Column4.HeaderText = "RoomID";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Visible = false;
      this.TypeID.DataPropertyName = "TypeID";
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TypeID.DefaultCellStyle = gridViewCellStyle2;
      this.TypeID.HeaderText = "TyprID";
      this.TypeID.Name = "TypeID";
      this.TypeID.ReadOnly = true;
      this.TypeID.Visible = false;
      this.StatusID.DataPropertyName = "StatusID";
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.StatusID.DefaultCellStyle = gridViewCellStyle3;
      this.StatusID.HeaderText = "StatusID";
      this.StatusID.Name = "StatusID";
      this.StatusID.ReadOnly = true;
      this.StatusID.Visible = false;
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column1.DataPropertyName = "RoomNo";
      gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column1.DefaultCellStyle = gridViewCellStyle4;
      this.Column1.HeaderText = "Số Phòng";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column2.DataPropertyName = "TypeName";
      gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column2.DefaultCellStyle = gridViewCellStyle5;
      this.Column2.HeaderText = "Loại Phòng";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column3.DataPropertyName = "StatusName";
      gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column3.DefaultCellStyle = gridViewCellStyle6;
      this.Column3.HeaderText = "Tình Trạng";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column5.DataPropertyName = "Not";
      gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column5.DefaultCellStyle = gridViewCellStyle7;
      this.Column5.HeaderText = "Ghi chú";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.AccessibleRole = AccessibleRole.Sound;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(973, 523);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.groupBox1);
      this.DoubleBuffered = true;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(989, 561);
      this.MinimumSize = new Size(989, 561);
      this.Name = nameof (RoomManger);
      this.Text = "Quản lý phòng";
      this.FormClosing += new FormClosingEventHandler(this.RoomManger_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      ((ISupportInitialize) this.grvRoomManager).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
    }

    public RoomManger(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
      this.CmbGetData();
      this.GrvGetData();
      this.PriceGetData();
    }

    private void PriceGetData()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int typeId = (int) this.cmbType1.SelectedValue;
      RoomType roomType = smallHotelManager.RoomType.Single<RoomType>((Expression<Func<RoomType, bool>>) (d => d.TypeID == typeId));
      this.txtByHour.Text = roomType.PriceByHour.ToString();
      this.txtByNight.Text = roomType.PriceByNight.ToString();
      this.txtByDay.Text = roomType.PriceByDay.ToString();
      this.txtNumOfHour.Text = roomType.TimeForByHourMethod.ToString();
      this.txtEndByday.Text = roomType.ByDayEndTime.ToString();
      this.txtEndByNight.Text = roomType.ByNightEndTime.ToString();
      this.txtStartByDay.Text = roomType.ByDayStartTime.ToString();
      this.txtStartByNight.Text = roomType.ByNightStartTime.ToString();
      this.txtNextHour.Text = roomType.PriceByNextHour.ToString();
      this.txtMinutes.Text = roomType.MinuteOver.ToString();
      smallHotelManager.Connection.Close();
    }

    private void CmbGetData()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      IQueryable<\u003C\u003Ef__AnonymousType1<int, string>> source = smallHotelManager.RoomType.Select(t => new
      {
        TypeID = t.TypeID,
        TypeName = t.TypeName
      });
      IQueryable<\u003C\u003Ef__AnonymousTypeb<int, string>> queryable = smallHotelManager.Status.Select(s => new
      {
        StatusID = s.StatusID,
        StatusName = s.StatusName
      });
      this.cmbType.DataSource = (object) source;
      this.cmbType.DisplayMember = "TypeName";
      this.cmbType.ValueMember = "TypeID";
      this.cmbStatus.DataSource = (object) queryable;
      this.cmbStatus.DisplayMember = "StatusName";
      this.cmbStatus.ValueMember = "StatusID";
      this.cmbType1.DataSource = (object) source.AsQueryable().Where(t => t.TypeID > 1);
      this.cmbType1.DisplayMember = "TypeName";
      this.cmbType1.ValueMember = "TypeID";
      smallHotelManager.Connection.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void btnAdd_Click(object sender, EventArgs e)
    {
      int num = (int) new AddNewRoom(this).ShowDialog();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (this.rm != null && !this.rm.IsDisposed || this.grvRoomManager.RowCount <= 0)
        return;
      int num1 = int.Parse(this.grvRoomManager.Rows[this.grvRoomManager.CurrentCell.RowIndex].Cells[0].Value.ToString());
      this.rm = new AddNewRoom(this);
      this.rm.MdiParent = this.MdiParent;
      this.rm.RoomID = num1;
      int num2 = (int) this.rm.ShowDialog();
    }

    public void FormRefresh()
    {
      this.CmbGetData();
      this.GrvGetData();
      this.PriceGetData();
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
      if (this.grvRoomManager.RowCount <= 0)
        return;
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (int.Parse(this.grvRoomManager.Rows[this.grvRoomManager.CurrentCell.RowIndex].Cells[6].Value.ToString()) != 3)
      {
        if (MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          int roomID = int.Parse(this.grvRoomManager.Rows[this.grvRoomManager.CurrentCell.RowIndex].Cells[0].Value.ToString());
          IQueryable<Room> entities = smallHotelManager.Room.Where<Room>((Expression<Func<Room, bool>>) (r => r.RoomID == roomID));
          smallHotelManager.Room.DeleteAllOnSubmit<Room>((IEnumerable<Room>) entities);
          smallHotelManager.SubmitChanges();
          this.FormRefresh();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Phòng này đang sử dụng.\nKhông được phép xóa!");
      }
      smallHotelManager.Connection.Close();
    }

    private void GrvGetData()
    {
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int status = (int) this.cmbStatus.SelectedValue;
      int type = (int) this.cmbType.SelectedValue;
      IQueryable<\u003C\u003Ef__AnonymousTypee<int, string, string, string, string, int, int>> source = db.Room.SelectMany((Expression<Func<Room, IEnumerable<RoomType>>>) (r => db.RoomType), (r, t) => new
      {
        r = r,
        t = t
      }).SelectMany(data => db.Status, (data, s) => new
      {
        \u003C\u003Eh__TransparentIdentifier4 = data,
        s = s
      }).Where(data => data.\u003C\u003Eh__TransparentIdentifier4.r.TypeID == data.\u003C\u003Eh__TransparentIdentifier4.t.TypeID && data.\u003C\u003Eh__TransparentIdentifier4.r.StatusID == data.s.StatusID && data.\u003C\u003Eh__TransparentIdentifier4.r.StatusID > 1 && data.\u003C\u003Eh__TransparentIdentifier4.r.TypeID > 1).Select(data => new
      {
        RoomID = data.\u003C\u003Eh__TransparentIdentifier4.r.RoomID,
        RoomNo = data.\u003C\u003Eh__TransparentIdentifier4.r.RoomNo,
        TypeName = data.\u003C\u003Eh__TransparentIdentifier4.t.TypeName,
        StatusName = data.s.StatusName,
        Not = data.\u003C\u003Eh__TransparentIdentifier4.r.Not,
        TypeID = data.\u003C\u003Eh__TransparentIdentifier4.r.TypeID,
        StatusID = data.\u003C\u003Eh__TransparentIdentifier4.r.StatusID
      });
      if (status > 1)
        source = source.AsQueryable().Where(r => r.StatusID == status);
      if (type > 1)
        source = source.AsQueryable().Where(r => r.TypeID == type);
      this.grvRoomManager.DataSource = (object) source;
    }

    private void RoomManger_FormClosing(object sender, FormClosingEventArgs e)
    {
      this._parent.PerformRefresh();
      this.Dispose();
    }

    private void cmbType_SelectionChangeCommitted(object sender, EventArgs e) => this.GrvGetData();

    private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e) => this.GrvGetData();

    private void cmbType1_SelectionChangeCommitted(object sender, EventArgs e) => this.PriceGetData();

    private void btnAddType_Click(object sender, EventArgs e)
    {
      int num = (int) new AddNewRoomType(this).ShowDialog();
    }

    private void btnEditType_Click(object sender, EventArgs e)
    {
      if (this.rtp == null || this.rtp.IsDisposed)
      {
        int selectedValue = (int) this.cmbType1.SelectedValue;
        this.rtp = new AddNewRoomType(this);
        this.rtp.MdiParent = this.MdiParent;
        this.rtp.TypeID = selectedValue;
      }
      int num = (int) this.rtp.ShowDialog();
    }

    private void btbDelType_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int typeID = (int) this.cmbType1.SelectedValue;
      if (typeID == 2)
      {
        int num = (int) MessageBox.Show("Bạn không được phép xóa lại phòng [Thường]!");
      }
      else if (!this.IsInUsed(typeID))
      {
        if (MessageBox.Show("Bạn có chắc muốn xóa loại phòng này?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          IQueryable<RoomType> entities = smallHotelManager.RoomType.Where<RoomType>((Expression<Func<RoomType, bool>>) (rt => rt.TypeID == typeID));
          smallHotelManager.RoomType.DeleteAllOnSubmit<RoomType>((IEnumerable<RoomType>) entities);
          smallHotelManager.SubmitChanges();
          this.FormRefresh();
        }
      }
      else if (MessageBox.Show("Nếu bạn xóa loại phòng này,\nthì tất cả các phòng loại này sẽ chuyển về loại [Thường]\nBạn có chắc muốn xóa loại phòng này?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        Table<Room> room1 = smallHotelManager.Room;
        Expression<Func<Room, bool>> predicate = (Expression<Func<Room, bool>>) (rt => rt.TypeID == typeID);
        foreach (Room room2 in (IEnumerable<Room>) room1.Where<Room>(predicate))
          room2.TypeID = 2;
        smallHotelManager.SubmitChanges();
        IQueryable<RoomType> entities = smallHotelManager.RoomType.Where<RoomType>((Expression<Func<RoomType, bool>>) (rt => rt.TypeID == typeID));
        smallHotelManager.RoomType.DeleteAllOnSubmit<RoomType>((IEnumerable<RoomType>) entities);
        smallHotelManager.SubmitChanges();
        this.FormRefresh();
      }
    }

    private bool IsInUsed(int typeId) => new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").Room.Count<Room>((Expression<Func<Room, bool>>) (q => q.TypeID == typeId)) > 0;
  }
}
