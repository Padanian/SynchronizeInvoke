Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Testaction = New System.Windows.Forms.Button()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.Timeelapsed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Testdelegate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Testaction
        '
        Me.Testaction.Location = New System.Drawing.Point(12, 12)
        Me.Testaction.Name = "Testaction"
        Me.Testaction.Size = New System.Drawing.Size(91, 23)
        Me.Testaction.TabIndex = 0
        Me.Testaction.Text = "Test action"
        Me.Testaction.UseVisualStyleBackColor = True
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(109, 12)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(227, 23)
        Me.Progress.TabIndex = 1
        '
        'Timeelapsed
        '
        Me.Timeelapsed.Location = New System.Drawing.Point(431, 13)
        Me.Timeelapsed.Name = "Timeelapsed"
        Me.Timeelapsed.Size = New System.Drawing.Size(39, 20)
        Me.Timeelapsed.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "time elapsed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ms"
        '
        'Testdelegate
        '
        Me.Testdelegate.Location = New System.Drawing.Point(12, 41)
        Me.Testdelegate.Name = "Testdelegate"
        Me.Testdelegate.Size = New System.Drawing.Size(91, 23)
        Me.Testdelegate.TabIndex = 0
        Me.Testdelegate.Text = "Test delegate"
        Me.Testdelegate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 82)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Timeelapsed)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Testdelegate)
        Me.Controls.Add(Me.Testaction)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Synchronize demo VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Testaction As Button
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents Timeelapsed As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Testdelegate As Button
End Class
