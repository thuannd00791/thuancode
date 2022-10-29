// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.EditDataBase
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
  public class EditDataBase : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem createToolStripMenuItem;
    private Button button2;

    public EditDataBase() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      Table<RoomPurchaseInfo> roomPurchaseInfo1 = smallHotelManager.RoomPurchaseInfo;
      Expression<Func<RoomPurchaseInfo, bool>> predicate = (Expression<Func<RoomPurchaseInfo, bool>>) (x => x.Loan == (int?) 0);
      foreach (RoomPurchaseInfo roomPurchaseInfo2 in (IEnumerable<RoomPurchaseInfo>) roomPurchaseInfo1.Where<RoomPurchaseInfo>(predicate))
        roomPurchaseInfo2.IsPaid = new int?();
      smallHotelManager.SubmitChanges();
      int num = (int) MessageBox.Show("Successfull!");
    }

    public int CalculateCost(string roomNo, DateTime CO, DateTime CI)
    {
      DateTime now = DateTime.Now;
      CalculatorCost calculatorCost = new CalculatorCost();
      calculatorCost.GetData(roomNo, CO, CI, false);
      return calculatorCost.CalcuCost();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.button1 = new Button();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.createToolStripMenuItem = new ToolStripMenuItem();
      this.button2 = new Button();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.button1.ContextMenuStrip = this.contextMenuStrip1;
      this.button1.Location = new Point(13, 13);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.openToolStripMenuItem,
        (ToolStripItem) this.createToolStripMenuItem
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(109, 48);
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new Size(108, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.createToolStripMenuItem.Name = "createToolStripMenuItem";
      this.createToolStripMenuItem.Size = new Size(108, 22);
      this.createToolStripMenuItem.Text = "Create";
      this.button2.Location = new Point(126, 12);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(284, 261);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Name = nameof (EditDataBase);
      this.Text = nameof (EditDataBase);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
