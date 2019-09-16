namespace ManageIT.MedShop.Start
{
    partial class AdminFrame
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menustripAdmin = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.dailyPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newParchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menustripAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDisplay, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.49451F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.50549F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLogout, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.menustripAdmin, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1184, 36);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Image = global::ManageIT.MedShop.Properties.Resources.med24x24;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(452, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "    Shohan Pharmacy";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(789, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome : Md Babul Sardar Badol";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Tomato;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLogout.Location = new System.Drawing.Point(1082, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.BtnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.BtnLogout_MouseLeave);
            // 
            // menustripAdmin
            // 
            this.menustripAdmin.BackColor = System.Drawing.Color.Coral;
            this.menustripAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menustripAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menustripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.purchesToolStripMenuItem,
            this.employToolStripMenuItem,
            this.sellsToolStripMenuItem});
            this.menustripAdmin.Location = new System.Drawing.Point(0, 0);
            this.menustripAdmin.Name = "menustripAdmin";
            this.menustripAdmin.Size = new System.Drawing.Size(347, 36);
            this.menustripAdmin.TabIndex = 5;
            this.menustripAdmin.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // purchesToolStripMenuItem
            // 
            this.purchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyPurchaseToolStripMenuItem,
            this.newParchesToolStripMenuItem});
            this.purchesToolStripMenuItem.Name = "purchesToolStripMenuItem";
            this.purchesToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.purchesToolStripMenuItem.Text = "Purches";
            // 
            // employToolStripMenuItem
            // 
            this.employToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.employesToolStripMenuItem});
            this.employToolStripMenuItem.Name = "employToolStripMenuItem";
            this.employToolStripMenuItem.Size = new System.Drawing.Size(90, 32);
            this.employToolStripMenuItem.Text = "Employ";
            // 
            // sellsToolStripMenuItem
            // 
            this.sellsToolStripMenuItem.Name = "sellsToolStripMenuItem";
            this.sellsToolStripMenuItem.Size = new System.Drawing.Size(63, 32);
            this.sellsToolStripMenuItem.Text = "Sells";
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(0, 36);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1184, 625);
            this.pnlDisplay.TabIndex = 2;
            // 
            // dailyPurchaseToolStripMenuItem
            // 
            this.dailyPurchaseToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.dailyPurchaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.dailyPurchaseToolStripMenuItem.Name = "dailyPurchaseToolStripMenuItem";
            this.dailyPurchaseToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.dailyPurchaseToolStripMenuItem.Text = "Daily Purchase";
            this.dailyPurchaseToolStripMenuItem.Click += new System.EventHandler(this.DailyPurchaseToolStripMenuItem_Click);
            // 
            // newParchesToolStripMenuItem
            // 
            this.newParchesToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.newParchesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.newParchesToolStripMenuItem.Name = "newParchesToolStripMenuItem";
            this.newParchesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.newParchesToolStripMenuItem.Text = "New Parches";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.addNewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // employesToolStripMenuItem
            // 
            this.employesToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.employesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.employesToolStripMenuItem.Name = "employesToolStripMenuItem";
            this.employesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.employesToolStripMenuItem.Text = "Employes";
            // 
            // AdminFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menustripAdmin;
            this.Name = "AdminFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFrame";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menustripAdmin.ResumeLayout(false);
            this.menustripAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.MenuStrip menustripAdmin;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.ToolStripMenuItem dailyPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newParchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employesToolStripMenuItem;
    }
}