namespace kutup
{
    partial class kulsilform
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
            this.silbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1179, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // silbut
            // 
            this.silbut.BackColor = System.Drawing.Color.Lime;
            this.silbut.FlatAppearance.BorderSize = 0;
            this.silbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silbut.ForeColor = System.Drawing.Color.Black;
            this.silbut.Location = new System.Drawing.Point(45, 12);
            this.silbut.Name = "silbut";
            this.silbut.Size = new System.Drawing.Size(327, 68);
            this.silbut.TabIndex = 1;
            this.silbut.Text = "SİL";
            this.silbut.UseVisualStyleBackColor = false;
            this.silbut.Click += new System.EventHandler(this.silbut_Click);
            // 
            // kulsilform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.silbut);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kulsilform";
            this.Text = "kullanicisil";
            this.Load += new System.EventHandler(this.kulsilform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button silbut;
    }
}