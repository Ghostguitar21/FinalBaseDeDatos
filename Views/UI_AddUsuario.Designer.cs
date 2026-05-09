namespace BaseDeDatos.Views
{
    partial class UI_AddUsuario
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 34F);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(546, 62);
            label1.TabIndex = 0;
            label1.Text = "Registrar un usario nuevo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(485, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(36, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(485, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 135);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 3;
            label2.Text = "Primer nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(36, 211);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 4;
            label3.Text = "Primer apellido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(36, 311);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(485, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(36, 287);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 6;
            label4.Text = "Correo intitucional";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(36, 375);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(36, 399);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(485, 23);
            textBox4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(36, 456);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 10;
            label6.Text = "Programa";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(36, 480);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(485, 23);
            textBox5.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(36, 539);
            label7.Name = "label7";
            label7.Size = new Size(108, 21);
            label7.TabIndex = 12;
            label7.Text = "Tipo de usario";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 563);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(485, 23);
            comboBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F);
            button1.Location = new Point(753, 311);
            button1.Name = "button1";
            button1.Size = new Size(246, 61);
            button1.TabIndex = 14;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(36, 618);
            label8.Name = "label8";
            label8.Size = new Size(60, 21);
            label8.TabIndex = 16;
            label8.Text = "Codigo";
            
            // 
            // textBox6
            // 
            textBox6.Location = new Point(36, 642);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(485, 23);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // UI_AddUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 746);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UI_AddUsuario";
            Text = "UI_AddUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private ComboBox comboBox1;
        private Button button1;
        private Label label8;
        private TextBox textBox6;
    }
}