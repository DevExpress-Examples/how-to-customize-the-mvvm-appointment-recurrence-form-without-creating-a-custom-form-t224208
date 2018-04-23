// Developer Express Code Central Example:
// How to create a Custom Appointment Recurrence Dialog Using the MVVM Pattern
// 
// This example demonstrates how to use the MVVM approach to customize the default
// Appointment Recurrence dialog, which can be invoked by clicking the Recurrence
// button in the Edit Appointment form.
// 
// See also:
// How to: Create a Custom
// Appointment Recurrence Dialog Using the MVVM Pattern (step-by-step guide)
// (https://documentation.devexpress.com/#WPF/CustomDocument17568)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T181757

#region #usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
#endregion #usings

namespace MVVMSchedulerApplication.ViewModel
{
    #region #mybindinglist
    partial class MainViewModel
    {
        public BindingList<Doctor> Doctors { get; set; }
        public BindingList<HospitalAppointment> Appointments { get; set; }
        public MainViewModel() 
        {
            Doctors = new BindingList<Doctor>();
            Appointments = new BindingList<HospitalAppointment>();
            FillEmployees();
            FillTasks();
        }

        public class Doctor
        {
            public object Id { get; set; }
            public string Name { get; set; }
        }

        public class HospitalAppointment
        {
            public string PatientName { get; set; }
            public string Location { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string InsuranceNumber { get; set; }
            public bool FirstVisit { get; set; }
            public object DoctorId { get; set; }
            public string Notes { get; set; }
            public string Recurrence { get; set; }
            public int Type { get; set; }
        }
    }
    #endregion #mybindinglist
}
