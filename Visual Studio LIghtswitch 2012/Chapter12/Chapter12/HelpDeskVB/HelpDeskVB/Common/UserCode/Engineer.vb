'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class Engineer

        Private Sub Fullname_Compute(ByRef result As String)
            result = String.Format("{0} - {1}", Surname, Firstname)
        End Sub

        Private Sub Age_Compute(ByRef result As Integer)
            result = DateDiff(DateInterval.Year, DateOfBirth, Now)
        End Sub

        Private Sub IssueCount_Compute(ByRef result As Integer)
            result = Issues.Count()
        End Sub

    End Class

End Namespace
