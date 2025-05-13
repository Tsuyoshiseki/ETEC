# Meu Combustível - Álcool ou Gasolina (.NET MAUI)

Este é um aplicativo desenvolvido em **C# com .NET MAUI**, que ajuda o usuário a decidir **se compensa abastecer com etanol ou gasolina**, com base nos preços informados e no veículo (marca e modelo).

---

## Funcionalidades

- Entrada do nome da **marca** e **modelo** do veículo
- Campo para inserir o **preço do etanol**
- Campo para inserir o **preço da gasolina**
- Botão para **calcular qual combustível vale mais a pena**
- Exibição personalizada da **melhor escolha com base no veículo**
- **Validação de campos vazios** e tratamento de erros

---

## Lógica de cálculo

A regra usada é:

```txt
Se (etanol / gasolina) <= 0.7 → Etanol compensa
Senão → Gasolina compensa
