'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMailService" in both code and config file together.
<ServiceContract()>
Public Interface IMailService

    'Listing 15-16. Defining the Interface for Your Web Service 
    <OperationContract()>
    Function SendMail(
      emailTo As String, subject As String, body As String) As String

End Interface