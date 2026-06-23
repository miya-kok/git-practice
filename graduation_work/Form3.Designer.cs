namespace graduation_work
{
    partial class Form3
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtBreeds = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDelBreeds = new System.Windows.Forms.TextBox();
            this.btnSerch2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Breeds_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HairLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelet2 = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.txtDelOrigin = new System.Windows.Forms.TextBox();
            this.txtDelHairLength = new System.Windows.Forms.TextBox();
            this.btnClear2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(46, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "品種名";
            // 
            // txtBreeds
            // 
            this.txtBreeds.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBreeds.Location = new System.Drawing.Point(49, 93);
            this.txtBreeds.Name = "txtBreeds";
            this.txtBreeds.Size = new System.Drawing.Size(378, 34);
            this.txtBreeds.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(30, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "削除";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(791, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "毛並み";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(395, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "原産国";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(32, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "品種名";
            // 
            // txtDelBreeds
            // 
            this.txtDelBreeds.BackColor = System.Drawing.Color.White;
            this.txtDelBreeds.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDelBreeds.Location = new System.Drawing.Point(36, 466);
            this.txtDelBreeds.Name = "txtDelBreeds";
            this.txtDelBreeds.ReadOnly = true;
            this.txtDelBreeds.Size = new System.Drawing.Size(335, 34);
            this.txtDelBreeds.TabIndex = 32;
            // 
            // btnSerch2
            // 
            this.btnSerch2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSerch2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSerch2.Location = new System.Drawing.Point(475, 67);
            this.btnSerch2.Name = "btnSerch2";
            this.btnSerch2.Size = new System.Drawing.Size(145, 60);
            this.btnSerch2.TabIndex = 38;
            this.btnSerch2.Text = "検索";
            this.btnSerch2.UseVisualStyleBackColor = false;
            this.btnSerch2.Click += new System.EventHandler(this.btnSerch2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Breeds_id,
            this.Breeds,
            this.Origin,
            this.HairLength});
            this.dataGridView2.Location = new System.Drawing.Point(421, 166);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 30;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(610, 225);
            this.dataGridView2.TabIndex = 39;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // Breeds_id
            // 
            this.Breeds_id.HeaderText = "";
            this.Breeds_id.MinimumWidth = 6;
            this.Breeds_id.Name = "Breeds_id";
            this.Breeds_id.Visible = false;
            this.Breeds_id.Width = 30;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(297, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "件";
            // 
            // labelCnt
            // 
            this.labelCnt.AutoSize = true;
            this.labelCnt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCnt.Location = new System.Drawing.Point(217, 196);
            this.labelCnt.Name = "labelCnt";
            this.labelCnt.Size = new System.Drawing.Size(29, 30);
            this.labelCnt.TabIndex = 41;
            this.labelCnt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(90, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "ヒット件数";
            // 
            // btnDelet2
            // 
            this.btnDelet2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelet2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDelet2.Location = new System.Drawing.Point(953, 535);
            this.btnDelet2.Name = "btnDelet2";
            this.btnDelet2.Size = new System.Drawing.Size(145, 60);
            this.btnDelet2.TabIndex = 43;
            this.btnDelet2.Text = "削除";
            this.btnDelet2.UseVisualStyleBackColor = false;
            this.btnDelet2.Click += new System.EventHandler(this.btnDelet2_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClose2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose2.Location = new System.Drawing.Point(953, 631);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(145, 60);
            this.btnClose2.TabIndex = 44;
            this.btnClose2.Text = "閉じる";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // txtDelOrigin
            // 
            this.txtDelOrigin.BackColor = System.Drawing.Color.White;
            this.txtDelOrigin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDelOrigin.Location = new System.Drawing.Point(399, 466);
            this.txtDelOrigin.Name = "txtDelOrigin";
            this.txtDelOrigin.ReadOnly = true;
            this.txtDelOrigin.Size = new System.Drawing.Size(371, 34);
            this.txtDelOrigin.TabIndex = 45;
            // 
            // txtDelHairLength
            // 
            this.txtDelHairLength.BackColor = System.Drawing.Color.White;
            this.txtDelHairLength.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDelHairLength.Location = new System.Drawing.Point(795, 466);
            this.txtDelHairLength.Name = "txtDelHairLength";
            this.txtDelHairLength.ReadOnly = true;
            this.txtDelHairLength.Size = new System.Drawing.Size(303, 34);
            this.txtDelHairLength.TabIndex = 46;
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClear2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear2.Location = new System.Drawing.Point(36, 604);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(145, 60);
            this.btnClear2.TabIndex = 47;
            this.btnClear2.Text = "クリア";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::graduation_work.Properties.Resources.背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 703);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.txtDelHairLength);
            this.Controls.Add(this.txtDelOrigin);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.btnDelet2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSerch2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDelBreeds);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBreeds);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBreeds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDelBreeds;
        private System.Windows.Forms.Button btnSerch2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelet2;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.TextBox txtDelOrigin;
        private System.Windows.Forms.TextBox txtDelHairLength;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breeds_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HairLength;
    }
}