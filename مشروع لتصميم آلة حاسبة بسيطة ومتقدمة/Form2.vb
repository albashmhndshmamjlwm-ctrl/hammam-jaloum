Public Class Form2

    Private Sub Button1_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        x = Integer.Parse(TextBox1.Text)
        y = Integer.Parse(TextBox2.Text)
        If RadioButton1.Checked = True Then
            TextBox3.Text = (x Mod y).ToString
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = (x ^ y).ToString
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = System.Math.Sqrt(x).ToString
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = System.Math.Abs(y).ToString
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class