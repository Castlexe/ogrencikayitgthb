﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Kayıt_Sistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ögrenciKayitSistemiDataSet.ÖgrenciTables' table. You can move, or remove it, as needed.
            this.ögrenciTablesTableAdapter.Fill(this.ögrenciKayitSistemiDataSet.ÖgrenciTables);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
