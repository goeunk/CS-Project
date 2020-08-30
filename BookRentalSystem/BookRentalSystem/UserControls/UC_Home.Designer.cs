namespace BookRentalSystem.UserControls
{
    partial class UC_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_BottomHistory = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.dataGridView_History = new System.Windows.Forms.DataGridView();
            this.panel_Top.SuspendLayout();
            this.panel_BottomHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.lblMemberName);
            this.panel_Top.Controls.Add(this.lblHi);
            this.panel_Top.Controls.Add(this.lblRole);
            this.panel_Top.Controls.Add(this.lblWelcome);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(735, 186);
            this.panel_Top.TabIndex = 0;
            // 
            // panel_BottomHistory
            // 
            this.panel_BottomHistory.Controls.Add(this.dataGridView_History);
            this.panel_BottomHistory.Controls.Add(this.lblHistoryTitle);
            this.panel_BottomHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_BottomHistory.Location = new System.Drawing.Point(0, 192);
            this.panel_BottomHistory.Name = "panel_BottomHistory";
            this.panel_BottomHistory.Size = new System.Drawing.Size(735, 345);
            this.panel_BottomHistory.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(125, 32);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(475, 47);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Sky Library";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(500, 110);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(218, 23);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role: Member/Admin";
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(78, 123);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(41, 34);
            this.lblHi.TabIndex = 1;
            this.lblHi.Text = "Hi";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(125, 123);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(143, 34);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "Rainbow,";
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryTitle.Location = new System.Drawing.Point(40, 20);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(146, 28);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Rent History";
            // 
            // dataGridView_History
            // 
            this.dataGridView_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_History.Location = new System.Drawing.Point(28, 63);
            this.dataGridView_History.Name = "dataGridView_History";
            this.dataGridView_History.RowHeadersWidth = 51;
            this.dataGridView_History.RowTemplate.Height = 24;
            this.dataGridView_History.Size = new System.Drawing.Size(675, 250);
            this.dataGridView_History.TabIndex = 1;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_BottomHistory);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(735, 537);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_BottomHistory.ResumeLayout(false);
            this.panel_BottomHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel_BottomHistory;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.DataGridView dataGridView_History;
    }
}
