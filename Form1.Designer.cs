﻿namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btn_guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tx_nombre = new TextBox();
            tx_apellido = new TextBox();
            tx_dinero = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            LVClientes = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(226, 187);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(94, 29);
            btn_guardar.TabIndex = 4;
            btn_guardar.Text = "&Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 61);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 93);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Dinero:";
            // 
            // tx_nombre
            // 
            tx_nombre.Location = new Point(93, 29);
            tx_nombre.Name = "tx_nombre";
            tx_nombre.Size = new Size(191, 27);
            tx_nombre.TabIndex = 1;
            // 
            // tx_apellido
            // 
            tx_apellido.Location = new Point(93, 61);
            tx_apellido.Name = "tx_apellido";
            tx_apellido.Size = new Size(191, 27);
            tx_apellido.TabIndex = 2;
            // 
            // tx_dinero
            // 
            tx_dinero.Location = new Point(93, 93);
            tx_dinero.Name = "tx_dinero";
            tx_dinero.Size = new Size(94, 27);
            tx_dinero.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tx_apellido);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_guardar);
            groupBox1.Controls.Add(tx_dinero);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tx_nombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(23, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 277);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LVClientes);
            groupBox2.Location = new Point(344, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 221);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado Clientes";
            // 
            // LVClientes
            // 
            LVClientes.ContextMenuStrip = contextMenuStrip1;
            LVClientes.FullRowSelect = true;
            LVClientes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            LVClientes.HoverSelection = true;
            LVClientes.Location = new Point(12, 40);
            LVClientes.Name = "LVClientes";
            LVClientes.Size = new Size(286, 175);
            LVClientes.TabIndex = 0;
            LVClientes.UseCompatibleStateImageBehavior = false;
            LVClientes.ColumnWidthChanging += LVClientes_ColumnWidthChanging;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, modificarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 52);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(142, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(142, 24);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(214, 242);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 307);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado Clientes";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_guardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tx_nombre;
        private TextBox tx_apellido;
        private TextBox tx_dinero;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView LVClientes;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
    }
}
