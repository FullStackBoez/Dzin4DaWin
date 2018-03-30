using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodrom
{
    public partial class Nov_aerodrom : Form
    {
        public string item;

        public Nov_aerodrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                item = kratenka.Text + " - "+ime.Text + " - " + grad.Text;
                Close();
            }
        }

        private void Nov_aerodrom_Load(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.None;
            item = null;
        }

        private void Validate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(grad.Text))
            {
                e.Cancel = true;
                err1.SetError(grad,"Внесете град");
            }
            else
            {
                e.Cancel = false;
                err1.SetError(grad, null);
            }
            
            }

        private void Validate1(object sender, CancelEventArgs e)
        {
        if (string.IsNullOrEmpty(ime.Text))
        {
            e.Cancel = true;
            err2.SetError(ime, "Внесете име");
        }
        else
        {
            e.Cancel = false;
            err2.SetError(ime, null);
            }

        }

        private void Validate2(object sender, CancelEventArgs e)
        {
                string patt = "^[A-Z]{3}$";
                if (string.IsNullOrEmpty(kratenka.Text))
                {
                    e.Cancel = true;
                    err3.SetError(kratenka, "Внесете град");
                }
                else if (!Regex.IsMatch(kratenka.Text, patt))
                {
                    e.Cancel = true;
                    err3.SetError(kratenka, "Може да има само 3 големи букви");
                }
                else
                {
                    e.Cancel = false;
                    err3.SetError(kratenka, null);
                }
        }
    }
}
