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


        #region OptionCheck event things for C# 3.0
        public event EventHandler<OptionCheckEventArgs> OptionCheck;

        protected virtual void OnOptionCheck(OptionCheckEventArgs e)
        {
            if (OptionCheck != null)
                OptionCheck(this, e);
        }

        private OptionCheckEventArgs OnOptionCheck(bool dateTime, bool city, bool state, bool dayAndNight, bool dayOfWeek, bool deathCount, bool seriouslyCount, bool slightlyCount, bool injuryCount, bool accidentField, bool accidentType, bool violation, bool roadForm, bool attacker, bool victim)
        {
            OptionCheckEventArgs args = new OptionCheckEventArgs(dateTime, city, state, dayAndNight, dayOfWeek, deathCount, seriouslyCount, slightlyCount, injuryCount, accidentField, accidentType, violation, roadForm, attacker, victim);
            OnOptionCheck(args);

            return args;
        }

        private OptionCheckEventArgs OnOptionCheckForOut()
        {
            OptionCheckEventArgs args = new OptionCheckEventArgs();
            OnOptionCheck(args);

            return args;
        }

        public class OptionCheckEventArgs : EventArgs
        {
            public bool DateTime { get; set; }
            public bool City { get; set; }
            public bool State { get; set; }
            public bool DayAndNight { get; set; }
            public bool DayOfWeek { get; set; }
            public bool DeathCount { get; set; }
            public bool SeriouslyCount { get; set; }
            public bool SlightlyCount { get; set; }
            public bool InjuryCount { get; set; }
            public bool AccidentField { get; set; }
            public bool AccidentType { get; set; }
            public bool Violation { get; set; }
            public bool RoadForm { get; set; }
            public bool Attacker { get; set; }
            public bool Victim { get; set; }

            public OptionCheckEventArgs()
            {
            }

            public OptionCheckEventArgs(bool dateTime, bool city, bool state, bool dayAndNight, bool dayOfWeek, bool deathCount, bool seriouslyCount, bool slightlyCount, bool injuryCount, bool accidentField, bool accidentType, bool violation, bool roadForm, bool attacker, bool victim)
            {
                DateTime = dateTime;
                City = city;
                State = state;
                DayAndNight = dayAndNight;
                DayOfWeek = dayOfWeek;
                DeathCount = deathCount;
                SeriouslyCount = seriouslyCount;
                SlightlyCount = slightlyCount;
                InjuryCount = injuryCount;
                AccidentField = accidentField;
                AccidentType = accidentType;
                Violation = violation;
                RoadForm = roadForm;
                Attacker = attacker;
                Victim = victim;
            }
        }
        #endregion

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            
            OnOptionCheck(ccbDate.Checked, ccbCity.Checked, ccbState.Checked, ccbDNN.Checked, ccbDOW.Checked,
               ccbDeath.Checked, ccbSeriously.Checked, ccbSlight.Checked,
               ccbInjury.Checked, ccbAccientFiled.Checked, ccbAccidentType.Checked,
               ccbViolation.Checked, ccbLoadForm.Checked, ccbAttacker.Checked,
               ccbVictim.Checked);
        }
    }
}
