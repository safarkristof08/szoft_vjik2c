﻿namespace Adatkotes
{
    partial class FormCountry
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
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBox1.Location = new Point(22, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBox2.Location = new Point(22, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBox3.Location = new Point(22, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Country name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 109);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 166);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Area in km2";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(171, 242);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "&Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCountry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 274);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormCountry";
            Text = "FormCountry";
            Load += FormCountry_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private BindingSource bindingSource1;
    }
}