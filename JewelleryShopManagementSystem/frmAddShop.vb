Public Class frmAddShop

    Private Sub frmAddShop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopdbDataSet6.shop' table. You can move, or remove it, as needed.
        Me.ShopTableAdapter.Fill(Me.ShopdbDataSet6.shop)

    End Sub

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        ShopBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Do want to save ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.ShopBindingSource.EndEdit()
            Me.ShopTableAdapter.Update(Me.ShopdbDataSet6)
            MessageBox.Show("Save Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("Do want to update ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.ShopBindingSource.EndEdit()

            MessageBox.Show("Update Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ShopBindingSource.RemoveCurrent()
        If MessageBox.Show("Do want to delete ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Me.Validate()
            Me.ShopBindingSource.EndEdit()

            MessageBox.Show("Delete Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        ShopBindingSource.Filter = "Sid='" & txtsearch.Text & "'"
    End Sub

    Private Sub rptshop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptshop.Click
        Form8.Show()
    End Sub
End Class