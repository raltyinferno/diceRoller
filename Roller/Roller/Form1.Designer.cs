namespace Roller
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
            this.MainDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio4d6 = new System.Windows.Forms.RadioButton();
            this.radio3d6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioOrderRolled = new System.Windows.Forms.RadioButton();
            this.radioOrderLow = new System.Windows.Forms.RadioButton();
            this.radioOrderHigh = new System.Windows.Forms.RadioButton();
            this.reroll1s = new System.Windows.Forms.CheckBox();
            this.stat_min = new System.Windows.Forms.TextBox();
            this.stat_total_min = new System.Windows.Forms.TextBox();
            this.set_roll_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rollStatsButton = new System.Windows.Forms.Button();
            this.d100_mod_roller = new Roller.modified_dice_roller_control();
            this.d20_mod_roller = new Roller.modified_dice_roller_control();
            this.d12_mod_roller = new Roller.modified_dice_roller_control();
            this.d10_mod_roller = new Roller.modified_dice_roller_control();
            this.d8_mod_roller = new Roller.modified_dice_roller_control();
            this.d6_mod_roller = new Roller.modified_dice_roller_control();
            this.d4_mod_roller = new Roller.modified_dice_roller_control();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDisplay
            // 
            this.MainDisplay.Location = new System.Drawing.Point(306, 12);
            this.MainDisplay.Multiline = true;
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.ReadOnly = true;
            this.MainDisplay.Size = new System.Drawing.Size(261, 417);
            this.MainDisplay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Character Stat Roller";
            // 
            // radio4d6
            // 
            this.radio4d6.AutoSize = true;
            this.radio4d6.Checked = true;
            this.radio4d6.Location = new System.Drawing.Point(7, 10);
            this.radio4d6.Name = "radio4d6";
            this.radio4d6.Size = new System.Drawing.Size(127, 17);
            this.radio4d6.TabIndex = 9;
            this.radio4d6.TabStop = true;
            this.radio4d6.Text = "Roll 4d6 (drop lowest)";
            this.radio4d6.UseVisualStyleBackColor = true;
            // 
            // radio3d6
            // 
            this.radio3d6.AutoSize = true;
            this.radio3d6.Location = new System.Drawing.Point(7, 33);
            this.radio3d6.Name = "radio3d6";
            this.radio3d6.Size = new System.Drawing.Size(64, 17);
            this.radio3d6.TabIndex = 10;
            this.radio3d6.Text = "Roll 3d6";
            this.radio3d6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio4d6);
            this.groupBox1.Controls.Add(this.radio3d6);
            this.groupBox1.Location = new System.Drawing.Point(588, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 58);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioOrderRolled);
            this.groupBox2.Controls.Add(this.radioOrderLow);
            this.groupBox2.Controls.Add(this.radioOrderHigh);
            this.groupBox2.Location = new System.Drawing.Point(588, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 82);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // radioOrderRolled
            // 
            this.radioOrderRolled.AutoSize = true;
            this.radioOrderRolled.Location = new System.Drawing.Point(7, 57);
            this.radioOrderRolled.Name = "radioOrderRolled";
            this.radioOrderRolled.Size = new System.Drawing.Size(93, 17);
            this.radioOrderRolled.TabIndex = 2;
            this.radioOrderRolled.Text = "Order as rolled";
            this.radioOrderRolled.UseVisualStyleBackColor = true;
            // 
            // radioOrderLow
            // 
            this.radioOrderLow.AutoSize = true;
            this.radioOrderLow.Location = new System.Drawing.Point(7, 33);
            this.radioOrderLow.Name = "radioOrderLow";
            this.radioOrderLow.Size = new System.Drawing.Size(98, 17);
            this.radioOrderLow.TabIndex = 1;
            this.radioOrderLow.Text = "Order by lowest";
            this.radioOrderLow.UseVisualStyleBackColor = true;
            // 
            // radioOrderHigh
            // 
            this.radioOrderHigh.AutoSize = true;
            this.radioOrderHigh.Checked = true;
            this.radioOrderHigh.Location = new System.Drawing.Point(7, 9);
            this.radioOrderHigh.Name = "radioOrderHigh";
            this.radioOrderHigh.Size = new System.Drawing.Size(102, 17);
            this.radioOrderHigh.TabIndex = 0;
            this.radioOrderHigh.TabStop = true;
            this.radioOrderHigh.Text = "Order by highest";
            this.radioOrderHigh.UseVisualStyleBackColor = true;
            // 
            // reroll1s
            // 
            this.reroll1s.AutoSize = true;
            this.reroll1s.Location = new System.Drawing.Point(595, 178);
            this.reroll1s.Name = "reroll1s";
            this.reroll1s.Size = new System.Drawing.Size(71, 17);
            this.reroll1s.TabIndex = 13;
            this.reroll1s.Text = "Reroll \'1\'s";
            this.reroll1s.UseVisualStyleBackColor = true;
            // 
            // stat_min
            // 
            this.stat_min.Location = new System.Drawing.Point(588, 211);
            this.stat_min.Name = "stat_min";
            this.stat_min.Size = new System.Drawing.Size(51, 20);
            this.stat_min.TabIndex = 14;
            // 
            // stat_total_min
            // 
            this.stat_total_min.Location = new System.Drawing.Point(588, 249);
            this.stat_total_min.Name = "stat_total_min";
            this.stat_total_min.Size = new System.Drawing.Size(51, 20);
            this.stat_total_min.TabIndex = 15;
            // 
            // set_roll_num
            // 
            this.set_roll_num.Location = new System.Drawing.Point(588, 285);
            this.set_roll_num.Name = "set_roll_num";
            this.set_roll_num.Size = new System.Drawing.Size(51, 20);
            this.set_roll_num.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Individual Stat Min (max 17)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Stat Min (max 102)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sets to Roll";
            // 
            // rollStatsButton
            // 
            this.rollStatsButton.Location = new System.Drawing.Point(647, 326);
            this.rollStatsButton.Name = "rollStatsButton";
            this.rollStatsButton.Size = new System.Drawing.Size(75, 23);
            this.rollStatsButton.TabIndex = 20;
            this.rollStatsButton.Text = "Roll";
            this.rollStatsButton.UseVisualStyleBackColor = true;
            this.rollStatsButton.Click += new System.EventHandler(this.rollStatsButton_Click);
            // 
            // d100_mod_roller
            // 
            this.d100_mod_roller.Die = 100;
            this.d100_mod_roller.ExternalDisplay = this.MainDisplay;
            this.d100_mod_roller.Location = new System.Drawing.Point(13, 211);
            this.d100_mod_roller.Name = "d100_mod_roller";
            this.d100_mod_roller.Size = new System.Drawing.Size(273, 27);
            this.d100_mod_roller.TabIndex = 7;
            // 
            // d20_mod_roller
            // 
            this.d20_mod_roller.Die = 20;
            this.d20_mod_roller.ExternalDisplay = this.MainDisplay;
            this.d20_mod_roller.Location = new System.Drawing.Point(13, 178);
            this.d20_mod_roller.Name = "d20_mod_roller";
            this.d20_mod_roller.Size = new System.Drawing.Size(273, 27);
            this.d20_mod_roller.TabIndex = 5;
            // 
            // d12_mod_roller
            // 
            this.d12_mod_roller.Die = 12;
            this.d12_mod_roller.ExternalDisplay = this.MainDisplay;
            this.d12_mod_roller.Location = new System.Drawing.Point(13, 144);
            this.d12_mod_roller.Name = "d12_mod_roller";
            this.d12_mod_roller.Size = new System.Drawing.Size(273, 27);
            this.d12_mod_roller.TabIndex = 4;
            // 
            // d10_mod_roller
            // 
            this.d10_mod_roller.Die = 10;
            this.d10_mod_roller.ExternalDisplay = this.MainDisplay;
            this.d10_mod_roller.Location = new System.Drawing.Point(13, 111);
            this.d10_mod_roller.Name = "d10_mod_roller";
            this.d10_mod_roller.Size = new System.Drawing.Size(273, 27);
            this.d10_mod_roller.TabIndex = 3;
            // 
            // d8_mod_roller
            // 
            this.d8_mod_roller.Die = 8;
            this.d8_mod_roller.ExternalDisplay = this.MainDisplay;
            this.d8_mod_roller.Location = new System.Drawing.Point(13, 78);
            this.d8_mod_roller.Name = "d8_mod_roller";
            this.d8_mod_roller.Size = new System.Drawing.Size(273, 27);
            this.d8_mod_roller.TabIndex = 2;
            // 
            // d6_mod_roller
            // 
            this.d6_mod_roller.Die = 6;
            this.d6_mod_roller.ExternalDisplay = this.MainDisplay;
            this.d6_mod_roller.Location = new System.Drawing.Point(13, 45);
            this.d6_mod_roller.Name = "d6_mod_roller";
            this.d6_mod_roller.Size = new System.Drawing.Size(273, 27);
            this.d6_mod_roller.TabIndex = 1;
            // 
            // d4_mod_roller
            // 
            this.d4_mod_roller.Die = 4;
            this.d4_mod_roller.ExternalDisplay = this.MainDisplay;
            this.d4_mod_roller.Location = new System.Drawing.Point(13, 12);
            this.d4_mod_roller.Name = "d4_mod_roller";
            this.d4_mod_roller.Size = new System.Drawing.Size(273, 27);
            this.d4_mod_roller.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rollStatsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.set_roll_num);
            this.Controls.Add(this.stat_total_min);
            this.Controls.Add(this.stat_min);
            this.Controls.Add(this.reroll1s);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d100_mod_roller);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.d20_mod_roller);
            this.Controls.Add(this.d12_mod_roller);
            this.Controls.Add(this.d10_mod_roller);
            this.Controls.Add(this.d8_mod_roller);
            this.Controls.Add(this.d6_mod_roller);
            this.Controls.Add(this.d4_mod_roller);
            this.Name = "Form1";
            this.Text = "dInfinity";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private modified_dice_roller_control d4_mod_roller;
        private modified_dice_roller_control d6_mod_roller;
        private modified_dice_roller_control d8_mod_roller;
        private modified_dice_roller_control d10_mod_roller;
        private modified_dice_roller_control d12_mod_roller;
        private modified_dice_roller_control d20_mod_roller;
        private System.Windows.Forms.TextBox MainDisplay;
        private modified_dice_roller_control d100_mod_roller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio4d6;
        private System.Windows.Forms.RadioButton radio3d6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioOrderRolled;
        private System.Windows.Forms.RadioButton radioOrderLow;
        private System.Windows.Forms.RadioButton radioOrderHigh;
        private System.Windows.Forms.CheckBox reroll1s;
        private System.Windows.Forms.TextBox stat_min;
        private System.Windows.Forms.TextBox stat_total_min;
        private System.Windows.Forms.TextBox set_roll_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rollStatsButton;
    }
}

