// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var listaServicios = [];
$(document).ready(function () {
    cargarServicios();
});

/*Servicios*/
function cargarServicios() {
    $("#message").css('display', 'none');
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
            $("#inputHoras").val() == "" ||
            $("#fechaInicio").val() == "") {
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
        $("#tBodyServicio").empty();
        listaServicios.forEach((item) => {
            var column = "<td>" + item.Rol + "</td>";
            column += "<td>" + item.Categoria + "</td>";
            column += "<td>" + item.Horas + "</td>";
            column += "<td><button onclick ='deleteItem(01, 02)' type='button' class='btn btn-sm btn-dark'>Delete</button></td>";
            $("#tBodyServicio").append("<tr>" + column + "</tr>");
        });
        clearServicios();
    });


    function clearServicios() {
        $("#inputRol").val("0");
        $("#inputCategoria").empty();
        $("#inputCategoria").append(new Option("Seleccione", "0"));
        $("#inputHoras").val(""); 
        $("#fechaInicio").val("");
    }

    function deleteItem(idRol, idCategoria) {
        alert(idRol);
        alert(idCategoria);
    }
}
/*Servicios*/