﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox
{
    public partial class UINewCustomer : UserControl
    {
        public UINewCustomer()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UILogin());
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new UINewOrder());
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            back_button.Cursor = Cursors.Hand;
        }

        private void next_button_MouseEnter(object sender, EventArgs e)
        {
            next_button.Cursor = Cursors.Hand;
        }
    }
}
