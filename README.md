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
   }
  ```
