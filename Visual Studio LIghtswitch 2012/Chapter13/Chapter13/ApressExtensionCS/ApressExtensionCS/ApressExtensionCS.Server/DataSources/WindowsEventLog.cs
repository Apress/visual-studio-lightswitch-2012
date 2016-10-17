//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel.DomainServices.Server;
using System.Diagnostics;

namespace ApressExtensionCS.DataSources
{
    public class WindowsEventLog : DomainService
    {

        private string _serverName;
        public override void Initialize(DomainServiceContext context)
        {
            base.Initialize(context);
        }

        public override bool Submit(ChangeSet changeSet)
        {
            Boolean baseResult = base.Submit(changeSet);
            return true;
        }

        protected override int Count<T>(IQueryable<T> query)
        {
            return query.Count();
        }

        [Query(IsDefault = true)]                                              
        public IQueryable<LogEntry> GetEventEntries()
        {

            int idCount = 0;
            List<LogEntry> eventLogs = new List<LogEntry>();
            LogSource logSource = default(LogSource);

            foreach (var eventSource in EventLog.GetEventLogs("."))
            {
                logSource = new LogSource();
                logSource.SourceName = eventSource.Log;

                try
                {
                    foreach (System.Diagnostics.EventLogEntry eventEntry 
                       in eventSource.Entries)
                    {
                        LogEntry newEntry = new LogEntry();
                        newEntry.LogEntryID = idCount;

                        newEntry.EventDateTime = eventEntry.TimeWritten;
                        newEntry.Message = eventEntry.Message;
                        newEntry.Message = eventEntry.Source;
                        newEntry.SourceName = eventSource.Log;
                        newEntry.EventSource = logSource;
                        eventLogs.Add(newEntry);

                        idCount += 1;
                        if (idCount > 200)
                        {
                            break;  
                        }
                    }
                }
                catch (System.Security.SecurityException ex)
                {
                    //User doesn't have access to view the log
                    //Move onto the next log
                }
            }

            return eventLogs.AsQueryable();
        }

        [Query(IsDefault = true)]                                          
        public IQueryable<LogSource> GetEventLogTypes()
        {

            List<LogSource> eventLogs = new List<LogSource>();

            foreach (var elEventEntry in
               System.Diagnostics.EventLog.GetEventLogs())
            {
                LogSource event1 = new LogSource();
                event1.SourceName = elEventEntry.Log;
                eventLogs.Add(event1);
            }

            return eventLogs.AsQueryable();
        }

        public void InsertLogEntry(LogEntry entry)
        {
            try
            {
                using (System.Diagnostics.EventLog applicationLog =  
                   new System.Diagnostics.EventLog("Application", "."))
                {
                    applicationLog.Source = "Application";
                    applicationLog.WriteEntry(
                      entry.Message, EventLogEntryType.Warning);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(
                  "Error writing Event Log Entry" + ex.Message);
            }
        }

        public void UpdateLogEntry(LogEntry entry)
        {}

        public void DeleteLogEntry(LogEntry entry)
        {}
    }
}
