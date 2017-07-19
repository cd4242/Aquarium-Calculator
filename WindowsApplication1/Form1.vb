Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Allows the textbox 4 And 5 to display the volume and the gallons the tank can hold
        'Also the convert to int32 allows the input to be multiplied
        'The format allows for the gallons to be rounded to two decimal places
        TextBox4.Text = (Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text) * Convert.ToInt32(TextBox3.Text))
        TextBox5.Text = Format((Convert.ToInt32(TextBox4.Text) / 231), "0.00")
        TextBox15.Text = (Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox13.Text) * Convert.ToInt32(TextBox3.Text))
        TextBox14.Text = Format((Convert.ToInt32(TextBox15.Text) / 231), "0.00")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Allows button to increase tectbox7 by 1 every time it is clicked
        TextBox7.Text = Val(TextBox7.Text) + 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Allows button to decrease textbox7 by 1 every time it is clicked
        TextBox7.Text = Val(TextBox7.Text) - 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox8.Text = Val(TextBox8.Text) + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox8.Text = Val(TextBox8.Text) - 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox9.Text = Val(TextBox9.Text) + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox9.Text = Val(TextBox9.Text) - 1
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Allows textbox6 to display how much the fish chosen will cost
        TextBox6.Text = (Convert.ToInt32(TextBox9.Text) * 1) + (Convert.ToInt32(TextBox8.Text) * 1.5) + (Convert.ToInt32(TextBox7.Text) * 2)
        'Only allows the user to choose the amount of fish equal to the amount of gallons the tank can hold otherwise a message will appear explaining that
        If (Convert.ToInt32(TextBox7.Text) + Convert.ToInt32(TextBox8.Text) + Convert.ToInt32(TextBox9.Text)) > TextBox5.Text Then
            MessageBox.Show("Total number of fish can not exceed whole number of gallons")
        End If
        'Loop that inputs the data from the calculator to the datagridview
        For index As Integer = TextBox13.Text To TextBox2.Text Step +1
            Me.DataGridView1.Rows.Add(TextBox13.Text, TextBox3.Text, TextBox15.Text, TextBox14.Text, (Convert.ToInt32(TextBox9.Text) + Convert.ToInt32(TextBox8.Text) + Convert.ToInt32(TextBox7.Text)), FormatCurrency(TextBox6.Text))
            'Allows each piece of data to become correct when the loop is in play
            TextBox13.Text = Convert.ToInt32(TextBox13.Text) + 1
            TextBox15.Text = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox13.Text) * Convert.ToInt32(TextBox3.Text)
            TextBox14.Text = Format((Convert.ToInt32(TextBox15.Text) / 231), "0.00")
            Debug.Write(index.ToString & " ")
        Next
        Debug.WriteLine("")
        'Adds the text from the text file to the combobox1 allowing for users to see the fish names and prices 
        ComboBox1.Items.AddRange(IO.File.ReadAllLines("C:/Charlies School Files/POS408/week4/test1.txt"))


    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'exports the data to a test file 
        My.Computer.FileSystem.WriteAllText("C:/Charlies School Files/POS408/week4/test.txt", "Height=" + TextBox1.Text + "inches " + " Length=" + TextBox2.Text + "inches " + " Width=" + TextBox3.Text + "inches " + TextBox9.Text + "=" + TextBox10.Text + " " + TextBox8.Text + "=" + TextBox11.Text + " " + TextBox7.Text + "=" + TextBox12.Text + " Volume=" + TextBox4.Text + " Number of Gallons=" + TextBox5.Text + " Total Cost of Fish =" + TextBox6.Text, True)
        'displays the information that is being exported 
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:/Charlies School Files/POS408/week4/test.txt")
        MsgBox(fileReader)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click_1(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Checks that the user input is greater than 0 and does not exceed 10000 and allows checks that user input is a number only
        Dim Height1 As Integer
        Dim Height2 As Integer
        Try
            Height1 = Val(TextBox1.Text)
            If Height1 < 1 Or Height1 > 10000 Then
                MessageBox.Show("Number Must Be Greater Than 0")
            End If
            Height2 = TextBox1.Text
        Catch ex As Exception
            MessageBox.Show("Enter Numbers Only!")
        End Try





    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

        Dim Length1 As Integer
        Dim Length2 As Integer
        Try
            Length1 = Val(TextBox13.Text)
            If Length1 < 1 Or Length1 > 10000 Then
                MessageBox.Show("Number Must Be Greater Than 0")
            End If
            Length2 = TextBox13.Text
        Catch ex As Exception
            MessageBox.Show("Enter Numbers Only!")
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Dim LengthMax1 As Integer
        Dim LengthMax2 As Integer
        Try
            LengthMax1 = Val(TextBox2.Text)
            If LengthMax1 < 1 Or LengthMax1 > 20000 Then
                MessageBox.Show("Number Must Be Greater Than 0")
            End If
            LengthMax2 = TextBox2.Text
        Catch ex As Exception
            MessageBox.Show("Enter Numbers Only!")
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        Dim Width1 As Integer
        Dim Width2 As Integer
        Try
            Width1 = Val(TextBox3.Text)
            If Width1 < 1 Or Width1 > 20000 Then
                MessageBox.Show("Number Must Be Greater Than 0")
            End If
            Width2 = TextBox3.Text
        Catch ex As Exception
            MessageBox.Show("Enter Numbers Only!")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
