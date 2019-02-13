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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.loginButton = new MetroFramework.Controls.MetroButton();
      this.usernameLabel = new MetroFramework.Controls.MetroLabel();
      this.menuGrid = new MetroFramework.Controls.MetroGrid();
      this.columnIngredientsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnIngredientsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnIngredientsCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnIngredientsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuTree = new System.Windows.Forms.TreeView();
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
      this.splitContainer1.Panel1.Controls.Add(this.menuTree);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.menuGrid);
      this.splitContainer1.Size = new System.Drawing.Size(826, 321);
      this.splitContainer1.SplitterDistance = 274;
      this.splitContainer1.SplitterWidth = 2;
      this.splitContainer1.TabIndex = 3;
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
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
      dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.menuGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
      this.menuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.menuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIngredientsName,
            this.columnIngredientsQuantity,
            this.columnIngredientsCost,
            this.columnIngredientsDescription});
      dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.menuGrid.DefaultCellStyle = dataGridViewCellStyle20;
      this.menuGrid.EnableHeadersVisualStyles = false;
      this.menuGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.menuGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.menuGrid.Location = new System.Drawing.Point(5, 4);
      this.menuGrid.Name = "menuGrid";
      this.menuGrid.ReadOnly = true;
      this.menuGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
      dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.menuGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
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
      // menuTree
      // 
      this.menuTree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.menuTree.Location = new System.Drawing.Point(0, 0);
      this.menuTree.Name = "menuTree";
      this.menuTree.Size = new System.Drawing.Size(274, 321);
      this.menuTree.TabIndex = 1;
      this.menuTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menuTree_AfterSelect);
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
    private MetroFramework.Controls.MetroButton loginButton;
    private MetroFramework.Controls.MetroLabel usernameLabel;
    private MetroFramework.Controls.MetroGrid menuGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientsName;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientsQuantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientsCost;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIngredientsDescription;
    private System.Windows.Forms.TreeView menuTree;
  }
}

