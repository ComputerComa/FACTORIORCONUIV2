Imports MaterialSkin
Imports System
Imports Rcon
Imports Rcon.Events
Public Class FRM_MAIN
    Dim DefaultPort As Integer = 25575
    Dim Client As RconClient = New RconClient()

    Private Sub FRM_MAIN_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub


End Class
