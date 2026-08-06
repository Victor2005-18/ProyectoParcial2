Option Strict On
Option Explicit On

Public Enum ResultadoAsignacion
    Inscrito
    CursoLleno
    YaInscrito
End Enum

Public Class Curso

    Private _nombre As String
    Private _cupoMaximo As Integer
    Private _creditos As Integer

    Public Sub New(
        nombre As String,
        cupoMaximo As Integer,
        creditos As Integer
    )
        Me.Nombre = nombre
        Me.CupoMaximo = cupoMaximo
        Me.Creditos = creditos

        Inscripciones = New List(Of Inscripcion)()
        ListaEspera = New Queue(Of Estudiante)()
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)

            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException(
                    "El nombre del curso no puede estar vacío."
                )
            End If

            _nombre = value.Trim()
        End Set
    End Property

    Public Property CupoMaximo As Integer
        Get
            Return _cupoMaximo
        End Get
        Set(value As Integer)

            If value <= 0 Then
                Throw New ArgumentOutOfRangeException(
                    NameOf(CupoMaximo),
                    "El cupo máximo debe ser mayor que cero."
                )
            End If

            _cupoMaximo = value
        End Set
    End Property

    Public Property Creditos As Integer
        Get
            Return _creditos
        End Get
        Set(value As Integer)

            If value <= 0 Then
                Throw New ArgumentOutOfRangeException(
                    NameOf(Creditos),
                    "Los créditos deben ser mayores que cero."
                )
            End If

            _creditos = value
        End Set
    End Property

    Public ReadOnly Property Inscripciones As List(Of Inscripcion)

    Public ReadOnly Property ListaEspera As Queue(Of Estudiante)

    Public ReadOnly Property TotalInscritos As Integer
        Get
            Return Inscripciones.Count
        End Get
    End Property

    Public ReadOnly Property LugaresDisponibles As Integer
        Get
            Return CupoMaximo - TotalInscritos
        End Get
    End Property

    Public ReadOnly Property EstaLleno As Boolean
        Get
            Return TotalInscritos >= CupoMaximo
        End Get
    End Property

    Public Function AsignarEstudiante(
        estudiante As Estudiante,
        fechaInscripcion As Date
    ) As ResultadoAsignacion

        Dim yaInscrito As Boolean =
            Inscripciones.Any(
                Function(inscripcion As Inscripcion)
                    Return inscripcion.Estudiante.Matricula =
                           estudiante.Matricula
                End Function
            )

        If yaInscrito Then
            Return ResultadoAsignacion.YaInscrito
        End If

        If EstaLleno Then
            Return ResultadoAsignacion.CursoLleno
        End If

        Inscripciones.Add(
            New Inscripcion(estudiante, fechaInscripcion)
        )

        Return ResultadoAsignacion.Inscrito
    End Function

    Public Function AgregarAListaEspera(
        estudiante As Estudiante
    ) As Boolean

        Dim yaInscrito As Boolean =
            Inscripciones.Any(
                Function(inscripcion As Inscripcion)
                    Return inscripcion.Estudiante.Matricula =
                           estudiante.Matricula
                End Function
            )

        Dim yaEnEspera As Boolean =
            ListaEspera.Any(
                Function(item As Estudiante)
                    Return item.Matricula = estudiante.Matricula
                End Function
            )

        If yaInscrito OrElse yaEnEspera Then
            Return False
        End If

        ListaEspera.Enqueue(estudiante)
        Return True
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

End Class