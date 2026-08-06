Option Strict On
Option Explicit On

Imports System.IO
Imports System.Linq
Imports System.Drawing

Public Class Form1

    Private ReadOnly estudiantes As New List(Of Estudiante)()

    Private ReadOnly cursos As New Dictionary(Of String, Curso)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        splitEstudiantes.Enabled = True
        splitEstudiantes.Panel1.Enabled = True
        splitEstudiantes.Panel2.Enabled = True

        txtBuscarEstudiante.Enabled = True
        cboFiltroTurno.Enabled = True
        cboFiltroBeca.Enabled = True
        dgvEstudiantes.Enabled = True
        grpDetalleEstudiante.Enabled = True

        ConfigurarFormulario()
        ConfigurarCursos()
        ConfigurarFiltros()
        ConfigurarReportes()
        ConfigurarDataGridView()

        ActualizarTodo()

    End Sub

    ' =====================================================
    ' CONFIGURACIÓN INICIAL
    ' =====================================================

    Private Sub ConfigurarFormulario()

        btnGuardarEstudiante.Enabled = False

        cboFiltroTurno.DropDownStyle = ComboBoxStyle.DropDownList
        cboFiltroBeca.DropDownStyle = ComboBoxStyle.DropDownList
        cboCurso.DropDownStyle = ComboBoxStyle.DropDownList
        cboEstudianteCurso.DropDownStyle = ComboBoxStyle.DropDownList
        cboTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList

        dtpFechaInscripcion.MaxDate = Date.Today
        dtpFechaInscripcion.Value = Date.Today

        dgvEstudiantes.ContextMenuStrip = cmsEstudiantes

        ofdImportar.Filter =
            "Archivos de texto (*.txt)|*.txt|" &
            "Todos los archivos (*.*)|*.*"

        ofdImportar.Title = "Importar estudiantes"

        sfdExportar.Filter =
            "Archivos de texto (*.txt)|*.txt"

        sfdExportar.Title = "Exportar estudiantes"
        sfdExportar.DefaultExt = "txt"
        sfdExportar.AddExtension = True

        sslEstado.Text = "Estado: Listo"
        sslTotalEstudiantes.Text = "Total estudiantes: 0"
        sslTotalCursos.Text = "Total cursos: 0"
        sslCursoSeleccionado.Text =
            "Curso seleccionado: Ninguno"

    End Sub

    Private Sub ConfigurarCursos()

        cursos.Clear()

        cursos.Add(
            "Programación Visual",
            New Curso("Programación Visual", 3, 8)
        )

        cursos.Add(
            "Base de Datos",
            New Curso("Base de Datos", 4, 7)
        )

        cursos.Add(
            "Redes",
            New Curso("Redes", 3, 6)
        )

        cursos.Add(
            "Sistemas Operativos",
            New Curso("Sistemas Operativos", 5, 7)
        )

        cursos.Add(
            "Ingeniería de Software",
            New Curso("Ingeniería de Software", 4, 8)
        )

        cboCurso.DataSource = Nothing
        cboCurso.DataSource = cursos.Values.ToList()
        cboCurso.DisplayMember = NameOf(Curso.Nombre)
        cboCurso.SelectedIndex = -1

    End Sub

    Private Sub ConfigurarFiltros()

        cboFiltroTurno.Items.Clear()
        cboFiltroTurno.Items.Add("Todos")
        cboFiltroTurno.Items.Add("Matutino")
        cboFiltroTurno.Items.Add("Vespertino")
        cboFiltroTurno.SelectedIndex = 0

        cboFiltroBeca.Items.Clear()
        cboFiltroBeca.Items.Add("Todos")
        cboFiltroBeca.Items.Add("Con beca")
        cboFiltroBeca.Items.Add("Sin beca")
        cboFiltroBeca.SelectedIndex = 0

    End Sub

    Private Sub ConfigurarReportes()

        cboTipoReporte.Items.Clear()
        cboTipoReporte.Items.Add("Estudiantes por turno")
        cboTipoReporte.Items.Add("Estudiantes becados")
        cboTipoReporte.Items.Add("Estudiantes por curso")
        cboTipoReporte.Items.Add("Cursos con cupo lleno")
        cboTipoReporte.Items.Add("Lista de espera")
        cboTipoReporte.SelectedIndex = 0

    End Sub

    Private Sub ConfigurarDataGridView()

        dgvEstudiantes.AutoGenerateColumns = True
        dgvEstudiantes.ReadOnly = True
        dgvEstudiantes.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect
        dgvEstudiantes.MultiSelect = False
        dgvEstudiantes.AllowUserToAddRows = False

        dgvInscritosCurso.AutoGenerateColumns = True
        dgvInscritosCurso.ReadOnly = True
        dgvInscritosCurso.AllowUserToAddRows = False

        dgvListaEspera.AutoGenerateColumns = True
        dgvListaEspera.ReadOnly = True
        dgvListaEspera.AllowUserToAddRows = False

    End Sub

    ' =====================================================
    ' VALIDACIÓN DEL FORMULARIO
    ' =====================================================

    Private Sub DatosEstudiante_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtNombre.TextChanged,
              txtApellido.TextChanged,
              txtMatricula.TextChanged

        ValidarFormularioEnTiempoReal()

    End Sub

    Private Sub Turno_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles rbMatutino.CheckedChanged,
              rbVespertino.CheckedChanged

        ValidarFormularioEnTiempoReal()

    End Sub

    Private Sub ValidarFormularioEnTiempoReal()

        Dim nombreValido As Boolean =
            Not String.IsNullOrWhiteSpace(txtNombre.Text)

        Dim apellidoValido As Boolean =
            Not String.IsNullOrWhiteSpace(txtApellido.Text)

        Dim matriculaLimpia As String =
            txtMatricula.Text.Trim()

        Dim matriculaValida As Boolean =
            matriculaLimpia.Length >= 4 AndAlso
            matriculaLimpia.All(
                Function(caracter As Char)
                    Return Char.IsLetterOrDigit(caracter) OrElse
                           caracter = "-"c
                End Function
            )

        Dim turnoValido As Boolean =
            rbMatutino.Checked OrElse rbVespertino.Checked

        btnGuardarEstudiante.Enabled =
            nombreValido AndAlso
            apellidoValido AndAlso
            matriculaValida AndAlso
            turnoValido

    End Sub

    Private Function ValidarEstudiante() As Boolean

        epValidacion.Clear()

        Dim valido As Boolean = True

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            epValidacion.SetError(
                txtNombre,
                "Escribe el nombre del estudiante."
            )
            valido = False
        End If

        If String.IsNullOrWhiteSpace(txtApellido.Text) Then
            epValidacion.SetError(
                txtApellido,
                "Escribe el apellido del estudiante."
            )
            valido = False
        End If

        Dim matricula As String = txtMatricula.Text.Trim()

        If String.IsNullOrWhiteSpace(matricula) Then

            epValidacion.SetError(
                txtMatricula,
                "Escribe la matrícula."
            )

            valido = False

        ElseIf matricula.Length < 4 Then

            epValidacion.SetError(
                txtMatricula,
                "La matrícula debe tener al menos 4 caracteres."
            )

            valido = False

        ElseIf Not matricula.All(
            Function(caracter As Char)
                Return Char.IsLetterOrDigit(caracter) OrElse
                       caracter = "-"c
            End Function
        ) Then

            epValidacion.SetError(
                txtMatricula,
                "Usa únicamente letras, números o guiones."
            )

            valido = False

        End If

        If Not rbMatutino.Checked AndAlso
           Not rbVespertino.Checked Then

            epValidacion.SetError(
                grpTurno,
                "Selecciona un turno."
            )

            valido = False

        End If

        Dim matriculaRepetida As Boolean =
            estudiantes.Any(
                Function(estudiante As Estudiante)
                    Return estudiante.Matricula.Equals(
                        matricula,
                        StringComparison.OrdinalIgnoreCase
                    )
                End Function
            )

        If matriculaRepetida Then
            epValidacion.SetError(
                txtMatricula,
                "Ya existe un estudiante con esa matrícula."
            )

            valido = False
        End If

        Return valido

    End Function

    ' =====================================================
    ' GUARDAR ESTUDIANTE
    ' =====================================================

    Private Sub btnGuardarEstudiante_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGuardarEstudiante.Click

        GuardarEstudiante()

    End Sub

    Private Sub GuardarEstudiante()

        If Not ValidarEstudiante() Then

            sslEstado.Text =
                "Estado: Corrige los campos marcados"

            Return
        End If

        Try
            Dim turno As String

            If rbMatutino.Checked Then
                turno = "Matutino"
            Else
                turno = "Vespertino"
            End If

            Dim nuevoEstudiante As New Estudiante(
                txtNombre.Text,
                txtApellido.Text,
                txtMatricula.Text,
                turno,
                chkBeca.Checked
            )

            estudiantes.Add(nuevoEstudiante)

            sslEstado.Text =
                "Estado: Estudiante registrado correctamente"

            LimpiarFormularioEstudiante()
            ActualizarTodo()

        Catch ex As ArgumentException

            MessageBox.Show(
                ex.Message,
                "Datos inválidos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo registrar al estudiante: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnLimpiarEstudiante_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLimpiarEstudiante.Click

        LimpiarFormularioEstudiante()

    End Sub

    Private Sub LimpiarFormularioEstudiante()

        txtNombre.Clear()
        txtApellido.Clear()
        txtMatricula.Clear()

        rbMatutino.Checked = False
        rbVespertino.Checked = False
        chkBeca.Checked = False

        epValidacion.Clear()

        btnGuardarEstudiante.Enabled = False

        txtNombre.Focus()

    End Sub

    ' =====================================================
    ' LISTADO Y FILTROS
    ' =====================================================

    Private Sub FiltrosCambiaron(
        sender As Object,
        e As EventArgs
    ) Handles txtBuscarEstudiante.TextChanged,
              cboFiltroTurno.SelectedIndexChanged,
              cboFiltroBeca.SelectedIndexChanged

        ActualizarListadoEstudiantes()

    End Sub

    Private Sub ActualizarListadoEstudiantes()

        Dim consulta As IEnumerable(Of Estudiante) =
            estudiantes.AsEnumerable()

        Dim textoBusqueda As String =
            txtBuscarEstudiante.Text.Trim()

        If textoBusqueda <> String.Empty Then

            consulta =
                consulta.Where(
                    Function(estudiante As Estudiante)

                        Return estudiante.Nombre.Contains(
                                   textoBusqueda,
                                   StringComparison.OrdinalIgnoreCase
                               ) OrElse
                               estudiante.Apellido.Contains(
                                   textoBusqueda,
                                   StringComparison.OrdinalIgnoreCase
                               ) OrElse
                               estudiante.Matricula.Contains(
                                   textoBusqueda,
                                   StringComparison.OrdinalIgnoreCase
                               )

                    End Function
                )

        End If

        If cboFiltroTurno.SelectedItem IsNot Nothing Then

            Dim filtroTurno As String =
                cboFiltroTurno.SelectedItem.ToString()

            If filtroTurno <> "Todos" Then

                consulta =
                    consulta.Where(
                        Function(estudiante As Estudiante)
                            Return estudiante.Turno = filtroTurno
                        End Function
                    )

            End If

        End If

        If cboFiltroBeca.SelectedItem IsNot Nothing Then

            Dim filtroBeca As String =
                cboFiltroBeca.SelectedItem.ToString()

            If filtroBeca = "Con beca" Then

                consulta =
                    consulta.Where(
                        Function(estudiante As Estudiante)
                            Return estudiante.TieneBeca
                        End Function
                    )

            ElseIf filtroBeca = "Sin beca" Then

                consulta =
                    consulta.Where(
                        Function(estudiante As Estudiante)
                            Return Not estudiante.TieneBeca
                        End Function
                    )

            End If

        End If

        dgvEstudiantes.DataSource = Nothing
        dgvEstudiantes.DataSource =
            consulta.OrderBy(
                Function(estudiante As Estudiante)
                    Return estudiante.Apellido
                End Function
            ).ToList()

    End Sub

    Private Sub dgvEstudiantes_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvEstudiantes.SelectionChanged

        MostrarDetalleSeleccionado()

    End Sub

    Private Sub MostrarDetalleSeleccionado()

        Dim estudiante As Estudiante =
            ObtenerEstudianteSeleccionado()

        If estudiante Is Nothing Then

            lblDetalleNombre.Text = "Nombre: --"
            lblDetalleApellido.Text = "Apellido: --"
            lblDetalleMatricula.Text = "Matrícula: --"
            lblDetalleTurno.Text = "Turno: --"
            lblDetalleBeca.Text = "Beca: --"

            Return
        End If

        lblDetalleNombre.Text =
            "Nombre: " & estudiante.Nombre

        lblDetalleApellido.Text =
            "Apellido: " & estudiante.Apellido

        lblDetalleMatricula.Text =
            "Matrícula: " & estudiante.Matricula

        lblDetalleTurno.Text =
            "Turno: " & estudiante.Turno

        If estudiante.TieneBeca Then
            lblDetalleBeca.Text = "Beca: Sí"
        Else
            lblDetalleBeca.Text = "Beca: No"
        End If

    End Sub

    Private Function ObtenerEstudianteSeleccionado() As Estudiante

        If dgvEstudiantes.CurrentRow Is Nothing Then
            Return Nothing
        End If

        Return TryCast(
            dgvEstudiantes.CurrentRow.DataBoundItem,
            Estudiante
        )

    End Function

    ' =====================================================
    ' ELIMINAR ESTUDIANTE
    ' =====================================================

    Private Sub EliminarEstudianteSeleccionado()

        Dim estudiante As Estudiante =
            ObtenerEstudianteSeleccionado()

        If estudiante Is Nothing Then

            MessageBox.Show(
                "Selecciona un estudiante.",
                "Sin selección",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return
        End If

        Dim estaInscrito As Boolean =
            cursos.Values.Any(
                Function(curso As Curso)
                    Return curso.Inscripciones.Any(
                        Function(inscripcion As Inscripcion)
                            Return inscripcion.Estudiante.Matricula =
                                   estudiante.Matricula
                        End Function
                    )
                End Function
            )

        If estaInscrito Then

            MessageBox.Show(
                "El estudiante está inscrito en un curso y no puede eliminarse.",
                "Operación no permitida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return
        End If

        Dim respuesta As DialogResult =
            MessageBox.Show(
                "¿Deseas eliminar a " &
                estudiante.NombreCompleto & "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If respuesta <> DialogResult.Yes Then
            Return
        End If

        estudiantes.Remove(estudiante)

        sslEstado.Text =
            "Estado: Estudiante eliminado"

        ActualizarTodo()

    End Sub

    ' =====================================================
    ' CURSOS
    ' =====================================================

    Private Sub cboCurso_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cboCurso.SelectedIndexChanged

        ActualizarCursoSeleccionado()

    End Sub

    Private Function ObtenerCursoSeleccionado() As Curso

        Return TryCast(cboCurso.SelectedItem, Curso)

    End Function

    Private Sub ActualizarCursoSeleccionado()

        Dim curso As Curso =
            ObtenerCursoSeleccionado()

        If curso Is Nothing Then

            lblCupoMaximoValor.Text = "--"
            lblCreditosValor.Text = "--"
            lblInscritosValor.Text = "--"
            lblDisponiblesValor.Text = "--"
            lblEstadoCurso.Text = "Selecciona un curso"

            sslCursoSeleccionado.Text =
                "Curso seleccionado: Ninguno"

            dgvInscritosCurso.DataSource = Nothing
            dgvListaEspera.DataSource = Nothing

            btnAsignarCurso.Enabled = False
            btnAgregarEspera.Enabled = False

            Return
        End If

        lblCupoMaximoValor.Text =
            curso.CupoMaximo.ToString()

        lblCreditosValor.Text =
            curso.Creditos.ToString()

        lblInscritosValor.Text =
            curso.TotalInscritos.ToString()

        lblDisponiblesValor.Text =
            curso.LugaresDisponibles.ToString()

        sslCursoSeleccionado.Text =
            "Curso seleccionado: " & curso.Nombre

        If curso.EstaLleno Then

            lblEstadoCurso.Text = "Cupo lleno"
            btnAsignarCurso.Enabled = False
            btnAgregarEspera.Enabled = True

        Else

            lblEstadoCurso.Text = "Cupo disponible"
            btnAsignarCurso.Enabled = True
            btnAgregarEspera.Enabled = False

        End If

        ActualizarListadosCurso(curso)

    End Sub

    Private Sub ActualizarComboEstudiantesCurso()

        cboEstudianteCurso.DataSource = Nothing
        cboEstudianteCurso.DataSource =
            estudiantes.OrderBy(
                Function(estudiante As Estudiante)
                    Return estudiante.Apellido
                End Function
            ).ToList()

        cboEstudianteCurso.SelectedIndex = -1

    End Sub

    Private Sub btnAsignarCurso_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAsignarCurso.Click

        Dim curso As Curso =
            ObtenerCursoSeleccionado()

        Dim estudiante As Estudiante =
            TryCast(cboEstudianteCurso.SelectedItem, Estudiante)

        epValidacion.Clear()

        If curso Is Nothing Then

            epValidacion.SetError(
                cboCurso,
                "Selecciona un curso."
            )

            Return
        End If

        If estudiante Is Nothing Then

            epValidacion.SetError(
                cboEstudianteCurso,
                "Selecciona un estudiante."
            )

            Return
        End If

        If dtpFechaInscripcion.Value.Date > Date.Today Then

            epValidacion.SetError(
                dtpFechaInscripcion,
                "La fecha no puede ser futura."
            )

            Return
        End If

        Try
            Dim resultado As ResultadoAsignacion =
                curso.AsignarEstudiante(
                    estudiante,
                    dtpFechaInscripcion.Value.Date
                )

            Select Case resultado

                Case ResultadoAsignacion.Inscrito

                    sslEstado.Text =
                        "Estado: Estudiante asignado al curso"

                Case ResultadoAsignacion.CursoLleno

                    Dim respuesta As DialogResult =
                        MessageBox.Show(
                            "El curso llegó a su cupo máximo." &
                            Environment.NewLine &
                            "¿Deseas agregar al estudiante a la lista de espera?",
                            "Curso lleno",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        )

                    If respuesta = DialogResult.Yes Then
                        AgregarEstudianteAEspera(
                            curso,
                            estudiante
                        )
                    End If

                Case ResultadoAsignacion.YaInscrito

                    MessageBox.Show(
                        "El estudiante ya está inscrito en este curso.",
                        "Registro duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )

            End Select

            ActualizarTodo()
            cboCurso.SelectedItem = curso

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo realizar la inscripción: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnAgregarEspera_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAgregarEspera.Click

        Dim curso As Curso =
            ObtenerCursoSeleccionado()

        Dim estudiante As Estudiante =
            TryCast(cboEstudianteCurso.SelectedItem, Estudiante)

        If curso Is Nothing OrElse estudiante Is Nothing Then

            MessageBox.Show(
                "Selecciona un curso y un estudiante.",
                "Datos incompletos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return
        End If

        AgregarEstudianteAEspera(curso, estudiante)
        ActualizarTodo()
        cboCurso.SelectedItem = curso

    End Sub

    Private Sub AgregarEstudianteAEspera(
        curso As Curso,
        estudiante As Estudiante
    )

        If curso.AgregarAListaEspera(estudiante) Then

            sslEstado.Text =
                "Estado: Estudiante agregado a lista de espera"

        Else

            MessageBox.Show(
                "El estudiante ya está inscrito o ya está en espera.",
                "No se pudo agregar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        End If

    End Sub

    Private Sub ActualizarListadosCurso(curso As Curso)

        dgvInscritosCurso.DataSource = Nothing

        dgvInscritosCurso.DataSource =
            curso.Inscripciones.Select(
                Function(inscripcion As Inscripcion)

                    Return New With {
                        .Matricula =
                            inscripcion.Estudiante.Matricula,
                        .Nombre =
                            inscripcion.Estudiante.NombreCompleto,
                        .Turno =
                            inscripcion.Estudiante.Turno,
                        .Fecha =
                            inscripcion.FechaInscripcion.ToShortDateString()
                    }

                End Function
            ).ToList()

        dgvListaEspera.DataSource = Nothing

        dgvListaEspera.DataSource =
            curso.ListaEspera.Select(
                Function(estudiante As Estudiante)

                    Return New With {
                        .Matricula = estudiante.Matricula,
                        .Nombre = estudiante.NombreCompleto,
                        .Turno = estudiante.Turno
                    }

                End Function
            ).ToList()

    End Sub

    ' =====================================================
    ' REPORTES CON LINQ
    ' =====================================================

    Private Sub btnGenerarReporte_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGenerarReporte.Click

        GenerarReporte()

    End Sub

    Private Sub GenerarReporte()

        lstResultadoReporte.Items.Clear()

        ActualizarResumenReportes()

        If cboTipoReporte.SelectedItem Is Nothing Then
            Return
        End If

        Dim tipoReporte As String =
            cboTipoReporte.SelectedItem.ToString()

        Select Case tipoReporte

            Case "Estudiantes por turno"

                Dim gruposPorTurno =
                    estudiantes.GroupBy(
                        Function(estudiante As Estudiante)
                            Return estudiante.Turno
                        End Function
                    )

                For Each grupo In gruposPorTurno

                    lstResultadoReporte.Items.Add(
                        grupo.Key & ": " &
                        grupo.Count().ToString()
                    )

                    For Each estudiante As Estudiante In grupo

                        lstResultadoReporte.Items.Add(
                            "   " &
                            estudiante.Matricula &
                            " - " &
                            estudiante.NombreCompleto
                        )

                    Next

                Next

            Case "Estudiantes becados"

                Dim becados As List(Of Estudiante) =
                    estudiantes.Where(
                        Function(estudiante As Estudiante)
                            Return estudiante.TieneBeca
                        End Function
                    ).OrderBy(
                        Function(estudiante As Estudiante)
                            Return estudiante.Apellido
                        End Function
                    ).ToList()

                If becados.Count = 0 Then
                    lstResultadoReporte.Items.Add(
                        "No existen estudiantes becados."
                    )
                Else
                    For Each estudiante As Estudiante In becados
                        lstResultadoReporte.Items.Add(
                            estudiante.ObtenerDescripcion()
                        )
                    Next
                End If

            Case "Estudiantes por curso"

                For Each curso As Curso In cursos.Values

                    lstResultadoReporte.Items.Add(
                        curso.Nombre & ": " &
                        curso.TotalInscritos.ToString() &
                        " inscritos"
                    )

                Next

            Case "Cursos con cupo lleno"

                Dim cursosLlenos As List(Of Curso) =
                    cursos.Values.Where(
                        Function(curso As Curso)
                            Return curso.EstaLleno
                        End Function
                    ).ToList()

                If cursosLlenos.Count = 0 Then

                    lstResultadoReporte.Items.Add(
                        "Ningún curso ha alcanzado su cupo."
                    )

                Else

                    For Each curso As Curso In cursosLlenos

                        lstResultadoReporte.Items.Add(
                            curso.Nombre &
                            " - Cupo: " &
                            curso.CupoMaximo.ToString()
                        )

                    Next

                End If

            Case "Lista de espera"

                For Each curso As Curso In cursos.Values

                    lstResultadoReporte.Items.Add(
                        curso.Nombre & ": " &
                        curso.ListaEspera.Count.ToString() &
                        " en espera"
                    )

                Next

        End Select

        sslEstado.Text = "Estado: Reporte generado"

    End Sub

    Private Sub ActualizarResumenReportes()

        Dim totalBecados As Integer =
        estudiantes.Where(
            Function(estudiante As Estudiante)
                Return estudiante.TieneBeca
            End Function
        ).Count()

        Dim totalMatutino As Integer =
        estudiantes.Where(
            Function(estudiante As Estudiante)
                Return estudiante.Turno = "Matutino"
            End Function
        ).Count()

        Dim totalVespertino As Integer =
        estudiantes.Where(
            Function(estudiante As Estudiante)
                Return estudiante.Turno = "Vespertino"
            End Function
        ).Count()

        lblTotalEstudiantesReporte.Text =
        "Total estudiantes: " & estudiantes.Count.ToString()

        lblTotalBecadosReporte.Text =
        "Becados: " & totalBecados.ToString()

        lblTotalMatutinoReporte.Text =
        "Matutino: " & totalMatutino.ToString()

        lblTotalVespertinoReporte.Text =
        "Vespertino: " & totalVespertino.ToString()

    End Sub

    ' =====================================================
    ' IMPORTAR Y EXPORTAR
    ' =====================================================

    Private Sub ExportarEstudiantes()

        If estudiantes.Count = 0 Then

            MessageBox.Show(
                "No hay estudiantes para exportar.",
                "Sin información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return
        End If

        If sfdExportar.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Try

            Using escritor As New StreamWriter(
                sfdExportar.FileName,
                False,
                System.Text.Encoding.UTF8
            )

                For Each estudiante As Estudiante In estudiantes

                    escritor.WriteLine(
                        estudiante.Nombre & "|" &
                        estudiante.Apellido & "|" &
                        estudiante.Matricula & "|" &
                        estudiante.Turno & "|" &
                        estudiante.TieneBeca.ToString()
                    )

                Next

            End Using

            sslEstado.Text =
                "Estado: Estudiantes exportados correctamente"

            MessageBox.Show(
                "El listado se exportó correctamente.",
                "Exportación terminada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As UnauthorizedAccessException

            MessageBox.Show(
                "No tienes permiso para guardar en esa ubicación.",
                "Acceso denegado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As IOException

            MessageBox.Show(
                "No se pudo escribir el archivo: " &
                ex.Message,
                "Error de archivo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception

            MessageBox.Show(
                "Error al exportar: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub ImportarEstudiantes()

        If ofdImportar.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim importados As Integer = 0
        Dim omitidos As Integer = 0

        Try

            Using lector As New StreamReader(
                ofdImportar.FileName,
                System.Text.Encoding.UTF8
            )

                While Not lector.EndOfStream

                    Dim linea As String = lector.ReadLine()

                    If String.IsNullOrWhiteSpace(linea) Then
                        Continue While
                    End If

                    Dim partes() As String =
                        linea.Split("|"c)

                    If partes.Length <> 5 Then
                        omitidos += 1
                        Continue While
                    End If

                    Dim tieneBeca As Boolean

                    If Not Boolean.TryParse(
                        partes(4),
                        tieneBeca
                    ) Then
                        omitidos += 1
                        Continue While
                    End If

                    Dim matriculaDuplicada As Boolean =
                        estudiantes.Any(
                            Function(estudiante As Estudiante)
                                Return estudiante.Matricula.Equals(
                                    partes(2),
                                    StringComparison.OrdinalIgnoreCase
                                )
                            End Function
                        )

                    If matriculaDuplicada Then
                        omitidos += 1
                        Continue While
                    End If

                    Try

                        Dim estudianteImportado As New Estudiante(
                            partes(0),
                            partes(1),
                            partes(2),
                            partes(3),
                            tieneBeca
                        )

                        estudiantes.Add(estudianteImportado)
                        importados += 1

                    Catch ex As ArgumentException
                        omitidos += 1
                    End Try

                End While

            End Using

            ActualizarTodo()

            MessageBox.Show(
                "Importados: " & importados.ToString() &
                Environment.NewLine &
                "Omitidos: " & omitidos.ToString(),
                "Importación finalizada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            sslEstado.Text =
                "Estado: Importación finalizada"

        Catch ex As FileNotFoundException

            MessageBox.Show(
                "El archivo seleccionado ya no existe.",
                "Archivo no encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As IOException

            MessageBox.Show(
                "No se pudo leer el archivo: " &
                ex.Message,
                "Error de archivo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception

            MessageBox.Show(
                "Error al importar: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =====================================================
    ' OBSERVACIONES: FUENTE Y COLOR
    ' =====================================================

    Private Sub btnFuenteObservaciones_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFuenteObservaciones.Click

        CambiarFuenteObservaciones()

    End Sub

    Private Sub CambiarFuenteObservaciones()

        If rtbObservaciones.SelectionLength = 0 Then

            MessageBox.Show(
                "Selecciona el texto que deseas modificar.",
                "Sin selección",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return
        End If

        If rtbObservaciones.SelectionFont IsNot Nothing Then
            fdObservaciones.Font =
                rtbObservaciones.SelectionFont
        End If

        If fdObservaciones.ShowDialog() =
           DialogResult.OK Then

            rtbObservaciones.SelectionFont =
                fdObservaciones.Font

        End If

    End Sub

    Private Sub btnColorObservaciones_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnColorObservaciones.Click

        CambiarColorObservaciones()

    End Sub

    Private Sub CambiarColorObservaciones()

        If rtbObservaciones.SelectionLength = 0 Then

            MessageBox.Show(
                "Selecciona el texto que deseas colorear.",
                "Sin selección",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return
        End If

        cdObservaciones.Color =
            rtbObservaciones.SelectionColor

        If cdObservaciones.ShowDialog() =
           DialogResult.OK Then

            rtbObservaciones.SelectionColor =
                cdObservaciones.Color

        End If

    End Sub

    Private Sub btnNegrita_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNegrita.Click

        AlternarEstilo(FontStyle.Bold)

    End Sub

    Private Sub btnCursiva_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCursiva.Click

        AlternarEstilo(FontStyle.Italic)

    End Sub

    Private Sub AlternarEstilo(estilo As FontStyle)

        If rtbObservaciones.SelectionLength = 0 Then

            MessageBox.Show(
                "Selecciona el texto que deseas modificar.",
                "Sin selección",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return
        End If

        Dim fuenteActual As Font =
            rtbObservaciones.SelectionFont

        If fuenteActual Is Nothing Then

            MessageBox.Show(
                "La selección contiene diferentes tipos de fuente.",
                "Formato mixto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return
        End If

        Dim nuevoEstilo As FontStyle =
            fuenteActual.Style Xor estilo

        rtbObservaciones.SelectionFont =
            New Font(fuenteActual, nuevoEstilo)

    End Sub

    ' =====================================================
    ' MENÚS
    ' =====================================================

    Private Sub mnuNuevoEstudiante_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuNuevoEstudiante.Click

        tabPrincipal.SelectedTab = tabEstudiantes
        LimpiarFormularioEstudiante()

    End Sub

    Private Sub mnuImportar_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuImportar.Click

        ImportarEstudiantes()

    End Sub

    Private Sub mnuExportar_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuExportar.Click

        ExportarEstudiantes()

    End Sub

    Private Sub mnuSalir_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuSalir.Click

        Me.Close()

    End Sub

    Private Sub mnuGuardarEstudiante_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuGuardarEstudiante.Click

        GuardarEstudiante()

    End Sub

    Private Sub mnuEliminarEstudiante_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuEliminarEstudiante.Click

        EliminarEstudianteSeleccionado()

    End Sub

    Private Sub mnuLimpiarEstudiante_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuLimpiarEstudiante.Click

        LimpiarFormularioEstudiante()

    End Sub

    Private Sub mnuActualizarReporte_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuActualizarReporte.Click

        tabPrincipal.SelectedTab = tabReportes
        GenerarReporte()

    End Sub

    Private Sub mnuReporteBecados_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuReporteBecados.Click

        tabPrincipal.SelectedTab = tabReportes
        cboTipoReporte.SelectedItem =
            "Estudiantes becados"

        GenerarReporte()

    End Sub

    Private Sub mnuReporteTurnos_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuReporteTurnos.Click

        tabPrincipal.SelectedTab = tabReportes
        cboTipoReporte.SelectedItem =
            "Estudiantes por turno"

        GenerarReporte()

    End Sub

    Private Sub mnuFuente_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuFuente.Click

        CambiarFuenteObservaciones()

    End Sub

    Private Sub mnuColor_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuColor.Click

        CambiarColorObservaciones()

    End Sub

    Private Sub mnuNegrita_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuNegrita.Click

        AlternarEstilo(FontStyle.Bold)

    End Sub

    Private Sub mnuCursiva_Click(
        sender As Object,
        e As EventArgs
    ) Handles mnuCursiva.Click

        AlternarEstilo(FontStyle.Italic)

    End Sub

    ' =====================================================
    ' TOOLSTRIP
    ' =====================================================

    Private Sub tsbNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles tsbNuevo.Click

        tabPrincipal.SelectedTab = tabEstudiantes
        LimpiarFormularioEstudiante()

    End Sub

    Private Sub tsbGuardar_Click(
        sender As Object,
        e As EventArgs
    ) Handles tsbGuardar.Click

        GuardarEstudiante()

    End Sub

    Private Sub tsbImportar_Click(
        sender As Object,
        e As EventArgs
    ) Handles tsbImportar.Click

        ImportarEstudiantes()

    End Sub

    Private Sub tsbExportar_Click(
        sender As Object,
        e As EventArgs
    ) Handles tsbExportar.Click

        ExportarEstudiantes()

    End Sub

    Private Sub tsbActualizarReporte_Click(
        sender As Object,
        e As EventArgs
    ) Handles tsbActualizarReporte.Click

        tabPrincipal.SelectedTab = tabReportes
        GenerarReporte()

    End Sub

    ' =====================================================
    ' CONTEXT MENU DEL DATAGRIDVIEW
    ' =====================================================

    Private Sub cmsVerDetalle_Click(
        sender As Object,
        e As EventArgs
    ) Handles cmsVerDetalle.Click

        MostrarDetalleSeleccionado()

    End Sub

    Private Sub cmsEliminarEstudiante_Click(
        sender As Object,
        e As EventArgs
    ) Handles cmsEliminarEstudiante.Click

        EliminarEstudianteSeleccionado()

    End Sub

    Private Sub cmsCopiarMatricula_Click(
        sender As Object,
        e As EventArgs
    ) Handles cmsCopiarMatricula.Click

        Dim estudiante As Estudiante =
            ObtenerEstudianteSeleccionado()

        If estudiante Is Nothing Then
            Return
        End If

        Clipboard.SetText(estudiante.Matricula)

        sslEstado.Text =
            "Estado: Matrícula copiada"

    End Sub

    Private Sub cmsEditarEstudiante_Click(
        sender As Object,
        e As EventArgs
    ) Handles cmsEditarEstudiante.Click

        Dim estudiante As Estudiante =
            ObtenerEstudianteSeleccionado()

        If estudiante Is Nothing Then
            Return
        End If

        txtNombre.Text = estudiante.Nombre
        txtApellido.Text = estudiante.Apellido
        txtMatricula.Text = estudiante.Matricula
        chkBeca.Checked = estudiante.TieneBeca

        rbMatutino.Checked =
            estudiante.Turno = "Matutino"

        rbVespertino.Checked =
            estudiante.Turno = "Vespertino"

        estudiantes.Remove(estudiante)

        tabPrincipal.SelectedTab = tabEstudiantes
        txtNombre.Focus()

        ActualizarTodo()

        sslEstado.Text =
            "Estado: Modifica los datos y vuelve a guardar"

    End Sub

    ' =====================================================
    ' ACTUALIZACIÓN GENERAL
    ' =====================================================

    Private Sub ActualizarTodo()

        ActualizarListadoEstudiantes()
        ActualizarComboEstudiantesCurso()
        ActualizarCursoSeleccionado()
        ActualizarResumenReportes()

        sslTotalEstudiantes.Text =
            "Total estudiantes: " &
            estudiantes.Count.ToString()

        sslTotalCursos.Text =
            "Total cursos: " &
            cursos.Count.ToString()

    End Sub


End Class