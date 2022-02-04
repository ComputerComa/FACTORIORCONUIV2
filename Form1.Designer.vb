<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MAIN
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MS_TXT_CON_IP = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MS_OUTPUT = New System.Windows.Forms.TextBox()
        Me.MS_TXT_CON_PORT = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MS_TXT_CON_PASSWD = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MS_RB_CONNECT = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_DISCONNECT = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MS_RB_QC_PLAYERS = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_QC_ADMINS = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_QC_SERVSAVE = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_QC_STOP_SRV = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MS_RB_AC_PURGE_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_KICK_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_BAN_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_UNBAN_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_PROMOTE_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_DEMOTE_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_MUTE_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_UNMUTE_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_UNIGNORE_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_AC_IGNORE_PLAYER = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_TXT_AC_PLAYER_ENTRY = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider4 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MS_TXT_OC_CMD_ENRTY = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MS_TXT_OC_CHAT_ENTRY = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MS_RB_AC_OC_CMD_SUBMIT = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MS_RB_OC_CHAT_SEND = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider5 = New MaterialSkin.Controls.MaterialDivider()
        Me.SuspendLayout()
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(13, 79)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1018, 90)
        Me.MaterialDivider1.TabIndex = 0
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(21, 86)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(145, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Connection Settings"
        '
        'MS_TXT_CON_IP
        '
        Me.MS_TXT_CON_IP.Depth = 0
        Me.MS_TXT_CON_IP.Hint = "  IP"
        Me.MS_TXT_CON_IP.Location = New System.Drawing.Point(36, 119)
        Me.MS_TXT_CON_IP.MaxLength = 32767
        Me.MS_TXT_CON_IP.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_TXT_CON_IP.Name = "MS_TXT_CON_IP"
        Me.MS_TXT_CON_IP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MS_TXT_CON_IP.SelectedText = ""
        Me.MS_TXT_CON_IP.SelectionLength = 0
        Me.MS_TXT_CON_IP.SelectionStart = 0
        Me.MS_TXT_CON_IP.Size = New System.Drawing.Size(221, 23)
        Me.MS_TXT_CON_IP.TabIndex = 2
        Me.MS_TXT_CON_IP.TabStop = False
        Me.MS_TXT_CON_IP.UseSystemPasswordChar = False
        '
        'MS_OUTPUT
        '
        Me.MS_OUTPUT.Location = New System.Drawing.Point(13, 194)
        Me.MS_OUTPUT.Multiline = True
        Me.MS_OUTPUT.Name = "MS_OUTPUT"
        Me.MS_OUTPUT.Size = New System.Drawing.Size(356, 413)
        Me.MS_OUTPUT.TabIndex = 3
        '
        'MS_TXT_CON_PORT
        '
        Me.MS_TXT_CON_PORT.Depth = 0
        Me.MS_TXT_CON_PORT.Hint = "  Port"
        Me.MS_TXT_CON_PORT.Location = New System.Drawing.Point(286, 119)
        Me.MS_TXT_CON_PORT.MaxLength = 32767
        Me.MS_TXT_CON_PORT.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_TXT_CON_PORT.Name = "MS_TXT_CON_PORT"
        Me.MS_TXT_CON_PORT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MS_TXT_CON_PORT.SelectedText = ""
        Me.MS_TXT_CON_PORT.SelectionLength = 0
        Me.MS_TXT_CON_PORT.SelectionStart = 0
        Me.MS_TXT_CON_PORT.Size = New System.Drawing.Size(129, 23)
        Me.MS_TXT_CON_PORT.TabIndex = 4
        Me.MS_TXT_CON_PORT.TabStop = False
        Me.MS_TXT_CON_PORT.UseSystemPasswordChar = False
        '
        'MS_TXT_CON_PASSWD
        '
        Me.MS_TXT_CON_PASSWD.Depth = 0
        Me.MS_TXT_CON_PASSWD.Hint = "  Password"
        Me.MS_TXT_CON_PASSWD.Location = New System.Drawing.Point(438, 119)
        Me.MS_TXT_CON_PASSWD.MaxLength = 32767
        Me.MS_TXT_CON_PASSWD.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_TXT_CON_PASSWD.Name = "MS_TXT_CON_PASSWD"
        Me.MS_TXT_CON_PASSWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.MS_TXT_CON_PASSWD.SelectedText = ""
        Me.MS_TXT_CON_PASSWD.SelectionLength = 0
        Me.MS_TXT_CON_PASSWD.SelectionStart = 0
        Me.MS_TXT_CON_PASSWD.Size = New System.Drawing.Size(266, 23)
        Me.MS_TXT_CON_PASSWD.TabIndex = 5
        Me.MS_TXT_CON_PASSWD.TabStop = False
        Me.MS_TXT_CON_PASSWD.UseSystemPasswordChar = False
        '
        'MS_RB_CONNECT
        '
        Me.MS_RB_CONNECT.AutoSize = True
        Me.MS_RB_CONNECT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_CONNECT.Depth = 0
        Me.MS_RB_CONNECT.Icon = Nothing
        Me.MS_RB_CONNECT.Location = New System.Drawing.Point(710, 112)
        Me.MS_RB_CONNECT.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_CONNECT.Name = "MS_RB_CONNECT"
        Me.MS_RB_CONNECT.Primary = True
        Me.MS_RB_CONNECT.Size = New System.Drawing.Size(84, 36)
        Me.MS_RB_CONNECT.TabIndex = 6
        Me.MS_RB_CONNECT.Text = "Connect"
        Me.MS_RB_CONNECT.UseVisualStyleBackColor = True
        '
        'MS_RB_DISCONNECT
        '
        Me.MS_RB_DISCONNECT.AutoSize = True
        Me.MS_RB_DISCONNECT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_DISCONNECT.Depth = 0
        Me.MS_RB_DISCONNECT.Icon = Nothing
        Me.MS_RB_DISCONNECT.Location = New System.Drawing.Point(824, 112)
        Me.MS_RB_DISCONNECT.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_DISCONNECT.Name = "MS_RB_DISCONNECT"
        Me.MS_RB_DISCONNECT.Primary = True
        Me.MS_RB_DISCONNECT.Size = New System.Drawing.Size(105, 36)
        Me.MS_RB_DISCONNECT.TabIndex = 7
        Me.MS_RB_DISCONNECT.Text = "Disconnect"
        Me.MS_RB_DISCONNECT.UseVisualStyleBackColor = True
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(375, 175)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(656, 91)
        Me.MaterialDivider2.TabIndex = 8
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(383, 183)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(128, 19)
        Me.MaterialLabel2.TabIndex = 9
        Me.MaterialLabel2.Text = "Quick Commands"
        '
        'MS_RB_QC_PLAYERS
        '
        Me.MS_RB_QC_PLAYERS.AutoSize = True
        Me.MS_RB_QC_PLAYERS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_QC_PLAYERS.Depth = 0
        Me.MS_RB_QC_PLAYERS.Icon = Nothing
        Me.MS_RB_QC_PLAYERS.Location = New System.Drawing.Point(499, 211)
        Me.MS_RB_QC_PLAYERS.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_QC_PLAYERS.Name = "MS_RB_QC_PLAYERS"
        Me.MS_RB_QC_PLAYERS.Primary = True
        Me.MS_RB_QC_PLAYERS.Size = New System.Drawing.Size(79, 36)
        Me.MS_RB_QC_PLAYERS.TabIndex = 10
        Me.MS_RB_QC_PLAYERS.Text = "Players"
        Me.MS_RB_QC_PLAYERS.UseVisualStyleBackColor = True
        '
        'MS_RB_QC_ADMINS
        '
        Me.MS_RB_QC_ADMINS.AutoSize = True
        Me.MS_RB_QC_ADMINS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_QC_ADMINS.Depth = 0
        Me.MS_RB_QC_ADMINS.Icon = Nothing
        Me.MS_RB_QC_ADMINS.Location = New System.Drawing.Point(584, 211)
        Me.MS_RB_QC_ADMINS.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_QC_ADMINS.Name = "MS_RB_QC_ADMINS"
        Me.MS_RB_QC_ADMINS.Primary = True
        Me.MS_RB_QC_ADMINS.Size = New System.Drawing.Size(73, 36)
        Me.MS_RB_QC_ADMINS.TabIndex = 11
        Me.MS_RB_QC_ADMINS.Text = "Admins"
        Me.MS_RB_QC_ADMINS.UseVisualStyleBackColor = True
        '
        'MS_RB_QC_SERVSAVE
        '
        Me.MS_RB_QC_SERVSAVE.AutoSize = True
        Me.MS_RB_QC_SERVSAVE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_QC_SERVSAVE.Depth = 0
        Me.MS_RB_QC_SERVSAVE.Icon = Nothing
        Me.MS_RB_QC_SERVSAVE.Location = New System.Drawing.Point(663, 211)
        Me.MS_RB_QC_SERVSAVE.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_QC_SERVSAVE.Name = "MS_RB_QC_SERVSAVE"
        Me.MS_RB_QC_SERVSAVE.Primary = True
        Me.MS_RB_QC_SERVSAVE.Size = New System.Drawing.Size(108, 36)
        Me.MS_RB_QC_SERVSAVE.TabIndex = 12
        Me.MS_RB_QC_SERVSAVE.Text = "Server Save"
        Me.MS_RB_QC_SERVSAVE.UseVisualStyleBackColor = True
        '
        'MS_RB_QC_STOP_SRV
        '
        Me.MS_RB_QC_STOP_SRV.AutoSize = True
        Me.MS_RB_QC_STOP_SRV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_QC_STOP_SRV.Depth = 0
        Me.MS_RB_QC_STOP_SRV.Icon = Nothing
        Me.MS_RB_QC_STOP_SRV.Location = New System.Drawing.Point(777, 211)
        Me.MS_RB_QC_STOP_SRV.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_QC_STOP_SRV.Name = "MS_RB_QC_STOP_SRV"
        Me.MS_RB_QC_STOP_SRV.Primary = True
        Me.MS_RB_QC_STOP_SRV.Size = New System.Drawing.Size(109, 36)
        Me.MS_RB_QC_STOP_SRV.TabIndex = 13
        Me.MS_RB_QC_STOP_SRV.Text = "Stop Server"
        Me.MS_RB_QC_STOP_SRV.UseVisualStyleBackColor = True
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(375, 272)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(656, 196)
        Me.MaterialDivider3.TabIndex = 14
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(383, 279)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(133, 19)
        Me.MaterialLabel3.TabIndex = 15
        Me.MaterialLabel3.Text = "Admin Commands"
        '
        'MS_RB_AC_PURGE_PLAYER
        '
        Me.MS_RB_AC_PURGE_PLAYER.AutoSize = True
        Me.MS_RB_AC_PURGE_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_PURGE_PLAYER.Depth = 0
        Me.MS_RB_AC_PURGE_PLAYER.Icon = Nothing
        Me.MS_RB_AC_PURGE_PLAYER.Location = New System.Drawing.Point(453, 312)
        Me.MS_RB_AC_PURGE_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_PURGE_PLAYER.Name = "MS_RB_AC_PURGE_PLAYER"
        Me.MS_RB_AC_PURGE_PLAYER.Primary = True
        Me.MS_RB_AC_PURGE_PLAYER.Size = New System.Drawing.Size(118, 36)
        Me.MS_RB_AC_PURGE_PLAYER.TabIndex = 16
        Me.MS_RB_AC_PURGE_PLAYER.Text = "Purge Player"
        Me.MS_RB_AC_PURGE_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_KICK_PLAYER
        '
        Me.MS_RB_AC_KICK_PLAYER.AutoSize = True
        Me.MS_RB_AC_KICK_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_KICK_PLAYER.Depth = 0
        Me.MS_RB_AC_KICK_PLAYER.Icon = Nothing
        Me.MS_RB_AC_KICK_PLAYER.Location = New System.Drawing.Point(584, 312)
        Me.MS_RB_AC_KICK_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_KICK_PLAYER.Name = "MS_RB_AC_KICK_PLAYER"
        Me.MS_RB_AC_KICK_PLAYER.Primary = True
        Me.MS_RB_AC_KICK_PLAYER.Size = New System.Drawing.Size(105, 36)
        Me.MS_RB_AC_KICK_PLAYER.TabIndex = 17
        Me.MS_RB_AC_KICK_PLAYER.Text = "Kick Player"
        Me.MS_RB_AC_KICK_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_BAN_PLAYER
        '
        Me.MS_RB_AC_BAN_PLAYER.AutoSize = True
        Me.MS_RB_AC_BAN_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_BAN_PLAYER.Depth = 0
        Me.MS_RB_AC_BAN_PLAYER.Icon = Nothing
        Me.MS_RB_AC_BAN_PLAYER.Location = New System.Drawing.Point(702, 312)
        Me.MS_RB_AC_BAN_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_BAN_PLAYER.Name = "MS_RB_AC_BAN_PLAYER"
        Me.MS_RB_AC_BAN_PLAYER.Primary = True
        Me.MS_RB_AC_BAN_PLAYER.Size = New System.Drawing.Size(102, 36)
        Me.MS_RB_AC_BAN_PLAYER.TabIndex = 18
        Me.MS_RB_AC_BAN_PLAYER.Text = "Ban Player"
        Me.MS_RB_AC_BAN_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_UNBAN_PLAYER
        '
        Me.MS_RB_AC_UNBAN_PLAYER.AutoSize = True
        Me.MS_RB_AC_UNBAN_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_UNBAN_PLAYER.Depth = 0
        Me.MS_RB_AC_UNBAN_PLAYER.Icon = Nothing
        Me.MS_RB_AC_UNBAN_PLAYER.Location = New System.Drawing.Point(817, 312)
        Me.MS_RB_AC_UNBAN_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_UNBAN_PLAYER.Name = "MS_RB_AC_UNBAN_PLAYER"
        Me.MS_RB_AC_UNBAN_PLAYER.Primary = True
        Me.MS_RB_AC_UNBAN_PLAYER.Size = New System.Drawing.Size(121, 36)
        Me.MS_RB_AC_UNBAN_PLAYER.TabIndex = 19
        Me.MS_RB_AC_UNBAN_PLAYER.Text = "UnBan Player"
        Me.MS_RB_AC_UNBAN_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_PROMOTE_PLAYER
        '
        Me.MS_RB_AC_PROMOTE_PLAYER.AutoSize = True
        Me.MS_RB_AC_PROMOTE_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_PROMOTE_PLAYER.Depth = 0
        Me.MS_RB_AC_PROMOTE_PLAYER.Icon = Nothing
        Me.MS_RB_AC_PROMOTE_PLAYER.Location = New System.Drawing.Point(486, 354)
        Me.MS_RB_AC_PROMOTE_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_PROMOTE_PLAYER.Name = "MS_RB_AC_PROMOTE_PLAYER"
        Me.MS_RB_AC_PROMOTE_PLAYER.Primary = True
        Me.MS_RB_AC_PROMOTE_PLAYER.Size = New System.Drawing.Size(139, 36)
        Me.MS_RB_AC_PROMOTE_PLAYER.TabIndex = 20
        Me.MS_RB_AC_PROMOTE_PLAYER.Text = "Promote Player"
        Me.MS_RB_AC_PROMOTE_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_DEMOTE_PLAYER
        '
        Me.MS_RB_AC_DEMOTE_PLAYER.AutoSize = True
        Me.MS_RB_AC_DEMOTE_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_DEMOTE_PLAYER.Depth = 0
        Me.MS_RB_AC_DEMOTE_PLAYER.Icon = Nothing
        Me.MS_RB_AC_DEMOTE_PLAYER.Location = New System.Drawing.Point(486, 396)
        Me.MS_RB_AC_DEMOTE_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_DEMOTE_PLAYER.Name = "MS_RB_AC_DEMOTE_PLAYER"
        Me.MS_RB_AC_DEMOTE_PLAYER.Primary = True
        Me.MS_RB_AC_DEMOTE_PLAYER.Size = New System.Drawing.Size(139, 36)
        Me.MS_RB_AC_DEMOTE_PLAYER.TabIndex = 21
        Me.MS_RB_AC_DEMOTE_PLAYER.Text = "Demote    Player"
        Me.MS_RB_AC_DEMOTE_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_MUTE_PLAYER
        '
        Me.MS_RB_AC_MUTE_PLAYER.AutoSize = True
        Me.MS_RB_AC_MUTE_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_MUTE_PLAYER.Depth = 0
        Me.MS_RB_AC_MUTE_PLAYER.Icon = Nothing
        Me.MS_RB_AC_MUTE_PLAYER.Location = New System.Drawing.Point(636, 354)
        Me.MS_RB_AC_MUTE_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_MUTE_PLAYER.Name = "MS_RB_AC_MUTE_PLAYER"
        Me.MS_RB_AC_MUTE_PLAYER.Primary = True
        Me.MS_RB_AC_MUTE_PLAYER.Size = New System.Drawing.Size(129, 36)
        Me.MS_RB_AC_MUTE_PLAYER.TabIndex = 22
        Me.MS_RB_AC_MUTE_PLAYER.Text = "Mute      Player"
        Me.MS_RB_AC_MUTE_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_UNMUTE_PLAYER
        '
        Me.MS_RB_AC_UNMUTE_PLAYER.AutoSize = True
        Me.MS_RB_AC_UNMUTE_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_UNMUTE_PLAYER.Depth = 0
        Me.MS_RB_AC_UNMUTE_PLAYER.Icon = Nothing
        Me.MS_RB_AC_UNMUTE_PLAYER.Location = New System.Drawing.Point(636, 396)
        Me.MS_RB_AC_UNMUTE_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_UNMUTE_PLAYER.Name = "MS_RB_AC_UNMUTE_PLAYER"
        Me.MS_RB_AC_UNMUTE_PLAYER.Primary = True
        Me.MS_RB_AC_UNMUTE_PLAYER.Size = New System.Drawing.Size(130, 36)
        Me.MS_RB_AC_UNMUTE_PLAYER.TabIndex = 23
        Me.MS_RB_AC_UNMUTE_PLAYER.Text = "Unmute Player"
        Me.MS_RB_AC_UNMUTE_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_UNIGNORE_PLAYER
        '
        Me.MS_RB_AC_UNIGNORE_PLAYER.AutoSize = True
        Me.MS_RB_AC_UNIGNORE_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_UNIGNORE_PLAYER.Depth = 0
        Me.MS_RB_AC_UNIGNORE_PLAYER.Icon = Nothing
        Me.MS_RB_AC_UNIGNORE_PLAYER.Location = New System.Drawing.Point(777, 396)
        Me.MS_RB_AC_UNIGNORE_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_UNIGNORE_PLAYER.Name = "MS_RB_AC_UNIGNORE_PLAYER"
        Me.MS_RB_AC_UNIGNORE_PLAYER.Primary = True
        Me.MS_RB_AC_UNIGNORE_PLAYER.Size = New System.Drawing.Size(142, 36)
        Me.MS_RB_AC_UNIGNORE_PLAYER.TabIndex = 25
        Me.MS_RB_AC_UNIGNORE_PLAYER.Text = "Unignore Player"
        Me.MS_RB_AC_UNIGNORE_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_RB_AC_IGNORE_PLAYER
        '
        Me.MS_RB_AC_IGNORE_PLAYER.AutoSize = True
        Me.MS_RB_AC_IGNORE_PLAYER.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_IGNORE_PLAYER.Depth = 0
        Me.MS_RB_AC_IGNORE_PLAYER.Icon = Nothing
        Me.MS_RB_AC_IGNORE_PLAYER.Location = New System.Drawing.Point(777, 354)
        Me.MS_RB_AC_IGNORE_PLAYER.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_IGNORE_PLAYER.Name = "MS_RB_AC_IGNORE_PLAYER"
        Me.MS_RB_AC_IGNORE_PLAYER.Primary = True
        Me.MS_RB_AC_IGNORE_PLAYER.Size = New System.Drawing.Size(140, 36)
        Me.MS_RB_AC_IGNORE_PLAYER.TabIndex = 24
        Me.MS_RB_AC_IGNORE_PLAYER.Text = "Ignore      Player"
        Me.MS_RB_AC_IGNORE_PLAYER.UseVisualStyleBackColor = True
        '
        'MS_TXT_AC_PLAYER_ENTRY
        '
        Me.MS_TXT_AC_PLAYER_ENTRY.Depth = 0
        Me.MS_TXT_AC_PLAYER_ENTRY.Hint = "  Player"
        Me.MS_TXT_AC_PLAYER_ENTRY.Location = New System.Drawing.Point(604, 438)
        Me.MS_TXT_AC_PLAYER_ENTRY.MaxLength = 32767
        Me.MS_TXT_AC_PLAYER_ENTRY.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_TXT_AC_PLAYER_ENTRY.Name = "MS_TXT_AC_PLAYER_ENTRY"
        Me.MS_TXT_AC_PLAYER_ENTRY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MS_TXT_AC_PLAYER_ENTRY.SelectedText = ""
        Me.MS_TXT_AC_PLAYER_ENTRY.SelectionLength = 0
        Me.MS_TXT_AC_PLAYER_ENTRY.SelectionStart = 0
        Me.MS_TXT_AC_PLAYER_ENTRY.Size = New System.Drawing.Size(200, 23)
        Me.MS_TXT_AC_PLAYER_ENTRY.TabIndex = 26
        Me.MS_TXT_AC_PLAYER_ENTRY.TabStop = False
        Me.MS_TXT_AC_PLAYER_ENTRY.UseSystemPasswordChar = False
        '
        'MaterialDivider4
        '
        Me.MaterialDivider4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider4.Depth = 0
        Me.MaterialDivider4.Location = New System.Drawing.Point(375, 483)
        Me.MaterialDivider4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider4.Name = "MaterialDivider4"
        Me.MaterialDivider4.Size = New System.Drawing.Size(656, 124)
        Me.MaterialDivider4.TabIndex = 27
        Me.MaterialDivider4.Text = "MaterialDivider4"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(384, 492)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(126, 19)
        Me.MaterialLabel4.TabIndex = 28
        Me.MaterialLabel4.Text = "Other Commands"
        '
        'MS_TXT_OC_CMD_ENRTY
        '
        Me.MS_TXT_OC_CMD_ENRTY.Depth = 0
        Me.MS_TXT_OC_CMD_ENRTY.Hint = "Command"
        Me.MS_TXT_OC_CMD_ENRTY.Location = New System.Drawing.Point(478, 521)
        Me.MS_TXT_OC_CMD_ENRTY.MaxLength = 32767
        Me.MS_TXT_OC_CMD_ENRTY.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_TXT_OC_CMD_ENRTY.Name = "MS_TXT_OC_CMD_ENRTY"
        Me.MS_TXT_OC_CMD_ENRTY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MS_TXT_OC_CMD_ENRTY.SelectedText = ""
        Me.MS_TXT_OC_CMD_ENRTY.SelectionLength = 0
        Me.MS_TXT_OC_CMD_ENRTY.SelectionStart = 0
        Me.MS_TXT_OC_CMD_ENRTY.Size = New System.Drawing.Size(200, 23)
        Me.MS_TXT_OC_CMD_ENRTY.TabIndex = 29
        Me.MS_TXT_OC_CMD_ENRTY.TabStop = False
        Me.MS_TXT_OC_CMD_ENRTY.UseSystemPasswordChar = False
        '
        'MS_TXT_OC_CHAT_ENTRY
        '
        Me.MS_TXT_OC_CHAT_ENTRY.Depth = 0
        Me.MS_TXT_OC_CHAT_ENTRY.Hint = "Chat"
        Me.MS_TXT_OC_CHAT_ENTRY.Location = New System.Drawing.Point(479, 568)
        Me.MS_TXT_OC_CHAT_ENTRY.MaxLength = 32767
        Me.MS_TXT_OC_CHAT_ENTRY.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_TXT_OC_CHAT_ENTRY.Name = "MS_TXT_OC_CHAT_ENTRY"
        Me.MS_TXT_OC_CHAT_ENTRY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MS_TXT_OC_CHAT_ENTRY.SelectedText = ""
        Me.MS_TXT_OC_CHAT_ENTRY.SelectionLength = 0
        Me.MS_TXT_OC_CHAT_ENTRY.SelectionStart = 0
        Me.MS_TXT_OC_CHAT_ENTRY.Size = New System.Drawing.Size(200, 23)
        Me.MS_TXT_OC_CHAT_ENTRY.TabIndex = 30
        Me.MS_TXT_OC_CHAT_ENTRY.TabStop = False
        Me.MS_TXT_OC_CHAT_ENTRY.UseSystemPasswordChar = False
        '
        'MS_RB_AC_OC_CMD_SUBMIT
        '
        Me.MS_RB_AC_OC_CMD_SUBMIT.AutoSize = True
        Me.MS_RB_AC_OC_CMD_SUBMIT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_AC_OC_CMD_SUBMIT.Depth = 0
        Me.MS_RB_AC_OC_CMD_SUBMIT.Icon = Nothing
        Me.MS_RB_AC_OC_CMD_SUBMIT.Location = New System.Drawing.Point(764, 514)
        Me.MS_RB_AC_OC_CMD_SUBMIT.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_AC_OC_CMD_SUBMIT.Name = "MS_RB_AC_OC_CMD_SUBMIT"
        Me.MS_RB_AC_OC_CMD_SUBMIT.Primary = True
        Me.MS_RB_AC_OC_CMD_SUBMIT.Size = New System.Drawing.Size(71, 36)
        Me.MS_RB_AC_OC_CMD_SUBMIT.TabIndex = 31
        Me.MS_RB_AC_OC_CMD_SUBMIT.Text = "Submit"
        Me.MS_RB_AC_OC_CMD_SUBMIT.UseVisualStyleBackColor = True
        '
        'MS_RB_OC_CHAT_SEND
        '
        Me.MS_RB_OC_CHAT_SEND.AutoSize = True
        Me.MS_RB_OC_CHAT_SEND.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MS_RB_OC_CHAT_SEND.Depth = 0
        Me.MS_RB_OC_CHAT_SEND.Icon = Nothing
        Me.MS_RB_OC_CHAT_SEND.Location = New System.Drawing.Point(771, 561)
        Me.MS_RB_OC_CHAT_SEND.MouseState = MaterialSkin.MouseState.HOVER
        Me.MS_RB_OC_CHAT_SEND.Name = "MS_RB_OC_CHAT_SEND"
        Me.MS_RB_OC_CHAT_SEND.Primary = True
        Me.MS_RB_OC_CHAT_SEND.Size = New System.Drawing.Size(56, 36)
        Me.MS_RB_OC_CHAT_SEND.TabIndex = 32
        Me.MS_RB_OC_CHAT_SEND.Text = "Send"
        Me.MS_RB_OC_CHAT_SEND.UseVisualStyleBackColor = True
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(165, 169)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(53, 19)
        Me.MaterialLabel5.TabIndex = 33
        Me.MaterialLabel5.Text = "Output"
        '
        'MaterialDivider5
        '
        Me.MaterialDivider5.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider5.Depth = 0
        Me.MaterialDivider5.Location = New System.Drawing.Point(13, 148)
        Me.MaterialDivider5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider5.Name = "MaterialDivider5"
        Me.MaterialDivider5.Size = New System.Drawing.Size(356, 54)
        Me.MaterialDivider5.TabIndex = 34
        Me.MaterialDivider5.Text = "MaterialDivider5"
        '
        'FRM_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1043, 619)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MS_RB_OC_CHAT_SEND)
        Me.Controls.Add(Me.MS_RB_AC_OC_CMD_SUBMIT)
        Me.Controls.Add(Me.MS_TXT_OC_CHAT_ENTRY)
        Me.Controls.Add(Me.MS_TXT_OC_CMD_ENRTY)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialDivider4)
        Me.Controls.Add(Me.MS_TXT_AC_PLAYER_ENTRY)
        Me.Controls.Add(Me.MS_RB_AC_UNIGNORE_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_IGNORE_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_UNMUTE_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_MUTE_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_DEMOTE_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_PROMOTE_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_UNBAN_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_BAN_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_KICK_PLAYER)
        Me.Controls.Add(Me.MS_RB_AC_PURGE_PLAYER)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialDivider3)
        Me.Controls.Add(Me.MS_RB_QC_STOP_SRV)
        Me.Controls.Add(Me.MS_RB_QC_SERVSAVE)
        Me.Controls.Add(Me.MS_RB_QC_ADMINS)
        Me.Controls.Add(Me.MS_RB_QC_PLAYERS)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialDivider2)
        Me.Controls.Add(Me.MS_RB_DISCONNECT)
        Me.Controls.Add(Me.MS_RB_CONNECT)
        Me.Controls.Add(Me.MS_TXT_CON_PASSWD)
        Me.Controls.Add(Me.MS_TXT_CON_PORT)
        Me.Controls.Add(Me.MS_OUTPUT)
        Me.Controls.Add(Me.MS_TXT_CON_IP)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialDivider5)
        Me.Name = "FRM_MAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factorio RCON Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MS_TXT_CON_IP As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MS_OUTPUT As TextBox
    Friend WithEvents MS_TXT_CON_PORT As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MS_TXT_CON_PASSWD As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MS_RB_CONNECT As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_DISCONNECT As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MS_RB_QC_PLAYERS As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_QC_ADMINS As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_QC_SERVSAVE As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_QC_STOP_SRV As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MS_RB_AC_PURGE_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_KICK_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_BAN_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_UNBAN_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_PROMOTE_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_DEMOTE_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_MUTE_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_UNMUTE_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_UNIGNORE_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_AC_IGNORE_PLAYER As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_TXT_AC_PLAYER_ENTRY As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialDivider4 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MS_TXT_OC_CMD_ENRTY As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MS_TXT_OC_CHAT_ENTRY As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MS_RB_AC_OC_CMD_SUBMIT As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MS_RB_OC_CHAT_SEND As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider5 As MaterialSkin.Controls.MaterialDivider
End Class
