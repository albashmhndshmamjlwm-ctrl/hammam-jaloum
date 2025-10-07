<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Location = New Point(317, 308)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 55)
        Button1.TabIndex = 0
        Button1.Text = "تنفيذ العملية"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Cyan
        Button2.Location = New Point(317, 372)
        Button2.Name = "Button2"
        Button2.Size = New Size(168, 55)
        Button2.TabIndex = 1
        Button2.Text = "آلة حاسبة بسيطة"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Turquoise
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 415)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Turquoise
        Label1.Location = New Point(377, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 64)
        Label1.TabIndex = 3
        Label1.Text = "أدخل العدد الأول"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Turquoise
        Label2.Location = New Point(377, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 70)
        Label2.TabIndex = 4
        Label2.Text = "أدخل العدد الثاني "
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Turquoise
        Label3.Location = New Point(377, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 72)
        Label3.TabIndex = 5
        Label3.Text = "النتيجة"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(268, 135)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(103, 53)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(268, 53)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(103, 53)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(268, 221)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(103, 53)
        TextBox3.TabIndex = 8
        ' 
        ' RadioButton1
        ' 
        RadioButton1.BackColor = Color.DeepSkyBlue
        RadioButton1.Location = New Point(6, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(238, 68)
        RadioButton1.TabIndex = 9
        RadioButton1.TabStop = True
        RadioButton1.Text = "(%) باقي القسمة"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.BackColor = Color.DeepSkyBlue
        RadioButton2.Location = New Point(6, 123)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(238, 68)
        RadioButton2.TabIndex = 10
        RadioButton2.TabStop = True
        RadioButton2.Text = "(^) الرفع لقوى"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.BackColor = Color.DeepSkyBlue
        RadioButton3.Location = New Point(6, 226)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(238, 73)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "الجذر التربيعي"
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' RadioButton4
        ' 
        RadioButton4.BackColor = Color.DeepSkyBlue
        RadioButton4.Location = New Point(6, 332)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(238, 70)
        RadioButton4.TabIndex = 11
        RadioButton4.TabStop = True
        RadioButton4.Text = "القيمة المطلقة"
        RadioButton4.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 434)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
End Class
