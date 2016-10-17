//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApressExtensionCS
{
    public class LogEntry
    {
        [Key(), Editable(false), ScaffoldColumn(false),
           Display(Name = "Log Entry ID")]
        public int LogEntryID { get; set; }

        [Required(), Display(Name = "Message")]
        public string Message { get; set; }

        [Display(Name = "Source Name")]
        public string SourceName { get; set; }

        [Association("EventLog_EventEntry", "SourceName", "SourceName",
             IsForeignKey = true)]
        public LogSource EventSource { get; set; }

        [Required(), Display(Name = "Event DateTime")]
        public DateTime EventDateTime { get; set; }
    }

    public class LogSource
    {
        [Key(), Editable(false), ScaffoldColumn(false),
           Required(), Display(Name = "Source Name")]
        public string SourceName { get; set; }

        [Association("EventLog_EventEntry", "SourceName", "SourceName"),
            Display(Name = "EventLogEntries")]
        public ICollection<LogEntry> EventEntries { get; set; }
    }

}
