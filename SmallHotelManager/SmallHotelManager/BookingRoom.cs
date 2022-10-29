// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.BookingRoom
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class BookingRoom : Form
  {
    private Main _parent;
    private AddNewBooking rm = (AddNewBooking) null;
    private IContainer components = (IContainer) null;
    private Button button4;
    private Button btnDel;
    private Button btnEdit;
    private Button btnBook;
    private DataGridView grvBookedRoom;
    private GroupBox groupBox1;
    private Label label2;
    private Label label3;
    private DateTimePicker dtpByDay;
    private Label label4;
    private ComboBox cmbType;
    private GroupBox groupBox2;
    private DataGridViewTextBoxColumn BookingID;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column7;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn Column8;

    public BookingRoom(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
      DateTime date = DateTime.Now.Date;
      this.dtpByDay.CustomFormat = "dd/MM/yyyy";
      this.dtpByDay.Format = DateTimePickerFormat.Custom;
      this.cmbType.SelectedIndex = 0;
      this.GrvGetData();
    }

    public void FormRefresh()
    {
      this.cmbType.SelectedIndex = 0;
      this.GrvGetData();
    }

    public void GrvGetData()
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.grvBookedRoom.DataSource = (object) smallHotelManager.BookedRoom.Select(s => new
      {
        BookingID = s.BookingID,
        RoomNo = s.RoomNo,
        NameOfBooker = s.NameOfBooker,
        BookingDate = string.Format("{0:d/M/yyyy}", (object) s.BookingDate.Value.Date),
        CODate = string.Format("{0:d/M/yyyy}", (object) s.CODate.Value.Date),
        PhoneNumber = s.PhoneNumber,
        NumOfPersons = s.NumOfPersons,
        Prepaid = string.Format("{0:0,0}", (object) (s.Prepaid * (int?) 1000)),
        BookingNote = s.BookingNote
      });
      smallHotelManager.Connection.Close();
    }

    private void button4_Click(object sender, EventArgs e) => this.Dispose();

    private void btnBook_Click(object sender, EventArgs e)
    {
      int num = (int) new AddNewBooking(this).ShowDialog();
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this.grvBookedRoom.RowCount <= 0 || MessageBox.Show("Bạn có chắc muốn xóa phòng đặt này?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      int roomID = int.Parse(this.grvBookedRoom.Rows[this.grvBookedRoom.CurrentCell.RowIndex].Cells[0].Value.ToString());
      IQueryable<BookedRoom> entities = smallHotelManager.BookedRoom.Where<BookedRoom>((Expression<Func<BookedRoom, bool>>) (r => r.BookingID == roomID));
      smallHotelManager.BookedRoom.DeleteAllOnSubmit<BookedRoom>((IEnumerable<BookedRoom>) entities);
      smallHotelManager.SubmitChanges();
      this.FormRefresh();
    }

    private void BookingRoom_FormClosing(object sender, FormClosingEventArgs e)
    {
      this._parent.listBookingData();
      this.Dispose();
    }

    public void grvBindData(DateTime date)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.grvBookedRoom.Rows.Clear();
      this.grvBookedRoom.DataSource = (object) smallHotelManager.BookedRoom.Where<BookedRoom>((Expression<Func<BookedRoom, bool>>) (s => s.BookingDate.Value.Date == date)).Select(s => new
      {
        BookingID = s.BookingID,
        RoomNo = s.RoomNo,
        NameOfBooker = s.NameOfBooker,
        BookingDate = string.Format("{0:d/M/yyyy}", (object) s.BookingDate.Value.Date),
        CODate = string.Format("{0:d/M/yyyy}", (object) s.CODate.Value.Date),
        PhoneNumber = s.PhoneNumber,
        NumOfPersons = s.NumOfPersons,
        Prepaid = string.Format("{0:0,0}", (object) (s.Prepaid * (int?) 1000)),
        BookingNote = s.BookingNote
      });
      smallHotelManager.Connection.Close();
    }

    public void grvBindDataByMonth(DateTime date)
    {
      this.grvBookedRoom.Rows.Clear();
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.grvBookedRoom.DataSource = (object) smallHotelManager.BookedRoom.Where<BookedRoom>((Expression<Func<BookedRoom, bool>>) (s => s.BookingDate.Value.Date.Month == date.Month)).Select(s => new
      {
        BookingID = s.BookingID,
        RoomNo = s.RoomNo,
        NameOfBooker = s.NameOfBooker,
        BookingDate = string.Format("{0:d/M/yyyy}", (object) s.BookingDate.Value.Date),
        CODate = string.Format("{0:d/M/yyyy}", (object) s.CODate.Value.Date),
        PhoneNumber = s.PhoneNumber,
        NumOfPersons = s.NumOfPersons,
        Prepaid = string.Format("{0:0,0}", (object) (s.Prepaid * (int?) 1000)),
        BookingNote = s.BookingNote
      });
      smallHotelManager.Connection.Close();
    }

    private void cmbType_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (this.cmbType.SelectedIndex == 1)
      {
        this.label3.Text = "Ngày";
        this.label2.Visible = false;
        this.dtpByDay.CustomFormat = "dd/MM/yyyy";
        this.dtpByDay.Format = DateTimePickerFormat.Custom;
        this.grvBindData(this.dtpByDay.Value.Date);
      }
      else if (this.cmbType.SelectedIndex == 2)
      {
        this.label3.Text = "Tháng";
        this.label2.Visible = true;
        this.dtpByDay.CustomFormat = "MM/yyyy";
        this.dtpByDay.Format = DateTimePickerFormat.Custom;
        this.grvBindDataByMonth(this.dtpByDay.Value.Date);
      }
      else
      {
        this.label3.Text = "";
        this.label2.Visible = false;
        this.GrvGetData();
      }
    }

    private void dtpByDay_ValueChanged(object sender, EventArgs e)
    {
      DateTime date = this.dtpByDay.Value.Date;
      if (this.cmbType.SelectedIndex == 1)
        this.grvBindData(date);
      else if (this.cmbType.SelectedIndex == 2)
        this.grvBindDataByMonth(this.dtpByDay.Value.Date);
      else
        this.GrvGetData();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (this.rm != null && !this.rm.IsDisposed || this.grvBookedRoom.RowCount <= 0)
        return;
      int num1 = int.Parse(this.grvBookedRoom.Rows[this.grvBookedRoom.CurrentCell.RowIndex].Cells[0].Value.ToString());
      this.rm = new AddNewBooking(this);
      this.rm.MdiParent = this.MdiParent;
      this.rm.BookingID = num1;
      int num2 = (int) this.rm.ShowDialog();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BookingRoom));
      this.button4 = new Button();
      this.btnDel = new Button();
      this.btnEdit = new Button();
      this.btnBook = new Button();
      this.grvBookedRoom = new DataGridView();
      this.groupBox1 = new GroupBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.dtpByDay = new DateTimePicker();
      this.label4 = new Label();
      this.cmbType = new ComboBox();
      this.groupBox2 = new GroupBox();
      this.BookingID = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column7 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column6 = new DataGridViewTextBoxColumn();
      this.Column8 = new DataGridViewTextBoxColumn();
      ((ISupportInitialize) this.grvBookedRoom).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.button4.BackColor = SystemColors.GradientInactiveCaption;
      this.button4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button4.Location = new Point(687, 344);
      this.button4.Name = "button4";
      this.button4.Size = new Size(75, 40);
      this.button4.TabIndex = 10;
      this.button4.Text = "Thoát";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.btnDel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnDel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnDel.Location = new Point(298, 344);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new Size(107, 40);
      this.btnDel.TabIndex = 9;
      this.btnDel.Text = "Hủy Đặt Phòng";
      this.btnDel.UseVisualStyleBackColor = false;
      this.btnDel.Click += new EventHandler(this.btnDel_Click);
      this.btnEdit.BackColor = SystemColors.GradientInactiveCaption;
      this.btnEdit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEdit.Location = new Point(155, 344);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new Size(108, 40);
      this.btnEdit.TabIndex = 8;
      this.btnEdit.Text = "Chỉnh Sửa";
      this.btnEdit.UseVisualStyleBackColor = false;
      this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
      this.btnBook.BackColor = SystemColors.GradientInactiveCaption;
      this.btnBook.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnBook.Location = new Point(16, 344);
      this.btnBook.Name = "btnBook";
      this.btnBook.Size = new Size(117, 40);
      this.btnBook.TabIndex = 7;
      this.btnBook.Text = "Đặt Phòng";
      this.btnBook.UseVisualStyleBackColor = false;
      this.btnBook.Click += new EventHandler(this.btnBook_Click);
      this.grvBookedRoom.AllowUserToAddRows = false;
      this.grvBookedRoom.AllowUserToDeleteRows = false;
      gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.grvBookedRoom.AlternatingRowsDefaultCellStyle = gridViewCellStyle;
      this.grvBookedRoom.BackgroundColor = SystemColors.ButtonHighlight;
      this.grvBookedRoom.Columns.AddRange((DataGridViewColumn) this.BookingID, (DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column8);
      this.grvBookedRoom.Dock = DockStyle.Fill;
      this.grvBookedRoom.Location = new Point(3, 18);
      this.grvBookedRoom.Name = "grvBookedRoom";
      this.grvBookedRoom.ReadOnly = true;
      this.grvBookedRoom.RowHeadersVisible = false;
      this.grvBookedRoom.Size = new Size(755, 218);
      this.grvBookedRoom.TabIndex = 6;
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.dtpByDay);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.cmbType);
      this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.groupBox1.Location = new Point(7, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(758, 81);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Hiển thị danh sách theo";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Italic);
      this.label2.ImeMode = ImeMode.NoControl;
      this.label2.Location = new Point(216, 54);
      this.label2.Name = "label2";
      this.label2.Size = new Size(218, 16);
      this.label2.TabIndex = 7;
      this.label2.Text = "(*Chọn bất kỳ một ngày trong tháng)";
      this.label2.Visible = false;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f);
      this.label3.ImeMode = ImeMode.NoControl;
      this.label3.Location = new Point(51, 54);
      this.label3.Name = "label3";
      this.label3.Size = new Size(47, 16);
      this.label3.TabIndex = 6;
      this.label3.Text = "Tháng";
      this.dtpByDay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.dtpByDay.Font = new Font("Microsoft Sans Serif", 9.75f);
      this.dtpByDay.Format = DateTimePickerFormat.Custom;
      this.dtpByDay.Location = new Point(104, 49);
      this.dtpByDay.Name = "dtpByDay";
      this.dtpByDay.Size = new Size(106, 22);
      this.dtpByDay.TabIndex = 5;
      this.dtpByDay.ValueChanged += new EventHandler(this.dtpByDay_ValueChanged);
      this.label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold | FontStyle.Italic);
      this.label4.ImeMode = ImeMode.NoControl;
      this.label4.Location = new Point(6, 54);
      this.label4.Name = "label4";
      this.label4.Size = new Size(51, 16);
      this.label4.TabIndex = 2;
      this.label4.Text = "Chọn: ";
      this.cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbType.Font = new Font("Microsoft Sans Serif", 9.75f);
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Items.AddRange(new object[3]
      {
        (object) "Tất cả",
        (object) "Ngày",
        (object) "Tháng"
      });
      this.cmbType.Location = new Point(9, 19);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new Size(103, 24);
      this.cmbType.TabIndex = 0;
      this.cmbType.SelectionChangeCommitted += new EventHandler(this.cmbType_SelectionChangeCommitted);
      this.groupBox2.Controls.Add((Control) this.grvBookedRoom);
      this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.Location = new Point(4, 99);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(761, 239);
      this.groupBox2.TabIndex = 14;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Danh sách đặt phòng";
      this.BookingID.DataPropertyName = "BookingID";
      this.BookingID.HeaderText = "Column6";
      this.BookingID.Name = "BookingID";
      this.BookingID.ReadOnly = true;
      this.BookingID.Visible = false;
      this.Column1.DataPropertyName = "RoomNo";
      this.Column1.FillWeight = 50f;
      this.Column1.HeaderText = "Phòng";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column2.DataPropertyName = "NameOfBooker";
      this.Column2.FillWeight = 120f;
      this.Column2.HeaderText = "Tên Khách";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column3.DataPropertyName = "BookingDate";
      this.Column3.FillWeight = 80f;
      this.Column3.HeaderText = "Ngày Đặt";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column7.DataPropertyName = "CODate";
      this.Column7.HeaderText = "Ngày Đi";
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.Column4.DataPropertyName = "PhoneNumber";
      this.Column4.HeaderText = "Phone";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column5.DataPropertyName = "NumOfPersons";
      this.Column5.FillWeight = 120f;
      this.Column5.HeaderText = "Số Người Ở";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column6.DataPropertyName = "PrePaid";
      this.Column6.HeaderText = "Trả Trước";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column8.DataPropertyName = "BookingNote";
      this.Column8.HeaderText = "Ghi Chú";
      this.Column8.Name = "Column8";
      this.Column8.ReadOnly = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(777, 396);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.btnDel);
      this.Controls.Add((Control) this.btnEdit);
      this.Controls.Add((Control) this.btnBook);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(793, 434);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(793, 434);
      this.Name = nameof (BookingRoom);
      this.Text = "Đặt phòng";
      this.FormClosing += new FormClosingEventHandler(this.BookingRoom_FormClosing);
      ((ISupportInitialize) this.grvBookedRoom).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
