namespace WorkflowProject
{
    partial class NuevaTarea
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
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lbNuevaTarea = new System.Windows.Forms.Label();
            this.tbNameTask = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btCancel = new WorkflowProject.BotonPersonalizado();
            this.btSafe = new WorkflowProject.BotonPersonalizado();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(62, 245);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(460, 29);
            this.tbDescripcion.TabIndex = 0;
            this.tbDescripcion.Enter += new System.EventHandler(this.tbDescripcion_Enter);
            this.tbDescripcion.Leave += new System.EventHandler(this.tbDescripcion_Leave);
            // 
            // lbNuevaTarea
            // 
            this.lbNuevaTarea.AutoSize = true;
            this.lbNuevaTarea.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbNuevaTarea.Location = new System.Drawing.Point(170, 57);
            this.lbNuevaTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNuevaTarea.Name = "lbNuevaTarea";
            this.lbNuevaTarea.Size = new System.Drawing.Size(231, 30);
            this.lbNuevaTarea.TabIndex = 4;
            this.lbNuevaTarea.Text = "Añade la nueva tarea";
            this.lbNuevaTarea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbNameTask
            // 
            this.tbNameTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNameTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameTask.Location = new System.Drawing.Point(62, 168);
            this.tbNameTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNameTask.Name = "tbNameTask";
            this.tbNameTask.Size = new System.Drawing.Size(460, 29);
            this.tbNameTask.TabIndex = 7;
            this.tbNameTask.Enter += new System.EventHandler(this.tbNameTask_Enter);
            this.tbNameTask.Leave += new System.EventHandler(this.tbNameTask_Leave);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(57, 400);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(392, 20);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "*La tarea se asigna automáticamente como pendiente";
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaLimite.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaLimite.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFechaLimite.Location = new System.Drawing.Point(62, 337);
            this.dtpFechaLimite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(460, 29);
            this.dtpFechaLimite.TabIndex = 9;
            this.dtpFechaLimite.ValueChanged += new System.EventHandler(this.dtpFechaLimite_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(596, 37);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WorkflowProject.Properties.Resources.atras;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton1.Text = "Atrás";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btCancel.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btCancel.BorderColor = System.Drawing.Color.LightBlue;
            this.btCancel.BorderRadius = 20;
            this.btCancel.BorderSize = 0;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Location = new System.Drawing.Point(175, 580);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(226, 66);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "CANCELAR";
            this.btCancel.TextColor = System.Drawing.Color.Black;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
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
            this.btSafe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSafe.ForeColor = System.Drawing.Color.Black;
            this.btSafe.Location = new System.Drawing.Point(175, 486);
            this.btSafe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSafe.Name = "btSafe";
            this.btSafe.Size = new System.Drawing.Size(226, 66);
            this.btSafe.TabIndex = 11;
            this.btSafe.Text = "GUARDAR Y SALIR";
            this.btSafe.TextColor = System.Drawing.Color.Black;
            this.btSafe.UseVisualStyleBackColor = false;
            this.btSafe.Click += new System.EventHandler(this.btSafe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Introduce el nombre de la tarea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Introduce la descripción de la tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Introduce la fecha fin de la tarea";
            // 
            // NuevaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSafe);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.tbNameTask);
            this.Controls.Add(this.lbNuevaTarea);
            this.Controls.Add(this.tbDescripcion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NuevaTarea";
            this.Text = "Nueva Tarea";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lbNuevaTarea;
        private System.Windows.Forms.TextBox tbNameTask;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private BotonPersonalizado btSafe;
        private BotonPersonalizado btCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}