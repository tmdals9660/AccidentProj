﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accident.Data;

namespace Accident.Control
{
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();
        }

        private void ChkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrintOpt.Checked) OnSeachChangeClick();
            else OnSeachChangeClickOff();
        }
        #region SeachChangeClick event things for C# 3.0
        public event EventHandler<SeachChangeClickEventArgs> SeachChangeClick;

        protected virtual void OnSeachChangeClick(SeachChangeClickEventArgs e)
        {
            if (SeachChangeClick != null)
                SeachChangeClick(this, e);
        }

        private SeachChangeClickEventArgs OnSeachChangeClick()
        {
            SeachChangeClickEventArgs args = new SeachChangeClickEventArgs();
            OnSeachChangeClick(args);

            return args;
        }

        /*private SeachChangeClickEventArgs OnSeachChangeClickForOut()
        {
            SeachChangeClickEventArgs args = new SeachChangeClickEventArgs();
            OnSeachChangeClick(args);

            return args;
        }*/

        public class SeachChangeClickEventArgs : EventArgs
        {


            /*public SeachChangeClickEventArgs()
            {
            }

            public SeachChangeClickEventArgs()
            {

            }*/
        }
        #endregion

        #region SeachChangeClickOff event things for C# 3.0
        public event EventHandler<SeachChangeClickOffEventArgs> SeachChangeClickOff;

        protected virtual void OnSeachChangeClickOff(SeachChangeClickOffEventArgs e)
        {
            if (SeachChangeClickOff != null)
                SeachChangeClickOff(this, e);
        }

        private SeachChangeClickOffEventArgs OnSeachChangeClickOff()
        {
            SeachChangeClickOffEventArgs args = new SeachChangeClickOffEventArgs();
            OnSeachChangeClickOff(args);

            return args;
        }

        /*private SeachChangeClickOffEventArgs OnSeachChangeClickOffForOut()
        {
            SeachChangeClickOffEventArgs args = new SeachChangeClickOffEventArgs();
            OnSeachChangeClickOff(args);

            return args;
        }*/

        public class SeachChangeClickOffEventArgs : EventArgs
        {


            /*public SeachChangeClickOffEventArgs()
            {
            }

            public SeachChangeClickOffEventArgs()
            {

            }*/
        }
        #endregion

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int? id = cbbCites.Enabled ? (int?)cbbCites.SelectedValue : null;
            DateTime? startDate = dateTimePicker1.Enabled ?
                dateTimePicker1.Value : new DateTime(2011,12,31);
            DateTime? finishDate = dateTimePicker2.Enabled ?
               dateTimePicker2.Value : new DateTime(2019, 1, 1);
                     
            OnSearchClick(id, startDate, finishDate);
         }

        #region SearchClick event things for C# 3.0
        public event EventHandler<SearchClickEventArgs> SearchClick;

        protected virtual void OnSearchClick(SearchClickEventArgs e)
        {
            if (SearchClick != null)
                SearchClick(this, e);
        }

        private SearchClickEventArgs OnSearchClick(int? id, DateTime? stime, DateTime? ftime)
        {
            SearchClickEventArgs args = new SearchClickEventArgs(id, stime, ftime);
            OnSearchClick(args);

            return args;
        }

        private SearchClickEventArgs OnSearchClickForOut()
        {
            SearchClickEventArgs args = new SearchClickEventArgs();
            OnSearchClick(args);

            return args;
        }

        public class SearchClickEventArgs : EventArgs
        {
            public int? Id { get; set; }
            public DateTime? Stime { get; set; }
            public DateTime? Ftime { get; set; }

            public SearchClickEventArgs()
            {
            }

            public SearchClickEventArgs(int? id, DateTime? stime, DateTime? ftime)
            {
                Id = id;
                Stime = stime;
                Ftime = ftime;
            }
        }
        #endregion

        private void ChbCity_CheckedChanged(object sender, EventArgs e)
        {
            cbbCites.Enabled = chbCity.Checked;
        }

        private void ChbDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = chbDate.Checked;
            dateTimePicker2.Enabled = chbDate.Checked;
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            bdsCities.DataSource = DB.City.GetAll();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnWeek_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
        }

        private void BtnMonth_Click(object sender, EventArgs e)
        {
            MonthAddFunc(1);
        }

        public void MonthAddFunc(int month)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(month);
        }

        private void BtnMonth3_Click(object sender, EventArgs e)
        {
            MonthAddFunc(3);
        }

        private void BtnMonth6_Click(object sender, EventArgs e)
        {
            MonthAddFunc(6);
        }
    }
}
