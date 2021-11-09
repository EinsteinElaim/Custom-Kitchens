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
        file.WriteLine("    House number        :   " + houseNo)
        file.WriteLine("    Street name         :   " + streetName)
        file.WriteLine("    Town/City           :   " + townCity)
        file.WriteLine("    Post code           :   " + postCode)
        file.WriteLine("    Email               :   " + email)
        file.WriteLine(" ")
        file.WriteLine("Credit card number      :           " + creditCardNumber.ToString)
        file.WriteLine(" ")
        file.WriteLine(" ")
        file.WriteLine("Total charges breakdown :")
        file.WriteLine("Selected kitchen name & Layout          :   " + Form1.selectedKitchenNameAndLayout)
        file.WriteLine(" ")
        file.WriteLine("Selected kitchen actual cost            :   £" + Form1.selectedKitchenActualCost.ToString)
        file.WriteLine("Selected kitchen installation cost      :   £" + Form1.selectedKitchenInstallationCost.ToString)
        file.WriteLine("Selected kitchen appliances cost        :   £" + Form1.kitchenAppliancesTotal.ToString)

        If Form1.shippingCostCharged = True Then
            file.WriteLine("Selected kitchen shipping cost          :   £" + Form1.shippingCost.ToString)
        Else
            Form1.shippingCost = 0
            file.WriteLine("Selected kitchen shipping cost          :   £" + Form1.shippingCost.ToString)
        End If

        file.WriteLine(" ")
        file.WriteLine(" ")
        file.WriteLine("Customer Total Budget   :           £" + Form1.maximumBudget.ToString())


        Dim total As Integer = Form1.selectedKitchenActualCost + Form1.selectedKitchenInstallationCost + Form1.kitchenAppliancesTotal + Form1.shippingCost
        file.WriteLine("Customer Total Charge   :           £" + total.ToString())
        Dim balance As Integer
        If Form1.maximumBudget >= total Then
            balance = Form1.maximumBudget - total
            file.WriteLine("Customer Balance        :           £" + balance.ToString())
        ElseIf Form1.maximumBudget < total Then
            balance = total - Form1.maximumBudget
            file.WriteLine("Customer Deficit        :           £" + balance.ToString())
        End If

        file.WriteLine(" ")
        file.WriteLine(" ")
        file.WriteLine("Thank you for shopping with us!")


        file.Close()
    End Sub
End Class