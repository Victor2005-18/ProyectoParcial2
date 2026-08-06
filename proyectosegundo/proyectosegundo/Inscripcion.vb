Option Strict On
Option Explicit On

Public Class Inscripcion

    Public Sub New(estudiante As Estudiante, fechaInscripcion As Date)

        If estudiante Is Nothing Then
            Throw New ArgumentNullException(NameOf(estudiante))
        End If

        If fechaInscripcion.Date > Date.Today Then
            Throw New ArgumentException(
                "La fecha de inscripción no puede ser futura."
            )
        End If

        Me.Estudiante = estudiante
        Me.FechaInscripcion = fechaInscripcion.Date
    End Sub

    Public ReadOnly Property Estudiante As Estudiante

    Public ReadOnly Property FechaInscripcion As Date

End Class