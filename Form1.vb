Imports MaterialSkin
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT

        SkinManager.ColorScheme = New ColorScheme(Primary.DeepOrange700, Primary.DeepOrange300, Primary.Amber50, Accent.LightBlue200, TextShade.WHITE)
    End Sub

End Class
