namespace MascotasAPP
{
    partial class FormMascota
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.chk_disponible = new System.Windows.Forms.CheckBox();
            this.mtxt_precio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_especie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxt_edad = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(708, 303);
            this.dataGridView1.TabIndex = 21;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(347, 206);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(178, 23);
            this.btn_guardar.TabIndex = 20;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // chk_disponible
            // 
            this.chk_disponible.AutoSize = true;
            this.chk_disponible.Location = new System.Drawing.Point(395, 174);
            this.chk_disponible.Name = "chk_disponible";
            this.chk_disponible.Size = new System.Drawing.Size(82, 19);
            this.chk_disponible.TabIndex = 19;
            this.chk_disponible.Text = "Disponible";
            this.chk_disponible.UseVisualStyleBackColor = true;
            // 
            // mtxt_precio
            // 
            this.mtxt_precio.Location = new System.Drawing.Point(347, 144);
            this.mtxt_precio.Mask = "##9.##";
            this.mtxt_precio.Name = "mtxt_precio";
            this.mtxt_precio.Size = new System.Drawing.Size(178, 23);
            this.mtxt_precio.TabIndex = 16;
            this.mtxt_precio.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio:";
            // 
            // txt_especie
            // 
            this.txt_especie.Location = new System.Drawing.Point(347, 60);
            this.txt_especie.Name = "txt_especie";
            this.txt_especie.Size = new System.Drawing.Size(178, 23);
            this.txt_especie.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Especie:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(347, 18);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 23);
            this.txt_nombre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Edad:";
            // 
            // mtxt_edad
            // 
            this.mtxt_edad.Location = new System.Drawing.Point(347, 102);
            this.mtxt_edad.Mask = "##9.#";
            this.mtxt_edad.Name = "mtxt_edad";
            this.mtxt_edad.Size = new System.Drawing.Size(178, 23);
            this.mtxt_edad.TabIndex = 24;
            this.mtxt_edad.ValidatingType = typeof(int);
            // 
            // FormMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.mtxt_edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.chk_disponible);
            this.Controls.Add(this.mtxt_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_especie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "FormMascota";
            this.Text = "FormMascota";
            this.Load += new System.EventHandler(this.FormMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_guardar;
        private CheckBox chk_disponible;
        private MaskedTextBox mtxt_precio;
        private Label label3;
        private TextBox txt_especie;
        private Label label2;
        private TextBox txt_nombre;
        private Label label1;
        private Label label4;
        private MaskedTextBox mtxt_edad;
    }
}