namespace MiPaint2
{
    partial class CreditosForm
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
            this.nombre_Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cat_picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cat_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_Lbl
            // 
            this.nombre_Lbl.AutoSize = true;
            this.nombre_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nombre_Lbl.Location = new System.Drawing.Point(12, 27);
            this.nombre_Lbl.Name = "nombre_Lbl";
            this.nombre_Lbl.Size = new System.Drawing.Size(289, 24);
            this.nombre_Lbl.TabIndex = 0;
            this.nombre_Lbl.Text = "Pedro Brandon Urquijo Canizales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "urquijodevengineer@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mexico, Hermosillo Sonora";
            // 
            // cat_picbox
            // 
            this.cat_picbox.Image = global::MiPaint2.Properties.Resources.cat_cat_brick;
            this.cat_picbox.Location = new System.Drawing.Point(452, 12);
            this.cat_picbox.Name = "cat_picbox";
            this.cat_picbox.Size = new System.Drawing.Size(336, 273);
            this.cat_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat_picbox.TabIndex = 3;
            this.cat_picbox.TabStop = false;
            // 
            // CreditosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.cat_picbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre_Lbl);
            this.Name = "CreditosForm";
            this.Text = "Creditos";
            ((System.ComponentModel.ISupportInitialize)(this.cat_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre_Lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cat_picbox;
    }
}