
Namespace LightSwitchApplication

    Public Class Issue

        Private Sub Icon_Compute(ByRef result As Byte())
            ' Set result to the desired field value

            If TargetEndDateTime < DateTime.Now Then
                Dim base64EncodedImage = "iVBORw0KGgoAAAANSUhEUgAAAA4AAAAOCAYAAAAfSC3RAAAABGdBTUEAANbY1E9YMgAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAGWSURBVHjaYvz//z8DDKzu5mEGUmlA7AfEolDh+0C8OLT0yyYGJMAI0wjUlMDIyDBfSf83g5TKXwZ2Loj41w9MDA+vsTA8u8O8HsidDjRgN1gCpHFVF3fOttmc/98+YwJx/585w/C/o4Ph/927YGkwfnKL+f+GSVz/gWqdwJYBGUJrern/f3zDBFfk4sIAsg6sGSYGwo9vsIA0rgZxmIAKMtVNfzPwCf9jIARk1P+AvBEC9JYfSGMISIBYIKMGVhsC0qjIzf8fRdLYGEIrKWFq5OIDq5VjwmaqoCAqjRINjGCKGaTxxY+vjAz4DEAGULUvWIDE1uf3mNV5hRCBk5aG6mRkAFQLoraCbJx+7Rgrw7dPCFtXr2Zg2LOHgeHsWVRNrx8zMzy4wnIQmAgWMAGJO79/Mlae2MzB8OsHRDNIEwzDwJf3TAyntrGDmNPRk1wLB/f/ajWT3wxMXP8Y7j35x+Bgx8Dw7gUTw5snzAx3zrMw/PnFWAy0qA9FI1SzIihBALEZyItA/B2ITwHxEWg6/QhTCxBgAB4kvHiHyye8AAAAAElFTkSuQmCC"
                result = Convert.FromBase64String(base64EncodedImage)
            Else
                result = Nothing
            End If

        End Sub

        'Listing 5-2. Compare Validation
        Private Sub CreateDateTime_Validate(results As EntityValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            If CreateDateTime > ClosedDateTime Then
                results.AddPropertyError("Closed Date cannot be before Create Date")
            End If

        End Sub

        'Listing 5-3. Making Fields Mandatory Based on Some Condition  
        Private Sub ClosedByEngineer_Validate(results As EntityValidationResultsBuilder)
            ' results.AddPropertyError("<Error-Message>")
            If ClosedByEngineer IsNot Nothing And
   ClosedDateTime.HasValue = False Then
                results.AddPropertyError("Closed By Date must be entered")
            End If

        End Sub
    End Class

End Namespace
