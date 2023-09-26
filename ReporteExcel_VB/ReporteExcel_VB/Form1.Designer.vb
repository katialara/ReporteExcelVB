<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CapacitacionDataSet1 = New ReporteExcel_VB.CapacitacionDataSet1()
        Me.InstructorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstructorTableAdapter = New ReporteExcel_VB.CapacitacionDataSet1TableAdapters.InstructorTableAdapter()
        Me.IdInstructorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CveEscDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CapacitacionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInstructorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.CveEscDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InstructorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(70, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 179)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(123, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Crear reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CapacitacionDataSet1
        '
        Me.CapacitacionDataSet1.DataSetName = "CapacitacionDataSet1"
        Me.CapacitacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InstructorBindingSource
        '
        Me.InstructorBindingSource.DataMember = "Instructor"
        Me.InstructorBindingSource.DataSource = Me.CapacitacionDataSet1
        '
        'InstructorTableAdapter
        '
        Me.InstructorTableAdapter.ClearBeforeFill = True
        '
        'IdInstructorDataGridViewTextBoxColumn
        '
        Me.IdInstructorDataGridViewTextBoxColumn.DataPropertyName = "Id_Instructor"
        Me.IdInstructorDataGridViewTextBoxColumn.HeaderText = "Id_Instructor"
        Me.IdInstructorDataGridViewTextBoxColumn.Name = "IdInstructorDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        '
        'CveEscDataGridViewTextBoxColumn
        '
        Me.CveEscDataGridViewTextBoxColumn.DataPropertyName = "Cve_Esc"
        Me.CveEscDataGridViewTextBoxColumn.HeaderText = "Cve_Esc"
        Me.CveEscDataGridViewTextBoxColumn.Name = "CveEscDataGridViewTextBoxColumn"
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1000, 486)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CapacitacionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstructorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents CapacitacionDataSet1 As CapacitacionDataSet1
    Friend WithEvents InstructorBindingSource As BindingSource
    Friend WithEvents InstructorTableAdapter As CapacitacionDataSet1TableAdapters.InstructorTableAdapter
    Friend WithEvents IdInstructorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CveEscDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
