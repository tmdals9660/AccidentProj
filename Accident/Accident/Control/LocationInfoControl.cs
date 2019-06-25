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

        public void GetLocationInfo(string city,string state,double rati, double longi)
        {
            lblCity.Text = city;
            lblState.Text = state;
            lblLatitude.Text = rati.ToString();
            lblLongitude.Text = longi.ToString();
        }

        #region LocationFormClose event things for C# 3.0
        public event EventHandler<LocationFormCloseEventArgs> LocationFormClose;

        protected virtual void OnLocationFormClose(LocationFormCloseEventArgs e)
        {
            if (LocationFormClose != null)
                LocationFormClose(this, e);
        }

        private LocationFormCloseEventArgs OnLocationFormClose()
        {
            LocationFormCloseEventArgs args = new LocationFormCloseEventArgs();
            OnLocationFormClose(args);

            return args;
        }

        /*private LocationFormCloseEventArgs OnLocationFormCloseForOut()
        {
            LocationFormCloseEventArgs args = new LocationFormCloseEventArgs();
            OnLocationFormClose(args);

            return args;
        }*/

        public class LocationFormCloseEventArgs : EventArgs
        {


            /*public LocationFormCloseEventArgs()
            {
            }

            public LocationFormCloseEventArgs()
            {

            }*/
        }
        #endregion
        private void BtnClose_Click(object sender, EventArgs e)
        {
            OnLocationFormClose();
        }
    }
}
