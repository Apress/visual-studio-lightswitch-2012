'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Linq
Imports Microsoft.LightSwitch.Model

Public Module CustomEditorHelper

    ' This method returns the Summary Property
    Public Function GetSummaryProperty(
       entityType As IEntityType) As IEntityPropertyDefinition

        Dim attribute As ISummaryPropertyAttribute =
            entityType.Attributes.OfType(
               Of ISummaryPropertyAttribute)().FirstOrDefault()

        If attribute IsNot Nothing AndAlso
           attribute.Property IsNot Nothing Then
            Return attribute.Property
        End If

        ' There's no Summary Property – return the first property
        Return GetFirstEntityProperty(entityType)

    End Function

    Private Function GetFirstEntityProperty(
       entityType As IEntityType) As IEntityPropertyDefinition

        'Simple type properties are non business types/ non navigation properties
        Dim simpleTypeProperties As IEnumerable(Of IEntityPropertyDefinition) =
            entityType.Properties.Where(
               Function(p) TypeOf p.PropertyType Is ISimpleType)

        ' Find the first string property, or the first one that can
        ' be represented as a string
        Dim defaultSummaryProperty As IEntityPropertyDefinition =
            simpleTypeProperties.FirstOrDefault(
                Function(p) GetBaseSystemType(p.PropertyType) Is GetType(String))

        If defaultSummaryProperty Is Nothing Then
            simpleTypeProperties.FirstOrDefault(Function(p) IsTextProperty(p))
        End If

        Return defaultSummaryProperty

    End Function

    ' This returns true if a property can be represented by a string  
    Public Function IsTextProperty(
       propertyDefinition As IPropertyDefinition) As Boolean

        Dim dataType As ISimpleType =
           TryCast(propertyDefinition.PropertyType, ISimpleType)
        If dataType IsNot Nothing Then
            Dim clrType As Type = GetBaseSystemType(dataType)
            Return clrType IsNot Nothing AndAlso
                clrType IsNot GetType(Byte())
        End If
        Return False
    End Function

    ' This returns the underlying type of a business type
    Public Function GetBaseSystemType(dataType As ISimpleType) As Type
        While dataType IsNot Nothing
            If TypeOf dataType Is IPrimitiveType Then
                ' Primitive types are foundation LightSwitch data types like:
                'String/Int32/Decimal/Date/...
                Return DirectCast(dataType, IPrimitiveType).ClrType
            ElseIf TypeOf dataType Is INullableType Then
                ' NullableType represents a Nullable version of 
                'any primitive or semantic (business) type.
                dataType = DirectCast(dataType, INullableType).UnderlyingType
            ElseIf TypeOf dataType Is ISemanticType Then
                dataType = DirectCast(dataType, ISemanticType).UnderlyingType
            End If
        End While
        Return Nothing
    End Function

    ' This returns a collection of properties for an entity
    Public Function GetTextPropertiesForEntity(
       dataType As IDataType) As IEnumerable(Of IPropertyDefinition)

        If dataType IsNot Nothing Then
            Return dataType.Properties _
                .Where(Function(p) CustomEditorHelper.IsTextProperty(p)) _
                .Cast(Of IPropertyDefinition)()
        End If
        Return Enumerable.Empty(Of IPropertyDefinition)()

    End Function

End Module
