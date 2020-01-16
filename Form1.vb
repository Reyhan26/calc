Public Class Calculator

    Dim firstnum As Decimal
    Dim secondnum As Decimal
    Dim operation As Integer
    Dim op_selector As Boolean = False

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles But_0.Click
        If screen.Text <> "0" Then
            screen.Text += "0"
        End If
    End Sub

    Private Sub But_2_Click(sender As Object, e As EventArgs) Handles But_2.Click
        If screen.Text <> "0" Then
            screen.Text += "2"
        Else
            screen.Text = "2"
        End If
    End Sub

    Private Sub But_3_Click(sender As Object, e As EventArgs) Handles But_3.Click
        If screen.Text <> "0" Then
            screen.Text += "3"
        Else
            screen.Text = "3"
        End If
    End Sub

    Private Sub But_1_Click(sender As Object, e As EventArgs) Handles But_1.Click
        If screen.Text <> "0" Then
            screen.Text += "1"
        Else
            screen.Text = "1"
        End If
    End Sub

    Private Sub But_4_Click(sender As Object, e As EventArgs) Handles But_4.Click
        If screen.Text <> "0" Then
            screen.Text += "4"
        Else
            screen.Text = "4"
        End If
    End Sub

    Private Sub But_5_Click(sender As Object, e As EventArgs) Handles But_5.Click
        If screen.Text <> "0" Then
            screen.Text += "5"
        Else
            screen.Text = "5"
        End If
    End Sub

    Private Sub But_6_Click(sender As Object, e As EventArgs) Handles But_6.Click
        If screen.Text <> "0" Then
            screen.Text += "6"
        Else
            screen.Text = "6"
        End If
    End Sub

    Private Sub But_7_Click(sender As Object, e As EventArgs) Handles But_7.Click
        If screen.Text <> "0" Then
            screen.Text += "7"
        Else
            screen.Text = "7"
        End If
    End Sub

    Private Sub But_8_Click(sender As Object, e As EventArgs) Handles But_8.Click
        If screen.Text <> "0" Then
            screen.Text += "8"
        Else
            screen.Text = "8"
        End If
    End Sub

    Private Sub But_9_Click(sender As Object, e As EventArgs) Handles But_9.Click
        If screen.Text <> "0" Then
            screen.Text += "9"
        Else
            screen.Text = "9"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles screen.TextChanged

    End Sub

    Private Sub But_Click(sender As Object, e As EventArgs)

    End Sub
End Class
