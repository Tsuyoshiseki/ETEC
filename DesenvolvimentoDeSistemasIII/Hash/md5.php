<?php
$texto = "MinhaSenha123";
$hash = md5($texto);

echo "Texto original: $texto<br>";
echo "Hash MD5: $hash";
?>