﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_1_EC
{
    public partial class LibraryView : Form
    {
        public LibraryView()
        {
            InitializeComponent();
            fillCloudLibOnOpen();
        }

        private SyncLibrary syncLibHan;
        private LibraryModel libraryModel;
       
        private void listCloudLibSelectedBook(object sender, EventArgs e)
        {

        }

        private void addToLibBtnClick(object sender, EventArgs e)
        {
            //syncLibHan(listCloudLib.SelectedValue);
        }
        public void fillCloudLibOnOpen()
        {
            //syncLibHan();
        }

        private void viewBookBtn(object sender, EventArgs e)
        {
            BookView bV = new BookView();
            bV.Show();
        }
    }
}
