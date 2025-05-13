<!DOCTYPE html>
<html lang="pt-BR">
<head>

    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <title>Agenda 2-DS</title>

</head>

<body>

    <div class="w3-container w3-blue-grey w3-text-black" >
        <h2>Cadastro - Loja Brincos e Companhia</h2>
    </div>
<br>
 

<form id="form"name="form"method="post"class="w3-container" method="post" action="acao.php">

        <label class="w3-text-black"><b>Nome*</b></label>
        <input class="w3-input w3-border w3-light-grey" name="nome" id="nome" type="text" placeholder="Digite seu nome">
    <br>
 
        <label class="w3-text-black"><b>Sobrenome*</b></label>
        <input class="w3-input w3-border w3-light-grey" name="sobrenome" id="sobrenome" type="text" placeholder="Digite seu sobrenome">
    <br>

        <label class="w3-text-black"><b>E-mail*</b></label>
        <input class="w3-input w3-border w3-light-grey" name="email" id="email" type="text" placeholder="Digite seu e-mail">
    <br>

        <label class="w3-text-black"><b>Formação*</b></label>
        <input class="w3-input w3-border w3-light-grey" name="formacao" id="formacao" type="text">
    <br>
 
        <label class="w3-text-black"><b>Descrição último emprego</b></label>
        <input class="w3-input w3-border w3-light-grey" name="emprego" id="emprego" type="text">

        <br>
 
        <button class="w3-btn w3-blue-grey">Enviar</button>

    </form>
</body>
</html>