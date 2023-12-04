# anonimizador
Código para um trabalho da faculdade para anonimização de dados.

Foi feito de maneira muito simples, sem utilizar nenhum padrão de projeto.
A base de dados utiliza dados fake que são armazenados na memória na própria aplicação

## Instruções de funcionamento
2 Controllers no projeto "Anonimizador"

1. ClubController:
   HTTP GET "/club" -> Retorna a lista de registros do clube
2. AnonimizeController:
   HTTP POST "/anonimize" -> Recebe uma requisição com os campos a serem anonimizados na base de dados
   JSON
   ```json
   {
    "Fields": [
        "name",
        "email"
    ]
   }  ```

## Como testar
1. Executar o projeto
2. Fazer um GET no recurso de Club onde serão retornados os dados pessoais expostos
3. Fazer um POST no recurso Anonimize passando os campos que se deseja anonimizar
4. Fazer um GET novamente em Club e observar os campos anonimizados
