namespace graduation_work
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Breeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HairLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddition2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddBreeds = new System.Windows.Forms.TextBox();
            this.btnClose3 = new System.Windows.Forms.Button();
            this.cmbHairLength = new System.Windows.Forms.ComboBox();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 62;
            this.label1.Text = "追加";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Breeds,
            this.Origin,
            this.HairLength});
            this.dataGridView3.Location = new System.Drawing.Point(90, 368);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 30;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(743, 244);
            this.dataGridView3.TabIndex = 59;
            // 
            // Breeds
            // 
            this.Breeds.HeaderText = "Breeds(品種名)";
            this.Breeds.MinimumWidth = 6;
            this.Breeds.Name = "Breeds";
            this.Breeds.ReadOnly = true;
            this.Breeds.Width = 180;
            // 
            // Origin
            // 
            this.Origin.HeaderText = "Origin(原産国)";
            this.Origin.MinimumWidth = 6;
            this.Origin.Name = "Origin";
            this.Origin.ReadOnly = true;
            this.Origin.Width = 150;
            // 
            // HairLength
            // 
            this.HairLength.HeaderText = "HairLength(毛並み)";
            this.HairLength.MinimumWidth = 6;
            this.HairLength.Name = "HairLength";
            this.HairLength.ReadOnly = true;
            this.HairLength.Width = 160;
            // 
            // btnAddition2
            // 
            this.btnAddition2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddition2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddition2.Location = new System.Drawing.Point(949, 327);
            this.btnAddition2.Name = "btnAddition2";
            this.btnAddition2.Size = new System.Drawing.Size(145, 60);
            this.btnAddition2.TabIndex = 58;
            this.btnAddition2.Text = "追加";
            this.btnAddition2.UseVisualStyleBackColor = false;
            this.btnAddition2.Click += new System.EventHandler(this.btnAddition2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(814, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "毛並み";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(432, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "原産国";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "品種名";
            // 
            // txtAddBreeds
            // 
            this.txtAddBreeds.BackColor = System.Drawing.Color.White;
            this.txtAddBreeds.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAddBreeds.Location = new System.Drawing.Point(32, 133);
            this.txtAddBreeds.Name = "txtAddBreeds";
            this.txtAddBreeds.Size = new System.Drawing.Size(335, 34);
            this.txtAddBreeds.TabIndex = 63;
            // 
            // btnClose3
            // 
            this.btnClose3.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose3.Location = new System.Drawing.Point(949, 608);
            this.btnClose3.Name = "btnClose3";
            this.btnClose3.Size = new System.Drawing.Size(145, 60);
            this.btnClose3.TabIndex = 67;
            this.btnClose3.Text = "閉じる";
            this.btnClose3.UseVisualStyleBackColor = false;
            this.btnClose3.Click += new System.EventHandler(this.btnClose3_Click);
            // 
            // cmbHairLength
            // 
            this.cmbHairLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHairLength.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbHairLength.FormattingEnabled = true;
            this.cmbHairLength.Location = new System.Drawing.Point(818, 132);
            this.cmbHairLength.Name = "cmbHairLength";
            this.cmbHairLength.Size = new System.Drawing.Size(239, 35);
            this.cmbHairLength.TabIndex = 69;
            this.cmbHairLength.SelectedIndexChanged += new System.EventHandler(this.cmbHairLength_SelectedIndexChanged);
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Location = new System.Drawing.Point(436, 131);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Size = new System.Drawing.Size(326, 35);
            this.cmbOrigin.TabIndex = 68;
            this.cmbOrigin.SelectedIndexChanged += new System.EventHandler(this.cmbOrigin_SelectedIndexChanged);
            // 
            // txtOthers
            // 
            this.txtOthers.Enabled = false;
            this.txtOthers.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtOthers.Location = new System.Drawing.Point(152, 250);
            this.txtOthers.Multiline = true;
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(601, 81);
            this.txtOthers.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(148, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "その他（原産国／毛並み等）";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 705);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.cmbHairLength);
            this.Controls.Add(this.cmbOrigin);
            this.Controls.Add(this.btnClose3);
            this.Controls.Add(this.txtAddBreeds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnAddition2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnAddition2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddBreeds;
        private System.Windows.Forms.Button btnClose3;
        private System.Windows.Forms.ComboBox cmbHairLength;
        private System.Windows.Forms.ComboBox cmbOrigin;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HairLength;
    }
}