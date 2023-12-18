Public Class Main
    Private Sub logoPanel_Paint(sender As Object, e As PaintEventArgs) Handles logoPanel.Paint
        ' Create a rectangle with rounded corners
        Dim roundedRect As New Drawing2D.GraphicsPath()
        Dim rectangle As Rectangle = New Rectangle(0, 0, logoPanel.Width, logoPanel.Height)
        Dim cornerRadius As Integer = 15 ' Adjust the corner radius as needed

        roundedRect.AddArc(rectangle.X, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 180, 90)
        roundedRect.AddArc(rectangle.Right - cornerRadius * 2, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 270, 90)
        roundedRect.AddArc(rectangle.Right - cornerRadius * 2, rectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        roundedRect.AddArc(rectangle.X, rectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)
        roundedRect.CloseFigure()

        ' Apply the rounded rectangle to the Region property of the panel
        logoPanel.Region = New Region(roundedRect)
    End Sub

    Private Sub cartButton_Click(sender As Object, e As EventArgs) Handles cartButton.Click
        ' Create an instance of the Cart form
        Dim cartForm As New Cart()

        ' Show the Cart form
        cartForm.Show()

        ' Optionally, hide the current form
        Me.Hide()
    End Sub

    Private Sub hoverPanel_MouseEnter(sender As Object, e As EventArgs) Handles hoverPanel1.MouseEnter, hoverPanel2.MouseEnter, hoverPanel3.MouseEnter, hoverPanel4.MouseEnter, hoverPanel5.MouseEnter, hoverPanel6.MouseEnter, fiftyRosesPanel.MouseEnter, sixtysixRosesPanel.MouseEnter, ninetynineRosesPanel.MouseEnter
        ' Change the appearance when the mouse enters the panel
        Dim panel As Panel = DirectCast(sender, Panel)
        panel.Size = New Size(panel.Width + 10, panel.Height + 10)
        panel.BackColor = Color.LemonChiffon
        ' Optionally, adjust other visual properties like the image size, position, or transparency.
    End Sub

    Private Sub hoverPanel_MouseLeave(sender As Object, e As EventArgs) Handles hoverPanel1.MouseLeave, hoverPanel2.MouseLeave, hoverPanel3.MouseLeave, hoverPanel4.MouseLeave, hoverPanel5.MouseLeave, hoverPanel6.MouseLeave, fiftyRosesPanel.MouseLeave, sixtysixRosesPanel.MouseLeave, ninetynineRosesPanel.MouseLeave
        ' Change the appearance when the mouse leaves the panel
        Dim panel As Panel = DirectCast(sender, Panel)
        panel.Size = New Size(panel.Width - 10, panel.Height - 10)
        panel.BackColor = SystemColors.Control  ' Change this to the original background color
        ' Reset other visual properties as needed.
    End Sub

    Private Sub birthdayButton_Click(sender As Object, e As EventArgs) Handles birthdayButton.Click
        Dim birthdayForm = New BirthdayForm
        birthdayForm.Show()
        Me.Hide()
    End Sub

    Private Sub graduationButton_Click(sender As Object, e As EventArgs) Handles graduationButton.Click
        Dim graduationForm = New GraduationForm
        graduationForm.Show()
        Me.Hide()
    End Sub

    Private Sub anniversaryButton_Click(sender As Object, e As EventArgs) Handles anniversaryButton.Click
        Dim anniversaryForm = New AnniversaryForm
        anniversaryForm.Show()
        Me.Hide()
    End Sub

    Private Sub funeralButton_Click(sender As Object, e As EventArgs) Handles funeralButton.Click
        Dim funeralForm = New FuneralForm
        funeralForm.Show()
        Me.Hide()
    End Sub

    Private Sub flowerBouquetButton_Click(sender As Object, e As EventArgs) Handles flowerBouquetButton.Click
        Dim flowerBoquetForm = New FlowerBouquetForm
        flowerBoquetForm.Show()
        Me.Hide()
    End Sub

    Private Sub flowerBoxesButton_Click(sender As Object, e As EventArgs) Handles flowerBoxesButton.Click
        Dim flowerBoxesForm = New FlowerBoxesForm
        flowerBoxesForm.Show()
        Me.Hide()
    End Sub

    Private Sub flowerBasketButton_Click(sender As Object, e As EventArgs) Handles flowerBasketButton.Click
        Dim flowerBasketForm = New FlowerBasketForm
        flowerBasketForm.Show()
        Me.Hide()
    End Sub

    Private Sub chocolateBouquetButton_Click(sender As Object, e As EventArgs) Handles chocolateBouquetButton.Click
        Dim chocolateBoquetForm = New ChocolateBoquetForm
        chocolateBoquetForm.Show()
        Me.Hide()
    End Sub

    Private Sub sunflowerButton_Click(sender As Object, e As EventArgs) Handles sunflowerButton.Click
        Dim sunFlowerForm = New SunFlowerForm
        sunFlowerForm.Show()
        Me.Hide()
    End Sub

    Private Sub rosesButton_Click(sender As Object, e As EventArgs) Handles rosesButton.Click
        Dim rosesForm = New RosesForm
        rosesForm.Show()
        Me.Hide()
    End Sub

    Private Sub orchidsButton_Click(sender As Object, e As EventArgs) Handles orchidsButton.Click
        Dim orchidsForm = New OrchidsForm
        orchidsForm.Show()
        Me.Hide()
    End Sub

    Private Sub tulipsButton_Click(sender As Object, e As EventArgs) Handles tulipsButton.Click
        Dim tulipsForm = New TulipsForm
        tulipsForm.Show()
        Me.Hide()
    End Sub

    Private Sub forMenButton_Click(sender As Object, e As EventArgs) Handles forMenButton.Click
        Dim forMenForm = New ForMen
        forMenForm.Show()
        Me.Hide()
    End Sub

    Private Sub forWomenButton_Click(sender As Object, e As EventArgs) Handles forWomenButton.Click
        Dim forWomenForm = New ForWomen
        forWomenForm.Show()
        Me.Hide()
    End Sub

    Private Sub forTeacherButton_Click(sender As Object, e As EventArgs) Handles forTeacherButton.Click
        Dim forTeacherForm = New ForTeacher
        forTeacherForm.Show()
        Me.Hide()
    End Sub

    Private Sub forColleaguesButton_Click(sender As Object, e As EventArgs) Handles forColleaguesButton.Click
        Dim forColleaguesForm = New ForColleagues
        forColleaguesForm.Show()
        Me.Hide()
    End Sub

    Private Sub price1Button_Click(sender As Object, e As EventArgs) Handles price1Button.Click
        Dim belowOneFivForm = New BelowOneFive
        belowOneFivForm.Show()
        Me.Hide()
    End Sub

    Private Sub price2Button_Click(sender As Object, e As EventArgs) Handles price2Button.Click
        Dim oneFiveToThree = New OneFiveToThree
        oneFiveToThree.Show()
        Me.Hide()
    End Sub

    Private Sub price3Button_Click(sender As Object, e As EventArgs) Handles price3Button.Click
        Dim threeToFourForm = New ThreeToFour
        ThreeToFour.Show()
        Me.Hide()
    End Sub

    Private Sub price4Button_Click(sender As Object, e As EventArgs) Handles price4Button.Click
        Dim aboveFour = New AboveFour
        aboveFour.Show()
        Me.Hide()
    End Sub
End Class