// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function sumar() {

    let valor1 = document.getElementById("valor1").value; 
    let valor2 = document.getElementById("valor2").value;

    let resultado = document.getElementById("resultado");
    resultado.innerHTML = valor1 + valor2;

}



