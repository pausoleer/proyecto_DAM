namespace WorkflowProject
{
    partial class ModificarFases
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
            this.cbFases = new System.Windows.Forms.ComboBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbEjecutable = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btAdd = new System.Windows.Forms.Button();
            this.lFase = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btGuardar = new WorkflowProject.BotonPersonalizado();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsVolver = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFases
            // 
            this.cbFases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFases.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbFases.FormattingEnabled = true;
            this.cbFases.Location = new System.Drawing.Point(167, 87);
            this.cbFases.Name = "cbFases";
            this.cbFases.Size = new System.Drawing.Size(191, 29);
            this.cbFases.TabIndex = 0;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDescripcion.Location = new System.Drawing.Point(147, 170);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(230, 29);
            this.tbDescripcion.TabIndex = 1;
            this.tbDescripcion.Enter += new System.EventHandler(this.tbDescripcion_Enter);
            this.tbDescripcion.Leave += new System.EventHandler(this.tbDescripcion_Leave);
            // 
            // tbEjecutable
            // 
            this.tbEjecutable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbEjecutable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbEjecutable.Location = new System.Drawing.Point(228, 331);
            this.tbEjecutable.Name = "tbEjecutable";
            this.tbEjecutable.Size = new System.Drawing.Size(149, 29);
            this.tbEjecutable.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btAdd.Location = new System.Drawing.Point(147, 330);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 30);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Añadir";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lFase
            // 
            this.lFase.AutoSize = true;
            this.lFase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lFase.Location = new System.Drawing.Point(143, 51);
            this.lFase.Name = "lFase";
            this.lFase.Size = new System.Drawing.Size(260, 21);
            this.lFase.TabIndex = 4;
            this.lFase.Text = "Elija la fase que quiere modificar";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lNombre.Location = new System.Drawing.Point(143, 146);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(211, 21);
            this.lNombre.TabIndex = 5;
            this.lNombre.Text = "Introduzca un nuevo nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(143, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elija un archivo";
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btGuardar.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btGuardar.BorderColor = System.Drawing.Color.LightBlue;
            this.btGuardar.BorderRadius = 20;
            this.btGuardar.BorderSize = 0;
            this.btGuardar.FlatAppearance.BorderSize = 0;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btGuardar.ForeColor = System.Drawing.Color.Black;
            this.btGuardar.Location = new System.Drawing.Point(147, 500);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(238, 47);
            this.btGuardar.TabIndex = 7;
            this.btGuardar.Text = "GUARDAR Y SALIR";
            this.btGuardar.TextColor = System.Drawing.Color.Black;
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFecha.Location = new System.Drawing.Point(147, 403);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(230, 29);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cbEstados
            // 
            this.cbEstados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstados.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Items.AddRange(new object[] {
            "Terminada",
            "Pendiente"});
            this.cbEstados.Location = new System.Drawing.Point(147, 254);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(230, 29);
            this.cbEstados.TabIndex = 9;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbEstado.Location = new System.Drawing.Point(143, 230);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(155, 21);
            this.cbEstado.TabIndex = 10;
            this.cbEstado.Text = "Seleccione un estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(143, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Elija una fecha";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVolver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 37);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsVolver
            // 
            this.tsVolver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsVolver.Image = global::WorkflowProject.Properties.Resources.atras;
            this.tsVolver.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsVolver.Name = "tsVolver";
            this.tsVolver.Size = new System.Drawing.Size(34, 34);
            this.tsVolver.Text = "Volver";
            this.tsVolver.Click += new System.EventHandler(this.tsVolver_Click);
            // 
            // ModificarFases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 653);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lFase);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbEjecutable);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.cbFases);
            this.Name = "ModificarFases";
            this.Text = "ModificarFases";
            this.Load += new System.EventHandler(this.ModificarFases_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFases;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbEjecutable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lFase;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label label3;
        private BotonPersonalizado btGuardar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.Label cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsVolver;
    }
}