﻿namespace Skedule_v3
{
    partial class Assignment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttondash = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tasktext = new System.Windows.Forms.RichTextBox();
            this.subjecttext = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgw_assignment = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teachertext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_assignment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttondash
            // 
            this.buttondash.BackColor = System.Drawing.Color.Transparent;
            this.buttondash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondash.FlatAppearance.BorderSize = 0;
            this.buttondash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondash.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondash.ForeColor = System.Drawing.SystemColors.Control;
            this.buttondash.Image = global::Skedule_v3.Properties.Resources.arrow_92_32;
            this.buttondash.Location = new System.Drawing.Point(13, 14);
            this.buttondash.Name = "buttondash";
            this.buttondash.Size = new System.Drawing.Size(36, 36);
            this.buttondash.TabIndex = 70;
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
            this.btn_update.Location = new System.Drawing.Point(773, 395);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(73, 31);
            this.btn_update.TabIndex = 67;
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
            this.btn_remove.Location = new System.Drawing.Point(694, 433);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(152, 31);
            this.btn_remove.TabIndex = 66;
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
            this.addButton.Location = new System.Drawing.Point(694, 395);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 31);
            this.addButton.TabIndex = 65;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tasktext
            // 
            this.tasktext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasktext.Location = new System.Drawing.Point(88, 427);
            this.tasktext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tasktext.Name = "tasktext";
            this.tasktext.Size = new System.Drawing.Size(592, 44);
            this.tasktext.TabIndex = 64;
            this.tasktext.Text = "";
            // 
            // subjecttext
            // 
            this.subjecttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjecttext.Location = new System.Drawing.Point(88, 393);
            this.subjecttext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjecttext.Name = "subjecttext";
            this.subjecttext.Size = new System.Drawing.Size(140, 26);
            this.subjecttext.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 393);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 26);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // dgw_assignment
            // 
            this.dgw_assignment.AllowUserToAddRows = false;
            this.dgw_assignment.AllowUserToDeleteRows = false;
            this.dgw_assignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_assignment.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(211)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_assignment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_assignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_assignment.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgw_assignment.Location = new System.Drawing.Point(13, 57);
            this.dgw_assignment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgw_assignment.Name = "dgw_assignment";
            this.dgw_assignment.ReadOnly = true;
            this.dgw_assignment.RowHeadersVisible = false;
            this.dgw_assignment.RowHeadersWidth = 51;
            this.dgw_assignment.RowTemplate.Height = 40;
            this.dgw_assignment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_assignment.Size = new System.Drawing.Size(845, 318);
            this.dgw_assignment.TabIndex = 59;
            this.dgw_assignment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_assignment_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(36, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Task";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(26, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(239, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Deadline";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLogin.Location = new System.Drawing.Point(48, 12);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(180, 37);
            this.labelLogin.TabIndex = 53;
            this.labelLogin.Text = "Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(430, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Teacher";
            // 
            // teachertext
            // 
            this.teachertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachertext.Location = new System.Drawing.Point(497, 393);
            this.teachertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teachertext.Name = "teachertext";
            this.teachertext.Size = new System.Drawing.Size(183, 26);
            this.teachertext.TabIndex = 72;
            this.teachertext.TextChanged += new System.EventHandler(this.teachertext_TextChanged);
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(869, 492);
            this.Controls.Add(this.teachertext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttondash);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tasktext);
            this.Controls.Add(this.subjecttext);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgw_assignment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Assignment";
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_assignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondash;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox tasktext;
        private System.Windows.Forms.TextBox subjecttext;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgw_assignment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teachertext;
    }
}