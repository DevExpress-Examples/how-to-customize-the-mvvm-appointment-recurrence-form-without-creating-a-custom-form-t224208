using DevExpress.Xpf.Scheduler.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraScheduler;

namespace MVVMSchedulerApplication
{
    public class CustomRecurrenceDialogViewModel : RecurrenceDialogViewModel
    {
        public CustomRecurrenceDialogViewModel(AppointmentFormViewModel viewModel)
            : base(viewModel)
        {

        }
        private void HideRecurrenceTypes()
        {
            System.Collections.ObjectModel.ObservableCollection<RecurrenceType> availableRecurrenceTypes = this.AvailableRecurrenceTypes;
            for (int i = availableRecurrenceTypes.Count - 1; i >= 0; i--)
            {
                if (availableRecurrenceTypes[i] == DevExpress.XtraScheduler.RecurrenceType.Yearly ||
                    availableRecurrenceTypes[i] == DevExpress.XtraScheduler.RecurrenceType.Monthly)
                    availableRecurrenceTypes.RemoveAt(i);
            }
        }
        private void SetPredefinedValues()
        {
            this.RecurrenceInfo.WeekDays = WeekDays.WorkDays;
            this.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
            this.RecurrenceInfo.OccurrenceCount = 5;
        }
        public CustomRecurrenceDialogViewModel(AppointmentFormViewModel viewModel, bool readOnly)
            : base(viewModel, readOnly)
        {
            if (viewModel.IsNewAppointment)
            {
                SetPredefinedValues();
                HideRecurrenceTypes();

            }
        }
        public CustomRecurrenceDialogViewModel(AppointmentFormViewModel viewModel, DevExpress.XtraScheduler.RecurrenceType[] availableRecurrenceTypes)
            : base(viewModel, availableRecurrenceTypes)
        {

        }
        public CustomRecurrenceDialogViewModel(AppointmentFormViewModel viewModel, DevExpress.XtraScheduler.RecurrenceType[] availableRecurrenceTypes, bool readOnly)
            : base(viewModel, availableRecurrenceTypes, readOnly)
        {

        }

    }
}
