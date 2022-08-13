namespace ordenamiento
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputInt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioReal128 = new System.Windows.Forms.RadioButton();
            this.radioString32 = new System.Windows.Forms.RadioButton();
            this.radioReal32 = new System.Windows.Forms.RadioButton();
            this.radioString8 = new System.Windows.Forms.RadioButton();
            this.radioInt64 = new System.Windows.Forms.RadioButton();
            this.radioInt16 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioQuick = new System.Windows.Forms.RadioButton();
            this.radioQuickI = new System.Windows.Forms.RadioButton();
            this.radioMerge = new System.Windows.Forms.RadioButton();
            this.radioSeleccion = new System.Windows.Forms.RadioButton();
            this.radioBurbuja = new System.Windows.Forms.RadioButton();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 372);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(933, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ordenar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputInt
            // 
            this.inputInt.Location = new System.Drawing.Point(709, 69);
            this.inputInt.Name = "inputInt";
            this.inputInt.Size = new System.Drawing.Size(401, 22);
            this.inputInt.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioReal128);
            this.groupBox2.Controls.Add(this.radioString32);
            this.groupBox2.Controls.Add(this.radioReal32);
            this.groupBox2.Controls.Add(this.radioString8);
            this.groupBox2.Controls.Add(this.radioInt64);
            this.groupBox2.Controls.Add(this.radioInt16);
            this.groupBox2.Location = new System.Drawing.Point(709, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 179);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de vector";
            // 
            // radioReal128
            // 
            this.radioReal128.AutoSize = true;
            this.radioReal128.Location = new System.Drawing.Point(30, 153);
            this.radioReal128.Name = "radioReal128";
            this.radioReal128.Size = new System.Drawing.Size(105, 20);
            this.radioReal128.TabIndex = 8;
            this.radioReal128.Text = "REALES 128";
            this.radioReal128.UseVisualStyleBackColor = true;
            // 
            // radioString32
            // 
            this.radioString32.AutoSize = true;
            this.radioString32.Location = new System.Drawing.Point(30, 101);
            this.radioString32.Name = "radioString32";
            this.radioString32.Size = new System.Drawing.Size(96, 20);
            this.radioString32.TabIndex = 7;
            this.radioString32.Text = "STRING 32";
            this.radioString32.UseVisualStyleBackColor = true;
            // 
            // radioReal32
            // 
            this.radioReal32.AutoSize = true;
            this.radioReal32.Location = new System.Drawing.Point(30, 127);
            this.radioReal32.Name = "radioReal32";
            this.radioReal32.Size = new System.Drawing.Size(98, 20);
            this.radioReal32.TabIndex = 6;
            this.radioReal32.Text = "REALES 32";
            this.radioReal32.UseVisualStyleBackColor = true;
            // 
            // radioString8
            // 
            this.radioString8.AutoSize = true;
            this.radioString8.Location = new System.Drawing.Point(30, 75);
            this.radioString8.Name = "radioString8";
            this.radioString8.Size = new System.Drawing.Size(89, 20);
            this.radioString8.TabIndex = 5;
            this.radioString8.Text = "STRING 8";
            this.radioString8.UseVisualStyleBackColor = true;
            // 
            // radioInt64
            // 
            this.radioInt64.AutoSize = true;
            this.radioInt64.Location = new System.Drawing.Point(30, 51);
            this.radioInt64.Name = "radioInt64";
            this.radioInt64.Size = new System.Drawing.Size(64, 20);
            this.radioInt64.TabIndex = 4;
            this.radioInt64.Text = "INT64";
            this.radioInt64.UseVisualStyleBackColor = true;
            // 
            // radioInt16
            // 
            this.radioInt16.AutoSize = true;
            this.radioInt16.Checked = true;
            this.radioInt16.Location = new System.Drawing.Point(30, 25);
            this.radioInt16.Name = "radioInt16";
            this.radioInt16.Size = new System.Drawing.Size(64, 20);
            this.radioInt16.TabIndex = 3;
            this.radioInt16.TabStop = true;
            this.radioInt16.Text = "INT16";
            this.radioInt16.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad de elementos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioQuick);
            this.groupBox3.Controls.Add(this.radioQuickI);
            this.groupBox3.Controls.Add(this.radioMerge);
            this.groupBox3.Controls.Add(this.radioSeleccion);
            this.groupBox3.Controls.Add(this.radioBurbuja);
            this.groupBox3.Location = new System.Drawing.Point(933, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 181);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metodo de Ordenamiento";
            // 
            // radioQuick
            // 
            this.radioQuick.AutoSize = true;
            this.radioQuick.Location = new System.Drawing.Point(6, 59);
            this.radioQuick.Name = "radioQuick";
            this.radioQuick.Size = new System.Drawing.Size(62, 20);
            this.radioQuick.TabIndex = 7;
            this.radioQuick.Text = "Quick";
            this.radioQuick.UseVisualStyleBackColor = true;
            // 
            // radioQuickI
            // 
            this.radioQuickI.AutoSize = true;
            this.radioQuickI.Location = new System.Drawing.Point(6, 137);
            this.radioQuickI.Name = "radioQuickI";
            this.radioQuickI.Size = new System.Drawing.Size(112, 20);
            this.radioQuickI.TabIndex = 6;
            this.radioQuickI.Text = "Quick iterativo";
            this.radioQuickI.UseVisualStyleBackColor = true;
            // 
            // radioMerge
            // 
            this.radioMerge.AutoSize = true;
            this.radioMerge.Location = new System.Drawing.Point(6, 111);
            this.radioMerge.Name = "radioMerge";
            this.radioMerge.Size = new System.Drawing.Size(67, 20);
            this.radioMerge.TabIndex = 5;
            this.radioMerge.Text = "Merge";
            this.radioMerge.UseVisualStyleBackColor = true;
            // 
            // radioSeleccion
            // 
            this.radioSeleccion.AutoSize = true;
            this.radioSeleccion.Location = new System.Drawing.Point(6, 85);
            this.radioSeleccion.Name = "radioSeleccion";
            this.radioSeleccion.Size = new System.Drawing.Size(88, 20);
            this.radioSeleccion.TabIndex = 4;
            this.radioSeleccion.Text = "Seleccion";
            this.radioSeleccion.UseVisualStyleBackColor = true;
            // 
            // radioBurbuja
            // 
            this.radioBurbuja.AutoSize = true;
            this.radioBurbuja.Checked = true;
            this.radioBurbuja.Location = new System.Drawing.Point(6, 33);
            this.radioBurbuja.Name = "radioBurbuja";
            this.radioBurbuja.Size = new System.Drawing.Size(74, 20);
            this.radioBurbuja.TabIndex = 3;
            this.radioBurbuja.TabStop = true;
            this.radioBurbuja.Text = "Burbuja";
            this.radioBurbuja.UseVisualStyleBackColor = true;
            // 
            // listInfo
            // 
            this.listInfo.FormattingEnabled = true;
            this.listInfo.ItemHeight = 16;
            this.listInfo.Location = new System.Drawing.Point(463, 54);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(240, 372);
            this.listInfo.TabIndex = 10;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(243, 54);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(206, 372);
            this.listBox3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vector ordenado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.inputInt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputInt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioReal32;
        private System.Windows.Forms.RadioButton radioString8;
        private System.Windows.Forms.RadioButton radioInt64;
        private System.Windows.Forms.RadioButton radioInt16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioQuick;
        private System.Windows.Forms.RadioButton radioQuickI;
        private System.Windows.Forms.RadioButton radioMerge;
        private System.Windows.Forms.RadioButton radioSeleccion;
        private System.Windows.Forms.RadioButton radioBurbuja;
        private System.Windows.Forms.ListBox listInfo;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioReal128;
        private System.Windows.Forms.RadioButton radioString32;
    }
}

