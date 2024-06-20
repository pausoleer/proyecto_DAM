namespace WorkflowProject
{
    partial class ModificarTareas
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.ttbDescripcion = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lEstado = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lFecha = new System.Windows.Forms.Label();
            this.cbTarea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsVolver = new System.Windows.Forms.ToolStripButton();
            this.btGuardar = new WorkflowProject.BotonPersonalizado();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(145, 162);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(239, 29);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.Text = "Nombre...";
            this.tbNombre.Enter += new System.EventHandler(this.tbNombre_Enter);
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // ttbDescripcion
            // 
            this.ttbDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ttbDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttbDescripcion.Location = new System.Drawing.Point(144, 244);
            this.ttbDescripcion.Name = "ttbDescripcion";
            this.ttbDescripcion.Size = new System.Drawing.Size(240, 29);
            this.ttbDescripcion.TabIndex = 1;
            this.ttbDescripcion.Text = "Descripción...";
            this.ttbDescripcion.Enter += new System.EventHandler(this.ttbDescripcion_Enter);
            this.ttbDescripcion.Leave += new System.EventHandler(this.ttbDescripcion_Leave);
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Completada"});
            this.cbEstado.Location = new System.Drawing.Point(144, 323);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(240, 29);
            this.cbEstado.TabIndex = 2;
            this.cbEstado.Text = "Nuevo estado";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(141, 138);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(181, 21);
            this.lNombre.TabIndex = 3;
            this.lNombre.Text = "Escriba el nuevo nombre";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(142, 220);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(204, 21);
            this.lDescripcion.TabIndex = 4;
            this.lDescripcion.Text = "Escriba la nueva descripción";
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.Location = new System.Drawing.Point(142, 299);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(149, 21);
            this.lEstado.TabIndex = 5;
            this.lEstado.Text = "Seleccione el estado";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(146, 405);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(238, 29);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(142, 381);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(154, 21);
            this.lFecha.TabIndex = 7;
            this.lFecha.Text = "Seleccione una fecha";
            // 
            // cbTarea
            // 
            this.cbTarea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTarea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTarea.FormattingEnabled = true;
            this.cbTarea.Location = new System.Drawing.Point(144, 72);
            this.cbTarea.Name = "cbTarea";
            this.cbTarea.Size = new System.Drawing.Size(214, 29);
            this.cbTarea.TabIndex = 9;
            this.cbTarea.Text = "Seleccione una tarea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "¿Qué Tarea quieres modificar?";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVolver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 37);
            this.toolStrip1.TabIndex = 11;
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
            this.btGuardar.Location = new System.Drawing.Point(146, 505);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(238, 47);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "GUARDAR Y SALIR";
            this.btGuardar.TextColor = System.Drawing.Color.Black;
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // ModificarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 653);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTarea);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.ttbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Name = "ModificarTareas";
            this.Text = "ModificarTareas";
            this.Load += new System.EventHandler(this.ModificarTareas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox ttbDescripcion;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lFecha;
        private BotonPersonalizado btGuardar;
        private System.Windows.Forms.ComboBox cbTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsVolver;
    }
}