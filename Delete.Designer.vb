<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
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
        Me.btnyes = New System.Windows.Forms.Button()
        Me.btnno = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnyes
        '
        Me.btnyes.Location = New System.Drawing.Point(12, 60)
        Me.btnyes.Name = "btnyes"
        Me.btnyes.Size = New System.Drawing.Size(102, 20)
        Me.btnyes.TabIndex = 0
        Me.btnyes.Text = "Ähmm...Ja"
        Me.btnyes.UseVisualStyleBackColor = True
        '
        'btnno
        '
        Me.btnno.Location = New System.Drawing.Point(139, 60)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(102, 20)
        Me.btnno.TabIndex = 1
        Me.btnno.Text = "Ähmm...Nein"
        Me.btnno.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Wirklich Löschen???"
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 92)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnno)
        Me.Controls.Add(Me.btnyes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Delete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Löschen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnyes As System.Windows.Forms.Button
    Friend WithEvents btnno As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
