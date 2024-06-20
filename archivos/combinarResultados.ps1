## Ejecutar ecuacion1.ps1 y ecuacion2.ps1 y capturar sus salidas
& .\ecuacion1.ps1
$resultado1 = Get-Content ecuacion1.txt

& .\ecuacion2.ps1
$resultado2 = Get-Content ecuacion2.txt

# Combinar los resultados
$resultadosCombinados = $resultado1 + $resultado2

# Exportar los resultados combinados a un archivo
$resultadosCombinados | Out-File -FilePath resultado.txt

# Opcional: Mostrar el contenido de resultado.txt en la consola
Get-Content resultado.txt


