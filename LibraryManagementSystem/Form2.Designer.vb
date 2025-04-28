<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        cmb_acctype = New ComboBox()
        Button2 = New Button()
        btnRegister = New Button()
        Label7 = New Label()
        txt_address = New TextBox()
        Label6 = New Label()
        txt_accnumber = New TextBox()
        gp_sex = New GroupBox()
        rbOther = New RadioButton()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
        Label5 = New Label()
        Label4 = New Label()
        txt_phone = New TextBox()
        txt_email = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txt_firstname = New TextBox()
        txt_middlename = New TextBox()
        txt_lastname = New TextBox()
        GroupBox1.SuspendLayout()
        gp_sex.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(cmb_acctype)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(btnRegister)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txt_address)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txt_accnumber)
        GroupBox1.Controls.Add(gp_sex)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txt_phone)
        GroupBox1.Controls.Add(txt_email)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txt_firstname)
        GroupBox1.Controls.Add(txt_middlename)
        GroupBox1.Controls.Add(txt_lastname)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(657, 258)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Details"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(346, 199)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 15)
        Label8.TabIndex = 20
        Label8.Text = "Account Type"
        ' 
        ' cmb_acctype
        ' 
        cmb_acctype.FormattingEnabled = True
        cmb_acctype.Items.AddRange(New Object() {"Credit", "Debit"})
        cmb_acctype.Location = New Point(346, 216)
        cmb_acctype.Name = "cmb_acctype"
        cmb_acctype.Size = New Size(121, 23)
        cmb_acctype.TabIndex = 19
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(502, 206)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 40)
        Button2.TabIndex = 18
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnRegister.Location = New Point(502, 160)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(134, 40)
        btnRegister.TabIndex = 17
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 142)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 15)
        Label7.TabIndex = 16
        Label7.Text = "Address"
        ' 
        ' txt_address
        ' 
        txt_address.Location = New Point(6, 160)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(399, 23)
        txt_address.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 199)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 15)
        Label6.TabIndex = 14
        Label6.Text = "Account Number"
        ' 
        ' txt_accnumber
        ' 
        txt_accnumber.Location = New Point(6, 217)
        txt_accnumber.Name = "txt_accnumber"
        txt_accnumber.Size = New Size(280, 23)
        txt_accnumber.TabIndex = 13
        ' 
        ' gp_sex
        ' 
        gp_sex.Controls.Add(rbOther)
        gp_sex.Controls.Add(rbMale)
        gp_sex.Controls.Add(rbFemale)
        gp_sex.Location = New Point(520, 32)
        gp_sex.Name = "gp_sex"
        gp_sex.Size = New Size(116, 102)
        gp_sex.TabIndex = 12
        gp_sex.TabStop = False
        gp_sex.Text = "Sex"
        ' 
        ' rbOther
        ' 
        rbOther.AutoSize = True
        rbOther.Location = New Point(11, 72)
        rbOther.Name = "rbOther"
        rbOther.Size = New Size(55, 19)
        rbOther.TabIndex = 12
        rbOther.TabStop = True
        rbOther.Text = "Other"
        rbOther.UseVisualStyleBackColor = True
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(11, 22)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(51, 19)
        rbMale.TabIndex = 10
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(11, 47)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(63, 19)
        rbFemale.TabIndex = 11
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(301, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 9
        Label5.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 8
        Label4.Text = "Email"
        ' 
        ' txt_phone
        ' 
        txt_phone.Location = New Point(301, 111)
        txt_phone.Name = "txt_phone"
        txt_phone.Size = New Size(195, 23)
        txt_phone.TabIndex = 7
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(6, 111)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(254, 23)
        txt_email.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(346, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 5
        Label3.Text = "Firstname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(183, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 4
        Label2.Text = "Middlename"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 3
        Label1.Text = "Lastname"
        ' 
        ' txt_firstname
        ' 
        txt_firstname.Location = New Point(346, 50)
        txt_firstname.Name = "txt_firstname"
        txt_firstname.Size = New Size(150, 23)
        txt_firstname.TabIndex = 2
        ' 
        ' txt_middlename
        ' 
        txt_middlename.Location = New Point(183, 50)
        txt_middlename.Name = "txt_middlename"
        txt_middlename.Size = New Size(148, 23)
        txt_middlename.TabIndex = 1
        ' 
        ' txt_lastname
        ' 
        txt_lastname.Location = New Point(6, 50)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.Size = New Size(158, 23)
        txt_lastname.TabIndex = 0
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 287)
        Controls.Add(GroupBox1)
        Name = "RegisterForm"
        Text = "Account Details"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        gp_sex.ResumeLayout(False)
        gp_sex.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_firstname As TextBox
    Friend WithEvents txt_middlename As TextBox
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gp_sex As GroupBox
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents txt_accnumber As TextBox
    Friend WithEvents rbOther As RadioButton
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_acctype As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label7 As Label
End Class
