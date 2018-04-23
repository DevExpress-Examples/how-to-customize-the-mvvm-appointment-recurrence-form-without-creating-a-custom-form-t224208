Imports DevExpress.Xpf.Scheduler.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraScheduler

Namespace MVVMSchedulerApplication
    Public Class CustomRecurrenceDialogViewModel
        Inherits RecurrenceDialogViewModel

        Public Sub New(ByVal viewModel As AppointmentFormViewModel)
            MyBase.New(viewModel)

        End Sub
        Private Sub HideRecurrenceTypes()
            Dim availableRecurrenceTypes As System.Collections.ObjectModel.ObservableCollection(Of RecurrenceType) = Me.AvailableRecurrenceTypes
            For i As Integer = availableRecurrenceTypes.Count - 1 To 0 Step -1
                If availableRecurrenceTypes(i) = DevExpress.XtraScheduler.RecurrenceType.Yearly OrElse availableRecurrenceTypes(i) = DevExpress.XtraScheduler.RecurrenceType.Monthly Then
                    availableRecurrenceTypes.RemoveAt(i)
                End If
            Next i
        End Sub
        Private Sub SetPredefinedValues()
            Me.RecurrenceInfo.WeekDays = WeekDays.WorkDays
            Me.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            Me.RecurrenceInfo.OccurrenceCount = 5
        End Sub
        Public Sub New(ByVal viewModel As AppointmentFormViewModel, ByVal [readOnly] As Boolean)
            MyBase.New(viewModel, [readOnly])
            If viewModel.IsNewAppointment Then
                SetPredefinedValues()
                HideRecurrenceTypes()

            End If
        End Sub
        Public Sub New(ByVal viewModel As AppointmentFormViewModel, ByVal availableRecurrenceTypes() As DevExpress.XtraScheduler.RecurrenceType)
            MyBase.New(viewModel, availableRecurrenceTypes)

        End Sub
        Public Sub New(ByVal viewModel As AppointmentFormViewModel, ByVal availableRecurrenceTypes() As DevExpress.XtraScheduler.RecurrenceType, ByVal [readOnly] As Boolean)
            MyBase.New(viewModel, availableRecurrenceTypes, [readOnly])

        End Sub

    End Class
End Namespace
