Imports System

Namespace LightSwitchCommonModule

    Public Class GlobalDates

        Public Shared Function SevenDaysAgo() As DateTime
            Return DateTime.Now.AddDays(-7)
        End Function

    End Class

End Namespace
