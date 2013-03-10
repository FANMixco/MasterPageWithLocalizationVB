Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports Udev.MasterPageWithLocalization.Classes

Partial Public Class MasterPage
    Inherits System.Web.UI.MasterPage
    Protected Sub Page_Load(sender As Object, e As EventArgs)
    End Sub

    Protected Sub RequestLanguageChange_Click(sender As Object, e As EventArgs)
        Dim senderLink As LinkButton = TryCast(sender, LinkButton)

        'store requested language as new culture in the session
        Session([Global].SESSION_KEY_CULTURE) = senderLink.CommandArgument

        'reload last requested page with new culture
        Server.Transfer(Request.Path)
    End Sub
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
