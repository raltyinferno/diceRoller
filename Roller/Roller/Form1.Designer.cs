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
            this.d20_mod_roller = new Roller.modified_dice_roller_control();
            this.d12_mod_roller = new Roller.modified_dice_roller_control();
            this.d10_mod_roller = new Roller.modified_dice_roller_control();
            this.d8_mod_roller = new Roller.modified_dice_roller_control();
            this.d6_mod_roller = new Roller.modified_dice_roller_control();
            this.d4_mod_roller = new Roller.modified_dice_roller_control();
            this.d100_mod_roller = new Roller.modified_dice_roller_control();
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
            // d100_mod_roller
            // 
            this.d100_mod_roller.Die = 100;
            this.d100_mod_roller.ExternalDisplay = this.MainDisplay;
            this.d100_mod_roller.Location = new System.Drawing.Point(13, 211);
            this.d100_mod_roller.Name = "d100_mod_roller";
            this.d100_mod_roller.Size = new System.Drawing.Size(273, 27);
            this.d100_mod_roller.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.d100_mod_roller);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.d20_mod_roller);
            this.Controls.Add(this.d12_mod_roller);
            this.Controls.Add(this.d10_mod_roller);
            this.Controls.Add(this.d8_mod_roller);
            this.Controls.Add(this.d6_mod_roller);
            this.Controls.Add(this.d4_mod_roller);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

