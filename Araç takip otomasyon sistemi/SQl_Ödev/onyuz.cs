using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQl_Ödev
{
    public partial class onyuz : Form
    {
        public onyuz()
        {
            InitializeComponent();
        }

        

    
        private void btn1_Musterıler_Click(object sender, EventArgs e)
        {
            Musterıler mstr = new Musterıler();
            mstr.ShowDialog();
            this.Hide();

        }

        private void btn1_Araclar_Click(object sender, EventArgs e)
        {
            Araclar arc = new Araclar();
            arc.ShowDialog();
            this.Hide();

        }

        private void btn1_servısKayıtları_Click(object sender, EventArgs e)
        {
            ServısKayıtları srv = new ServısKayıtları();
            srv.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void onyuz_Load(object sender, EventArgs e)
        {

        }
    }
}
