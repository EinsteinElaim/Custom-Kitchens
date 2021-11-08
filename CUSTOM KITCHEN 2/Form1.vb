﻿Public Class Form1
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

    Public Shared shippingCost As Integer = 95

    Dim maximumBudget As Integer

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged

    End Sub
    Private Sub lblWidth_Click(sender As Object, e As EventArgs) Handles lblWidth.Click

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub btnEnterSpecification_Click(sender As Object, e As EventArgs) Handles btnEnterSpecification.Click
        'Dim length As Double = Convert.ToDouble(txtLength.Text)
        'Dim width As Double = Convert.ToDouble(txtWidth.Text)
        'Dim maximumBudget As Double = Convert.ToDouble(txtMaximumBudget.Text)
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
        MessageBox.Show("Valid")
        MessageBox.Show(length)
        MessageBox.Show(width)
        MessageBox.Show(maximumBudget)





        'Kitchen layout as per Small Straight Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(3, 0) And Convert.ToInt64(width) >= dimensions(3, 1) Then
            CboKitchenStyle.Items.Add(kitchenStyles(3))
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(3, 0) Then
                CboKitchenStyle.Items.Add(kitchenStyles(3) + " with " + counterTopNames(0) + " countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(3, 1) Then
                CboKitchenStyle.Items.Add("Small straight kitchen with Wood Block countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(3, 2) Then
                CboKitchenStyle.Items.Add("Small straight kitchen with Granite countertops")
            End If
        End If

        'Kitchen layout as per Small L-shaped Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(0, 0) And Convert.ToInt64(width) >= dimensions(0, 1) Then
            CboKitchenStyle.Items.Add(kitchenStyles(0))
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(0, 0) Then
                CboKitchenStyle.Items.Add("Small L-shaped kitchen with Laminate countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(0, 1) Then
                CboKitchenStyle.Items.Add("Small L-shaped kitchen with Wood Block countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(0, 2) Then
                CboKitchenStyle.Items.Add("Small L-shaped kitchen with Granite countertops")
            End If
        End If

        'Kitchen layout as per Medium Straight Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(4, 0) And Convert.ToInt64(width) >= dimensions(4, 1) Then
            CboKitchenStyle.Items.Add(kitchenStyles(4))
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(4, 0) Then
                CboKitchenStyle.Items.Add("Medium Straight kitchen with Laminate countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(4, 1) Then
                CboKitchenStyle.Items.Add("Medium Straight kitchen with Wood Block countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(4, 2) Then
                CboKitchenStyle.Items.Add("Medium Straight kitchen with Granite countertops")
            End If
        End If

        'Kitchen layout as per Medium L-shaped Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(1, 0) And Convert.ToInt64(width) >= dimensions(1, 1) Then
            CboKitchenStyle.Items.Add(kitchenStyles(1))
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(1, 0) Then
                CboKitchenStyle.Items.Add("Medium L-shaped kitchen with Laminate countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(1, 1) Then
                CboKitchenStyle.Items.Add("Medium L-shaped kitchen with Wood Block countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(1, 2) Then
                CboKitchenStyle.Items.Add("Medium L-shaped kitchen with Granite countertops")
            End If
        End If

        'Kitchen layout as per Large L-shaped Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(2, 0) And Convert.ToInt64(width) >= dimensions(2, 1) Then
            CboKitchenStyle.Items.Add(kitchenStyles(2))
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(2, 0) Then
                CboKitchenStyle.Items.Add("Large L-shaped kitchen with Laminate countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(2, 1) Then
                CboKitchenStyle.Items.Add("Large L-shaped kitchen with Wood Block countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(2, 2) Then
                CboKitchenStyle.Items.Add("Large L-shaped kitchen with Granite countertops")
            End If
        End If

        'Kitchen layout as per Large Straight Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(5, 0) And Convert.ToInt64(width) >= dimensions(5, 1) Then
            CboKitchenStyle.Items.Add(kitchenStyles(5))
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(5, 0) Then
                CboKitchenStyle.Items.Add("Large Straight kitchen with Laminate countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(5, 1) Then
                CboKitchenStyle.Items.Add("Large Straight kitchen with Wood Block countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(5, 2) Then
                CboKitchenStyle.Items.Add("Large Straight kitchen with Granite countertops")
            End If
        End If

        'Kitchen layout as per Large Island Kitchen Layout
        If Convert.ToInt64(length) >= dimensions(6, 0) And Convert.ToInt64(width) >= dimensions(6, 1) Then
            CboKitchenStyle.Items.Add(kitchenStyles(6))
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(6, 0) Then
                CboKitchenStyle.Items.Add("Large Island kitchen with Laminate countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(6, 1) Then
                CboKitchenStyle.Items.Add("Large Island kitchen with Wood Block countertops")
            End If
            If Convert.ToInt64(maximumBudget) >= counterTopsPricing(6, 2) Then
                CboKitchenStyle.Items.Add("Large Island kitchen with Granite countertops")
            End If
        End If

        MessageBox.Show("DONE")

        'Else
        'MessageBox.Show("Out!")







    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Me.Hide()
        FrmCustomer_Detail.Visible = True

    End Sub

    Private Sub CboCountertop_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class