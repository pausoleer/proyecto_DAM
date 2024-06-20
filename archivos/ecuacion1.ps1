# Coeficientes para la ecuación de segundo grado ax^2 + bx + c = 0
$a = 1
$b = -3
$c = 2

# Calculando el discriminante
$discriminante = $b * $b - 4 * $a * $c

# Calculando las soluciones
if ($discriminante -eq 0) {
    $x = -($b / (2 * $a))
    $solucion = "La ecuación tiene una solución: $x"
} elseif ($discriminante -gt 0) {
    $x1 = (-$b + [Math]::Sqrt($discriminante)) / (2 * $a)
    $x2 = (-$b - [Math]::Sqrt($discriminante)) / (2 * $a)
    $solucion = "La ecuación tiene dos soluciones: $x1 y $x2"
} else {
    $solucion = "La ecuación no tiene soluciones reales."
}

# Exportando el resultado a un archivo
$solucion | Out-File -FilePath ecuacion1.txt
