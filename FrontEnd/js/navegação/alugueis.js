const home = document.querySelector(".home");
const alugueis = document.querySelector(".alugueis");
const frota = document.querySelector(".frota");
const clientes = document.querySelector(".clientes");
const funcionarios = document.querySelector(".funcionarios");

home.addEventListener("click", () =>{
    window.location.href = "/FrontEnd/html/mainScreen.html";
});

frota.addEventListener("click", () =>{
    window.location.href = "/FrontEnd/html/navegação/frota.html";
});

clientes.addEventListener("click", () =>{
    window.location.href = "/FrontEnd/html/navegação/clientes.html";
});

funcionarios.addEventListener("click", () =>{
    window.location.href = "/FrontEnd/html/navegação/funcionarios.html";
});

