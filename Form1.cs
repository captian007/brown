using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        { 
            string err = "Please enter a valid value between 1 to 20";
           
                int j, i, n;
                n = int.Parse(Txt_Num.Text);
                if (n > 20 || n < 0)
                {
                    MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (i = 0; i <= n; i++)
                    {
                    table.Columns.Add(i.ToString());
                    for (j = 1; j <= n; j++)
                        {
                        
                            if (i > 0)
                            //Here Im getting error
                            // Im not able to figure how to row data in every colomn 
                                table.Rows.Add((i * j).ToString());
                            else
                                table.Rows.Add(j.ToString());
                        }
                    }
                    dataGridView1.DataSource = table;
                }
        }
    }
}
       

