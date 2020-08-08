
var listaServicios = [];

$(document).ready(function () {

    $("#message").css('display', 'none');
    $(".messageError").css('display', 'none');
    $("#inputRol").change(function () {
        $.ajax({
            url: "../../Servicio/CambiarRol",
            type: "GET",
            data: { a: this.value },
            success: function (response) {
                $("#inputCategoria").empty();
                $("#inputCategoria").append(new Option("Seleccione", "0"));
                response.forEach((item) => {
                    $("#inputCategoria").append(new Option(item.descripcionCategoria, item.idCategoria));
                });
            },
            error: function (response) {
                alert(response);
            }
        });
    });

    $("#agregarServicio").click(() => {
        $("#message").css('display', 'none');
        if ($("#inputRol").val() == "0" ||
            $("#inputCategoria").val() == "0" ||
            $("#inputHoras").val() == "") {
            $("#message").css('display', 'block');
            return;
        }

        //validar existencia de objto
        var servicio = {
            id: $("#inputRol").val(),
            Rol: $("#inputRol option:selected").text(),
            idCategoria: $("#inputCategoria").val(),
            Categoria: $("#inputCategoria option:selected").text(),
            Horas: parseInt($("#inputHoras").val())
        }
        var existe = false;
        listaServicios.map((item) => {
            if (item.id == servicio.id && item.idCategoria == servicio.idCategoria) {
                item.Horas += servicio.Horas;
                existe = true;
            }
        });

        if (!existe) listaServicios.push(servicio);

        //llenar objecto
        llenarTabla();
    });

    $("#cotizarServicio").click(() => {

        $(".messageError").css('display', 'none');
        let result = validateEmail();
        if (!result) $("#messageEmail").css('display', 'block');

        if ($("#fechaInicio").val() == "") {
            result = false;
            $("#messageFecha").css('display', 'block');
        }

        if (listaServicios.length === 0) {
            result = false;
            $("#messageEquipo").css('display', 'block');
        }

        if (result) {
            alert('Se enviaron los datos');
            listaServicios = [];
            clearServicios();
            $("#tBodyServicio").empty();
            $("#correo").val("");
        }
     
    });


});

function clearServicios() {
    $("#inputRol").val("0");
    $("#inputCategoria").empty();
    $("#inputCategoria").append(new Option("Seleccione", "0"));
    $("#inputHoras").val("");
    $("#fechaInicio").val("");
}

function deleteItem(idRol, idCategoria) {

    const index = listaServicios.findIndex(item => {
                    return item.id == idRol && item.idCategoria == idCategoria;
    });
    listaServicios.splice(index, 1);
    llenarTabla();

}

function llenarTabla() {
    $("#tBodyServicio").empty();
    listaServicios.forEach((item) => {
        var column = '<td>' + item.Rol + '</td>';
        column += '<td>' + item.Categoria + '</td>';
        column += '<td>' + item.Horas + '</td>';
        column += '<td><button onclick="deleteItem(' + item.id + ',' + item.idCategoria + ')" type="button" class="btn btn-sm btn-dark">Delete</button></td>';
        $("#tBodyServicio").append("<tr>" + column + "</tr>");
    });
    clearServicios();
}

function validateEmail() {
    let result = false;
    const inputEmail = $("#correo").val();

    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (inputEmail.match(mailformat)) {
        return true;
    }
    return false;
}