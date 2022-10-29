// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.AttendanceReport
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
  public class AttendanceReport : Form
  {
    private IContainer components = (IContainer) null;
    private DataGridView grvAttendance;

    public AttendanceReport() => this.InitializeComponent();

    private void AttendanceReport_FormClosing(object sender, FormClosingEventArgs e) => this.Dispose();

    private void bindAttendaceData()
    {
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      db.Attendance.SelectMany((Expression<Func<Attendance, IEnumerable<Users>>>) (a => db.Users), (a, u) => new
      {
        a = a,
        u = u
      }).Where(data => data.a.UserID == (int?) data.u.UserID && data.u.DelIDUs != (int?) 1).Select(data => new
      {
        UserName = data.u.UserName,
        StartTime = string.Format("{0:d/M/yyyy HH:mm}", (object) data.a.StartTime),
        EndTime = string.Format("{0:d/M/yyyy HH:mm}", (object) data.a.EndTime)
      });
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AttendanceReport));
      this.grvAttendance = new DataGridView();
      ((ISupportInitialize) this.grvAttendance).BeginInit();
      this.SuspendLayout();
      this.grvAttendance.AllowUserToAddRows = false;
      this.grvAttendance.AllowUserToDeleteRows = false;
      this.grvAttendance.BackgroundColor = SystemColors.ButtonHighlight;
      this.grvAttendance.EnableHeadersVisualStyles = false;
      this.grvAttendance.Location = new Point(2, 62);
      this.grvAttendance.Margin = new Padding(4);
      this.grvAttendance.MultiSelect = false;
      this.grvAttendance.Name = "grvAttendance";
      this.grvAttendance.ReadOnly = true;
      this.grvAttendance.RowHeadersVisible = false;
      this.grvAttendance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.grvAttendance.RowsDefaultCellStyle = gridViewCellStyle;
      this.grvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvAttendance.Size = new Size(801, 369);
      this.grvAttendance.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(805, 491);
      this.Controls.Add((Control) this.grvAttendance);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (AttendanceReport);
      this.Text = "Bảng chấm công";
      this.FormClosing += new FormClosingEventHandler(this.AttendanceReport_FormClosing);
      ((ISupportInitialize) this.grvAttendance).EndInit();
      this.ResumeLayout(false);
    }
  }
}
