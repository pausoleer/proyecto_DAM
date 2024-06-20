namespace WorkflowProject
{
    partial class TareasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TareasForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsModificar = new System.Windows.Forms.ToolStripButton();
            this.tsExportar = new System.Windows.Forms.ToolStripButton();
            this.dgTareas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.workflow_databaseDataSet = new WorkflowProject.Workflow_databaseDataSet();
            this.tareaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareaTableAdapter = new WorkflowProject.Workflow_databaseDataSetTableAdapters.TareaTableAdapter();
            this.tableAdapterManager1 = new WorkflowProject.DataSet2TableAdapters.TableAdapterManager();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAgregar,
            this.tsDelete,
            this.tsUsuario,
            this.tsModificar,
            this.tsExportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1180, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Modificar Tarea";
            // 
            // tsAgregar
            // 
            this.tsAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsAgregar.Image")));
            this.tsAgregar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsAgregar.Name = "tsAgregar";
            this.tsAgregar.Size = new System.Drawing.Size(34, 34);
            this.tsAgregar.Text = "Agregar Tarea";
            this.tsAgregar.Click += new System.EventHandler(this.tsAgregar_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Image = global::WorkflowProject.Properties.Resources.delete;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(34, 34);
            this.tsDelete.Text = "Eliminar Tarea";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsUsuario
            // 
            this.tsUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tsUsuario.Image")));
            this.tsUsuario.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Size = new System.Drawing.Size(34, 34);
            this.tsUsuario.Text = "Crear Usuario";
            this.tsUsuario.Click += new System.EventHandler(this.tsUsuario_Click);
            // 
            // tsModificar
            // 
            this.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsModificar.Image = global::WorkflowProject.Properties.Resources.modificar;
            this.tsModificar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsModificar.Name = "tsModificar";
            this.tsModificar.Size = new System.Drawing.Size(34, 34);
            this.tsModificar.Text = "Modificar Tareas";
            this.tsModificar.Click += new System.EventHandler(this.tsModificar_Click);
            // 
            // tsExportar
            // 
            this.tsExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsExportar.Image")));
            this.tsExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExportar.Name = "tsExportar";
            this.tsExportar.Size = new System.Drawing.Size(34, 34);
            this.tsExportar.Text = "Exportar";
            this.tsExportar.Click += new System.EventHandler(this.tsExportar_Click);
            // 
            // dgTareas
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgTareas.AutoGenerateColumns = false;
            this.dgTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTareas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.descripcionDataGridViewTextBoxColumn,
            this.estado,
            this.limite});
            this.dgTareas.DataSource = this.tareaBindingSource2;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTareas.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTareas.EnableHeadersVisualStyles = false;
            this.dgTareas.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgTareas.Location = new System.Drawing.Point(0, 37);
            this.dgTareas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgTareas.Name = "dgTareas";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTareas.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.dgTareas.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTareas.Size = new System.Drawing.Size(1180, 618);
            this.dgTareas.TabIndex = 1;
            this.dgTareas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTareas_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.id.DefaultCellStyle = dataGridViewCellStyle13;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle14;
            this.Nombre.HeaderText = "nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.DataPropertyName = "estado";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.DefaultCellStyle = dataGridViewCellStyle16;
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // limite
            // 
            this.limite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.limite.DataPropertyName = "fecha_limite";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limite.DefaultCellStyle = dataGridViewCellStyle17;
            this.limite.HeaderText = "fecha_limite";
            this.limite.Name = "limite";
            this.limite.ReadOnly = true;
            // 
            // tareaBindingSource2
            // 
            this.tareaBindingSource2.DataMember = "Tarea";
            this.tareaBindingSource2.DataSource = this.workflow_databaseDataSet;
            // 
            // workflow_databaseDataSet
            // 
            this.workflow_databaseDataSet.DataSetName = "Workflow_databaseDataSet";
            this.workflow_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tareaBindingSource1
            // 
            this.tareaBindingSource1.DataMember = "Tarea";
            this.tareaBindingSource1.DataSource = this.workflow_databaseDataSet;
            // 
            // tareaBindingSource
            // 
            this.tareaBindingSource.DataMember = "Tarea";
            this.tareaBindingSource.DataSource = this.workflow_databaseDataSet;
            // 
            // tareaTableAdapter
            // 
            this.tareaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = WorkflowProject.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usuariosTableAdapter = null;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.dgTareas);
            this.panelContenido.Controls.Add(this.toolStrip1);
            this.panelContenido.Location = new System.Drawing.Point(18, 18);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1180, 655);
            this.panelContenido.TabIndex = 2;
            // 
            // TareasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 678);
            this.Controls.Add(this.panelContenido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TareasForm";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.TareasForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAgregar;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private Workflow_databaseDataSet workflow_databaseDataSet;
        private System.Windows.Forms.BindingSource tareaBindingSource;
        private Workflow_databaseDataSetTableAdapters.TareaTableAdapter tareaTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        public System.Windows.Forms.DataGridView dgTareas;
        private System.Windows.Forms.BindingSource tareaBindingSource1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.BindingSource tareaBindingSource2;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.ToolStripButton tsUsuario;
        private System.Windows.Forms.ToolStripButton tsModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn limite;
        private System.Windows.Forms.ToolStripButton tsExportar;
    }
}