Imports System.ComponentModel.Composition
Imports Microsoft.LightSwitch.Runtime.Rules
Imports Microsoft.LightSwitch.Model



<Export(GetType(IValidationCodeFactory))>
<ValidationCodeFactory("ApressExtensionVB:@MaxIntegerValidationId")>
Public Class MaxIntegerValidationFactory
    Implements IValidationCodeFactory

    Public Function Create(
       modelItem As Microsoft.LightSwitch.Model.IStructuralItem,
       attributes As System.Collections.Generic.IEnumerable(
          Of Microsoft.LightSwitch.Model.IAttribute)) As Microsoft.LightSwitch.Runtime.Rules.IAttachedValidation Implements Microsoft.LightSwitch.Runtime.Rules.IValidationCodeFactory.Create

        If Not IsValid(modelItem) Then
            Throw New InvalidOperationException("Unsupported data type.")
        End If
        Return New MaxIntegerValidation(attributes)
    End Function

    Public Function IsValid(modelItem As Microsoft.LightSwitch.Model.IStructuralItem) As Boolean Implements Microsoft.LightSwitch.Runtime.Rules.IValidationCodeFactory.IsValid

        Dim nullableType As INullableType = TryCast(modelItem, INullableType)

        ' Get underlying type if it is a INullableType.
        modelItem =
           If(nullableType IsNot Nothing, nullableType.UnderlyingType, modelItem)

        ' Ensure the type is an integer type, or that a type inherits from it.
        While TypeOf modelItem Is ISemanticType
            If String.Equals(DirectCast(modelItem, ISemanticType).Id,
               "ApressExtensionVB:DurationType",
                  StringComparison.Ordinal) Then
                Return True
            End If
            modelItem = DirectCast(modelItem, ISemanticType).UnderlyingType
        End While
        ' Don't apply the validation if the conditions aren't met
        Return False

    End Function
End Class

