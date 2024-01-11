namespace _23.Intro_to_GUI
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
            button1 = new Button();
            lblname = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSurname = new TextBox();
            txtYear = new TextBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            lblFullname = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(364, 375);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(68, 27);
            lblname.Name = "lblname";
            lblname.Size = new Size(59, 25);
            lblname.TabIndex = 1;
            lblname.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(228, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(457, 31);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 98);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 3;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 180);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 4;
            label3.Text = "Year of birth";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(228, 98);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(457, 31);
            txtSurname.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(228, 180);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(131, 31);
            txtYear.TabIndex = 6;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(29, 319);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(121, 29);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "checkBox1";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(29, 354);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(121, 29);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "checkBox2";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(29, 390);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(121, 29);
            checkBox6.TabIndex = 11;
            checkBox6.Text = "checkBox3";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.BorderStyle = BorderStyle.Fixed3D;
            lblFullname.Location = new Point(322, 247);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(294, 27);
            lblFullname.TabIndex = 12;
            lblFullname.Text = "                                                        ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFullname);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(txtYear);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(lblname);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblname;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtSurname;
        private TextBox txtYear;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label lblFullname;
    }
}