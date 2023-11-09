using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMapGameLabor3
{
    public partial class EuropeCountry : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        PictureBox pb;
        Label l1, l2, l3;
        public EuropeCountry()
        {
            this.Height = 800;
            this.Width = 1000;
            this.Text = "Euroopi riigid nimega";


        }
    }
}
