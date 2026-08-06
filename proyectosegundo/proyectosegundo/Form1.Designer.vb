<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        mnuArchivo = New ToolStripMenuItem()
        mnuNuevoEstudiante = New ToolStripMenuItem()
        mnuImportar = New ToolStripMenuItem()
        mnuExportar = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        mnuEstudiantes = New ToolStripMenuItem()
        mnuGuardarEstudiante = New ToolStripMenuItem()
        mnuEliminarEstudiante = New ToolStripMenuItem()
        mnuLimpiarEstudiante = New ToolStripMenuItem()
        mnuReportes = New ToolStripMenuItem()
        mnuActualizarReporte = New ToolStripMenuItem()
        mnuReporteBecados = New ToolStripMenuItem()
        mnuReporteTurnos = New ToolStripMenuItem()
        mnuFormato = New ToolStripMenuItem()
        mnuFuente = New ToolStripMenuItem()
        mnuColor = New ToolStripMenuItem()
        mnuNegrita = New ToolStripMenuItem()
        mnuCursiva = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        tsbNuevo = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        tsbImportar = New ToolStripButton()
        tsbExportar = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        tsbActualizarReporte = New ToolStripButton()
        tabPrincipal = New TabControl()
        tabEstudiantes = New TabPage()
        splitEstudiantes = New SplitContainer()
        grpRegistroEstudiante = New GroupBox()
        tlpRegistroEstudiante = New TableLayoutPanel()
        txtNombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtApellido = New TextBox()
        txtMatricula = New TextBox()
        grpTurno = New GroupBox()
        rbVespertino = New RadioButton()
        rbMatutino = New RadioButton()
        Label4 = New Label()
        chkBeca = New CheckBox()
        btnLimpiarEstudiante = New Button()
        btnGuardarEstudiante = New Button()
        flpFiltrosEstudiantes = New FlowLayoutPanel()
        Label5 = New Label()
        txtBuscarEstudiante = New TextBox()
        lbl = New Label()
        cboFiltroBeca = New ComboBox()
        Label6 = New Label()
        cboFiltroTurno = New ComboBox()
        dvgEstudiantes = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        dgvEstudiantes = New DataGridView()
        cmsEstudiantes = New ContextMenuStrip(components)
        cmsVerDetalle = New ToolStripMenuItem()
        cmsEditarEstudiante = New ToolStripMenuItem()
        cmsEliminarEstudiante = New ToolStripMenuItem()
        cmsCopiarMatricula = New ToolStripMenuItem()
        grpDetalleEstudiante = New GroupBox()
        lblDetalleBeca = New Label()
        lblDetalleTurno = New Label()
        lblDetalleMatricula = New Label()
        lblDetalleApellido = New Label()
        lblDetalleNombre = New Label()
        tabCursos = New TabPage()
        TableLayoutPanel1 = New TableLayoutPanel()
        grpInscripcionCurso = New GroupBox()
        btnAgregarEspera = New Button()
        btnAsignarCurso = New Button()
        dtpFechaInscripcion = New DateTimePicker()
        Label9 = New Label()
        cboEstudianteCurso = New ComboBox()
        Label8 = New Label()
        grpDatosCurso = New GroupBox()
        lblEstadoCurso = New Label()
        lblDisponiblesValor = New Label()
        lblInscritosValor = New Label()
        lblCreditosValor = New Label()
        lblCupoMaximoValor = New Label()
        Label7 = New Label()
        cboCurso = New ComboBox()
        dgvInscritosCurso = New DataGridView()
        dgvListaEspera = New DataGridView()
        tabReportes = New TabPage()
        SplitContainer1 = New SplitContainer()
        grpReportes = New GroupBox()
        lstResultadoReporte = New ListBox()
        lblTotalVespertinoReporte = New Label()
        lblTotalMatutinoReporte = New Label()
        lblTotalBecadosReporte = New Label()
        lblTotalEstudiantesReporte = New Label()
        btnGenerarReporte = New Button()
        Label10 = New Label()
        cboTipoReporte = New ComboBox()
        grpObservaciones = New GroupBox()
        btnColorObservaciones = New Button()
        btnFuenteObservaciones = New Button()
        btnCursiva = New Button()
        btnNegrita = New Button()
        flpFormatoObservaciones = New FlowLayoutPanel()
        rtbObservaciones = New RichTextBox()
        StatusStrip1 = New StatusStrip()
        sslEstado = New ToolStripStatusLabel()
        sslTotalEstudiantes = New ToolStripStatusLabel()
        sslTotalCursos = New ToolStripStatusLabel()
        sslCursoSeleccionado = New ToolStripStatusLabel()
        epValidacion = New ErrorProvider(components)
        ofdImportar = New OpenFileDialog()
        sfdExportar = New SaveFileDialog()
        cdObservaciones = New ColorDialog()
        fdObservaciones = New FontDialog()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        tabPrincipal.SuspendLayout()
        tabEstudiantes.SuspendLayout()
        CType(splitEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        splitEstudiantes.Panel1.SuspendLayout()
        splitEstudiantes.Panel2.SuspendLayout()
        splitEstudiantes.SuspendLayout()
        grpRegistroEstudiante.SuspendLayout()
        tlpRegistroEstudiante.SuspendLayout()
        grpTurno.SuspendLayout()
        flpFiltrosEstudiantes.SuspendLayout()
        CType(dvgEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        cmsEstudiantes.SuspendLayout()
        grpDetalleEstudiante.SuspendLayout()
        tabCursos.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        grpInscripcionCurso.SuspendLayout()
        grpDatosCurso.SuspendLayout()
        CType(dgvInscritosCurso, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvListaEspera, ComponentModel.ISupportInitialize).BeginInit()
        tabReportes.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        grpReportes.SuspendLayout()
        grpObservaciones.SuspendLayout()
        StatusStrip1.SuspendLayout()
        CType(epValidacion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuArchivo, mnuEstudiantes, mnuReportes, mnuFormato})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1085, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuArchivo
        ' 
        mnuArchivo.DropDownItems.AddRange(New ToolStripItem() {mnuNuevoEstudiante, mnuImportar, mnuExportar, mnuSalir})
        mnuArchivo.Name = "mnuArchivo"
        mnuArchivo.Size = New Size(88, 29)
        mnuArchivo.Text = "Archivo"
        ' 
        ' mnuNuevoEstudiante
        ' 
        mnuNuevoEstudiante.Name = "mnuNuevoEstudiante"
        mnuNuevoEstudiante.Size = New Size(279, 34)
        mnuNuevoEstudiante.Text = "Nuevo Registro"
        ' 
        ' mnuImportar
        ' 
        mnuImportar.Name = "mnuImportar"
        mnuImportar.Size = New Size(279, 34)
        mnuImportar.Text = "Importar Estudiantes"
        ' 
        ' mnuExportar
        ' 
        mnuExportar.Name = "mnuExportar"
        mnuExportar.Size = New Size(279, 34)
        mnuExportar.Text = "Exportar Estudiantes"
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.Size = New Size(279, 34)
        mnuSalir.Text = "Salir"
        ' 
        ' mnuEstudiantes
        ' 
        mnuEstudiantes.DropDownItems.AddRange(New ToolStripItem() {mnuGuardarEstudiante, mnuEliminarEstudiante, mnuLimpiarEstudiante})
        mnuEstudiantes.Name = "mnuEstudiantes"
        mnuEstudiantes.Size = New Size(118, 29)
        mnuEstudiantes.Text = "Estudiantes"
        ' 
        ' mnuGuardarEstudiante
        ' 
        mnuGuardarEstudiante.Name = "mnuGuardarEstudiante"
        mnuGuardarEstudiante.Size = New Size(264, 34)
        mnuGuardarEstudiante.Text = "Guardar Estudiante"
        ' 
        ' mnuEliminarEstudiante
        ' 
        mnuEliminarEstudiante.Name = "mnuEliminarEstudiante"
        mnuEliminarEstudiante.Size = New Size(264, 34)
        mnuEliminarEstudiante.Text = "Eliminar Estudiante"
        ' 
        ' mnuLimpiarEstudiante
        ' 
        mnuLimpiarEstudiante.Name = "mnuLimpiarEstudiante"
        mnuLimpiarEstudiante.Size = New Size(264, 34)
        mnuLimpiarEstudiante.Text = "Limpiar Formulario"
        ' 
        ' mnuReportes
        ' 
        mnuReportes.DropDownItems.AddRange(New ToolStripItem() {mnuActualizarReporte, mnuReporteBecados, mnuReporteTurnos})
        mnuReportes.Name = "mnuReportes"
        mnuReportes.Size = New Size(98, 29)
        mnuReportes.Text = "Reportes"
        ' 
        ' mnuActualizarReporte
        ' 
        mnuActualizarReporte.Name = "mnuActualizarReporte"
        mnuActualizarReporte.Size = New Size(263, 34)
        mnuActualizarReporte.Text = "Actualizar Reporte"
        ' 
        ' mnuReporteBecados
        ' 
        mnuReporteBecados.Name = "mnuReporteBecados"
        mnuReporteBecados.Size = New Size(263, 34)
        mnuReporteBecados.Text = "Mostrar Becados"
        ' 
        ' mnuReporteTurnos
        ' 
        mnuReporteTurnos.Name = "mnuReporteTurnos"
        mnuReporteTurnos.Size = New Size(263, 34)
        mnuReporteTurnos.Text = "Agrupar por Turno"
        ' 
        ' mnuFormato
        ' 
        mnuFormato.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuColor, mnuNegrita, mnuCursiva})
        mnuFormato.Name = "mnuFormato"
        mnuFormato.Size = New Size(104, 29)
        mnuFormato.Text = "Formatos"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(175, 34)
        mnuFuente.Text = "Fuentes"
        ' 
        ' mnuColor
        ' 
        mnuColor.Name = "mnuColor"
        mnuColor.Size = New Size(175, 34)
        mnuColor.Text = "Color"
        ' 
        ' mnuNegrita
        ' 
        mnuNegrita.Name = "mnuNegrita"
        mnuNegrita.Size = New Size(175, 34)
        mnuNegrita.Text = "Negrita"
        ' 
        ' mnuCursiva
        ' 
        mnuCursiva.Name = "mnuCursiva"
        mnuCursiva.Size = New Size(175, 34)
        mnuCursiva.Text = "Cursiva"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbGuardar, ToolStripSeparator1, tsbImportar, tsbExportar, ToolStripSeparator2, tsbActualizarReporte})
        ToolStrip1.Location = New Point(0, 33)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1085, 34)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(68, 29)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), Image)
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(79, 29)
        tsbGuardar.Text = "Guardar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 34)
        ' 
        ' tsbImportar
        ' 
        tsbImportar.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbImportar.Image = CType(resources.GetObject("tsbImportar.Image"), Image)
        tsbImportar.ImageTransparentColor = Color.Magenta
        tsbImportar.Name = "tsbImportar"
        tsbImportar.Size = New Size(86, 29)
        tsbImportar.Text = "Importar"
        ' 
        ' tsbExportar
        ' 
        tsbExportar.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbExportar.Image = CType(resources.GetObject("tsbExportar.Image"), Image)
        tsbExportar.ImageTransparentColor = Color.Magenta
        tsbExportar.Name = "tsbExportar"
        tsbExportar.Size = New Size(82, 29)
        tsbExportar.Text = "Exportar"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 34)
        ' 
        ' tsbActualizarReporte
        ' 
        tsbActualizarReporte.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbActualizarReporte.Image = CType(resources.GetObject("tsbActualizarReporte.Image"), Image)
        tsbActualizarReporte.ImageTransparentColor = Color.Magenta
        tsbActualizarReporte.Name = "tsbActualizarReporte"
        tsbActualizarReporte.Size = New Size(159, 29)
        tsbActualizarReporte.Text = "Actualizar Reporte"
        ' 
        ' tabPrincipal
        ' 
        tabPrincipal.Controls.Add(tabEstudiantes)
        tabPrincipal.Controls.Add(tabCursos)
        tabPrincipal.Controls.Add(tabReportes)
        tabPrincipal.Location = New Point(2, 76)
        tabPrincipal.Name = "tabPrincipal"
        tabPrincipal.SelectedIndex = 0
        tabPrincipal.Size = New Size(1083, 652)
        tabPrincipal.TabIndex = 2
        ' 
        ' tabEstudiantes
        ' 
        tabEstudiantes.Controls.Add(splitEstudiantes)
        tabEstudiantes.Location = New Point(4, 34)
        tabEstudiantes.Name = "tabEstudiantes"
        tabEstudiantes.Padding = New Padding(3)
        tabEstudiantes.Size = New Size(1075, 614)
        tabEstudiantes.TabIndex = 0
        tabEstudiantes.Text = "Inscripción de Estudiantes"
        tabEstudiantes.UseVisualStyleBackColor = True
        ' 
        ' splitEstudiantes
        ' 
        splitEstudiantes.Dock = DockStyle.Fill
        splitEstudiantes.Location = New Point(3, 3)
        splitEstudiantes.Name = "splitEstudiantes"
        ' 
        ' splitEstudiantes.Panel1
        ' 
        splitEstudiantes.Panel1.Controls.Add(grpRegistroEstudiante)
        ' 
        ' splitEstudiantes.Panel2
        ' 
        splitEstudiantes.Panel2.Controls.Add(flpFiltrosEstudiantes)
        splitEstudiantes.Size = New Size(1069, 608)
        splitEstudiantes.SplitterDistance = 425
        splitEstudiantes.TabIndex = 0
        ' 
        ' grpRegistroEstudiante
        ' 
        grpRegistroEstudiante.Controls.Add(tlpRegistroEstudiante)
        grpRegistroEstudiante.Location = New Point(3, 3)
        grpRegistroEstudiante.Name = "grpRegistroEstudiante"
        grpRegistroEstudiante.Size = New Size(386, 327)
        grpRegistroEstudiante.TabIndex = 0
        grpRegistroEstudiante.TabStop = False
        grpRegistroEstudiante.Text = "Registro del Estudiante"
        ' 
        ' tlpRegistroEstudiante
        ' 
        tlpRegistroEstudiante.ColumnCount = 2
        tlpRegistroEstudiante.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.68421F))
        tlpRegistroEstudiante.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 71.31579F))
        tlpRegistroEstudiante.Controls.Add(txtNombre, 1, 0)
        tlpRegistroEstudiante.Controls.Add(Label1, 0, 0)
        tlpRegistroEstudiante.Controls.Add(Label2, 0, 1)
        tlpRegistroEstudiante.Controls.Add(Label3, 0, 2)
        tlpRegistroEstudiante.Controls.Add(txtApellido, 1, 1)
        tlpRegistroEstudiante.Controls.Add(txtMatricula, 1, 2)
        tlpRegistroEstudiante.Controls.Add(grpTurno, 1, 3)
        tlpRegistroEstudiante.Controls.Add(Label4, 0, 3)
        tlpRegistroEstudiante.Controls.Add(chkBeca, 1, 4)
        tlpRegistroEstudiante.Controls.Add(btnLimpiarEstudiante, 1, 5)
        tlpRegistroEstudiante.Controls.Add(btnGuardarEstudiante, 0, 5)
        tlpRegistroEstudiante.Dock = DockStyle.Fill
        tlpRegistroEstudiante.Location = New Point(3, 27)
        tlpRegistroEstudiante.Name = "tlpRegistroEstudiante"
        tlpRegistroEstudiante.RowCount = 6
        tlpRegistroEstudiante.RowStyles.Add(New RowStyle(SizeType.Percent, 47.727272F))
        tlpRegistroEstudiante.RowStyles.Add(New RowStyle(SizeType.Percent, 52.272728F))
        tlpRegistroEstudiante.RowStyles.Add(New RowStyle(SizeType.Absolute, 47.0F))
        tlpRegistroEstudiante.RowStyles.Add(New RowStyle(SizeType.Absolute, 56.0F))
        tlpRegistroEstudiante.RowStyles.Add(New RowStyle(SizeType.Absolute, 54.0F))
        tlpRegistroEstudiante.RowStyles.Add(New RowStyle(SizeType.Absolute, 51.0F))
        tlpRegistroEstudiante.Size = New Size(380, 297)
        tlpRegistroEstudiante.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(112, 3)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(265, 31)
        txtNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 25)
        Label2.TabIndex = 2
        Label2.Text = "Apellidos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 3
        Label3.Text = "Matricula"
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(112, 45)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(265, 31)
        txtApellido.TabIndex = 5
        ' 
        ' txtMatricula
        ' 
        txtMatricula.Location = New Point(112, 91)
        txtMatricula.Name = "txtMatricula"
        txtMatricula.Size = New Size(265, 31)
        txtMatricula.TabIndex = 6
        ' 
        ' grpTurno
        ' 
        grpTurno.Controls.Add(rbVespertino)
        grpTurno.Controls.Add(rbMatutino)
        grpTurno.Location = New Point(112, 138)
        grpTurno.Name = "grpTurno"
        grpTurno.Size = New Size(265, 50)
        grpTurno.TabIndex = 7
        grpTurno.TabStop = False
        ' 
        ' rbVespertino
        ' 
        rbVespertino.AutoSize = True
        rbVespertino.Location = New Point(115, 15)
        rbVespertino.Name = "rbVespertino"
        rbVespertino.Size = New Size(121, 29)
        rbVespertino.TabIndex = 1
        rbVespertino.TabStop = True
        rbVespertino.Text = "Vespertino"
        rbVespertino.UseVisualStyleBackColor = True
        ' 
        ' rbMatutino
        ' 
        rbMatutino.AutoSize = True
        rbMatutino.Location = New Point(0, 15)
        rbMatutino.Name = "rbMatutino"
        rbMatutino.Size = New Size(109, 29)
        rbMatutino.TabIndex = 0
        rbMatutino.TabStop = True
        rbMatutino.Text = "Matutino"
        rbMatutino.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 4
        Label4.Text = "Turno"
        ' 
        ' chkBeca
        ' 
        chkBeca.AutoSize = True
        chkBeca.Location = New Point(112, 194)
        chkBeca.Name = "chkBeca"
        chkBeca.Size = New Size(168, 29)
        chkBeca.TabIndex = 8
        chkBeca.Text = "Cuenta con Beca"
        chkBeca.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiarEstudiante
        ' 
        btnLimpiarEstudiante.Location = New Point(112, 248)
        btnLimpiarEstudiante.Name = "btnLimpiarEstudiante"
        btnLimpiarEstudiante.Size = New Size(112, 34)
        btnLimpiarEstudiante.TabIndex = 10
        btnLimpiarEstudiante.Text = "Limpiar"
        btnLimpiarEstudiante.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarEstudiante
        ' 
        btnGuardarEstudiante.Location = New Point(3, 248)
        btnGuardarEstudiante.Name = "btnGuardarEstudiante"
        btnGuardarEstudiante.Size = New Size(103, 34)
        btnGuardarEstudiante.TabIndex = 11
        btnGuardarEstudiante.Text = "Guardar"
        btnGuardarEstudiante.UseVisualStyleBackColor = True
        ' 
        ' flpFiltrosEstudiantes
        ' 
        flpFiltrosEstudiantes.Controls.Add(Label5)
        flpFiltrosEstudiantes.Controls.Add(txtBuscarEstudiante)
        flpFiltrosEstudiantes.Controls.Add(lbl)
        flpFiltrosEstudiantes.Controls.Add(cboFiltroBeca)
        flpFiltrosEstudiantes.Controls.Add(Label6)
        flpFiltrosEstudiantes.Controls.Add(cboFiltroTurno)
        flpFiltrosEstudiantes.Controls.Add(dvgEstudiantes)
        flpFiltrosEstudiantes.Controls.Add(dgvEstudiantes)
        flpFiltrosEstudiantes.Controls.Add(grpDetalleEstudiante)
        flpFiltrosEstudiantes.Location = New Point(3, 3)
        flpFiltrosEstudiantes.Name = "flpFiltrosEstudiantes"
        flpFiltrosEstudiantes.Size = New Size(634, 536)
        flpFiltrosEstudiantes.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 25)
        Label5.TabIndex = 0
        Label5.Text = "Buscar"
        ' 
        ' txtBuscarEstudiante
        ' 
        txtBuscarEstudiante.Location = New Point(72, 3)
        txtBuscarEstudiante.Name = "txtBuscarEstudiante"
        txtBuscarEstudiante.Size = New Size(524, 31)
        txtBuscarEstudiante.TabIndex = 1
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Location = New Point(3, 37)
        lbl.Name = "lbl"
        lbl.Size = New Size(58, 25)
        lbl.TabIndex = 2
        lbl.Text = "Turno"
        ' 
        ' cboFiltroBeca
        ' 
        cboFiltroBeca.FormattingEnabled = True
        cboFiltroBeca.Items.AddRange(New Object() {"", "Con Beca", "Sin Beca"})
        cboFiltroBeca.Location = New Point(67, 40)
        cboFiltroBeca.Name = "cboFiltroBeca"
        cboFiltroBeca.Size = New Size(529, 33)
        cboFiltroBeca.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 25)
        Label6.TabIndex = 4
        Label6.Text = "Beca"
        ' 
        ' cboFiltroTurno
        ' 
        cboFiltroTurno.FormattingEnabled = True
        cboFiltroTurno.Items.AddRange(New Object() {"Completo", "Matutino", "Vespertino"})
        cboFiltroTurno.Location = New Point(57, 79)
        cboFiltroTurno.Name = "cboFiltroTurno"
        cboFiltroTurno.Size = New Size(539, 33)
        cboFiltroTurno.TabIndex = 3
        ' 
        ' dvgEstudiantes
        ' 
        dvgEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgEstudiantes.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dvgEstudiantes.Dock = DockStyle.Fill
        dvgEstudiantes.Location = New Point(3, 118)
        dvgEstudiantes.Name = "dvgEstudiantes"
        dvgEstudiantes.RowHeadersWidth = 62
        dvgEstudiantes.Size = New Size(575, 0)
        dvgEstudiantes.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Matricula"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nombre"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Apellido"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Turno"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Beca"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' dgvEstudiantes
        ' 
        dgvEstudiantes.AllowUserToAddRows = False
        dgvEstudiantes.AllowUserToDeleteRows = False
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEstudiantes.ContextMenuStrip = cmsEstudiantes
        dgvEstudiantes.Dock = DockStyle.Bottom
        dgvEstudiantes.Location = New Point(3, 124)
        dgvEstudiantes.MultiSelect = False
        dgvEstudiantes.Name = "dgvEstudiantes"
        dgvEstudiantes.ReadOnly = True
        dgvEstudiantes.RowHeadersWidth = 62
        dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEstudiantes.Size = New Size(629, 147)
        dgvEstudiantes.TabIndex = 7
        ' 
        ' cmsEstudiantes
        ' 
        cmsEstudiantes.ImageScalingSize = New Size(24, 24)
        cmsEstudiantes.Items.AddRange(New ToolStripItem() {cmsVerDetalle, cmsEditarEstudiante, cmsEliminarEstudiante, cmsCopiarMatricula})
        cmsEstudiantes.Name = "cmsEstudiantes"
        cmsEstudiantes.Size = New Size(214, 132)
        ' 
        ' cmsVerDetalle
        ' 
        cmsVerDetalle.Name = "cmsVerDetalle"
        cmsVerDetalle.Size = New Size(213, 32)
        cmsVerDetalle.Text = "Ver detalle"
        ' 
        ' cmsEditarEstudiante
        ' 
        cmsEditarEstudiante.Name = "cmsEditarEstudiante"
        cmsEditarEstudiante.Size = New Size(213, 32)
        cmsEditarEstudiante.Text = "Editar"
        ' 
        ' cmsEliminarEstudiante
        ' 
        cmsEliminarEstudiante.Name = "cmsEliminarEstudiante"
        cmsEliminarEstudiante.Size = New Size(213, 32)
        cmsEliminarEstudiante.Text = "Eliminar"
        ' 
        ' cmsCopiarMatricula
        ' 
        cmsCopiarMatricula.Name = "cmsCopiarMatricula"
        cmsCopiarMatricula.Size = New Size(213, 32)
        cmsCopiarMatricula.Text = "Copiar matrícula"
        ' 
        ' grpDetalleEstudiante
        ' 
        grpDetalleEstudiante.Controls.Add(lblDetalleBeca)
        grpDetalleEstudiante.Controls.Add(lblDetalleTurno)
        grpDetalleEstudiante.Controls.Add(lblDetalleMatricula)
        grpDetalleEstudiante.Controls.Add(lblDetalleApellido)
        grpDetalleEstudiante.Controls.Add(lblDetalleNombre)
        grpDetalleEstudiante.Location = New Point(3, 277)
        grpDetalleEstudiante.Name = "grpDetalleEstudiante"
        grpDetalleEstudiante.Size = New Size(629, 255)
        grpDetalleEstudiante.TabIndex = 8
        grpDetalleEstudiante.TabStop = False
        grpDetalleEstudiante.Text = "Detalle del Estudiante Seleccionado"
        ' 
        ' lblDetalleBeca
        ' 
        lblDetalleBeca.AutoSize = True
        lblDetalleBeca.Location = New Point(6, 192)
        lblDetalleBeca.Name = "lblDetalleBeca"
        lblDetalleBeca.Size = New Size(48, 25)
        lblDetalleBeca.TabIndex = 5
        lblDetalleBeca.Text = "Beca"
        ' 
        ' lblDetalleTurno
        ' 
        lblDetalleTurno.AutoSize = True
        lblDetalleTurno.Location = New Point(6, 152)
        lblDetalleTurno.Name = "lblDetalleTurno"
        lblDetalleTurno.Size = New Size(58, 25)
        lblDetalleTurno.TabIndex = 4
        lblDetalleTurno.Text = "Turno"
        ' 
        ' lblDetalleMatricula
        ' 
        lblDetalleMatricula.AutoSize = True
        lblDetalleMatricula.Location = New Point(6, 112)
        lblDetalleMatricula.Name = "lblDetalleMatricula"
        lblDetalleMatricula.Size = New Size(84, 25)
        lblDetalleMatricula.TabIndex = 2
        lblDetalleMatricula.Text = "Matricula"
        ' 
        ' lblDetalleApellido
        ' 
        lblDetalleApellido.AutoSize = True
        lblDetalleApellido.Location = New Point(6, 73)
        lblDetalleApellido.Name = "lblDetalleApellido"
        lblDetalleApellido.Size = New Size(78, 25)
        lblDetalleApellido.TabIndex = 1
        lblDetalleApellido.Text = "Apellido"
        ' 
        ' lblDetalleNombre
        ' 
        lblDetalleNombre.AutoSize = True
        lblDetalleNombre.Location = New Point(6, 36)
        lblDetalleNombre.Name = "lblDetalleNombre"
        lblDetalleNombre.Size = New Size(78, 25)
        lblDetalleNombre.TabIndex = 0
        lblDetalleNombre.Text = "Nombre"
        ' 
        ' tabCursos
        ' 
        tabCursos.Controls.Add(TableLayoutPanel1)
        tabCursos.Location = New Point(4, 34)
        tabCursos.Name = "tabCursos"
        tabCursos.Padding = New Padding(3)
        tabCursos.Size = New Size(1075, 614)
        tabCursos.TabIndex = 1
        tabCursos.Text = "Cursos y Grupos"
        tabCursos.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.4275F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 52.5725F))
        TableLayoutPanel1.Controls.Add(grpInscripcionCurso, 1, 0)
        TableLayoutPanel1.Controls.Add(grpDatosCurso, 0, 0)
        TableLayoutPanel1.Controls.Add(dgvInscritosCurso, 0, 1)
        TableLayoutPanel1.Controls.Add(dgvListaEspera, 1, 1)
        TableLayoutPanel1.Location = New Point(3, 33)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 56.2613449F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 43.7386551F))
        TableLayoutPanel1.Size = New Size(1069, 551)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' grpInscripcionCurso
        ' 
        grpInscripcionCurso.Controls.Add(btnAgregarEspera)
        grpInscripcionCurso.Controls.Add(btnAsignarCurso)
        grpInscripcionCurso.Controls.Add(dtpFechaInscripcion)
        grpInscripcionCurso.Controls.Add(Label9)
        grpInscripcionCurso.Controls.Add(cboEstudianteCurso)
        grpInscripcionCurso.Controls.Add(Label8)
        grpInscripcionCurso.Location = New Point(510, 3)
        grpInscripcionCurso.Name = "grpInscripcionCurso"
        grpInscripcionCurso.Size = New Size(556, 304)
        grpInscripcionCurso.TabIndex = 1
        grpInscripcionCurso.TabStop = False
        grpInscripcionCurso.Text = "Incripciones del Curso"
        ' 
        ' btnAgregarEspera
        ' 
        btnAgregarEspera.Location = New Point(341, 192)
        btnAgregarEspera.Name = "btnAgregarEspera"
        btnAgregarEspera.Size = New Size(180, 34)
        btnAgregarEspera.TabIndex = 5
        btnAgregarEspera.Text = "Lista de Espera"
        btnAgregarEspera.UseVisualStyleBackColor = True
        ' 
        ' btnAsignarCurso
        ' 
        btnAsignarCurso.Location = New Point(137, 192)
        btnAsignarCurso.Name = "btnAsignarCurso"
        btnAsignarCurso.Size = New Size(112, 34)
        btnAsignarCurso.TabIndex = 4
        btnAsignarCurso.Text = "Asignar"
        btnAsignarCurso.UseVisualStyleBackColor = True
        ' 
        ' dtpFechaInscripcion
        ' 
        dtpFechaInscripcion.Location = New Point(212, 101)
        dtpFechaInscripcion.Name = "dtpFechaInscripcion"
        dtpFechaInscripcion.Size = New Size(300, 31)
        dtpFechaInscripcion.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(15, 101)
        Label9.Name = "Label9"
        Label9.Size = New Size(172, 25)
        Label9.TabIndex = 2
        Label9.Text = "Fecha de Inscripcion"
        ' 
        ' cboEstudianteCurso
        ' 
        cboEstudianteCurso.FormattingEnabled = True
        cboEstudianteCurso.Location = New Point(225, 45)
        cboEstudianteCurso.Name = "cboEstudianteCurso"
        cboEstudianteCurso.Size = New Size(259, 33)
        cboEstudianteCurso.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(15, 48)
        Label8.Name = "Label8"
        Label8.Size = New Size(187, 25)
        Label8.TabIndex = 0
        Label8.Text = "Seleccionar Estudiante"
        ' 
        ' grpDatosCurso
        ' 
        grpDatosCurso.Controls.Add(Label11)
        grpDatosCurso.Controls.Add(Label12)
        grpDatosCurso.Controls.Add(Label13)
        grpDatosCurso.Controls.Add(Label14)
        grpDatosCurso.Controls.Add(Label15)
        grpDatosCurso.Controls.Add(lblEstadoCurso)
        grpDatosCurso.Controls.Add(lblDisponiblesValor)
        grpDatosCurso.Controls.Add(lblInscritosValor)
        grpDatosCurso.Controls.Add(lblCreditosValor)
        grpDatosCurso.Controls.Add(lblCupoMaximoValor)
        grpDatosCurso.Controls.Add(Label7)
        grpDatosCurso.Controls.Add(cboCurso)
        grpDatosCurso.Location = New Point(3, 3)
        grpDatosCurso.Name = "grpDatosCurso"
        grpDatosCurso.Size = New Size(501, 304)
        grpDatosCurso.TabIndex = 0
        grpDatosCurso.TabStop = False
        grpDatosCurso.Text = "Cursos"
        ' 
        ' lblEstadoCurso
        ' 
        lblEstadoCurso.AutoSize = True
        lblEstadoCurso.Location = New Point(229, 270)
        lblEstadoCurso.Name = "lblEstadoCurso"
        lblEstadoCurso.Size = New Size(26, 25)
        lblEstadoCurso.TabIndex = 6
        lblEstadoCurso.Text = "--"
        ' 
        ' lblDisponiblesValor
        ' 
        lblDisponiblesValor.AutoSize = True
        lblDisponiblesValor.Location = New Point(228, 229)
        lblDisponiblesValor.Name = "lblDisponiblesValor"
        lblDisponiblesValor.Size = New Size(26, 25)
        lblDisponiblesValor.TabIndex = 5
        lblDisponiblesValor.Text = "--"
        ' 
        ' lblInscritosValor
        ' 
        lblInscritosValor.AutoSize = True
        lblInscritosValor.Location = New Point(228, 186)
        lblInscritosValor.Name = "lblInscritosValor"
        lblInscritosValor.Size = New Size(26, 25)
        lblInscritosValor.TabIndex = 4
        lblInscritosValor.Text = "--"
        ' 
        ' lblCreditosValor
        ' 
        lblCreditosValor.AutoSize = True
        lblCreditosValor.Location = New Point(229, 145)
        lblCreditosValor.Name = "lblCreditosValor"
        lblCreditosValor.Size = New Size(26, 25)
        lblCreditosValor.TabIndex = 3
        lblCreditosValor.Text = "--"
        ' 
        ' lblCupoMaximoValor
        ' 
        lblCupoMaximoValor.AutoSize = True
        lblCupoMaximoValor.Location = New Point(228, 106)
        lblCupoMaximoValor.Name = "lblCupoMaximoValor"
        lblCupoMaximoValor.Size = New Size(26, 25)
        lblCupoMaximoValor.TabIndex = 2
        lblCupoMaximoValor.Text = "--"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(23, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 25)
        Label7.TabIndex = 1
        Label7.Text = "Seleccionar Curso"
        ' 
        ' cboCurso
        ' 
        cboCurso.FormattingEnabled = True
        cboCurso.Items.AddRange(New Object() {"Programación Visual", "Base de Datos", "Redes", "Sistemas Operativos", "Ingeniería de Software"})
        cboCurso.Location = New Point(18, 58)
        cboCurso.Name = "cboCurso"
        cboCurso.Size = New Size(264, 33)
        cboCurso.TabIndex = 0
        ' 
        ' dgvInscritosCurso
        ' 
        dgvInscritosCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInscritosCurso.Location = New Point(3, 313)
        dgvInscritosCurso.Name = "dgvInscritosCurso"
        dgvInscritosCurso.RowHeadersWidth = 62
        dgvInscritosCurso.Size = New Size(501, 225)
        dgvInscritosCurso.TabIndex = 2
        ' 
        ' dgvListaEspera
        ' 
        dgvListaEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListaEspera.Location = New Point(510, 313)
        dgvListaEspera.Name = "dgvListaEspera"
        dgvListaEspera.RowHeadersWidth = 62
        dgvListaEspera.Size = New Size(554, 225)
        dgvListaEspera.TabIndex = 3
        ' 
        ' tabReportes
        ' 
        tabReportes.Controls.Add(SplitContainer1)
        tabReportes.Location = New Point(4, 34)
        tabReportes.Name = "tabReportes"
        tabReportes.Padding = New Padding(3)
        tabReportes.Size = New Size(1075, 614)
        tabReportes.TabIndex = 2
        tabReportes.Text = "Reportes y observaciones"
        tabReportes.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(3, 3)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(grpReportes)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(grpObservaciones)
        SplitContainer1.Size = New Size(1069, 608)
        SplitContainer1.SplitterDistance = 520
        SplitContainer1.TabIndex = 0
        ' 
        ' grpReportes
        ' 
        grpReportes.Controls.Add(lstResultadoReporte)
        grpReportes.Controls.Add(lblTotalVespertinoReporte)
        grpReportes.Controls.Add(lblTotalMatutinoReporte)
        grpReportes.Controls.Add(lblTotalBecadosReporte)
        grpReportes.Controls.Add(lblTotalEstudiantesReporte)
        grpReportes.Controls.Add(btnGenerarReporte)
        grpReportes.Controls.Add(Label10)
        grpReportes.Controls.Add(cboTipoReporte)
        grpReportes.Location = New Point(3, 3)
        grpReportes.Name = "grpReportes"
        grpReportes.Size = New Size(514, 414)
        grpReportes.TabIndex = 0
        grpReportes.TabStop = False
        grpReportes.Text = "Reportes"
        ' 
        ' lstResultadoReporte
        ' 
        lstResultadoReporte.FormattingEnabled = True
        lstResultadoReporte.ItemHeight = 25
        lstResultadoReporte.Location = New Point(30, 251)
        lstResultadoReporte.Name = "lstResultadoReporte"
        lstResultadoReporte.Size = New Size(456, 129)
        lstResultadoReporte.TabIndex = 7
        ' 
        ' lblTotalVespertinoReporte
        ' 
        lblTotalVespertinoReporte.AutoSize = True
        lblTotalVespertinoReporte.Location = New Point(313, 199)
        lblTotalVespertinoReporte.Name = "lblTotalVespertinoReporte"
        lblTotalVespertinoReporte.Size = New Size(96, 25)
        lblTotalVespertinoReporte.TabIndex = 6
        lblTotalVespertinoReporte.Text = "Vespertino"
        ' 
        ' lblTotalMatutinoReporte
        ' 
        lblTotalMatutinoReporte.AutoSize = True
        lblTotalMatutinoReporte.Location = New Point(313, 147)
        lblTotalMatutinoReporte.Name = "lblTotalMatutinoReporte"
        lblTotalMatutinoReporte.Size = New Size(84, 25)
        lblTotalMatutinoReporte.TabIndex = 5
        lblTotalMatutinoReporte.Text = "Matutino"
        ' 
        ' lblTotalBecadosReporte
        ' 
        lblTotalBecadosReporte.AutoSize = True
        lblTotalBecadosReporte.Location = New Point(30, 199)
        lblTotalBecadosReporte.Name = "lblTotalBecadosReporte"
        lblTotalBecadosReporte.Size = New Size(78, 25)
        lblTotalBecadosReporte.TabIndex = 4
        lblTotalBecadosReporte.Text = "Becados"
        ' 
        ' lblTotalEstudiantesReporte
        ' 
        lblTotalEstudiantesReporte.AutoSize = True
        lblTotalEstudiantesReporte.Location = New Point(30, 147)
        lblTotalEstudiantesReporte.Name = "lblTotalEstudiantesReporte"
        lblTotalEstudiantesReporte.Size = New Size(144, 25)
        lblTotalEstudiantesReporte.TabIndex = 3
        lblTotalEstudiantesReporte.Text = "Total Estudiantes"
        ' 
        ' btnGenerarReporte
        ' 
        btnGenerarReporte.Location = New Point(160, 89)
        btnGenerarReporte.Name = "btnGenerarReporte"
        btnGenerarReporte.Size = New Size(156, 34)
        btnGenerarReporte.TabIndex = 2
        btnGenerarReporte.Text = "Generar Reporte"
        btnGenerarReporte.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(30, 33)
        Label10.Name = "Label10"
        Label10.Size = New Size(134, 25)
        Label10.TabIndex = 1
        Label10.Text = "Tipo Estudiante"
        ' 
        ' cboTipoReporte
        ' 
        cboTipoReporte.FormattingEnabled = True
        cboTipoReporte.Items.AddRange(New Object() {"Estudiantes por turno", "Estudiantes becados", "Estudiantes por curso", "Cursos con cupo lleno", "Lista de espera"})
        cboTipoReporte.Location = New Point(222, 30)
        cboTipoReporte.Name = "cboTipoReporte"
        cboTipoReporte.Size = New Size(264, 33)
        cboTipoReporte.TabIndex = 0
        ' 
        ' grpObservaciones
        ' 
        grpObservaciones.Controls.Add(btnColorObservaciones)
        grpObservaciones.Controls.Add(btnFuenteObservaciones)
        grpObservaciones.Controls.Add(btnCursiva)
        grpObservaciones.Controls.Add(btnNegrita)
        grpObservaciones.Controls.Add(flpFormatoObservaciones)
        grpObservaciones.Controls.Add(rtbObservaciones)
        grpObservaciones.Location = New Point(3, 3)
        grpObservaciones.Name = "grpObservaciones"
        grpObservaciones.Size = New Size(542, 414)
        grpObservaciones.TabIndex = 0
        grpObservaciones.TabStop = False
        grpObservaciones.Text = "Observaciones"
        ' 
        ' btnColorObservaciones
        ' 
        btnColorObservaciones.Location = New Point(424, 364)
        btnColorObservaciones.Name = "btnColorObservaciones"
        btnColorObservaciones.Size = New Size(112, 34)
        btnColorObservaciones.TabIndex = 5
        btnColorObservaciones.Text = "Color"
        btnColorObservaciones.UseVisualStyleBackColor = True
        ' 
        ' btnFuenteObservaciones
        ' 
        btnFuenteObservaciones.Location = New Point(295, 364)
        btnFuenteObservaciones.Name = "btnFuenteObservaciones"
        btnFuenteObservaciones.Size = New Size(112, 34)
        btnFuenteObservaciones.TabIndex = 4
        btnFuenteObservaciones.Text = "Fuente"
        btnFuenteObservaciones.UseVisualStyleBackColor = True
        ' 
        ' btnCursiva
        ' 
        btnCursiva.Location = New Point(153, 364)
        btnCursiva.Name = "btnCursiva"
        btnCursiva.Size = New Size(112, 34)
        btnCursiva.TabIndex = 3
        btnCursiva.Text = "Cursiva"
        btnCursiva.UseVisualStyleBackColor = True
        ' 
        ' btnNegrita
        ' 
        btnNegrita.Location = New Point(6, 364)
        btnNegrita.Name = "btnNegrita"
        btnNegrita.Size = New Size(112, 34)
        btnNegrita.TabIndex = 2
        btnNegrita.Text = "Negrita"
        btnNegrita.UseVisualStyleBackColor = True
        ' 
        ' flpFormatoObservaciones
        ' 
        flpFormatoObservaciones.Location = New Point(6, 192)
        flpFormatoObservaciones.Name = "flpFormatoObservaciones"
        flpFormatoObservaciones.Size = New Size(530, 150)
        flpFormatoObservaciones.TabIndex = 1
        ' 
        ' rtbObservaciones
        ' 
        rtbObservaciones.Location = New Point(6, 33)
        rtbObservaciones.Name = "rtbObservaciones"
        rtbObservaciones.Size = New Size(530, 153)
        rtbObservaciones.TabIndex = 0
        rtbObservaciones.Text = ""
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {sslEstado, sslTotalEstudiantes, sslTotalCursos, sslCursoSeleccionado})
        StatusStrip1.Location = New Point(0, 749)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1085, 32)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' sslEstado
        ' 
        sslEstado.Name = "sslEstado"
        sslEstado.Size = New Size(66, 25)
        sslEstado.Text = "Estado"
        ' 
        ' sslTotalEstudiantes
        ' 
        sslTotalEstudiantes.Name = "sslTotalEstudiantes"
        sslTotalEstudiantes.Size = New Size(144, 25)
        sslTotalEstudiantes.Text = "Total Estudiantes"
        ' 
        ' sslTotalCursos
        ' 
        sslTotalCursos.Name = "sslTotalCursos"
        sslTotalCursos.Size = New Size(105, 25)
        sslTotalCursos.Text = "Total cursos"
        ' 
        ' sslCursoSeleccionado
        ' 
        sslCursoSeleccionado.Name = "sslCursoSeleccionado"
        sslCursoSeleccionado.Size = New Size(165, 25)
        sslCursoSeleccionado.Text = "Curso seleccionado"
        ' 
        ' epValidacion
        ' 
        epValidacion.ContainerControl = Me
        ' 
        ' ofdImportar
        ' 
        ofdImportar.FileName = "OpenFileDialog1"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(23, 265)
        Label11.Name = "Label11"
        Label11.Size = New Size(146, 25)
        Label11.TabIndex = 11
        Label11.Text = "Estado del Curso"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(22, 224)
        Label12.Name = "Label12"
        Label12.Size = New Size(171, 25)
        Label12.TabIndex = 10
        Label12.Text = "Lugares Disponibles"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(22, 181)
        Label13.Name = "Label13"
        Label13.Size = New Size(78, 25)
        Label13.TabIndex = 9
        Label13.Text = "Inscritos"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(23, 140)
        Label14.Name = "Label14"
        Label14.Size = New Size(78, 25)
        Label14.TabIndex = 8
        Label14.Text = "Creditos"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(22, 101)
        Label15.Name = "Label15"
        Label15.Size = New Size(124, 25)
        Label15.TabIndex = 7
        Label15.Text = "Cupo Maximo"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1085, 781)
        Controls.Add(StatusStrip1)
        Controls.Add(tabPrincipal)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        tabPrincipal.ResumeLayout(False)
        tabEstudiantes.ResumeLayout(False)
        splitEstudiantes.Panel1.ResumeLayout(False)
        splitEstudiantes.Panel2.ResumeLayout(False)
        CType(splitEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        splitEstudiantes.ResumeLayout(False)
        grpRegistroEstudiante.ResumeLayout(False)
        tlpRegistroEstudiante.ResumeLayout(False)
        tlpRegistroEstudiante.PerformLayout()
        grpTurno.ResumeLayout(False)
        grpTurno.PerformLayout()
        flpFiltrosEstudiantes.ResumeLayout(False)
        flpFiltrosEstudiantes.PerformLayout()
        CType(dvgEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        cmsEstudiantes.ResumeLayout(False)
        grpDetalleEstudiante.ResumeLayout(False)
        grpDetalleEstudiante.PerformLayout()
        tabCursos.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        grpInscripcionCurso.ResumeLayout(False)
        grpInscripcionCurso.PerformLayout()
        grpDatosCurso.ResumeLayout(False)
        grpDatosCurso.PerformLayout()
        CType(dgvInscritosCurso, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvListaEspera, ComponentModel.ISupportInitialize).EndInit()
        tabReportes.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        grpReportes.ResumeLayout(False)
        grpReportes.PerformLayout()
        grpObservaciones.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(epValidacion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuArchivo As ToolStripMenuItem
    Friend WithEvents mnuNuevoEstudiante As ToolStripMenuItem
    Friend WithEvents mnuImportar As ToolStripMenuItem
    Friend WithEvents mnuExportar As ToolStripMenuItem
    Friend WithEvents mnuEstudiantes As ToolStripMenuItem
    Friend WithEvents mnuReportes As ToolStripMenuItem
    Friend WithEvents mnuFormato As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuGuardarEstudiante As ToolStripMenuItem
    Friend WithEvents mnuEliminarEstudiante As ToolStripMenuItem
    Friend WithEvents mnuLimpiarEstudiante As ToolStripMenuItem
    Friend WithEvents mnuActualizarReporte As ToolStripMenuItem
    Friend WithEvents mnuReporteBecados As ToolStripMenuItem
    Friend WithEvents mnuReporteTurnos As ToolStripMenuItem
    Friend WithEvents mnuFuente As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents mnuNegrita As ToolStripMenuItem
    Friend WithEvents mnuCursiva As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbImportar As ToolStripButton
    Friend WithEvents tsbExportar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbActualizarReporte As ToolStripButton
    Friend WithEvents tabPrincipal As TabControl
    Friend WithEvents tabEstudiantes As TabPage
    Friend WithEvents tabCursos As TabPage
    Friend WithEvents splitEstudiantes As SplitContainer
    Friend WithEvents grpRegistroEstudiante As GroupBox
    Friend WithEvents tlpRegistroEstudiante As TableLayoutPanel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents grpTurno As GroupBox
    Friend WithEvents rbVespertino As RadioButton
    Friend WithEvents rbMatutino As RadioButton
    Friend WithEvents chkBeca As CheckBox
    Friend WithEvents btnLimpiarEstudiante As Button
    Friend WithEvents btnGuardarEstudiante As Button
    Friend WithEvents flpFiltrosEstudiantes As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBuscarEstudiante As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents cboFiltroTurno As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboFiltroBeca As ComboBox
    Friend WithEvents dvgEstudiantes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents dgvEstudiantes As DataGridView
    Friend WithEvents grpDetalleEstudiante As GroupBox
    Friend WithEvents lblDetalleNombre As Label
    Friend WithEvents lblDetalleApellido As Label
    Friend WithEvents lblDetalleMatricula As Label
    Friend WithEvents lblDetalleTurno As Label
    Friend WithEvents lblDetalleBeca As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents grpInscripcionCurso As GroupBox
    Friend WithEvents grpDatosCurso As GroupBox
    Friend WithEvents lblCupoMaximoValor As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCurso As ComboBox
    Friend WithEvents lblEstadoCurso As Label
    Friend WithEvents lblDisponiblesValor As Label
    Friend WithEvents lblInscritosValor As Label
    Friend WithEvents lblCreditosValor As Label
    Friend WithEvents cboEstudianteCurso As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFechaInscripcion As DateTimePicker
    Friend WithEvents btnAgregarEspera As Button
    Friend WithEvents btnAsignarCurso As Button
    Friend WithEvents dgvInscritosCurso As DataGridView
    Friend WithEvents tabReportes As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grpReportes As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboTipoReporte As ComboBox
    Friend WithEvents lblTotalVespertinoReporte As Label
    Friend WithEvents lblTotalMatutinoReporte As Label
    Friend WithEvents lblTotalBecadosReporte As Label
    Friend WithEvents lblTotalEstudiantesReporte As Label
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents lstResultadoReporte As ListBox
    Friend WithEvents grpObservaciones As GroupBox
    Friend WithEvents rtbObservaciones As RichTextBox
    Friend WithEvents flpFormatoObservaciones As FlowLayoutPanel
    Friend WithEvents btnColorObservaciones As Button
    Friend WithEvents btnFuenteObservaciones As Button
    Friend WithEvents btnCursiva As Button
    Friend WithEvents btnNegrita As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslEstado As ToolStripStatusLabel
    Friend WithEvents sslTotalEstudiantes As ToolStripStatusLabel
    Friend WithEvents sslTotalCursos As ToolStripStatusLabel
    Friend WithEvents sslCursoSeleccionado As ToolStripStatusLabel
    Friend WithEvents epValidacion As ErrorProvider
    Friend WithEvents ofdImportar As OpenFileDialog
    Friend WithEvents sfdExportar As SaveFileDialog
    Friend WithEvents cdObservaciones As ColorDialog
    Friend WithEvents fdObservaciones As FontDialog
    Friend WithEvents cmsEstudiantes As ContextMenuStrip
    Friend WithEvents dgvListaEspera As DataGridView
    Friend WithEvents cmsVerDetalle As ToolStripMenuItem
    Friend WithEvents cmsEditarEstudiante As ToolStripMenuItem
    Friend WithEvents cmsEliminarEstudiante As ToolStripMenuItem
    Friend WithEvents cmsCopiarMatricula As ToolStripMenuItem
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label

End Class
