# Leer el contenido del archivo resultado.txt
$contenidoResultado = Get-Content resultado.txt

# Texto adicional para añadir al final
$textoAdicional = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."

# Inicializar la variable que contendrá el texto adicional final
$textoAdicionalFinal = ""

# Añadir el texto adicional 4 veces
for ($i = 0; $i -lt 4; $i++) {
    $textoAdicionalFinal += $textoAdicional + "`n`n"
}

# Combinar el contenido existente con el texto adicional
$contenidoFinal = $contenidoResultado + $textoAdicionalFinal

# Escribir el contenido combinado en final.txt
$contenidoFinal | Out-File -FilePath final.txt

# Opcional: Mostrar el contenido de final.txt en la consola
Get-Content final.txt






