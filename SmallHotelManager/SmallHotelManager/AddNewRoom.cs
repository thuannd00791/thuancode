// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AddNewRoom
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
  public class AddNewRoom : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox txtRoomNo;
    private Label label2;
    private Button btnSave;
    private Button btnCancel;
    private ComboBox cmbTypeRoom;
    private Label label4;
    private TextBox txtNote;
    private int _roomid = 0;
    private RoomManger _parent;
    private int _status = 0;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddNewRoom));
      this.label1 = new Label();
      this.txtRoomNo = new TextBox();
      this.label2 = new Label();
      this.btnSave = new Button();
      this.btnCancel = new Button();
      this.cmbTypeRoom = new ComboBox();
      this.label4 = new Label();
      this.txtNote = new TextBox();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(5, 17);
      this.label1.Margin = new Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(66, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Số phòng";
      this.txtRoomNo.Location = new Point(88, 13);
      this.txtRoomNo.Margin = new Padding(4);
      this.txtRoomNo.Name = "txtRoomNo";
      this.txtRoomNo.Size = new Size(132, 22);
      this.txtRoomNo.TabIndex = 1;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(5, 47);
      this.label2.Margin = new Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(75, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Loại phòng";
      this.btnSave.BackColor = SystemColors.GradientInactiveCaption;
      this.btnSave.Location = new Point(32, 211);
      this.btnSave.Margin = new Padding(4);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(100, 28);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "Thêm";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Location = new Point(179, 211);
      this.btnCancel.Margin = new Padding(4);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(100, 28);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.cmbTypeRoom.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTypeRoom.FormattingEnabled = true;
      this.cmbTypeRoom.Location = new Point(88, 44);
      this.cmbTypeRoom.Margin = new Padding(4);
      this.cmbTypeRoom.Name = "cmbTypeRoom";
      this.cmbTypeRoom.Size = new Size(160, 24);
      this.cmbTypeRoom.TabIndex = 2;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(5, 76);
      this.label4.Margin = new Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(54, 16);
      this.label4.TabIndex = 16;
      this.label4.Text = "Ghi Chú";
      this.txtNote.Location = new Point(88, 76);
      this.txtNote.Margin = new Padding(4);
      this.txtNote.Multiline = true;
      this.txtNote.Name = "txtNote";
      this.txtNote.Size = new Size(216, (int) sbyte.MaxValue);
      this.txtNote.TabIndex = 4;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(312, 248);
      this.Controls.Add((Control) this.txtNote);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.cmbTypeRoom);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnSave);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.txtRoomNo);
      this.Controls.Add((Control) this.label1);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(328, 286);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(328, 286);
      this.Name = nameof (AddNewRoom);
      this.Text = "Thêm phòng mới";
      this.WindowState = FormWindowState.Maximized;
      this.FormClosing += new FormClosingEventHandler(this.AddNewRoom_FormClosing);
      this.Load += new EventHandler(this.AddNewRoom_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public int Status
    {
      get => this._status;
      set => this._status = value;
    }

    public int RoomID
    {
      set => this._roomid = value;
      get => this._roomid;
    }

    public AddNewRoom(RoomManger parent)
    {
      this._parent = parent;
      this.InitializeComponent();
      this.cmbTypeRoom.DataSource = (object) new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").RoomType.Where<RoomType>((Expression<Func<RoomType, bool>>) (t => t.TypeID > 1)).Select(t => new
      {
        TypeID = t.TypeID,
        TypeName = t.TypeName
      });
      this.cmbTypeRoom.DisplayMember = "TypeName";
      this.cmbTypeRoom.ValueMember = "TypeID";
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        int selectedValue = (int) this.cmbTypeRoom.SelectedValue;
        string roomNo = this.txtRoomNo.Text.ToString();
        string note = this.txtNote.Text.ToString();
        if (!this.IsExistRoom(roomNo))
        {
          if (this._roomid == 0)
            this.AddNew(roomNo, selectedValue, note);
          else
            this.Edition(roomNo, selectedValue, note);
        }
        else
        {
          int num = (int) MessageBox.Show("Phòng này đã tồn tại.\n Xin vui lòng thử lại!!!");
          return;
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Chỉ được phép nhập số.\n Xin vui lòng thử lại!!!");
        this.txtRoomNo.Text = "";
        return;
      }
      this._parent.FormRefresh();
    }

    private void Edition(string roomNo, int typeId, string note)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (p => p.RoomID == this._roomid));
        room.RoomNo = roomNo.ToString();
        room.TypeID = typeId;
        room.Not = note.ToString();
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num1 = (int) MessageBox.Show("Chỉnh sửa thành công!!!");
    }

    private void AddNew(string roomNo, int typeId, string note)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        Room entity = new Room()
        {
          RoomNo = roomNo.ToString(),
          StatusID = 2,
          TypeID = typeId,
          Not = note.ToString()
        };
        smallHotelManager.Room.InsertOnSubmit(entity);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num1 = (int) MessageBox.Show("Thêm phòng thành công!!!");
    }

    private bool IsExistRoom(string roomNo)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._roomid == 0)
      {
        if (smallHotelManager.Room.Count<Room>((Expression<Func<Room, bool>>) (q => q.RoomNo.Equals(roomNo.ToString()))) > 0)
          return true;
      }
      else if (smallHotelManager.Room.Count<Room>((Expression<Func<Room, bool>>) (q => q.RoomNo.Equals(roomNo.ToString()) && q.RoomID != this._roomid)) > 0)
        return true;
      return false;
    }

    private void AddNewRoom_Load(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._roomid == 0)
        return;
      this.Status = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (x => x.RoomID == this._roomid)).StatusID;
      this.Text = "Chỉnh sửa phòng";
      this.btnSave.Text = "Lưu";
      Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (d => d.RoomID == this._roomid));
      this.txtRoomNo.Text = room.RoomNo.ToString();
      this.txtNote.Text = room.Not;
      this.cmbTypeRoom.SelectedValue = (object) room.TypeID;
    }

    private void AddNewRoom_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();
  }
}
