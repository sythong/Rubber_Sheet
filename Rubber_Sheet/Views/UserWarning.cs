using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubber_Sheet.Views
{
    public partial class UserWarning : UserControl
    {
        public UserWarning()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(0, "one", "two");
            //dataGridView1.Columns[0].Name = "column2";
            //dataGridView1.Columns[1].Name = "column6";
            //string[] row1 = new string[] { "column2 value", "column6 value" };
            //dataGridView1.Rows.Add(row1);
        }
    }
}
