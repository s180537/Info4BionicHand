using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BionicHand_BETA_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (this.progressBar1.Value < 100)
            {
                this.progressBar1.Value = this.progressBar1.Value + 5;
                Thread.Sleep(5);
            }
            this.progressBar1.Value = 0;

            Form2 form2 = new Form2();

            // #2. Set second form's size
            form2.Width = this.Width;
            form2.Height = this.Height;
            //Testkommentar

            // #3. Set second form's start position as same as parent form
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Location.X, this.Location.Y);

            // #4. Set parent form's visible to false
            this.Visible = false;

            // #5. Open second dialog
            form2.ShowDialog();

            // #6. Set parent form's visible to true
            this.Visible = true;
        }
    }
}
