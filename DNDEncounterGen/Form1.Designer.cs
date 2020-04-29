namespace DNDEncounterGen
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
            this.grpCR = new System.Windows.Forms.GroupBox();
            this.txtPlayerCt = new System.Windows.Forms.TextBox();
            this.txtPlayerLvl = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.grpCR.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCR
            // 
            this.grpCR.Controls.Add(this.groupBox1);
            this.grpCR.Controls.Add(this.label4);
            this.grpCR.Controls.Add(this.label3);
            this.grpCR.Controls.Add(this.label2);
            this.grpCR.Controls.Add(this.label1);
            this.grpCR.Controls.Add(this.txtCR);
            this.grpCR.Controls.Add(this.txtPlayerLvl);
            this.grpCR.Controls.Add(this.txtPlayerCt);
            this.grpCR.Location = new System.Drawing.Point(12, 12);
            this.grpCR.Name = "grpCR";
            this.grpCR.Size = new System.Drawing.Size(257, 160);
            this.grpCR.TabIndex = 0;
            this.grpCR.TabStop = false;
            this.grpCR.Text = "Combat Rating";
            // 
            // txtPlayerCt
            // 
            this.txtPlayerCt.Location = new System.Drawing.Point(6, 35);
            this.txtPlayerCt.Name = "txtPlayerCt";
            this.txtPlayerCt.Size = new System.Drawing.Size(43, 20);
            this.txtPlayerCt.TabIndex = 0;
            this.txtPlayerCt.TextChanged += new System.EventHandler(this.txtPlayerCt_TextChanged);
            // 
            // txtPlayerLvl
            // 
            this.txtPlayerLvl.Location = new System.Drawing.Point(67, 35);
            this.txtPlayerLvl.Name = "txtPlayerLvl";
            this.txtPlayerLvl.Size = new System.Drawing.Size(43, 20);
            this.txtPlayerLvl.TabIndex = 1;
            this.txtPlayerLvl.TextChanged += new System.EventHandler(this.txtPlayerLvl_TextChanged);
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(141, 35);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(95, 20);
            this.txtCR.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Num of \r\nPlayers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player \r\nLevel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "-->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Avg Combat Rating";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threshold Level";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Easy";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Moderate";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(111, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Challenging";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(111, 43);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Deadly";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.grpCR);
            this.Name = "Form1";
            this.Text = "DND Encounter Generator 5e";
            this.grpCR.ResumeLayout(false);
            this.grpCR.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.TextBox txtPlayerLvl;
        private System.Windows.Forms.TextBox txtPlayerCt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

