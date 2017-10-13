Public Class Form1
    Dim arreglo(23) As Integer
    Dim contador As Integer = 0
    Dim ima(23) As String
    Dim pic(23) As PictureBox
    Dim buenas As Integer = 0
    Dim jugador1 As Integer
    Dim jugador2 As Integer
    Dim ba As Boolean = True
    Dim contpulsaciones As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False   
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox24.Click, PictureBox23.Click, PictureBox22.Click, PictureBox21.Click, PictureBox20.Click, PictureBox2.Click, PictureBox19.Click, PictureBox18.Click, PictureBox17.Click, PictureBox16.Click, PictureBox15.Click, PictureBox14.Click, PictureBox13.Click, PictureBox12.Click, PictureBox11.Click, PictureBox10.Click, PictureBox1.Click
        Dim band As Boolean = True
        Dim picsender As PictureBox = CType(sender, PictureBox)
        pic(contador) = picsender

        Dim aux As Integer = 0
        aux = Integer.Parse(picsender.Tag)
        Dim imagen As String = arreglo(aux).ToString() + ".jpg"
        ima(contador) = imagen
        picsender.Image = System.Drawing.Image.FromFile(imagen)
        Dim div As Integer
        div = (contador + 1) Mod 2
        If div = 0 Then
            If ima(contador) = ima(contador - 1) Then
                If ba = True Then
                    jugador1 += 1
                    Label5.Text = jugador1.ToString()
                Else
                    jugador2 += 1
                    Label6.Text = jugador2.ToString()
                End If

            Else
                If ba = True Then
                    ba = False
                Else
                    ba = True
                End If
                pic(contador).Image = Nothing
                pic(contador - 1).Image = Nothing
                'For j As Integer = 0 To contador
                '    pic(j).Image = Nothing
                'Next
                contador -= 1
                buenas = 0
                band = False
            End If

        End If
        If band = True Then
            contador += 1
            buenas += 1
        End If
        If contador = 24 Then
            MessageBox.Show("**Felicidades Usted ha ganado el juego**")
            contador = 0
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        contpulsaciones += 1
        If contpulsaciones > 1 Then
            For o As Integer = 0 To 24
                pic(o).Image = Nothing
            Next
        End If
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        
        GroupBox1.Enabled = True
        Dim random As New Random(DateTime.Now.Millisecond)
        Dim val As Integer, band As Integer
        Dim j As Integer
        Dim conta As Integer = 0
        val = random.Next(1, 13)
        arreglo(conta) = val
        conta += 1
        While conta < 12
            Do
                val = random.Next(1, 13)
                For j = 0 To 11
                    If val = arreglo(j) Then
                        j = 12
                    End If
                Next
                If j = 12 Then
                    band = 0
                Else
                    band = 1
                End If
            Loop While band = 1
            arreglo(conta) = val
            conta += 1
        End While
        val = random.Next(1, 13)
        arreglo(conta) = val

        conta += 1
        While conta < 24
            Do
                val = random.Next(1, 13)
                For j = 12 To 23
                    If val = arreglo(j) Then
                        j = 24
                    End If
                Next
                If j = 24 Then
                    band = 0
                Else
                    band = 1
                End If
            Loop While band = 1
            arreglo(conta) = val

            conta += 1
        End While
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub


    Private Sub PictureBox13_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox9.MouseMove, PictureBox8.MouseMove, PictureBox7.MouseMove, PictureBox6.MouseMove, PictureBox5.MouseMove, PictureBox4.MouseMove, PictureBox3.MouseMove, PictureBox24.MouseMove, PictureBox23.MouseMove, PictureBox22.MouseMove, PictureBox21.MouseMove, PictureBox20.MouseMove, PictureBox2.MouseMove, PictureBox19.MouseMove, PictureBox18.MouseMove, PictureBox17.MouseMove, PictureBox16.MouseMove, PictureBox15.MouseMove, PictureBox14.MouseMove, PictureBox13.MouseMove, PictureBox12.MouseMove, PictureBox11.MouseMove, PictureBox10.MouseMove, PictureBox1.MouseMove
        Dim picsender As PictureBox = CType(sender, PictureBox)
        picsender.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox13_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave, PictureBox8.MouseLeave, PictureBox7.MouseLeave, PictureBox6.MouseLeave, PictureBox5.MouseLeave, PictureBox4.MouseLeave, PictureBox3.MouseLeave, PictureBox24.MouseLeave, PictureBox23.MouseLeave, PictureBox22.MouseLeave, PictureBox21.MouseLeave, PictureBox20.MouseLeave, PictureBox2.MouseLeave, PictureBox19.MouseLeave, PictureBox18.MouseLeave, PictureBox17.MouseLeave, PictureBox16.MouseLeave, PictureBox15.MouseLeave, PictureBox14.MouseLeave, PictureBox13.MouseLeave, PictureBox12.MouseLeave, PictureBox11.MouseLeave, PictureBox10.MouseLeave, PictureBox1.MouseLeave
        Dim picsender As PictureBox = CType(sender, PictureBox)
        picsender.BorderStyle = BorderStyle.FixedSingle
    End Sub
End Class
