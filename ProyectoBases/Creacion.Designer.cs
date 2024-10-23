namespace ProyectoBases
{
    partial class Creacion
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
            OpcionesCreacion = new TabControl();
            Pelicula = new TabPage();
            dtDuracionPelicula = new DateTimePicker();
            txtDescripcionPelicula = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            cbClasificacionPelicula = new ComboBox();
            label2 = new Label();
            txtNombrePelicula = new TextBox();
            label1 = new Label();
            Sesion = new TabPage();
            button2 = new Button();
            cbNombrePelicula = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            dtFechaInicio = new DateTimePicker();
            cbSala = new ComboBox();
            label5 = new Label();
            OpcionesCreacion.SuspendLayout();
            Pelicula.SuspendLayout();
            Sesion.SuspendLayout();
            SuspendLayout();
            // 
            // OpcionesCreacion
            // 
            OpcionesCreacion.Controls.Add(Pelicula);
            OpcionesCreacion.Controls.Add(Sesion);
            OpcionesCreacion.Location = new Point(12, 12);
            OpcionesCreacion.Name = "OpcionesCreacion";
            OpcionesCreacion.SelectedIndex = 0;
            OpcionesCreacion.Size = new Size(345, 426);
            OpcionesCreacion.TabIndex = 0;
            // 
            // Pelicula
            // 
            Pelicula.Controls.Add(dtDuracionPelicula);
            Pelicula.Controls.Add(txtDescripcionPelicula);
            Pelicula.Controls.Add(button1);
            Pelicula.Controls.Add(label4);
            Pelicula.Controls.Add(label3);
            Pelicula.Controls.Add(cbClasificacionPelicula);
            Pelicula.Controls.Add(label2);
            Pelicula.Controls.Add(txtNombrePelicula);
            Pelicula.Controls.Add(label1);
            Pelicula.Location = new Point(4, 29);
            Pelicula.Name = "Pelicula";
            Pelicula.Padding = new Padding(3);
            Pelicula.Size = new Size(337, 393);
            Pelicula.TabIndex = 0;
            Pelicula.Text = "Pelicula";
            Pelicula.UseVisualStyleBackColor = true;
            // 
            // dtDuracionPelicula
            // 
            dtDuracionPelicula.CustomFormat = "HH:mm:ss";
            dtDuracionPelicula.Format = DateTimePickerFormat.Custom;
            dtDuracionPelicula.Location = new Point(81, 107);
            dtDuracionPelicula.Name = "dtDuracionPelicula";
            dtDuracionPelicula.ShowUpDown = true;
            dtDuracionPelicula.Size = new Size(87, 27);
            dtDuracionPelicula.TabIndex = 10;
            dtDuracionPelicula.Value = new DateTime(2024, 10, 18, 11, 26, 43, 0);
            // 
            // txtDescripcionPelicula
            // 
            txtDescripcionPelicula.Location = new Point(6, 176);
            txtDescripcionPelicula.Multiline = true;
            txtDescripcionPelicula.Name = "txtDescripcionPelicula";
            txtDescripcionPelicula.Size = new Size(249, 176);
            txtDescripcionPelicula.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(130, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 153);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Duracion";
            // 
            // cbClasificacionPelicula
            // 
            cbClasificacionPelicula.FormattingEnabled = true;
            cbClasificacionPelicula.Location = new Point(104, 65);
            cbClasificacionPelicula.Name = "cbClasificacionPelicula";
            cbClasificacionPelicula.Size = new Size(151, 28);
            cbClasificacionPelicula.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Clasificacion";
            // 
            // txtNombrePelicula
            // 
            txtNombrePelicula.Location = new Point(76, 17);
            txtNombrePelicula.MaxLength = 100;
            txtNombrePelicula.Name = "txtNombrePelicula";
            txtNombrePelicula.Size = new Size(179, 27);
            txtNombrePelicula.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // Sesion
            // 
            Sesion.Controls.Add(button2);
            Sesion.Controls.Add(cbNombrePelicula);
            Sesion.Controls.Add(label8);
            Sesion.Controls.Add(label6);
            Sesion.Controls.Add(dtFechaInicio);
            Sesion.Controls.Add(cbSala);
            Sesion.Controls.Add(label5);
            Sesion.Location = new Point(4, 29);
            Sesion.Name = "Sesion";
            Sesion.Padding = new Padding(3);
            Sesion.Size = new Size(337, 393);
            Sesion.TabIndex = 1;
            Sesion.Text = "Sesion";
            Sesion.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(128, 358);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbNombrePelicula
            // 
            cbNombrePelicula.FormattingEnabled = true;
            cbNombrePelicula.Location = new Point(71, 103);
            cbNombrePelicula.Name = "cbNombrePelicula";
            cbNombrePelicula.Size = new Size(151, 28);
            cbNombrePelicula.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 106);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 6;
            label8.Text = "Pelicula";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 3;
            label6.Text = "Fecha y Hora Inicio";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtFechaInicio.Format = DateTimePickerFormat.Custom;
            dtFechaInicio.Location = new Point(147, 14);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(164, 27);
            dtFechaInicio.TabIndex = 2;
            dtFechaInicio.Value = new DateTime(2024, 10, 18, 11, 26, 43, 0);
            // 
            // cbSala
            // 
            cbSala.FormattingEnabled = true;
            cbSala.Location = new Point(49, 57);
            cbSala.Name = "cbSala";
            cbSala.Size = new Size(173, 28);
            cbSala.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 60);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 0;
            label5.Text = "Sala";
            // 
            // Creacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 450);
            Controls.Add(OpcionesCreacion);
            Name = "Creacion";
            Text = "Creacion";
            OpcionesCreacion.ResumeLayout(false);
            Pelicula.ResumeLayout(false);
            Pelicula.PerformLayout();
            Sesion.ResumeLayout(false);
            Sesion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl OpcionesCreacion;
        private TabPage Pelicula;
        private TabPage Sesion;
        private Label label1;
        private ComboBox cbClasificacionPelicula;
        private Label label2;
        private TextBox txtNombrePelicula;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox txtDescripcionPelicula;
        private ComboBox cbSala;
        private Label label5;
        private Label label6;
        private DateTimePicker dtFechaInicio;
        private DateTimePicker dtDuracionPelicula;
        private Button button2;
        private ComboBox cbNombrePelicula;
        private Label label8;
    }
}