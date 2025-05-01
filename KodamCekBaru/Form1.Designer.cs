namespace KodamCekBaru
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
            this.btnCekKodam = new System.Windows.Forms.Button();
            this.dataGridViewRiwayat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaUser = new System.Windows.Forms.TextBox();
            this.btnClearRiwayat = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCekKodam
            // 
            this.btnCekKodam.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCekKodam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCekKodam.Font = new System.Drawing.Font("Vogue", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCekKodam.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnCekKodam.Location = new System.Drawing.Point(807, 121);
            this.btnCekKodam.Name = "btnCekKodam";
            this.btnCekKodam.Size = new System.Drawing.Size(201, 60);
            this.btnCekKodam.TabIndex = 0;
            this.btnCekKodam.Text = "Cek Kodam";
            this.btnCekKodam.UseVisualStyleBackColor = false;
            this.btnCekKodam.Click += new System.EventHandler(this.btnCekKhodam_Click);
            // 
            // dataGridViewRiwayat
            // 
            this.dataGridViewRiwayat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayat.Location = new System.Drawing.Point(24, 195);
            this.dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            this.dataGridViewRiwayat.RowHeadersWidth = 62;
            this.dataGridViewRiwayat.RowTemplate.Height = 28;
            this.dataGridViewRiwayat.Size = new System.Drawing.Size(984, 287);
            this.dataGridViewRiwayat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masukan nama anda";
            // 
            // txtNamaUser
            // 
            this.txtNamaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaUser.Location = new System.Drawing.Point(24, 121);
            this.txtNamaUser.Multiline = true;
            this.txtNamaUser.Name = "txtNamaUser";
            this.txtNamaUser.Size = new System.Drawing.Size(655, 60);
            this.txtNamaUser.TabIndex = 3;
            // 
            // btnClearRiwayat
            // 
            this.btnClearRiwayat.BackColor = System.Drawing.Color.Red;
            this.btnClearRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRiwayat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearRiwayat.Location = new System.Drawing.Point(807, 495);
            this.btnClearRiwayat.Name = "btnClearRiwayat";
            this.btnClearRiwayat.Size = new System.Drawing.Size(201, 48);
            this.btnClearRiwayat.TabIndex = 4;
            this.btnClearRiwayat.Text = "Hapus Riwayat";
            this.btnClearRiwayat.UseVisualStyleBackColor = false;
            this.btnClearRiwayat.Click += new System.EventHandler(this.btnClearRiwayat_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(24, 495);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 48);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Gabriola", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, -16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 89);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cek Pengawal Sepiritual Anda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1020, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClearRiwayat);
            this.Controls.Add(this.txtNamaUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRiwayat);
            this.Controls.Add(this.btnCekKodam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCekKodam;
        private System.Windows.Forms.DataGridView dataGridViewRiwayat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaUser;
        private System.Windows.Forms.Button btnClearRiwayat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
    }
}

