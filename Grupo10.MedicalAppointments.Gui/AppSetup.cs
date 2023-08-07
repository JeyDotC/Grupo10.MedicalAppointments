using Grupo10.MedicalAppointments.Gui.Controllers;
using Grupo10_MedicalAppointments.MySQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.MedicalAppointments.Gui
{
    internal class AppSetup
    {
        public static void Setup(MainWindow mainWindow)
        {
            var appState = new AppState();
            var connectionString = ConfigurationManager.ConnectionStrings["mainConnection"].ConnectionString;
            var db = new Database(connectionString);
            var medicalAppointmentsRepository = new MedicalAppointmentsRepositoryMySQL(db);
            var doctorsRepository = new DoctorsRepositoryMySql(db);

            new MedicalAppointmentsListController(
                 state: appState,
                 view: mainWindow.medicalAppointmentsList,
                 medicalAppointmentsRepository
             ).Setup();

            new MedicalAppointmentsEditorController(
                state: appState,
                view: mainWindow.medicalAppointmentsEditor,
                doctorsRepository,
                medicalAppointmentsRepository
            ).Setup();
        }
    }
}
