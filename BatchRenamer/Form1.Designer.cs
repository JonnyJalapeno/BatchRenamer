namespace BatchRenamer
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
            Open = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            Execute = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Open
            // 
            Open.Location = new Point(273, 577);
            Open.Name = "Open";
            Open.Size = new Size(82, 41);
            Open.TabIndex = 0;
            Open.Text = "Wybierz pliki";
            Open.UseVisualStyleBackColor = true;
            Open.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "[Wybierz operację]", "Znajdź i zastąp" });
            comboBox1.Location = new Point(84, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 83);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(460, 200);
            textBox1.TabIndex = 3;
            // 
            // Execute
            // 
            Execute.Location = new Point(658, 583);
            Execute.Name = "Execute";
            Execute.Size = new Size(75, 35);
            Execute.TabIndex = 4;
            Execute.Text = "Wykonaj";
            Execute.UseVisualStyleBackColor = true;
            Execute.Click += Execute_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 333);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(460, 227);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 52);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 6;
            label1.Text = "Wybrane pliki:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 297);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Rezultat:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 630);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(Execute);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(Open);
            Name = "Form1";
            Text = "Batch Renamer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Open;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button Execute;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}