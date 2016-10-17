//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

//Listing 13-5. Creating the Validation Class

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Model;
using Microsoft.LightSwitch.Runtime.Rules;

public class MaxIntegerValidation : IAttachedPropertyValidation
{
    public MaxIntegerValidation (IEnumerable<IAttribute> attributes)
    {
        _attributes = attributes;
    }

    private IEnumerable<IAttribute> _attributes;

    public void Validate(object value,                                         
        IPropertyValidationResultsBuilder results)
    {
        if (null != value)
        {
            // Ensure the value type is integer.
            if (typeof(Int32) != value.GetType())
            {
                throw new InvalidOperationException("Unsupported data type.");
            }

            IAttribute validationAttribute = _attributes.FirstOrDefault();    
            if (validationAttribute != null &&
                validationAttribute.Class != null &&
                validationAttribute.Class.Id == 
                   "ApressExtensionCS:@MaxIntegerValidationId")               
            {

                int intValue = (int)value;
                int intMaxDays = (int)validationAttribute["MaxDays"];

                //There are 1440 minutes in a day
                if (intMaxDays > 0 && intValue > (intMaxDays * 1440))
                {
                    results.AddPropertyResult(
                       "Max value must be less than " + intMaxDays.ToString() +
                       " days", ValidationSeverity.Error);
                }
            }
        }
    }
}
