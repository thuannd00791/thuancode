// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AddNewError
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
  public class AddNewError : Form
  {
    private Main _parent;
    private int _roomid;
    private IContainer components = (IContainer) null;
    private TextBox textBox1;
    private Label label1;
    private Label label2;
    private Button btnSave;
    private Button btnCancel;

    public int Roomid
    {
      get => this._roomid;
      set => this._roomid = value;
    }

    public AddNewError(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      Room room = smallHotelManager.Room.Single<Room>((Expression<Func<Room, bool>>) (x => x.RoomID == this._roomid));
      int num = this.textBox1.Text == "" ? 0 : (this.textBox1.Text != null ? 1 : 0);
      room.Not = num != 0 ? this.textBox1.Text : "";
      room.StatusID = 5;
      smallHotelManager.SubmitChanges();
      this._parent.bindToErrorRoom();
      this._parent.RoomCreating();
      this.Dispose();
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Dispose();

    private void AddNewError_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    private void AddNewError_Load(object sender, EventArgs e) => this.label1.Text = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").Room.Single<Room>((Expression<Func<Room, bool>>) (x => x.RoomID == this._roomid)).RoomNo;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AddNewError));
      this.textBox1 = new TextBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.btnSave = new Button();
      this.btnCancel = new Button();
      this.SuspendLayout();
      this.textBox1.Location = new Point(12, 70);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(260, 75);
      this.textBox1.TabIndex = 1;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Tomato;
      this.label1.Location = new Point(94, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(92, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(12, 45);
      this.label2.Name = "label2";
      this.label2.Size = new Size(47, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Hỏng: ";
      this.btnSave.BackColor = SystemColors.GradientInactiveCaption;
      this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Location = new Point(12, 152);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(75, 32);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Lưu";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(100, 152);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(75, 32);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(284, 186);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnSave);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(300, 224);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(300, 224);
      this.Name = nameof (AddNewError);
      this.Text = "Báo hỏng";
      this.FormClosing += new FormClosingEventHandler(this.AddNewError_FormClosing);
      this.Load += new EventHandler(this.AddNewError_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
