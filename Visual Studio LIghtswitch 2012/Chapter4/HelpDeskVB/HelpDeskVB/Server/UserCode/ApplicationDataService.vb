'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Transactions
Imports System.Text

Namespace LightSwitchApplication

    Public Class ApplicationDataService


        'Listing 4-5. Retrieving Original Values in Code
        Private Sub Issues_Updating(entity As Issue)

            Dim issueHistory As IssueStatusChange =
            Me.DataWorkspace.ApplicationData.IssueStatusChanges.AddNew()

            issueHistory.OldStatus =
                entity.Details.Properties.IssueStatus.OriginalValue

            issueHistory.NewStatus = entity.IssueStatus
            issueHistory.Issue = entity
            issueHistory.ChangeDate = DateTime.UtcNow

        End Sub


        'Listing 4-7. Creating Your Own Transaction Scope

        Dim transaction As TransactionScope

        Private Sub SaveChanges_Executing()

            Dim transactionOptions = New TransactionOptions()
            transactionOptions.IsolationLevel = IsolationLevel.ReadCommitted

            'Create an audit record as part of the transaction                      
            Me.transaction = New TransactionScope(
               TransactionScopeOption.Required, transactionOptions)

            Dim auditDesc As StringBuilder =
               New StringBuilder("Changes " + DateTime.Now.ToString() + " :")
            For Each changedEntity In
               Me.DataWorkspace.ApplicationData.Details.GetChanges()

                auditDesc.AppendLine(changedEntity.Details.Entity.ToString())
            Next

            Using dataworkspace2 = Me.Application.CreateDataWorkspace()
                Dim auditRecord = dataworkspace2.AuditDataSource.AuditDetails.AddNew
                auditRecord.AuditDesc = auditDesc.ToString()
                dataworkspace2.AuditDataSource.SaveChanges()
                auditRecord.AuditDate = Date.Now
            End Using

        End Sub

        Private Sub SaveChanges_Executed()
            'Commit the transaction                                                 
            Me.transaction.Complete()
            Me.transaction.Dispose()
        End Sub

        Private Sub SaveChanges_ExecuteFailed(exception As System.Exception)
            'Rollback the transaction on an error                                   
            Me.transaction.Dispose()
        End Sub


    End Class

End Namespace
