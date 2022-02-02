# API
A API está rodando em um servidor pessoal, e pode ser acessado via `GET https://abgsolucoes.com/api/Repository/repository-order`  

O retorno segue conforme exemplo abaixo:
```
{
	"repositories": [
		{
			"full_name": "takenet/library.data",
			"private": false,
			"created_at": "2013-10-25T13:04:51.000Z",
			"language": "C#",
			"description": "Provides a simple abstraction for implementing the repository and unit of work patterns for data-enabled applications"
		},
		{
			"full_name": "takenet/library.logging",
			"private": false,
			"created_at": "2013-10-25T15:18:07.000Z",
			"language": "C#",
			"description": "Provides a simple logging interface for applications and some basic implementations of this interface"
		},
		{
			"full_name": "takenet/libphonenumber-csharp",
			"private": false,
			"created_at": "2013-11-29T09:16:51.000Z",
			"language": "C#",
			"description": "Forking original c# port"
		},
		{
			"full_name": "takenet/Takenet.Radar",
			"private": false,
			"created_at": "2014-01-13T11:38:38.000Z",
			"language": "C#",
			"description": "Radar de tecnologias takenet"
		},
		{
			"full_name": "takenet/Takenet.ScoreSystem",
			"private": false,
			"created_at": "2014-01-28T10:31:10.000Z",
			"language": "C#",
			"description": "Takenet score system"
		}
	]
}
```
# Desafio Take
### CHATBOTS NA TAKE BLIP

Os chatbots que criamos aqui na Take Blip precisam frequentemente de consumir dados de APIs de parceiros. Para fazer essas integrações, geralmente criamos APIs intermediárias que se integram às APIs dos parceiros e nossos bots consomem a API intermediária.

### ENTENDENDO O DESAFIO

O nosso objetivo é conhecer um pouco mais de você enquanto profissional! E além disso, que você conheça o nosso produto, serviços e um pouquinho da atividade que você irá desempenhar aqui na Take Blip.

### O DESAFIO

Você deverá construir um chatbot em nossa plataforma, para isso, você pode seguir esses passos:

- crie uma conta em nosso portal (https://bit.ly/3lYcJTf), depois crie um chatbot usando a opção ""Criar do zero"";

- crie uma API que faça integração com a API pública do GitHub com informações sobre os repositórios da Take no GitHub. Para criá-la, você pode usar C#, Java ou Javascript;

- agora que você tem a API criada, deverá utilizar esses dados para exibir um carrossel a partir de qualquer entrada do usuário com informações sobre os 5 repositórios de linguagem C# mais antigos da Take, ordenados de forma crescente por data de criação;

- a imagem de cada card do carrossel deve ser o avatar da Take no GitHub. O título de cada card deve ser o nome completo do repositório, e o subtítulo deve ser a descrição do repositório. Os cards não devem ter nenhum botão;

- o fluxo do bot precisa estar parecido com o que está no link:https://bit.ly/2uDaGhi;

- favor colocar no repositório o json do fluxo do bot para que o mesmo possa ser avaliado.

### Seguem links que podem auxiliar em seu desafio:

- Fluxo do bot: https://bit.ly/3bxfe9F
- Documentação do BLiP com todos os tipos de card e exemplos: https://docs.blip.ai/
- Documentação de como criar um bot no Builder: https://bit.ly/3tw7zRR
- Documentação da API do GitHub: https://developer.github.com/v3/														
