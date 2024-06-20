namespace WorkflowProject
{
    partial class NuevoUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lPass = new System.Windows.Forms.Label();
            this.lEquipo = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workflow_databaseDataSet1 = new WorkflowProject.Workflow_databaseDataSet1();
            this.btCreate = new System.Windows.Forms.Button();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbNewUser = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.equipoTableAdapter = new WorkflowProject.Workflow_databaseDataSet1TableAdapters.EquipoTableAdapter();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.lCorreo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet1)).BeginInit();
            this.panelUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lCorreo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lPass);
            this.groupBox1.Controls.Add(this.lEquipo);
            this.groupBox1.Controls.Add(this.lblErrorPass);
            this.groupBox1.Controls.Add(this.lblErrorNombre);
            this.groupBox1.Controls.Add(this.cbEquipos);
            this.groupBox1.Controls.Add(this.btCreate);
            this.groupBox1.Controls.Add(this.tbNewPass);
            this.groupBox1.Controls.Add(this.tbNewUser);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 568);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Introduzca su nombre de usuario";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btCancelar.Location = new System.Drawing.Point(106, 500);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(260, 30);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Introduzca su correo electrónico";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPass.Location = new System.Drawing.Point(103, 216);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(183, 21);
            this.lPass.TabIndex = 10;
            this.lPass.Text = "Introduzca su contraseña";
            // 
            // lEquipo
            // 
            this.lEquipo.AutoSize = true;
            this.lEquipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEquipo.Location = new System.Drawing.Point(103, 349);
            this.lEquipo.Name = "lEquipo";
            this.lEquipo.Size = new System.Drawing.Size(157, 21);
            this.lEquipo.TabIndex = 9;
            this.lEquipo.Text = "Seleccione un equipo";
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPass.Location = new System.Drawing.Point(103, 272);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(261, 66);
            this.lblErrorPass.TabIndex = 8;
            this.lblErrorPass.Text = "La contraseña debe tener al menos 6 caracteres.\r\nLa contraseña debe contener mayú" +
    "sculas y minúsculas.\r\nLa contraseña debe contener al menos un carácter especial." +
    "";
            this.lblErrorPass.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(103, 123);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(324, 15);
            this.lblErrorNombre.TabIndex = 7;
            this.lblErrorNombre.Text = "Nombre de usuario no puede contener caracteres especiales";
            this.lblErrorNombre.Visible = false;
            // 
            // cbEquipos
            // 
            this.cbEquipos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEquipos.DataSource = this.equipoBindingSource;
            this.cbEquipos.DisplayMember = "nombre_equipo";
            this.cbEquipos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Location = new System.Drawing.Point(106, 373);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(260, 29);
            this.cbEquipos.TabIndex = 5;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.workflow_databaseDataSet1;
            // 
            // workflow_databaseDataSet1
            // 
            this.workflow_databaseDataSet1.DataSetName = "Workflow_databaseDataSet1";
            this.workflow_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btCreate.Location = new System.Drawing.Point(106, 438);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(260, 32);
            this.btCreate.TabIndex = 4;
            this.btCreate.Text = "Crear";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // tbNewPass
            // 
            this.tbNewPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass.Location = new System.Drawing.Point(106, 240);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(258, 29);
            this.tbNewPass.TabIndex = 2;
            this.tbNewPass.Enter += new System.EventHandler(this.tbNewPass_Enter);
            this.tbNewPass.Leave += new System.EventHandler(this.tbNewPass_Leave);
            // 
            // tbNewUser
            // 
            this.tbNewUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewUser.Location = new System.Drawing.Point(107, 173);
            this.tbNewUser.Name = "tbNewUser";
            this.tbNewUser.Size = new System.Drawing.Size(257, 29);
            this.tbNewUser.TabIndex = 1;
            this.tbNewUser.Enter += new System.EventHandler(this.tbNewUser_Enter);
            this.tbNewUser.Leave += new System.EventHandler(this.tbNewUser_Leave);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(106, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(258, 29);
            this.tbName.TabIndex = 0;
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.groupBox1);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(497, 583);
            this.panelUsuario.TabIndex = 1;
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lCorreo.ForeColor = System.Drawing.Color.Red;
            this.lCorreo.Location = new System.Drawing.Point(103, 205);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(181, 15);
            this.lCorreo.TabIndex = 13;
            this.lCorreo.Text = "El correo electrónico no es válido";
            this.lCorreo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(130, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Crear nuevo usuario";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lUsuario.ForeColor = System.Drawing.Color.Red;
            this.lUsuario.Location = new System.Drawing.Point(103, 138);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(157, 15);
            this.lUsuario.TabIndex = 15;
            this.lUsuario.Text = "Nombre de usuario ya existe";
            this.lUsuario.Visible = false;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 583);
            this.Controls.Add(this.panelUsuario);
            this.Name = "NuevoUsuario";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet1)).EndInit();
            this.panelUsuario.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.Label lEquipo;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label label3;
    }
}