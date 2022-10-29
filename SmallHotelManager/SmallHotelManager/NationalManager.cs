// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.NationalManager
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
  public class NationalManager : Form
  {
    private IContainer components = (IContainer) null;
    private TextBox txtNation;
    private Button btnAdd;
    private Button btnEdit;
    private Button BtnDel;
    private Button btnClose;
    private ComboBox comboBox1;
    private int _nationalID = 0;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.txtNation = new TextBox();
      this.btnAdd = new Button();
      this.btnEdit = new Button();
      this.BtnDel = new Button();
      this.btnClose = new Button();
      this.comboBox1 = new ComboBox();
      this.SuspendLayout();
      this.txtNation.Location = new Point(16, 25);
      this.txtNation.Margin = new Padding(4);
      this.txtNation.Multiline = true;
      this.txtNation.Name = "txtNation";
      this.txtNation.Size = new Size(231, 32);
      this.txtNation.TabIndex = 1;
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(283, 25);
      this.btnAdd.Margin = new Padding(4);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(119, 32);
      this.btnAdd.TabIndex = 8;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.btnEdit.BackColor = SystemColors.GradientInactiveCaption;
      this.btnEdit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEdit.Location = new Point(16, 154);
      this.btnEdit.Margin = new Padding(4);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new Size(104, 32);
      this.btnEdit.TabIndex = 9;
      this.btnEdit.Text = "Chỉnh Sửa";
      this.btnEdit.UseVisualStyleBackColor = false;
      this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
      this.BtnDel.BackColor = SystemColors.GradientInactiveCaption;
      this.BtnDel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.BtnDel.Location = new Point(128, 154);
      this.BtnDel.Margin = new Padding(4);
      this.BtnDel.Name = "BtnDel";
      this.BtnDel.Size = new Size(119, 32);
      this.BtnDel.TabIndex = 10;
      this.BtnDel.Text = "Xóa";
      this.BtnDel.UseVisualStyleBackColor = false;
      this.btnClose.BackColor = SystemColors.GradientInactiveCaption;
      this.btnClose.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Location = new Point(283, 154);
      this.btnClose.Margin = new Padding(4);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(119, 32);
      this.btnClose.TabIndex = 11;
      this.btnClose.Text = "Thoát";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.ItemHeight = 24;
      this.comboBox1.Location = new Point(16, 91);
      this.comboBox1.Margin = new Padding(4);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(231, 32);
      this.comboBox1.TabIndex = 12;
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(424, 201);
      this.Controls.Add((Control) this.comboBox1);
      this.Controls.Add((Control) this.btnClose);
      this.Controls.Add((Control) this.BtnDel);
      this.Controls.Add((Control) this.btnEdit);
      this.Controls.Add((Control) this.btnAdd);
      this.Controls.Add((Control) this.txtNation);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Margin = new Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(440, 239);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(440, 239);
      this.Name = nameof (NationalManager);
      this.Text = "Quản lý Quốc tịch";
      this.Load += new EventHandler(this.NationalManager_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public NationalManager() => this.InitializeComponent();

    private void btnClose_Click(object sender, EventArgs e) => this.Dispose();

    private void cmbGetData()
    {
      this._nationalID = 0;
      this.btnAdd.Text = "Thêm";
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this.comboBox1.DataSource = (object) smallHotelManager.National.Where<National>((Expression<Func<National, bool>>) (g => g.IsDelete != (int?) 1)).Select(g => new
      {
        NationalID = g.NationalID,
        Nation = g.Nation
      });
      this.comboBox1.DisplayMember = "Nation";
      this.comboBox1.ValueMember = "NationalID";
      smallHotelManager.Connection.Close();
    }

    private void AddNew(string nati)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      National entity = new National()
      {
        Nation = nati,
        IsDelete = new int?(0)
      };
      smallHotelManager.National.InsertOnSubmit(entity);
      try
      {
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
      int num1 = (int) MessageBox.Show("Thêm Quốc tịch thành công");
      smallHotelManager.Connection.Close();
    }

    private void Edition(string nati)
    {
      try
      {
        SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
        smallHotelManager.National.Single<National>((Expression<Func<National, bool>>) (p => p.NationalID == this._nationalID)).Nation = nati;
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        return;
      }
      int num1 = (int) MessageBox.Show("Chỉnh sửa thành công!!!");
    }

    private bool IsExistRoom(string roomNo)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      if (this._nationalID == 0)
      {
        if (smallHotelManager.National.Count<National>((Expression<Func<National, bool>>) (q => q.Nation.Equals(roomNo.ToString()))) > 0)
          return true;
      }
      else if (smallHotelManager.National.Count<National>((Expression<Func<National, bool>>) (q => q.Nation.Equals(roomNo.ToString()) && q.NationalID != this._nationalID)) > 0)
        return true;
      return false;
    }

    private void NationalManager_Load(object sender, EventArgs e) => this.cmbGetData();

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.txtNation.Text))
      {
        int num = (int) MessageBox.Show("Vui lòng nhập tên Quốc tịch");
        this.txtNation.Focus();
      }
      else
      {
        string str = this.txtNation.Text.ToString();
        if (!this.IsExistRoom(str))
        {
          if (this._nationalID == 0)
            this.AddNew(str);
          else
            this.Edition(str);
          this.cmbGetData();
        }
        else
        {
          int num = (int) MessageBox.Show("Quốc tịch này đã tồn tại.\n Xin vui lòng thử lại!!!");
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      this.btnAdd.Text = "Lưu";
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      this._nationalID = (int) this.comboBox1.SelectedValue;
      this.txtNation.Text = smallHotelManager.National.Single<National>((Expression<Func<National, bool>>) (d => d.NationalID == this._nationalID)).Nation;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => this.txtNation.Text = "";
  }
}
