# Joga Bonito

## Identificação, proposta e solução.
- Joga Bonito tem o objetivo de resolver os problemas de quem está a procura de uma partida amistosa(ou mais competitiva) de futebol, em um sistema simples e direto.

- A ideia facilita o trabalho de procurar uma partida, seja no dia ou daqui a uma semana, proporcionando mais flexibilidade em suas exigências, podendo também escolher partidas com níveis mais intensos de jogabilidade.

- Na prática, basta o usuário escolher entre organizar uma partida ou ingressar em uma partida disponível. Nesse sentido, a solução proposta resolve o problema da necessidade de achar uma partida seja em apuros ou não, como também, atender seu ritmo de jogo preferível.


## Escopo

**Desenvolvimento**

- O projeto será um sistema web, desenvolvido com C# e Vue 3. C# para desenvolvimento da API que retornará informações necessárias para realizar as funcionalidades das telas feitas com o Vue 3, e também para consumir a API do Google Maps, para filtragrem e visualização dos endereços da cidade em que o usuário utilizará para busca da partida. Será desenvolvido um sistema de fila para procura de partidas, caso o usuário não encontrar no momento da filtragem.

**Qualidade do produto**

- Testes unitários serão implementados tanto no front-end quanto no back-end para melhor cobertura de qualidade do projeto, utilizando o SonarQube para melhoria da qualidade nos cenários dos testes unitários.

## Restrições

- O sistema não fará a parte de pagamentos das quadras alugadas, seja do organizador da partida com o dono da quadra, ou o jogador que foi aceito pelo organizador da partida.

## C4 Model

- [Acesse este caminho para ser redirecionado ao C4 Model.](files/c4-model.md)


## Trade-off

**Portabilidade**

- O sistema web será totalmente responsível, com uma interface de fácil uso e visualização para o usuário. 

**Funcionalidade**

- A interface do sistema e suas funcionalidades serão objetivas, priorizando a rapidez para solução proposta, dando tanto opções diretas quanto avançadas, trazendo flexibilidade ao usuário. 

**Confiabilidade**

- A confialidade no acontecimento das partidas, seria o contato direto que o usuário teria com quem esta organizando a partida, consultando as informações do perfil do organizador da partida. 

**Usabilidade**

- A usabilidade do produto gira em torno das funcionalidades simples e diretas que o sistema proporciona, tendo poucas telas com as devidas informações necessárias.

**Eficiência**

- Tendo em vista que o usuário deseja encontrar uma partida, o sistema terá tanto a opção de encontrar alguma partida disponível no momento, como também ficará em uma fila de espera, aguardando uma partida aparecer com as filtragens que o usuário selecionou.

**Manutenibilidade**

- Como o sistema tem a intenção de ser algo prático e simples, a manutenibilidade pode ser considerada no sistema de filas, dependendo da quantidade de usuários esperando uma partida e quantos se encaixariam na mesma filtragem.
  

## Requisitos e Casos de Uso

- [Acesse este caminho para ser redirecionado aos requisitos e os casos de uso.](files/requirements-nonrequirementsl.md)

##Modelagem por funcionalidade
- Com o próprio GitHub, na opção de Projetos, as tarefas estão sendo dividas em processos no estilo Kanban. 

## Stack

- BE: C# e .Net Core
- FE:  VueJs 3 e Tailwind CSS
- Databse: PostgreSQL
- Testes: Selenium
- Qualidade nos cenários de testes: SonarQube
- Observalidade: Datadog
