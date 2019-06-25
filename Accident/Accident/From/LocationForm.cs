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
        private Incident _incidentId;

        public LocationForm(Incident incidentId)
        {
            InitializeComponent();

            _incidentId = incidentId;
        }


        private void ReadFromEntity()
        {
            int incidentId = _incidentId.IncidentId;
            string cityName = DB.Location.GetCitiesName(incidentId).ToString();
            string stateName = DB.Location.GetStateName(incidentId).ToString();
            double ratitude = _incidentId.Location.Ratitude;
            double longitude = _incidentId.Location.Longitude;


            uscLocation.GetLocationInfo(cityName, stateName, ratitude, longitude);

        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            ReadFromEntity();


        }
    }
}
