<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdraw
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
        Label4 = New Label()
        Label3 = New Label()
        btn_withdraw = New Button()
        txt_withdraw = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        lbl_balance = New Label()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(242, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 12
        Label4.Text = "PHP 100"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(138, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 11
        Label3.Text = "Minimum Amount: "
        ' 
        ' btn_withdraw
        ' 
        btn_withdraw.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_withdraw.Location = New Point(160, 270)
        btn_withdraw.Name = "btn_withdraw"
        btn_withdraw.Size = New Size(133, 43)
        btn_withdraw.TabIndex = 10
        btn_withdraw.Text = "Withdraw"
        btn_withdraw.UseVisualStyleBackColor = True
        ' 
        ' txt_withdraw
        ' 
        txt_withdraw.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_withdraw.Location = New Point(116, 205)
        txt_withdraw.Name = "txt_withdraw"
        txt_withdraw.Size = New Size(214, 35)
        txt_withdraw.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(13, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 30)
        Label2.TabIndex = 8
        Label2.Text = "Current Balance: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(13, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 65)
        Label1.TabIndex = 7
        Label1.Text = "Withdraw Money"
        ' 
        ' lbl_balance
        ' 
        lbl_balance.AutoSize = True
        lbl_balance.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_balance.Location = New Point(194, 105)
        lbl_balance.Name = "lbl_balance"
        lbl_balance.Size = New Size(0, 30)
        lbl_balance.TabIndex = 13
        ' 
        ' Withdraw
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 342)
        Controls.Add(lbl_balance)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btn_withdraw)
        Controls.Add(txt_withdraw)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Withdraw"
        Text = "Withdraw"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_withdraw As Button
    Friend WithEvents txt_withdraw As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_balance As Label
End Class
