Public Class Car
    Dim Speed As Integer = 6
    Public Fuel As Integer = 10
    Public Distance As Integer = 0
    Public Tires As Integer = 10

    ' car drives at normal speed using 1ga of fuel
    Public Sub Drive()
        Dim RandomNum As New Random
        If Fuel > 0 And Tires >= 1 Then
            Distance = Speed + RandomNum.Next(4, 30)
            Fuel -= 1
            Tires -= 1
        End If
    End Sub

    ' car drives at accelerated speed using 5ga of fuel
    Public Sub Nitro()
        Distance = 0
        Dim RandomNum As New Random
        If Fuel >= 5 And Tires >= 4 Then
            Speed += 5
            Distance = Speed + 2 * RandomNum.Next(4, 30)
            Fuel -= 5
            Tires -= 4
        End If
    End Sub

    ' increases car's speed and fuel
    Public Sub Mechanic()
        Distance = 0
        Speed += 4
        Fuel += 4
        Tires += 4
    End Sub

    ' refuels car with 10 ga of gas
    Public Sub Refuel()
        Distance = 0
        Fuel += 10
    End Sub

    ' changes tires to 10 tire life
    Public Sub ChangeTires()
        Distance = 0
        Tires = 10
    End Sub
End Class
