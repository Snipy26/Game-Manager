<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.listeSpiele = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnloginOrigin = New System.Windows.Forms.Button()
        Me.btnloginSteam = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OriginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SteamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BattlenetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Teamspeak3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielEntfernenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(160, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 47)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'listeSpiele
        '
        Me.listeSpiele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listeSpiele.FormattingEnabled = True
        Me.listeSpiele.Location = New System.Drawing.Point(12, 95)
        Me.listeSpiele.Name = "listeSpiele"
        Me.listeSpiele.Size = New System.Drawing.Size(270, 23)
        Me.listeSpiele.TabIndex = 4
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 211)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(122, 46)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Starten"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnloginOrigin
        '
        Me.btnloginOrigin.Location = New System.Drawing.Point(12, 276)
        Me.btnloginOrigin.Name = "btnloginOrigin"
        Me.btnloginOrigin.Size = New System.Drawing.Size(122, 44)
        Me.btnloginOrigin.TabIndex = 8
        Me.btnloginOrigin.Text = "Login Origin"
        Me.btnloginOrigin.UseVisualStyleBackColor = True
        '
        'btnloginSteam
        '
        Me.btnloginSteam.Location = New System.Drawing.Point(160, 276)
        Me.btnloginSteam.Name = "btnloginSteam"
        Me.btnloginSteam.Size = New System.Drawing.Size(122, 44)
        Me.btnloginSteam.TabIndex = 9
        Me.btnloginSteam.Text = "Login Steam"
        Me.btnloginSteam.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(54, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Wähle Dein Spiel"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem, Me.LoginToolStripMenuItem, Me.OptionenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(294, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.InfoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangelogToolStripMenuItem, Me.HilfeToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.ÜberToolStripMenuItem})
        Me.InfoToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        Me.InfoToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Image = CType(resources.GetObject("ChangelogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Image = CType(resources.GetObject("HilfeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Image = CType(resources.GetObject("UpdateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ÜberToolStripMenuItem
        '
        Me.ÜberToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Info
        Me.ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        Me.ÜberToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ÜberToolStripMenuItem.Text = "Über ..."
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OriginToolStripMenuItem, Me.SteamToolStripMenuItem, Me.BattlenetToolStripMenuItem, Me.Teamspeak3ToolStripMenuItem})
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'OriginToolStripMenuItem
        '
        Me.OriginToolStripMenuItem.Image = CType(resources.GetObject("OriginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OriginToolStripMenuItem.Name = "OriginToolStripMenuItem"
        Me.OriginToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.OriginToolStripMenuItem.Text = "Origin"
        '
        'SteamToolStripMenuItem
        '
        Me.SteamToolStripMenuItem.Image = CType(resources.GetObject("SteamToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SteamToolStripMenuItem.Name = "SteamToolStripMenuItem"
        Me.SteamToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SteamToolStripMenuItem.Text = "Steam"
        '
        'BattlenetToolStripMenuItem
        '
        Me.BattlenetToolStripMenuItem.Image = CType(resources.GetObject("BattlenetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BattlenetToolStripMenuItem.Name = "BattlenetToolStripMenuItem"
        Me.BattlenetToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.BattlenetToolStripMenuItem.Text = "Battle.net"
        '
        'Teamspeak3ToolStripMenuItem
        '
        Me.Teamspeak3ToolStripMenuItem.Image = CType(resources.GetObject("Teamspeak3ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Teamspeak3ToolStripMenuItem.Name = "Teamspeak3ToolStripMenuItem"
        Me.Teamspeak3ToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.Teamspeak3ToolStripMenuItem.Text = "Teamspeak 3"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpielHinzufügenToolStripMenuItem, Me.SpielEntfernenToolStripMenuItem})
        Me.OptionenToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OptionenToolStripMenuItem.Text = "Optionen"
        '
        'SpielHinzufügenToolStripMenuItem
        '
        Me.SpielHinzufügenToolStripMenuItem.Image = CType(resources.GetObject("SpielHinzufügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SpielHinzufügenToolStripMenuItem.Name = "SpielHinzufügenToolStripMenuItem"
        Me.SpielHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SpielHinzufügenToolStripMenuItem.Text = "Spiel Hinzufügen"
        '
        'SpielEntfernenToolStripMenuItem
        '
        Me.SpielEntfernenToolStripMenuItem.Image = CType(resources.GetObject("SpielEntfernenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SpielEntfernenToolStripMenuItem.Name = "SpielEntfernenToolStripMenuItem"
        Me.SpielEntfernenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SpielEntfernenToolStripMenuItem.Text = "Spiel Entfernen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(294, 332)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnloginSteam)
        Me.Controls.Add(Me.btnloginOrigin)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.listeSpiele)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game-Mananger"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents listeSpiele As System.Windows.Forms.ComboBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnloginOrigin As System.Windows.Forms.Button
    Friend WithEvents btnloginSteam As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpielHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpielEntfernenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OriginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SteamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BattlenetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Teamspeak3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
