Option Strict On
Option Explicit On

Public Class Estudiante
    Inherits Persona

    Private _matricula As String
    Private _turno As String

    Public Sub New(
        nombre As String,
        apellido As String,
        matricula As String,
        turno As String,
        tieneBeca As Boolean
    )
        MyBase.New(nombre, apellido)

        Me.Matricula = matricula
        Me.Turno = turno
        Me.TieneBeca = tieneBeca
    End Sub

    Public Property Matricula As String
        Get
            Return _matricula
        End Get
        Set(value As String)

            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException(
                    "La matrícula no puede estar vacía."
                )
            End If

            Dim matriculaLimpia As String = value.Trim()

            If matriculaLimpia.Length < 4 Then
                Throw New ArgumentException(
                    "La matrícula debe tener al menos 4 caracteres."
                )
            End If

            If Not matriculaLimpia.All(
                Function(caracter As Char)
                    Return Char.IsLetterOrDigit(caracter) OrElse caracter = "-"c
                End Function
            ) Then
                Throw New ArgumentException(
                    "La matrícula solo puede contener letras, números o guiones."
                )
            End If

            _matricula = matriculaLimpia.ToUpperInvariant()
        End Set
    End Property

    Public Property Turno As String
        Get
            Return _turno
        End Get
        Set(value As String)

            If value <> "Matutino" AndAlso value <> "Vespertino" Then
                Throw New ArgumentException(
                    "El turno debe ser Matutino o Vespertino."
                )
            End If

            _turno = value
        End Set
    End Property

    Public Property TieneBeca As Boolean

    Public Overrides Function ObtenerDescripcion() As String
        Dim estadoBeca As String

        If TieneBeca Then
            estadoBeca = "Con beca"
        Else
            estadoBeca = "Sin beca"
        End If

        Return Matricula & " - " &
               NombreCompleto & " - " &
               Turno & " - " &
               estadoBeca
    End Function

    Public Overrides Function ToString() As String
        Return Matricula & " - " & NombreCompleto
    End Function

End Class