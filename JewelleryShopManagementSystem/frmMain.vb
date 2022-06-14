Public Class frmMain

    Private Sub ToolStripMenuItemAddCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemAddCustomer.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Customer" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim frmAddCstmr As New frmAddCustomer
            frmAddCstmr.MdiParent = Me
            frmAddCstmr.Show()
        End If
    End Sub


    Private Sub ToolStripMenuItemAddEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemAddEmployee.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Employee" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim frmAddEmpl As New frmAddEmployee
            frmAddEmpl.MdiParent = Me
            frmAddEmpl.Show()
        End If
    End Sub

  

    Private Sub AddShopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddShopToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Shop" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim frmAddSP As New frmAddShop
            frmAddSP.MdiParent = Me
            frmAddSP.Show()
        End If
    End Sub

 
    
    Private Sub AddItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemsToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Items" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim frmItm As New frmAdditem
            frmItm.MdiParent = Me
            frmItm.Show()
        End If
    End Sub

   
    Private Sub AddSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSupplierToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Supplier" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim AddSupplier As New frmAddSupplier
            AddSupplier.MdiParent = Me
            AddSupplier.Show()
        End If
    End Sub

    Private Sub AddPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPaymentToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Payment" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim AddPayment As New frmAddPayment
            AddPayment.MdiParent = Me
            AddPayment.Show()
        End If
    End Sub

    Private Sub AddPurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPurchaseToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Purchase" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim AddPurchase As New frmAddPurchase
            AddPurchase.MdiParent = Me
            AddPurchase.Show()
        End If
    End Sub

    Private Sub AddBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBillToolStripMenuItem.Click
        Dim isOpen As Boolean = False

        For Each frm As Form In Application.OpenForms
            If frm.Text = "Add Bill" Then
                isOpen = True
                frm.BringToFront()
            End If
        Next

        If isOpen = False Then
            Dim AddBill As New frmAddBill
            AddBill.MdiParent = Me
            AddBill.Show()
        End If
    End Sub

    Private Sub ExitMastersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMastersToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExitTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTransactionToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MenuStripHeader_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStripHeader.ItemClicked

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("TaskMgr.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub WordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Winword.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    
    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub ItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub PurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub BillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub ShopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShopToolStripMenuItem.Click
        Form8.Show()
    End Sub
End Class
