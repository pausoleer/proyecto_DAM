namespace WorkflowProject
{
    partial class Form4
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
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbNameTask = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(44, 103);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(308, 20);
            this.tbDescripcion.TabIndex = 0;
            this.tbDescripcion.Text = "Descripción...";
            // 
            // lbNuevaTarea
            // 
            this.lbNuevaTarea.AutoSize = true;
            this.lbNuevaTarea.Location = new System.Drawing.Point(41, 22);
            this.lbNuevaTarea.Name = "lbNuevaTarea";
            this.lbNuevaTarea.Size = new System.Drawing.Size(109, 13);
            this.lbNuevaTarea.TabIndex = 4;
            this.lbNuevaTarea.Text = "Añade la nueva tarea";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(44, 243);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 5;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbNameTask
            // 
            this.tbNameTask.Location = new System.Drawing.Point(41, 62);
            this.tbNameTask.Name = "tbNameTask";
            this.tbNameTask.Size = new System.Drawing.Size(166, 20);
            this.tbNameTask.TabIndex = 7;
            this.tbNameTask.Text = "Nombre de la tarea";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(41, 212);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(257, 13);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "La tarea se asigna automáticamente como pendiente";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.tbNameTask);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lbNuevaTarea);
            this.Controls.Add(this.tbDescripcion);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lbNuevaTarea;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbNameTask;
        private System.Windows.Forms.Label labelInfo;
    }
}