<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <title>Atividade 05</title>
</head>
<body>


    <div class="w3-center w3-animate-top w3-padding">
    <div class="w3-center w3-animate-top w3-padding w3-blue-gray">
        <h4><strong>8º ano A</strong></h4>
    </div>
<?php

    $nota = array(
        array("nome" => "Aline", "p1" => "10", "p2" => "9.5"),
        array("nome" => "Alfredo", "p1" => "8", "p2" => "5"),
        array("nome" => "Carla", "p1" => "5", "p2" => "6.5"),
        array("nome" => "César", "p1" => "9", "p2" => "9"),
        array("nome" => "Daniel", "p1" => "10", "p2" => "7"),
        array("nome" => "Esnar", "p1" => "8", "p2" => "6"),
        array("nome" => "Henzo", "p1" => "6", "p2" => "8"),
        array("nome" => "Pablo", "p1" => "7", "p2" => "5"),
        array("nome" => "Wallace", "p1" => "8", "p2" => "7"),
        array("nome" => "Zulmira", "p1" => "10", "p2" => "6"),
    ); 
?>

<table class="w3-table-all w3-hoverable w3-textblack">
    
    <tr class="w3-blue-gray">
        <th class="w3-center"> Nome</th>
        <th class="w3-center"> Primeiro Semestre</th>
    <th class="w3-center"> Segundo Semestre</th>
    </tr>

<?php foreach ($nota as $estudante) { ?>

<tr>
    <td class="w3-center"><?php echo $estudante['nome'] ?></td>
    <td class="w3-center"><?php echo $estudante['p1'] ?></td>
    <td class="w3-center"><?php echo $estudante['p2'] ?></td>

</tr>

<?php } ?>

</table>

<br>

</div>
</body>
</html>