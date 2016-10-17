'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should reference the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be:
'"Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.ComponentModel.DataAnnotations

'Listing 9-1. Entity Class for Engineers
Public Class EngineerRecord
    <Key(), Editable(False)>
    Public Property Id As Integer

    <Required(ErrorMessage:="Surname required"),
        StringLength(50)>
    Public Property Surname As String

    <Required(ErrorMessage:="Firstname required"),
            StringLength(50)>
    Public Property Firstname As String

    <Required(ErrorMessage:="DateOfBirth required")>
    Public Property DateOfBirth As DateTime

    <Required(ErrorMessage:="SecurityVetted required")>
    Public Property SecurityVetted As Boolean

    <Editable(False)>
    Public Property IssueCount As Integer

End Class
