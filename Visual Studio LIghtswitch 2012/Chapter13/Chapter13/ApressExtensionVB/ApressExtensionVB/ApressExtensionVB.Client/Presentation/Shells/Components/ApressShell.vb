Imports System
Imports System.ComponentModel.Composition

Imports Microsoft.LightSwitch.Runtime.Shell

Namespace Presentation.Shells.Components

    <Export(GetType(IShell))>
    <Shell(ApressShell.ShellId)>
    Friend Class ApressShell
        Implements IShell

#Region "IShell Members"

        Public ReadOnly Property Name As String Implements IShell.Name
            Get
                Return ApressShell.ShellId
            End Get
        End Property

        Public ReadOnly Property ShellUri As Uri Implements IShell.ShellUri
            Get
                Return New Uri("/ApressExtensionVB.Client;component/Presentation/Shells/ApressShell.xaml", UriKind.Relative)
            End Get
        End Property

#End Region

#Region "Constants"

        Friend Const ShellId As String = "ApressExtensionVB:ApressShell"

#End Region

    End Class

End Namespace