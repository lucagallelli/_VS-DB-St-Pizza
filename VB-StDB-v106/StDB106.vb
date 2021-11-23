﻿Public Class StDB107
    'set up a record or "class" for a student
    Class STUDENT
        Public studID As Int16
        Public firstname As String
        Public lastname As String
        Public DOB As Date
        Public gender As Char
        Public avMk As Char
        Public phoneNo As String
        Public paid As String
    End Class
    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 9
            students(i) = New STUDENT
        Next
        'load 4 test records
        students(0).studID = 1
        students(0).firstname = "Johnny"
        students(0).lastname = "Depp"
        students(0).DOB = "9/6/63"
        students(0).gender = "Yes"
        students(0).avMk = "settter"
        students(0).phoneNo = "0490487461"
        students(0).paid = False
        students(1).studID = 2
        students(1).firstname = "Jennifer"
        students(1).lastname = "Lawrence"
        students(1).DOB = "15/8/90"
        students(1).gender = "Yes"
        students(1).avMk = "streeeet"
        students(1).phoneNo = "0496375441"
        students(1).paid = True
        students(2).studID = 3
        students(2).firstname = "George"
        students(2).lastname = "Clooney"
        students(2).DOB = "6/5/61"
        students(2).gender = "No"
        students(2).avMk = "street"
        students(2).phoneNo = "0485385185"
        students(2).paid = False
        students(3).studID = 4
        students(3).firstname = "Scarlett"
        students(3).lastname = "Johansson"
        students(3).DOB = "22/11/84"
        students(3).gender = "No"
        students(3).avMk = "street"
        students(3).phoneNo = "0473851375"
        students(3).paid = True
        'set the student count to the number of students which have been entered
        studentCount = 4
        displayList()
    End Sub

    Private Sub txtfirstname_textchanged()
        If Not txtFirstName.Text = txtFirstName_TextChanged(False) Then
            MsgBox("Please Enter a Value", MsgBoxStyle.Exclamation, "Invalid Entry")
        End If

    End Sub
    Private Function txtFirstName_TextChanged(v As Boolean) As String
        Throw New NotImplementedException()
    End Function

    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        students(studentCount).studID = studentCount + 1 'allocate the new student ID to an incremented value
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstname = txtFirstName.Text
        students(studentCount).lastname = txtLastName.Text
        students(studentCount).DOB = txtDOB.Text
        students(studentCount).gender = txtGender.Text
        students(studentCount).avMk = txtAvMk.Text
        students(studentCount).phoneNo = txtPhone.Text
        students(studentCount).paid = chkPaid.Checked
        studentCount += 1
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = ""
        txtGender.Text = ""
        txtAvMk.Text = ""
        txtPhone.Text = ""
        chkPaid.Checked = False
        displayList()
    End Sub
    Private Sub displayList()
        txtStList.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            txtStList.Items.Add(students(i).studID & " - FIRST NAME: " & students(i).firstname & " - LAST NAME: " &
                              students(i).lastname & " - Delivery Date: " & students(i).DOB & " - Delivery " &
                              students(i).gender & " - " & students(i).avMk & " . Phone Number " &
            students(i).phoneNo & " - " & students(i).paid & ".")
        Next
        'gender should be changed to Pick up Or delivery but it works fine'
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtPhone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPhone.MaskInputRejected

    End Sub

    Private Sub txtDOB_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles txtDOB.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGender.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub chkPaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaid.CheckedChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/lucagallelli/_VS-DB-St-Pizza ")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://lucagallelli.github.io/_VS-DB-St-Pizza/ ")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

'Add base options, toppings, quantities, ETA bassed on distance'
'finding order details all with prices'
