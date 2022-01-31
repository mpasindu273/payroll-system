Public Class Form1

    Private Sub bcal_Click(sender As Object, e As EventArgs) Handles bcal.Click
        Dim basic_salary As Integer
        Dim cost_of_living As Integer
        Dim research As Integer
        Dim total_allowance As Integer
        Dim gross_salary As Integer
        Dim deduction As Integer
        Dim net_pay As Integer

        basic_salary = Val(tsalary.Text)
        cost_of_living = 7500
        research = basic_salary * 0.35
        total_allowance = 0
        deduction = 0

        If chkcost.Checked Then
            total_allowance = total_allowance + cost_of_living
        End If

        If chkresearch.Checked Then
            total_allowance = total_allowance + research
        End If

        gross_salary = basic_salary + total_allowance

        If rbepf.Checked Then
            deduction = gross_salary * 0.12
        ElseIf rbupf.Checked Then
            deduction = gross_salary * 0.2
        End If

        net_pay = gross_salary - deduction

        ttotal.Text = total_allowance
        tdeduction.Text = deduction
        tnet.Text = net_pay
    End Sub

    Private Sub bclear_Click(sender As Object, e As EventArgs) Handles bclear.Click
        tsalary.Clear()
        chkcost.Checked = False
        chkresearch.Checked = False
        rbepf.Checked = True
        ttotal.Clear()
        tdeduction.Clear()
        tnet.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbepf.Checked = True
    End Sub
End Class
