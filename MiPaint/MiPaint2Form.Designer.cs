namespace MiPaint2
{
    partial class MiPaint2Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.limpiar_Btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.linea_Btn = new System.Windows.Forms.Button();
            this.rectangulo_Btn = new System.Windows.Forms.Button();
            this.elipse_Btn = new System.Windows.Forms.Button();
            this.llenar_Btn = new System.Windows.Forms.Button();
            this.color_Btn = new System.Windows.Forms.Button();
            this.borrador_Btn = new System.Windows.Forms.Button();
            this.lapiz_Btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.limpiar_Btn);
            this.panel1.Controls.Add(this.guardar_btn);
            this.panel1.Controls.Add(this.linea_Btn);
            this.panel1.Controls.Add(this.rectangulo_Btn);
            this.panel1.Controls.Add(this.elipse_Btn);
            this.panel1.Controls.Add(this.llenar_Btn);
            this.panel1.Controls.Add(this.color_Btn);
            this.panel1.Controls.Add(this.borrador_Btn);
            this.panel1.Controls.Add(this.lapiz_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 100);
            this.panel1.TabIndex = 0;
            // 
            // limpiar_Btn
            // 
            this.limpiar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiar_Btn.Location = new System.Drawing.Point(904, 56);
            this.limpiar_Btn.Name = "limpiar_Btn";
            this.limpiar_Btn.Size = new System.Drawing.Size(75, 32);
            this.limpiar_Btn.TabIndex = 8;
            this.limpiar_Btn.Text = "Limpiar";
            this.limpiar_Btn.UseVisualStyleBackColor = true;
            this.limpiar_Btn.Click += new System.EventHandler(this.limpiar_Btn_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar_btn.Location = new System.Drawing.Point(904, 12);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(75, 32);
            this.guardar_btn.TabIndex = 7;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // linea_Btn
            // 
            this.linea_Btn.BackgroundImage = global::MiPaint2.Properties.Resources.recta;
            this.linea_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.linea_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linea_Btn.Location = new System.Drawing.Point(799, 12);
            this.linea_Btn.Name = "linea_Btn";
            this.linea_Btn.Size = new System.Drawing.Size(75, 76);
            this.linea_Btn.TabIndex = 6;
            this.linea_Btn.UseVisualStyleBackColor = true;
            this.linea_Btn.Click += new System.EventHandler(this.linea_Btn_Click);
            // 
            // rectangulo_Btn
            // 
            this.rectangulo_Btn.BackgroundImage = global::MiPaint2.Properties.Resources.rectangulo;
            this.rectangulo_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangulo_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangulo_Btn.Location = new System.Drawing.Point(718, 12);
            this.rectangulo_Btn.Name = "rectangulo_Btn";
            this.rectangulo_Btn.Size = new System.Drawing.Size(75, 76);
            this.rectangulo_Btn.TabIndex = 5;
            this.rectangulo_Btn.UseVisualStyleBackColor = true;
            this.rectangulo_Btn.Click += new System.EventHandler(this.rectangulo_Btn_Click);
            // 
            // elipse_Btn
            // 
            this.elipse_Btn.BackgroundImage = global::MiPaint2.Properties.Resources.Elipse;
            this.elipse_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elipse_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elipse_Btn.Location = new System.Drawing.Point(637, 12);
            this.elipse_Btn.Name = "elipse_Btn";
            this.elipse_Btn.Size = new System.Drawing.Size(75, 76);
            this.elipse_Btn.TabIndex = 4;
            this.elipse_Btn.UseVisualStyleBackColor = true;
            this.elipse_Btn.Click += new System.EventHandler(this.elipse_Btn_Click);
            // 
            // llenar_Btn
            // 
            this.llenar_Btn.BackgroundImage = global::MiPaint2.Properties.Resources.cubeta;
            this.llenar_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.llenar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llenar_Btn.Location = new System.Drawing.Point(378, 12);
            this.llenar_Btn.Name = "llenar_Btn";
            this.llenar_Btn.Size = new System.Drawing.Size(75, 76);
            this.llenar_Btn.TabIndex = 3;
            this.llenar_Btn.UseVisualStyleBackColor = true;
            this.llenar_Btn.Click += new System.EventHandler(this.llenar_Btn_Click);
            // 
            // color_Btn
            // 
            this.color_Btn.BackgroundImage = global::MiPaint2.Properties.Resources.Color;
            this.color_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.color_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_Btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.color_Btn.Location = new System.Drawing.Point(79, 12);
            this.color_Btn.Name = "color_Btn";
            this.color_Btn.Size = new System.Drawing.Size(75, 76);
            this.color_Btn.TabIndex = 2;
            this.color_Btn.UseVisualStyleBackColor = true;
            this.color_Btn.Click += new System.EventHandler(this.color_Btn_Click);
            // 
            // borrador_Btn
            // 
            this.borrador_Btn.BackgroundImage = global::MiPaint2.Properties.Resources.borrador;
            this.borrador_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrador_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrador_Btn.Location = new System.Drawing.Point(545, 12);
            this.borrador_Btn.Name = "borrador_Btn";
            this.borrador_Btn.Size = new System.Drawing.Size(75, 76);
            this.borrador_Btn.TabIndex = 1;
            this.borrador_Btn.UseVisualStyleBackColor = true;
            this.borrador_Btn.Click += new System.EventHandler(this.borrador_Btn_Click);
            // 
            // lapiz_Btn
            // 
            this.lapiz_Btn.BackgroundImage = global::MiPaint2.Properties.Resources.Lapiz;
            this.lapiz_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lapiz_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lapiz_Btn.Location = new System.Drawing.Point(464, 12);
            this.lapiz_Btn.Name = "lapiz_Btn";
            this.lapiz_Btn.Size = new System.Drawing.Size(75, 76);
            this.lapiz_Btn.TabIndex = 0;
            this.lapiz_Btn.UseVisualStyleBackColor = true;
            this.lapiz_Btn.Click += new System.EventHandler(this.lapiz_Btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosToolStripMenuItem1,
            this.salirToolStripMenuItem1});
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.creditosToolStripMenuItem.Text = "Acerca de ";
            // 
            // creditosToolStripMenuItem1
            // 
            this.creditosToolStripMenuItem1.Name = "creditosToolStripMenuItem1";
            this.creditosToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.creditosToolStripMenuItem1.Text = "Creditos";
            this.creditosToolStripMenuItem1.Click += new System.EventHandler(this.creditosToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // pic
            // 
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Location = new System.Drawing.Point(0, 118);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(998, 447);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // MiPaint2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 564);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MiPaint2Form";
            this.Text = "Mipaint";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button limpiar_Btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Button linea_Btn;
        private System.Windows.Forms.Button rectangulo_Btn;
        private System.Windows.Forms.Button elipse_Btn;
        private System.Windows.Forms.Button llenar_Btn;
        private System.Windows.Forms.Button color_Btn;
        private System.Windows.Forms.Button borrador_Btn;
        private System.Windows.Forms.Button lapiz_Btn;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
    }
}

