Imports Godot

Public Class GodotVisualBasic

    Private node3d As Node3D
    Private ct As Integer

    Public Sub New(n As Node3D)
        node3d = n
    End Sub

    Public Sub _Ready()
        GD.Print("hello world from visualbasic from node ", node3d.Name)
        Randomize()

        Dim cb = New CsgBox3D()
        Dim newscale = New Vector3()
        newscale.X = 5
        newscale.Y = 0.5
        newscale.Z = 5
        cb.Scale = newscale
        cb.UseCollision = True
        node3d.AddChild(cb)

        ct = 0
    End Sub

    Public Sub _Process(delta As Double)
        ct += 1
        If (ct > 60) Then
            SpawnBox(0, 6, 0)
            ct = 0
        End If
    End Sub

    Function SpawnBox(x As Integer, y As Integer, z As Integer)
        Dim rb = New RigidBody3D()
        Dim cs = New CollisionShape3D()
        Dim cb = New CsgBox3D()
        Dim bs = New BoxShape3D()
        cs.Shape = bs

        Dim mat = New StandardMaterial3D()
        Dim color = New Color()
        color.R = Rnd()
        color.G = Rnd()
        color.B = Rnd()
        mat.AlbedoColor = color
        cb.Material = mat

        Dim newt = New Vector3()
        newt.X = x
        newt.Y = y
        newt.Z = z
        rb.Translate(newt)
        rb.Rotate(New Vector3(1, 0, 0), Rnd() * 360)

        cs.AddChild(cb)
        rb.AddChild(cs)
        node3d.AddChild(rb)
    End Function


End Class
