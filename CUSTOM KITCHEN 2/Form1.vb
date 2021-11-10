Public Class Form1
    Public Shared kitchenStyles() As String = {
            "Small L-shaped kitchen",
            "Medium L-shaped kitchen",
            "Large L-shaped kitchen",
            "Small straight kitchen",
            "Medium straight kitchen",
            "Large straight kitchen",
            "Large island kitchen"
    }

    Public Shared dimensions(,) As Integer = {
        {250, 180},
        {350, 240},
        {450, 350},
        {150, 60},
        {350, 60},
        {500, 60},
        {450, 450}
    }

    Public Shared counterTopNames() As String = {
        "Laminate",
        "Wood block",
        "Granite"
    }

    Public Shared counterTopsPricing(,) As Integer = {
        {3500, 4500, 5750},
        {6500, 7750, 9500},
        {8250, 9500, 12500},
        {1000, 1500, 2200},
        {5250, 6200, 8000},
        {6750, 8500, 11000},
        {12500, 15000, 23000}
    }

    Public Shared kitchenAppliancesNames() As String = {
        "Basic Fridge Freezer",
        "American Style Fridge Freezer",
        "Hob",
        "Single Oven",
        "Double Oven",
        "Dishwasher"
    }

    Public Shared kitchenAppliancesPrices() As Integer = {
        180,
        750,
        400,
        340,
        550,
        270
    }

    Public Shared kitchenInstallationCost() As Integer = {
        1250,
        2750,
        3750,
        750,
        1500,
        2500,
        4750
    }

    Public Shared shippingCost As Integer
    Public Shared shippingCostCharged As Boolean = False
    Public Shared maximumBudget As Integer
    Public Shared selectedKitchenInstallationCost As Integer
    Public Shared finalTotal As Integer
    Public Shared selectedKitchenActualCost As Integer
    Public Shared kitchenAppliancesTotal As Integer
    Public Shared selectedKitchenNameAndLayout As String




    Public Function Purchase()
        kitchenAppliancesTotal = 0


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


        If ChkInstallKitchen.Checked Then
            MessageBox.Show("Selected kitchen Installation Cost is: £" + selectedKitchenInstallationCost.ToString())
            shippingCostCharged = False
        Else
            selectedKitchenInstallationCost = 0
            MessageBox.Show("Your kitchen will not be installed by us. We will charge you a shipping cost of: £" + shippingCost.ToString)
            shippingCostCharged = True
        End If


        MessageBox.Show("Selected kitchen appliances cost is: £" + kitchenAppliancesTotal.ToString)


        Me.Hide()
        FrmCustomer_Detail.Visible = True

        Return 0

    End Function



    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged

    End Sub
    Private Sub lblWidth_Click(sender As Object, e As EventArgs) Handles lblWidth.Click

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDishwasher.CheckedChanged

    End Sub

    Private Sub btnEnterSpecification_Click(sender As Object, e As EventArgs) Handles btnEnterSpecification.Click
       
        Dim length As Integer = Convert.ToInt32(txtLength.Text)
        Dim width As Integer = Convert.ToInt32(txtWidth.Text)
        maximumBudget = Convert.ToInt32(txtMaximumBudget.Text)

        CboKitchenStyle.Items.Clear()
        CboKitchenStyle.Text = ""

        If length < dimensions(3, 0) Then
            MessageBox.Show("Kitchen length value can only be a minimum of 150!")
            txtLength.Text = "150"
            length = 150
            'length = Convert.ToInt32(txtLength.Text)
        ElseIf length > 600 Then
            MessageBox.Show("Kitchen length value can only be a maximum 0f 600!")
            txtLength.Text = "600"
            length = 600
            'length = Convert.ToInt32(txtLength.Text)
        End If

        If width < 120 Then
            MessageBox.Show("Kitchen width value can only be a minimum of 120!")
            txtWidth.Text = "120"
            width = 120
            'width = Convert.ToInt32(txtWidth.Text)
        ElseIf width > 600 Then
            MessageBox.Show("Kitchen width value can only be a maximum of 600!")
            txtWidth.Text = "600"
            width = 600
            'width = Convert.ToInt32(txtWidth.Text)
        End If

        If maximumBudget < counterTopsPricing(3, 0) Then
            MessageBox.Show("Total budget entered can only be a minimum of 1,000!")
            txtMaximumBudget.Text = "1000"
            maximumBudget = 1000
            'maximumBudget = Convert.ToInt32(txtMaximumBudget.Text)
        ElseIf maximumBudget > 25000 Then
            MessageBox.Show("Total budget entered can only be a maximum of 25,000!")
            txtMaximumBudget.Text = "25000"
            maximumBudget = 25000
            'maximumBudget = Convert.ToInt32(txtMaximumBudget.Text)
        End If
        MessageBox.Show("Inputs are valid!")






        'Kitchen layout as per Small Straight Kitchen Layout
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

        'Kitchen layout as per Small L-shaped Kitchen Layout
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

        'Kitchen layout as per Medium Straight Kitchen Layout
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

        'Kitchen layout as per Medium L-shaped Kitchen Layout
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

        'Kitchen layout as per Large L-shaped Kitchen Layout
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

        'Kitchen layout as per Large Straight Kitchen Layout
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

        'Kitchen layout as per Large Island Kitchen Layout
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


    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Purchase()
    End Sub

    Private Sub CboCountertop_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        shippingCost = 95
        selectedKitchenInstallationCost = 0
        finalTotal = 0
    End Sub

    Private Sub btnSelectKitchenAndAppliances_Click(sender As Object, e As EventArgs) Handles btnSelectKitchenAndAppliances.Click


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

        selectedKitchenNameAndLayout = CboKitchenStyle.SelectedItem.ToString()

        MessageBox.Show("Selected kitchen layout & countertop total cost is: £" + selectedKitchenActualCost.ToString)


        GroupBox1.Visible = True


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
