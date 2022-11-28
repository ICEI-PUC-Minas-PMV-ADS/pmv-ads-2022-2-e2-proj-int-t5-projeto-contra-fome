 if(!localStorage.getItem('usuario')){
     alert('Você precia está logado para acessar essa página!')
     location.href='Login.html'
}
let userlogado = ""
function lerBD(){
    
    if (localStorage.getItem("usuarioLogado") === null)  {
        console.log('teste')
        userlogado = JSON.parse(localStorage.getItem('usuario'))
    }
    else{
        userlogado = JSON.parse(localStorage.getItem('usuarioLogado'))
    }
    let logado = document.querySelector('#logado')
    logado.innerHTML =`Olá ${userlogado.razaoSocial}`
    desenhar()
}

window.addEventListener('load', () => {
  
    lerBD()
    //document.getElementById('CadastroRegistro').addEventListener('submit', submeter)
})
function sair(){
    localStorage.removeItem('usuario')
    localStorage.removeItem('usuarioLogado')
    
    location.href='Login.html'
}

function desenhar(){
   
    const tbody = document.getElementById('listaRegistrosBody')
    
    if(tbody){
        tbody.innerHTML = userlogado.cadastroCampanhas.map(usuario =>{

            return `<tr>
                    <td>${usuario.descricaoDaCampanha}</td>
                    <td>
                            <button class='verde'  onclick="gerenci(${usuario.idCampanha})">Editar</button>
                            <button class='vermelho' onclick="delet(${usuario.idCampanha},${usuario.cadastroCodigo})">Deletar</button>
                    </td>
                </tr>`

        } ).join('')
    }
} 
function gerenci(id){
    put(id)
 
 
}


async function put(id) {
    
    const response = await fetch(`https://localhost:7297/api/CadastroCampanhas/${id}`, {
        
      method: 'GET',
      headers: {
        'Content-type': 'application/json'
      }
    });
   
    const resData = await response.json();
  
    console.log(resData.descricaoDaCampanha);
    localStorage.setItem('edit', JSON.stringify(resData))
    window.location.href='EditarCampanha.html'
    
   

    // Return response data 
    return resData;

}
   



function delet(id,id2){
    delet2(id,id2)

}
async function delet2(id,id2) {
    
    const response = await fetch(`https://localhost:7297/api/CadastroCampanhas/${id}`, {
       
      method: 'DELETE',
      headers: {
        'Content-type': 'application/json'
      }
    });
    const response2 = await fetch(`https://localhost:7297/api/Cadastro/${id2}`, {
        method: 'GET',
        headers: {
          'Content-type': 'application/json'
        }
      });
    const resData = await response2.json();
    console.log(resData.descricaoDaCampanha);
    localStorage.setItem('usuarioLogado', JSON.stringify(resData))
    window.location.href='Gerenciar.html'
    
        
  
      //window.location.href='EditarCampanha.html'

}

// async function buscaCampanhasLogado(){
//     let userlogado = JSON.parse(localStorage.getItem('novo'))
//     const response = await http.get(`api/Cadastro/${userlogado.codigo}`)
//         localStorage.setItem('usuarioLogado', JSON.stringify(response.data))
//         window.location.href='Gerenciar.html'
// }




