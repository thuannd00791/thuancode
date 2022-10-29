// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AddNewBooking
// Assembly: SmallHotelManager, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19C439E0-2D5A-423B-A0D0-4E7BDC1D8A7F
// Assembly location: C:\Users\thuan\Downloads\Quan Ly Khach San\3.0\SmallHotelManager.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SmallHotelManager
{
  public class AddNewBooking : Form
  {
    private IContainer components = (IContainer) null;
    private TextBox txtName;
    private DateTimePicker dateTimePicker1;
    private Button button2;
    private Button btnSave;
    private TextBox txtRoom;
    private TextBox txtNum;
    private TextBox txtPhone;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label lbl;
    private Label label6;
    private TextBox txtRe;
    private Label label5;
    private Label label7;
    private Label label8;
    private TextBox txtNote;
    private DateTimePicker dateTimePicker2;
    private BookingRoom _parent;
    private int _bookingID = 0;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddNewBooking));
      this.txtName = new TextBox();
      this.dateTimePicker1 = new DateTimePicker();
      this.button2 = new Button();
      this.btnSave = new Button();
      this.txtRoom = new TextBox();
      this.txtNum = new TextBox();
      this.txtPhone = new TextBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.lbl = new Label();
      this.label6 = new Label();
      this.txtRe = new TextBox();
      this.label5 = new Label();
      this.label7 = new Label();
      this.label8 = new Label();
      this.txtNote = new TextBox();
      this.dateTimePicker2 = new DateTimePicker();
      this.SuspendLayout();
      this.txtName.Location = new Point(132, 6);
      this.txtName.Margin = new Padding(5);
      this.txtName.Name = "txtName";
      this.txtName.Size = new Size(206, 22);
      this.txtName.TabIndex = 1;
      this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker1.Location = new Point(132, 70);
      this.dateTimePicker1.Margin = new Padding(5);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new Size(113, 22);
      this.dateTimePicker1.TabIndex = 3;
      this.button2.BackColor = SystemColors.GradientInactiveCaption;
      this.button2.Location = new Point(233, 291);
      this.button2.Margin = new Padding(5);
      this.button2.Name = "button2";
      this.button2.Size = new Size(105, 42);
      this.button2.TabIndex = 8;
      this.button2.Text = "Thoát";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.btnSave.BackColor = SystemColors.GradientInactiveCaption;
      this.btnSave.Location = new Point(28, 291);
      this.btnSave.Margin = new Padding(5);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(104, 42);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "Lưu";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.txtRoom.Location = new Point(132, 162);
      this.txtRoom.Margin = new Padding(5);
      this.txtRoom.Name = "txtRoom";
      this.txtRoom.Size = new Size(113, 22);
      this.txtRoom.TabIndex = 5;
      this.txtNum.Location = new Point(132, 130);
      this.txtNum.Margin = new Padding(5);
      this.txtNum.Name = "txtNum";
      this.txtNum.Size = new Size(113, 22);
      this.txtNum.TabIndex = 4;
      this.txtPhone.Location = new Point(132, 38);
      this.txtPhone.Margin = new Padding(5);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new Size(206, 22);
      this.txtPhone.TabIndex = 2;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(14, 41);
      this.label4.Margin = new Padding(5, 0, 5, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(47, 16);
      this.label4.TabIndex = 0;
      this.label4.Text = "Phone";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(14, 136);
      this.label3.Margin = new Padding(5, 0, 5, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(77, 16);
      this.label3.TabIndex = 0;
      this.label3.Text = "Số Người Ở";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(14, 75);
      this.label2.Margin = new Padding(5, 0, 5, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(64, 16);
      this.label2.TabIndex = 0;
      this.label2.Text = "Ngày Đặt";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(14, 9);
      this.label1.Margin = new Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(108, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tên Khách Hàng";
      this.lbl.AutoSize = true;
      this.lbl.Location = new Point(14, 168);
      this.lbl.Margin = new Padding(5, 0, 5, 0);
      this.lbl.Name = "lbl";
      this.lbl.Size = new Size(47, 16);
      this.lbl.TabIndex = 0;
      this.lbl.Text = "Phòng";
      this.label6.AutoSize = true;
      this.label6.Location = new Point((int) byte.MaxValue, 169);
      this.label6.Margin = new Padding(5, 0, 5, 0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(71, 16);
      this.label6.TabIndex = 26;
      this.label6.Text = "(.000 VNĐ)";
      this.txtRe.Location = new Point(132, 194);
      this.txtRe.Margin = new Padding(5);
      this.txtRe.Name = "txtRe";
      this.txtRe.Size = new Size(113, 22);
      this.txtRe.TabIndex = 6;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(14, 200);
      this.label5.Margin = new Padding(5, 0, 5, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(66, 16);
      this.label5.TabIndex = 0;
      this.label5.Text = "Đặt Trước";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(14, 106);
      this.label7.Name = "label7";
      this.label7.Size = new Size(56, 16);
      this.label7.TabIndex = 27;
      this.label7.Text = "Ngày Đi";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(14, 230);
      this.label8.Name = "label8";
      this.label8.Size = new Size(52, 16);
      this.label8.TabIndex = 28;
      this.label8.Text = "Ghi chú";
      this.txtNote.Location = new Point(132, 224);
      this.txtNote.Multiline = true;
      this.txtNote.Name = "txtNote";
      this.txtNote.Size = new Size(194, 59);
      this.txtNote.TabIndex = 30;
      this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
      this.dateTimePicker2.Location = new Point(132, 100);
      this.dateTimePicker2.Name = "dateTimePicker2";
      this.dateTimePicker2.Size = new Size(113, 22);
      this.dateTimePicker2.TabIndex = 31;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(345, 337);
      this.Controls.Add((Control) this.dateTimePicker2);
      this.Controls.Add((Control) this.txtNote);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.txtRe);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.txtName);
      this.Controls.Add((Control) this.dateTimePicker1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.btnSave);
      this.Controls.Add((Control) this.txtRoom);
      this.Controls.Add((Control) this.txtNum);
      this.Controls.Add((Control) this.txtPhone);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.lbl);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(361, 375);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(361, 375);
      this.Name = nameof (AddNewBooking);
      this.Text = "Đặt phòng";
      this.FormClosing += new FormClosingEventHandler(this.AddNewBooking_FormClosing);
      this.Load += new EventHandler(this.AddNewBooking_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public int BookingID
    {
      set => this._bookingID = value;
      get => this._bookingID;
    }

    public AddNewBooking(BookingRoom parent)
    {
      this.InitializeComponent();
      this._parent = parent;
    }

    private void AddNew(
      string roomNo,
      string name,
      string phone,
      DateTime date,
      DateTime outdate,
      int num,
      int repaid,
      string note)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        BookedRoom entity = new BookedRoom()
        {
          RoomNo = roomNo,
          NameOfBooker = name,
          PhoneNumber = phone,
          BookingDate = new DateTime?(date),
          NumOfPersons = new int?(num),
          Prepaid = new int?(repaid),
          CODate = new DateTime?(outdate),
          BookingNote = note
        };
        smallHotelManager.BookedRoom.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num1 = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num2 = (int) MessageBox.Show("Đặt phòng thành công!!!");
    }

    private void Edition(
      int bookingID,
      string roomNo,
      string name,
      string phone,
      DateTime date,
      DateTime outdate,
      int num,
      int repaid,
      string note)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        BookedRoom bookedRoom = smallHotelManager.BookedRoom.Single<BookedRoom>((Expression<Func<BookedRoom, bool>>) (p => p.BookingID == this._bookingID));
        bookedRoom.RoomNo = roomNo;
        bookedRoom.NameOfBooker = name;
        bookedRoom.PhoneNumber = phone;
        bookedRoom.BookingDate = new DateTime?(date);
        bookedRoom.NumOfPersons = new int?(num);
        bookedRoom.Prepaid = new int?(repaid);
        bookedRoom.CODate = new DateTime?(outdate);
        bookedRoom.BookingNote = note;
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num1 = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num2 = (int) MessageBox.Show("Chỉnh sửa đặt phòng thành công!!!");
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.txtName.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập tên Khách Hàng");
        this.txtName.Focus();
      }
      else if (string.IsNullOrEmpty(this.txtPhone.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập Số điện thoại của Khách Hàng");
        this.txtPhone.Focus();
      }
      else if (string.IsNullOrEmpty(this.txtRoom.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập tên phòng");
        this.txtRoom.Focus();
      }
      else
      {
        try
        {
          if (Convert.ToInt32(this.txtNum.Text) < 0)
          {
            int num = (int) MessageBox.Show("Vui lòng nhập số người ở > 0");
            this.txtNum.Focus();
            return;
          }
        }
        catch
        {
          int num = (int) MessageBox.Show("Số người ở chỉ được phép nhập số.\n Xin vui lòng thử lại!!!");
          this.txtNum.Text = "";
          return;
        }
        try
        {
          if (Convert.ToInt32(this.txtPhone.Text) < 0)
          {
            int num = (int) MessageBox.Show("Vui lòng nhập số điện thoại > 0");
            this.txtPhone.Focus();
            return;
          }
        }
        catch
        {
          int num = (int) MessageBox.Show("Số Điện Thoại chỉ được phép nhập số.\n Xin vui lòng thử lại!!!");
          this.txtPhone.Text = "";
          return;
        }
        try
        {
          if (Convert.ToInt32(this.txtRe.Text) < 0)
          {
            int num = (int) MessageBox.Show("Vui lòng nhập số tiền đặt trước > 0");
            this.txtRe.Focus();
            return;
          }
        }
        catch
        {
          int num = (int) MessageBox.Show("Số tiền đặt trước được phép nhập số.\n Xin vui lòng thử lại!!!");
          this.txtRe.Text = "";
          return;
        }
        string roomNo = this.txtRoom.Text.ToString();
        string name = this.txtName.Text.ToString();
        string phone = this.txtPhone.Text.ToString();
        int int32_1 = Convert.ToInt32(this.txtNum.Text);
        string note = this.txtNote.Text.ToString();
        int int32_2 = Convert.ToInt32(this.txtRe.Text.ToString());
        DateTime date = this.dateTimePicker1.Value;
        DateTime outdate = this.dateTimePicker2.Value;
        if (this._bookingID == 0)
          this.AddNew(roomNo, name, phone, date, outdate, int32_1, int32_2, note);
        else
          this.Edition(this.BookingID, roomNo, name, phone, date, outdate, int32_1, int32_2, note);
        this._parent.FormRefresh();
      }
    }

    private void AddNewBooking_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    private void button2_Click(object sender, EventArgs e) => this.Dispose();

    private void AddNewBooking_Load(object sender, EventArgs e)
    {
      if (this._bookingID == 0)
        return;
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.Text = "Chỉnh sửa Phòng Đặt";
      BookedRoom bookedRoom = smallHotelManager.BookedRoom.Single<BookedRoom>((Expression<Func<BookedRoom, bool>>) (d => d.BookingID == this._bookingID));
      this.txtName.Text = bookedRoom.NameOfBooker.ToString();
      this.txtNum.Text = bookedRoom.NumOfPersons.ToString();
      this.txtPhone.Text = bookedRoom.PhoneNumber.ToString();
      this.txtRoom.Text = bookedRoom.RoomNo.ToString();
      this.txtRe.Text = bookedRoom.Prepaid.ToString();
      this.dateTimePicker1.Value = DateTime.Parse(bookedRoom.BookingDate.ToString());
      this.dateTimePicker2.Value = DateTime.Parse(bookedRoom.CODate.ToString());
    }
  }
}
