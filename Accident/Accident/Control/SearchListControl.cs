using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accident.Data;
using Accident.From;

namespace Accident.Control
{
    public partial class SearchListControl : UserControl
    {
        public SearchListControl()
        {
            InitializeComponent();

        }

        public void SetDataSource(List<Incident> incidents)
        {
            bdsIncident.DataSource = incidents;
        }

        public void SetDataCount(int count)
        {
            sslCount.Text = count.ToString();
        }

        public void OptionCheck(bool _date, bool city, bool state, bool dnn, bool wod, bool death, bool serious, bool slight, bool injury, bool filed, bool type, bool violation, bool road, bool attacker, bool victim)
        {
            dgvInccident.Columns[0].Visible = _date;
            dgvInccident.Columns[1].Visible = city;
            dgvInccident.Columns[2].Visible = state;
            dgvInccident.Columns[3].Visible = dnn;
            dgvInccident.Columns[4].Visible = wod;
            dgvInccident.Columns[5].Visible = death;
            dgvInccident.Columns[6].Visible = serious;
            dgvInccident.Columns[7].Visible = slight;
            dgvInccident.Columns[8].Visible = injury;
            dgvInccident.Columns[9].Visible = filed;
            dgvInccident.Columns[10].Visible = type;
            dgvInccident.Columns[11].Visible = violation;
            dgvInccident.Columns[12].Visible = road;
            dgvInccident.Columns[13].Visible = attacker;
            dgvInccident.Columns[14].Visible = victim;

        }

        private void DgvInccident_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Incident incident = dgvInccident.CurrentRow.DataBoundItem as Incident;
            if (incident == null) return;
            
            LocationForm form = new LocationForm(incident);
            form.ShowDialog();

        }
    }
}
