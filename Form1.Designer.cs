namespace Guia8
{
    partial class Simulador
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoVerticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnElArc = new System.Windows.Forms.Button();
            this.btnEliminarVer = new System.Windows.Forms.Button();
            this.CBArco = new System.Windows.Forms.ComboBox();
            this.CBVertice = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnch = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CBNodoPartida = new System.Windows.Forms.ComboBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.btnDistancia = new System.Windows.Forms.Button();
            this.Pizarra = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Pizarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESAFÍO 2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoVerticeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // nuevoVerticeToolStripMenuItem
            // 
            this.nuevoVerticeToolStripMenuItem.Name = "nuevoVerticeToolStripMenuItem";
            this.nuevoVerticeToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.nuevoVerticeToolStripMenuItem.Text = "Nuevo Vertice";
            this.nuevoVerticeToolStripMenuItem.Click += new System.EventHandler(this.nuevoVerticeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnElArc);
            this.groupBox1.Controls.Add(this.btnEliminarVer);
            this.groupBox1.Controls.Add(this.CBArco);
            this.groupBox1.Controls.Add(this.CBVertice);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Arco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vértice:";
            // 
            // BtnElArc
            // 
            this.BtnElArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElArc.ForeColor = System.Drawing.Color.Black;
            this.BtnElArc.Location = new System.Drawing.Point(173, 57);
            this.BtnElArc.Margin = new System.Windows.Forms.Padding(4);
            this.BtnElArc.Name = "BtnElArc";
            this.BtnElArc.Size = new System.Drawing.Size(85, 28);
            this.BtnElArc.TabIndex = 2;
            this.BtnElArc.Text = "Eliminar";
            this.BtnElArc.UseVisualStyleBackColor = true;
            this.BtnElArc.Click += new System.EventHandler(this.BtnElArc_Click);
            // 
            // btnEliminarVer
            // 
            this.btnEliminarVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVer.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarVer.Location = new System.Drawing.Point(173, 21);
            this.btnEliminarVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarVer.Name = "btnEliminarVer";
            this.btnEliminarVer.Size = new System.Drawing.Size(85, 28);
            this.btnEliminarVer.TabIndex = 0;
            this.btnEliminarVer.Text = "Eliminar";
            this.btnEliminarVer.UseVisualStyleBackColor = true;
            this.btnEliminarVer.Click += new System.EventHandler(this.BtnEliminarVer_Click);
            // 
            // CBArco
            // 
            this.CBArco.FormattingEnabled = true;
            this.CBArco.Location = new System.Drawing.Point(69, 57);
            this.CBArco.Margin = new System.Windows.Forms.Padding(4);
            this.CBArco.Name = "CBArco";
            this.CBArco.Size = new System.Drawing.Size(95, 24);
            this.CBArco.TabIndex = 1;
            // 
            // CBVertice
            // 
            this.CBVertice.FormattingEnabled = true;
            this.CBVertice.Location = new System.Drawing.Point(69, 23);
            this.CBVertice.Margin = new System.Windows.Forms.Padding(4);
            this.CBVertice.Name = "CBVertice";
            this.CBVertice.Size = new System.Drawing.Size(95, 24);
            this.CBVertice.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnch);
            this.groupBox2.Controls.Add(this.btnProf);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CBNodoPartida);
            this.groupBox2.Location = new System.Drawing.Point(343, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 98);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorridos";
            // 
            // btnAnch
            // 
            this.btnAnch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnch.Location = new System.Drawing.Point(147, 63);
            this.btnAnch.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnch.Name = "btnAnch";
            this.btnAnch.Size = new System.Drawing.Size(101, 28);
            this.btnAnch.TabIndex = 5;
            this.btnAnch.Text = "Anchura";
            this.btnAnch.UseVisualStyleBackColor = true;
            this.btnAnch.Click += new System.EventHandler(this.BtnAnch_Click);
            // 
            // btnProf
            // 
            this.btnProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.Location = new System.Drawing.Point(20, 63);
            this.btnProf.Margin = new System.Windows.Forms.Padding(4);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(103, 28);
            this.btnProf.TabIndex = 3;
            this.btnProf.Text = "Profundidad";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.BtnProf_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nodo de partida:";
            // 
            // CBNodoPartida
            // 
            this.CBNodoPartida.FormattingEnabled = true;
            this.CBNodoPartida.Location = new System.Drawing.Point(147, 23);
            this.CBNodoPartida.Margin = new System.Windows.Forms.Padding(4);
            this.CBNodoPartida.Name = "CBNodoPartida";
            this.CBNodoPartida.Size = new System.Drawing.Size(95, 24);
            this.CBNodoPartida.TabIndex = 4;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(921, 627);
            this.lblRespuesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 17);
            this.lblRespuesta.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.BtnBuscar);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(628, 52);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(267, 98);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(63, 27);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 22);
            this.txtBuscar.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Vértice";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(172, 25);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(85, 28);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnDistancia
            // 
            this.btnDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistancia.Location = new System.Drawing.Point(924, 80);
            this.btnDistancia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDistancia.Name = "btnDistancia";
            this.btnDistancia.Size = new System.Drawing.Size(123, 49);
            this.btnDistancia.TabIndex = 6;
            this.btnDistancia.Text = "Distancia";
            this.btnDistancia.UseVisualStyleBackColor = true;
            // 
            // Pizarra
            // 
            this.Pizarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pizarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pizarra.Controls.Add(this.lblY);
            this.Pizarra.Controls.Add(this.lblX);
            this.Pizarra.Location = new System.Drawing.Point(30, 176);
            this.Pizarra.Margin = new System.Windows.Forms.Padding(4);
            this.Pizarra.Name = "Pizarra";
            this.Pizarra.Size = new System.Drawing.Size(865, 469);
            this.Pizarra.TabIndex = 0;
            this.Pizarra.Paint += new System.Windows.Forms.PaintEventHandler(this.Pizarra_Paint);
            this.Pizarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseDown);
            this.Pizarra.MouseLeave += new System.EventHandler(this.Pizarra_MouseLeave);
            this.Pizarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseMove);
            this.Pizarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pizarra_MouseUp);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.Color.White;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(42, 450);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(52, 17);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "label6";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.White;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Black;
            this.lblX.Location = new System.Drawing.Point(8, 450);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(52, 17);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "label5";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(911, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 100);
            this.listBox1.TabIndex = 12;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1154, 668);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Pizarra);
            this.Controls.Add(this.btnDistancia);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Simulador";
            this.Text = "Desafío 2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Pizarra.ResumeLayout(false);
            this.Pizarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoVerticeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnElArc;
        private System.Windows.Forms.Button btnEliminarVer;
        private System.Windows.Forms.ComboBox CBArco;
        private System.Windows.Forms.ComboBox CBVertice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAnch;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.ComboBox CBNodoPartida;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnDistancia;
        private System.Windows.Forms.Panel Pizarra;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.ListBox listBox1;
    }
}

