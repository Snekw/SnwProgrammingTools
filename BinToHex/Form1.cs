#region License
/**
 * BinToHex, convert between binary and hex.
 * Copyright (C) 2017  Ilkka Kuosmanen
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinToHex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byteButtons = new Button[]
            {
                B_0,
                B_1,
                B_2,
                B_3,
                B_4,
                B_5,
                B_6,
                B_7
            };
            B_0.Tag = 1;
            B_1.Tag = 2;
            B_2.Tag = 4;
            B_3.Tag = 8;
            B_4.Tag = 16;
            B_5.Tag = 32;
            B_6.Tag = 64;
            B_7.Tag = 128;

            UpdateHex();
        }

        private Button[] byteButtons;

        private void ByteChangeEvent(object sender, EventArgs e)
        {
            Button target = sender as Button;

            target.Text = target.Text == "0" ? "1" : "0";
            UpdateHex();
        }

        private void ByteReset(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            string newVal = (string)s.Tag;
            foreach(Button button in byteButtons)
            {
                button.Text = newVal;
            }
            UpdateHex();
        }

        private void UpdateHex()
        {
            byte b = 0;
            foreach (Button button in byteButtons)
            {
                if (button.Text == "1")
                {
                    byte temp = (byte)((int)button.Tag);
                    b |= temp;
                }
            }

            TB_OUT.Text = "0x" + b.ToString("X2");
        }

        private void B_COPY_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TB_OUT.Text);
        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem s = (ToolStripMenuItem)sender;
            TopMost = !TopMost;
            s.Checked = TopMost;
        }

        private void B_TOBIN_Click(object sender, EventArgs e)
        {
            string temp = TB_OUT.Text;
            temp = temp.Trim();
            temp = temp.Substring(2);
            byte b = Convert.ToByte(temp, 16);

            foreach(Button button in byteButtons)
            {
                if((b & (int)button.Tag) != 0)
                {
                    button.Text = "1";
                }
                else
                {
                    button.Text = "0";
                }
            }
        }
    }
}
