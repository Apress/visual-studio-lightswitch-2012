'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

'Listing 13-25. Domain Service Code for Accessing Data
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.ServiceModel.DomainServices.Server

Imports System.Configuration
Imports System.Web.Configuration
Imports System.Diagnostics.EventLog

Namespace DataSources

    <Description("Enter your server path.")> _
    Public Class WindowsEventLog
        Inherits DomainService

        Private _serverName As String

        Public Overrides Sub Initialize(context As DomainServiceContext)
            MyBase.Initialize(context)
        End Sub

        Public Overrides Function Submit(changeSet As ChangeSet) As Boolean
            Dim baseResult As [Boolean] = MyBase.Submit(changeSet)
            Return True
        End Function

#Region "Queries"

        Protected Overrides Function Count(Of T)(query As IQueryable(Of T)) As Integer
            Return query.Count()
        End Function

        <Query(IsDefault:=True)> _
        Public Function GetEventEntries() As IQueryable(Of LogEntry)

            Dim idCount As Integer = 0
            Dim eventLogs As New List(Of LogEntry)()
            Dim logSource As LogSource

            For Each eventSource In EventLog.GetEventLogs(".")

                logSource = New LogSource
                logSource.SourceName = eventSource.Log

                Try
                    For Each eventEntry As System.Diagnostics.EventLogEntry
                       In eventSource.Entries
                        Dim newEntry As New LogEntry
                        newEntry.LogEntryID = idCount

                        newEntry.EventDateTime = eventEntry.TimeWritten
                        newEntry.Message = eventEntry.Message
                        newEntry.Message = eventEntry.Source
                        newEntry.SourceName = eventSource.Log
                        newEntry.EventSource = logSource
                        eventLogs.Add(newEntry)

                        idCount += 1
                        If idCount > 200 Then
                            Exit For
                        End If

                    Next

                Catch ex As System.Security.SecurityException
                    'User doesn't have access to view the log
                    'Move onto the next log
                End Try
            Next

            Return eventLogs.AsQueryable
        End Function

        <Query(IsDefault:=True)> _
        Public Function GetEventLogTypes() As IQueryable(Of LogSource)

            Dim eventLogs As New List(Of LogSource)()
            For Each elEventEntry In System.Diagnostics.EventLog.GetEventLogs

                Dim event1 As New LogSource
                event1.SourceName = elEventEntry.Log
                eventLogs.Add(event1)
            Next

            Return eventLogs.AsQueryable
        End Function

        Public Sub InsertLogEntry(entry As LogEntry)
            Try
                Using applicationLog As New System.Diagnostics.EventLog("Application", ".")
                    applicationLog.Source = "Application"
                    applicationLog.WriteEntry(
                       entry.Message, EventLogEntryType.Warning)
                End Using

            Catch ex As Exception
                Throw New Exception("Error writing Event Log Entry" & ex.Message)
            End Try
        End Sub

        Public Sub UpdateLogEntry(entry As LogEntry)
        End Sub

        Public Sub DeleteLogEntry(entry As LogEntry)
        End Sub

#End Region

    End Class

End Namespace
