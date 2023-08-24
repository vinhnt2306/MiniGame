
namespace MiniGame
{
    partial class fMayMan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.btn_Quay = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(89, 111);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(172, 196);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(339, 111);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(172, 196);
            this.pic2.TabIndex = 0;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(592, 111);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(172, 196);
            this.pic3.TabIndex = 0;
            this.pic3.TabStop = false;
            // 
            // btn_Quay
            // 
            this.btn_Quay.Location = new System.Drawing.Point(208, 398);
            this.btn_Quay.Name = "btn_Quay";
            this.btn_Quay.Size = new System.Drawing.Size(153, 61);
            this.btn_Quay.TabIndex = 1;
            this.btn_Quay.Text = "Quay";
            this.btn_Quay.UseVisualStyleBackColor = true;
            this.btn_Quay.Click += new System.EventHandler(this.btn_Quay_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(464, 398);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(153, 61);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(339, 332);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(172, 42);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "18";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fMayMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Quay);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fMayMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Số may mắn";
            this.Load += new System.EventHandler(this.fTaixiu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Button btn_Quay;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lblResult;
    }
}

