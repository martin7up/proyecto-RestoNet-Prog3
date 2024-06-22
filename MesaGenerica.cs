using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resto_App
{
    public partial class MesaGenerica : Button
    {
        public int TotalSillas { get; set; }
        public int SillasOcupadas { get; set; }
        public MesaGenerica()
        {
            InitializeComponent();
        }
    }
}
