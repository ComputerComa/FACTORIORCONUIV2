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
        If MS_TXT_CON_PASSWD.Text.Length > 0 Then
            PASS = True
        Else
            PASS = False
        End If
        Dim OK As Boolean = IPVALID And PortValid And PASS
        Return OK
    End Function

    Private Sub FRM_MAIN_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub


    Private Sub MS_RB_CONNECT_Click(sender As Object, e As EventArgs) Handles MS_RB_CONNECT.Click
        If Not Client.Connected Then
            Dim Validated = Form_Validate()
            If Validated Then
                Try
                    MS_OUTPUT.Text += "Trying to connect to " + MS_TXT_CON_IP.Text + " on port " + MS_TXT_CON_PORT.Text
                    Client.Connect(MS_TXT_CON_IP.Text, CInt(MS_TXT_CON_PORT.Text))
                    MS_OUTPUT.Text += vbNewLine + "Connection Successful!"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    If Client.Connected Then
                        MS_OUTPUT.Text += vbNewLine + "Attempting to authenticate!"
                        Client.Authenticate(MS_TXT_CON_PASSWD.Text)
                        MS_OUTPUT.Text += vbNewLine + "Authentication Successful!"
                    Else
                        MS_OUTPUT.Text += vbNewLine + "Connection Aborted. Skipping authentication"
                    End If

                Catch ex As Exception
                    MS_OUTPUT.Text += vbNewLine + "Error authenticating!"
                    Client.Disconnect()

                End Try
            Else
                MS_OUTPUT.Text += "Error with input data!"
            End If
        End If

    End Sub

    Private Sub MS_RB_QC_ADMINS_Click(sender As Object, e As EventArgs) Handles MS_RB_QC_ADMINS.Click
        Dim Resp = Client.SendCommand("/admins")
        MS_OUTPUT.Text += vbNewLine + Resp

    End Sub
End Class
