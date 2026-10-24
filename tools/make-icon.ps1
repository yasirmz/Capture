<#
  Writes src\Capture\app.ico (the exe, Explorer and Start menu icon) from the drawing the app itself uses for its
  window (src\Capture\App\AppIconArt.cs): the grey plate, the grey replay arc and arrow, and the dot in the theme's beige.
  Build the solution first, then build again so the exe takes the new icon.
#>
param([string]$Out = (Join-Path $PSScriptRoot '..\src\Capture\app.ico'))
$exe = Join-Path $PSScriptRoot '..\src\Capture\bin\x64\Debug\net9.0-windows\win-x64\Capture.exe'
if (-not (Test-Path $exe)) { throw "Build Capture.sln first: $exe not found" }
& $exe --write-icon ([System.IO.Path]::GetFullPath($Out)) | Out-String | Write-Output
