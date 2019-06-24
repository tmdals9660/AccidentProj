using Accident.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accident.From
{
    public partial class LocationForm : Form
    {
        public LocationForm(Incident incident)
        {
            InitializeComponent();

            _incident = incident;
        }

        private Incident _incident;

        private void ReadFromEntity()
        {
            label1.Text = _incident.Location.City.CityName.ToString();
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            ReadFromEntity();


        }
    }
}
