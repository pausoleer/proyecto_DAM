namespace WorkflowProject
{
    partial class NuevaFase
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lErrorFecha = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lArchivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.btSalir = new WorkflowProject.BotonPersonalizado();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAtras = new System.Windows.Forms.ToolStripButton();
            this.lFase = new System.Windows.Forms.Label();
            this.btSafe = new WorkflowProject.BotonPersonalizado();
            this.tbExe = new System.Windows.Forms.TextBox();
            this.btExe = new System.Windows.Forms.Button();
            this.cbAnterior = new System.Windows.Forms.ComboBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.workflow_databaseDataSet = new WorkflowProject.Workflow_databaseDataSet();
            this.workflowdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WorkflowProject.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflowdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Controls.Add(this.lErrorFecha);
            this.panel1.Controls.Add(this.lUsuario);
            this.panel1.Controls.Add(this.lArchivo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.lDescripcion);
            this.panel1.Controls.Add(this.btSalir);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.lFase);
            this.panel1.Controls.Add(this.btSafe);
            this.panel1.Controls.Add(this.tbExe);
            this.panel1.Controls.Add(this.btExe);
            this.panel1.Controls.Add(this.cbAnterior);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Controls.Add(this.tbDescripcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 692);
            this.panel1.TabIndex = 0;
            // 
            // lErrorFecha
            // 
            this.lErrorFecha.AutoSize = true;
            this.lErrorFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lErrorFecha.ForeColor = System.Drawing.Color.Red;
            this.lErrorFecha.Location = new System.Drawing.Point(129, 319);
            this.lErrorFecha.Name = "lErrorFecha";
            this.lErrorFecha.Size = new System.Drawing.Size(348, 15);
            this.lErrorFecha.TabIndex = 19;
            this.lErrorFecha.Text = "La fecha de inicio debe ser posterior a la fecha de la fase anterior.";
            this.lErrorFecha.Visible = false;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lUsuario.Location = new System.Drawing.Point(128, 176);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(159, 21);
            this.lUsuario.TabIndex = 18;
            this.lUsuario.Text = "Selecciona el usuario ";
            // 
            // lArchivo
            // 
            this.lArchivo.AutoSize = true;
            this.lArchivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lArchivo.Location = new System.Drawing.Point(128, 416);
            this.lArchivo.Name = "lArchivo";
            this.lArchivo.Size = new System.Drawing.Size(131, 21);
            this.lArchivo.TabIndex = 17;
            this.lArchivo.Text = "Añade un archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(128, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Selecciona la fase anterior";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lFecha.Location = new System.Drawing.Point(128, 259);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(154, 21);
            this.lFecha.TabIndex = 15;
            this.lFecha.Text = "Selecciona una fecha";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lDescripcion.Location = new System.Drawing.Point(128, 102);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(222, 21);
            this.lDescripcion.TabIndex = 14;
            this.lDescripcion.Text = "Introduce el nombre de la Fase";
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btSalir.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btSalir.BorderColor = System.Drawing.Color.LightBlue;
            this.btSalir.BorderRadius = 20;
            this.btSalir.BorderSize = 0;
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btSalir.ForeColor = System.Drawing.Color.Black;
            this.btSalir.Location = new System.Drawing.Point(168, 600);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(238, 47);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "CANCELAR";
            this.btSalir.TextColor = System.Drawing.Color.Black;
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAtras});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 37);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAtras
            // 
            this.tsAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAtras.Image = global::WorkflowProject.Properties.Resources.atras;
            this.tsAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAtras.Name = "tsAtras";
            this.tsAtras.Size = new System.Drawing.Size(34, 34);
            this.tsAtras.Text = "Salir";
            this.tsAtras.Click += new System.EventHandler(this.tsAtras_Click);
            // 
            // lFase
            // 
            this.lFase.AutoSize = true;
            this.lFase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lFase.Location = new System.Drawing.Point(197, 48);
            this.lFase.Name = "lFase";
            this.lFase.Size = new System.Drawing.Size(185, 25);
            this.lFase.TabIndex = 11;
            this.lFase.Text = "Crear nueva Fase";
            // 
            // btSafe
            // 
            this.btSafe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btSafe.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btSafe.BorderColor = System.Drawing.Color.LightBlue;
            this.btSafe.BorderRadius = 20;
            this.btSafe.BorderSize = 0;
            this.btSafe.FlatAppearance.BorderSize = 0;
            this.btSafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSafe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btSafe.ForeColor = System.Drawing.Color.Black;
            this.btSafe.Location = new System.Drawing.Point(168, 519);
            this.btSafe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSafe.Name = "btSafe";
            this.btSafe.Size = new System.Drawing.Size(238, 47);
            this.btSafe.TabIndex = 10;
            this.btSafe.Text = "GUARDAR Y SALIR";
            this.btSafe.TextColor = System.Drawing.Color.Black;
            this.btSafe.UseVisualStyleBackColor = false;
            this.btSafe.Click += new System.EventHandler(this.btSafe_Click);
            // 
            // tbExe
            // 
            this.tbExe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbExe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbExe.Location = new System.Drawing.Point(267, 441);
            this.tbExe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbExe.Name = "tbExe";
            this.tbExe.Size = new System.Drawing.Size(173, 29);
            this.tbExe.TabIndex = 7;
            // 
            // btExe
            // 
            this.btExe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btExe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btExe.Location = new System.Drawing.Point(132, 441);
            this.btExe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExe.Name = "btExe";
            this.btExe.Size = new System.Drawing.Size(112, 29);
            this.btExe.TabIndex = 6;
            this.btExe.Text = "Añadir archivo";
            this.btExe.UseVisualStyleBackColor = false;
            this.btExe.Click += new System.EventHandler(this.btExe_Click);
            // 
            // cbAnterior
            // 
            this.cbAnterior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAnterior.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAnterior.FormattingEnabled = true;
            this.cbAnterior.Location = new System.Drawing.Point(132, 371);
            this.cbAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAnterior.Name = "cbAnterior";
            this.cbAnterior.Size = new System.Drawing.Size(308, 29);
            this.cbAnterior.TabIndex = 5;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpInicio.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpInicio.Location = new System.Drawing.Point(132, 285);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(308, 29);
            this.dtpInicio.TabIndex = 4;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // cbUsuario
            // 
            this.cbUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(132, 202);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(308, 29);
            this.cbUsuario.TabIndex = 3;
            this.cbUsuario.Text = "Usuario...";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDescripcion.Location = new System.Drawing.Point(132, 128);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(308, 29);
            this.tbDescripcion.TabIndex = 0;
            this.tbDescripcion.Enter += new System.EventHandler(this.tbDescripcion_Enter);
            this.tbDescripcion.Leave += new System.EventHandler(this.tbDescripcion_Leave);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // workflow_databaseDataSet
            // 
            this.workflow_databaseDataSet.DataSetName = "Workflow_databaseDataSet";
            this.workflow_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workflowdatabaseDataSetBindingSource
            // 
            this.workflowdatabaseDataSetBindingSource.DataSource = this.workflow_databaseDataSet;
            this.workflowdatabaseDataSetBindingSource.Position = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lNombre.ForeColor = System.Drawing.Color.Red;
            this.lNombre.Location = new System.Drawing.Point(129, 162);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(219, 15);
            this.lNombre.TabIndex = 20;
            this.lNombre.Text = "Ya existe una fase con el mismo nombre";
            this.lNombre.Visible = false;
            // 
            // NuevaFase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 692);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NuevaFase";
            this.Text = "NuevaFase";
            this.Load += new System.EventHandler(this.NuevaFase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflowdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.ComboBox cbAnterior;
        private System.Windows.Forms.Button btExe;
        private System.Windows.Forms.TextBox tbExe;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private Workflow_databaseDataSet workflow_databaseDataSet;
        private System.Windows.Forms.BindingSource workflowdatabaseDataSetBindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private BotonPersonalizado btSafe;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAtras;
        private System.Windows.Forms.Label lFase;
        private BotonPersonalizado btSalir;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lErrorFecha;
        private System.Windows.Forms.Label lNombre;
    }
}