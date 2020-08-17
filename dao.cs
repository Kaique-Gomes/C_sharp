using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Dao
{
    class dao
    {
        private void LimparCampos()
        {
            foreach (Control cont in this.Controls)
            {
                if (cont is TextBox)
                {
                    ((textBox)(cont)).Text = String.Empty;
                }
            }
        }
    }
}
