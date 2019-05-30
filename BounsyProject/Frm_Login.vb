Public Class Frm_Login
    Dim Database As New DatabaseManage
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPass.isPassword = False
        Else
            txtPass.isPassword = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("ທ່ານຕ້ອງການທີ່ຈະຍົກເລີກຫຼື ບໍ່ ?", "ຄຳເຕືອນ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("ກາລຸນາປ້ອນຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຜ່ານ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            sql = "select*from tb_user where username='" & txtUser.Text & "'and pass='" & txtPass.Text & "'"
            da = New SqlClient.SqlDataAdapter(sql, cn)
            ds.Clear()
            da.Fill(ds, "table")
            If ds.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("ຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ")
            Else
                Me.Close()

            End If
        End If
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.connect()


    End Sub

    Private Sub TxtPass_MouseEnter(sender As Object, e As EventArgs) Handles txtPass.MouseEnter
        txtPass.isPassword = True
    End Sub
End Class