// You can use and redistribute the code from this book (and sample application) for non-commercial and 
// most commercial purposes as long as you acknowledge the source and authorship. 
// You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
// The acknowledgment should include author, title, publisher, and ISBN. 
// An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Text;
using System.Transactions;

namespace LightSwitchApplication
{
    partial  class ApplicationDataService
    {

        //Listing 4-5. Retrieving Original Values in Code
        partial void Issues_Updating(Issue entity)
        {
            IssueStatusChange issueHistory =
                this.DataWorkspace.ApplicationData.
                IssueStatusChanges.AddNew();

            issueHistory.OldStatus =
                entity.Details.Properties.IssueStatus.OriginalValue;

            issueHistory.NewStatus = entity.IssueStatus;
            issueHistory.Issue = entity;
            issueHistory.ChangeDate = DateTime.UtcNow;
        }



        //Listing 4-7. Creating Your Own Transaction Scope

        TransactionScope transaction;

        partial void SaveChanges_Executing()
        {
            TransactionOptions transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = IsolationLevel.ReadCommitted;

            //Create an audit record as part of the transaction                   
            this.transaction = new TransactionScope(
                TransactionScopeOption.Required, transactionOptions);

            StringBuilder auditDesc =
                new StringBuilder("Changes " + DateTime.Now.ToString() + " :");
            foreach (var changedEntity in
                this.DataWorkspace.ApplicationData.Details.GetChanges())
            {
                auditDesc.AppendLine(changedEntity.Details.Entity.ToString());
            }

            using (var dataworkspace2 = this.Application.CreateDataWorkspace())
            {
                AuditDetail auditRecord =
                    dataworkspace2.AuditDataSource.AuditDetails.AddNew();
                auditRecord.AuditDesc = auditDesc.ToString();
                auditRecord.AuditDate = DateTime.Now;
                dataworkspace2.AuditDataSource.SaveChanges();
            }
        }

        partial void SaveChanges_Executed()
        {
            //Commit the transaction                                              
            this.transaction.Complete();
            this.transaction.Dispose();
        }

        partial void SaveChanges_ExecuteFailed(System.Exception exception)
        {
            //Rollback the transaction on an error                                
            this.transaction.Dispose();
        }

    }
}

