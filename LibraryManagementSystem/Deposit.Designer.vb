<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        lbl_balance = New Label()
        txt_deposit = New TextBox()
        btn_deposit = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(45, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(371, 65)
        Label1.TabIndex = 0
        Label1.Text = "Deposit Money"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 30)
        Label2.TabIndex = 1
        Label2.Text = "Current Balance: "
        ' 
        ' lbl_balance
        ' 
        lbl_balance.AutoSize = True
        lbl_balance.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_balance.Location = New Point(187, 105)
        lbl_balance.Name = "lbl_balance"
        lbl_balance.Size = New Size(0, 30)
        lbl_balance.TabIndex = 2
        ' 
        ' txt_deposit
        ' 
        txt_deposit.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_deposit.Location = New Point(115, 205)
        txt_deposit.Name = "txt_deposit"
        txt_deposit.Size = New Size(214, 35)
        txt_deposit.TabIndex = 3
        ' 
        ' btn_deposit
        ' 
        btn_deposit.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_deposit.Location = New Point(159, 270)
        btn_deposit.Name = "btn_deposit"
        btn_deposit.Size = New Size(133, 43)
        btn_deposit.TabIndex = 4
        btn_deposit.Text = "Deposit"
        btn_deposit.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(137, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 5
        Label3.Text = "Minimum Amount: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(241, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 6
        Label4.Text = "PHP 100"
        ' 
        ' Deposit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 353)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btn_deposit)
        Controls.Add(txt_deposit)
        Controls.Add(lbl_balance)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Deposit"
        Text = "Deposit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_balance As Label
    Friend WithEvents txt_deposit As TextBox
    Friend WithEvents btn_deposit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
