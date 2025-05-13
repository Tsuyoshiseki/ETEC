<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">

<?php
$nome = $_POST['nome'];
$sobrenome = $_POST['sobrenome'];
$email = $_POST['email'];
$formacao = $_POST['formacao'];
$emprego = $_POST['emprego'];

echo '<h2 class="w3-container w3-blue-grey w3-text-black w3-center">Cadastro confirmado com sucesso!</h2>';
echo "<div style='margin-left: 5px;'><strong>Nome: </strong>".$nome."<br></div>";
echo "<div style='margin-left: 5px;'><strong>Sobrenome: </strong>".$sobrenome."<br></div>";
echo "<div style='margin-left: 5px;'><strong>E-mail: </strong>".$email."<br></div>";
echo "<div style='margin-left: 5px;'><strong>Sua formação: </strong>".$formacao."<br></div>";
echo "<div style='margin-left: 5px;'><strong>Seu último emprego: </strong>".$emprego."<br></div>";
?>
<hr>