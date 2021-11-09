Public Class FrmCustomer_Detail

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmCustomer_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("RECEIPT.txt", True)

        file.WriteLine("This is a test edit example!")
        file.Close()
    End Sub
End Class