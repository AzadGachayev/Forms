namespace Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupname = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // txtGroupname
            // 
            this.txtGroupname.AutoSize = true;
            this.txtGroupname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGroupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtGroupname.Location = new System.Drawing.Point(304, 28);
            this.txtGroupname.Name = "txtGroupname";
            this.txtGroupname.Size = new System.Drawing.Size(99, 18);
            this.txtGroupname.TabIndex = 1;
            this.txtGroupname.Text = "GroupName";
            // 
            // txtMail
            // 
            this.txtMail.AutoSize = true;
            this.txtMail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtMail.Location = new System.Drawing.Point(190, 28);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(55, 18);
            this.txtMail.TabIndex = 2;
            this.txtMail.Text = "E Mail";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtName.Location = new System.Drawing.Point(32, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(174, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEnter.Location = new System.Drawing.Point(437, 61);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(129, 28);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(307, 66);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(112, 21);
            this.cmbGroup.TabIndex = 7;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(29, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Group";
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAdd.Location = new System.Drawing.Point(32, 358);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 20);
            this.txtAdd.TabIndex = 9;
            this.txtAdd.TextChanged += new System.EventHandler(this.TxtAdd_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSend.Location = new System.Drawing.Point(32, 384);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(129, 28);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Enter";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblError.Location = new System.Drawing.Point(29, 434);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(53, 18);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Errror";
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.LblError_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtGroupname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtGroupname;
        private System.Windows.Forms.Label txtMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblError;
    }
}

