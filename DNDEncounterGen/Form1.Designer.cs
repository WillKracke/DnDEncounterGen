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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDead = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.txtPlayerLvl = new System.Windows.Forms.TextBox();
            this.txtPlayerCt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadBar = new System.Windows.Forms.ProgressBar();
            this.chkAnimal = new System.Windows.Forms.CheckBox();
            this.chkCelest = new System.Windows.Forms.CheckBox();
            this.chkDemon = new System.Windows.Forms.CheckBox();
            this.chkConstr = new System.Windows.Forms.CheckBox();
            this.chkElement = new System.Windows.Forms.CheckBox();
            this.chkDragon = new System.Windows.Forms.CheckBox();
            this.chkHuman = new System.Windows.Forms.CheckBox();
            this.chkGiant = new System.Windows.Forms.CheckBox();
            this.chkUndead = new System.Windows.Forms.CheckBox();
            this.chkMonster = new System.Windows.Forms.CheckBox();
            this.btnLoadEnemies = new System.Windows.Forms.Button();
            this.grpCR.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.grpCR.Size = new System.Drawing.Size(249, 160);
            this.grpCR.TabIndex = 0;
            this.grpCR.TabStop = false;
            this.grpCR.Text = "Combat Rating";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDead);
            this.groupBox1.Controls.Add(this.rbHard);
            this.groupBox1.Controls.Add(this.rbMed);
            this.groupBox1.Controls.Add(this.rbEasy);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threshold Level";
            // 
            // rbDead
            // 
            this.rbDead.AutoSize = true;
            this.rbDead.Location = new System.Drawing.Point(111, 43);
            this.rbDead.Name = "rbDead";
            this.rbDead.Size = new System.Drawing.Size(58, 17);
            this.rbDead.TabIndex = 3;
            this.rbDead.Text = "Deadly";
            this.rbDead.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(111, 20);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(80, 17);
            this.rbHard.TabIndex = 2;
            this.rbHard.Text = "Challenging";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Location = new System.Drawing.Point(7, 43);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(70, 17);
            this.rbMed.TabIndex = 1;
            this.rbMed.Text = "Moderate";
            this.rbMed.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Location = new System.Drawing.Point(7, 20);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(48, 17);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Avg Combat Rating\r\n(XP)";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player \r\nLevel";
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
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(141, 35);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(95, 20);
            this.txtCR.TabIndex = 2;
            // 
            // txtPlayerLvl
            // 
            this.txtPlayerLvl.Location = new System.Drawing.Point(67, 35);
            this.txtPlayerLvl.Name = "txtPlayerLvl";
            this.txtPlayerLvl.Size = new System.Drawing.Size(43, 20);
            this.txtPlayerLvl.TabIndex = 1;
            // 
            // txtPlayerCt
            // 
            this.txtPlayerCt.Location = new System.Drawing.Point(6, 35);
            this.txtPlayerCt.Name = "txtPlayerCt";
            this.txtPlayerCt.Size = new System.Drawing.Size(43, 20);
            this.txtPlayerCt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadEnemies);
            this.groupBox2.Controls.Add(this.chkUndead);
            this.groupBox2.Controls.Add(this.chkMonster);
            this.groupBox2.Controls.Add(this.chkHuman);
            this.groupBox2.Controls.Add(this.chkGiant);
            this.groupBox2.Controls.Add(this.chkElement);
            this.groupBox2.Controls.Add(this.chkDragon);
            this.groupBox2.Controls.Add(this.chkDemon);
            this.groupBox2.Controls.Add(this.chkConstr);
            this.groupBox2.Controls.Add(this.chkCelest);
            this.groupBox2.Controls.Add(this.chkAnimal);
            this.groupBox2.Location = new System.Drawing.Point(268, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enabled Enemy Sets";
            // 
            // loadBar
            // 
            this.loadBar.Location = new System.Drawing.Point(12, 415);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(534, 23);
            this.loadBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadBar.TabIndex = 2;
            // 
            // chkAnimal
            // 
            this.chkAnimal.AutoSize = true;
            this.chkAnimal.Location = new System.Drawing.Point(8, 19);
            this.chkAnimal.Name = "chkAnimal";
            this.chkAnimal.Size = new System.Drawing.Size(62, 17);
            this.chkAnimal.TabIndex = 0;
            this.chkAnimal.Text = "Animals";
            this.chkAnimal.UseVisualStyleBackColor = true;
            // 
            // chkCelest
            // 
            this.chkCelest.AutoSize = true;
            this.chkCelest.Location = new System.Drawing.Point(95, 19);
            this.chkCelest.Name = "chkCelest";
            this.chkCelest.Size = new System.Drawing.Size(65, 17);
            this.chkCelest.TabIndex = 1;
            this.chkCelest.Text = "Celestial";
            this.chkCelest.UseVisualStyleBackColor = true;
            // 
            // chkDemon
            // 
            this.chkDemon.AutoSize = true;
            this.chkDemon.Location = new System.Drawing.Point(95, 42);
            this.chkDemon.Name = "chkDemon";
            this.chkDemon.Size = new System.Drawing.Size(68, 17);
            this.chkDemon.TabIndex = 3;
            this.chkDemon.Text = "Demonic";
            this.chkDemon.UseVisualStyleBackColor = true;
            // 
            // chkConstr
            // 
            this.chkConstr.AutoSize = true;
            this.chkConstr.Location = new System.Drawing.Point(8, 42);
            this.chkConstr.Name = "chkConstr";
            this.chkConstr.Size = new System.Drawing.Size(76, 17);
            this.chkConstr.TabIndex = 2;
            this.chkConstr.Text = "Constructs";
            this.chkConstr.UseVisualStyleBackColor = true;
            // 
            // chkElement
            // 
            this.chkElement.AutoSize = true;
            this.chkElement.Location = new System.Drawing.Point(95, 66);
            this.chkElement.Name = "chkElement";
            this.chkElement.Size = new System.Drawing.Size(77, 17);
            this.chkElement.TabIndex = 5;
            this.chkElement.Text = "Elementals";
            this.chkElement.UseVisualStyleBackColor = true;
            // 
            // chkDragon
            // 
            this.chkDragon.AutoSize = true;
            this.chkDragon.Location = new System.Drawing.Point(8, 66);
            this.chkDragon.Name = "chkDragon";
            this.chkDragon.Size = new System.Drawing.Size(66, 17);
            this.chkDragon.TabIndex = 4;
            this.chkDragon.Text = "Dragons";
            this.chkDragon.UseVisualStyleBackColor = true;
            // 
            // chkHuman
            // 
            this.chkHuman.AutoSize = true;
            this.chkHuman.Location = new System.Drawing.Point(95, 89);
            this.chkHuman.Name = "chkHuman";
            this.chkHuman.Size = new System.Drawing.Size(79, 17);
            this.chkHuman.TabIndex = 7;
            this.chkHuman.Text = "Humanoids";
            this.chkHuman.UseVisualStyleBackColor = true;
            // 
            // chkGiant
            // 
            this.chkGiant.AutoSize = true;
            this.chkGiant.Location = new System.Drawing.Point(8, 89);
            this.chkGiant.Name = "chkGiant";
            this.chkGiant.Size = new System.Drawing.Size(56, 17);
            this.chkGiant.TabIndex = 6;
            this.chkGiant.Text = "Giants";
            this.chkGiant.UseVisualStyleBackColor = true;
            // 
            // chkUndead
            // 
            this.chkUndead.AutoSize = true;
            this.chkUndead.Location = new System.Drawing.Point(95, 112);
            this.chkUndead.Name = "chkUndead";
            this.chkUndead.Size = new System.Drawing.Size(64, 17);
            this.chkUndead.TabIndex = 9;
            this.chkUndead.Text = "Undead";
            this.chkUndead.UseVisualStyleBackColor = true;
            // 
            // chkMonster
            // 
            this.chkMonster.AutoSize = true;
            this.chkMonster.Location = new System.Drawing.Point(8, 112);
            this.chkMonster.Name = "chkMonster";
            this.chkMonster.Size = new System.Drawing.Size(69, 17);
            this.chkMonster.TabIndex = 8;
            this.chkMonster.Text = "Monsters";
            this.chkMonster.UseVisualStyleBackColor = true;
            // 
            // btnLoadEnemies
            // 
            this.btnLoadEnemies.Location = new System.Drawing.Point(6, 130);
            this.btnLoadEnemies.Name = "btnLoadEnemies";
            this.btnLoadEnemies.Size = new System.Drawing.Size(266, 23);
            this.btnLoadEnemies.TabIndex = 10;
            this.btnLoadEnemies.Text = "Load Enemy List";
            this.btnLoadEnemies.UseVisualStyleBackColor = true;
            this.btnLoadEnemies.Click += new System.EventHandler(this.btnLoadEnemies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.loadBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCR);
            this.Name = "Form1";
            this.Text = "DND Encounter Generator 5e";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCR.ResumeLayout(false);
            this.grpCR.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbDead;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadEnemies;
        private System.Windows.Forms.CheckBox chkUndead;
        private System.Windows.Forms.CheckBox chkMonster;
        private System.Windows.Forms.CheckBox chkHuman;
        private System.Windows.Forms.CheckBox chkGiant;
        private System.Windows.Forms.CheckBox chkElement;
        private System.Windows.Forms.CheckBox chkDragon;
        private System.Windows.Forms.CheckBox chkDemon;
        private System.Windows.Forms.CheckBox chkConstr;
        private System.Windows.Forms.CheckBox chkCelest;
        private System.Windows.Forms.CheckBox chkAnimal;
        private System.Windows.Forms.ProgressBar loadBar;
    }
}

