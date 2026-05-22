namespace BDDistribuida
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            label1 = new Label();
            cmbLocalidad = new ComboBox();
            chkLocalidades = new CheckedListBox();
            chkTablas = new CheckedListBox();
            chkCampos = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbCampoCondicion = new ComboBox();
            cmbOperador = new ComboBox();
            txtValor = new TextBox();
            btnEjecutar = new Button();
            txtResultado = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Localidad actual";
            label1.Click += label1_Click;
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.BackColor = SystemColors.InactiveCaption;
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Items.AddRange(new object[] { "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8", "L9" });
            cmbLocalidad.Location = new Point(38, 26);
            cmbLocalidad.Margin = new Padding(3, 2, 3, 2);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(132, 23);
            cmbLocalidad.TabIndex = 1;
            // 
            // chkLocalidades
            // 
            chkLocalidades.BackColor = SystemColors.InactiveCaption;
            chkLocalidades.FormattingEnabled = true;
            chkLocalidades.Items.AddRange(new object[] { "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8", "L9" });
            chkLocalidades.Location = new Point(13, 50);
            chkLocalidades.Margin = new Padding(3, 2, 3, 2);
            chkLocalidades.Name = "chkLocalidades";
            chkLocalidades.Size = new Size(119, 76);
            chkLocalidades.TabIndex = 2;
            chkLocalidades.SelectedIndexChanged += chkLocalidades_SelectedIndexChanged;
            // 
            // chkTablas
            // 
            chkTablas.BackColor = SystemColors.InactiveCaption;
            chkTablas.Font = new Font("Lucida Bright", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTablas.FormattingEnabled = true;
            chkTablas.Items.AddRange(new object[] { "Alumno", "Carrera", "Materia", "Maestro", "Califica" });
            chkTablas.Location = new Point(151, 50);
            chkTablas.Margin = new Padding(3, 2, 3, 2);
            chkTablas.Name = "chkTablas";
            chkTablas.Size = new Size(113, 64);
            chkTablas.TabIndex = 3;
            chkTablas.ItemCheck += chkTablas_ItemCheck;
            chkTablas.SelectedIndexChanged += chkTablas_SelectedIndexChanged;
            // 
            // chkCampos
            // 
            chkCampos.BackColor = SystemColors.InactiveCaption;
            chkCampos.FormattingEnabled = true;
            chkCampos.Location = new Point(288, 50);
            chkCampos.Margin = new Padding(3, 2, 3, 2);
            chkCampos.Name = "chkCampos";
            chkCampos.Size = new Size(108, 76);
            chkCampos.TabIndex = 4;
            chkCampos.SelectedIndexChanged += chkCampos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 34);
            label2.Name = "label2";
            label2.Size = new Size(126, 14);
            label2.TabIndex = 5;
            label2.Text = "Act/Desc Localidades";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 34);
            label3.Name = "label3";
            label3.Size = new Size(87, 14);
            label3.TabIndex = 6;
            label3.Text = "Tablas (FROM)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(288, 34);
            label4.Name = "label4";
            label4.Size = new Size(103, 14);
            label4.TabIndex = 7;
            label4.Text = "Campos (SELECT)";
            // 
            // cmbCampoCondicion
            // 
            cmbCampoCondicion.BackColor = SystemColors.InactiveCaption;
            cmbCampoCondicion.FormattingEnabled = true;
            cmbCampoCondicion.Location = new Point(17, 49);
            cmbCampoCondicion.Margin = new Padding(3, 2, 3, 2);
            cmbCampoCondicion.Name = "cmbCampoCondicion";
            cmbCampoCondicion.Size = new Size(133, 23);
            cmbCampoCondicion.TabIndex = 8;
            cmbCampoCondicion.SelectedIndexChanged += cmbCampoCondicion_SelectedIndexChanged;
            // 
            // cmbOperador
            // 
            cmbOperador.BackColor = SystemColors.InactiveCaption;
            cmbOperador.FormattingEnabled = true;
            cmbOperador.Items.AddRange(new object[] { "=", "<", ">", "<=", ">=", "<>" });
            cmbOperador.Location = new Point(156, 49);
            cmbOperador.Margin = new Padding(3, 2, 3, 2);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(133, 23);
            cmbOperador.TabIndex = 9;
            cmbOperador.SelectedIndexChanged += cmbOperador_SelectedIndexChanged;
            // 
            // txtValor
            // 
            txtValor.BackColor = SystemColors.InactiveCaption;
            txtValor.Location = new Point(47, 272);
            txtValor.Margin = new Padding(3, 2, 3, 2);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(110, 23);
            txtValor.TabIndex = 10;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Font = new Font("Lucida Fax", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEjecutar.Location = new Point(59, 241);
            btnEjecutar.Margin = new Padding(3, 2, 3, 2);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(82, 22);
            btnEjecutar.TabIndex = 11;
            btnEjecutar.Text = "Ejecutar Consulta";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.InactiveCaption;
            txtResultado.Location = new Point(204, 241);
            txtResultado.Margin = new Padding(3, 2, 3, 2);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(169, 128);
            txtResultado.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 19);
            label5.Name = "label5";
            label5.Size = new Size(64, 14);
            label5.TabIndex = 13;
            label5.Text = "Condición";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(197, 19);
            label6.Name = "label6";
            label6.Size = new Size(59, 14);
            label6.TabIndex = 14;
            label6.Text = "Operador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(257, 221);
            label7.Name = "label7";
            label7.Size = new Size(61, 14);
            label7.TabIndex = 15;
            label7.Text = "Resultado";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(705, 307);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 17;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chkCampos);
            groupBox1.Controls.Add(chkTablas);
            groupBox1.Controls.Add(chkLocalidades);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(38, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 148);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Controls.Add(cmbOperador);
            groupBox2.Controls.Add(cmbCampoCondicion);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(494, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 100);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(853, 388);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txtResultado);
            Controls.Add(btnEjecutar);
            Controls.Add(txtValor);
            Controls.Add(cmbLocalidad);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            Text = "Sistema de Fragmentación Distribuida";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbLocalidad;
        private CheckedListBox chkLocalidades;
        private CheckedListBox chkTablas;
        private CheckedListBox chkCampos;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbCampoCondicion;
        private ComboBox cmbOperador;
        private TextBox txtValor;
        private Button btnEjecutar;
        private TextBox txtResultado;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
