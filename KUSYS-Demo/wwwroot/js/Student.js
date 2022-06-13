
//send data to delete modal
function modaldelete(studentId, firstname, lastname) {
    document.getElementById("stundentIdDelete").value = studentId;
    document.getElementById("studentinfo").innerHTML = firstname + " " + lastname;
}
//send data to edit modal
function modaledit(firstname, lastname, birthDate, stundentId) {
    document.getElementById("firstNameUpdate").value = firstname;
    document.getElementById("lastNameUpdate").value = lastname;
    document.getElementById("birthDateUpdate").value = birthDate;
    document.getElementById("stundentIdUpdate").value = stundentId;

}
//send data to detail modal
function modaldetail(firstname, lastname, birthDate, coursename) {
    document.getElementById("firstNameDetails").innerHTML = firstname;
    document.getElementById("lastNameDetails").innerHTML = lastname;
    document.getElementById("birthDateDetails").innerHTML = birthDate;
    document.getElementById("coursenameDetails").innerHTML = coursename;
}
//taking the incoming id and sending it to the controller with ajax
function deleteStudent() {
    var studentId = document.getElementById("stundentIdDelete").value;

    $.ajax({
        url: 'Student/StudentDelete',
        type: 'DELETE',
        dataType: 'json',
        data: { studentId: studentId },
        success: function (result) {
            if (result == true) {
                window.location.reload();
            }
            else {
                alert("Not Deleted");
            }
        },
        error: function (hata) {

        }
    });
}
//receiving the incoming information and sending it to the controller with ajax
function updateStudent() {
    var dataupdate = GetFormData($("#dataupdateForm"));
    var studentId = document.getElementById("stundentIdUpdate").value;

    $.ajax({
        url: 'student/studentupdate',
        type: 'put',
        datatype: 'json',
        data: { dataupdate: dataupdate, studentId: studentId },
        success: function (result) {
            if (result == true) {
                window.location.reload();
            }
            else {
                alert("not updated");
            }
        },
        error: function (hata) {

        }
    });
}
//receiving the incoming information and sending it to the controller with ajax
function addStudent() {
    var studentAdd = GetFormData($("#dataaddForm"));

    $.ajax({
        url: 'student/StudentAdd',
        type: 'post',
        datatype: 'json',
        data: { studentAdd: studentAdd },
        success: function (result) {
            if (result == true) {
                window.location.reload();
            }
            else {
                alert("not added");
            }
        },
        error: function (hata) {

        }
    });
}
//to get information in the form
function GetFormData($form) {
    var unindexed_array = $form.serializeArray();
    var indexed_array = {};

    $.map(unindexed_array, function (n, i) {
        indexed_array[n['name']] = n['value'];
    });
    console.log(indexed_array)
    return indexed_array;
}

