<!DOCTYPE html>
<html lang="pt-BR">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<meta http-equiv="X-UA-Compatible" content="ie=edge">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<title>O valor do seu aumento</title>

</head>

<body>

<div class="w3-container w3-brown w3-text-black">
<h1><strong>Madeira e Cia Ltda.</strong>
</h1>
</div>

<p>
<div class="w3-container w3-text-black">
<?php
$nome = $_POST['nome'];
$compra = intval($_POST['compra']);
$pag = $_POST['pag'];

if($pag == "Depósito") {
    $desc = "10%";
    $eco =  $compra * 0.10;
    $Npag = $compra - $eco;

echo"<strong>Promoção de mês de aniversário!</strong>"."<br>";
echo"".$nome."!<br>";
echo "O valor da sua compra sem desconto: ".$compra.",00<br>";
echo "Método de pagamento escolhido: ".$pag."<br>";
echo "Desconto de: ".$desc."<br>";
echo "Você economizou: R$".$eco.",00<br>";
echo "Valor à pagar: R$".$Npag.",00<br>";

}

else if($pag == "Boleto") {
    $desc = "08%";
    $eco =  $compra * 0.08;
    $Npag = $compra - $eco;

echo"<strong>Promoção de mês de aniversário!</strong>"."<br>";
echo"".$nome."!<br>";
echo "O valor da sua compra sem desconto: ".$compra.",00<br>";
echo "Método de pagamento escolhido: ".$pag."<br>";
echo "Desconto de: ".$desc."<br>";
echo "Você economizou: R$".$eco.",00<br>";
echo "Valor à pagar: R$".$Npag.",00<br>";
}


//OBS: Optei por não colocar as informações de desconto nessa opção, já que ela não teria.
else{ 

echo"".$nome."!<br>";
echo "Método de pagamento escolhido: ".$pag.",00<br>";
echo "Valor à pagar: R$".$compra.",00<br>";
}

?>

</p> 
</div>
</body>
</html>