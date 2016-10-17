'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Namespace LightSwitchApplication

    Public Class Setup

        'Listing 4-1. Creating a New Record
        Private Sub SetupData_Execute()
            'Dim statusRaised = Me.DataWorkspace.ApplicationData.IssueStatusSet.AddNew()
            'statusRaised.StatusDescription = "Open"
            'Me.DataWorkspace.ApplicationData.SaveChanges()
            'Bonus code for setting up other records
            AddPriorityIfNotExists("Low")
            AddPriorityIfNotExists("Medium")
            AddPriorityIfNotExists("High")
            AddStatusIfNotExists("Open")
            AddStatusIfNotExists("In Progress")
            AddStatusIfNotExists("Cancelled")
            AddStatusIfNotExists("Closed")
            AddDeptIfNotExists("Head Office")
            DataWorkspace.ApplicationData.SaveChanges()

        End Sub

        'Listing 4-4. Accessing the Currently Logged-On User  
        'this.Application.User  

        'Bonus code for setting up data
        Private Sub AddPriorityIfNotExists(PriorityDesc As String)
            If DataWorkspace.ApplicationData.Priorities.Where(Function(item) item.PriorityDesc = PriorityDesc).FirstOrDefault() Is Nothing Then
                Dim newPriority = DataWorkspace.ApplicationData.Priorities.AddNew()
                newPriority.PriorityDesc = PriorityDesc
            End If
        End Sub

        Private Sub AddStatusIfNotExists(StatusDesc As String)
            If DataWorkspace.ApplicationData.IssueStatusSet.Where(Function(item) item.StatusDescription = StatusDesc).FirstOrDefault() Is Nothing Then
                Dim newStatus = DataWorkspace.ApplicationData.IssueStatusSet.AddNew()
                newStatus.StatusDescription = StatusDesc
            End If
        End Sub

        Private Sub AddDeptIfNotExists(DeptDesc As String)
            If DataWorkspace.ApplicationData.Departments.Where(Function(item) item.DepartmentName = DeptDesc).FirstOrDefault() Is Nothing Then
                Dim newDept = DataWorkspace.ApplicationData.Departments.AddNew()
                newDept.DepartmentName = DeptDesc
                newDept.Address1 = "Address1"
                newDept.Address2 = "Address2"
                newDept.City = "City"
                newDept.Country = "Country"
                newDept.Postcode = "Postcode"
                newDept.DepartmentManager = "Manager"
            End If

        End Sub

        'Listing 4-2. Retrieving and Uupdating Rrecords
        Private Sub CloseAllIssues_Execute()
            Dim statusClosed =
               DataWorkspace.ApplicationData.IssueStatusSet_SingleOrDefault(1)

            For Each issue As Issue In
                  Me.DataWorkspace.ApplicationData.Issues
                issue.IssueStatus = statusClosed
            Next
            Me.DataWorkspace.ApplicationData.SaveChanges()

        End Sub

        'Listing 4-3. Deleting Rrecords
        Private Sub DeleteAllIssues_Execute()
            For Each issue As Issue In Me.DataWorkspace.ApplicationData.Issues
                issue.Delete()
            Next
            Me.DataWorkspace.ApplicationData.SaveChanges()
        End Sub
    End Class

End Namespace
