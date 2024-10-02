using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_1_EC
{
    public partial class BookView : Form
    {
        public FlipPage flipDel;
        public LibraryModel model;
        public BookView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to handle flipping a page to the right
        /// </summary>
        /// <param name="sender">the object signaling the event</param>
        /// <param name="e">information about the event</param>
        private void flipRight_Click(object sender, EventArgs e)
        {
            //flipDel();
        }
    }
}
