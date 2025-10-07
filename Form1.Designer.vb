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
        Button1 = New Button()
        خروج = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(349, 51)
        Button1.TabIndex = 0
        Button1.Text = "حول المشروع"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' خروج
        ' 
        خروج.Location = New Point(12, 80)
        خروج.Name = "خروج"
        خروج.Size = New Size(349, 43)
        خروج.TabIndex = 1
        خروج.Text = "خروج"
        خروج.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 144)
        Button3.Name = "Button3"
        Button3.Size = New Size(349, 42)
        Button3.TabIndex = 2
        Button3.Text = "صندوق إدخال الألوان"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 205)
        Button4.Name = "Button4"
        Button4.Size = New Size(349, 39)
        Button4.TabIndex = 3
        Button4.Text = "الألوان العشوائية"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 264)
        Button5.Name = "Button5"
        Button5.Size = New Size(349, 42)
        Button5.TabIndex = 4
        Button5.Text = "الكتابة على عدة أسطر"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 379)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(349, 59)
        TextBox1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Location = New Point(12, 321)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 55)
        Label1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 450)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(خروج)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "س"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents خروج As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label


End Class
