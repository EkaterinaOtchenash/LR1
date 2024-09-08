namespace lr1
{
    partial class FormAddUsers
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
            this.BindingSourceRole = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.PhonemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.second_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceRole)).BeginInit();
            this.SuspendLayout();
            // 
            // BindingSourceRole
            // 
            this.BindingSourceRole.DataSource = typeof(lr1.DBContext.Roles);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(173)))), ((int)(((byte)(133)))));
            this.ButtonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.ButtonBack.Location = new System.Drawing.Point(16, 16);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(165, 66);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(420, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new user";
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.DataSource = this.BindingSourceRole;
            this.roleIDComboBox.DisplayMember = "Name";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(642, 278);
            this.roleIDComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(184, 29);
            this.roleIDComboBox.TabIndex = 2;
            this.roleIDComboBox.ValueMember = "ID";
            // 
            // PhonemaskedTextBox
            // 
            this.PhonemaskedTextBox.Location = new System.Drawing.Point(230, 411);
            this.PhonemaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhonemaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.PhonemaskedTextBox.Name = "PhonemaskedTextBox";
            this.PhonemaskedTextBox.Size = new System.Drawing.Size(184, 30);
            this.PhonemaskedTextBox.TabIndex = 3;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(173)))), ((int)(((byte)(133)))));
            this.ButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.ButtonAdd.Location = new System.Drawing.Point(918, 520);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(165, 55);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Checked = true;
            this.radioButtonMen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.radioButtonMen.Location = new System.Drawing.Point(642, 346);
            this.radioButtonMen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(72, 25);
            this.radioButtonMen.TabIndex = 5;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "Male";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.radioButtonWoman.Location = new System.Drawing.Point(758, 346);
            this.radioButtonWoman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(92, 25);
            this.radioButtonWoman.TabIndex = 6;
            this.radioButtonWoman.Text = "Female";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(230, 223);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(184, 30);
            this.passwordTextBox.TabIndex = 7;
            // 
            // second_NameTextBox
            // 
            this.second_NameTextBox.Location = new System.Drawing.Point(642, 219);
            this.second_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.second_NameTextBox.Name = "second_NameTextBox";
            this.second_NameTextBox.Size = new System.Drawing.Size(184, 30);
            this.second_NameTextBox.TabIndex = 8;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Location = new System.Drawing.Point(642, 172);
            this.first_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(184, 30);
            this.first_NameTextBox.TabIndex = 9;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(230, 176);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(184, 30);
            this.loginTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(230, 346);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(184, 30);
            this.emailTextBox.TabIndex = 11;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Location = new System.Drawing.Point(230, 281);
            this.passwordTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(184, 30);
            this.passwordTextBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(121, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label3.Location = new System.Drawing.Point(477, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "second name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(539, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label5.Location = new System.Drawing.Point(543, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label6.Location = new System.Drawing.Point(43, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "phone number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label7.Location = new System.Drawing.Point(115, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "e-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label8.Location = new System.Drawing.Point(16, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "confirm password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label9.Location = new System.Drawing.Point(80, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(75)))));
            this.label10.Location = new System.Drawing.Point(517, 345);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "gender";
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1100, 591);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.second_NameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.radioButtonMen);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.PhonemaskedTextBox);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonBack);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource BindingSourceRole;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private System.Windows.Forms.MaskedTextBox PhonemaskedTextBox;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox second_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}