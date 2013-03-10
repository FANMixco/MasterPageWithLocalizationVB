Imports System
Imports System.Data
Imports System.Configuration
Imports System.Globalization
Imports System.Threading
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace Udev.MasterPageWithLocalization.Classes
    ''' <summary>
    ''' Custom base page used for all web forms.
    ''' </summary>
    Public Class BasePage
        Inherits Page
        Protected Overrides Sub InitializeCulture()
            'retrieve culture information from session
            Dim culture__1 As String = Convert.ToString(Session([Global].SESSION_KEY_CULTURE))

            'check whether a culture is stored in the session
            If culture__1.Length > 0 Then
                Culture = culture__1
            End If

            'set culture to current thread
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture__1)
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(culture__1)

            'call base class
            MyBase.InitializeCulture()
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
