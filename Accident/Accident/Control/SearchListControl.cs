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

        public void FilterCheck(bool _date, bool dnn, bool wod, bool death, bool serious, bool slight, bool injury, bool filed, bool type, bool violation, bool road, bool attacker, bool victim)
        {
            dgvInccident.Columns[0].Visible = _date;
            dgvInccident.Columns[1].Visible = dnn;
            dgvInccident.Columns[2].Visible = wod;
            dgvInccident.Columns[3].Visible = death;
            dgvInccident.Columns[4].Visible = serious;
            dgvInccident.Columns[5].Visible = slight;
            dgvInccident.Columns[6].Visible = injury;
            dgvInccident.Columns[7].Visible = filed;
            dgvInccident.Columns[8].Visible = type;
            dgvInccident.Columns[9].Visible = violation;
            dgvInccident.Columns[10].Visible = road;
            dgvInccident.Columns[11].Visible = attacker;
            dgvInccident.Columns[12].Visible = victim;

        }
    }
}
