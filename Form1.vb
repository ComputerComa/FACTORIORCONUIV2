Imports MaterialSkin
Imports System
Imports Rcon
Imports Rcon.Events
Imports System.Text.RegularExpressions
'Last edited 7/27/22 12:35
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


    Private Async Sub MS_RB_CONNECT_Click(sender As Object, e As EventArgs) Handles MS_RB_CONNECT.Click
        If Not Client.Connected Then
            Dim Validated = Form_Validate()
            If Validated Then
                Try
                    MS_OUTPUT.Text += "Trying to connect to " + MS_TXT_CON_IP.Text + " on port " + MS_TXT_CON_PORT.Text
                    Await Client.ConnectAsync(MS_TXT_CON_IP.Text, CInt(MS_TXT_CON_PORT.Text))
                    MS_OUTPUT.Text += vbNewLine + "Connection Successful!"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    If Client.Connected Then
                        MS_OUTPUT.Text += vbNewLine + "Attempting to authenticate!"
                        Await Client.AuthenticateAsync(MS_TXT_CON_PASSWD.Text)
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

    Private Async Sub MS_RB_QC_ADMINS_Click(sender As Object, e As EventArgs) Handles MS_RB_QC_ADMINS.Click
        If Client.Connected And Client.Authenticated Then
            Dim Resp = Await Client.SendCommandAsync("/admins")
            If Resp.Length > 0 Then
                MS_OUTPUT.Text += vbNewLine + Resp.Length
            Else
                MS_OUTPUT.Text += vbNewLine + "None"
            End If
        Else
            MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
        End If



    End Sub

    Private Sub MS_RB_DISCONNECT_Click(sender As Object, e As EventArgs) Handles MS_RB_DISCONNECT.Click
        If Client.Connected Then
            Try
                MS_OUTPUT.Text += vbNewLine + "Attempting to Disconnect!"
                Client.Disconnect()
                MS_OUTPUT.Text += vbNewLine + "Attempting to Disconnect!"
            Catch ex As Exception
                MS_OUTPUT.Text += vbNewLine + ex.Message
            End Try

        End If
    End Sub

    Private Async Sub MS_RB_QC_PLAYERS_Click(sender As Object, e As EventArgs) Handles MS_RB_QC_PLAYERS.Click
        If Client.Connected And Client.Authenticated Then
            Dim Resp = Await Client.SendCommandAsync("/players")
            If Resp.Length > 0 Then
                MS_OUTPUT.Text += vbNewLine + Resp
            Else
                MS_OUTPUT.Text += vbNewLine + "None"
            End If
        Else
            MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
        End If


    End Sub

    Private Async Sub MS_RB_AC_OC_CMD_SUBMIT_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_OC_CMD_SUBMIT.Click
        If Client.Connected And Client.Authenticated Then
            If MS_TXT_OC_CMD_ENRTY.Text.Length > 0 Then
                Dim Resp = Await Client.SendCommandAsync("/" + MS_TXT_OC_CMD_ENRTY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                End If

            End If
        Else
            MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
        End If


    End Sub

    Private Async Sub MS_RB_QC_SERVSAVE_Click(sender As Object, e As EventArgs) Handles MS_RB_QC_SERVSAVE.Click
        If Client.Connected And Client.Authenticated Then
            Dim Resp = Await Client.SendCommandAsync("/server-save")
            If Resp.Length > 0 Then
                MS_OUTPUT.Text += vbNewLine + Resp
            Else
                MS_OUTPUT.Text += vbNewLine + "None"
            End If
        Else
            MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
        End If

    End Sub

    Private Async Sub MS_RB_QC_STOP_SRV_Click(sender As Object, e As EventArgs) Handles MS_RB_QC_STOP_SRV.Click
        If Client.Connected And Client.Authenticated Then
            Dim Resp = Await Client.SendCommandAsync("/stop")
            If Resp.Length > 0 Then
                MS_OUTPUT.Text += vbNewLine + Resp
            Else
                MS_OUTPUT.Text += vbNewLine + "None"
            End If
        Else
            MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
        End If
    End Sub

    Private Async Sub MS_RB_AC_PURGE_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_PURGE_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/purge " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_KICK_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_KICK_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/kick " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_BAN_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_BAN_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/ban " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_UNBAN_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_UNBAN_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/unban " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_PROMOTE_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_PROMOTE_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/promote " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_DEMOTE_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_DEMOTE_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/demote " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_MUTE_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_MUTE_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/mute " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_UNMUTE_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_UNMUTE_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/unmute " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_IGNORE_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_IGNORE_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/ignore " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub

    Private Async Sub MS_RB_AC_UNIGNORE_PLAYER_Click(sender As Object, e As EventArgs) Handles MS_RB_AC_UNIGNORE_PLAYER.Click
        If MS_TXT_AC_PLAYER_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync("/unignore " + MS_TXT_AC_PLAYER_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "None"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub


    Private Async Sub MS_RB_OC_CHAT_SEND_Click(sender As Object, e As EventArgs) Handles MS_RB_OC_CHAT_SEND.Click
        If MS_TXT_OC_CHAT_ENTRY.Text.Length > 0 Then
            If Client.Connected And Client.Authenticated Then
                Dim Resp = Await Client.SendCommandAsync(MS_TXT_OC_CHAT_ENTRY.Text)
                If Resp.Length > 0 Then
                    MS_OUTPUT.Text += vbNewLine + Resp
                Else
                    MS_OUTPUT.Text += vbNewLine + "Chat Sent"
                End If
            Else
                MS_OUTPUT.Text += vbNewLine + "Client is not connected to a server! Please connect to one and try again."
            End If
        End If
    End Sub
End Class
