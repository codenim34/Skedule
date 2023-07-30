namespace Skedule_v3
{
    partial class SelfAssesment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttondash = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subjecttext = new System.Windows.Forms.TextBox();
            this.dgw_self = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quiztext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.midtext = new System.Windows.Forms.TextBox();
            this.finaltext = new System.Windows.Forms.TextBox();
            this.attendancetext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_self)).BeginInit();
            this.SuspendLayout();
            // 
            // buttondash
            // 
            this.buttondash.BackColor = System.Drawing.Color.Transparent;
            this.buttondash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondash.FlatAppearance.BorderSize = 0;
            this.buttondash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondash.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondash.ForeColor = System.Drawing.Color.Transparent;
            this.buttondash.Image = global::Skedule_v3.Properties.Resources.arrow_92_32;
            this.buttondash.Location = new System.Drawing.Point(12, 21);
            this.buttondash.Name = "buttondash";
            this.buttondash.Size = new System.Drawing.Size(36, 36);
            this.buttondash.TabIndex = 86;
            this.buttondash.UseVisualStyleBackColor = false;
            this.buttondash.Click += new System.EventHandler(this.buttondash_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_update.Location = new System.Drawing.Point(709, 395);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(73, 31);
            this.btn_update.TabIndex = 83;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_remove.Location = new System.Drawing.Point(630, 430);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(152, 31);
            this.btn_remove.TabIndex = 82;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.Location = new System.Drawing.Point(630, 395);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 31);
            this.addButton.TabIndex = 81;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subjecttext
            // 
            this.subjecttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjecttext.Location = new System.Drawing.Point(87, 398);
            this.subjecttext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjecttext.Name = "subjecttext";
            this.subjecttext.Size = new System.Drawing.Size(153, 26);
            this.subjecttext.TabIndex = 79;
            // 
            // dgw_self
            // 
            this.dgw_self.AllowUserToAddRows = false;
            this.dgw_self.AllowUserToDeleteRows = false;
            this.dgw_self.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_self.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(211)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_self.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw_self.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_self.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgw_self.Location = new System.Drawing.Point(12, 64);
            this.dgw_self.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgw_self.Name = "dgw_self";
            this.dgw_self.ReadOnly = true;
            this.dgw_self.RowHeadersVisible = false;
            this.dgw_self.RowHeadersWidth = 51;
            this.dgw_self.RowTemplate.Height = 40;
            this.dgw_self.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_self.Size = new System.Drawing.Size(846, 318);
            this.dgw_self.TabIndex = 77;
            this.dgw_self.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_self_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(19, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Subject";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogin.Location = new System.Drawing.Point(52, 20);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(213, 37);
            this.labelLogin.TabIndex = 73;
            this.labelLogin.Text = "Self_Assesment";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(261, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Quiz";
            // 
            // quiztext
            // 
            this.quiztext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiztext.Location = new System.Drawing.Point(306, 398);
            this.quiztext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quiztext.Name = "quiztext";
            this.quiztext.Size = new System.Drawing.Size(95, 26);
            this.quiztext.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(265, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Mid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(427, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(427, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Attendance";
            // 
            // midtext
            // 
            this.midtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtext.Location = new System.Drawing.Point(306, 430);
            this.midtext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.midtext.Name = "midtext";
            this.midtext.Size = new System.Drawing.Size(95, 26);
            this.midtext.TabIndex = 92;
            // 
            // finaltext
            // 
            this.finaltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finaltext.Location = new System.Drawing.Point(522, 398);
            this.finaltext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finaltext.Name = "finaltext";
            this.finaltext.Size = new System.Drawing.Size(87, 26);
            this.finaltext.TabIndex = 93;
            // 
            // attendancetext
            // 
            this.attendancetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendancetext.Location = new System.Drawing.Point(522, 430);
            this.attendancetext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attendancetext.Name = "attendancetext";
            this.attendancetext.Size = new System.Drawing.Size(87, 26);
            this.attendancetext.TabIndex = 94;
            // 
            // SelfAssesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(869, 492);
            this.Controls.Add(this.attendancetext);
            this.Controls.Add(this.finaltext);
            this.Controls.Add(this.midtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quiztext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttondash);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subjecttext);
            this.Controls.Add(this.dgw_self);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelfAssesment";
            this.Text = "SelfAssesment";
            this.Load += new System.EventHandler(this.SelfAssesment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_self)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttondash;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox subjecttext;
        private System.Windows.Forms.DataGridView dgw_self;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quiztext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox midtext;
        private System.Windows.Forms.TextBox finaltext;
        private System.Windows.Forms.TextBox attendancetext;
    }
}