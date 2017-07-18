using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redisDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            HashOperator op = new HashOperator();
            if (op.Set<string>("temp", "name", "秋水"))
            {
                string name = op.Get<string>("temp", "name");
                MessageBox.Show(name);
            }
        }
    }
}
