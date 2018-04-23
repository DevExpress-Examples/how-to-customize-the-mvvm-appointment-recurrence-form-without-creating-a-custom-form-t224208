' Developer Express Code Central Example:
' How to create a Custom Appointment Recurrence Dialog Using the MVVM Pattern
' 
' This example demonstrates how to use the MVVM approach to customize the default
' Appointment Recurrence dialog, which can be invoked by clicking the Recurrence
' button in the Edit Appointment form.
' 
' See also:
' How to: Create a Custom
' Appointment Recurrence Dialog Using the MVVM Pattern (step-by-step guide)
' (https://documentation.devexpress.com/#WPF/CustomDocument17568)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T181757

#Region "#usings"
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
#End Region ' #usings

Namespace MVVMSchedulerApplication.ViewModel
    #Region "#mybindinglist"
    Partial Friend Class MainViewModel
        Public Property Doctors() As BindingList(Of Doctor)
        Public Property Appointments() As BindingList(Of HospitalAppointment)
        Public Sub New()
            Doctors = New BindingList(Of Doctor)()
            Appointments = New BindingList(Of HospitalAppointment)()
            FillEmployees()
            FillTasks()
        End Sub

        Public Class Doctor
            Public Property Id() As Object
            Public Property Name() As String
        End Class

        Public Class HospitalAppointment
            Public Property PatientName() As String
            Public Property Location() As String
            Public Property StartTime() As Date
            Public Property EndTime() As Date
            Public Property InsuranceNumber() As String
            Public Property FirstVisit() As Boolean
            Public Property DoctorId() As Object
            Public Property Notes() As String
            Public Property Recurrence() As String
            Public Property Type() As Integer
        End Class
    End Class
    #End Region ' #mybindinglist
End Namespace
