using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BionicHand_BETA_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            // #2. Set second form's size
            form4.Width = this.Width;
            form4.Height = this.Height;

            // #3. Set second form's start position as same as parent form
            form4.StartPosition = FormStartPosition.Manual;
            form4.Location = new Point(this.Location.X, this.Location.Y);

            // #4. Set parent form's visible to false
            this.Visible = false;

            // #5. Open second dialog
            form4.ShowDialog();

            // #6. Set parent form's visible to true
            this.Visible = true;
        }
    }
}
