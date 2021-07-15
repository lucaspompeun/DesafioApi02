# DesafioApi02
Desafio API 02 - Retorno de cálculo de juros e show me the code

## Descrição
Esta API está disposta no serviço de nuvem Azure para livre utilização, a mesma possui dois endpoints, sendo o primeiro via `/calculajuros` e possui a seguinte estrutura de retorno:

```json
{
  "valorFinal": "105.10"
}
```

O segundo endpoint possui sua chamada via `/showmethecode` e retorna as Urls dos desafios no GitHub, com a seguinte estrutura de retorno:

```json
{
  "urlDesafio01": "https://github.com/lucaspompeun/DesafioApi01",
  "urlDesafio02": "https://github.com/lucaspompeun/DesafioApi02"
}
```

O desenvolvimento se deu sob ASP.NET Core Web API 3.1, a escolha desta versão se deu pela sua característa LTS, garantindo suporte de longo prazo. A documentação da API se deu a partir do Swagger.

## Entrega

### Requisitos mínimos
- [x] Código fonte ASP.NET Core Web API
- [x] Testes unitários utilizando-se do MSTest

### Requisitos extras
- [x] Construção da aplicação utilizando Docker
- [ ] Teste de integração da API / Pirâmide de testes
- [x] Utilização do Swagger
