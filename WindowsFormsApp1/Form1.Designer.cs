namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.tx_raza = new System.Windows.Forms.TextBox();
            this.tx_edad = new System.Windows.Forms.TextBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.bt_crear = new System.Windows.Forms.Button();
            this.ch_vacunas = new System.Windows.Forms.CheckBox();
            this.tx_sexo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vacunas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Nac";
            // 
            // tx_id
            // 
            this.tx_id.Location = new System.Drawing.Point(108, 21);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(50, 20);
            this.tx_id.TabIndex = 7;
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(108, 55);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(100, 20);
            this.tx_nombre.TabIndex = 8;
            // 
            // tx_raza
            // 
            this.tx_raza.Location = new System.Drawing.Point(108, 94);
            this.tx_raza.Name = "tx_raza";
            this.tx_raza.Size = new System.Drawing.Size(100, 20);
            this.tx_raza.TabIndex = 9;
            // 
            // tx_edad
            // 
            this.tx_edad.Location = new System.Drawing.Point(108, 120);
            this.tx_edad.Name = "tx_edad";
            this.tx_edad.Size = new System.Drawing.Size(100, 20);
            this.tx_edad.TabIndex = 10;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Location = new System.Drawing.Point(108, 226);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(200, 20);
            this.dt_fecha.TabIndex = 12;
            // 
            // bt_crear
            // 
            this.bt_crear.Location = new System.Drawing.Point(21, 273);
            this.bt_crear.Name = "bt_crear";
            this.bt_crear.Size = new System.Drawing.Size(113, 23);
            this.bt_crear.TabIndex = 13;
            this.bt_crear.Text = "Crear objeto";
            this.bt_crear.UseVisualStyleBackColor = true;
            this.bt_crear.Click += new System.EventHandler(this.bt_crear_Click);
            // 
            // ch_vacunas
            // 
            this.ch_vacunas.AutoSize = true;
            this.ch_vacunas.Location = new System.Drawing.Point(108, 192);
            this.ch_vacunas.Name = "ch_vacunas";
            this.ch_vacunas.Size = new System.Drawing.Size(15, 14);
            this.ch_vacunas.TabIndex = 15;
            this.ch_vacunas.UseVisualStyleBackColor = true;
            // 
            // tx_sexo
            // 
            this.tx_sexo.Location = new System.Drawing.Point(108, 149);
            this.tx_sexo.Name = "tx_sexo";
            this.tx_sexo.Size = new System.Drawing.Size(100, 20);
            this.tx_sexo.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 281);
            this.dataGridView1.TabIndex = 18;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(164, 19);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 19;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(21, 319);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 20;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(113, 319);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 21;
            this.bt_editar.Text = "Actualizar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(21, 349);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(167, 23);
            this.bt_reset.TabIndex = 22;
            this.bt_reset.Text = "Limpiar";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SELECCIONE",
            "MACHO",
            "HEMBRA"});
            this.comboBox1.Location = new System.Drawing.Point(148, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 373);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 488);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tx_sexo);
            this.Controls.Add(this.ch_vacunas);
            this.Controls.Add(this.bt_crear);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.tx_edad);
            this.Controls.Add(this.tx_raza);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.TextBox tx_raza;
        private System.Windows.Forms.TextBox tx_edad;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Button bt_crear;
        private System.Windows.Forms.CheckBox ch_vacunas;
        private System.Windows.Forms.TextBox tx_sexo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

