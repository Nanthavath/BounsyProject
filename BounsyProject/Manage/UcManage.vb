Public Class UcManage
    Private Sub ຂມນພະນກງານToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນພະນກງານToolStripMenuItem.Click


        FrmEmployee.ShowDialog()


    End Sub

    Private Sub ຂມນລກຄາToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນລກຄາToolStripMenuItem.Click
        FrmTenant.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ຂມນຫອງToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນຫອງToolStripMenuItem.Click
        FrmRoom.ShowDialog()
    End Sub

    Private Sub ຂມນອດຕາແລກປຽນToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນອດຕາແລກປຽນToolStripMenuItem.Click
        FrmExchange.ShowDialog()
    End Sub

    Private Sub ຂມນແຂວງToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນແຂວງToolStripMenuItem.Click
        FrmProvince.ShowDialog()
    End Sub

    Private Sub ຂມນເມອງToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ຂມນເມອງToolStripMenuItem.Click
        FrmDistric.ShowDialog()
    End Sub
End Class
