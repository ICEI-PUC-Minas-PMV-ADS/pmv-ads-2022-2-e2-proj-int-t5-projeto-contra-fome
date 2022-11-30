async function put() {

    const response = await fetch(`https://localhost:7297/api/CadastroCampanhas/`, {

        method: 'GET',
        headers: {
            'Content-type': 'application/json'
        }
    });

    const resData = await response.json();
    localStorage.setItem('usuario', JSON.stringify(resData))


    //return resData;


}

async function detalhe(id) {
    await buscar(id)

}


async function buscar(id) {

    const response = await fetch(`https://localhost:7297/api/CadastroCampanhas/${id}`, {

        method: 'GET',
        headers: {
            'Content-type': 'application/json'
        }
    });

    const resData = await response.json();
    localStorage.setItem('buscar', JSON.stringify(resData))
    // Return response data 
    location.href = 'detalhe.html'
}

async function final(){
    let userlogado
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
                            <button class='verde'  onclick="detalhe(${usuario.idCampanha})">Informações</button>
                            <button class='vermelho' onclick="delet()">Doar</button>
                    </td>
                </tr>`
        }).join('')
    }

}

window.addEventListener('load', async () => {
   
    await put()
    await final()

    
})

