namespace WorkflowProject
{
    partial class Form3
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Completada"}, -1, System.Drawing.Color.Green, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pendiente"}, -1, System.Drawing.Color.Red, System.Drawing.Color.Empty, null);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.lvLeyenda = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.gbTareas = new System.Windows.Forms.GroupBox();
            this.dgTareas = new System.Windows.Forms.DataGridView();
            this.tareaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workflow_databaseDataSet = new WorkflowProject.Workflow_databaseDataSet();
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareaTableAdapter = new WorkflowProject.Workflow_databaseDataSetTableAdapters.TareaTableAdapter();
            this.tableAdapterManager1 = new WorkflowProject.DataSet2TableAdapters.TableAdapterManager();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.gbTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet)).BeginInit();
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
            // lvLeyenda
            // 
            this.lvLeyenda.HideSelection = false;
            this.lvLeyenda.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvLeyenda.Location = new System.Drawing.Point(660, 385);
            this.lvLeyenda.Name = "lvLeyenda";
            this.lvLeyenda.Size = new System.Drawing.Size(80, 53);
            this.lvLeyenda.TabIndex = 1;
            this.lvLeyenda.UseCompatibleStateImageBehavior = false;
            this.lvLeyenda.View = System.Windows.Forms.View.List;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAgregar,
            this.tsDelete});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(636, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAgregar
            // 
            this.tsAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAgregar.Image = global::WorkflowProject.Properties.Resources.agregar1;
            this.tsAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAgregar.Name = "tsAgregar";
            this.tsAgregar.Size = new System.Drawing.Size(23, 22);
            this.tsAgregar.Text = "Agregar Tarea";
            this.tsAgregar.Click += new System.EventHandler(this.tsAgregar_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Image = global::WorkflowProject.Properties.Resources.delete;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(23, 22);
            this.tsDelete.Text = "Eliminar Tarea";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // gbTareas
            // 
            this.gbTareas.Controls.Add(this.dgTareas);
            this.gbTareas.Controls.Add(this.toolStrip1);
            this.gbTareas.Location = new System.Drawing.Point(3, 17);
            this.gbTareas.Name = "gbTareas";
            this.gbTareas.Size = new System.Drawing.Size(642, 426);
            this.gbTareas.TabIndex = 0;
            this.gbTareas.TabStop = false;
            this.gbTareas.Text = "Gurpo de Tareas";
            // 
            // dgTareas
            // 
            this.dgTareas.AutoGenerateColumns = false;
            this.dgTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgTareas.DataSource = this.tareaBindingSource1;
            this.dgTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTareas.Location = new System.Drawing.Point(3, 41);
            this.dgTareas.Name = "dgTareas";
            this.dgTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTareas.Size = new System.Drawing.Size(636, 382);
            this.dgTareas.TabIndex = 1;
            // 
            // tareaBindingSource1
            // 
            this.tareaBindingSource1.DataMember = "Tarea";
            this.tareaBindingSource1.DataSource = this.workflow_databaseDataSet;
            // 
            // workflow_databaseDataSet
            // 
            this.workflow_databaseDataSet.DataSetName = "Workflow_databaseDataSet";
            this.workflow_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panelContenido.Controls.Add(this.gbTareas);
            this.panelContenido.Location = new System.Drawing.Point(12, 12);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(642, 426);
            this.panelContenido.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "nombre";
            this.Nombre.Name = "Nombre";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.lvLeyenda);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbTareas.ResumeLayout(false);
            this.gbTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workflow_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ListView lvLeyenda;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAgregar;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.GroupBox gbTareas;
        private Workflow_databaseDataSet workflow_databaseDataSet;
        private System.Windows.Forms.BindingSource tareaBindingSource;
        private Workflow_databaseDataSetTableAdapters.TareaTableAdapter tareaTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        public System.Windows.Forms.DataGridView dgTareas;
        private System.Windows.Forms.BindingSource tareaBindingSource1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}