﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_MiniTrojan
{
    public partial class Dashboard : Form
    {
        public User user;
        public Dashboard(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            switch (user.Role)
            {
                case "ADMIN":

                    break;
                case "USER":

                    break;
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
