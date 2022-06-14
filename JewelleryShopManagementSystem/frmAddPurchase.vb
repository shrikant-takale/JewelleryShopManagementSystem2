Public Class frmAddPurchase

    Private Sub frmAddPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopdbDataSet5.porder' table. You can move, or remove it, as needed.
        Me.PorderTableAdapter.Fill(Me.ShopdbDataSet5.porder)

    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        PorderBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Do want to save ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.PorderBindingSource.EndEdit()
            Me.PorderTableAdapter.Update(Me.ShopdbDataSet5)
            MessageBox.Show("Save Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("Do want to update ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.PorderBindingSource.EndEdit()

            MessageBox.Show("Update Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        PorderBindingSource.RemoveCurrent()
        If MessageBox.Show("Do want to delete ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Me.Validate()
            Me.PorderBindingSource.EndEdit()

            MessageBox.Show("Delete Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        PorderBindingSource.Filter = "Pno='" & txtsearch.Text & "'"
    End Sub

    Private Sub rptpurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptpurchase.Click
        Form6.Show()
    End Sub
End Class