namespace WinFormsApp1
{
    partial class Ventas
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
            cb_clientes = new ComboBox();
            cb_vehiculo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            tx_precio = new TextBox();
            button2 = new Button();
            lVventas = new ListView();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cb_clientes
            // 
            cb_clientes.FormattingEnabled = true;
            cb_clientes.Location = new Point(18, 44);
            cb_clientes.Margin = new Padding(3, 4, 3, 4);
            cb_clientes.Name = "cb_clientes";
            cb_clientes.Size = new Size(209, 28);
            cb_clientes.TabIndex = 0;
            // 
            // cb_vehiculo
            // 
            cb_vehiculo.FormattingEnabled = true;
            cb_vehiculo.Location = new Point(304, 47);
            cb_vehiculo.Margin = new Padding(3, 4, 3, 4);
            cb_vehiculo.Name = "cb_vehiculo";
            cb_vehiculo.Size = new Size(187, 28);
            cb_vehiculo.TabIndex = 1;
            cb_vehiculo.SelectedIndexChanged += cb_vehiculo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 23);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccione Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 20);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 3;
            label2.Text = "Seleccione Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(345, 118);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(111, 45);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 103);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // tx_precio
            // 
            tx_precio.Location = new Point(66, 127);
            tx_precio.Margin = new Padding(3, 4, 3, 4);
            tx_precio.Name = "tx_precio";
            tx_precio.Size = new Size(131, 27);
            tx_precio.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(496, 350);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lVventas
            // 
            lVventas.Location = new Point(81, 182);
            lVventas.Name = "lVventas";
            lVventas.Size = new Size(399, 121);
            lVventas.TabIndex = 9;
            lVventas.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_clientes);
            groupBox1.Controls.Add(lVventas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tx_precio);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cb_vehiculo);
            groupBox1.Location = new Point(29, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 325);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 430);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cb_clientes;
        private ComboBox cb_vehiculo;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox tx_precio;
        private Button button2;
        private ListView lVventas;
        private GroupBox groupBox1;
    }
}