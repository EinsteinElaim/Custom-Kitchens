Public Class FrmCustomer_Detail

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmCustomer_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCreditCardNo.MaxLength = 16

    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click

        Dim name As String = txtName.Text
        Dim houseNo As String = txtHouseNo.Text
        Dim streetName As String = txtStreetName.Text
        Dim townCity As String = txtTownCity.Text
        Dim postCode As String = txtPostCode.Text
        Dim email As String = txtEmail.Text
        Dim creditCardNumber As String


        If txtCreditCardNo.TextLength < 16 Then
            MessageBox.Show("Credit card number too short!")
        ElseIf txtCreditCardNo.TextLength = 16 Then
            creditCardNumber = txtCreditCardNo.Text
        End If



        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("RECEIPT.txt", True)

        file.WriteLine("This is your Receipt of purchase.")
        file.WriteLine(" ")
        file.WriteLine("Name                    :           " + name)
        file.WriteLine(" ")
        file.WriteLine("Your address is:")
        file.WriteLine("House number            :           " + houseNo)
        file.WriteLine("Street name             :           " + streetName)
        file.WriteLine("Town/City               :           " + townCity)
        file.WriteLine("Post code               :           " + postCode)
        file.WriteLine("Email                   :           " + email)
        file.WriteLine(" ")
        file.WriteLine("Credit card number      :           " + creditCardNumber)
        file.WriteLine(" ")
        file.WriteLine(" ")
        file.WriteLine("Total charges           :           ")
        file.Close()
    End Sub
End Class