namespace programaFacturacion
{
    partial class frmReporteEstado : System.Windows.Forms.Form // Ensure inheritance from Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise.</param>
        protected override void Dispose(bool disposing) // Ensure Dispose is marked as override
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(383, 480);
            button1.Name = "button1";
            button1.Size = new Size(220, 66);
            button1.TabIndex = 0;
            button1.Text = "Generar Analisis";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 131);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 228);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Ganancia";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 177);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Costo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 23);
            textBox3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(500, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 362);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 59);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Resultado";
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(12, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 362);
            panel2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 62);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 7;
            label5.Text = "Intervalo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 177);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "Costo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 131);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 2;
            label6.Text = "Ventas";
            // 
            // button2
            // 
            button2.Location = new Point(128, 241);
            button2.Name = "button2";
            button2.Size = new Size(220, 66);
            button2.TabIndex = 8;
            button2.Text = "Hoy";
            button2.UseVisualStyleBackColor = true;
            button2.Click+= button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(128, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(128, 169);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(237, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 38);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 9;
            label8.Text = "Reporte de Estado";
            // 
            // frmReporteEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 611);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "frmReporteEstado";
            Text = "frmReporteEstado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
