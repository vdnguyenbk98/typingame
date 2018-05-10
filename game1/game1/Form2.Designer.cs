namespace game1
{
    partial class T
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
            this.namePlayer = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.Cc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namePlayer
            // 
            this.namePlayer.Location = new System.Drawing.Point(60, 46);
            this.namePlayer.Name = "namePlayer";
            this.namePlayer.Size = new System.Drawing.Size(211, 20);
            this.namePlayer.TabIndex = 0;
            this.namePlayer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(211, 100);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Cc
            // 
            this.Cc.Location = new System.Drawing.Point(51, 100);
            this.Cc.Name = "Cc";
            this.Cc.Size = new System.Drawing.Size(75, 23);
            this.Cc.TabIndex = 2;
            this.Cc.Text = "Bỏ qua";
            this.Cc.UseVisualStyleBackColor = true;
            this.Cc.Click += new System.EventHandler(this.Cc_Click);
            // 
            // T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 135);
            this.Controls.Add(this.Cc);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.namePlayer);
            this.Name = "T";
            this.Text = "Nhập tên người chơi";
            this.Load += new System.EventHandler(this.T_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namePlayer;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button Cc;
    }
}