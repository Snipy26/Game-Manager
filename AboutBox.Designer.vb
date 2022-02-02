<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
        Me.Label1Copyright = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1OK = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1Copyright
        '
        Me.Label1Copyright.AutoSize = True
        Me.Label1Copyright.Location = New System.Drawing.Point(13, 246)
        Me.Label1Copyright.Name = "Label1Copyright"
        Me.Label1Copyright.Size = New System.Drawing.Size(90, 13)
        Me.Label1Copyright.TabIndex = 3
        Me.Label1Copyright.Text = "Copyright © 2014"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 223)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LabelProductName)
        Me.TabPage1.Controls.Add(Me.LabelVersion)
        Me.TabPage1.Controls.Add(Me.LabelCopyright)
        Me.TabPage1.Controls.Add(Me.LabelCompanyName)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(382, 197)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Über..."
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(6, 6)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(70, 13)
        Me.LabelProductName.TabIndex = 6
        Me.LabelProductName.Text = "Produktname"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(6, 32)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(42, 13)
        Me.LabelVersion.TabIndex = 5
        Me.LabelVersion.Text = "Version"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Location = New System.Drawing.Point(6, 58)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(51, 13)
        Me.LabelCopyright.TabIndex = 3
        Me.LabelCopyright.Text = "Copyright"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(6, 84)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(64, 13)
        Me.LabelCompanyName.TabIndex = 1
        Me.LabelCompanyName.Text = "Firmenname"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(248, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(382, 197)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Copyrights"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 181)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Button1OK
        '
        Me.Button1OK.Location = New System.Drawing.Point(315, 241)
        Me.Button1OK.Name = "Button1OK"
        Me.Button1OK.Size = New System.Drawing.Size(87, 23)
        Me.Button1OK.TabIndex = 5
        Me.Button1OK.Text = "Schliessen"
        Me.Button1OK.UseVisualStyleBackColor = True
        '
        'AboutBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 276)
        Me.Controls.Add(Me.Button1OK)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1Copyright)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Info"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1Copyright As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1OK As System.Windows.Forms.Button

End Class
