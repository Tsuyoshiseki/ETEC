<?php
$texto = "MinhaSenha123";
$hash = sha1($texto);

echo "Texto original: $texto<br>";
echo "Hash SHA1: $hash";
?>