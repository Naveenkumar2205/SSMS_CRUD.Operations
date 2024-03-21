namespace People
{
    partial class Form1
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_addr = new System.Windows.Forms.RichTextBox();
            this.txt_mob = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.RichTextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.dB_Test1TableAdapter1 = new People.DataSet_PeopleTableAdapters.DB_Test1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(99, 22);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(370, 26);
            this.txt_name.TabIndex = 0;
            // 
            // txt_addr
            // 
            this.txt_addr.Location = new System.Drawing.Point(99, 74);
            this.txt_addr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_addr.Name = "txt_addr";
            this.txt_addr.Size = new System.Drawing.Size(370, 146);
            this.txt_addr.TabIndex = 1;
            this.txt_addr.Text = "";
            // 
            // txt_mob
            // 
            this.txt_mob.Location = new System.Drawing.Point(585, 26);
            this.txt_mob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mob.Name = "txt_mob";
            this.txt_mob.Size = new System.Drawing.Size(420, 26);
            this.txt_mob.TabIndex = 2;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(585, 78);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(420, 62);
            this.txt_mail.TabIndex = 3;
            this.txt_mail.Text = "";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(8, 26);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "email Id";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(585, 169);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(135, 52);
            this.Btn_Save.TabIndex = 8;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(747, 169);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(112, 52);
            this.Btn_Edit.TabIndex = 9;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Location = new System.Drawing.Point(893, 169);
            this.Btn_Del.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(112, 52);
            this.Btn_Del.TabIndex = 11;
            this.Btn_Del.Text = "Delete";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // dB_Test1TableAdapter1
            // 
            this.dB_Test1TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 590);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 847);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Del);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_mob);
            this.Controls.Add(this.txt_addr);
            this.Controls.Add(this.txt_name);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PEOPLE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RichTextBox txt_addr;
        private System.Windows.Forms.TextBox txt_mob;
        private System.Windows.Forms.RichTextBox txt_mail;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Del;
        private DataSet_PeopleTableAdapters.DB_Test1TableAdapter dB_Test1TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

