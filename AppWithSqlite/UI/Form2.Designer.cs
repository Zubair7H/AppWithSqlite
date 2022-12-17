namespace AppWithSqlite
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mailbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CaddressTextBox = new System.Windows.Forms.TextBox();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sallary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CSaveButton = new System.Windows.Forms.Button();
            this.CnumberTextBox = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.numberlbl = new System.Windows.Forms.Label();
            this.CnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(148, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(252, 34);
            label4.TabIndex = 1;
            label4.Text = "Building Materials";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 87);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(918, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mailbutton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CaddressTextBox);
            this.groupBox1.Controls.Add(this.Addresslbl);
            this.groupBox1.Controls.Add(this.customerDataGridView);
            this.groupBox1.Controls.Add(this.CSaveButton);
            this.groupBox1.Controls.Add(this.CnumberTextBox);
            this.groupBox1.Controls.Add(this.emaillbl);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.numberlbl);
            this.groupBox1.Controls.Add(this.CnameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(-1, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 451);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // Mailbutton
            // 
            this.Mailbutton.BackColor = System.Drawing.Color.Gold;
            this.Mailbutton.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Mailbutton.ForeColor = System.Drawing.Color.White;
            this.Mailbutton.Location = new System.Drawing.Point(573, 65);
            this.Mailbutton.Name = "Mailbutton";
            this.Mailbutton.Size = new System.Drawing.Size(94, 31);
            this.Mailbutton.TabIndex = 10;
            this.Mailbutton.Text = "Mail";
            this.Mailbutton.UseVisualStyleBackColor = false;
            this.Mailbutton.Click += new System.EventHandler(this.Mailbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(556, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mail Customer";
            // 
            // CaddressTextBox
            // 
            this.CaddressTextBox.Location = new System.Drawing.Point(108, 184);
            this.CaddressTextBox.Name = "CaddressTextBox";
            this.CaddressTextBox.Size = new System.Drawing.Size(269, 26);
            this.CaddressTextBox.TabIndex = 9;
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Location = new System.Drawing.Point(31, 192);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(73, 18);
            this.Addresslbl.TabIndex = 8;
            this.Addresslbl.Text = "Address";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Number,
            this.Sallary,
            this.Caddress});
            this.customerDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.customerDataGridView.Location = new System.Drawing.Point(148, 216);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 29;
            this.customerDataGridView.Size = new System.Drawing.Size(646, 228);
            this.customerDataGridView.TabIndex = 7;
            this.customerDataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDataGridView_RowHeaderMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "CustomerID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Name
            // 
            this.Name.HeaderText = "Cname";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Number
            // 
            this.Number.HeaderText = "Email";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // Sallary
            // 
            this.Sallary.HeaderText = "Cnumber";
            this.Sallary.MinimumWidth = 6;
            this.Sallary.Name = "Sallary";
            // 
            // Caddress
            // 
            this.Caddress.HeaderText = "Caddress";
            this.Caddress.MinimumWidth = 6;
            this.Caddress.Name = "Caddress";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // CSaveButton
            // 
            this.CSaveButton.BackColor = System.Drawing.Color.Gold;
            this.CSaveButton.Location = new System.Drawing.Point(31, 230);
            this.CSaveButton.Name = "CSaveButton";
            this.CSaveButton.Size = new System.Drawing.Size(94, 29);
            this.CSaveButton.TabIndex = 6;
            this.CSaveButton.Text = "Save";
            this.CSaveButton.UseVisualStyleBackColor = false;
            this.CSaveButton.Click += new System.EventHandler(this.CSaveButton_Click);
            // 
            // CnumberTextBox
            // 
            this.CnumberTextBox.Location = new System.Drawing.Point(108, 140);
            this.CnumberTextBox.Name = "CnumberTextBox";
            this.CnumberTextBox.Size = new System.Drawing.Size(269, 26);
            this.CnumberTextBox.TabIndex = 5;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(31, 97);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(55, 18);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(108, 89);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(269, 26);
            this.EmailTextBox.TabIndex = 3;
            // 
            // numberlbl
            // 
            this.numberlbl.AutoSize = true;
            this.numberlbl.Location = new System.Drawing.Point(31, 143);
            this.numberlbl.Name = "numberlbl";
            this.numberlbl.Size = new System.Drawing.Size(71, 18);
            this.numberlbl.TabIndex = 2;
            this.numberlbl.Text = "Number";
            // 
            // CnameTextBox
            // 
            this.CnameTextBox.Location = new System.Drawing.Point(108, 44);
            this.CnameTextBox.Name = "CnameTextBox";
            this.CnameTextBox.Size = new System.Drawing.Size(269, 26);
            this.CnameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(-1, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 59);
            this.panel2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox CaddressTextBox;
        private Label Addresslbl;
        private DataGridView customerDataGridView;
        private Button CSaveButton;
        private TextBox CnumberTextBox;
        private Label emaillbl;
        private TextBox EmailTextBox;
        private Label numberlbl;
        private TextBox CnameTextBox;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private new DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Sallary;
        private DataGridViewTextBoxColumn Caddress;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panel2;
        private Button Mailbutton;
        private Label label2;
        public PictureBox pictureBox2;
    }
}