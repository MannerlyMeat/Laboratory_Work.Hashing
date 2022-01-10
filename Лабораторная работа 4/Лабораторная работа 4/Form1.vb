Public Class Form1
    Dim a As Integer = 37
    Dim b As Integer = 11
    Dim maxVal As Integer = 255
    Dim c As Integer = maxVal + 1
    Dim t0 As Integer = 221

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KSumm(TextBox1)
        SummKodBukvOtkr(TextBox1)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Text = "021135579"
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox1.Text = "975531120"
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox1.Text = "1000097"
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox1.Text = "1970000"
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Sub KSumm(ByVal text As TextBox)
        Dim sum As Integer
        For i As Integer = 0 To TextBox1.Text.Length - 1
            sum += Int(Asc(text.Text(i)))
        Next
        If sum <= maxVal Then
            Label3.Text = sum
        Else
            Label3.Text = sum Mod maxVal + 1
        End If
    End Sub

    Sub SummKodBukvOtkr(ByVal text As TextBox)
        Dim t As Integer = t0
        Dim sum As Integer
        For i = 0 To TextBox1.Text.Length - 1
            Dim x As Integer = Convert.ToByte(Val(text.Text(i)))
            Dim Tt As Integer = Convert.ToByte(t)
            sum = x Xor Tt
            Tt = (a * t + b) Mod c
        Next
        Label5.Text = sum Mod c
    End Sub
End Class
