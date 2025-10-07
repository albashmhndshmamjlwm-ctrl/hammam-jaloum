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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Turquoise
        Label1.Location = New Point(404, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 82)
        Label1.TabIndex = 0
        Label1.Text = "أدخل العدد الأول"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Turquoise
        Label2.Location = New Point(406, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 82)
        Label2.TabIndex = 1
        Label2.Text = "أدخل العدد الثاني "
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Turquoise
        Label3.Location = New Point(406, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 83)
        Label3.TabIndex = 2
        Label3.Text = "النتيجة"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(280, 37)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(107, 55)
        TextBox1.TabIndex = 3
        TextBox1.Text = "76"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(280, 134)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(107, 55)
        TextBox2.TabIndex = 4
        TextBox2.Text = "45"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(280, 233)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(107, 55)
        TextBox3.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Turquoise
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(12, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 402)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "العمليات الحسابية"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.BackColor = Color.DeepSkyBlue
        RadioButton4.ForeColor = SystemColors.ButtonHighlight
        RadioButton4.Location = New Point(6, 310)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(238, 78)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "( / ) القسمة"
        RadioButton4.UseVisualStyleBackColor = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.BackColor = Color.DeepSkyBlue
        RadioButton3.ForeColor = SystemColors.ButtonHighlight
        RadioButton3.Location = New Point(6, 218)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(238, 71)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "( * ) الضرب"
        RadioButton3.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.BackColor = Color.DeepSkyBlue
        RadioButton2.ForeColor = SystemColors.ButtonHighlight
        RadioButton2.Location = New Point(6, 125)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(238, 76)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "( - ) الطرح"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.BackColor = Color.DeepSkyBlue
        RadioButton1.ForeColor = SystemColors.ButtonHighlight
        RadioButton1.Location = New Point(6, 36)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(238, 72)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "( + ) الجمع"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cyan
        Button1.Location = New Point(442, 322)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 59)
        Button1.TabIndex = 7
        Button1.Text = "تنفيذ العملية"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Cyan
        Button2.Location = New Point(280, 322)
        Button2.Name = "Button2"
        Button2.Size = New Size(137, 59)
        Button2.TabIndex = 8
        Button2.Text = "آلة حاسبة متقدمة"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Cyan
        Button3.Location = New Point(367, 387)
        Button3.Name = "Button3"
        Button3.Size = New Size(137, 60)
        Button3.TabIndex = 9
        Button3.Text = "الخروج"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(599, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
