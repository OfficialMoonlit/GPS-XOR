Public Class frmMain

    Dim XORString As String
    Dim XORSum As String
    Dim XORChar As String

    Private Sub txtXOR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtXOR.TextChanged

        XORString = ""
        XORSum = "00"
        XORChar = ""

        XORString = txtXOR.Text

        For i = 0 To Len(XORString) - 1
            XORSum = XORSum Xor Asc(Mid$(XORString, i + 1, 1))
        Next
        txtSum.Text = Hex$(XORSum)

    End Sub

End Class
