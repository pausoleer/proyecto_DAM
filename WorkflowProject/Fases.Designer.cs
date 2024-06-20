namespace WorkflowProject
{
    partial class Fases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fases));
            this.panelFases = new System.Windows.Forms.Panel();
            this.btReady = new WorkflowProject.BotonPersonalizado();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbBack = new System.Windows.Forms.ToolStripButton();
            this.tbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tbCrear = new System.Windows.Forms.ToolStripButton();
            this.tbCambiar = new System.Windows.Forms.ToolStripButton();
            this.gbInfoFase = new System.Windows.Forms.GroupBox();
            this.lEstadoValor = new System.Windows.Forms.Label();
            this.lEstado = new System.Windows.Forms.Label();
            this.lFechaValor = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.lFaseAnteriorValor = new System.Windows.Forms.Label();
            this.lFaseAnterior = new System.Windows.Forms.Label();
            this.lUsuarioValor = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.clbFases = new System.Windows.Forms.CheckedListBox();
            this.tbAgregarFase = new System.Windows.Forms.ToolStripButton();
            this.tbDelete = new System.Windows.Forms.ToolStripButton();
            this.tbModificar = new System.Windows.Forms.ToolStripButton();
            this.tbAtras = new System.Windows.Forms.ToolStripButton();
            this.tsExport = new System.Windows.Forms.ToolStripButton();
            this.panelFases.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbInfoFase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFases
            // 
            this.panelFases.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelFases.Controls.Add(this.btReady);
            this.panelFases.Controls.Add(this.toolStrip1);
            this.panelFases.Controls.Add(this.gbInfoFase);
            this.panelFases.Controls.Add(this.clbFases);
            this.panelFases.Location = new System.Drawing.Point(0, 0);
            this.panelFases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFases.Name = "panelFases";
            this.panelFases.Size = new System.Drawing.Size(1200, 694);
            this.panelFases.TabIndex = 0;
            // 
            // btReady
            // 
            this.btReady.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btReady.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btReady.BorderColor = System.Drawing.Color.LightBlue;
            this.btReady.BorderRadius = 20;
            this.btReady.BorderSize = 0;
            this.btReady.FlatAppearance.BorderSize = 0;
            this.btReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReady.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReady.ForeColor = System.Drawing.Color.Black;
            this.btReady.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btReady.Location = new System.Drawing.Point(957, 463);
            this.btReady.Name = "btReady";
            this.btReady.Size = new System.Drawing.Size(131, 58);
            this.btReady.TabIndex = 5;
            this.btReady.Text = "START";
            this.btReady.TextColor = System.Drawing.Color.Black;
            this.btReady.UseVisualStyleBackColor = false;
            this.btReady.Click += new System.EventHandler(this.btReady_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbBack,
            this.tbEliminar,
            this.tbCrear,
            this.tbCambiar,
            this.tsExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1200, 37);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbBack
            // 
            this.tbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBack.Image = ((System.Drawing.Image)(resources.GetObject("tbBack.Image")));
            this.tbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(34, 34);
            this.tbBack.Text = "Volver a Tareas";
            this.tbBack.Click += new System.EventHandler(this.tbBack_Click);
            // 
            // tbEliminar
            // 
            this.tbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEliminar.Image = global::WorkflowProject.Properties.Resources.delete;
            this.tbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Size = new System.Drawing.Size(34, 34);
            this.tbEliminar.Text = "Eliminar";
            this.tbEliminar.Click += new System.EventHandler(this.tbEliminar_Click);
            // 
            // tbCrear
            // 
            this.tbCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCrear.Image = ((System.Drawing.Image)(resources.GetObject("tbCrear.Image")));
            this.tbCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCrear.Name = "tbCrear";
            this.tbCrear.Size = new System.Drawing.Size(34, 34);
            this.tbCrear.Text = "Crear Tarea Nueva";
            this.tbCrear.Click += new System.EventHandler(this.tbCrear_Click);
            // 
            // tbCambiar
            // 
            this.tbCambiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCambiar.Image = global::WorkflowProject.Properties.Resources.modificar;
            this.tbCambiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCambiar.Name = "tbCambiar";
            this.tbCambiar.Size = new System.Drawing.Size(34, 34);
            this.tbCambiar.Text = "Modificar Fase";
            this.tbCambiar.Click += new System.EventHandler(this.tbCambiar_Click);
            // 
            // gbInfoFase
            // 
            this.gbInfoFase.Controls.Add(this.lEstadoValor);
            this.gbInfoFase.Controls.Add(this.lEstado);
            this.gbInfoFase.Controls.Add(this.lFechaValor);
            this.gbInfoFase.Controls.Add(this.lFecha);
            this.gbInfoFase.Controls.Add(this.lFaseAnteriorValor);
            this.gbInfoFase.Controls.Add(this.lFaseAnterior);
            this.gbInfoFase.Controls.Add(this.lUsuarioValor);
            this.gbInfoFase.Controls.Add(this.lUsuario);
            this.gbInfoFase.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoFase.Location = new System.Drawing.Point(420, 83);
            this.gbInfoFase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInfoFase.Name = "gbInfoFase";
            this.gbInfoFase.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInfoFase.Size = new System.Drawing.Size(300, 318);
            this.gbInfoFase.TabIndex = 3;
            this.gbInfoFase.TabStop = false;
            this.gbInfoFase.Text = "Información";
            // 
            // lEstadoValor
            // 
            this.lEstadoValor.AutoSize = true;
            this.lEstadoValor.Location = new System.Drawing.Point(180, 200);
            this.lEstadoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEstadoValor.Name = "lEstadoValor";
            this.lEstadoValor.Size = new System.Drawing.Size(55, 23);
            this.lEstadoValor.TabIndex = 7;
            this.lEstadoValor.Text = "label2";
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.lEstado.Location = new System.Drawing.Point(46, 200);
            this.lEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(68, 23);
            this.lEstado.TabIndex = 6;
            this.lEstado.Text = "Estado:";
            // 
            // lFechaValor
            // 
            this.lFechaValor.AutoSize = true;
            this.lFechaValor.Location = new System.Drawing.Point(180, 157);
            this.lFechaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFechaValor.Name = "lFechaValor";
            this.lFechaValor.Size = new System.Drawing.Size(55, 23);
            this.lFechaValor.TabIndex = 5;
            this.lFechaValor.Text = "label2";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.lFecha.Location = new System.Drawing.Point(46, 157);
            this.lFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(60, 23);
            this.lFecha.TabIndex = 4;
            this.lFecha.Text = "Fecha:";
            // 
            // lFaseAnteriorValor
            // 
            this.lFaseAnteriorValor.AutoSize = true;
            this.lFaseAnteriorValor.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFaseAnteriorValor.Location = new System.Drawing.Point(180, 106);
            this.lFaseAnteriorValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFaseAnteriorValor.Name = "lFaseAnteriorValor";
            this.lFaseAnteriorValor.Size = new System.Drawing.Size(55, 23);
            this.lFaseAnteriorValor.TabIndex = 3;
            this.lFaseAnteriorValor.Text = "label4";
            // 
            // lFaseAnterior
            // 
            this.lFaseAnterior.AutoSize = true;
            this.lFaseAnterior.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFaseAnterior.Location = new System.Drawing.Point(42, 106);
            this.lFaseAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFaseAnterior.Name = "lFaseAnterior";
            this.lFaseAnterior.Size = new System.Drawing.Size(121, 23);
            this.lFaseAnterior.TabIndex = 2;
            this.lFaseAnterior.Text = "Fase Anterior:";
            // 
            // lUsuarioValor
            // 
            this.lUsuarioValor.AutoSize = true;
            this.lUsuarioValor.Location = new System.Drawing.Point(180, 60);
            this.lUsuarioValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUsuarioValor.Name = "lUsuarioValor";
            this.lUsuarioValor.Size = new System.Drawing.Size(43, 23);
            this.lUsuarioValor.TabIndex = 1;
            this.lUsuarioValor.Text = "lagg";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.Location = new System.Drawing.Point(42, 60);
            this.lUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(75, 23);
            this.lUsuario.TabIndex = 0;
            this.lUsuario.Text = "Usuario:";
            // 
            // clbFases
            // 
            this.clbFases.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clbFases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbFases.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.clbFases.FormattingEnabled = true;
            this.clbFases.Location = new System.Drawing.Point(18, 83);
            this.clbFases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbFases.Name = "clbFases";
            this.clbFases.Size = new System.Drawing.Size(312, 522);
            this.clbFases.TabIndex = 0;
            this.clbFases.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clbFases_MouseClick);
            // 
            // tbAgregarFase
            // 
            this.tbAgregarFase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAgregarFase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAgregarFase.Name = "tbAgregarFase";
            this.tbAgregarFase.Size = new System.Drawing.Size(23, 22);
            this.tbAgregarFase.Text = "Agregar Fase";
            // 
            // tbDelete
            // 
            this.tbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(23, 22);
            this.tbDelete.Text = "Eliminar Fase";
            // 
            // tbModificar
            // 
            this.tbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbModificar.Name = "tbModificar";
            this.tbModificar.Size = new System.Drawing.Size(23, 22);
            this.tbModificar.Text = "Modificar Fase";
            // 
            // tbAtras
            // 
            this.tbAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAtras.Image = ((System.Drawing.Image)(resources.GetObject("tbAtras.Image")));
            this.tbAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAtras.Name = "tbAtras";
            this.tbAtras.Size = new System.Drawing.Size(23, 22);
            this.tbAtras.Text = "Atrás";
            // 
            // tsExport
            // 
            this.tsExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExport.Image = ((System.Drawing.Image)(resources.GetObject("tsExport.Image")));
            this.tsExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExport.Name = "tsExport";
            this.tsExport.Size = new System.Drawing.Size(34, 34);
            this.tsExport.Text = "toolStripButton1";
            this.tsExport.Click += new System.EventHandler(this.tsExport_Click);
            // 
            // Fases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelFases);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fases";
            this.Text = "Fases";
            this.Load += new System.EventHandler(this.Fases_Load);
            this.panelFases.ResumeLayout(false);
            this.panelFases.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbInfoFase.ResumeLayout(false);
            this.gbInfoFase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFases;
        public System.Windows.Forms.CheckedListBox clbFases;
        private System.Windows.Forms.ToolStripButton tbAgregarFase;
        private System.Windows.Forms.ToolStripButton tbDelete;
        private System.Windows.Forms.GroupBox gbInfoFase;
        private System.Windows.Forms.Label lUsuarioValor;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lFechaValor;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lFaseAnteriorValor;
        private System.Windows.Forms.Label lFaseAnterior;
        private System.Windows.Forms.ToolStripButton tbModificar;
        private System.Windows.Forms.Label lEstadoValor;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.ToolStripButton tbAtras;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbEliminar;
        private System.Windows.Forms.ToolStripButton tbCrear;
        private System.Windows.Forms.ToolStripButton tbCambiar;
        private System.Windows.Forms.ToolStripButton tbBack;
        private BotonPersonalizado btReady;
        private System.Windows.Forms.ToolStripButton tsExport;
    }
}