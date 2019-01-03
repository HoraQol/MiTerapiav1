namespace Vista
{
    partial class frmVerHorarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerHorarios));
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mie = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jue = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vie = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.cboTerap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.gbxFiltro.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Controls.Add(this.btnDer);
            this.panelContenido.Controls.Add(this.btnIzq);
            this.panelContenido.Controls.Add(this.label4);
            this.panelContenido.Controls.Add(this.dtpHasta);
            this.panelContenido.Controls.Add(this.label3);
            this.panelContenido.Controls.Add(this.dtpDesde);
            this.panelContenido.Controls.Add(this.dgvHorario);
            this.panelContenido.Controls.Add(this.btnSeleccionar);
            this.panelContenido.Controls.Add(this.gbxFiltro);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 30);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(600, 570);
            this.panelContenido.TabIndex = 3;
            // 
            // btnDer
            // 
            this.btnDer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDer.FlatAppearance.BorderSize = 0;
            this.btnDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDer.ForeColor = System.Drawing.Color.White;
            this.btnDer.Location = new System.Drawing.Point(440, 112);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(25, 25);
            this.btnDer.TabIndex = 16;
            this.btnDer.Text = ">";
            this.btnDer.UseVisualStyleBackColor = false;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzq.Enabled = false;
            this.btnIzq.FlatAppearance.BorderSize = 0;
            this.btnIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzq.ForeColor = System.Drawing.Color.White;
            this.btnIzq.Location = new System.Drawing.Point(405, 112);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(25, 25);
            this.btnIzq.TabIndex = 15;
            this.btnIzq.Text = "<";
            this.btnIzq.UseVisualStyleBackColor = false;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "al:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(265, 115);
            this.dtpHasta.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(125, 20);
            this.dtpHasta.TabIndex = 13;
            this.dtpHasta.Value = new System.DateTime(2019, 1, 12, 23, 59, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Semana del:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(115, 115);
            this.dtpDesde.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(125, 20);
            this.dtpDesde.TabIndex = 11;
            this.dtpDesde.Value = new System.DateTime(2019, 1, 7, 0, 0, 0, 0);
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hora,
            this.lun,
            this.mar,
            this.mie,
            this.jue,
            this.vie});
            this.dgvHorario.Location = new System.Drawing.Point(25, 160);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.RowHeadersVisible = false;
            this.dgvHorario.RowHeadersWidth = 40;
            this.dgvHorario.RowTemplate.Height = 45;
            this.dgvHorario.Size = new System.Drawing.Size(550, 383);
            this.dgvHorario.TabIndex = 10;
            // 
            // hora
            // 
            this.hora.HeaderText = "";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Width = 72;
            // 
            // lun
            // 
            this.lun.HeaderText = "LUNES";
            this.lun.Name = "lun";
            this.lun.ReadOnly = true;
            this.lun.Width = 95;
            // 
            // mar
            // 
            this.mar.HeaderText = "MARTES";
            this.mar.Name = "mar";
            this.mar.ReadOnly = true;
            this.mar.Width = 95;
            // 
            // mie
            // 
            this.mie.HeaderText = "MIÉRCOLES";
            this.mie.Name = "mie";
            this.mie.ReadOnly = true;
            this.mie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mie.Width = 95;
            // 
            // jue
            // 
            this.jue.HeaderText = "JUEVES";
            this.jue.Name = "jue";
            this.jue.ReadOnly = true;
            this.jue.Width = 95;
            // 
            // vie
            // 
            this.vie.HeaderText = "VIERNES";
            this.vie.Name = "vie";
            this.vie.ReadOnly = true;
            this.vie.Width = 95;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(475, 112);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 25);
            this.btnSeleccionar.TabIndex = 9;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.cboTerap);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltro.Location = new System.Drawing.Point(25, 25);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(550, 70);
            this.gbxFiltro.TabIndex = 0;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Opciones de filtrado";
            // 
            // cboTerap
            // 
            this.cboTerap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerap.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTerap.FormattingEnabled = true;
            this.cboTerap.Location = new System.Drawing.Point(100, 25);
            this.cboTerap.Name = "cboTerap";
            this.cboTerap.Size = new System.Drawing.Size(425, 21);
            this.cboTerap.TabIndex = 1;
            this.cboTerap.SelectedIndexChanged += new System.EventHandler(this.cboTerap_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Terapeuta:";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(600, 30);
            this.panelTitulo.TabIndex = 2;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Disponibilidad de sesiones";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(575, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmVerHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerHorarios";
            this.Text = "frmVerHorarios";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.ComboBox cboTerap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewButtonColumn lun;
        private System.Windows.Forms.DataGridViewButtonColumn mar;
        private System.Windows.Forms.DataGridViewButtonColumn mie;
        private System.Windows.Forms.DataGridViewButtonColumn jue;
        private System.Windows.Forms.DataGridViewButtonColumn vie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnIzq;
    }
}