// Decompiled with JetBrains decompiler
// Type: SmallHotelManager.UserManager
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
  public class UserManager : Form
  {
    private Main _parent;
    private EditUser rtp = (EditUser) null;
    private IContainer components = (IContainer) null;
    private GroupBox groupBox2;
    private DataGridView grvUserManager;
    private GroupBox groupBox1;
    private ComboBox cmbGroup;
    private Label label2;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn StatusID;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private Button btnCancel;
    private Button btnDel;
    private Button btnEdit;
    private Button btnAdd;

    public UserManager(Main parent)
    {
      this._parent = parent;
      this.InitializeComponent();
      this.cmbGetData();
      this.GrvGetData();
    }

    public void FormRefresh() => this.GrvGetData();

    private void cmbGetData()
    {
      this.cmbGroup.DataSource = (object) new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;").GroupUser.Select(g => new
      {
        GroupID = g.GroupID,
        GroupName = g.GroupName
      });
      this.cmbGroup.DisplayMember = "GroupName";
      this.cmbGroup.ValueMember = "GroupID";
    }

    private void GrvGetData()
    {
      SmallHotelManager.SmallHotelManager db = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      int group = (int) this.cmbGroup.SelectedValue;
      IQueryable<\u003C\u003Ef__AnonymousType38<int, string, string, string, string, int, string>> source = db.Users.SelectMany((Expression<Func<Users, IEnumerable<GroupUser>>>) (u => db.GroupUser), (u, g) => new
      {
        u = u,
        g = g
      }).Where(data => data.u.GroupID == data.g.GroupID && data.g.GroupID > 1 && data.u.DelIDUs == new int?() && data.u.UserID > 1).Select(data => new
      {
        UserID = data.u.UserID,
        UserName = data.u.UserName,
        Name = data.u.Name,
        IDNumber = data.u.IDNumber,
        PhoneNumber = data.u.PhoneNumber,
        GroupID = data.u.GroupID,
        GroupName = data.g.GroupName
      });
      if (group > 1)
        source = source.AsQueryable().Where(u => u.GroupID == group);
      this.grvUserManager.DataSource = (object) source;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      int num = (int) new AddNewUser(this).ShowDialog();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (this.rtp != null && !this.rtp.IsDisposed || this.grvUserManager.RowCount <= 0)
        return;
      int num1 = int.Parse(this.grvUserManager.Rows[this.grvUserManager.CurrentCell.RowIndex].Cells[0].Value.ToString());
      this.rtp = new EditUser(this);
      this.rtp.MdiParent = this.MdiParent;
      this.rtp.UserID = num1;
      int num2 = (int) this.rtp.ShowDialog();
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
      if (this.grvUserManager.RowCount <= 0)
        return;
      int userID = int.Parse(this.grvUserManager.Rows[this.grvUserManager.CurrentCell.RowIndex].Cells[0].Value.ToString());
      if (userID != 1)
      {
        if (MessageBox.Show("Bạn có chắc muốn xóa User này?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
        {
          int delID = 1;
          this.Edition(userID, delID);
          this.FormRefresh();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Không được phép xóa tài khoản [admin]");
      }
    }

    private void Edition(int userID, int delID)
    {
      SmallHotelManager.SmallHotelManager smallHotelManager = new SmallHotelManager.SmallHotelManager("Data Source = |DataDirectory|\\SmallHotelManager.sdf; Password=Ducthuan3008;");
      delID = 1;
      userID = int.Parse(this.grvUserManager.Rows[this.grvUserManager.CurrentCell.RowIndex].Cells[0].Value.ToString());
      try
      {
        smallHotelManager.Users.Single<Users>((Expression<Func<Users, bool>>) (p => p.UserID == userID)).DelIDUs = new int?(delID);
        smallHotelManager.SubmitChanges();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void UserManager_FormClosing(object sender, FormClosingEventArgs e)
    {
      this._parent.PerformRefresh();
      this.Dispose();
    }

    private void cmbGroup_SelectionChangeCommitted(object sender, EventArgs e) => this.GrvGetData();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserManager));
      this.groupBox2 = new GroupBox();
      this.grvUserManager = new DataGridView();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.Column6 = new DataGridViewTextBoxColumn();
      this.StatusID = new DataGridViewTextBoxColumn();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.groupBox1 = new GroupBox();
      this.cmbGroup = new ComboBox();
      this.label2 = new Label();
      this.btnCancel = new Button();
      this.btnDel = new Button();
      this.btnEdit = new Button();
      this.btnAdd = new Button();
      this.groupBox2.SuspendLayout();
      ((ISupportInitialize) this.grvUserManager).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox2.Controls.Add((Control) this.grvUserManager);
      this.groupBox2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.Location = new Point(12, 64);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(662, 318);
      this.groupBox2.TabIndex = 15;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Danh sách người dùng";
      this.grvUserManager.AllowUserToAddRows = false;
      this.grvUserManager.AllowUserToDeleteRows = false;
      this.grvUserManager.BackgroundColor = SystemColors.ControlLightLight;
      this.grvUserManager.BorderStyle = BorderStyle.Fixed3D;
      this.grvUserManager.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
      this.grvUserManager.ColumnHeadersHeight = 30;
      this.grvUserManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.grvUserManager.Columns.AddRange((DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.StatusID, (DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3);
      this.grvUserManager.Dock = DockStyle.Fill;
      this.grvUserManager.Location = new Point(3, 18);
      this.grvUserManager.Name = "grvUserManager";
      this.grvUserManager.ReadOnly = true;
      this.grvUserManager.RowHeadersVisible = false;
      this.grvUserManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.grvUserManager.Size = new Size(656, 297);
      this.grvUserManager.TabIndex = 1;
      this.Column4.DataPropertyName = "UserID";
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column4.DefaultCellStyle = gridViewCellStyle1;
      this.Column4.HeaderText = "UserID";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Visible = false;
      this.Column6.DataPropertyName = "GroupID";
      this.Column6.HeaderText = "GroupID";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column6.Visible = false;
      this.StatusID.DataPropertyName = "UserName";
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.StatusID.DefaultCellStyle = gridViewCellStyle2;
      this.StatusID.HeaderText = "Tài khoản";
      this.StatusID.Name = "StatusID";
      this.StatusID.ReadOnly = true;
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column1.DataPropertyName = "Name";
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column1.DefaultCellStyle = gridViewCellStyle3;
      this.Column1.HeaderText = "Tên";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column5.DataPropertyName = "IDNumber";
      this.Column5.HeaderText = "Số CMTND";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column2.DataPropertyName = "PhoneNumber";
      gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column2.DefaultCellStyle = gridViewCellStyle4;
      this.Column2.HeaderText = "Số điện thoại";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      this.Column3.DataPropertyName = "GroupName";
      gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Column3.DefaultCellStyle = gridViewCellStyle5;
      this.Column3.HeaderText = "Nhóm";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.groupBox1.Controls.Add((Control) this.cmbGroup);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(662, 49);
      this.groupBox1.TabIndex = 16;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Hiển thị theo";
      this.cmbGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbGroup.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cmbGroup.FormattingEnabled = true;
      this.cmbGroup.Location = new Point(75, 16);
      this.cmbGroup.Name = "cmbGroup";
      this.cmbGroup.Size = new Size(153, 28);
      this.cmbGroup.TabIndex = 12;
      this.cmbGroup.SelectionChangeCommitted += new EventHandler(this.cmbGroup_SelectionChangeCommitted);
      this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(11, 19);
      this.label2.Name = "label2";
      this.label2.Size = new Size(55, 20);
      this.label2.TabIndex = 11;
      this.label2.Text = "Nhóm";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnCancel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Location = new Point(559, 388);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(108, 40);
      this.btnCancel.TabIndex = 20;
      this.btnCancel.Text = "Thoát";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnDel.BackColor = SystemColors.GradientInactiveCaption;
      this.btnDel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnDel.Location = new Point(246, 389);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new Size(108, 40);
      this.btnDel.TabIndex = 19;
      this.btnDel.Text = "Xóa";
      this.btnDel.UseVisualStyleBackColor = false;
      this.btnDel.Click += new EventHandler(this.btnDel_Click);
      this.btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnEdit.BackColor = SystemColors.GradientInactiveCaption;
      this.btnEdit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnEdit.Location = new Point(132, 389);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new Size(108, 40);
      this.btnEdit.TabIndex = 18;
      this.btnEdit.Text = "Chỉnh sửa";
      this.btnEdit.UseVisualStyleBackColor = false;
      this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
      this.btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.btnAdd.BackColor = SystemColors.GradientInactiveCaption;
      this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnAdd.Location = new Point(18, 389);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new Size(108, 40);
      this.btnAdd.TabIndex = 17;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(687, 441);
      this.Controls.Add((Control) this.btnCancel);
      this.Controls.Add((Control) this.btnDel);
      this.Controls.Add((Control) this.btnEdit);
      this.Controls.Add((Control) this.btnAdd);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.groupBox2);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MaximumSize = new Size(703, 479);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(703, 479);
      this.Name = nameof (UserManager);
      this.Text = "Quản lý người dùng";
      this.FormClosing += new FormClosingEventHandler(this.UserManager_FormClosing);
      this.groupBox2.ResumeLayout(false);
      ((ISupportInitialize) this.grvUserManager).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
