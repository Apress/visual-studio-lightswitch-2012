'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should reference the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be:
'"Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Option Compare Binary
Option Infer On
Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.ServiceModel.DomainServices.Hosting
Imports System.ServiceModel.DomainServices.Server
Imports System.Configuration
Imports System.Data.SqlClient

'Listing 9-2. Domain Service Code for Retrieving Records
<Description("Enter the connection string to the HelpDesk Database")>
Public Class EngineerDataService
    Inherits DomainService

    Private ReadOnly _EngineerRecordList As List(Of EngineerRecord)
    Public Sub New()
        _EngineerRecordList = New List(Of EngineerRecord)()
    End Sub

    Private _connectionString As String

    Public Overrides Sub Initialize(
        context As System.ServiceModel.DomainServices.Server.DomainServiceContext)
        _connectionString = ConfigurationManager.ConnectionStrings(
            Me.[GetType]().FullName).ConnectionString
        MyBase.Initialize(context)
    End Sub

    <Query(IsDefault:=True)>
    Public Function GetEngineerData() As IQueryable(
       Of EngineerRecord)
        _EngineerRecordList.Clear()
        Using cnn As New SqlConnection(_connectionString)
            Using cmd As SqlCommand = cnn.CreateCommand()

                cmd.CommandText =
                   "SELECT Id ,Surname ,Firstname ,DateOfBirth ,SecurityVetted ,IssueCount " & _
                   "FROM dbo.Engineers eng JOIN  " & _
                   "   (SELECT Issue_Engineer, COUNT(Issue_Engineer) IssueCount  " & _
                   "    FROM  dbo.Issues GROUP BY Issue_Engineer) AS iss ON eng.Id = iss.Issue_Engineer"

                cnn.Open()

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim Engineer As New EngineerRecord()
                        Engineer.Id = CInt(dr("Id"))
                        Engineer.Surname = dr("Surname").ToString()
                        Engineer.Firstname = dr("Firstname").ToString()
                        Engineer.DateOfBirth = CDate(dr("DateOfBirth"))
                        Engineer.SecurityVetted = CBool(dr("SecurityVetted"))
                        Engineer.IssueCount = CInt(dr("IssueCount"))
                        _EngineerRecordList.Add(Engineer)
                    End While
                End Using
                cnn.Close()
            End Using
        End Using

        Return _EngineerRecordList.AsQueryable()

    End Function

    'Listing 9-3. Updating and Inserting Data
    Public Sub UpdateEngineerData(Engineer As EngineerRecord)

        Using cnn As New SqlConnection(_connectionString)
            Using cmd As SqlCommand = cnn.CreateCommand()

                cmd.CommandText =
                    "UPDATE Engineers  " & _
                   " SET [Surname] = @Surname,  " & _
                   "     [Firstname] = @Firstname,  " & _
                   "     [DateOfBirth] = @DateOfBirth ,  " & _
                   "     [SecurityVetted] = @SecurityVetted  " & _
                   " WHERE Id=@Id"
                cmd.Parameters.AddWithValue("Surname", Engineer.Surname)
                cmd.Parameters.AddWithValue("Firstname", Engineer.Firstname)
                cmd.Parameters.AddWithValue("DateOfBirth", Engineer.DateOfBirth)
                cmd.Parameters.AddWithValue("SecurityVetted", Engineer.SecurityVetted)
                cmd.Parameters.AddWithValue("ID", Engineer.Id)

                cnn.Open()
                cmd.ExecuteNonQuery()
                cnn.Close()
            End Using
        End Using

    End Sub

    Public Sub InsertEngineerData(Engineer As EngineerRecord)

        Using cnn As New SqlConnection(_connectionString)
            Using cmd As SqlCommand = cnn.CreateCommand()

                cmd.CommandText =
                "INSERT INTO Engineers (Surname, Firstname, DateOfBirth , SecurityVetted)  " & _
                "VALUES (@Surname, @Firstname, @DateOfBirth, @SecurityVetted);  " & _
                "SELECT @@Identity "

                cmd.Parameters.AddWithValue("Surname", Engineer.Surname)
                cmd.Parameters.AddWithValue("Firstname", Engineer.Firstname)
                cmd.Parameters.AddWithValue("DateOfBirth", Engineer.DateOfBirth)
                cmd.Parameters.AddWithValue("SecurityVetted", Engineer.SecurityVetted)

                cnn.Open()
                Engineer.Id = CInt(cmd.ExecuteScalar())
                cnn.Close()
            End Using
        End Using

    End Sub

    'Listing 9-5. Deleting Records
    Public Sub DeleteEngineerData(Engineer As EngineerRecord)

        Using cnn As New SqlConnection(_connectionString)
            Using cmd As SqlCommand = cnn.CreateCommand()
                cmd.CommandText = "DeleteEngineer"
                cmd.Parameters.AddWithValue("@Id", Engineer.Id)
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                cnn.Open()
                cmd.ExecuteNonQuery()
                cnn.Close()
            End Using
        End Using

    End Sub

End Class
