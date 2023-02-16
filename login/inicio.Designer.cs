namespace login
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.ingreso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.nombre = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.muestra = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(392, 3);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(41, 23);
            this.cerrar.TabIndex = 0;
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // ingreso
            // 
            this.ingreso.BackColor = System.Drawing.Color.Maroon;
            this.ingreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ingreso.FlatAppearance.BorderSize = 0;
            this.ingreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ingreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingreso.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingreso.ForeColor = System.Drawing.Color.White;
            this.ingreso.Location = new System.Drawing.Point(158, 359);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(116, 35);
            this.ingreso.TabIndex = 1;
            this.ingreso.Text = "Entrar";
            this.ingreso.UseVisualStyleBackColor = false;
            this.ingreso.Click += new System.EventHandler(this.ingreso_Click);
            this.ingreso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.ingreso.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(434, 486);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 108;
            this.lineShape2.X2 = 316;
            this.lineShape2.Y1 = 302;
            this.lineShape2.Y2 = 302;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 105;
            this.lineShape1.X2 = 313;
            this.lineShape1.Y1 = 222;
            this.lineShape1.Y2 = 222;
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.nombre.Location = new System.Drawing.Point(108, 194);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(206, 20);
            this.nombre.TabIndex = 10;
            this.nombre.Text = "Ingrese su usuario";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.Enter += new System.EventHandler(this.nombre_Enter);
            this.nombre.Leave += new System.EventHandler(this.nombre_Leave);
            // 
            // contraseña
            // 
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.contraseña.Location = new System.Drawing.Point(108, 274);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(206, 20);
            this.contraseña.TabIndex = 11;
            this.contraseña.Text = "Ingrese la contraseña";
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            this.contraseña.Enter += new System.EventHandler(this.contraseña_Enter);
            this.contraseña.Leave += new System.EventHandler(this.contraseña_Leave);
            // 
            // muestra
            // 
            this.muestra.AutoSize = true;
            this.muestra.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestra.Location = new System.Drawing.Point(253, 317);
            this.muestra.Name = "muestra";
            this.muestra.Size = new System.Drawing.Size(65, 17);
            this.muestra.TabIndex = 12;
            this.muestra.Text = "Mostrar";
            this.muestra.UseVisualStyleBackColor = true;
            this.muestra.CheckedChanged += new System.EventHandler(this.muestra_CheckedChanged);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 486);
            this.Controls.Add(this.muestra);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ingreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cerrar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.CheckBox muestra;
    }
}

