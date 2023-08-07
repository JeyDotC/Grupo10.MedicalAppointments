namespace Grupo10.MedicalAppointments.Model.Entities
{
    public class MedicalAppointment
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Identification { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        public Doctor Doctor { get; set; } = new Doctor();
    }
}