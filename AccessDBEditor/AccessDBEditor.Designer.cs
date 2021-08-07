
namespace DBWinFormDemo1
{
    partial class AccessDBEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessDBEditor));
            this.filepath_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browse_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.table_listview = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.table_gridview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.table_name_tb = new System.Windows.Forms.TextBox();
            this.create_table_btn = new System.Windows.Forms.Button();
            this.open_table_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.del_table_btn = new System.Windows.Forms.Button();
            this.add_col_btn = new System.Windows.Forms.Button();
            this.del_col_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.column_name_tb = new System.Windows.Forms.TextBox();
            this.tablegridview_refresh_btn = new System.Windows.Forms.Button();
            this.col_type_listview = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.table_gridview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filepath_tb
            // 
            this.filepath_tb.Enabled = false;
            this.filepath_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filepath_tb.Location = new System.Drawing.Point(101, 32);
            this.filepath_tb.Name = "filepath_tb";
            this.filepath_tb.Size = new System.Drawing.Size(865, 26);
            this.filepath_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB File:";
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(972, 33);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(77, 26);
            this.browse_btn.TabIndex = 2;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.Enabled = false;
            this.open_btn.Location = new System.Drawing.Point(1055, 33);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(77, 26);
            this.open_btn.TabIndex = 2;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Enabled = false;
            this.close_btn.Location = new System.Drawing.Point(1138, 33);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(80, 26);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // table_listview
            // 
            this.table_listview.Enabled = false;
            this.table_listview.HideSelection = false;
            this.table_listview.Location = new System.Drawing.Point(28, 89);
            this.table_listview.Name = "table_listview";
            this.table_listview.Size = new System.Drawing.Size(314, 208);
            this.table_listview.TabIndex = 4;
            this.table_listview.UseCompatibleStateImageBehavior = false;
            this.table_listview.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tables in file:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(254, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table_gridview
            // 
            this.table_gridview.AllowUserToOrderColumns = true;
            this.table_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_gridview.Enabled = false;
            this.table_gridview.Location = new System.Drawing.Point(589, 89);
            this.table_gridview.Name = "table_gridview";
            this.table_gridview.RowHeadersWidth = 51;
            this.table_gridview.RowTemplate.Height = 24;
            this.table_gridview.Size = new System.Drawing.Size(629, 208);
            this.table_gridview.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Table Name:";
            // 
            // table_name_tb
            // 
            this.table_name_tb.Enabled = false;
            this.table_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_name_tb.Location = new System.Drawing.Point(382, 111);
            this.table_name_tb.Name = "table_name_tb";
            this.table_name_tb.Size = new System.Drawing.Size(158, 24);
            this.table_name_tb.TabIndex = 9;
            // 
            // create_table_btn
            // 
            this.create_table_btn.Enabled = false;
            this.create_table_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_table_btn.Location = new System.Drawing.Point(382, 142);
            this.create_table_btn.Name = "create_table_btn";
            this.create_table_btn.Size = new System.Drawing.Size(158, 30);
            this.create_table_btn.TabIndex = 10;
            this.create_table_btn.Text = "Create Empty Table";
            this.create_table_btn.UseVisualStyleBackColor = true;
            this.create_table_btn.Click += new System.EventHandler(this.create_table_btn_Click);
            // 
            // open_table_btn
            // 
            this.open_table_btn.Enabled = false;
            this.open_table_btn.Location = new System.Drawing.Point(401, 205);
            this.open_table_btn.Name = "open_table_btn";
            this.open_table_btn.Size = new System.Drawing.Size(117, 34);
            this.open_table_btn.TabIndex = 11;
            this.open_table_btn.Text = "Open Table";
            this.open_table_btn.UseVisualStyleBackColor = true;
            this.open_table_btn.Click += new System.EventHandler(this.open_table_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "→";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "→";
            // 
            // del_table_btn
            // 
            this.del_table_btn.Enabled = false;
            this.del_table_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_table_btn.Location = new System.Drawing.Point(28, 304);
            this.del_table_btn.Name = "del_table_btn";
            this.del_table_btn.Size = new System.Drawing.Size(90, 37);
            this.del_table_btn.TabIndex = 13;
            this.del_table_btn.Text = "Delete";
            this.del_table_btn.UseVisualStyleBackColor = true;
            this.del_table_btn.Click += new System.EventHandler(this.del_table_btn_Click);
            // 
            // add_col_btn
            // 
            this.add_col_btn.Enabled = false;
            this.add_col_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_col_btn.Location = new System.Drawing.Point(587, 356);
            this.add_col_btn.Name = "add_col_btn";
            this.add_col_btn.Size = new System.Drawing.Size(101, 39);
            this.add_col_btn.TabIndex = 14;
            this.add_col_btn.Text = "Add";
            this.add_col_btn.UseVisualStyleBackColor = true;
            this.add_col_btn.Click += new System.EventHandler(this.add_col_btn_Click);
            // 
            // del_col_btn
            // 
            this.del_col_btn.Enabled = false;
            this.del_col_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_col_btn.Location = new System.Drawing.Point(737, 356);
            this.del_col_btn.Name = "del_col_btn";
            this.del_col_btn.Size = new System.Drawing.Size(101, 39);
            this.del_col_btn.TabIndex = 15;
            this.del_col_btn.Text = "Delete";
            this.del_col_btn.UseVisualStyleBackColor = true;
            this.del_col_btn.Click += new System.EventHandler(this.del_col_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Column Name:";
            // 
            // column_name_tb
            // 
            this.column_name_tb.Enabled = false;
            this.column_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column_name_tb.Location = new System.Drawing.Point(700, 309);
            this.column_name_tb.Name = "column_name_tb";
            this.column_name_tb.Size = new System.Drawing.Size(138, 26);
            this.column_name_tb.TabIndex = 17;
            // 
            // tablegridview_refresh_btn
            // 
            this.tablegridview_refresh_btn.Enabled = false;
            this.tablegridview_refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablegridview_refresh_btn.Location = new System.Drawing.Point(1117, 304);
            this.tablegridview_refresh_btn.Name = "tablegridview_refresh_btn";
            this.tablegridview_refresh_btn.Size = new System.Drawing.Size(101, 39);
            this.tablegridview_refresh_btn.TabIndex = 18;
            this.tablegridview_refresh_btn.Text = "Refresh";
            this.tablegridview_refresh_btn.UseVisualStyleBackColor = true;
            this.tablegridview_refresh_btn.Click += new System.EventHandler(this.tablegridview_refresh_btn_Click);
            // 
            // col_type_listview
            // 
            this.col_type_listview.Enabled = false;
            this.col_type_listview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_type_listview.HideSelection = false;
            this.col_type_listview.Location = new System.Drawing.Point(883, 330);
            this.col_type_listview.Name = "col_type_listview";
            this.col_type_listview.Size = new System.Drawing.Size(198, 72);
            this.col_type_listview.TabIndex = 19;
            this.col_type_listview.UseCompatibleStateImageBehavior = false;
            this.col_type_listview.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(880, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Select Column Type :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // AccessDBEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 420);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filepath_tb);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table_listview);
            this.Controls.Add(this.del_table_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.table_name_tb);
            this.Controls.Add(this.create_table_btn);
            this.Controls.Add(this.open_table_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.column_name_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.col_type_listview);
            this.Controls.Add(this.add_col_btn);
            this.Controls.Add(this.del_col_btn);
            this.Controls.Add(this.table_gridview);
            this.Controls.Add(this.tablegridview_refresh_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessDBEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessDBEditor";
            ((System.ComponentModel.ISupportInitialize)(this.table_gridview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filepath_tb;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView table_listview;
        private System.Windows.Forms.Button del_table_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox table_name_tb;
        private System.Windows.Forms.Button create_table_btn;
        private System.Windows.Forms.Button open_table_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox column_name_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView col_type_listview;
        private System.Windows.Forms.Button add_col_btn;
        private System.Windows.Forms.Button del_col_btn;
        private System.Windows.Forms.DataGridView table_gridview;
        private System.Windows.Forms.Button tablegridview_refresh_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

