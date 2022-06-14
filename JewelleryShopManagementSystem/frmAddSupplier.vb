Public Class frmAddSupplier

    Private Sub frmAddSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopdbDataSet7.supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.ShopdbDataSet7.supplier)

    End Sub


    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        SupplierBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Do want to save ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.SupplierBindingSource.EndEdit()
            Me.SupplierTableAdapter.Update(Me.ShopdbDataSet7)
            MessageBox.Show("Save Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("Do want to update ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.SupplierBindingSource.EndEdit()

            MessageBox.Show("Update Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        SupplierBindingSource.RemoveCurrent()
        If MessageBox.Show("Do want to delete ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Me.Validate()
            Me.SupplierBindingSource.EndEdit()

            MessageBox.Show("Delete Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        SupplierBindingSource.Filter = "Sno='" & txtsearch.Text & "'"
    End Sub

    Private Sub rptsupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptsupplier.Click
        Form7.Show()
    End Sub
End Class