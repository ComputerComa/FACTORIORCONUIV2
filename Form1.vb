Imports MaterialSkin
Imports System
Imports Rcon
Imports Rcon.Events
Imports System.Text.RegularExpressions
Public Class FRM_MAIN
    Dim DefaultPort As Integer = 25575
    Dim Client As RconClient = New RconClient()
    'Function to Validate connection inputs
    Function Validate()
        Dim IPVALID As Boolean = False
        Dim PortValid As Boolean = False
        Dim PASS As Boolean = False
        Dim IP As String = "\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b"
        Dim reIP As New Regex(IP)
        If Not reIP.IsMatch(MS_TXT_CON_IP.Text) Then
            MessageBox.Show("Please enter a valid IP address")
            IPVALID = False
        Else
            IPVALID = True
        End If
        Try
            If CInt(MS_TXT_CON_PORT.Text) < 0 Or CInt(MS_TXT_CON_PORT.Text) > 65535 Then
                MessageBox.Show("Please enter a valid port!" + vbNewLine + "Please remember port ranges are between 1 & 65535")
                PortValid = False
            Else
                PortValid = True
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter numerical values only")
            PortValid = False
        End Try
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

    End Sub

    Private Sub MS_TXT_CON_IP_Leave(sender As Object, e As EventArgs) Handles MS_TXT_CON_IP.Leave

    End Sub


End Class
