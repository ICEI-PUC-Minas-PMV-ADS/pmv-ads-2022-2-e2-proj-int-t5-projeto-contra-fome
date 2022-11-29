function sair(){
    localStorage.removeItem('buscar')
    location.href='doacao.html'

}
let NomeDaOng = document.querySelector("#NomeDaOng");
let userlogado = JSON.parse(localStorage.getItem('buscar'));

window.addEventListener('load', () => {


    document.getElementById('labelMudar').innerHTML =`${userlogado.descricaoDaCampanha}`

})
