Public Class Form1
    Dim x, y As String
    Dim i As Integer

    ' زر "حول المشروع"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim w As String = vbCrLf
        x = "جامعة الملك سعود" & w
        x &= "مركز التدريب وخدمة المجتمع" & w
        x &= "دبلوم الحاسب الآلي" & w
        x &= "إعداد الأستاذ حذيفة عبدالرحمن" & w
        x &= "للعام الدراسي 1442هـ"
        y = "حول المشروع"
        MsgBox(x, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, y)
    End Sub

    ' زر "خروج"
    Private Sub خروج_Click(sender As Object, e As EventArgs) Handles خروج.Click
        x = "هل تريد الخروج من المشروع؟"
        y = "تحذير"
        Dim k As MsgBoxResult
        k = MsgBox(x, MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, y)
        If k = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    ' زر "صندوق إدخال الألوان"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim input As String
        input = InputBox("الرجاء إدخال عدد بين 0 و 15", "صندوق الإدخال")

        If Integer.TryParse(input, i) Then
            If i >= 0 And i <= 15 Then
                Me.BackColor = System.Drawing.ColorTranslator.FromOle(Microsoft.VisualBasic.QBColor(i))
            Else
                MsgBox("الرقم يجب أن يكون بين 0 و 15", MsgBoxStyle.Exclamation, "تنبيه")
            End If
        Else
            MsgBox("الإدخال يجب أن يكون رقمًا", MsgBoxStyle.Exclamation, "تنبيه")
        End If
    End Sub

    ' زر "الألوان العشوائية"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Randomize()
        Me.BackColor = System.Drawing.Color.FromArgb(Int(Rnd() * 256), Int(Rnd() * 256), Int(Rnd() * 256))
    End Sub

    ' زر "الكتابة على عدة أسطر"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim w As String = vbCrLf
        TextBox1.Text = "الحمد لله" & w & "رب العالمين"
        Label1.Text = "الحمد لله" & w & "رب العالمين"
    End Sub
End Class

