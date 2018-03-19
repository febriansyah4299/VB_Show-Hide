Class MainWindow
    Private Sub button_Red_Click(sender As Object, e As RoutedEventArgs) Handles button_Red.Click
        button_Green.Visibility = True
        button_Blue.Visibility = True
    End Sub

    Private Sub button_Green_Click(sender As Object, e As RoutedEventArgs) Handles button_Green.Click
        button_Red.Visibility = True
        button_Blue.Visibility = True
    End Sub

    Private Sub button_Blue_Click(sender As Object, e As RoutedEventArgs) Handles button_Blue.Click
        button_Red.Visibility = True
        button_Green.Visibility = True
    End Sub

    Private Sub button_Back_Click(sender As Object, e As RoutedEventArgs) Handles button_Back.Click
        button_Red.Visibility = False
        button_Green.Visibility = False
        button_Blue.Visibility = False
    End Sub
End Class
