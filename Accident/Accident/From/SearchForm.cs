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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void UscSearch_SeachChangeClick(object sender, Control.SearchControl.SeachChangeClickEventArgs e)
        {
            uscFilter.Visible = true;
        }
        private void UscSearch_SeachChangeClickOff(object sender, Control.SearchControl.SeachChangeClickOffEventArgs e)
        {
            uscFilter.Visible = false;
        }

        private void UscFilter_FilterCheck(object sender, Control.SearchFilterControl.FilterCheckEventArgs e)
        {
            uscList.FilterCheck(e.__date, e.Dnn, e.Wod, e.Death, e.Serious, e.Slight,
                e.Injury, e.Filed, e.Type, e.Violation, e.Road, e.Attacker, e.Victim);
        }

        private void UscSearch_SearchClick(object sender, Control.SearchControl.SearchClickEventArgs e)
        {
            var incidents = DB.Incident.SearchIncident2(e.Id, e.Stime, e.Ftime);
            uscList.SetDataSource(incidents);
        }

        

     
    }
}
