using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void set_textbox_def(TextBox text_box, string def_val)
        {
            if (text_box.Text == "" || !int.TryParse(text_box.Text, out var temp))
            {
                text_box.Text = def_val;
            }
        }

        private int roll_stat()
        {
            var roller = new DiceRoller(6);
            IList<int> rolls = new List<int>();
            var roll_total = 0;
            int roll = 0;

            if (radio3d6.Checked.Equals(true))
            {
                for (var i = 0; i < 3; ++i)
                {
                    roll = roller.GetRoll();
                    if (reroll1s.Checked)
                    {
                        while (roll == 1)
                        {
                            roll = roller.GetRoll();
                        }
                    }
                    rolls.Add(roll);
                }
            }
            else
            {
                for (var i = 0; i < 4; ++i)
                {
                    roll = roller.GetRoll();
                    if (reroll1s.Checked)
                    {
                        while (roll == 1)
                        {
                            roll = roller.GetRoll();
                        }
                    }
                    rolls.Add(roll);
                }
                rolls = rolls.OrderByDescending(i => i).ToList();
                rolls.RemoveAt(3);
            }

            foreach (var i in rolls)
            {
                roll_total += i;
            }

            return roll_total;
        }

        private void rollStatsButton_Click(object sender, EventArgs e)
        {
            set_textbox_def(stat_min, "0");
            set_textbox_def(stat_total_min, "0");
            set_textbox_def(set_roll_num, "1");
            var stat_min_val = Convert.ToInt32(stat_min.Text);
            var stat_total_min_val = Convert.ToInt32(stat_total_min.Text);
            if (stat_min_val > 17)
            {
                stat_min.Text = "17";
            }
            if (stat_total_min_val > 102)
            {
                stat_total_min.Text = "102";
            };
            var thread = new Thread(roll_click);
            thread.Start();
        }

        private void roll_click()
        {
            
            IList<int> stat_set = new List<int>() { 0, 0, 0, 0, 0, 0 };
            var stat_min_val = Convert.ToInt32(stat_min.Text);
            var stat_total_min_val = Convert.ToInt32(stat_total_min.Text);
            

            for (var i = 0; i < Convert.ToInt32(set_roll_num.Text); ++i)
            {
                do
                {
                    for (var j = 0; j < 6; ++j)
                    {
                        stat_set[j] = roll_stat();
                    }
                } while (stat_set.Min() < stat_min_val ||
                         stat_set.Sum() < stat_total_min_val);

                if (radioOrderLow.Checked)
                {
                    stat_set = stat_set.OrderBy(stat => stat).ToList();
                }
                else if (radioOrderHigh.Checked)
                {
                    stat_set = stat_set.OrderByDescending(stat => stat).ToList();
                }

                var output = "";
                foreach (var stat in stat_set)
                {
                    output += stat.ToString();
                    output += " ";
                }

                output += "(Total:" + stat_set.Sum() + ")" + "\r\n";
                //required in order to modify UI element from different thread than it was created in
                Invoke(new Action(() => { MainDisplay.AppendText(output); }));
            }
            Invoke(new Action(() => { MainDisplay.AppendText("\r\n"); }));
        }

    }
}
