Public Class Form1

    'Declaring single dimension array to hold kitchen styles names
    Public Shared kitchenStyles() As String = {
            "Small L-shaped kitchen",
            "Medium L-shaped kitchen",
            "Large L-shaped kitchen",
            "Small straight kitchen",
            "Medium straight kitchen",
            "Large straight kitchen",
            "Large island kitchen"
    }

    'Declaring multi/two dimension array to hold kitchen styles dimensions
    Public Shared dimensions(,) As Integer = {
        {250, 180},
        {350, 240},
        {450, 350},
        {150, 60},
        {350, 60},
        {500, 60},
        {450, 450}
    }

    'Declaring single dimension array to hold countertop names
    Public Shared counterTopNames() As String = {
        "Laminate",
        "Wood block",
        "Granite"
    }

    'Declaring multi/three dimension array to hold kitchen styles countertops prices
    Public Shared counterTopsPricing(,) As Integer = {
        {3500, 4500, 5750},
        {6500, 7750, 9500},
        {8250, 9500, 12500},
        {1000, 1500, 2200},
        {5250, 6200, 8000},
        {6750, 8500, 11000},
        {12500, 15000, 23000}
    }

    'Declaring single dimension array to hold kitchen appliances names
    Public Shared kitchenAppliancesNames() As String = {
        "Basic Fridge Freezer",
        "American Style Fridge Freezer",
        "Hob",
        "Single Oven",
        "Double Oven",
        "Dishwasher"
    }

    'Declaring single dimension array to hold kitchen appliances prices
    Public Shared kitchenAppliancesPrices() As Integer = {
        180,
        750,
        400,
        340,
        550,
        270
    }

    'Declaring single dimension array to hold kitchen installation cost for each kitchen style
    Public Shared kitchenInstallationCost() As Integer = {
        1250,
        2750,
        3750,
        750,
        1500,
        2500,
        4750
    }

    'Declaring other variables that will be used
    Public Shared shippingCost As Integer
    Public Shared maximumBudget As Integer
    Public Shared selectedKitchenInstallationCost As Integer
    Public Shared finalTotal As Integer
    Public Shared selectedKitchenActualCost As Integer
    Public Shared kitchenAppliancesTotal As Integer
    Public Shared selectedKitchenNameAndLayout As String
    'Declaring and initialising shipping cost charged variable to False that will be used to validate Shipping cost charge
    Public Shared shippingCostCharged As Boolean = False


    'Creating a function that will be called from the Purchase button that will pass kitchen appliances total cost, kitchen installation cost or shipping cost to the customer detail form
    'The function will aslo display kitchen appliances total cost and take the user to the second Customer Detail form
    Public Function Purchase()

        'Initialising kitchen appliances total counter to 0 to avoid carrying previous values
        kitchenAppliancesTotal = 0


        'Using IF statements to check for checked kitchen appliances checkbuttons and adding their respective prices to kitchenappliancestotal variable
        If ChkBasicFridgeFreezer.Checked Then
            kitchenAppliancesTotal = kitchenAppliancesTotal + kitchenAppliancesPrices(0)
        End If
        If ChkAmericanStyleFridgeFreezer.Checked Then
            kitchenAppliancesTotal = kitchenAppliancesTotal + kitchenAppliancesPrices(1)
        End If
        If ChkHob.Checked Then
            kitchenAppliancesTotal = kitchenAppliancesTotal + kitchenAppliancesPrices(2)
        End If
        If ChkSingleOven.Checked Then
            kitchenAppliancesTotal = kitchenAppliancesTotal + kitchenAppliancesPrices(3)
        End If
        If ChkDoubleOven.Checked Then
            kitchenAppliancesTotal = kitchenAppliancesTotal + kitchenAppliancesPrices(4)
        End If
        If ChkDishwasher.Checked Then
            kitchenAppliancesTotal = kitchenAppliancesTotal + kitchenAppliancesPrices(5)
        End If


        'IF statements to check if user wants their kitchen installed or not and charge a shipping fees from the Install selected kitchen checkbox
        If ChkInstallKitchen.Checked Then
            MessageBox.Show("Selected kitchen Installation Cost is: £" + selectedKitchenInstallationCost.ToString())
            shippingCostCharged = False
        Else
            selectedKitchenInstallationCost = 0
            MessageBox.Show("Your kitchen will not be installed by us. We will charge you a shipping cost of: £" + shippingCost.ToString)
            shippingCostCharged = True
        End If

        'Displaying selected kitchen appliances total cost
        MessageBox.Show("Selected kitchen appliances cost is: £" + kitchenAppliancesTotal.ToString)


        'Displaying the Customer Details form to the user after filling the first form
        Me.Hide()
        FrmCustomer_Detail.Visible = True


        'Functions must have a return value
        Return 0

    End Function



    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged

    End Sub
    Private Sub lblWidth_Click(sender As Object, e As EventArgs) Handles lblWidth.Click

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDishwasher.CheckedChanged

    End Sub

    Private Sub btnEnterSpecification_Click(sender As Object, e As EventArgs) Handles btnEnterSpecification.Click

        'Declaring length, width variables
        Dim length As Integer
        Dim width As Integer

        'IF statements to check if the Length textbox is NULL and displaying to the user an appropriate  message then setting the textbox and variable to minimum allowed value
        If txtLength.Text = "" Then
            MessageBox.Show("Kitchen length value can't be NULL/EMPTY. It will be set to the minimum of 150!")
            txtLength.Text = "150"
            length = 150
        End If

        'IF statements to check if the Width textbox is NULL and displaying to the user an appropriate  message then setting the textbox and variable to minimum allowed value
        If txtWidth.Text = "" Then
            MessageBox.Show("Kitchen width value can't be NULL/EMPTY. It will be set to the minimum of 120!")
            txtWidth.Text = "120"
            width = 120
        End If

        'IF statements to check if the Maximum Budget textbox is NULL and displaying to the user an appropriate  message then setting the textbox and variable to minimum allowed value
        If txtMaximumBudget.Text = "" Then
            MessageBox.Show("Maximum budget value can't be NULL/EMPTY. It will be set to the minimum of 1000!")
            txtMaximumBudget.Text = "1000"
            maximumBudget = 1000
        End If



        'Setting lenth, width and maximumBudget variables to the values filled in respective text boxes by user and converting the inputs to integer types
        length = Convert.ToInt32(txtLength.Text)
        width = Convert.ToInt32(txtWidth.Text)
        maximumBudget = Convert.ToInt32(txtMaximumBudget.Text)

        'Clearing the Kitchen style and countertops combobox to avoid carrying over previous values
        CboKitchenStyle.Items.Clear()
        CboKitchenStyle.Text = ""

        'IF statements to check and set/correct length, width and maximum budget values input by the user
        'Statements that check the length for lower & higher than wanted range for input
        If length < dimensions(3, 0) Then
            MessageBox.Show("Kitchen length value can only be a minimum of 150!")
            txtLength.Text = "150"
            length = 150
        ElseIf length > 600 Then
            MessageBox.Show("Kitchen length value can only be a maximum 0f 600!")
            txtLength.Text = "600"
            length = 600
        End If
        'Statements that check the widgth for lower & higher than wanted range for input
        If width < 120 Then
            MessageBox.Show("Kitchen width value can only be a minimum of 120!")
            txtWidth.Text = "120"
            width = 120
        ElseIf width > 600 Then
            MessageBox.Show("Kitchen width value can only be a maximum of 600!")
            txtWidth.Text = "600"
            width = 600
        End If
        'Statements that check the maximumBudget for lower & higher than wanted range for input
        If maximumBudget < counterTopsPricing(3, 0) Then
            MessageBox.Show("Total budget entered can only be a minimum of 1,000!")
            txtMaximumBudget.Text = "1000"
            maximumBudget = 1000
        ElseIf maximumBudget > 25000 Then
            MessageBox.Show("Total budget entered can only be a maximum of 25,000!")
            txtMaximumBudget.Text = "25000"
            maximumBudget = 25000
        End If

        


        'Messagebox to show Inputs are valid if all criteria has been met above
        MessageBox.Show("Inputs are valid!")





        'Nested If statements to set kitchen styles and countertops to be displayed in the kitchen style and countertops combobox depending on the length, width and maximum budget inputs from the user
        'Kitchen layouts as per Small Straight Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(3, 0) And Convert.ToInt64(width) >= dimensions(3, 1) Then
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(3, 0) Then
                CboKitchenStyle.Items.Add(kitchenStyles(3) + " with " + counterTopNames(0) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(3, 1) Then
                CboKitchenStyle.Items.Add(kitchenStyles(3) + " with " + counterTopNames(1) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(3, 2) Then
                CboKitchenStyle.Items.Add(kitchenStyles(3) + " with " + counterTopNames(2) + " countertops")
            End If
        End If

        'Kitchen layouts as per Small L-shaped Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(0, 0) And Convert.ToInt64(width) >= dimensions(0, 1) Then
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(0, 0) Then
                CboKitchenStyle.Items.Add(kitchenStyles(0) + " with " + counterTopNames(0) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(0, 1) Then
                CboKitchenStyle.Items.Add(kitchenStyles(0) + " with " + counterTopNames(1) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(0, 2) Then
                CboKitchenStyle.Items.Add(kitchenStyles(0) + " with " + counterTopNames(2) + " countertops")
            End If
        End If

        'Kitchen layouts as per Medium Straight Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(4, 0) And Convert.ToInt64(width) >= dimensions(4, 1) Then
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(4, 0) Then
                CboKitchenStyle.Items.Add(kitchenStyles(4) + " with " + counterTopNames(0) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(4, 1) Then
                CboKitchenStyle.Items.Add(kitchenStyles(4) + " with " + counterTopNames(1) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(4, 2) Then
                CboKitchenStyle.Items.Add(kitchenStyles(4) + " with " + counterTopNames(2) + " countertops")
            End If
        End If

        'Kitchen layouts as per Medium L-shaped Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(1, 0) And Convert.ToInt64(width) >= dimensions(1, 1) Then
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(1, 0) Then
                CboKitchenStyle.Items.Add(kitchenStyles(1) + " with " + counterTopNames(0) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(1, 1) Then
                CboKitchenStyle.Items.Add(kitchenStyles(1) + " with " + counterTopNames(1) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(1, 2) Then
                CboKitchenStyle.Items.Add(kitchenStyles(1) + " with " + counterTopNames(2) + " countertops")
            End If
        End If

        'Kitchen layouts as per Large L-shaped Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(2, 0) And Convert.ToInt64(width) >= dimensions(2, 1) Then
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(2, 0) Then
                CboKitchenStyle.Items.Add(kitchenStyles(2) + " with " + counterTopNames(0) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(2, 1) Then
                CboKitchenStyle.Items.Add(kitchenStyles(2) + " with " + counterTopNames(1) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(2, 2) Then
                CboKitchenStyle.Items.Add(kitchenStyles(2) + " with " + counterTopNames(2) + " countertops")
            End If
        End If

        'Kitchen layouts as per Large Straight Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(5, 0) And Convert.ToInt64(width) >= dimensions(5, 1) Then
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(5, 0) Then
                CboKitchenStyle.Items.Add(kitchenStyles(5) + " with " + counterTopNames(0) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(5, 1) Then
                CboKitchenStyle.Items.Add(kitchenStyles(5) + " with " + counterTopNames(1) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(5, 2) Then
                CboKitchenStyle.Items.Add(kitchenStyles(5) + " with " + counterTopNames(2) + " countertops")
            End If
        End If

        'Kitchen layouts as per Large Island Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(6, 0) And Convert.ToInt64(width) >= dimensions(6, 1) Then
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(6, 0) Then
                CboKitchenStyle.Items.Add(kitchenStyles(6) + " with " + counterTopNames(0) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(6, 1) Then
                CboKitchenStyle.Items.Add(kitchenStyles(6) + " with " + counterTopNames(1) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(6, 2) Then
                CboKitchenStyle.Items.Add(kitchenStyles(6) + " with " + counterTopNames(2) + " countertops")
            End If
        End If

        'Activating the select kitchen button that selects the user's selected kitchen and countertop from combobox
        btnSelectKitchenAndAppliances.Enabled = True


    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click

        'Calling/running the Purchase function from clicking the Purchase button
        Purchase()
    End Sub

    Private Sub CboCountertop_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialising length. width and maximum budget textboxes to 0 text to avoid null value prompts
        txtLength.Text = "0"
        txtWidth.Text = "0"
        txtMaximumBudget.Text = "0"

        'Disabling  the Select kitchen button to avoid user selecting null value before the appropriate kitchens are listed in the kitchen style and countertops combobox
        btnSelectKitchenAndAppliances.Enabled = False

        'Hiding the group box containing kitchen appliances checkbuttons, install kitchen checkbox and Purchase button that will show only after user has selected a kitchen and countertop 
        GroupBox1.Hide()

        'Initialising shipping cot to 95 everytime form1 loads to avoid picking up previous used values
        shippingCost = 95
        'Initilising selected kitchen installation cost and final total(will be used in second form to set total for selected kitchen and countertop, installation & kitchen appliances selected) cost to zero
        selectedKitchenInstallationCost = 0
        finalTotal = 0
    End Sub

    Private Sub btnSelectKitchenAndAppliances_Click(sender As Object, e As EventArgs) Handles btnSelectKitchenAndAppliances.Click

        'Declaring and initialising all String values of all kitchens and countertops options available to be used below to determine kitchen actual cost and installation cost for each kitchen style listed in the Kitchen style and countertops combobox 
        Dim kitchenZeroZero As String = kitchenStyles(0) + " with " + counterTopNames(0) + " countertops"
        Dim kitchenZeroOne As String = kitchenStyles(0) + " with " + counterTopNames(1) + " countertops"
        Dim kitchenZeroTwo As String = kitchenStyles(0) + " with " + counterTopNames(2) + " countertops"
        Dim kitchenOneZero As String = kitchenStyles(1) + " with " + counterTopNames(0) + " countertops"
        Dim kitchenOneOne As String = kitchenStyles(1) + " with " + counterTopNames(1) + " countertops"
        Dim kitchenOneTwo As String = kitchenStyles(1) + " with " + counterTopNames(2) + " countertops"
        Dim kitchenTwoZero As String = kitchenStyles(2) + " with " + counterTopNames(0) + " countertops"
        Dim kitchenTwoOne As String = kitchenStyles(2) + " with " + counterTopNames(1) + " countertops"
        Dim kitchenTwoTwo As String = kitchenStyles(2) + " with " + counterTopNames(2) + " countertops"
        Dim kitchenThreeZero As String = kitchenStyles(3) + " with " + counterTopNames(0) + " countertops"
        Dim kitchenThreeONe As String = kitchenStyles(3) + " with " + counterTopNames(1) + " countertops"
        Dim kitchenThreeTwo As String = kitchenStyles(3) + " with " + counterTopNames(2) + " countertops"
        Dim kitchenFourZero As String = kitchenStyles(4) + " with " + counterTopNames(0) + " countertops"
        Dim kitchenFourOne As String = kitchenStyles(4) + " with " + counterTopNames(1) + " countertops"
        Dim kitchenFourTwo As String = kitchenStyles(4) + " with " + counterTopNames(2) + " countertops"
        Dim kitchenFiveZero As String = kitchenStyles(5) + " with " + counterTopNames(0) + " countertops"
        Dim kitchenFiveOne As String = kitchenStyles(5) + " with " + counterTopNames(1) + " countertops"
        Dim kitchenFiveTwo As String = kitchenStyles(5) + " with " + counterTopNames(2) + " countertops"
        Dim kitchenSixZero As String = kitchenStyles(6) + " with " + counterTopNames(0) + " countertops"
        Dim kitchenSixOne As String = kitchenStyles(6) + " with " + counterTopNames(1) + " countertops"
        Dim kitchenSixTwo As String = kitchenStyles(6) + " with " + counterTopNames(2) + " countertops"



        'IF statements to determine kitchen actual cost and installation cost for each kitchen style listed in the Kitchen style and countertops combobox item that the user will select
        If CboKitchenStyle.SelectedItem.ToString = kitchenZeroZero Then
            selectedKitchenActualCost = counterTopsPricing(0, 0)
            selectedKitchenInstallationCost = kitchenInstallationCost(0)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenZeroOne Then
            selectedKitchenActualCost = counterTopsPricing(0, 1)
            selectedKitchenInstallationCost = kitchenInstallationCost(0)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenZeroTwo Then
            selectedKitchenActualCost = counterTopsPricing(0, 2)
            selectedKitchenInstallationCost = kitchenInstallationCost(0)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenOneZero Then
            selectedKitchenActualCost = counterTopsPricing(1, 0)
            selectedKitchenInstallationCost = kitchenInstallationCost(1)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenOneOne Then
            selectedKitchenActualCost = counterTopsPricing(1, 1)
            selectedKitchenInstallationCost = kitchenInstallationCost(1)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenOneTwo Then
            selectedKitchenActualCost = counterTopsPricing(1, 2)
            selectedKitchenInstallationCost = kitchenInstallationCost(1)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenTwoZero Then
            selectedKitchenActualCost = counterTopsPricing(2, 0)
            selectedKitchenInstallationCost = kitchenInstallationCost(2)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenTwoOne Then
            selectedKitchenActualCost = counterTopsPricing(2, 1)
            selectedKitchenInstallationCost = kitchenInstallationCost(2)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenTwoTwo Then
            selectedKitchenActualCost = counterTopsPricing(2, 2)
            selectedKitchenInstallationCost = kitchenInstallationCost(2)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenThreeZero Then
            selectedKitchenActualCost = counterTopsPricing(3, 0)
            selectedKitchenInstallationCost = kitchenInstallationCost(3)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenThreeONe Then
            selectedKitchenActualCost = counterTopsPricing(3, 1)
            selectedKitchenInstallationCost = kitchenInstallationCost(3)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenThreeTwo Then
            selectedKitchenActualCost = counterTopsPricing(3, 2)
            selectedKitchenInstallationCost = kitchenInstallationCost(3)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenFourZero Then
            selectedKitchenActualCost = counterTopsPricing(4, 0)
            selectedKitchenInstallationCost = kitchenInstallationCost(4)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenFourOne Then
            selectedKitchenActualCost = counterTopsPricing(4, 1)
            selectedKitchenInstallationCost = kitchenInstallationCost(4)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenFourTwo Then
            selectedKitchenActualCost = counterTopsPricing(4, 2)
            selectedKitchenInstallationCost = kitchenInstallationCost(4)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenFiveZero Then
            selectedKitchenActualCost = counterTopsPricing(5, 0)
            selectedKitchenInstallationCost = kitchenInstallationCost(5)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenFiveOne Then
            selectedKitchenActualCost = counterTopsPricing(5, 1)
            selectedKitchenInstallationCost = kitchenInstallationCost(5)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenFiveTwo Then
            selectedKitchenActualCost = counterTopsPricing(5, 2)
            selectedKitchenInstallationCost = kitchenInstallationCost(5)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenSixZero Then
            selectedKitchenActualCost = counterTopsPricing(6, 0)
            selectedKitchenInstallationCost = kitchenInstallationCost(6)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenSixOne Then
            selectedKitchenActualCost = counterTopsPricing(6, 1)
            selectedKitchenInstallationCost = kitchenInstallationCost(6)
        ElseIf CboKitchenStyle.SelectedItem.ToString = kitchenSixTwo Then
            selectedKitchenActualCost = counterTopsPricing(6, 2)
            selectedKitchenInstallationCost = kitchenInstallationCost(6)
        End If

        'Setting selected kitchen layout and countertop text to sselectedKitchenNameAndLayout variable that will be used in the second form's receipt to show selected kitchen and countertops 
        selectedKitchenNameAndLayout = CboKitchenStyle.SelectedItem.ToString()

        'Messagebox to display cost of the selected kitchen layout and countertop
        MessageBox.Show("Selected kitchen layout & countertop total cost is: £" + selectedKitchenActualCost.ToString)

        'Displaying the groupbox for the user to be able to select kitchen appliances, installation and purchase button 
        GroupBox1.Visible = True


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtLength_TextChanged(sender As Object, e As EventArgs) Handles txtLength.TextChanged

    End Sub

    Private Sub lblLength_Click(sender As Object, e As EventArgs) Handles lblLength.Click

    End Sub
End Class
