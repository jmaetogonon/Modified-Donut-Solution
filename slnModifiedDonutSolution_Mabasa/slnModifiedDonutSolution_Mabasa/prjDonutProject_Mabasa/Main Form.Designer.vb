<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpDonuts = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChoco = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.grpDisplays = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.grpCoffee = New System.Windows.Forms.GroupBox()
        Me.radCappucino = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.grpDonuts.SuspendLayout()
        Me.grpDisplays.SuspendLayout()
        Me.grpCoffee.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDonuts
        '
        Me.grpDonuts.Controls.Add(Me.radFilled)
        Me.grpDonuts.Controls.Add(Me.radChoco)
        Me.grpDonuts.Controls.Add(Me.radSugar)
        Me.grpDonuts.Controls.Add(Me.radGlazed)
        Me.grpDonuts.Location = New System.Drawing.Point(186, 68)
        Me.grpDonuts.Name = "grpDonuts"
        Me.grpDonuts.Size = New System.Drawing.Size(187, 193)
        Me.grpDonuts.TabIndex = 0
        Me.grpDonuts.TabStop = False
        Me.grpDonuts.Text = "Donut choices"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(31, 142)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(79, 17)
        Me.radFilled.TabIndex = 4
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "Filled ($.95)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChoco
        '
        Me.radChoco.AutoSize = True
        Me.radChoco.Location = New System.Drawing.Point(31, 107)
        Me.radChoco.Name = "radChoco"
        Me.radChoco.Size = New System.Drawing.Size(103, 17)
        Me.radChoco.TabIndex = 3
        Me.radChoco.TabStop = True
        Me.radChoco.Text = "Chocolate ($.75)"
        Me.radChoco.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(31, 72)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(83, 17)
        Me.radSugar.TabIndex = 2
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "Sugar ($.75)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(31, 37)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(88, 17)
        Me.radGlazed.TabIndex = 1
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "Glazed ($.75)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'grpDisplays
        '
        Me.grpDisplays.Controls.Add(Me.lblTotal)
        Me.grpDisplays.Controls.Add(Me.lblTotalDue)
        Me.grpDisplays.Controls.Add(Me.lblTax)
        Me.grpDisplays.Controls.Add(Me.lblSalesTax)
        Me.grpDisplays.Controls.Add(Me.lblSub)
        Me.grpDisplays.Controls.Add(Me.lblSubtotal)
        Me.grpDisplays.Location = New System.Drawing.Point(395, 68)
        Me.grpDisplays.Name = "grpDisplays"
        Me.grpDisplays.Size = New System.Drawing.Size(177, 193)
        Me.grpDisplays.TabIndex = 5
        Me.grpDisplays.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(85, 124)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 23)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(30, 129)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(55, 13)
        Me.lblTotalDue.TabIndex = 10
        Me.lblTotalDue.Text = "Total due:"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(85, 81)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(57, 23)
        Me.lblTax.TabIndex = 9
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(30, 86)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(53, 13)
        Me.lblSalesTax.TabIndex = 8
        Me.lblSalesTax.Text = "Sales tax:"
        '
        'lblSub
        '
        Me.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSub.Location = New System.Drawing.Point(85, 38)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(57, 23)
        Me.lblSub.TabIndex = 7
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(30, 43)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'grpCoffee
        '
        Me.grpCoffee.Controls.Add(Me.radCappucino)
        Me.grpCoffee.Controls.Add(Me.radRegular)
        Me.grpCoffee.Controls.Add(Me.radNone)
        Me.grpCoffee.Location = New System.Drawing.Point(186, 276)
        Me.grpCoffee.Name = "grpCoffee"
        Me.grpCoffee.Size = New System.Drawing.Size(187, 156)
        Me.grpCoffee.TabIndex = 12
        Me.grpCoffee.TabStop = False
        Me.grpCoffee.Text = "Coffee choices"
        '
        'radCappucino
        '
        Me.radCappucino.AutoSize = True
        Me.radCappucino.Location = New System.Drawing.Point(31, 107)
        Me.radCappucino.Name = "radCappucino"
        Me.radCappucino.Size = New System.Drawing.Size(118, 17)
        Me.radCappucino.TabIndex = 15
        Me.radCappucino.TabStop = True
        Me.radCappucino.Text = "Cappuccino ($2.75)"
        Me.radCappucino.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(31, 72)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(98, 17)
        Me.radRegular.TabIndex = 14
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(31, 37)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 13
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(466, 298)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(106, 32)
        Me.btnCalc.TabIndex = 16
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(466, 340)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 32)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(167, 22)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(449, 28)
        Me.lblHeading.TabIndex = 18
        Me.lblHeading.Text = "Our dougnuts and coffee are the best in town!"
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.prjDonutProject_Mabasa.My.Resources.Resources._11_111107_open_coffee_donuts_clipart_png_download
        Me.PictureBox.Location = New System.Drawing.Point(21, 22)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(120, 124)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 7
        Me.PictureBox.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 453)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpCoffee)
        Me.Controls.Add(Me.grpDisplays)
        Me.Controls.Add(Me.grpDonuts)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                Donut Shoppe"
        Me.grpDonuts.ResumeLayout(False)
        Me.grpDonuts.PerformLayout()
        Me.grpDisplays.ResumeLayout(False)
        Me.grpDisplays.PerformLayout()
        Me.grpCoffee.ResumeLayout(False)
        Me.grpCoffee.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpDonuts As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radChoco As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents grpDisplays As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents grpCoffee As GroupBox
    Friend WithEvents radCappucino As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents lblHeading As Label
End Class
