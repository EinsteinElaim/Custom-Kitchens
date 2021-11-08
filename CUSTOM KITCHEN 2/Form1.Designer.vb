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
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 135)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kitchen Appliances "
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(209, 68)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "Dishwasher"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(209, 44)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Double Oven"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(209, 20)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Single Oven"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(7, 68)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Hob"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(166, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "American Style Fridge Freezer"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Basic Fridge Freezer"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(519, 426)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 47)
        Me.btnPurchase.TabIndex = 12
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(519, 242)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(138, 17)
        Me.CheckBox7.TabIndex = 13
        Me.CheckBox7.Text = "Installation Kitchen cost"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 485)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.btnPurchase)
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
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox

End Class
