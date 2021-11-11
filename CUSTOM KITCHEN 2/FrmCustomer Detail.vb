Public Class FrmCustomer_Detail



    Public Function Receipt() As Integer

        'IF statements to validate all Customer Details Form inputs
        If txtName.Text = "" Then
            MessageBox.Show("You must enter your name!")
            txtName.Text = "Type names here!"
        End If
        If txtHouseNo.Text = "" Then
            MessageBox.Show("You must enter your house number!")
            txtHouseNo.Text = "Type house number here!"
        End If
        If txtStreetName.Text = "" Then
            MessageBox.Show("You must enter your street name!")
            txtStreetName.Text = "Type street name here!"
        End If
        If txtTownCity.Text = "" Then
            MessageBox.Show("You must enter your town/city name!")
            txtTownCity.Text = "Type town/city name here!"
        End If
        If txtPostCode.Text = "" Then
            MessageBox.Show("You must enter your post code!")
            txtPostCode.Text = "Type post code here!"
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("You must enter your email address!")
            txtEmail.Text = "Type your email here!"
        End If
        If txtCreditCardNo.Text = "" Then
            MessageBox.Show("You must enter your 16 digit credit card number!")
            txtCreditCardNo.Text = "1234123412341234"
        End If



        'Declaring variables to be used for various receipt values and initialising them to their respective textboxes text
        Dim name As String = txtName.Text
        Dim houseNo As String = txtHouseNo.Text
        Dim streetName As String = txtStreetName.Text
        Dim townCity As String = txtTownCity.Text
        Dim postCode As String = txtPostCode.Text
        Dim email As String = txtEmail.Text
        Dim creditCardNumber As String = "1234123412341234"


        'Validating credit card input if less than or equal to 16 digits which will set the creditCardNumber variable to the valid 16 digit input 
        If txtCreditCardNo.TextLength < 16 Then
            MessageBox.Show("Credit card number too short!")
        ElseIf txtCreditCardNo.TextLength = 16 Then
            creditCardNumber = txtCreditCardNo.Text
        End If






        'Creating variable that holds streamwriter that allows user to create files and edit them as well as open files in custom directories
        Dim file As System.IO.StreamWriter
        'Naming the creating, editing and naming the receipt 
        file = My.Computer.FileSystem.OpenTextFileWriter("KitchenReceipt.txt", True)

        'filling the receipt
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

        'checking if shipping charge should be charged
        If Form1.shippingCostCharged = True Then
            file.WriteLine("Selected kitchen shipping cost          :   £" + Form1.shippingCost.ToString)
        Else
            Form1.shippingCost = 0
            file.WriteLine("Selected kitchen shipping cost          :   £" + Form1.shippingCost.ToString)
        End If

        file.WriteLine(" ")
        file.WriteLine(" ")
        file.WriteLine("Customer Total Budget   :           £" + Form1.maximumBudget.ToString())


        'Calculating totals, balances
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

        'Closing the file after use
        file.Close()

        Return 0
    End Function



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label12.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmCustomer_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting the credit card number textbox to accept a maximum input character count of 16 (16 digits maximum for input) on form load to avoid getting more than 16 digits
        txtCreditCardNo.MaxLength = 16

    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click

        'Calling the receipt function that will calculate all costs, totals and balances/deficits if any and put all the customer details and costs breakdown in a receipt text file
        Receipt()

    End Sub

    Private Sub txtCreditCardNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreditCardNo.KeyPress

        'Using a keypress listener to watch the keys pressed in this creditcardnuumber textbox
        'Asc(e.KeyChar) < 48 checks if the ASCII value for key pressed is less than numeric 0(ASCII:48) and Asc(e.KeyChar) > 57  checks if the ASCII value for key pressed is greater than numeric 9(ASCII:57)
        'This limits input to only numbers
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only input numbers!")
        End If

    End Sub

    Private Sub txtCreditCardNo_TextChanged(sender As Object, e As EventArgs) Handles txtCreditCardNo.TextChanged

    End Sub
End Class