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
    public partial class SearchFilterControl : UserControl
    {
        public SearchFilterControl()
        {
            InitializeComponent();
        }




        #region FilterCheck event things for C# 3.0
        public event EventHandler<FilterCheckEventArgs> FilterCheck;

        protected virtual void OnFilterCheck(FilterCheckEventArgs e)
        {
            if (FilterCheck != null)
                FilterCheck(this, e);
        }

        private FilterCheckEventArgs OnFilterCheck(bool _date, bool dnn, bool wod, bool death, bool serious, bool slight, bool injury, bool filed, bool type, bool violation, bool road, bool attacker, bool victim)
        {
            FilterCheckEventArgs args = new FilterCheckEventArgs(_date, dnn, wod, death, serious, slight, injury, filed, type, violation, road, attacker, victim);
            OnFilterCheck(args);

            return args;
        }

        private FilterCheckEventArgs OnFilterCheckForOut()
        {
            FilterCheckEventArgs args = new FilterCheckEventArgs();
            OnFilterCheck(args);

            return args;
        }

        public class FilterCheckEventArgs : EventArgs
        {
            public bool __date { get; set; }
            public bool Dnn { get; set; }
            public bool Wod { get; set; }
            public bool Death { get; set; }
            public bool Serious { get; set; }
            public bool Slight { get; set; }
            public bool Injury { get; set; }
            public bool Filed { get; set; }
            public bool Type { get; set; }
            public bool Violation { get; set; }
            public bool Road { get; set; }
            public bool Attacker { get; set; }
            public bool Victim { get; set; }

            public FilterCheckEventArgs()
            {
            }

            public FilterCheckEventArgs(bool _date, bool dnn, bool wod, bool death, bool serious, bool slight, bool injury, bool filed, bool type, bool violation, bool road, bool attacker, bool victim)
            {
                __date = _date;
                Dnn = dnn;
                Wod = wod;
                Death = death;
                Serious = serious;
                Slight = slight;
                Injury = injury;
                Filed = filed;
                Type = type;
                Violation = violation;
                Road = road;
                Attacker = attacker;
                Victim = victim;
            }
        }
        #endregion

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            OnFilterCheck(ccbDate.Checked, ccbDNN.Checked, ccbDOW.Checked,
                ccbDeath.Checked, ccbSeriously.Checked, ccbSlight.Checked,
                ccbInjury.Checked, ccbAccientFiled.Checked, ccbAccidentType.Checked,
                ccbViolation.Checked, ccbLoadForm.Checked, ccbAttacker.Checked,
                ccbVictim.Checked);
        }
    }
}
