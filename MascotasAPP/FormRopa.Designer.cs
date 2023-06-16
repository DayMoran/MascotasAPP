namespace MascotasAPP
{
    partial class FormRopa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_precio = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_talla = new System.Windows.Forms.ComboBox();
            this.chk_disponible = new System.Windows.Forms.CheckBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(347, 12);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 23);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(347, 52);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(178, 23);
            this.txt_marca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // mtxt_precio
            // 
            this.mtxt_precio.Location = new System.Drawing.Point(347, 92);
            this.mtxt_precio.Mask = "##9.##";
            this.mtxt_precio.Name = "mtxt_precio";
            this.mtxt_precio.Size = new System.Drawing.Size(178, 23);
            this.mtxt_precio.TabIndex = 5;
            this.mtxt_precio.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Talla:";
            // 
            // cbo_talla
            // 
            this.cbo_talla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_talla.FormattingEnabled = true;
            this.cbo_talla.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cbo_talla.Location = new System.Drawing.Point(347, 133);
            this.cbo_talla.Name = "cbo_talla";
            this.cbo_talla.Size = new System.Drawing.Size(178, 23);
            this.cbo_talla.TabIndex = 7;
            // 
            // chk_disponible
            // 
            this.chk_disponible.AutoSize = true;
            this.chk_disponible.Location = new System.Drawing.Point(395, 168);
            this.chk_disponible.Name = "chk_disponible";
            this.chk_disponible.Size = new System.Drawing.Size(82, 19);
            this.chk_disponible.TabIndex = 8;
            this.chk_disponible.Text = "Disponible";
            this.chk_disponible.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(347, 200);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(178, 23);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(708, 303);
            this.dataGridView1.TabIndex = 10;
            // 
            // FormRopa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.chk_disponible);
            this.Controls.Add(this.cbo_talla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxt_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "FormRopa";
            this.Text = "FormRopa";
            this.Load += new System.EventHandler(this.FormRopa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_nombre;
        private TextBox txt_marca;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtxt_precio;
        private Label label4;
        private ComboBox cbo_talla;
        private CheckBox chk_disponible;
        private Button btn_guardar;
        private DataGridView dataGridView1;
    }
}