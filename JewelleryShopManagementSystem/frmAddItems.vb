Public Class frmAdditem


    Private Sub frmAddItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopdbDataSet3.item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.ShopdbDataSet3.item)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ItemBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Do want to save ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.ItemBindingSource.EndEdit()
            Me.ItemTableAdapter.Update(Me.ShopdbDataSet3)
            MessageBox.Show("Save Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If MessageBox.Show("Do want to update ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Validate()
            Me.ItemBindingSource.EndEdit()

            MessageBox.Show("Update Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ItemBindingSource.RemoveCurrent()
        If MessageBox.Show("Do want to delete ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Me.Validate()
            Me.ItemBindingSource.EndEdit()

            MessageBox.Show("Delete Successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.Click
        ItemBindingSource.Filter = "Ino='" & txtSearchItemName.Text & "'"
    End Sub


    Private Sub rptitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptitem.Click
        Form4.Show()
    End Sub
End Class