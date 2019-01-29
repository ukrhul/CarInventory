<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Me.lbMake = New System.Windows.Forms.Label()
        Me.lbModel = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.lbNew = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvmCar = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbMake
        '
        Me.lbMake.AutoSize = True
        Me.lbMake.Location = New System.Drawing.Point(38, 13)
        Me.lbMake.Name = "lbMake"
        Me.lbMake.Size = New System.Drawing.Size(37, 13)
        Me.lbMake.TabIndex = 0
        Me.lbMake.Text = "Make:"
        Me.lbMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbModel
        '
        Me.lbModel.AutoSize = True
        Me.lbModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbModel.Location = New System.Drawing.Point(36, 39)
        Me.lbModel.Name = "lbModel"
        Me.lbModel.Size = New System.Drawing.Size(39, 13)
        Me.lbModel.TabIndex = 2
        Me.lbModel.Text = "Model:"
        Me.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbYear
        '
        Me.lbYear.AutoSize = True
        Me.lbYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbYear.Location = New System.Drawing.Point(43, 65)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(32, 13)
        Me.lbYear.TabIndex = 4
        Me.lbYear.Text = "Year:"
        Me.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Location = New System.Drawing.Point(41, 91)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(34, 13)
        Me.lbPrice.TabIndex = 6
        Me.lbPrice.Text = "Price:"
        Me.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbNew
        '
        Me.lbNew.AutoSize = True
        Me.lbNew.Location = New System.Drawing.Point(43, 117)
        Me.lbNew.Name = "lbNew"
        Me.lbNew.Size = New System.Drawing.Size(32, 13)
        Me.lbNew.TabIndex = 8
        Me.lbNew.Text = "New:"
        Me.lbNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(81, 116)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(15, 14)
        Me.chkNew.TabIndex = 9
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(81, 91)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(115, 20)
        Me.tbPrice.TabIndex = 7
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(81, 36)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(115, 20)
        Me.tbModel.TabIndex = 3
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cmbYear.Location = New System.Drawing.Point(81, 64)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(115, 21)
        Me.cmbYear.TabIndex = 5
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Hyundai", "Honda", "Buick", "Dodge", "Mercedes", "Chevrolet"})
        Me.cmbMake.Location = New System.Drawing.Point(81, 9)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(115, 21)
        Me.cmbMake.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(13, 389)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(167, 389)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Re&set"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(321, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvmCar
        '
        Me.lvmCar.CheckBoxes = True
        Me.lvmCar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvmCar.FullRowSelect = True
        Me.lvmCar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvmCar.Location = New System.Drawing.Point(13, 149)
        Me.lvmCar.MultiSelect = False
        Me.lvmCar.Name = "lvmCar"
        Me.lvmCar.Size = New System.Drawing.Size(400, 145)
        Me.lvmCar.TabIndex = 10
        Me.lvmCar.UseCompatibleStateImageBehavior = False
        Me.lvmCar.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(12, 308)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(401, 65)
        Me.lbResult.TabIndex = 11
        '
        'frmInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(425, 424)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvmCar)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lbNew)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.lbModel)
        Me.Controls.Add(Me.lbMake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMake As Label
    Friend WithEvents lbModel As Label
    Friend WithEvents lbYear As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents lbNew As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents tbModel As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lvmCar As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lbResult As Label
End Class
