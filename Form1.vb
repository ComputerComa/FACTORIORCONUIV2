Imports MaterialSkin
Imports System
Imports Rcon
Imports Rcon.Events
Imports System.Text.RegularExpressions
Public Class FRM_MAIN
    Dim DefaultPort As Integer = 25575
    Dim Client As RconClient = New RconClient()
    'Function to Validate connection inputs
    Public Function Form_Validate() As Boolean
        Dim IPVALID As Boolean = False
        Dim PortValid As Boolean = False
        Dim PASS As Boolean = False
        Dim IP As String = "\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b"
        Dim reIP As New Regex(IP)
        If Not reIP.IsMatch(MS_TXT_CON_IP.Text) Then
            IPVALID = False
        Else
            IPVALID = True
        End If
        Try
            If CInt(MS_TXT_CON_PORT.Text) < 0 Or CInt(MS_TXT_CON_PORT.Text) > 65535 Then
                PortValid = False
            Else
                PortValid = True
            End If
        Catch ex As InvalidCastException
            PortValid = False
        End Try
        Dim OK As Boolean = IPVALID And PortValid And PASS
        Return OK
    End Function
    Sub Connect_RCON(IP As String, PORT As String, PASSWD As String)

    End Sub

    Private Sub FRM_MAIN_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub

    Private Sub MS_RB_CONNECT_Click(sender As Object, e As EventArgs) Handles MS_RB_CONNECT.Click
        Dim Validated = Form_Validate()
        If Validated Then

        End If
    End Sub

    Private Sub MS_TXT_CON_IP_Leave(sender As Object, e As EventArgs) Handles MS_TXT_CON_IP.Leave

    End Sub


End Class
