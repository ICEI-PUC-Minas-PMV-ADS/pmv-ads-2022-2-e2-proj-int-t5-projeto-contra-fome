// if(!localStorage.getItem('usuario')){
//     alert('Você precia está logado para acessar essa página!')
//     location.href='Login.html'
// // }
 const resp =document.getElementById("container")



let userlogado = ""
    if (localStorage.getItem("usuarioLogado") === null) {
        console.log('teste')
        userlogado = JSON.parse(localStorage.getItem('usuario'))
    }
    else{
        userlogado = JSON.parse(localStorage.getItem('usuarioLogado'))
     }   
// let logado = document.querySelector('#logado')
// let campanha = document.querySelector('#campanha')
// logado.innerHTML =`Olá ${userlogado.razaoSocial}`
// let resposta =""
// let lista = [];
//const button = document.createElement('button')

// lista = resposta.split(".");
// lista.forEach(element => {
//     let Ong = (userlogado.cadastroCampanhas);
//     for (let i = 0; i < Ong.length; i++) {
//         let Ong2 = (userlogado.cadastroCampanhas[i]);
        
//         //let ong22 = (userlogado.idCampanha[i]);
//         resposta = resposta + Ong2.descricaoDaCampanha + "." + '\n'
        
//         //resposta = resposta + Ong2.descricaoDaCampanha + document.createElement(`button onclick= teste(${ong22})`) + "\n"
//     }
    
// //     resp.innerText = resposta
   
   
// });





var listaRegistros = {
    ultimoIdGerado:0,
    usuarios:[
        {id:1,nome:'Cassio',fone:'81 9000-0000'},
        {id:2,nome:'Cassio',fone:'81 9000-0000'},
        {id:3,nome:'Cassio',fone:'81 9000-0000'}
    ]

}
function desenhar(){
   
    const tbody = document.getElementById('listaRegistrosBody')
    
    if(tbody){
        tbody.innerHTML = listaRegistros.usuarios.map(usuario =>{

            return `<tr>
                    <td>${usuario.id}</td>
                    <td>${usuario.nome}</td>
                    <td>${usuario.fone}</td>
                </tr>`

        } ).join('')
    }
}
function insert(nome,fone){
    const id = listaRegistros.ultimoIdGerado + 1;
    listaRegistros.usuarios.push({
        id,nome,fone
    })
    desenhar()
    visualizar('lista')

}
function edit(id,nome,fone){

}

function deleteUsuario(id){

}
    
function sair(){
    localStorage.removeItem('usuario')
    localStorage.removeItem('usuarioLogado')
    
    location.href='Login.html'
}

function visualizar(pagina){
    document.body.setAttribute('page',pagina)
    if(pagina ==='cadastro'){
        document.getElementById('nome').focus()
    }
    
}

function submeter(e){
    e.preventDefault()
    const data ={
        id: document.getElementById('id').value,
        nome: document.getElementById('nome').value,
        fone: document.getElementById('fone').value,
    }
    if(data.id){
        edit(...data)
    }else{
        insert(data.nome, data.fone)
    }

}



window.addEventListener('load', () => {
  
    desenhar()
    document.getElementById('CadastroRegistro').addEventListener('submit', submeter)
})
//async function teste(id){
  //const response = http.get(`api/CadastroCampanhas${id}`)
//}

