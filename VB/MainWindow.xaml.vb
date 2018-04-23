Imports DevExpress.Xpf.Scheduler.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Mvvm.POCO

Namespace MVVMSchedulerApplication
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            AddHandler Scheduler.RecurrenceFormShowing, AddressOf Scheduler_RecurrenceFormShowing

        End Sub

        Private Sub Scheduler_RecurrenceFormShowing(ByVal sender As Object, ByVal e As DevExpress.Xpf.Scheduler.RecurrenceFormEventArgs)
            Dim viewModel As AppointmentFormViewModel = e.AppointmentFormViewModel
            e.ViewModel = ViewModelSource.Create(Function() New CustomRecurrenceDialogViewModel(viewModel, e.ReadOnly))
        End Sub



    End Class
End Namespace