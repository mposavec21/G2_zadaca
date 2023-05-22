namespace WindowsFormsApp1
{
    partial class FrmEvaluation
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
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(74, 126);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(459, 86);
            this.txtActivityDescription.TabIndex = 0;
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(281, 62);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 22);
            this.txtMinForSignature.TabIndex = 1;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(433, 64);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.Size = new System.Drawing.Size(100, 22);
            this.txtMinForGrade.TabIndex = 2;
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(74, 62);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(121, 24);
            this.cboActivities.TabIndex = 3;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(74, 274);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(100, 22);
            this.txtTeacher.TabIndex = 4;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(232, 274);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.Size = new System.Drawing.Size(68, 22);
            this.txtEvaluationDate.TabIndex = 5;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(364, 275);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(120, 22);
            this.numPoints.TabIndex = 6;
            this.numPoints.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(364, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(458, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aktivnost:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Uvjet za potpis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Uvjet za ocjenu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ocjenjivač";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datum evaluacije";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bodovi";
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 395);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.txtActivityDescription);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}