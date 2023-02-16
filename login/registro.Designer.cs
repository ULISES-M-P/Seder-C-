namespace login
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.n_name = new System.Windows.Forms.TextBox();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.txt_municipio = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_solicitante = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 26);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // salir
            // 
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(720, 3);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(41, 23);
            this.salir.TabIndex = 1;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // n_name
            // 
            this.n_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n_name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_name.Location = new System.Drawing.Point(150, 52);
            this.n_name.Name = "n_name";
            this.n_name.Size = new System.Drawing.Size(204, 15);
            this.n_name.TabIndex = 2;
            // 
            // txt_localidad
            // 
            this.txt_localidad.Location = new System.Drawing.Point(179, 217);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(100, 20);
            this.txt_localidad.TabIndex = 5;
            this.txt_localidad.Text = "Localidad";
            // 
            // txt_municipio
            // 
            this.txt_municipio.Location = new System.Drawing.Point(321, 154);
            this.txt_municipio.Name = "txt_municipio";
            this.txt_municipio.Size = new System.Drawing.Size(100, 20);
            this.txt_municipio.TabIndex = 6;
            this.txt_municipio.Text = "Municipio";
            // 
            // txt_fecha
            // 
            this.txt_fecha.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txt_fecha.Location = new System.Drawing.Point(321, 262);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(129, 20);
            this.txt_fecha.TabIndex = 7;
            this.txt_fecha.Text = "Fecha DD//MM//YYYY";
            // 
            // txt_solicitante
            // 
            this.txt_solicitante.Location = new System.Drawing.Point(179, 154);
            this.txt_solicitante.Name = "txt_solicitante";
            this.txt_solicitante.Size = new System.Drawing.Size(100, 20);
            this.txt_solicitante.TabIndex = 8;
            this.txt_solicitante.Text = "Solicitante";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(179, 262);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 10;
            this.txt_telefono.Text = "Telefono";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(54, 318);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.Size = new System.Drawing.Size(679, 170);
            this.dgvRegistros.TabIndex = 11;
            this.dgvRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellDoubleClick);
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Location = new System.Drawing.Point(321, 217);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(100, 20);
            this.txt_domicilio.TabIndex = 12;
            this.txt_domicilio.Text = "Domicilio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(641, 194);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 15;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::login.Properties.Resources.seder1;
            this.pictureBox1.Location = new System.Drawing.Point(127, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_domicilio);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_solicitante);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_municipio);
            this.Controls.Add(this.txt_localidad);
            this.Controls.Add(this.n_name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.registro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox n_name;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.TextBox txt_municipio;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_solicitante;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}