# PowerShell

# Generar una cadena aleatoria de 10 caracteres
$random = -join ((65..90) + (97..122) | Get-Random -Count 10 | % {[char]$_})

# Crear un archivo de texto en el escritorio con el contenido aleatorio
$random | Out-File "$([Environment]::GetFolderPath("Desktop"))\file.txt"