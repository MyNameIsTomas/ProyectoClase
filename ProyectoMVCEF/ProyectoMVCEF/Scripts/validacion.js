$(document).ready(function () {
    $("#botonenviar").click(function () {
        alert("Hello baby!!");
        //Debemos validar la entrada del usuario de datos                   
        var datos = $("#Nombre").val();
        //Recorremos todas las letras de la caja
        var datosbuenos = "";
        for (var i = 0; i < datos.length; i++) {
            //Capturamos cada letra
            var letra = datos.charAt(i);
            if (letra == "<") {
                letra = "&lt;";
            } else if (letra == ">") {
                letra = "&gt;";
            }
            datosbuenos += letra;
        }
        //ambiamos el contenido de la caja normalizado
        $("#Nombre").val(datosbuenos);
    });
}); 
