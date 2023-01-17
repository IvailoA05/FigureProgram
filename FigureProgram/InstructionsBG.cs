using System;
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
    public partial class InstructionsBG : Form
    {
        public InstructionsBG()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            Hide();
            fm.Show();
        }

        private void btnUK_Click(object sender, EventArgs e)
        {
            Instructions ins = new Instructions();
            Hide();
            ins.Show();
        }
    }
}
