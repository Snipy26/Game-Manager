Public Class Form1

    Dim LastSTate As FormWindowState

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'My.Computer.Audio.Play(My.Resources.Startsound, AudioPlayMode.Background)

        'listeSpiele.Items.Add("Battlefield 1942")  ' 0
        'listeSpiele.Items.Add("CoD4 MP")  ' 1
        'listeSpiele.Items.Add("Battlefield 1942")  ' 2
        'listeSpiele.Items.Add("Battlefield Heros")  ' 3
        'listeSpiele.Items.Add("Battlefield Play For Free")  ' 4
        'listeSpiele.Items.Add("Call of Duty 4 SP")  ' 5
        'listeSpiele.Items.Add("Call of Duty 4 MP")  ' 6
        'listeSpiele.Items.Add("Spiel 7")  ' 7
        'listeSpiele.Items.Add("test")   ' 8

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click


        'If listeSpiele.SelectedIndex = 0 Then Process.Start("C:\Program Files (x86)\Origin Games\Battlefield 1942\BF1942_GM.lnk")

        'If listeSpiele.SelectedIndex = 1 Then Process.Start("C:\Program Files (x86)\Activision\Call of Duty 4 - Modern Warfare\IWMP.lnk")

        'If listeSpiele.SelectedIndex = 2 Then MsgBox("Spiel 3")

        'If listeSpiele.SelectedIndex = 8 Then Process.Start("F:\Program Files (x86)\Codemasters\Overlord\Overlord.exe")

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        If LastSTate = FormWindowState.Normal AndAlso Me.WindowState = FormWindowState.Minimized Then
            My.Computer.Audio.Play(My.Resources.Minimize, AudioPlayMode.Background)

        ElseIf LastSTate = FormWindowState.Minimized Then
            My.Computer.Audio.Play(My.Resources.Maximize, AudioPlayMode.Background)

        End If
        LastSTate = Me.WindowState

    End Sub

    Private Sub SpielHinzufügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpielHinzufügenToolStripMenuItem.Click
        MsgBox("Wähle dein Spiel, was du hinzufügen möchtest")
        listeSpiele.Items.Add("*")


        ' Dim fbd As New FolderBrowserDialog

        ' fbd.RootFolder = 
        ''Environment.SpecialFolder.Desktop()
        ' fbd.ShowNewFolderButton = False
        ' fbd.Description = "Verzeichnis auswählen"

        ' If fbd.ShowDialog() = DialogResult.OK Then
        '     MessageBox.Show("Zugriff auf " &
        '        "Verzeichnis: " & fbd.SelectedPath)
        ' Else
        '     MessageBox.Show("Abbruch")
        ' End If

    End Sub

    Private Sub SpielEntfernenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpielEntfernenToolStripMenuItem.Click

        Dim ask As MsgBoxResult
        ask = MsgBox("Wirklich löschen??", MsgBoxStyle.YesNo, " ")
        If ask = MsgBoxResult.Yes Then
            listeSpiele.Items.Remove(listeSpiele.SelectedItem)
            Process.Start("C:\Windows\System32\appwiz.cpl") ' ggf. weglassen !!
            MsgBox("Wurde entfernt :(")
        Else
            If ask = MsgBoxResult.No Then
                MsgBox("Besser is dat :p")
            End If
        End If
    End Sub

    Private Sub btnloginOrigin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloginOrigin.Click
        Process.Start("C:\Program Files (x86)\Origin\Origin.exe")
        ' aus der Registry kann man die Pfad ermitteln
    End Sub

    Private Sub btnloginSteam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloginSteam.Click
        Process.Start("C:\Program Files (x86)\Steam\Steam.exe")
        ' aus der Registry kann man die Pfad ermitteln
    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangelogToolStripMenuItem.Click
        Dim fileReader As String = "Hier komme der komplette Text rein aus der Textdatei"


        ' fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\sachs\Desktop\VB Basic\Game Manager 1.0\Game Manager\Changelog.txt",
        ' System.Text.Encoding.UTF32)
        MsgBox(fileReader)
    End Sub

    Private Sub HilfeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HilfeToolStripMenuItem.Click
        Dim fileReader As String
             Dim fileReader As String = "Hier komme der komplette Text rein aus der Textdatei"
      '  fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\sachs\Desktop\VB Basic\Game Manager 1.0\Game Manager\Help1.txt",
      '  System.Text.Encoding.UTF32)
        MsgBox(fileReader)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        MsgBox("Derzeit nicht verfügbar!")
    End Sub

    Private Sub ÜberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÜberToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub OriginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginToolStripMenuItem.Click
        Process.Start("C:\Program Files (x86)\Origin\Origin.exe")
        ' aus der Registry kann man die Pfad ermitteln
    End Sub

    Private Sub SteamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SteamToolStripMenuItem.Click
        Process.Start("C:\Program Files (x86)\Steam\Steam.exe")
        ' aus der Registry kann man die Pfad ermitteln
    End Sub

    Private Sub BattlenetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BattlenetToolStripMenuItem.Click
        Process.Start("C:\Program Files (x86)\Battle.net\Battle.net.exe")
        ' aus der Registry kann man die Pfad ermitteln
    End Sub

    Private Sub Teamspeak3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Teamspeak3ToolStripMenuItem.Click
        Process.Start("C:\Program Files\TeamSpeak 3 Client\ts3client_win64.exe")
        ' aus der Registry kann man die Pfad ermitteln
    End Sub

    Private Sub Form1_close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        My.Computer.Audio.Play(My.Resources.Endsound, AudioPlayMode.WaitToComplete)
    End Sub

End Class