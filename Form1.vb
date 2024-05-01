Public Class Form1

    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim Operation As Integer
    Dim Operator_Selector As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nama As String
        nama = InputBox("Hai Banh Kmu Siafah ?")

        MessageBox.Show("Terima Kasih telah mencoba kalkulator gabut gwej " & nama)
    End Sub

    'NUMBER INPUTSS

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "1"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "1"
        Else
            txt_insrt.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "2"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "2"
        Else
            txt_insrt.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "3"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "3"
        Else
            txt_insrt.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "4"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "4"
        Else
            txt_insrt.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "5"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "5"
        Else
            txt_insrt.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "6"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "6"
        Else
            txt_insrt.Text = "6"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "7"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "7"
        Else
            txt_insrt.Text = "7"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "8"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "8"
        Else
            txt_insrt.Text = "8"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "9"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "9"
        Else
            txt_insrt.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txt_insrt.Text = "Error :C" Then
            txt_insrt.Text = "0"
        ElseIf txt_insrt.Text <> 0 Then
            txt_insrt.Text += "0"
        End If
    End Sub

    'END NUMBER

    'BUAT BUTTON RESET 

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txt_insrt.Text = "0"
    End Sub

    'BUAT NAMBAH KOMA

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        If Not (txt_insrt.Text.Contains(".")) Then
            txt_insrt.Text += "."
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Firstnum = txt_insrt.Text
        txt_insrt.Text = "0"
        Operator_Selector = True
        Operation = 1 ' Ini Tambah
    End Sub

    Private Sub btnKrng_Click(sender As Object, e As EventArgs) Handles btnKrng.Click
        Firstnum = txt_insrt.Text
        txt_insrt.Text = "0"
        Operator_Selector = True
        Operation = 2 ' Ini Kurang
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Firstnum = txt_insrt.Text
        txt_insrt.Text = "0"
        Operator_Selector = True
        Operation = 3 ' Ini Kali
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Firstnum = txt_insrt.Text
        txt_insrt.Text = "0"
        Operator_Selector = True
        Operation = 4 ' Ini Bagi
    End Sub

    Private Sub btnReslt_Click(sender As Object, e As EventArgs) Handles btnReslt.Click
        If Operator_Selector = True Then
            Secondnum = txt_insrt.Text
            If Operation = 1 Then
                txt_insrt.Text = Firstnum + Secondnum
            ElseIf Operation = 2 Then
                txt_insrt.Text = Firstnum - Secondnum
            ElseIf Operation = 3 Then
                txt_insrt.Text = Firstnum * Secondnum
            Else
                If Secondnum = 0 Then
                    txt_insrt.Text = "Error :C"
                Else
                    txt_insrt.Text = Firstnum / Secondnum
                End If
            End If
            Operator_Selector = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
