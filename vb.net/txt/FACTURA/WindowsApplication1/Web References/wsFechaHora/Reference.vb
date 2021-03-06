'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace wsFechaHora
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="wsFechaHoraSoap", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class wsFechaHora
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private RecuperarFechaHoraActualOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.WindowsApplication1.My.MySettings.Default.WindowsApplication1_wsFechaHor_wsFechaHora
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event RecuperarFechaHoraActualCompleted As RecuperarFechaHoraActualCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RecuperarFechaHoraActual", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function RecuperarFechaHoraActual(ByVal curCorreo As String, ByVal password As String) As respuesta
            Dim results() As Object = Me.Invoke("RecuperarFechaHoraActual", New Object() {curCorreo, password})
            Return CType(results(0),respuesta)
        End Function
        
        '''<remarks/>
        Public Overloads Sub RecuperarFechaHoraActualAsync(ByVal curCorreo As String, ByVal password As String)
            Me.RecuperarFechaHoraActualAsync(curCorreo, password, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RecuperarFechaHoraActualAsync(ByVal curCorreo As String, ByVal password As String, ByVal userState As Object)
            If (Me.RecuperarFechaHoraActualOperationCompleted Is Nothing) Then
                Me.RecuperarFechaHoraActualOperationCompleted = AddressOf Me.OnRecuperarFechaHoraActualOperationCompleted
            End If
            Me.InvokeAsync("RecuperarFechaHoraActual", New Object() {curCorreo, password}, Me.RecuperarFechaHoraActualOperationCompleted, userState)
        End Sub
        
        Private Sub OnRecuperarFechaHoraActualOperationCompleted(ByVal arg As Object)
            If (Not (Me.RecuperarFechaHoraActualCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RecuperarFechaHoraActualCompleted(Me, New RecuperarFechaHoraActualCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class respuesta
        
        Private erroresField As String
        
        Private fechaActualField As String
        
        Private horaActualField As String
        
        Private fechaHoraActualField As String
        
        '''<remarks/>
        Public Property errores() As String
            Get
                Return Me.erroresField
            End Get
            Set
                Me.erroresField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property fechaActual() As String
            Get
                Return Me.fechaActualField
            End Get
            Set
                Me.fechaActualField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property horaActual() As String
            Get
                Return Me.horaActualField
            End Get
            Set
                Me.horaActualField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property fechaHoraActual() As String
            Get
                Return Me.fechaHoraActualField
            End Get
            Set
                Me.fechaHoraActualField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")>  _
    Public Delegate Sub RecuperarFechaHoraActualCompletedEventHandler(ByVal sender As Object, ByVal e As RecuperarFechaHoraActualCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class RecuperarFechaHoraActualCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As respuesta
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),respuesta)
            End Get
        End Property
    End Class
End Namespace
