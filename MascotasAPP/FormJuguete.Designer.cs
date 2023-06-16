namespace MascotasAPP
{
    partial class FormJuguete
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.chk_disponible = new System.Windows.Forms.CheckBox();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxt_precio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(347, 211);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(178, 23);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // chk_disponible
            // 
            this.chk_disponible.AutoSize = true;
            this.chk_disponible.Location = new System.Drawing.Point(395, 179);
            this.chk_disponible.Name = "chk_disponible";
            this.chk_disponible.Size = new System.Drawing.Size(82, 19);
            this.chk_disponible.TabIndex = 18;
            this.chk_disponible.Text = "Disponible";
            this.chk_disponible.UseVisualStyleBackColor = true;
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Items.AddRange(new object[] {
            "Pelota",
            "Masticable",
            "Disco",
            "Chirriante",
            "Peluche"});
            this.cbo_tipo.Location = new System.Drawing.Point(347, 130);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(178, 23);
            this.cbo_tipo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo:";
            // 
            // mtxt_precio
            // 
            this.mtxt_precio.Location = new System.Drawing.Point(347, 92);
            this.mtxt_precio.Mask = "##9.##";
            this.mtxt_precio.Name = "mtxt_precio";
            this.mtxt_precio.Size = new System.Drawing.Size(178, 23);
            this.mtxt_precio.TabIndex = 15;
            this.mtxt_precio.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio:";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(347, 52);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(178, 23);
            this.txt_marca.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marca:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(347, 12);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 23);
            this.txt_nombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(708, 306);
            this.dataGridView1.TabIndex = 20;
            // 
            // FormJuguete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.chk_disponible);
            this.Controls.Add(this.cbo_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxt_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "FormJuguete";
            this.Text = "FormJuguete";
            this.Load += new System.EventHandler(this.FormJuguete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_guardar;
        private CheckBox chk_disponible;
        private ComboBox cbo_tipo;
        private Label label4;
        private MaskedTextBox mtxt_precio;
        private Label label3;
        private TextBox txt_marca;
        private Label label2;
        private TextBox txt_nombre;
        private Label label1;
        private DataGridView dataGridView1;
    }
}