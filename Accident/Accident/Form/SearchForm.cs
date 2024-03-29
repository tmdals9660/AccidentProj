﻿using Accident.Data;
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

        private void UscSearch_SearchClick(object sender, Control.SearchControl.SearchClickEventArgs e)
        {
            var incidents = DB.Incident.SearchIncident(e.Id, e.Stime, e.Ftime);
            uscList.SetDataSource(incidents);
            uscList.SetDataCount(incidents.Count);
        }

        private void UscSearch_Load(object sender, EventArgs e)
        {

        }

        private void UscFilter_OptionCheck(object sender, Control.SearchFilterControl.OptionCheckEventArgs e)
        {
            uscList.OptionCheck(e.DateTime, e.City, e.State, e.DayAndNight, e.DayOfWeek, e.DeathCount, e.SeriouslyCount, e.SlightlyCount,
     e.InjuryCount, e.AccidentField, e.AccidentType, e.Violation, e.RoadForm, e.Attacker, e.Victim);
        }
    }
}
