// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AddNewRoomType
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
  public class AddNewRoomType : Form
  {
    private int _typeid;
    private RoomManger _parent;
    private IContainer components = (IContainer) null;
    private Button btnCancel;
    private Button btnAdd;
    private Label label3;
    private TextBox txtTypeName;
    private Label label20;
    private TextBox txtStartByDay;
    private Label label14;
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
    private Label label21;
    private TextBox txtMinutes;
    private Label label22;

    public int TypeID
    {
      set => this._typeid = value;
      get => this._typeid;
    }

    public AddNewRoomType(RoomManger parent)
    {
      this._parent = parent;
      this.InitializeComponent();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void btnAdd_Click(object sender, EventArgs e)
    {
      try
      {
        string typeName = this.txtTypeName.Text.ToString();
        int priceByHour = int.Parse(this.txtByHour.Text.ToString());
        int priceByNight = int.Parse(this.txtByNight.Text.ToString());
        int priceByDay = int.Parse(this.txtByDay.Text.ToString());
        int pricePerNextHour = int.Parse(this.txtNextHour.Text.ToString());
        int timeForByHour = int.Parse(this.txtNumOfHour.Text.ToString());
        int byNightEndTime = int.Parse(this.txtEndByNight.Text.ToString());
        int byDayEndTime = int.Parse(this.txtEndByday.Text.ToString());
        int byNightStartTime = int.Parse(this.txtStartByNight.Text.ToString());
        int byDayStartTime = int.Parse(this.txtStartByDay.Text.ToString());
        int minuteOver = int.Parse(this.txtMinutes.Text.ToString());
        if (!this.IsExistRoomType(typeName))
        {
          if (this._typeid == 0)
            this.AddNew(typeName, priceByHour, priceByNight, priceByDay, pricePerNextHour, timeForByHour, byNightEndTime, byDayEndTime, byNightStartTime, byDayStartTime, minuteOver);
          else
            this.Edition(typeName, priceByHour, priceByNight, priceByDay, pricePerNextHour, timeForByHour, byNightEndTime, byDayEndTime, byNightStartTime, byDayStartTime, minuteOver);
        }
        else
        {
          int num = (int) MessageBox.Show("Loại phòng này đã tồn tại.\n Xin vui lòng thử lại!!!");
          return;
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Chỉ được phép nhập số.\n Xin vui lòng thử lại!!!");
        this.txtTypeName.Text = "";
        return;
      }
      this._parent.FormRefresh();
    }

    private bool IsExistRoomType(string typeName)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._typeid == 0)
      {
        if (smallHotelManager.RoomType.Count<RoomType>((Expression<Func<RoomType, bool>>) (q => q.TypeName == typeName)) > 0)
          return true;
      }
      else if (smallHotelManager.RoomType.Count<RoomType>((Expression<Func<RoomType, bool>>) (q => q.TypeName == typeName && q.TypeID != this._typeid)) > 0)
        return true;
      return false;
    }

    private void Edition(
      string typeName,
      int priceByHour,
      int priceByNight,
      int priceByDay,
      int pricePerNextHour,
      int timeForByHour,
      int byNightEndTime,
      int byDayEndTime,
      int byNightStartTime,
      int byDayStartTime,
      int minuteOver)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        RoomType roomType = smallHotelManager.RoomType.Single<RoomType>((Expression<Func<RoomType, bool>>) (p => p.TypeID == this._typeid));
        roomType.TypeName = typeName;
        roomType.PriceByHour = priceByHour;
        roomType.PriceByNight = priceByNight;
        roomType.PriceByDay = priceByDay;
        roomType.PriceByNextHour = pricePerNextHour;
        roomType.TimeForByHourMethod = timeForByHour;
        roomType.ByNightEndTime = byNightEndTime;
        roomType.ByNightStartTime = byNightStartTime;
        roomType.ByDayEndTime = byDayEndTime;
        roomType.ByDayStartTime = byDayStartTime;
        roomType.MinuteOver = minuteOver;
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num1 = (int) MessageBox.Show("Chỉnh sửa thành công!!!");
    }

    private void AddNew(
      string typeName,
      int priceByHour,
      int priceByNight,
      int priceByDay,
      int pricePerNextHour,
      int timeForByHour,
      int byNightEndTime,
      int byDayEndTime,
      int byNightStartTime,
      int byDayStartTime,
      int minuteOver)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        RoomType entity = new RoomType()
        {
          TypeName = typeName.ToString(),
          PriceByHour = priceByHour,
          PriceByNight = priceByNight,
          PriceByDay = priceByDay,
          PriceByNextHour = pricePerNextHour,
          TimeForByHourMethod = timeForByHour,
          ByNightStartTime = byNightStartTime,
          ByNightEndTime = byNightEndTime,
          ByDayStartTime = byDayStartTime,
          ByDayEndTime = byDayEndTime,
          MinuteOver = minuteOver
        };
        smallHotelManager.RoomType.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num1 = (int) MessageBox.Show("Thêm loại phòng thành công!!!");
    }

    private void AddNewRoomType_Load(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._typeid == 0)
        return;
      this.Text = "Chỉnh sửa phòng";
      this.btnAdd.Text = "Lưu";
      RoomType roomType = smallHotelManager.RoomType.Single<RoomType>((Expression<Func<RoomType, bool>>) (d => d.TypeID == this._typeid));
      this.txtTypeName.Text = roomType.TypeName.ToString();
      if (this._typeid == 2)
        this.txtTypeName.ReadOnly = true;
      TextBox txtByHour = this.txtByHour;
      int num = roomType.PriceByHour;
      string str1 = num.ToString();
      txtByHour.Text = str1;
      TextBox txtByNight = this.txtByNight;
      num = roomType.PriceByNight;
      string str2 = num.ToString();
      txtByNight.Text = str2;
      TextBox txtByDay = this.txtByDay;
      num = roomType.PriceByDay;
      string str3 = num.ToString();
      txtByDay.Text = str3;
      TextBox txtNextHour = this.txtNextHour;
      num = roomType.PriceByNextHour;
      string str4 = num.ToString();
      txtNextHour.Text = str4;
      TextBox txtNumOfHour = this.txtNumOfHour;
      num = roomType.TimeForByHourMethod;
      string str5 = num.ToString();
      txtNumOfHour.Text = str5;
      TextBox txtStartByDay = this.txtStartByDay;
      num = roomType.ByDayStartTime;
      string str6 = num.ToString();
      txtStartByDay.Text = str6;
      TextBox txtEndByday = this.txtEndByday;
      num = roomType.ByDayEndTime;
      string str7 = num.ToString();
      txtEndByday.Text = str7;
      TextBox txtStartByNight = this.txtStartByNight;
      num = roomType.ByNightStartTime;
      string str8 = num.ToString();
      txtStartByNight.Text = str8;
      TextBox txtEndByNight = this.txtEndByNight;
      num = roomType.ByNightEndTime;
      string str9 = num.ToString();
      txtEndByNight.Text = str9;
      TextBox txtMinutes = this.txtMinutes;
      num = roomType.MinuteOver;
      string str10 = num.ToString();
      txtMinutes.Text = str10;
    }

    private void AddNewRoomType_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddNewRoomType));
      this.btnCancel = new Button();
      this.btnAdd = new Button();
      this.label3 = new Label();
      this.txtTypeName = new TextBox();
      this.label20 = new Label();
      this.txtStartByDay = new TextBox();
      this.label14 = new Label();
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
      this.label21 = new Label();
      this.txtMinutes = new TextBox();
      this.label22 = new Label();
      this.SuspendLayout();
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Location = new Point(108, 239);
      this.btnCancel.Margin = new Padding(4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(84, 46);
      this.btnCancel.TabIndex = 13;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Location = new Point(16, 239);
      this.btnAdd.Margin = new Padding(4);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(84, 46);
      this.btnAdd.TabIndex = 12;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(16, 12);
      this.label3.Margin = new Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(79, 15);
      this.label3.TabIndex = 38;
      this.label3.Text = "Loại phòng";
      this.txtTypeName.Location = new Point(103, 9);
      this.txtTypeName.Margin = new Padding(4);
      this.txtTypeName.Name = "txtTypeName";
      this.txtTypeName.Size = new Size(164, 22);
      this.txtTypeName.TabIndex = 1;
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.Location = new Point(84, 151);
      this.label20.Name = "label20";
      this.label20.Size = new Size(55, 16);
      this.label20.TabIndex = 87;
      this.label20.Text = "h00 đến";
      this.txtStartByDay.Location = new Point(56, 148);
      this.txtStartByDay.Name = "txtStartByDay";
      this.txtStartByDay.Size = new Size(25, 22);
      this.txtStartByDay.TabIndex = 8;
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.Location = new Point(13, 151);
      this.label14.Name = "label14";
      this.label14.Size = new Size(41, 16);
      this.label14.TabIndex = 85;
      this.label14.Text = "tính từ";
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.Location = new Point(226, 179);
      this.label15.Name = "label15";
      this.label15.Size = new Size(56, 16);
      this.label15.TabIndex = 84;
      this.label15.Text = ".000 / 1h";
      this.txtNextHour.Location = new Point(174, 176);
      this.txtNextHour.Name = "txtNextHour";
      this.txtNextHour.Size = new Size(46, 22);
      this.txtNextHour.TabIndex = 10;
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.Location = new Point(13, 179);
      this.label16.Name = "label16";
      this.label16.Size = new Size(155, 16);
      this.label16.TabIndex = 82;
      this.label16.Text = "Giá cho mỗi giờ tiếp theo";
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(170, 151);
      this.label13.Name = "label13";
      this.label13.Size = new Size(116, 16);
      this.label13.TabIndex = 81;
      this.label13.Text = "h00 ngày hôm sau";
      this.txtEndByday.Location = new Point(140, 148);
      this.txtEndByday.Name = "txtEndByday";
      this.txtEndByday.Size = new Size(25, 22);
      this.txtEndByday.TabIndex = 9;
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(195, 123);
      this.label10.Name = "label10";
      this.label10.Size = new Size(72, 16);
      this.label10.TabIndex = 79;
      this.label10.Text = ".000 / ngày";
      this.txtByDay.Location = new Point(99, 120);
      this.txtByDay.Name = "txtByDay";
      this.txtByDay.Size = new Size(90, 22);
      this.txtByDay.TabIndex = 7;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(13, 123);
      this.label6.Name = "label6";
      this.label6.Size = new Size(88, 16);
      this.label6.TabIndex = 77;
      this.label6.Text = "Giá qua ngày";
      this.txtStartByNight.Location = new Point(56, 92);
      this.txtStartByNight.Name = "txtStartByNight";
      this.txtStartByNight.Size = new Size(25, 22);
      this.txtStartByNight.TabIndex = 5;
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.Location = new Point(13, 95);
      this.label19.Name = "label19";
      this.label19.Size = new Size(41, 16);
      this.label19.TabIndex = 75;
      this.label19.Text = "tính từ";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(171, 95);
      this.label11.Name = "label11";
      this.label11.Size = new Size(116, 16);
      this.label11.TabIndex = 74;
      this.label11.Text = "h00 ngày hôm sau";
      this.txtEndByNight.Location = new Point(140, 92);
      this.txtEndByNight.Name = "txtEndByNight";
      this.txtEndByNight.Size = new Size(25, 22);
      this.txtEndByNight.TabIndex = 6;
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(84, 95);
      this.label12.Name = "label12";
      this.label12.Size = new Size(55, 16);
      this.label12.TabIndex = 72;
      this.label12.Text = "h00 đến";
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(195, 67);
      this.label9.Name = "label9";
      this.label9.Size = new Size(69, 16);
      this.label9.TabIndex = 71;
      this.label9.Text = ".000 / đêm";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(240, 41);
      this.label8.Name = "label8";
      this.label8.Size = new Size(41, 16);
      this.label8.TabIndex = 70;
      this.label8.Text = "h đầu";
      this.txtNumOfHour.Location = new Point(215, 38);
      this.txtNumOfHour.Name = "txtNumOfHour";
      this.txtNumOfHour.Size = new Size(23, 22);
      this.txtNumOfHour.TabIndex = 3;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(170, 41);
      this.label7.Name = "label7";
      this.label7.Size = new Size(39, 16);
      this.label7.TabIndex = 68;
      this.label7.Text = ".000 /";
      this.txtByNight.Location = new Point(99, 64);
      this.txtByNight.Name = "txtByNight";
      this.txtByNight.Size = new Size(90, 22);
      this.txtByNight.TabIndex = 4;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(13, 67);
      this.label5.Name = "label5";
      this.label5.Size = new Size(85, 16);
      this.label5.TabIndex = 66;
      this.label5.Text = "Giá qua đêm";
      this.txtByHour.Location = new Point(99, 38);
      this.txtByHour.Name = "txtByHour";
      this.txtByHour.Size = new Size(66, 22);
      this.txtByHour.TabIndex = 2;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(13, 41);
      this.label4.Name = "label4";
      this.label4.Size = new Size(80, 16);
      this.label4.TabIndex = 64;
      this.label4.Text = "Giá theo giờ";
      this.label21.AutoSize = true;
      this.label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label21.Location = new Point(106, 207);
      this.label21.Name = "label21";
      this.label21.Size = new Size(141, 16);
      this.label21.TabIndex = 90;
      this.label21.Text = "phút sẽ tính thành 1 giờ";
      this.txtMinutes.Location = new Point(73, 204);
      this.txtMinutes.Name = "txtMinutes";
      this.txtMinutes.Size = new Size(27, 22);
      this.txtMinutes.TabIndex = 11;
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.Location = new Point(13, 207);
      this.label22.Name = "label22";
      this.label22.Size = new Size(62, 16);
      this.label22.TabIndex = 88;
      this.label22.Text = "Nếu quá ";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(294, 292);
      this.Controls.Add((Control) this.label21);
      this.Controls.Add((Control) this.txtMinutes);
      this.Controls.Add((Control) this.label22);
      this.Controls.Add((Control) this.label20);
      this.Controls.Add((Control) this.txtStartByDay);
      this.Controls.Add((Control) this.label14);
      this.Controls.Add((Control) this.label15);
      this.Controls.Add((Control) this.txtNextHour);
      this.Controls.Add((Control) this.label16);
      this.Controls.Add((Control) this.label13);
      this.Controls.Add((Control) this.txtEndByday);
      this.Controls.Add((Control) this.label10);
      this.Controls.Add((Control) this.txtByDay);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.txtStartByNight);
      this.Controls.Add((Control) this.label19);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.txtEndByNight);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.txtNumOfHour);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.txtByNight);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.txtByHour);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.txtTypeName);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnAdd);
      this.Controls.Add((Control) this.label3);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(310, 330);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(310, 330);
      this.Name = nameof (AddNewRoomType);
      this.Text = "Thêm loại phòng mới";
      this.FormClosing += new FormClosingEventHandler(this.AddNewRoomType_FormClosing);
      this.Load += new EventHandler(this.AddNewRoomType_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
