namespace Mold_Number_Folder_Labels.Classes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lbl_search = new System.Windows.Forms.Label();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tab_by_list = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbx_copies = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbx_copies2 = new System.Windows.Forms.ComboBox();
            this.btn_print2 = new System.Windows.Forms.Button();
            this.lbl_job_number = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbx_job_input = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_by_list.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(81, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(574, 538);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(109, 53);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(755, 35);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(88, 25);
            this.lbl_search.TabIndex = 4;
            this.lbl_search.Text = "Search:";
            // 
            // tbx_search
            // 
            this.tbx_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_search.Location = new System.Drawing.Point(849, 32);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(351, 30);
            this.tbx_search.TabIndex = 5;
            this.tbx_search.TextChanged += new System.EventHandler(this.tbx_search_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(93, 30);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(135, 35);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tab_by_list
            // 
            this.tab_by_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_by_list.Controls.Add(this.tabPage1);
            this.tab_by_list.Controls.Add(this.tabPage2);
            this.tab_by_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_by_list.Location = new System.Drawing.Point(-2, 1);
            this.tab_by_list.Name = "tab_by_list";
            this.tab_by_list.SelectedIndex = 0;
            this.tab_by_list.Size = new System.Drawing.Size(1268, 665);
            this.tab_by_list.TabIndex = 9;
            this.tab_by_list.SelectedIndexChanged += new System.EventHandler(this.tab_by_list_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbx_copies);
            this.tabPage1.Controls.Add(this.tbx_search);
            this.tabPage1.Controls.Add(this.btn_print);
            this.tabPage1.Controls.Add(this.lbl_search);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_refresh);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1260, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "By List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbx_copies
            // 
            this.cbx_copies.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbx_copies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_copies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_copies.FormattingEnabled = true;
            this.cbx_copies.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbx_copies.Location = new System.Drawing.Point(484, 549);
            this.cbx_copies.Name = "cbx_copies";
            this.cbx_copies.Size = new System.Drawing.Size(68, 33);
            this.cbx_copies.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbx_copies2);
            this.tabPage2.Controls.Add(this.btn_print2);
            this.tabPage2.Controls.Add(this.lbl_job_number);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.tbx_job_input);
            this.tabPage2.Controls.Add(this.btn_search);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1260, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "By Job Number";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbx_copies2
            // 
            this.cbx_copies2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbx_copies2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_copies2.FormattingEnabled = true;
            this.cbx_copies2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbx_copies2.Location = new System.Drawing.Point(536, 530);
            this.cbx_copies2.Name = "cbx_copies2";
            this.cbx_copies2.Size = new System.Drawing.Size(82, 33);
            this.cbx_copies2.TabIndex = 6;
            // 
            // btn_print2
            // 
            this.btn_print2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_print2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print2.Location = new System.Drawing.Point(626, 525);
            this.btn_print2.Name = "btn_print2";
            this.btn_print2.Size = new System.Drawing.Size(131, 40);
            this.btn_print2.TabIndex = 5;
            this.btn_print2.Text = "PRINT";
            this.btn_print2.UseVisualStyleBackColor = true;
            this.btn_print2.Click += new System.EventHandler(this.btn_print2_Click);
            // 
            // lbl_job_number
            // 
            this.lbl_job_number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_job_number.AutoSize = true;
            this.lbl_job_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_job_number.Location = new System.Drawing.Point(621, 66);
            this.lbl_job_number.Name = "lbl_job_number";
            this.lbl_job_number.Size = new System.Drawing.Size(136, 25);
            this.lbl_job_number.TabIndex = 4;
            this.lbl_job_number.Text = "Job Number:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView2.Location = new System.Drawing.Point(85, 121);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1092, 345);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseUp);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // tbx_job_input
            // 
            this.tbx_job_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_job_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_job_input.Location = new System.Drawing.Point(794, 63);
            this.tbx_job_input.Name = "tbx_job_input";
            this.tbx_job_input.Size = new System.Drawing.Size(205, 30);
            this.tbx_job_input.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1035, 55);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(142, 46);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 664);
            this.Controls.Add(this.tab_by_list);
            this.Name = "Form1";
            this.Text = "Color Standard Folder Labels";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_by_list.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TabControl tab_by_list;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbx_copies;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_job_number;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tbx_job_input;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbx_copies2;
        private System.Windows.Forms.Button btn_print2;
    }
}

