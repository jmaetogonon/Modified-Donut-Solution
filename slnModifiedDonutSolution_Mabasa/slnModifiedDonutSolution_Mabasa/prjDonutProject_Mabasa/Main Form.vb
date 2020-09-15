Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    'calculate donut funciton
    Private Sub getDoughnut(ByRef decDonutPrice As Decimal)
        If radGlazed.Checked Then
            decDonutPrice = 0.75D
        ElseIf radSugar.Checked Then
            decDonutPrice = 0.75D
        ElseIf radChoco.Checked Then
            decDonutPrice = 0.75D
        ElseIf radFilled.Checked Then
            decDonutPrice = 0.95D
        End If
    End Sub

    'calculate coffee funciton
    Private Sub getCoffee(ByRef decCoffeePrice As Decimal)

        If radNone.Checked Then
            decCoffeePrice = 0D
        ElseIf radRegular.Checked Then
            decCoffeePrice = 1.5D
        ElseIf radCappucino.Checked Then
            decCoffeePrice = 2.75D
        End If

    End Sub

    'calculate tax funciton
    Private Sub getTax(ByVal decSubTotal As Decimal, ByVal decTaxRate As Decimal, ByRef decTax As Decimal)
        decTax = decSubTotal * decTaxRate
    End Sub

    'form load
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radNone.Checked = True
        radGlazed.Checked = True
    End Sub

    'btnCALC
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Const decSALES_TAX As Decimal = 0.045D
        Dim decDonut As Decimal
        Dim decCoffee As Decimal
        Dim decSubTotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal

        'call coffee sub
        Call getDoughnut(decDonut)

        'call coffee sub
        Call getCoffee(decCoffee)

        'calculate SUBTOTAL
        decSubTotal = decDonut + decCoffee

        'call sales funciton
        Call getTax(decSubTotal, decSALES_TAX, decTax)

        'calculate TOTAL
        decTotal = decSubTotal + decTax

        'displays
        lblSub.Text = decSubTotal.ToString("N2")
        lblTax.Text = decTax.ToString("N2")
        lblTotal.Text = decTotal.ToString("N2")
    End Sub

    'exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'iclear ang displays
    Private Sub radGlazed_CheckedChanged(sender As Object, e As EventArgs) Handles radGlazed.CheckedChanged, radCappucino.CheckedChanged, radChoco.CheckedChanged, radFilled.CheckedChanged, radNone.CheckedChanged, radRegular.CheckedChanged, radSugar.CheckedChanged
        lblSub.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
