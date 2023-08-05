using Grupo10.MedicalAppointments.Model.Entities;
using Grupo10.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo10.MedicalAppointments.Gui.Views
{
    public partial class MedicalAppointmentsList : UserControl, IRenderData<IEnumerable<MedicalAppointment>>
    {
        private readonly BindingSource _bindingSource = new BindingSource();

        public MedicalAppointmentsList()
        {
            InitializeComponent();
            appointmentsGridView.DataSource = _bindingSource;
        }

        public void RenderData(IEnumerable<MedicalAppointment> data)
        {
            _bindingSource.DataSource = data;
        }
    }
}
