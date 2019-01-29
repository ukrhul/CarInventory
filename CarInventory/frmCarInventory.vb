Option Strict On

Public Class frmInventory

    Private carList As New SortedList
    Private currentCarIdentificationNumber As String = String.Empty
    Private isEdit As Boolean = False

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Me.setDefault()

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car
        Dim carItem As ListViewItem

        If IsValidInput() Then

            isEdit = True

            If currentCarIdentificationNumber.Trim.Length = 0 Then

                car = New Car(cmbMake.Text, tbModel.Text, CInt(cmbYear.Text), CDec(tbPrice.Text), chkNew.Checked)

                carList.Add(car.IdentificationNumber.ToString(), car)

            Else

                car = CType(carList.Item(currentCarIdentificationNumber), Car)

                car.Make = cmbMake.SelectedText
                car.Model = tbModel.Text
                car.Price = CDec(tbPrice.Text.ToString())
                car.Year = CInt(cmbYear.Text)


            End If

            lvmCar.Items.Clear()

            For Each carEntry As DictionaryEntry In carList

                carItem = New ListViewItem()

                car = CType(carEntry.Value, Car)

                carItem.Checked = car.carNew
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year.ToString())
                carItem.SubItems.Add(FormatNumber(car.Price.ToString(), 2))

                lvmCar.Items.Add(carItem)

            Next carEntry

            setDefault()

            isEdit = False

        End If

    End Sub


    Private Sub setDefault()

        tbModel.Text = String.Empty
        tbPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        lbResult.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub

    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' check if the title has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the title has been selected
        If cmbYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If tbPrice.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If Not IsNumeric(tbPrice.Text) Then

            ' If not set the error message
            outputMessage += "Please enter valid car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If tbModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    Private Sub lvmCar_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvmCar.ItemCheck

        If isEdit = False Then

            e.NewValue = e.CurrentValue

        End If

    End Sub

    Private Sub lvmCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvmCar.SelectedIndexChanged

        Const identificationSubItemIndex As Integer = 1

        currentCarIdentificationNumber = lvmCar.Items(lvmCar.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        Dim car As Car = CType(carList.Item(currentCarIdentificationNumber), Car)

        tbModel.Text = car.Model
        tbPrice.Text = car.Price.ToString()
        cmbMake.Text = car.Make
        cmbYear.Text = car.Year.ToString()

        lbResult.Text = car.GetSalutation()

    End Sub
End Class
