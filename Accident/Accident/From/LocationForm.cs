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
            string cityName = DB.Incident.GetCitiesName(incidentId).ToString();
            string stateName = DB.Incident.GetStateName(incidentId).ToString();
            double ratitude = _incidentId.Ratitude;
            double longitude = _incidentId.Longitude;


            uscLocation.GetLocationInfo(cityName, stateName, ratitude, longitude);
            PrintMaps(ratitude, longitude);

        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            ReadFromEntity();
        }

        private void PrintMaps(double rat, double longi)
        {
            string ratitude = rat.ToString();
            string longitude = longi.ToString();


            StringBuilder address = new StringBuilder("http://maps.daum.net/?q=");

            address.Append(ratitude + ", ");

            address.Append(longitude);

            webBrowser1.Navigate(address.ToString());
        }

        private void UscLocation_LocationFormClose(object sender, Control.LocationInfoControl.LocationFormCloseEventArgs e)
        {
            Close();
        }
    }
}
