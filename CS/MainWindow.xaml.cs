using DevExpress.Xpf.Scheduler.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Mvvm.POCO;

namespace MVVMSchedulerApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Scheduler.RecurrenceFormShowing += Scheduler_RecurrenceFormShowing;
            
        }

        void Scheduler_RecurrenceFormShowing(object sender, DevExpress.Xpf.Scheduler.RecurrenceFormEventArgs e)
        {
            AppointmentFormViewModel viewModel = e.AppointmentFormViewModel;
            e.ViewModel = ViewModelSource.Create(() =>
               new CustomRecurrenceDialogViewModel(viewModel, e.ReadOnly)
           );
        }

      
       
    }
}