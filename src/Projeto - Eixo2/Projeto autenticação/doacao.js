async function put() {

    const response = await fetch(`https://localhost:7297/api/CadastroCampanhas/`, {

        method: 'GET',
        headers: {
            'Content-type': 'application/json'
        }
    });

    const resData = await response.json();
    localStorage.setItem('usuario', JSON.stringify(resData))
   

    return resData;


}
window.addEventListener('load', () => {
    let userlogado
   
    put()
    
    if (localStorage.getItem("usuario")) {
        console.log('teste')
        
        userlogado = JSON.parse(localStorage.getItem('usuario'))
        // userlogado.forEach(element => {
        //     //alert(element.idCampanha)
        // });
       
    }

    const tbody = document.getElementById('listaRegistrosBody')
    
    if (tbody) {
        tbody.innerHTML = userlogado.map(usuario => {


            return `<tr>
                    <td>${usuario.nomeDaOng}</td>
                    <td>${usuario.nomeDaCampanha}</td>
                    <td>
                            <button class='verde'  onclick="gerenci()">Detalhes</button>
                            <button class='vermelho' onclick="delet()">Doar</button>
                    </td>
                </tr>`
                
                



        }).join('')
        
    }

  
})
