'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class LogEntry

    <Key()> _
     <[ReadOnly](True)> _
     <Display(Name:="Log Entry ID")> _
     <ScaffoldColumn(False)> _
    Public Property LogEntryID As Integer

    <Required()> _
    <Display(Name:="Message")> _
    Public Property Message() As String

    <Display(Name:="Source Name")> _
    Public Property SourceName As String

    <Association("EventLog_EventEntry",
       "SourceName", "SourceName", IsForeignKey:=True)> _
    <Display(Name:="Source")> _
    Public Property EventSource As LogSource

    <Display(Name:="Event DateTime")> _
    Public Property EventDateTime() As DateTime

End Class

Public Class LogSource

    <Key()> _
     <[ReadOnly](True)> _
     <Display(Name:="Source Name")> _
     <ScaffoldColumn(False)> _
     <Required()> _
    Public Property SourceName As String

    <Association("EventLog_EventEntry", "SourceName", "SourceName")> _
    <Display(Name:="EventLogEntries")> _
    Public Property EventEntries As ICollection(Of LogEntry)

End Class
