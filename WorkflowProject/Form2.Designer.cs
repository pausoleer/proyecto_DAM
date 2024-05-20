namespace WorkflowProject
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbNewUser = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.workflow_databaseDataSet1 = new WorkflowProject.Workflow_databaseDataSet1();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipoTableAdapter = new WorkflowProject.Workflow_databaseDataSet1TableAdapters.EquipoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEquipos);
            this.groupBox1.Controls.Add(this.btCreate);
            this.groupBox1.Controls.Add(this.tbNewPass);
            this.groupBox1.Controls.Add(this.tbNewUser);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(64, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Usuario";
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(24, 282);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 4;
            this.btCreate.Text = "Crear";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(24, 138);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(100, 20);
            this.tbNewPass.TabIndex = 2;
            this.tbNewPass.Text = "password";
            // 
            // tbNewUser
            // 
            this.tbNewUser.Location = new System.Drawing.Point(24, 98);
            this.tbNewUser.Name = "tbNewUser";
            this.tbNewUser.Size = new System.Drawing.Size(100, 20);
            this.tbNewUser.TabIndex = 1;
            this.tbNewUser.Text = "email";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(24, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "nombre usuario";
            // 
            // cbEquipos
            // 
            this.cbEquipos.DataSource = this.equipoBindingSource;
            this.cbEquipos.DisplayMember = "nombre_equipo";
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Location = new System.Drawing.Point(24, 189);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(121, 21);
            this.cbEquipos.TabIndex = 5;
            // 
            // workflow_databaseDataSet1
            // 
            this.workflow_databaseDataSet1.DataSetName = "Workflow_databaseDataSet1";
            this.workflow_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.workflow_databaseDataSet1;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbNewUser;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.ComboBox cbEquipos;
        private Workflow_databaseDataSet1 workflow_databaseDataSet1;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private Workflow_databaseDataSet1TableAdapters.EquipoTableAdapter equipoTableAdapter;
    }
}