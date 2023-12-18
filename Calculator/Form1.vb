Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNum, secondNum, Result As Double
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            firstNum = CDbl(TextBox1.Text)
            secondNum = CDbl(TextBox2.Text)

            Result = firstNum + secondNum
            TextResult.Text = "The Result of " & firstNum & " and " & secondNum & " is :" & Result
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim firstNum, secondNum, Result As Double
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            firstNum = CDbl(TextBox1.Text)
            secondNum = CDbl(TextBox2.Text)

            Result = firstNum - secondNum
            TextResult.Text = "The Result of " & firstNum & " and " & secondNum & " is :" & Result
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim firstNum, secondNum, Result As Double
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            firstNum = CDbl(TextBox1.Text)
            secondNum = CDbl(TextBox2.Text)

            Result = firstNum * secondNum
            TextResult.Text = "The Result of " & firstNum & " and " & secondNum & " is :" & Result
        End If
    End Sub
End Class
