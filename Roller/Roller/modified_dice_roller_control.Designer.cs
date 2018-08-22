using System.Runtime.InteropServices;

namespace Roller
{
    partial class modified_dice_roller_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dice_amount_textbox = new System.Windows.Forms.TextBox();
            this.dice_sides_label = new System.Windows.Forms.Label();
            this.modifier_textbox = new System.Windows.Forms.TextBox();
            this.roller_click = new System.Windows.Forms.Button();
            this.total_label = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dice_amount_textbox
            // 
            this.dice_amount_textbox.Location = new System.Drawing.Point(3, 4);
            this.dice_amount_textbox.Name = "dice_amount_textbox";
            this.dice_amount_textbox.Size = new System.Drawing.Size(47, 20);
            this.dice_amount_textbox.TabIndex = 1;
            // 
            // dice_sides_label
            // 
            this.dice_sides_label.AutoSize = true;
            this.dice_sides_label.Location = new System.Drawing.Point(56, 7);
            this.dice_sides_label.Name = "dice_sides_label";
            this.dice_sides_label.Size = new System.Drawing.Size(13, 13);
            this.dice_sides_label.TabIndex = 2;
            this.dice_sides_label.Text = "d";
            // 
            // modifier_textbox
            // 
            this.modifier_textbox.Location = new System.Drawing.Point(94, 4);
            this.modifier_textbox.Name = "modifier_textbox";
            this.modifier_textbox.Size = new System.Drawing.Size(49, 20);
            this.modifier_textbox.TabIndex = 3;
            // 
            // roller_click
            // 
            this.roller_click.Location = new System.Drawing.Point(149, 2);
            this.roller_click.Name = "roller_click";
            this.roller_click.Size = new System.Drawing.Size(64, 23);
            this.roller_click.TabIndex = 4;
            this.roller_click.Text = "Roll";
            this.roller_click.UseVisualStyleBackColor = true;
            this.roller_click.Click += new System.EventHandler(this.roll_button_click);
            // 
            // total_label
            // 
            this.total_label.Location = new System.Drawing.Point(219, 4);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(49,20);
            this.total_label.TabIndex = 5;
            this.total_label.Text = "0";
            this.total_label.ReadOnly = true;
            this.total_label.BackColor = this.BackColor;
            // 
            // modified_dice_roller_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.roller_click);
            this.Controls.Add(this.modifier_textbox);
            this.Controls.Add(this.dice_sides_label);
            this.Controls.Add(this.dice_amount_textbox);
            this.Name = "modified_dice_roller_control";
            this.Size = new System.Drawing.Size(273, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dice_amount_textbox;
        private System.Windows.Forms.Label dice_sides_label;
        private System.Windows.Forms.TextBox modifier_textbox;
        private System.Windows.Forms.Button roller_click;
        private System.Windows.Forms.TextBox total_label;

        
    }
}
