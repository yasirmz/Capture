<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="media/logo-dark.png">
    <img src="media/logo-light.png" alt="Capture" width="360">
  </picture>
</p>

<h3 align="center">Repetición instantánea para juegos de Windows.</h3>

<p align="center">
  Pulsa una tecla o di tu frase, y se guardan los últimos cinco minutos.<br>
  Gratis, de código abierto, sin conexión y tan ligero que olvidarás que está activo.
</p>

<p align="center">
  <a href="https://github.com/yasirmz/Capture/releases/latest"><img src="https://img.shields.io/badge/Download-Windows%2010%20%7C%2011-D9C4A1?style=for-the-badge&logo=windows&logoColor=1C1C1E" alt="Download for Windows"></a>
  <img src="https://img.shields.io/badge/license-GPL--2.0-27272A?style=for-the-badge" alt="License: GPL-2.0">
  <img src="https://img.shields.io/badge/languages-7-27272A?style=for-the-badge" alt="7 languages">
</p>

<p align="center">
  <a href="../README.md">English</a> ·
  <a href="README.ar.md">العربية</a> ·
  <a href="README.zh-Hans.md">简体中文</a> ·
  <a href="README.ru.md">Русский</a> ·
  <b>Español</b> ·
  <a href="README.pt-BR.md">Português (Brasil)</a> ·
  <a href="README.de.md">Deutsch</a>
</p>

## ¿Por qué Capture?

- **No te pierdas el momento.** Capture guarda los últimos 15 segundos a 20 minutos (5 por defecto) en tu disco o en la RAM. Pulsa `Alt+F10` y se convierte en un clip.
- **Guardado por voz.** Graba una frase propia, en cualquier idioma, y luego solo dila para guardar un clip o hacer una captura. Funciona sin conexión.
- **Ligero.** Graba con tu tarjeta gráfica. Medido con un juego a 1440p60 AV1: 0,4 % de CPU y ningún fotograma perdido.
- **Edita al momento.** Recorta, cambia la velocidad, añade texto, dibuja, difumina y crea subtítulos automáticos en tu propio PC.
- **Comparte con un clic.** Publica en X, TikTok e Instagram, o en los tres a la vez con un solo texto, o copia el clip y pégalo donde quieras.
- **Privado.** Sin cuenta y sin telemetría. Tus clips se quedan en tu PC hasta que los compartes.

## Descarga

1. Descarga **Capture-Setup.exe** desde la [última versión](https://github.com/yasirmz/Capture/releases/latest).
2. Ejecútalo y sigue los pasos: elige el idioma y la carpeta (sin permisos de administrador), y si quieres un acceso directo en el escritorio y que Capture se inicie con Windows.
3. Juega y pulsa `Alt+F10` cuando pase algo.

Windows puede avisar de un editor desconocido (el instalador aún no está firmado): elige **Más información** y luego **Ejecutar de todas formas**.
Las actualizaciones llegan desde la propia app y nunca durante una grabación. Al desinstalar se conservan tus clips y tu configuración.

**Requisitos:** Windows 10 (2004 o posterior) o Windows 11, de 64 bits. Se recomienda una tarjeta gráfica con codificador de vídeo (NVIDIA, AMD o Intel).

## Funciones

<details>
<summary>Todo lo que hace Capture</summary>

- **Captura:** pantalla completa, hasta 5 aplicaciones (se graba la que está delante) o juegos (detectados automáticamente, también estirados y en pantalla completa exclusiva), hasta 4K de 30 a 240 fps.
- **Repetición instantánea:** hasta 20 minutos, en tu disco (SSD o HDD) o en la RAM, un clip rápido al lado y, si quieres, empezar de cero tras cada guardado.
- **Calidad automática:** Capture elige el codificador, el tamaño, los fotogramas y la calidad con los que mejor graba tu PC, y baja un paso por sí solo si se pierden fotogramas.
- **Codificación:** AV1, HEVC o H.264 en NVIDIA (NVENC), AMD (AMF) o Intel (Quick Sync); si uno no arranca, graba el siguiente, hasta x264.
- **Audio:** un mezclador con una fila por fuente (juego, Discord, música, micrófono, cualquier aplicación o dispositivo), cada una con su volumen y, si quieres, su propia pista.
- **Cámara:** tu webcam o móvil en una esquina (cuadrada o redonda) o arriba de una imagen 9:16, y si quieres guardada aparte.
- **Grabación:** inicia, pausa y detén con atajos; una grabación pausada sigue siendo un solo archivo.
- **Capturas** con su propio atajo, guardadas junto a tus clips.
- **Biblioteca:** clips y capturas por día, filtrados por juego; arrastra un clip directo a Discord; un límite de tamaño para la carpeta; guarda en OneDrive, Dropbox o Google Drive y libera las copias locales.
- **Editor:** cortar y unir, velocidad y sonido por parte (todas las pistas), zoom a una zona, textos con muchas fuentes y estilos, subtítulos automáticos, dibujo, formas, desenfoque, filtros y recorte para capturas.
- **Subtítulos automáticos:** Whisper en tu tarjeta gráfica. El motor y el modelo se descargan una vez, después de que aceptes, y se pueden quitar en Configuración.
- **Compartir:** X, TikTok, Instagram o todos a la vez, desde la propia página de cada sitio; Copiar ajustado a los 10, 50 o 500 MB de Discord; recorte sobre una tira de fotogramas y encuadre 9:16; las copias se guardan en la carpeta Shared de tus clips.
- **Ayuda:** «Guardar un informe» en la página Estado deja los registros y ajustes en un zip en tu escritorio, para adjuntarlo a un issue de GitHub.
- **Siete idiomas:** inglés, árabe, chino, ruso, español, portugués y alemán. La primera vez sigue el idioma de Windows.
- **Silencioso:** se inicia con Windows en la bandeja, sin ventanas emergentes ni sonidos salvo que los actives.

</details>

## Privacidad

- Sin telemetría, sin analíticas, sin cuenta de Capture.
- Capture solo se conecta para buscar una versión nueva en GitHub una vez al día y descargarla (puedes desactivarlo), para publicar lo que compartes a través de la propia página de cada sitio y para descargar una vez los subtítulos automáticos, después de que aceptes (el motor desde GitHub, el modelo desde Hugging Face).
- Tus clips se quedan en tu carpeta de clips (solo se sincronizan si eliges una carpeta de OneDrive, Dropbox o Google Drive), y tus ajustes y registros en tu PC. El guardado por voz y los subtítulos automáticos escuchan solo en tu PC, y tu frase de guardado por voz se graba solo ahí.
- Las sesiones de los sitios se quedan en el navegador propio de Capture en tu PC (Microsoft Edge WebView2, protegido por Windows como en Edge), nunca en los ajustes ni en los registros de Capture. Al cerrar sesión en un sitio, también se cierra la sesión de la cuenta de Google, Apple o Facebook que usaste para entrar.
- **Guardar un informe** incluye los registros y ajustes de Capture sin tu nombre de usuario de Windows ni los títulos de las ventanas, y nunca sesiones ni clips.
- ¿Encontraste un problema de seguridad? Infórmalo en privado: consulta [SECURITY.md](../SECURITY.md).

## Preguntas frecuentes

**¿Capture es seguro con los antitrampas?**

Capture nunca lee ni cambia la memoria del juego. Para capturar un juego a pantalla completa (en todos los modos, para que uno estirado o en pantalla completa exclusiva nunca salga negro) usa el mismo gancho de captura firmado y compatible con antitrampas que OBS Studio, que Riot Vanguard, Easy Anti-Cheat y BattlEye permiten. Si un juego no da imagen con el gancho, Capture graba la pantalla por sí solo, así que ningún clip sale negro.

**¿Aparece un borde amarillo al grabar?**

En Windows 11, no. En Windows 10, el propio Windows dibuja un borde amarillo alrededor de la aplicación en el modo **Aplicaciones** y no deja que los programas lo oculten; **Pantalla completa** y **Juegos** nunca lo muestran.

**Mis clips van a tirones por encima de 60 fps.**

Un clip no puede ser más fluido que tu pantalla o tu juego: grabar a 144 fps en una pantalla de 60 Hz repite fotogramas de forma desigual. Capture lo avisa bajo la tasa de fotogramas, y **Automático** en Calidad nunca graba por encima de la frecuencia de tu pantalla. 60 va bien para YouTube, X, TikTok e Instagram.

**Algo no funciona. ¿Qué envío?**

Pulsa **Guardar un informe** en la página Estado: en tu escritorio aparece un zip con los registros y ajustes de Capture. Adjúntalo a un [issue de GitHub](https://github.com/yasirmz/Capture/issues).

## Compilar desde el código

<details>
<summary>Para desarrolladores</summary>

Capture es una app de .NET 10 (WPF y WinForms) que integra **libobs**, el motor de [OBS Studio](https://obsproject.com), solo con los módulos que necesita, y usa FFmpeg para editar y compartir.

```powershell
.\tools\build-whisper.ps1               # once: the auto captions engine (needs the Vulkan SDK and VS Build Tools)
.\tools\release.ps1                     # the Setup, update files and source zip in releases\ (needs vpk 1.2.161)
dotnet run --project tests\Capture.Tests # the tests
```

La compilación copia libobs 32.2.2 desde un OBS Studio instalado.

</details>

## Licencia

Capture es software libre bajo la [Licencia Pública General de GNU v2.0 o posterior](../LICENSE), la misma licencia que libobs. Cada versión incluye su código fuente completo. Los componentes de terceros y sus licencias están en [THIRD-PARTY-NOTICES.md](../THIRD-PARTY-NOTICES.md).

<sub>Capture se basa en [Kairos](https://github.com/BasilForge/Kairos), de BasilForge, con la misma licencia.</sub>
