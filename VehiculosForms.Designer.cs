namespace WinFormsApp1
{
    partial class VehiculosForms
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            bt_guardar = new Button();
            tx_marca = new TextBox();
            tx_modelo = new TextBox();
            tx_año = new TextBox();
            tx_km = new TextBox();
            tx_Precio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            LvVehiculos = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            modificarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_guardar);
            groupBox1.Controls.Add(tx_marca);
            groupBox1.Controls.Add(tx_modelo);
            groupBox1.Controls.Add(tx_año);
            groupBox1.Controls.Add(tx_km);
            groupBox1.Controls.Add(tx_Precio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 313);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Vehículo";
            // 
            // bt_guardar
            // 
            bt_guardar.Location = new Point(204, 278);
            bt_guardar.Name = "bt_guardar";
            bt_guardar.Size = new Size(94, 29);
            bt_guardar.TabIndex = 6;
            bt_guardar.Text = "Guardar";
            bt_guardar.UseVisualStyleBackColor = true;
            bt_guardar.Click += bt_guardar_Click;
            // 
            // tx_marca
            // 
            tx_marca.Location = new Point(101, 41);
            tx_marca.Name = "tx_marca";
            tx_marca.Size = new Size(193, 27);
            tx_marca.TabIndex = 1;
            // 
            // tx_modelo
            // 
            tx_modelo.Location = new Point(101, 86);
            tx_modelo.Name = "tx_modelo";
            tx_modelo.Size = new Size(193, 27);
            tx_modelo.TabIndex = 2;
            // 
            // tx_año
            // 
            tx_año.Location = new Point(101, 129);
            tx_año.Name = "tx_año";
            tx_año.Size = new Size(193, 27);
            tx_año.TabIndex = 3;
            // 
            // tx_km
            // 
            tx_km.Location = new Point(105, 172);
            tx_km.Name = "tx_km";
            tx_km.Size = new Size(193, 27);
            tx_km.TabIndex = 4;
            // 
            // tx_Precio
            // 
            tx_Precio.Location = new Point(105, 219);
            tx_Precio.Name = "tx_Precio";
            tx_Precio.Size = new Size(193, 27);
            tx_Precio.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 222);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 172);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Kilometraje:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 132);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Año:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 93);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 44);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LvVehiculos);
            groupBox2.Location = new Point(341, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 307);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado";
            // 
            // LvVehiculos
            // 
            LvVehiculos.ContextMenuStrip = contextMenuStrip1;
            LvVehiculos.Dock = DockStyle.Fill;
            LvVehiculos.FullRowSelect = true;
            LvVehiculos.Location = new Point(3, 23);
            LvVehiculos.Name = "LvVehiculos";
            LvVehiculos.Size = new Size(231, 281);
            LvVehiculos.TabIndex = 0;
            LvVehiculos.UseCompatibleStateImageBehavior = false;
            LvVehiculos.View = View.List;
            LvVehiculos.ColumnWidthChanging += LvVehiculos_ColumnWidthChanging;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { modificarToolStripMenuItem, modificarToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 52);
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(142, 24);
            modificarToolStripMenuItem.Text = "Eliminar";
            modificarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click_1;
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(142, 24);
            modificarToolStripMenuItem1.Text = "Modificar";
            modificarToolStripMenuItem1.Click += modificarToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(488, 342);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VehiculosForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 386);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "VehiculosForms";
            Text = "VehiculosForms";
            Load += VehiculosForms_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_guardar;
        private TextBox tx_marca;
        private TextBox tx_modelo;
        private TextBox tx_año;
        private TextBox tx_km;
        private TextBox tx_Precio;
        private GroupBox groupBox2;
        private ListView LvVehiculos;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private Button button1;
    }
}