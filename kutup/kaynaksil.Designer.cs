namespace kutup
{
    partial class kaynaksil
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
            this.kaynaksilbtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // kaynaksilbtn
            // 
            this.kaynaksilbtn.BackColor = System.Drawing.Color.Lime;
            this.kaynaksilbtn.FlatAppearance.BorderSize = 0;
            this.kaynaksilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaynaksilbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.75F, System.Drawing.FontStyle.Bold);
            this.kaynaksilbtn.Location = new System.Drawing.Point(20, 33);
            this.kaynaksilbtn.Name = "kaynaksilbtn";
            this.kaynaksilbtn.Size = new System.Drawing.Size(177, 66);
            this.kaynaksilbtn.TabIndex = 0;
            this.kaynaksilbtn.Text = "SİL";
            this.kaynaksilbtn.UseVisualStyleBackColor = false;
            this.kaynaksilbtn.Click += new System.EventHandler(this.kaynaksilbtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 122);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(745, 300);
            this.dataGridView2.TabIndex = 2;
            // 
            // kaynaksil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.kaynaksilbtn);
            this.Name = "kaynaksil";
            this.Text = "kaynaksil";
            this.Load += new System.EventHandler(this.kaynaksil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kaynaksilbtn;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}