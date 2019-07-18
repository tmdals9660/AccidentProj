using Accident.Data;
using Accident.Helpers;
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
    public partial class InsertForm : Form
    {
        private Incident _incident;

        public InsertForm()
        {
            InitializeComponent();

            Incident incident = new Incident();
            _incident = incident;


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bdsState.DataSource = DB.State.CityValues((int)cbbCity.SelectedValue);
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

            bdsCity.DataSource = DB.City.GetAll();
            //MessageBox.Show($"{cbbCity.SelectedValue.ToString()}");
            //bdsState.DataSource = DB.State.GetAll();
            bdsState.DataSource = DB.State.CityValues((int)cbbCity.SelectedValue);
            bdsAccidentFiled.DataSource = DB.AccidentFiled.GetAll();
            bdsAccidentType.DataSource = DB.AccidentType.GetAll();
            bdsViolation.DataSource = DB.Violation.GetAll();
            bdsRoadForm.DataSource = DB.RoadForm.GetAll();
            bdsAttacker.DataSource = DB.AttackerType.GetAll();
            bdsVictim.DataSource = DB.VictimType.GetAll();

            DtpSetDay();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {

            if (InputCheck())
            {
                WriteToEntity();                

                if (FormHelper.SureToAddIncident())
                {
                    if (_incident.IncidentId == 0)
                        DB.Incident.Insert(_incident);
                    else
                        DB.Incident.Update(_incident);

                    FormHelper.AddIncidentSucces();

                    Close();

                }

            }
            else FormHelper.AddIncidentFail();




        }

        private void WriteToEntity()
        {
            _incident.DateAndTime = dtpInsert.Value;
            _incident.DayNight = txbDayAndNight.Text;
            _incident.DayOfWeek = txbDayOfWeeks.Text;
            _incident.DeadCount = Convert.ToInt32(txbDeathCount.Text);
            _incident.SeriouslyCount = Convert.ToInt32(txbSeriouslyCount.Text);
            _incident.SlightlyCount = Convert.ToInt32(txbSlightlyCount.Text);
            _incident.InjuryCount = Convert.ToInt32(txbInjuerlyCount.Text);
            _incident.AccidentFiledId = (int)cbbField.SelectedValue;
            _incident.AccidentTypeId = (int)cbbType.SelectedValue;
            _incident.ViolationId = (int)cbbViolation.SelectedValue;
            _incident.RoadFormId = (int)cbbRoadform.SelectedValue;
            _incident.AttackerId = (int)cbbAttacker.SelectedValue;
            _incident.VictimId = (int)cbbVictim.SelectedValue;

            _incident.CityId = (int)cbbCity.SelectedValue;
            _incident.StateId = (int)cbbState.SelectedValue;
            _incident.Ratitude = Convert.ToDouble(txbRatitude.Text);
            _incident.Longitude = Convert.ToDouble(txbLongitude.Text);

        }
        public bool InputCheck()
        {
            bool check = true;


            if (txbDeathCount.Text == string.Empty) check = false;
            if (txbSeriouslyCount.Text == string.Empty) check = false;
            if (txbSlightlyCount.Text == string.Empty) check = false;
            if (txbInjuerlyCount.Text == string.Empty) check = false;
            if (txbRatitude.Text == string.Empty) check = false;
            if (txbLongitude.Text == string.Empty) check = false;

            return check;
        }

        private void DtpInsert_ValueChanged(object sender, EventArgs e)
        {

            DtpSetDay();
        }

        private void DtpSetDay()
        {
            txbDayOfWeeks.Text = dtpInsert.Value.ToString("dddd");

            int hour = dtpInsert.Value.Hour;

            string DayNight = "주";

            if (hour >= 18 || hour < 6) DayNight = "야";

            txbDayAndNight.Text = DayNight;
        }
    }
}
