//You can use and redistribute the code from this book (and sample application) for non-commercial and 
//most commercial purposes as long as you acknowledge the source and authorship. 
//You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
//The acknowledgment should include author, title, publisher, and ISBN. 
//An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

using System;
using System.Linq;
using Microsoft.LightSwitch.Model;
using System.Collections.Generic;

public static class CustomEditorHelper
{
    // This method returns the Summary Property
    public static IEntityPropertyDefinition GetSummaryProperty(
       IEntityType entityType)
    {
        ISummaryPropertyAttribute attribute =
            entityType.Attributes.OfType
            <ISummaryPropertyAttribute>().FirstOrDefault();

        if (attribute != null && attribute.Property != null)
        {
            return attribute.Property;
        }

        // There's no Summary Property – return the first property
        return GetFirstEntityProperty(entityType);
    }

    private static IEntityPropertyDefinition GetFirstEntityProperty(
       IEntityType entityType)
    {
        // Simple types are non business types/ non navigation properties
        IEnumerable<IEntityPropertyDefinition> simpleTypeProperties =
            entityType.Properties.Where(p => p.PropertyType is ISimpleType);

        // Find the first string property, or the first one that can
        // be represented as a string
        IEntityPropertyDefinition defaultSummaryProperty =
            simpleTypeProperties.FirstOrDefault(
               p => CustomEditorHelper.GetBaseSystemType(
                   (ISimpleType)p.PropertyType) == typeof(string)) ??
            simpleTypeProperties.FirstOrDefault(
               p => CustomEditorHelper.IsTextProperty(p));

        return defaultSummaryProperty;
    }

    // This returns true if a property can be represented by a string  
    public static bool IsTextProperty(IPropertyDefinition propertyDefinition)
    {
        ISimpleType dataType =
            propertyDefinition.PropertyType as ISimpleType;
        if (dataType != null)
        {
            Type clrType = GetBaseSystemType(dataType);
            return clrType != null &&
                !object.ReferenceEquals(clrType, typeof(byte[]));
        }
        return false;
    }

    // This returns the underlying type of a business type
    public static Type GetBaseSystemType(ISimpleType dataType)
    {
        while (dataType != null)
        {
            if (dataType is IPrimitiveType)
            {
                // Primitive types are foundation LightSwitch data types like:
                // String/Int32/Decimal/Date/...
                return ((IPrimitiveType)dataType).ClrType;
            }
            else if (dataType is INullableType)
            {
                // NullableType represents a Nullable version of 
                // any primitive or semantic (business) type.
                dataType = ((INullableType)dataType).UnderlyingType;
            }
            else if (dataType is ISemanticType)
            {
                dataType = ((ISemanticType)dataType).UnderlyingType;
            }
        }
        return null;
    }

    // This returns a collection of properties for an entity
    public static IEnumerable<IPropertyDefinition>
        GetTextPropertiesForEntity(IDataType dataType)
    {
        if (dataType != null)
        {
            return dataType.Properties.Where(
                p => CustomEditorHelper.IsTextProperty(p)
                ).Cast<IPropertyDefinition>();
        }
        return Enumerable.Empty<IPropertyDefinition>();
    }
}
