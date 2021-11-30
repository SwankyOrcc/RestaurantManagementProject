
namespace RestaurantManagementProject
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpLeft = new System.Windows.Forms.GroupBox();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grpRight = new System.Windows.Forms.GroupBox();
			this.cmdExit = new System.Windows.Forms.Button();
			this.lblStatistic = new System.Windows.Forms.Label();
			this.lvsFood = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.grpLeft.SuspendLayout();
			this.grpRight.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpLeft
			// 
			this.grpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.grpLeft.Controls.Add(this.cbbCategory);
			this.grpLeft.Controls.Add(this.txtNotes);
			this.grpLeft.Controls.Add(this.txtPrice);
			this.grpLeft.Controls.Add(this.txtUnit);
			this.grpLeft.Controls.Add(this.txtName);
			this.grpLeft.Controls.Add(this.btnDelete);
			this.grpLeft.Controls.Add(this.btnUpdate);
			this.grpLeft.Controls.Add(this.btnAdd);
			this.grpLeft.Controls.Add(this.btnClear);
			this.grpLeft.Controls.Add(this.label5);
			this.grpLeft.Controls.Add(this.label4);
			this.grpLeft.Controls.Add(this.label3);
			this.grpLeft.Controls.Add(this.label2);
			this.grpLeft.Controls.Add(this.label1);
			this.grpLeft.Location = new System.Drawing.Point(12, 12);
			this.grpLeft.Name = "grpLeft";
			this.grpLeft.Size = new System.Drawing.Size(353, 459);
			this.grpLeft.TabIndex = 0;
			this.grpLeft.TabStop = false;
			this.grpLeft.Text = "Chức năng";
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(128, 183);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(202, 21);
			this.cbbCategory.TabIndex = 3;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(128, 236);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(202, 168);
			this.txtNotes.TabIndex = 2;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(128, 141);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(202, 20);
			this.txtPrice.TabIndex = 2;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(128, 94);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(202, 20);
			this.txtUnit.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(128, 31);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(202, 20);
			this.txtName.TabIndex = 2;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnDelete.Location = new System.Drawing.Point(272, 422);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 30);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Xoá";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnUpdate.Location = new System.Drawing.Point(183, 422);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 30);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAdd.Location = new System.Drawing.Point(95, 422);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 30);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClear.Location = new System.Drawing.Point(6, 422);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 30);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Nhập lại";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(19, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ghi chú";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Loại thực phẩm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Đơn giá";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Đơn vị tính";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên thực phẩm";
			// 
			// grpRight
			// 
			this.grpRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpRight.Controls.Add(this.cmdExit);
			this.grpRight.Controls.Add(this.lblStatistic);
			this.grpRight.Controls.Add(this.lvsFood);
			this.grpRight.Location = new System.Drawing.Point(371, 12);
			this.grpRight.Name = "grpRight";
			this.grpRight.Size = new System.Drawing.Size(596, 459);
			this.grpRight.TabIndex = 1;
			this.grpRight.TabStop = false;
			this.grpRight.Text = "Danh mục thức ăn";
			// 
			// cmdExit
			// 
			this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExit.Location = new System.Drawing.Point(515, 426);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(75, 23);
			this.cmdExit.TabIndex = 4;
			this.cmdExit.Text = "Thoát";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// lblStatistic
			// 
			this.lblStatistic.AutoSize = true;
			this.lblStatistic.Location = new System.Drawing.Point(10, 434);
			this.lblStatistic.Name = "lblStatistic";
			this.lblStatistic.Size = new System.Drawing.Size(53, 13);
			this.lblStatistic.TabIndex = 1;
			this.lblStatistic.Text = "Thống kê";
			// 
			// lvsFood
			// 
			this.lvsFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvsFood.FullRowSelect = true;
			this.lvsFood.GridLines = true;
			this.lvsFood.HideSelection = false;
			this.lvsFood.Location = new System.Drawing.Point(6, 19);
			this.lvsFood.MultiSelect = false;
			this.lvsFood.Name = "lvsFood";
			this.lvsFood.Size = new System.Drawing.Size(584, 401);
			this.lvsFood.TabIndex = 0;
			this.lvsFood.UseCompatibleStateImageBehavior = false;
			this.lvsFood.View = System.Windows.Forms.View.Details;
			this.lvsFood.Click += new System.EventHandler(this.lvsFood_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 76;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên thực phẩm";
			this.columnHeader2.Width = 123;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "ĐVT";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giá";
			this.columnHeader4.Width = 86;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Loại thực phẩm";
			this.columnHeader5.Width = 102;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Ghi chú";
			this.columnHeader6.Width = 132;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(979, 483);
			this.Controls.Add(this.grpRight);
			this.Controls.Add(this.grpLeft);
			this.Name = "Form1";
			this.Text = "Thêm Xoá Sửa Bảng Food";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.grpLeft.ResumeLayout(false);
			this.grpLeft.PerformLayout();
			this.grpRight.ResumeLayout(false);
			this.grpRight.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpLeft;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpRight;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Label lblStatistic;
		private System.Windows.Forms.ListView lvsFood;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}

