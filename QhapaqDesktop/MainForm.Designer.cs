namespace QhapaqDesktop {
  partial class MainForm {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.menuList = new MetroFramework.Controls.MetroListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.loginButton = new MetroFramework.Controls.MetroButton();
      this.usernameLabel = new MetroFramework.Controls.MetroLabel();
      this.menuGrid = new MetroFramework.Controls.MetroGrid();
      this.columnIngredientsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnIngredientsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnIngredientsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnIngredientsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.Location = new System.Drawing.Point(8, 64);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.menuList);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.menuGrid);
      this.splitContainer1.Size = new System.Drawing.Size(826, 321);
      this.splitContainer1.SplitterDistance = 274;
      this.splitContainer1.SplitterWidth = 2;
      this.splitContainer1.TabIndex = 3;
      // 
      // menuList
      // 
      this.menuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.menuList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.menuList.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.menuList.FullRowSelect = true;
      listViewGroup1.Header = "ListViewGroup";
      listViewGroup1.Name = "listViewGroup1";
      listViewGroup2.Header = "ListViewGroup";
      listViewGroup2.Name = "listViewGroup2";
      this.menuList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
      this.menuList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
      this.menuList.Location = new System.Drawing.Point(0, 0);
      this.menuList.Name = "menuList";
      this.menuList.OwnerDraw = true;
      this.menuList.Size = new System.Drawing.Size(274, 321);
      this.menuList.TabIndex = 0;
      this.menuList.UseCompatibleStateImageBehavior = false;
      this.menuList.UseSelectable = true;
      this.menuList.View = System.Windows.Forms.View.List;
      // 
      // loginButton
      // 
      this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.loginButton.Location = new System.Drawing.Point(759, 25);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(75, 23);
      this.loginButton.TabIndex = 5;
      this.loginButton.Text = "ログイン";
      this.loginButton.UseSelectable = true;
      this.loginButton.Click += new System.EventHandler(this.metroButton1_Click);
      // 
      // usernameLabel
      // 
      this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.usernameLabel.AutoSize = true;
      this.usernameLabel.Location = new System.Drawing.Point(625, 29);
      this.usernameLabel.Name = "usernameLabel";
      this.usernameLabel.Size = new System.Drawing.Size(128, 19);
      this.usernameLabel.TabIndex = 6;
      this.usernameLabel.Text = "ログインされていません";
      this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // menuGrid
      // 
      this.menuGrid.AllowUserToAddRows = false;
      this.menuGrid.AllowUserToDeleteRows = false;
      this.menuGrid.AllowUserToOrderColumns = true;
      this.menuGrid.AllowUserToResizeRows = false;
      this.menuGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.menuGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.menuGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.menuGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.menuGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.menuGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.menuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.menuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIngredientsName,
            this.columnIngredientsQuantity,
            this.columnIngredientsCost,
            this.columnIngredientsDescription});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.menuGrid.DefaultCellStyle = dataGridViewCellStyle2;
      this.menuGrid.EnableHeadersVisualStyles = false;
      this.menuGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.menuGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.menuGrid.Location = new System.Drawing.Point(5, 4);
      this.menuGrid.Name = "menuGrid";
      this.menuGrid.ReadOnly = true;
      this.menuGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.menuGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.menuGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.menuGrid.RowTemplate.Height = 21;
      this.menuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.menuGrid.Size = new System.Drawing.Size(542, 255);
      this.menuGrid.TabIndex = 0;
      // 
      // columnIngredientsName
      // 
      this.columnIngredientsName.HeaderText = "材料名";
      this.columnIngredientsName.Name = "columnIngredientsName";
      this.columnIngredientsName.ReadOnly = true;
      this.columnIngredientsName.ToolTipText = "調理に必要な材料の名前";
      // 
      // columnIngredientsQuantity
      // 
      this.columnIngredientsQuantity.HeaderText = "分量/人";
      this.columnIngredientsQuantity.Name = "columnIngredientsQuantity";
      this.columnIngredientsQuantity.ReadOnly = true;
      this.columnIngredientsQuantity.ToolTipText = "調理で１人あたりに必要な材料の分量";
      // 
      // columnIngredientsCost
      // 
      this.columnIngredientsCost.HeaderText = "費用/人";
      this.columnIngredientsCost.Name = "columnIngredientsCost";
      this.columnIngredientsCost.ReadOnly = true;
      this.columnIngredientsCost.ToolTipText = "調理で１人あたりに必要な材料の費用";
      // 
      // columnIngredientsDescription
      // 
      this.columnIngredientsDescription.HeaderText = "説明";
      this.columnIngredientsDescription.Name = "columnIngredientsDescription";
      this.columnIngredientsDescription.ReadOnly = true;
      this.columnIngredientsDescription.ToolTipText = "調理方法や調理における注意など";
      this.columnIngredientsDescription.Width = 200;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(848, 400);
      this.Controls.Add(this.usernameLabel);
      this.Controls.Add(this.loginButton);
      this.Controls.Add(this.splitContainer1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(12, 60, 12, 13);
      this.Text = "Qhapaq";
      this.Load += new System.EventHandler(this.MailForm_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private MetroFramework.Controls.MetroListView menuList;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private MetroFramework.Controls.MetroButton loginButton;
    private MetroFramework.Controls.MetroLabel usernameLabel;
    private MetroFramework.Controls.MetroGrid menuGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientsName;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientsQuantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientsCost;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientsDescription;
  }
}

