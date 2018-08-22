using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roller
{
    public partial class modified_dice_roller_control : UserControl
    {
        public modified_dice_roller_control()
        {
            InitializeComponent();
            dice_sides_label.Text = "d" + Die.ToString() + " +";
            roller = new DiceRoller(Die);
        }
        public modified_dice_roller_control(int sides)
        {
            InitializeComponent();
            Die = sides;
            dice_sides_label.Text = "d" + Die.ToString() + " +";
        }

        private int die = 0;
        private TextBox rollsDisplay;

        [Description("Textbox to send roll to"), Category("Data")]
        public TextBox ExternalDisplay
        {
            get { return rollsDisplay;}
            set { rollsDisplay = value; }
        }

        [Description("Die type for roller"),Category("Data")]
        public int Die
        {
            get => die;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                die = value;
                roller = new DiceRoller(Die);
                dice_sides_label.Text = "d" + Die.ToString() + " +";
            }
        }

        private DiceRoller roller;

        private void roll_button_click(object sender, System.EventArgs e)
        {
            if (modifier_textbox.Text == "" || !int.TryParse(modifier_textbox.Text, out var val))
            {
                modifier_textbox.Text = "0";
            }

            if (dice_amount_textbox.Text == "" || !int.TryParse(modifier_textbox.Text, out var check))
            {
                dice_amount_textbox.Text = "1";
            }
            var mult = Convert.ToInt32(dice_amount_textbox.Text);
            var modifier = Convert.ToInt32(modifier_textbox.Text);
            var roll = 0;
            var rolls_string = "(";
            var curr_roll = 0;
            for (var i = 0; i < mult; ++i)
            {
                curr_roll = roller.GetRoll();
                roll += curr_roll;
                rolls_string += curr_roll.ToString();
                if (mult - i > 1)
                {
                    rolls_string += "+";
                }
            }

            rolls_string += ")";

            var total = roll + modifier;
            var display_string = roll.ToString() + "+" + modifier.ToString() + "=" + total.ToString();
            total_label.Text = display_string;
            rollsDisplay.AppendText(display_string + "\r\n" + rolls_string + "\r\n\r\n");

        }
    }
}
