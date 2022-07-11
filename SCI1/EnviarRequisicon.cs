using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI1
{
    public partial class EnviarRequisicon : Form, IResumen
    {
        public EnviarRequisicon()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK )
            {
                this.label1.Font = fontDialog1.Font;
                
               
            }
        }
    }

    internal interface IResumen
    {
        
    }
}
