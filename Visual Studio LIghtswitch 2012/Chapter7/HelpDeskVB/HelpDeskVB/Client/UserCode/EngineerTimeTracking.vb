'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".


Namespace LightSwitchApplication

    Public Class EngineerTimeTracking

        Private Sub Engineer_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        Private Sub Engineer_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        Private Sub EngineerTimeTracking_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Engineer)
        End Sub

        ' Listing 6-6. Querying an EntityCollection  
        Private Sub MergeDuplicateIssues_Execute()

            Dim duplicates =
                From timeEntry In Engineer.TimeTrackings
                Group timeEntry By timeEntry.Issue Into issueGroup = Group, Count()
                Where issueGroup.Count() > 1
                Select issueGroup

            For Each dup In duplicates
                Dim totalDuration = dup.Sum(Function(timeEntry) timeEntry.DurationMins)
                Dim firstLine = dup.First
                firstLine.DurationMins = totalDuration
                dup.Except(New TimeTracking() {firstLine}).ToList().ForEach(
                   Sub(timeEntry) timeEntry.Delete())
            Next

        End Sub
    End Class

End Namespace