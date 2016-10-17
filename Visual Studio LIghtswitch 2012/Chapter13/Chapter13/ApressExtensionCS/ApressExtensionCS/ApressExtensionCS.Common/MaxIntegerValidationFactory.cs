//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Model;
using Microsoft.LightSwitch.Runtime.Rules;

//Listing 13-4. Creating the Validation Factory Code
namespace ApressExtensionCS
{
    [Export(typeof(IValidationCodeFactory))]
    [ValidationCodeFactory("ApressExtensionCS:@MaxIntegerValidationId")]      
    public class MaxIntegerValidationFactory : IValidationCodeFactory
    {
        public IAttachedValidation Create(IStructuralItem modelItem,
           IEnumerable<IAttribute> attributes)
        {
            // Enusre that the data type is a positive integer semantic
            // type (or nullable positive integer)
            if (!IsValid(modelItem))
            {
                throw new InvalidOperationException("Unsupported data type.");
            }
            return new MaxIntegerValidation (attributes);
        }

        public bool IsValid(IStructuralItem modelItem)
        {
            INullableType nullableType = modelItem as INullableType;

            // Get underlying type if it is an INullableType.
            modelItem = 
               null != nullableType ? nullableType.UnderlyingType : modelItem;

            // Ensure the type matches the business type, 
            // or the underlying type
            while (modelItem is ISemanticType)
            {
                if (String.Equals(((ISemanticType)modelItem).Id,
                   "ApressExtensionCS:DurationType",                        
                    StringComparison.Ordinal))
                {
                    return true;
                }
                modelItem = ((ISemanticType)modelItem).UnderlyingType;
            }

            //Don't apply the validation if the conditions aren't met
            return false;
        }
    }
}
