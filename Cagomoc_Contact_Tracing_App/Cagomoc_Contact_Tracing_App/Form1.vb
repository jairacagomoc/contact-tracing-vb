Public Class Form1
    Dim iSubmit As DialogResult
    Dim iExit As DialogResult
    Dim iClear As DialogResult
    Dim g As String
    Dim chk1 As String
    Dim chk2 As String
    Dim chk3 As String
    Dim chk4 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iSubmit = MessageBox.Show("Confirm if you want to submit", "Contact Tracing App", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iSubmit = DialogResult.OK Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\63907\Desktop\Cagomoc_Contact_Tracing_App\test.txt", True)
            file.WriteLine("Full Name : " + TextBox1.Text + ", " + TextBox2.Text + " " + TextBox3.Text + ".")
            file.WriteLine(homeadd.Text + " " + TextBox5.Text)
            file.WriteLine(bday.Text + " " + TextBox6.Text)
            file.WriteLine(age.Text + " " + TextBox4.Text + age1.Text)
            file.WriteLine(gender.Text + " " + g)
            file.WriteLine(email.Text + " " + TextBox7.Text + co.Text)
            file.WriteLine(contact.Text + " " + TextBox8.Text)
            file.WriteLine(vacc.Text + " " + TextBox9.Text)
            file.WriteLine("*******************************")
            file.WriteLine("*******************************")
            If CheckBox1.Checked = True Then
                file.WriteLine(one.Text)
            Else
                'do nothing 
            End If
            If CheckBox2.Checked = True Then
                file.WriteLine(two.Text)
            Else
                'do nothing 
            End If
            If CheckBox3.Checked = True Then
                file.WriteLine(four.Text)
            Else
                'do nothing 
            End If
            If CheckBox4.Checked = True Then
                file.WriteLine(three.Text)
            Else
                'do nothing 
            End If

            file.Close()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox10.Text = "  "
        TextBox10.Text = ((lastname.Text + " " + TextBox1.Text) +
            (vbCrLf + firstname.Text + " " + TextBox2.Text) +
            (vbCrLf + middleI.Text + " " + TextBox3.Text) +
            (vbCrLf + homeadd.Text + " " + TextBox5.Text) +
            (vbCrLf + bday.Text + " " + TextBox6.Text) +
            (vbCrLf + age.Text + " " + TextBox4.Text + age1.Text) +
            (vbCrLf + gender.Text + " " + g) +
            (vbCrLf + email.Text + " " + TextBox7.Text + co.Text) +
            (vbCrLf + contact.Text + " " + TextBox8.Text) +
            (vbCrLf + vacc.Text + " " + TextBox9.Text) +
            (vbCrLf + "*******************************") +
            (vbCrLf + chk1) +
            (vbCrLf + chk2) +
            (vbCrLf + chk3) +
            (vbCrLf + chk4))

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            chk1 = one.Text
        Else
            'do nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        iExit = MessageBox.Show("Do you want to exit? ", "Contact Tracing App", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        iClear = MessageBox.Show("Do you want to clear data ? ", "Contact Tracing App", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iClear = DialogResult.Yes Then
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            Male.Checked = False
            Female.Checked = False
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        Else
            'do nothing
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            chk2 = two.Text
        Else
            'do nothing
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            chk3 = three.Text
        Else
            'do nothing
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            chk4 = four.Text
        Else
            'do nothing
        End If
    End Sub

    Private Sub Male_CheckedChanged(sender As Object, e As EventArgs) Handles Male.CheckedChanged
        If Male.Checked = True Then
            g = " Male "
        End If
    End Sub

    Private Sub Female_CheckedChanged(sender As Object, e As EventArgs) Handles Female.CheckedChanged
        If Female.Checked = True Then
            g = " Female "
        End If
    End Sub
End Class
