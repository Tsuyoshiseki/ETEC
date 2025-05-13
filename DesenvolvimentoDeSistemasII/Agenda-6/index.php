<!-- Início do código php -->
<?php
// Conectar ao banco de dados MySQL
$servername = "localhost";
$username = "root"; 
$password = ""; 
$database = "pwii";

$conexao = new mysqli($servername, $username, $password, $database);

// Verificar conexão
if ($conexao->connect_error) {
    die("Falha na conexão: " . $conexao->connect_error);
}

// Capturar o termo de pesquisa, se houver
$search = isset($_GET['search']) ? $_GET['search'] : "";


// Montar a consulta SQL
$sql = "SELECT *, (nota1 + nota2 + nota3 + nota4) / 4 AS media FROM alunoconcluinte";
if (!empty($search)) {
    $sql .= " WHERE nome LIKE '%$search%'";
}
$sql .= " ORDER BY media DESC";

$result = $conexao->query($sql);
?>

<!-- Inicio do código HTML -->
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <title>Agenda 06</title>
</head>

<body>
    <h1>Alunos concluintes</h1>

    <div>
    <!-- Formulário de pesquisa e botões de buscar e voltar -->
    <form method="GET">
        <input type="text" name="search" placeholder="Buscar aluno..."value="<?= htmlspecialchars($search) ?>">
        <button type="submit">Buscar</button>    
    </form>
    <button onclick="window.location.href='index.php'">Voltar</button>
    </div>

    <!-- Tabela de alunos -->
    <table>
        <tr>
            <th>Nome</th>
            <th>Nota 1</th>
            <th>Nota 2</th>
            <th>Nota 3</th>
            <th>Nota 4</th>
            <th>Média</th>
        </tr>

        <?php while ($row = $result->fetch_assoc()): ?>
        <tr>
            <td><?= htmlspecialchars($row['nome']) ?></td>
            <td><?= $row['nota1'] ?></td>
            <td><?= $row['nota2'] ?></td>
            <td><?= $row['nota3'] ?></td>
            <td><?= $row['nota4'] ?></td>
            <td><strong><?= number_format($row['media'], 2) ?></strong></td>
        </tr>
        <?php endwhile; ?>
    </table>
    </body>
</html>

<?php
// Fechar conexão
$conexao->close();
?>
