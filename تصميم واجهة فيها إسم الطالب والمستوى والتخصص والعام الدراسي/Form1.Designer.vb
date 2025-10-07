<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.IndianRed
        Label1.Location = New Point(113, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 38)
        Label1.TabIndex = 0
        Label1.Text = "همام أحمد سالم علي جلعوم "
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.IndianRed
        Label2.Location = New Point(99, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(222, 40)
        Label2.TabIndex = 1
        Label2.Text = "تقنية معلومات عام مستوى ثاني"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.IndianRed
        Label3.Location = New Point(173, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 34)
        Label3.TabIndex = 2
        Label3.Text = "2025-2026"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(711, 443)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
