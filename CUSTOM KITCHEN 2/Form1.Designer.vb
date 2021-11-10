<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblMaximumBudget = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtMaximumBudget = New System.Windows.Forms.TextBox()
        Me.btnEnterSpecification = New System.Windows.Forms.Button()
        Me.lblKitchenStyle = New System.Windows.Forms.Label()
        Me.CboKitchenStyle = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkDishwasher = New System.Windows.Forms.CheckBox()
        Me.ChkDoubleOven = New System.Windows.Forms.CheckBox()
        Me.ChkSingleOven = New System.Windows.Forms.CheckBox()
        Me.ChkHob = New System.Windows.Forms.CheckBox()
        Me.ChkAmericanStyleFridgeFreezer = New System.Windows.Forms.CheckBox()
        Me.ChkBasicFridgeFreezer = New System.Windows.Forms.CheckBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.ChkInstallKitchen = New System.Windows.Forms.CheckBox()
        Me.btnSelectKitchenAndAppliances = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(25, 30)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(40, 13)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(25, 56)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 1
        Me.lblWidth.Text = "Width"
        '
        'lblMaximumBudget
        '
        Me.lblMaximumBudget.AutoSize = True
        Me.lblMaximumBudget.Location = New System.Drawing.Point(24, 82)
        Me.lblMaximumBudget.Name = "lblMaximumBudget"
        Me.lblMaximumBudget.Size = New System.Drawing.Size(88, 13)
        Me.lblMaximumBudget.TabIndex = 2
        Me.lblMaximumBudget.Text = "Maximum Budget"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(198, 30)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 3
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(198, 56)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 4
        '
        'txtMaximumBudget
        '
        Me.txtMaximumBudget.Location = New System.Drawing.Point(198, 82)
        Me.txtMaximumBudget.Name = "txtMaximumBudget"
        Me.txtMaximumBudget.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximumBudget.TabIndex = 5
        '
        'btnEnterSpecification
        '
        Me.btnEnterSpecification.Location = New System.Drawing.Point(12, 132)
        Me.btnEnterSpecification.Name = "btnEnterSpecification"
        Me.btnEnterSpecification.Size = New System.Drawing.Size(84, 51)
        Me.btnEnterSpecification.TabIndex = 6
        Me.btnEnterSpecification.Text = "Enter Specification"
        Me.btnEnterSpecification.UseVisualStyleBackColor = True
        '
        'lblKitchenStyle
        '
        Me.lblKitchenStyle.AutoSize = True
        Me.lblKitchenStyle.Location = New System.Drawing.Point(24, 208)
        Me.lblKitchenStyle.Name = "lblKitchenStyle"
        Me.lblKitchenStyle.Size = New System.Drawing.Size(157, 13)
        Me.lblKitchenStyle.TabIndex = 7
        Me.lblKitchenStyle.Text = "Kitchen Style And Countertops :"
        '
        'CboKitchenStyle
        '
        Me.CboKitchenStyle.FormattingEnabled = True
        Me.CboKitchenStyle.Location = New System.Drawing.Point(198, 205)
        Me.CboKitchenStyle.Name = "CboKitchenStyle"
        Me.CboKitchenStyle.Size = New System.Drawing.Size(266, 21)
        Me.CboKitchenStyle.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkDishwasher)
        Me.GroupBox1.Controls.Add(Me.btnPurchase)
        Me.GroupBox1.Controls.Add(Me.ChkInstallKitchen)
        Me.GroupBox1.Controls.Add(Me.ChkDoubleOven)
        Me.GroupBox1.Controls.Add(Me.ChkSingleOven)
        Me.GroupBox1.Controls.Add(Me.ChkHob)
        Me.GroupBox1.Controls.Add(Me.ChkAmericanStyleFridgeFreezer)
        Me.GroupBox1.Controls.Add(Me.ChkBasicFridgeFreezer)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 153)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kitchen Appliances "
        '
        'ChkDishwasher
        '
        Me.ChkDishwasher.AutoSize = True
        Me.ChkDishwasher.Location = New System.Drawing.Point(219, 80)
        Me.ChkDishwasher.Name = "ChkDishwasher"
        Me.ChkDishwasher.Size = New System.Drawing.Size(81, 17)
        Me.ChkDishwasher.TabIndex = 5
        Me.ChkDishwasher.Text = "Dishwasher"
        Me.ChkDishwasher.UseVisualStyleBackColor = True
        '
        'ChkDoubleOven
        '
        Me.ChkDoubleOven.AutoSize = True
        Me.ChkDoubleOven.Location = New System.Drawing.Point(219, 56)
        Me.ChkDoubleOven.Name = "ChkDoubleOven"
        Me.ChkDoubleOven.Size = New System.Drawing.Size(89, 17)
        Me.ChkDoubleOven.TabIndex = 4
        Me.ChkDoubleOven.Text = "Double Oven"
        Me.ChkDoubleOven.UseVisualStyleBackColor = True
        '
        'ChkSingleOven
        '
        Me.ChkSingleOven.AutoSize = True
        Me.ChkSingleOven.Location = New System.Drawing.Point(219, 32)
        Me.ChkSingleOven.Name = "ChkSingleOven"
        Me.ChkSingleOven.Size = New System.Drawing.Size(84, 17)
        Me.ChkSingleOven.TabIndex = 3
        Me.ChkSingleOven.Text = "Single Oven"
        Me.ChkSingleOven.UseVisualStyleBackColor = True
        '
        'ChkHob
        '
        Me.ChkHob.AutoSize = True
        Me.ChkHob.Location = New System.Drawing.Point(17, 80)
        Me.ChkHob.Name = "ChkHob"
        Me.ChkHob.Size = New System.Drawing.Size(46, 17)
        Me.ChkHob.TabIndex = 2
        Me.ChkHob.Text = "Hob"
        Me.ChkHob.UseVisualStyleBackColor = True
        '
        'ChkAmericanStyleFridgeFreezer
        '
        Me.ChkAmericanStyleFridgeFreezer.AutoSize = True
        Me.ChkAmericanStyleFridgeFreezer.Location = New System.Drawing.Point(17, 56)
        Me.ChkAmericanStyleFridgeFreezer.Name = "ChkAmericanStyleFridgeFreezer"
        Me.ChkAmericanStyleFridgeFreezer.Size = New System.Drawing.Size(166, 17)
        Me.ChkAmericanStyleFridgeFreezer.TabIndex = 1
        Me.ChkAmericanStyleFridgeFreezer.Text = "American Style Fridge Freezer"
        Me.ChkAmericanStyleFridgeFreezer.UseVisualStyleBackColor = True
        '
        'ChkBasicFridgeFreezer
        '
        Me.ChkBasicFridgeFreezer.AutoSize = True
        Me.ChkBasicFridgeFreezer.Location = New System.Drawing.Point(17, 32)
        Me.ChkBasicFridgeFreezer.Name = "ChkBasicFridgeFreezer"
        Me.ChkBasicFridgeFreezer.Size = New System.Drawing.Size(122, 17)
        Me.ChkBasicFridgeFreezer.TabIndex = 0
        Me.ChkBasicFridgeFreezer.Text = "Basic Fridge Freezer"
        Me.ChkBasicFridgeFreezer.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(474, 80)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 47)
        Me.btnPurchase.TabIndex = 12
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'ChkInstallKitchen
        '
        Me.ChkInstallKitchen.AutoSize = True
        Me.ChkInstallKitchen.Location = New System.Drawing.Point(474, 32)
        Me.ChkInstallKitchen.Name = "ChkInstallKitchen"
        Me.ChkInstallKitchen.Size = New System.Drawing.Size(137, 17)
        Me.ChkInstallKitchen.TabIndex = 13
        Me.ChkInstallKitchen.Text = "Install Selected Kitchen"
        Me.ChkInstallKitchen.UseVisualStyleBackColor = True
        '
        'btnSelectKitchenAndAppliances
        '
        Me.btnSelectKitchenAndAppliances.Location = New System.Drawing.Point(502, 203)
        Me.btnSelectKitchenAndAppliances.Name = "btnSelectKitchenAndAppliances"
        Me.btnSelectKitchenAndAppliances.Size = New System.Drawing.Size(166, 23)
        Me.btnSelectKitchenAndAppliances.TabIndex = 14
        Me.btnSelectKitchenAndAppliances.Text = "Select Kitchen"
        Me.btnSelectKitchenAndAppliances.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 485)
        Me.Controls.Add(Me.btnSelectKitchenAndAppliances)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CboKitchenStyle)
        Me.Controls.Add(Me.lblKitchenStyle)
        Me.Controls.Add(Me.btnEnterSpecification)
        Me.Controls.Add(Me.txtMaximumBudget)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblMaximumBudget)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblMaximumBudget As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtMaximumBudget As System.Windows.Forms.TextBox
    Friend WithEvents btnEnterSpecification As System.Windows.Forms.Button
    Friend WithEvents lblKitchenStyle As System.Windows.Forms.Label
    Friend WithEvents CboKitchenStyle As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkDishwasher As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDoubleOven As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSingleOven As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHob As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAmericanStyleFridgeFreezer As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBasicFridgeFreezer As System.Windows.Forms.CheckBox
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents ChkInstallKitchen As System.Windows.Forms.CheckBox
    Friend WithEvents btnSelectKitchenAndAppliances As System.Windows.Forms.Button

End Class
