﻿using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class EngineerTimeTracking
    {
        partial void Engineer_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
        }

        partial void Engineer_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
        }

        partial void EngineerTimeTracking_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Engineer);
        }

        // Listing 6-6. Querying an EntityCollection  
        partial void MergeDuplicateIssues_Execute()
        {
            var duplicates =
                from TimeTracking timeEntry in this.Engineer.TimeTracking
                group timeEntry by timeEntry.Issue into issueGroup
                where issueGroup.Count() > 1
                select issueGroup;

            foreach (var dup in duplicates)
            {
                var totalDuration =
                    dup.Sum(timeEntry => timeEntry.DurationMins);
                var firstEntry = dup.First();
                firstEntry.DurationMins = totalDuration;
                dup.Except(
                    new TimeTracking[] { firstEntry }).ToList().ForEach(
                    timeEntry => timeEntry.Delete());
            }

        }
    }
}