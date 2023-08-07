using Grupo10.MedicalAppointments.Model.Entities;
using Grupo10.Mvc;

namespace Grupo10.MedicalAppointments.Gui.Views
{
    public partial class MedicalAppointmentsList : UserControl, IRenderData<IEnumerable<MedicalAppointment>>
    {
        private readonly BindingSource _bindingSource = new BindingSource();

        public MedicalAppointmentsList()
        {
            InitializeComponent();
            Initialize();
        }

        public event EventHandler<MedicalAppointment> EditMedicalAppointment;

        private void Initialize()
        {
            appointmentsGridView.AutoGenerateColumns = false;
            appointmentsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Name",
                Name = "Name",
            });
            appointmentsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Apellido",
                DataPropertyName = "LastName",
                Name = "LastName",
            });
            appointmentsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Identificación",
                DataPropertyName = "Identification",
                Name = "Identification",
            });
            appointmentsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Teléfono",
                DataPropertyName = "Phone",
                Name = "Phone",
            });
            appointmentsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha",
                DataPropertyName = "Date",
                Name = "Date",
            });
            appointmentsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Hora",
                DataPropertyName = "Date",
                Name = "Time",
            });
            appointmentsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Doctor",
                DataPropertyName = "Doctor",
                Name = "Doctor",
            });
            appointmentsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Especialidad",
                DataPropertyName = "Doctor",
                Name = "Speciality",
            });
            appointmentsGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Action",
                Text = "Editar",
                HeaderText = "",
                UseColumnTextForButtonValue = true,
            });
            appointmentsGridView.DataSource = _bindingSource;
        }

        public void RenderData(IEnumerable<MedicalAppointment> data)
        {
            _bindingSource.DataSource = data;
        }

        private void appointmentsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is not null && e.ColumnIndex == appointmentsGridView.Columns["Date"].Index)
            {
                e.Value = ((DateTime)e.Value).ToString("dd MMMM yyyy");
            }
            if (e.Value is not null && e.ColumnIndex == appointmentsGridView.Columns["Time"].Index)
            {
                e.Value = ((DateTime)e.Value).ToString("hh:mm tt");
            }
            if (e.Value is not null && e.ColumnIndex == appointmentsGridView.Columns["Doctor"].Index)
            {
                var doctor = e.Value as Doctor;
                if (doctor != null)
                {
                    e.Value = doctor.Name;
                }
                else
                {
                    e.Value = "N/A";
                }
            }
            if (e.Value is not null && e.ColumnIndex == appointmentsGridView.Columns["Speciality"].Index)
            {
                var doctor = e.Value as Doctor;
                if (doctor != null)
                {
                    e.Value = doctor.Speciality;
                }
                else
                {
                    e.Value = "N/A";
                }
            }
        }

        private void appointmentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != appointmentsGridView.Columns["Action"].Index)
            {
                return;
            }

            var appointment = _bindingSource.Current as MedicalAppointment;

            if (appointment == null)
            {
                return;
            }

            EditMedicalAppointment?.Invoke(this, appointment);
        }
    }
}
