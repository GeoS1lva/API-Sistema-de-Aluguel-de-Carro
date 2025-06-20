const formBtn = document.querySelector(".entrar-btn")
const userInput = document.querySelector("#user")
const passwordInput = document.querySelector("#senha")

async function requestLogin() {
    try {
        const response = await axios.post("http://localhost:5279/api/EmployeeLogin/requestLogin", {
        "userName": userInput.value,
        "passwords": passwordInput.value
        });

        if(response.status === 200){
            window.location.href = "http://127.0.0.1:5500/FrontEnd/html/mainScreen.html";
        }
    } 
    catch (erro) {
        const aviso = document.querySelector(".aviso");

        const errorMessage = erro.response.data;

        aviso.textContent = errorMessage;

        aviso.style.display = "block";

        setTimeout(() => {
            aviso.style.display = "none";
            aviso.textContent = "";
        }, 2000);
    }
}

formBtn.addEventListener("click", (l)=> {
    l.preventDefault();

    requestLogin();
})