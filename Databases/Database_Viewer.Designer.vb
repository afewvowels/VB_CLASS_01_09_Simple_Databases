<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database_Viewer
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
        Me.components = New System.ComponentModel.Container()
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim Subject_CodeLabel As System.Windows.Forms.Label
        Dim Shelf_LocationLabel As System.Windows.Forms.Label
        Dim FictionLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RnrBooksDataSet = New Databases.RnrBooksDataSet()
        Me.BooksTableAdapter = New Databases.RnrBooksDataSetTableAdapters.BooksTableAdapter()
        Me.TableAdapterManager = New Databases.RnrBooksDataSetTableAdapters.TableAdapterManager()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.Subject_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Shelf_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.FictionCheckBox = New System.Windows.Forms.CheckBox()
        Me.TitleListBox = New System.Windows.Forms.ListBox()
        ISBNLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        PublisherLabel = New System.Windows.Forms.Label()
        Subject_CodeLabel = New System.Windows.Forms.Label()
        Shelf_LocationLabel = New System.Windows.Forms.Label()
        FictionLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnrBooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.RnrBooksDataSet
        '
        'RnrBooksDataSet
        '
        Me.RnrBooksDataSet.DataSetName = "RnrBooksDataSet"
        Me.RnrBooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.UpdateOrder = Databases.RnrBooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(23, 31)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 0
        ISBNLabel.Text = "ISBN:"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(107, 28)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ISBNTextBox.TabIndex = 1
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(23, 83)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 4
        AuthorLabel.Text = "Author:"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(107, 80)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(104, 20)
        Me.AuthorTextBox.TabIndex = 5
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.Location = New System.Drawing.Point(23, 109)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(53, 13)
        PublisherLabel.TabIndex = 6
        PublisherLabel.Text = "Publisher:"
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Publisher", True))
        Me.PublisherTextBox.Location = New System.Drawing.Point(107, 106)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PublisherTextBox.TabIndex = 7
        '
        'Subject_CodeLabel
        '
        Subject_CodeLabel.AutoSize = True
        Subject_CodeLabel.Location = New System.Drawing.Point(23, 135)
        Subject_CodeLabel.Name = "Subject_CodeLabel"
        Subject_CodeLabel.Size = New System.Drawing.Size(74, 13)
        Subject_CodeLabel.TabIndex = 8
        Subject_CodeLabel.Text = "Subject Code:"
        '
        'Subject_CodeTextBox
        '
        Me.Subject_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Subject_Code", True))
        Me.Subject_CodeTextBox.Location = New System.Drawing.Point(107, 132)
        Me.Subject_CodeTextBox.Name = "Subject_CodeTextBox"
        Me.Subject_CodeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Subject_CodeTextBox.TabIndex = 9
        '
        'Shelf_LocationLabel
        '
        Shelf_LocationLabel.AutoSize = True
        Shelf_LocationLabel.Location = New System.Drawing.Point(23, 161)
        Shelf_LocationLabel.Name = "Shelf_LocationLabel"
        Shelf_LocationLabel.Size = New System.Drawing.Size(78, 13)
        Shelf_LocationLabel.TabIndex = 10
        Shelf_LocationLabel.Text = "Shelf Location:"
        '
        'Shelf_LocationTextBox
        '
        Me.Shelf_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Shelf_Location", True))
        Me.Shelf_LocationTextBox.Location = New System.Drawing.Point(107, 158)
        Me.Shelf_LocationTextBox.Name = "Shelf_LocationTextBox"
        Me.Shelf_LocationTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Shelf_LocationTextBox.TabIndex = 11
        '
        'FictionLabel
        '
        FictionLabel.AutoSize = True
        FictionLabel.Location = New System.Drawing.Point(23, 189)
        FictionLabel.Name = "FictionLabel"
        FictionLabel.Size = New System.Drawing.Size(41, 13)
        FictionLabel.TabIndex = 12
        FictionLabel.Text = "Fiction:"
        '
        'FictionCheckBox
        '
        Me.FictionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BooksBindingSource, "Fiction", True))
        Me.FictionCheckBox.Location = New System.Drawing.Point(107, 184)
        Me.FictionCheckBox.Name = "FictionCheckBox"
        Me.FictionCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.FictionCheckBox.TabIndex = 13
        Me.FictionCheckBox.Text = "CheckBox1"
        Me.FictionCheckBox.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(246, 53)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 13
        TitleLabel.Text = "Title:"
        '
        'TitleListBox
        '
        Me.TitleListBox.DataSource = Me.BooksBindingSource
        Me.TitleListBox.DisplayMember = "Title"
        Me.TitleListBox.FormattingEnabled = True
        Me.TitleListBox.Location = New System.Drawing.Point(282, 53)
        Me.TitleListBox.Name = "TitleListBox"
        Me.TitleListBox.Size = New System.Drawing.Size(324, 225)
        Me.TitleListBox.TabIndex = 14
        '
        'Database_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 312)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleListBox)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(PublisherLabel)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(Subject_CodeLabel)
        Me.Controls.Add(Me.Subject_CodeTextBox)
        Me.Controls.Add(Shelf_LocationLabel)
        Me.Controls.Add(Me.Shelf_LocationTextBox)
        Me.Controls.Add(FictionLabel)
        Me.Controls.Add(Me.FictionCheckBox)
        Me.Name = "Database_Viewer"
        Me.Text = "Database Editor"
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnrBooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RnrBooksDataSet As Databases.RnrBooksDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As Databases.RnrBooksDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As Databases.RnrBooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Shelf_LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FictionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleListBox As System.Windows.Forms.ListBox

End Class
