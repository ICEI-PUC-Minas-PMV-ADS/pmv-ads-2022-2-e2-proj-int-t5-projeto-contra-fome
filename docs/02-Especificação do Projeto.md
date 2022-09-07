# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada através de reuniões periódicas entre os integrantes do grupo praticando um brainstorming, trabalho de pesquisa em reportagens e publicações acadêmicas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.


## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas nas tabelas que se seguem.

<table border="1" width="70%">
<tr>
    <th></th>
    <td></td>
</tr>
<tr>
    <th rowspan="2"><img src="./img/laura.png" width="800"></th>  
    <td colspan="2" align="right"><b>Isabela</b> </td>
</tr>
<tr>
    <td><b>Idade:</b> 35 <br><br> <b>Dificuldades:</b> Sua maior dificuldade foi encontrar um site que reúna pontos de coleta para doações de mantimentos próximos à sua residência

 <br><br>       
    </td> 
    <br>
    <td><b>Em relação ao projeto: </b> Disse que usaria um site ou aplicativo que ajudasse pessoas em vulnerabilidade social a encontrarem pontos de distribuição gratuita de alimentos e refeições. O ponto de distribuição gratuita de alimentos deverá fornecer pontos de coleta para doações de mantimentos próximos a sua residência.
    </td>  
</tr>
</table>

<table border="1" width="70%">
<tr>
    <th></th>
    <td></td>
</tr>
<tr>
    <th rowspan="2"><img src="./img/carlos.jpg" width="900"></th> 
    <td colspan="2" align="right"><b>Carlos</b></td>
</tr>
<tr>
    <td><b>Idade:</b> 19 <br><br> <b>Dificuldades:</b> Sente que necessita ajudar a combater a fome no Brasil. Para isso, considera necessário ter um site que reúna todos os pontos de coleta para doação de mantimentos próximo de sua residência e próximo ao seu local de trabalho. Para ele, o site deve ser amigável, acessível e bem projetado.
 <br><br>     
    </td> 
    <td> <b>Em relação ao projeto:</b> Apresentou entusiasmo ao saber que vai ser desenvolvido um site que pode fornecer pontos de coleta para doações de mantimentos de forma permanente e não quando acontece algum tipo de catástrofe.
    </td>  
</tr>

<table border="1" width="70%">
<tr>
    <th></th>
    <td></td>
</tr>
<tr>
    <th rowspan="2"><img src="./img/joaopedro.png" width="800"></th>
    <td colspan="2" align="right"><b>Juarez</b></td>
</tr>
<tr>
    <td><b>Idade:</b> 15 <br><br> <b>Dificuldades:</b> Morador da periferia e ativista, sente que precisa fazer algo para amenizar o sofrimento da população em situação de vulnerabilidade social. Sente que precisa de um site que crie um mapa contendo pontos de mobilização social, que receba doações de alimentos e itens de necessidade básica.
 <br><br>     
    </td> 
    <td> <b>Em relação ao projeto:</b> Ficou super interessado e disse que usaria um aplicativo web que fornecesse ferramentas que viabilizassem a procura de pontos de coleta de doações.
    </td>  
</tr>

<table border="1" width="70%">
<tr>
    <th></th>
    <td></td>
</tr>
<tr>
    <th rowspan="2"><img src="./img/Barbaraa.jpg" width="400"></th>
    <td colspan="2" align="right"><b>Barbara</b></td>
</tr>
<tr>
    <td><b>Idade:</b> 60 <br><br> <b>Dificuldades:</b> Precisa de um site seguro e transparente para realizar doações financeiras a uma instituição que distribui mantimentos.
 <br><br>     
    </td> 
    <td> <b>Em relação ao projeto:</b> Disse que usaria um site que fosse transparente e mostrasse para onde a sua doação estava indo.
    </td>  
</tr>
</table>


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Isabella  | Um Site que forneça pontos de coleta para doações de mantimentos próximo a minha residência| Para ter maior chance de uma ninhada nesse mesmo traço de personalidade.| Para ajudar pessoas em vulnerabilidade social|
|Carlos      | Pesquisar por locais próximos à minha residência e ao meu trabalho , para que eu possa doar alimentos                | Sente que necessita ajudar a combater a fome no Brasil.|
|Juarez |Um site que contenha um mapa com pontos de mobilização social e que receba doações de alimentos e itens de necessidade básica.       | Sente que precisa ajudar as pessoas que possuem vulnerabilidade social , principalmente realizando doações de itens de necessidade básica |
|Barbara |Um site seguro e transparente para realizar doações financeiras a uma instituição que distribui mantimentos.| Ajudar o próximo através de doações financeiras|

## Requisitos

## Requisitos

A tabela a seguir apresenta os requisitos funcionais do projeto, identificando suas respectivas prioridades de entrega.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site deve apresentar imagens que auxiliem o entendimento do leitor para cada assunto exposto no corpo da página.  | MÉDIA | 
|RF-002|O site deve apresentar uma aba no cabeçalho com os contatos do site contendo telefone, Whatsapp, Instagram, e-mail.   | MÉDIA |
|RF-003| O site deve apresentar a funcionalidade que permita o usuário alterar o tamanho da letra.   | MÉDIA | 
|RF-004| O site deve apresentar a funcionalidade de modificar o tamanho da imagem através da tecla ALT.    | MÉDIA |
|RF-005| O site deve permitir visualizar as informações de contatos da(s) pessoa(s) que criaram o site e o mantém.  | BAIXA | 
|RF-006| O site deve apresentar na janela dos filtros de pesquisa a funcionalidade de selecionar o estado e cidade, a aplicação deve possibilitar clicar  no botão “Buscar” e aparecer todos os endereços da cidade X que recebam os alimentos.   |ALTA |
|RF-007| O sistema deve apresentar a informação de que não existe endereço cadastrado quando o local para doação de mantimentos for inexistente. | ALTA | 
|RF-008| O site deve apresentar uma aba no cabeçalho para o usuário acessar e/ou criar uma conta. A aplicação deve permitir que dentro da conta do usuário, aparecer as opções de criar novo ponto de recebimento de alimentos e (excluir ou editar) os pontos já cadastrados.    | ALTA |
|RF-009| O site deve conter um formulário de cadastro de novos lugares que recebem as doações com os campos: estado, cidade, bairro, rua, número, nome da pessoa que receberá os alimentos.  | ALTA | 
|RF-010| O site deve apresentar em todas as páginas, no footer, a logo marca oficial, políticas de privacidade e termos de uso.  | ALTA |
|RF-011| O site deve colher o aceite do usuário para os termos de Política de Cookies / Privacidade, flutuante com alinhamento vertical inferior, e horizontal ao centro. | BAIXA | 


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
