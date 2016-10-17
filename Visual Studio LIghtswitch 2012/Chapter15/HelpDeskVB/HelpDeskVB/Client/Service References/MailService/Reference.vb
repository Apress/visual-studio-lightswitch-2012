﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18051
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


'
'This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
'
Namespace MailService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="MailService.IMailService")>  _
    Public Interface IMailService
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/IMailService/SendMail", ReplyAction:="http://tempuri.org/IMailService/SendMailResponse")>  _
        Function BeginSendMail(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndSendMail(ByVal result As System.IAsyncResult) As String
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IMailServiceChannel
        Inherits MailService.IMailService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SendMailCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property Result() As String
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class MailServiceClient
        Inherits System.ServiceModel.ClientBase(Of MailService.IMailService)
        Implements MailService.IMailService
        
        Private onBeginSendMailDelegate As BeginOperationDelegate
        
        Private onEndSendMailDelegate As EndOperationDelegate
        
        Private onSendMailCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginOpenDelegate As BeginOperationDelegate
        
        Private onEndOpenDelegate As EndOperationDelegate
        
        Private onOpenCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginCloseDelegate As BeginOperationDelegate
        
        Private onEndCloseDelegate As EndOperationDelegate
        
        Private onCloseCompletedDelegate As System.Threading.SendOrPostCallback
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Property CookieContainer() As System.Net.CookieContainer
            Get
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    Return httpCookieContainerManager.CookieContainer
                Else
                    Return Nothing
                End If
            End Get
            Set
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    httpCookieContainerManager.CookieContainer = value
                Else
                    Throw New System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC"& _ 
                            "ookieContainerBindingElement.")
                End If
            End Set
        End Property
        
        Public Event SendMailCompleted As System.EventHandler(Of SendMailCompletedEventArgs)
        
        Public Event OpenCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Event CloseCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MailService_IMailService_BeginSendMail(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements MailService.IMailService.BeginSendMail
            Return MyBase.Channel.BeginSendMail(emailTo, subject, body, callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function MailService_IMailService_EndSendMail(ByVal result As System.IAsyncResult) As String Implements MailService.IMailService.EndSendMail
            Return MyBase.Channel.EndSendMail(result)
        End Function
        
        Private Function OnBeginSendMail(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Dim emailTo As String = CType(inValues(0),String)
            Dim subject As String = CType(inValues(1),String)
            Dim body As String = CType(inValues(2),String)
            Return CType(Me,MailService.IMailService).BeginSendMail(emailTo, subject, body, callback, asyncState)
        End Function
        
        Private Function OnEndSendMail(ByVal result As System.IAsyncResult) As Object()
            Dim retVal As String = CType(Me,MailService.IMailService).EndSendMail(result)
            Return New Object() {retVal}
        End Function
        
        Private Sub OnSendMailCompleted(ByVal state As Object)
            If (Not (Me.SendMailCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent SendMailCompleted(Me, New SendMailCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub SendMailAsync(ByVal emailTo As String, ByVal subject As String, ByVal body As String)
            Me.SendMailAsync(emailTo, subject, body, Nothing)
        End Sub
        
        Public Overloads Sub SendMailAsync(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal userState As Object)
            If (Me.onBeginSendMailDelegate Is Nothing) Then
                Me.onBeginSendMailDelegate = AddressOf Me.OnBeginSendMail
            End If
            If (Me.onEndSendMailDelegate Is Nothing) Then
                Me.onEndSendMailDelegate = AddressOf Me.OnEndSendMail
            End If
            If (Me.onSendMailCompletedDelegate Is Nothing) Then
                Me.onSendMailCompletedDelegate = AddressOf Me.OnSendMailCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginSendMailDelegate, New Object() {emailTo, subject, body}, Me.onEndSendMailDelegate, Me.onSendMailCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginOpen(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginOpen(callback, asyncState)
        End Function
        
        Private Function OnEndOpen(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndOpen(result)
            Return Nothing
        End Function
        
        Private Sub OnOpenCompleted(ByVal state As Object)
            If (Not (Me.OpenCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent OpenCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub OpenAsync()
            Me.OpenAsync(Nothing)
        End Sub
        
        Public Overloads Sub OpenAsync(ByVal userState As Object)
            If (Me.onBeginOpenDelegate Is Nothing) Then
                Me.onBeginOpenDelegate = AddressOf Me.OnBeginOpen
            End If
            If (Me.onEndOpenDelegate Is Nothing) Then
                Me.onEndOpenDelegate = AddressOf Me.OnEndOpen
            End If
            If (Me.onOpenCompletedDelegate Is Nothing) Then
                Me.onOpenCompletedDelegate = AddressOf Me.OnOpenCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginOpenDelegate, Nothing, Me.onEndOpenDelegate, Me.onOpenCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginClose(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginClose(callback, asyncState)
        End Function
        
        Private Function OnEndClose(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndClose(result)
            Return Nothing
        End Function
        
        Private Sub OnCloseCompleted(ByVal state As Object)
            If (Not (Me.CloseCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent CloseCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub CloseAsync()
            Me.CloseAsync(Nothing)
        End Sub
        
        Public Overloads Sub CloseAsync(ByVal userState As Object)
            If (Me.onBeginCloseDelegate Is Nothing) Then
                Me.onBeginCloseDelegate = AddressOf Me.OnBeginClose
            End If
            If (Me.onEndCloseDelegate Is Nothing) Then
                Me.onEndCloseDelegate = AddressOf Me.OnEndClose
            End If
            If (Me.onCloseCompletedDelegate Is Nothing) Then
                Me.onCloseCompletedDelegate = AddressOf Me.OnCloseCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginCloseDelegate, Nothing, Me.onEndCloseDelegate, Me.onCloseCompletedDelegate, userState)
        End Sub
        
        Protected Overrides Function CreateChannel() As MailService.IMailService
            Return New MailServiceClientChannel(Me)
        End Function
        
        Private Class MailServiceClientChannel
            Inherits ChannelBase(Of MailService.IMailService)
            Implements MailService.IMailService
            
            Public Sub New(ByVal client As System.ServiceModel.ClientBase(Of MailService.IMailService))
                MyBase.New(client)
            End Sub
            
            Public Function BeginSendMail(ByVal emailTo As String, ByVal subject As String, ByVal body As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements MailService.IMailService.BeginSendMail
                Dim _args((3) - 1) As Object
                _args(0) = emailTo
                _args(1) = subject
                _args(2) = body
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("SendMail", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Function EndSendMail(ByVal result As System.IAsyncResult) As String Implements MailService.IMailService.EndSendMail
                Dim _args((0) - 1) As Object
                Dim _result As String = CType(MyBase.EndInvoke("SendMail", _args, result),String)
                Return _result
            End Function
        End Class
    End Class
End Namespace