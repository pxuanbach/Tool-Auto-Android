
namespace AutoLDWinform
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbBdevicesID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumImages = new System.Windows.Forms.Label();
            this.btB = new System.Windows.Forms.Button();
            this.btMvL = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.dvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExit = new System.Windows.Forms.Button();
            this.linklbInfor = new System.Windows.Forms.LinkLabel();
            this.grStartButton = new System.Windows.Forms.GroupBox();
            this.btReloadImage = new System.Windows.Forms.Button();
            this.btDeleteRow = new System.Windows.Forms.Button();
            this.btAddID = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.grDatatable = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.grStartButton.SuspendLayout();
            this.grDatatable.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBdevicesID
            // 
            this.cbBdevicesID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBdevicesID.BackColor = System.Drawing.Color.White;
            this.cbBdevicesID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBdevicesID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBdevicesID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBdevicesID.ForeColor = System.Drawing.Color.Black;
            this.cbBdevicesID.FormattingEnabled = true;
            this.cbBdevicesID.Location = new System.Drawing.Point(12, 32);
            this.cbBdevicesID.Name = "cbBdevicesID";
            this.cbBdevicesID.Size = new System.Drawing.Size(181, 28);
            this.cbBdevicesID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List devices:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(314, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Images to check:";
            // 
            // lbNumImages
            // 
            this.lbNumImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumImages.AutoSize = true;
            this.lbNumImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNumImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumImages.ForeColor = System.Drawing.Color.Black;
            this.lbNumImages.Location = new System.Drawing.Point(444, 5);
            this.lbNumImages.Name = "lbNumImages";
            this.lbNumImages.Size = new System.Drawing.Size(18, 20);
            this.lbNumImages.TabIndex = 4;
            this.lbNumImages.Text = "0";
            // 
            // btB
            // 
            this.btB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btB.ForeColor = System.Drawing.Color.White;
            this.btB.Location = new System.Drawing.Point(5, 26);
            this.btB.Name = "btB";
            this.btB.Size = new System.Drawing.Size(114, 47);
            this.btB.TabIndex = 7;
            this.btB.Text = "B Program";
            this.btB.UseVisualStyleBackColor = false;
            this.btB.Click += new System.EventHandler(this.btB_Click);
            // 
            // btMvL
            // 
            this.btMvL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btMvL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMvL.ForeColor = System.Drawing.Color.Black;
            this.btMvL.Location = new System.Drawing.Point(5, 88);
            this.btMvL.Name = "btMvL";
            this.btMvL.Size = new System.Drawing.Size(114, 47);
            this.btMvL.TabIndex = 8;
            this.btMvL.Text = "MvL Prod";
            this.btMvL.UseVisualStyleBackColor = false;
            this.btMvL.Click += new System.EventHandler(this.btMvL_Click);
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvID,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV.Location = new System.Drawing.Point(6, 26);
            this.dGV.Name = "dGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV.RowHeadersVisible = false;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(335, 185);
            this.dGV.TabIndex = 10;
            // 
            // dvID
            // 
            this.dvID.DataPropertyName = "deviceID";
            this.dvID.HeaderText = "Device ID";
            this.dvID.MinimumWidth = 6;
            this.dvID.Name = "dvID";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(354, 257);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(110, 47);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // linklbInfor
            // 
            this.linklbInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linklbInfor.AutoSize = true;
            this.linklbInfor.Location = new System.Drawing.Point(10, 290);
            this.linklbInfor.Name = "linklbInfor";
            this.linklbInfor.Size = new System.Drawing.Size(126, 17);
            this.linklbInfor.TabIndex = 12;
            this.linklbInfor.TabStop = true;
            this.linklbInfor.Text = "Dev by Pxuanbach";
            this.linklbInfor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbInfor_LinkClicked);
            // 
            // grStartButton
            // 
            this.grStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grStartButton.Controls.Add(this.btMvL);
            this.grStartButton.Controls.Add(this.btB);
            this.grStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grStartButton.ForeColor = System.Drawing.Color.Black;
            this.grStartButton.Location = new System.Drawing.Point(354, 70);
            this.grStartButton.Name = "grStartButton";
            this.grStartButton.Size = new System.Drawing.Size(125, 155);
            this.grStartButton.TabIndex = 15;
            this.grStartButton.TabStop = false;
            this.grStartButton.Text = "Start auto";
            // 
            // btReloadImage
            // 
            this.btReloadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReloadImage.BackColor = System.Drawing.Color.White;
            this.btReloadImage.ForeColor = System.Drawing.Color.Black;
            this.btReloadImage.Image = global::AutoLDWinform.Properties.Resources.reload;
            this.btReloadImage.Location = new System.Drawing.Point(423, 28);
            this.btReloadImage.Name = "btReloadImage";
            this.btReloadImage.Size = new System.Drawing.Size(41, 32);
            this.btReloadImage.TabIndex = 14;
            this.btReloadImage.UseVisualStyleBackColor = false;
            this.btReloadImage.Click += new System.EventHandler(this.btReloadImage_Click);
            // 
            // btDeleteRow
            // 
            this.btDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteRow.BackColor = System.Drawing.Color.White;
            this.btDeleteRow.ForeColor = System.Drawing.Color.Black;
            this.btDeleteRow.Image = global::AutoLDWinform.Properties.Resources.delete_row;
            this.btDeleteRow.Location = new System.Drawing.Point(293, 28);
            this.btDeleteRow.Name = "btDeleteRow";
            this.btDeleteRow.Size = new System.Drawing.Size(41, 32);
            this.btDeleteRow.TabIndex = 13;
            this.btDeleteRow.UseVisualStyleBackColor = false;
            this.btDeleteRow.Click += new System.EventHandler(this.btDeleteRow_Click);
            // 
            // btAddID
            // 
            this.btAddID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddID.BackColor = System.Drawing.Color.White;
            this.btAddID.ForeColor = System.Drawing.Color.Black;
            this.btAddID.Image = global::AutoLDWinform.Properties.Resources.down_arrow;
            this.btAddID.Location = new System.Drawing.Point(246, 28);
            this.btAddID.Name = "btAddID";
            this.btAddID.Size = new System.Drawing.Size(41, 32);
            this.btAddID.TabIndex = 6;
            this.btAddID.UseVisualStyleBackColor = false;
            this.btAddID.Click += new System.EventHandler(this.btAddID_Click);
            // 
            // btReload
            // 
            this.btReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReload.BackColor = System.Drawing.Color.White;
            this.btReload.ForeColor = System.Drawing.Color.Black;
            this.btReload.Image = global::AutoLDWinform.Properties.Resources.reload;
            this.btReload.Location = new System.Drawing.Point(199, 28);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(41, 32);
            this.btReload.TabIndex = 3;
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // grDatatable
            // 
            this.grDatatable.Controls.Add(this.dGV);
            this.grDatatable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDatatable.Location = new System.Drawing.Point(1, 70);
            this.grDatatable.Name = "grDatatable";
            this.grDatatable.Size = new System.Drawing.Size(347, 217);
            this.grDatatable.TabIndex = 16;
            this.grDatatable.TabStop = false;
            this.grDatatable.Text = "Datatable";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(476, 313);
            this.Controls.Add(this.grDatatable);
            this.Controls.Add(this.grStartButton);
            this.Controls.Add(this.btReloadImage);
            this.Controls.Add(this.btDeleteRow);
            this.Controls.Add(this.linklbInfor);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAddID);
            this.Controls.Add(this.lbNumImages);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBdevicesID);
            this.MinimumSize = new System.Drawing.Size(494, 360);
            this.Name = "MainForm";
            this.Text = "Auto LDPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.grStartButton.ResumeLayout(false);
            this.grDatatable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBdevicesID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Label lbNumImages;
        private System.Windows.Forms.Button btAddID;
        private System.Windows.Forms.Button btB;
        private System.Windows.Forms.Button btMvL;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.LinkLabel linklbInfor;
        private System.Windows.Forms.Button btDeleteRow;
        private System.Windows.Forms.Button btReloadImage;
        private System.Windows.Forms.GroupBox grStartButton;
        private System.Windows.Forms.GroupBox grDatatable;
    }
}

