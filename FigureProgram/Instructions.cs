﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureProgram
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            Hide();
            fm.Show();
        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            InstructionsBG bg = new InstructionsBG();
            Hide();
            bg.Show();
        }
    }
}
