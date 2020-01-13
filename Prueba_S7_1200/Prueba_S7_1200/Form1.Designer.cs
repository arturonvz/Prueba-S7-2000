namespace Prueba_S7_1200
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.bgwConnect1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.functionCallStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRead1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnConnect1
            // 
            this.btnConnect1.BackColor = System.Drawing.Color.LightGray;
            this.btnConnect1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConnect1.Location = new System.Drawing.Point(0, 0);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(105, 24);
            this.btnConnect1.TabIndex = 1;
            this.btnConnect1.Text = "Conectar";
            this.btnConnect1.UseVisualStyleBackColor = false;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // bgwConnect1
            // 
            this.bgwConnect1.WorkerSupportsCancellation = true;
            this.bgwConnect1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConnect1_DoWork);
            this.bgwConnect1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConnect1_RunWorkerCompleted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVariable,
            this.colDirección,
            this.colValor});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(978, 398);
            this.dataGridView1.TabIndex = 25;
            // 
            // colVariable
            // 
            this.colVariable.Frozen = true;
            this.colVariable.HeaderText = "Variable";
            this.colVariable.Name = "colVariable";
            this.colVariable.ReadOnly = true;
            this.colVariable.Width = 150;
            // 
            // colDirección
            // 
            this.colDirección.Frozen = true;
            this.colDirección.HeaderText = "Dirección";
            this.colDirección.Name = "colDirección";
            this.colDirección.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.Frozen = true;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 463);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC Báscula de Entrada";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 444);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.btnRead1);
            this.panel1.Controls.Add(this.btnConnect1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 24);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionCallStatusLabel1,
            this.connectionStatusLabel,
            this.connectionStatus1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(210, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(768, 24);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip";
            // 
            // functionCallStatusLabel1
            // 
            this.functionCallStatusLabel1.AutoSize = false;
            this.functionCallStatusLabel1.AutoToolTip = true;
            this.functionCallStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.functionCallStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.functionCallStatusLabel1.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.functionCallStatusLabel1.Name = "functionCallStatusLabel1";
            this.functionCallStatusLabel1.Size = new System.Drawing.Size(180, 19);
            this.functionCallStatusLabel1.Text = "Desconectado";
            this.functionCallStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(0, 0);
            // 
            // connectionStatus1
            // 
            this.connectionStatus1.AutoSize = false;
            this.connectionStatus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectionStatus1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.connectionStatus1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connectionStatus1.Name = "connectionStatus1";
            this.connectionStatus1.Size = new System.Drawing.Size(40, 19);
            this.connectionStatus1.Text = "Disconnected";
            // 
            // btnRead1
            // 
            this.btnRead1.BackColor = System.Drawing.Color.LightGray;
            this.btnRead1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRead1.Enabled = false;
            this.btnRead1.Location = new System.Drawing.Point(105, 0);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(105, 24);
            this.btnRead1.TabIndex = 25;
            this.btnRead1.Text = "Iniciar lectura";
            this.btnRead1.UseVisualStyleBackColor = false;
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1006, 469);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 469);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Prueba lectura S7-1200";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnConnect1;
        private System.ComponentModel.BackgroundWorker bgwConnect1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRead1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel functionCallStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatus1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

