using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accident.Control
{
    public partial class LocationInfoControl : UserControl
    {
        public LocationInfoControl()
        {
            InitializeComponent();
        }

        public void GetCityLabel(string city)
        {
            lblCity.Text = city;
        }
    }
}
