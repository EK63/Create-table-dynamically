namespace DataRetrieve
{
    partial class StudentLookUp
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
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.btnStudentLookUp = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.btnTableCreate = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentColour = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(147, 17);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtStudentId.TabIndex = 0;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(24, 20);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(87, 13);
            this.lblStudentId.TabIndex = 1;
            this.lblStudentId.Text = "Enter student ID:";
            // 
            // btnStudentLookUp
            // 
            this.btnStudentLookUp.Location = new System.Drawing.Point(115, 56);
            this.btnStudentLookUp.Name = "btnStudentLookUp";
            this.btnStudentLookUp.Size = new System.Drawing.Size(132, 23);
            this.btnStudentLookUp.TabIndex = 2;
            this.btnStudentLookUp.Text = "Look-up Student (1-5)";
            this.btnStudentLookUp.UseVisualStyleBackColor = true;
            this.btnStudentLookUp.Click += new System.EventHandler(this.BtnStudentLookUp_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Student fist name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(24, 145);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(102, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Student surname";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(24, 178);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(99, 13);
            this.lblColour.TabIndex = 5;
            this.lblColour.Text = "Student\'s colour";
            // 
            // btnTableCreate
            // 
            this.btnTableCreate.BackColor = System.Drawing.Color.Lime;
            this.btnTableCreate.Location = new System.Drawing.Point(27, 213);
            this.btnTableCreate.Name = "btnTableCreate";
            this.btnTableCreate.Size = new System.Drawing.Size(100, 23);
            this.btnTableCreate.TabIndex = 6;
            this.btnTableCreate.Text = "Create Table";
            this.btnTableCreate.UseVisualStyleBackColor = false;
            this.btnTableCreate.Click += new System.EventHandler(this.BtnTableCreate_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(147, 110);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(35, 13);
            this.lblStudentName.TabIndex = 7;
            this.lblStudentName.Text = "Name";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Location = new System.Drawing.Point(147, 145);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(49, 13);
            this.lblStudentSurname.TabIndex = 8;
            this.lblStudentSurname.Text = "Surname";
            // 
            // lblStudentColour
            // 
            this.lblStudentColour.AutoSize = true;
            this.lblStudentColour.Location = new System.Drawing.Point(147, 178);
            this.lblStudentColour.Name = "lblStudentColour";
            this.lblStudentColour.Size = new System.Drawing.Size(37, 13);
            this.lblStudentColour.TabIndex = 9;
            this.lblStudentColour.Text = "Colour";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(147, 213);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close window";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Table name";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(144, 340);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(63, 13);
            this.lblTableName.TabIndex = 13;
            this.lblTableName.Text = "Table name";
            // 
            // StudentLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 428);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStudentColour);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnTableCreate);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnStudentLookUp);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtStudentId);
            this.Name = "StudentLookUp";
            this.Text = "Student look-up form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnStudentLookUp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Button btnTableCreate;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblStudentColour;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTableName;
    }
}

