<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="media/logo-dark.png">
    <img src="media/logo-light.png" alt="Capture" width="360">
  </picture>
</p>

<h3 align="center">Replay instantâneo para jogos no Windows.</h3>

<p align="center">
  Aperte uma tecla ou diga sua frase, e os últimos cinco minutos são salvos.<br>
  Grátis, de código aberto, offline e tão leve que você vai esquecer que está ligado.
</p>

<p align="center">
  <a href="https://github.com/yasirmz/Capture/releases/latest/download/Capture-Setup.exe"><img src="https://img.shields.io/badge/Download-Windows%2010%20%7C%2011-D9C4A1?style=for-the-badge&logo=windows&logoColor=1C1C1E" alt="Download for Windows"></a>
  <img src="https://img.shields.io/badge/license-GPL--2.0-27272A?style=for-the-badge" alt="License: GPL-2.0">
  <img src="https://img.shields.io/badge/languages-7-27272A?style=for-the-badge" alt="7 languages">
</p>

<p align="center">
  <a href="../README.md">English</a> ·
  <a href="README.ar.md">العربية</a> ·
  <a href="README.zh-Hans.md">简体中文</a> ·
  <a href="README.ru.md">Русский</a> ·
  <a href="README.es.md">Español</a> ·
  <b>Português (Brasil)</b> ·
  <a href="README.de.md">Deutsch</a>
</p>

## Por que o Capture

- **Não perca o momento.** O Capture mantém os últimos 15 segundos a 20 minutos (5 por padrão) no seu disco ou na RAM. Aperte `Alt+F10` e vira um clipe.
- **Salvamento por voz.** Grave uma frase sua, em qualquer idioma, e depois é só dizê-la para salvar um clipe ou capturar a tela. Funciona offline.
- **Leve.** Grava pela placa de vídeo. Medido com um jogo rodando em 1440p60 AV1: 0,4% de CPU, sem quadros perdidos.
- **Edite na hora.** Corte, mude a velocidade, adicione texto, desenhe, desfoque e crie legendas automáticas no seu próprio PC.
- **Compartilhe com um clique.** Publique no X, no TikTok e no Instagram, ou nos três de uma vez com uma só legenda, ou copie o clipe e cole onde quiser.
- **Privado.** Sem conta e sem telemetria. Seus clipes ficam no seu PC até você compartilhar.

## Download

1. Baixe o **Capture-Setup.exe** na [versão mais recente](https://github.com/yasirmz/Capture/releases/latest).
2. Execute e siga as etapas: escolha o idioma e a pasta (sem direitos de administrador), e se quer um atalho na área de trabalho e iniciar o Capture com o Windows.
3. Jogue e aperte `Alt+F10` quando algo acontecer.

O Windows pode avisar sobre um editor desconhecido (o instalador ainda não é assinado): escolha **Mais informações** e depois **Executar assim mesmo**.
As atualizações chegam pelo próprio app e nunca durante uma gravação. Ao desinstalar, seus clipes e configurações são mantidos.

**Requisitos:** Windows 10 (2004 ou mais recente) ou Windows 11, 64 bits. Recomenda-se uma placa de vídeo com codificador de vídeo (NVIDIA, AMD ou Intel).

## Recursos

<details>
<summary>Tudo o que o Capture faz</summary>

- **Captura:** tela inteira, até 5 apps (o que estiver na frente é gravado) ou jogos (detectados automaticamente, inclusive esticados e em tela cheia exclusiva), até 4K, de 30 a 240 fps.
- **Replay instantâneo:** até 20 minutos, no seu disco (SSD ou HDD) ou na RAM, um clipe rápido ao lado e, se quiser, recomeçar após cada clipe salvo.
- **Qualidade automática:** o Capture escolhe o codificador, o tamanho, os quadros e a qualidade com que seu PC grava melhor, e baixa um nível sozinho se quadros forem perdidos.
- **Codificação:** AV1, HEVC ou H.264 na NVIDIA (NVENC), AMD (AMF) ou Intel (Quick Sync); se um não iniciar, o próximo grava, até o x264.
- **Áudio:** um mixer com uma linha por fonte (jogo, Discord, música, microfone, qualquer app ou dispositivo), cada uma com seu volume e, se quiser, sua própria faixa.
- **Câmera:** sua webcam ou celular num canto (quadrada ou redonda) ou no topo de uma imagem 9:16, e se quiser salva à parte.
- **Gravação:** inicie, pause e pare com atalhos; uma gravação pausada continua sendo um só arquivo.
- **Capturas de tela** com atalho próprio, salvas ao lado dos clipes.
- **Biblioteca:** clipes e capturas por dia, filtrados por jogo; arraste um clipe direto para o Discord; um limite de tamanho para a pasta; salve no OneDrive, Dropbox ou Google Drive e libere as cópias locais.
- **Editor:** cortar e juntar, velocidade e som por parte (todas as faixas), zoom numa área, textos em várias fontes e estilos, legendas automáticas, desenho, formas, desfoque, filtros e recorte para capturas.
- **Legendas automáticas:** Whisper na sua placa de vídeo. O motor e o modelo são baixados uma vez, depois que você concorda, e podem ser removidos nas Configurações.
- **Compartilhar:** X, TikTok, Instagram ou todos juntos, pela página de cada site; Copiar no tamanho de 10, 50 ou 500 MB do Discord; corte numa faixa de quadros e enquadramento 9:16; as cópias ficam na pasta Shared dos seus clipes.
- **Ajuda:** "Salvar um relatório" na página Status coloca os registros e ajustes num zip na Área de Trabalho, para anexar a uma issue no GitHub.
- **Sete idiomas:** inglês, árabe, chinês, russo, espanhol, português e alemão. A primeira execução segue o idioma do Windows.
- **Discreto:** inicia com o Windows na bandeja, sem pop-ups nem sons, a menos que você os ative.

</details>

## Privacidade

- Sem telemetria, sem análises, sem conta do Capture.
- O Capture só se conecta para procurar uma versão nova no GitHub uma vez por dia e baixá-la (dá para desativar), para publicar o que você compartilha pela própria página de cada site e para baixar as legendas automáticas uma vez, depois que você concordar (o motor do GitHub, o modelo do Hugging Face).
- Seus clipes ficam na sua pasta de clipes (só são sincronizados se você escolher uma pasta do OneDrive, Dropbox ou Google Drive), e seus ajustes e registros no seu PC. O salvamento por voz e as legendas automáticas escutam só no seu PC, e a sua frase do salvamento por voz é gravada só nele.
- Os logins nos sites ficam no navegador próprio do Capture no seu PC (Microsoft Edge WebView2, protegido pelo Windows como no Edge), nunca nos ajustes ou registros do Capture. Ao sair de um site, você também sai da conta Google, Apple ou Facebook usada para entrar nele.
- **Salvar um relatório** traz os registros e ajustes do Capture sem o seu nome de usuário do Windows nem títulos de janelas, e nunca logins ou clipes.
- Achou um problema de segurança? Informe em particular: veja [SECURITY.md](../SECURITY.md).

## Perguntas frequentes

**O Capture é seguro com anti-cheats?**

O Capture nunca lê nem altera a memória do jogo. Para capturar um jogo em tela cheia (em todos os modos, para que um jogo esticado ou em tela cheia exclusiva nunca fique preto) ele usa o mesmo gancho de captura assinado e compatível com antitrapaça do OBS Studio, que o Riot Vanguard, o Easy Anti-Cheat e o BattlEye permitem. Se um jogo não der imagem pelo gancho, o Capture grava a tela sozinho, então nenhum clipe fica preto.

**Aparece uma borda amarela durante a gravação?**

No Windows 11, não. No Windows 10, o próprio Windows desenha uma borda amarela em volta do app no modo **Aplicativos** e não deixa os programas escondê-la; **Tela inteira** e **Jogos** nunca mostram borda.

**Meus clipes travam acima de 60 fps.**

Um clipe não fica mais suave que sua tela ou seu jogo: gravar a 144 fps numa tela de 60 Hz repete quadros de forma irregular. O Capture avisa isso abaixo da taxa de quadros, e o **Automático** em Qualidade nunca grava acima da taxa da sua tela. 60 serve para YouTube, X, TikTok e Instagram.

**Algo não funciona. O que eu envio?**

Clique em **Salvar um relatório** na página Status: um zip com os registros e ajustes do Capture vai para a sua Área de Trabalho. Anexe-o a uma [issue no GitHub](https://github.com/yasirmz/Capture/issues).

## Compilar a partir do código

<details>
<summary>Para desenvolvedores</summary>

O Capture é um app .NET 10 (WPF e WinForms) que usa a **libobs**, o motor do [OBS Studio](https://obsproject.com), só com os módulos de que precisa, e o FFmpeg para editar e compartilhar.

```powershell
.\tools\build-whisper.ps1               # once: the auto captions engine (needs the Vulkan SDK and VS Build Tools)
.\tools\release.ps1                     # the Setup, update files and source zip in releases\ (needs vpk 1.2.161)
dotnet run --project tests\Capture.Tests # the tests
```

A compilação copia a libobs 32.2.2 de um OBS Studio instalado.

</details>

## Licença

O Capture é software livre sob a [Licença Pública Geral GNU v2.0 ou posterior](../LICENSE), a mesma licença da libobs. Cada versão inclui seu código-fonte completo. Os componentes de terceiros e suas licenças estão em [THIRD-PARTY-NOTICES.md](../THIRD-PARTY-NOTICES.md).

<sub>O Capture é baseado no [Kairos](https://github.com/BasilForge/Kairos), da BasilForge, sob a mesma licença.</sub>
