<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="media/logo-dark.png">
    <img src="media/logo-light.png" alt="Capture" width="360">
  </picture>
</p>

<h3 align="center">Instant Replay für Windows-Spiele.</h3>

<p align="center">
  Drück eine Taste oder sag deinen Satz – und die letzten fünf Minuten sind gespeichert.<br>
  Kostenlos, Open Source, offline und so leicht, dass du vergisst, dass es läuft.
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
  <a href="README.pt-BR.md">Português (Brasil)</a> ·
  <b>Deutsch</b>
</p>

## Warum Capture

- **Verpass keinen Moment.** Capture hält die letzten 15 Sekunden bis 20 Minuten (standardmäßig 5) auf deiner Festplatte oder im RAM. Drück `Alt+F10`, und daraus wird ein Clip.
- **Smart Save.** Nimm einen eigenen Satz auf, in jeder Sprache, und sag ihn einfach, um einen Clip zu speichern oder einen Screenshot aufzunehmen. Läuft offline.
- **Leicht.** Aufgenommen wird auf der Grafikkarte. Gemessen mit einem laufenden Spiel in 1440p60 AV1: 0,4 % CPU, keine verlorenen Frames.
- **Direkt bearbeiten.** Schneiden, Tempo ändern, Text einfügen, zeichnen, weichzeichnen und automatische Untertitel auf deinem eigenen PC erstellen.
- **Teilen mit einem Klick.** Poste auf X, TikTok und Instagram oder auf allen dreien mit einer Beschreibung – oder kopiere den Clip und füge ihn überall ein.
- **Privat.** Kein Konto, keine Telemetrie. Deine Clips bleiben auf deinem PC, bis du sie teilst.

## Download

1. Lade **Capture-Setup.exe** aus dem [neuesten Release](https://github.com/yasirmz/Capture/releases/latest) herunter.
2. Starte sie und folge den Schritten: Wähle Sprache und Ordner (ohne Administratorrechte) und ob du eine Desktop-Verknüpfung möchtest und Capture mit Windows starten soll.
3. Spiel und drück `Alt+F10`, wenn etwas passiert.

Windows warnt eventuell vor einem unbekannten Herausgeber (der Installer ist noch nicht signiert): wähle **Weitere Informationen** und dann **Trotzdem ausführen**.
Updates kommen direkt in der App und nie während einer Aufnahme. Beim Deinstallieren bleiben deine Clips und Einstellungen erhalten.

**Voraussetzungen:** Windows 10 (2004 oder neuer) oder Windows 11, 64 Bit. Empfohlen wird eine Grafikkarte mit Video-Encoder (NVIDIA, AMD oder Intel).

## Funktionen

<details>
<summary>Alles, was Capture kann</summary>

- **Aufnahme:** ganzer Bildschirm, bis zu 5 Apps (die im Vordergrund wird aufgenommen) oder Spiele (automatisch erkannt, auch gestreckt und im exklusiven Vollbild), bis 4K bei 30 bis 240 fps.
- **Sofortwiederholung:** bis zu 20 Minuten, auf der Festplatte (SSD oder HDD) oder im RAM, ein kurzer Clip daneben und auf Wunsch ein Neustart nach jedem Speichern.
- **Automatische Qualität:** Capture wählt Encoder, Größe, Bildrate und Qualität, die dein PC am besten aufnimmt, und geht bei verlorenen Bildern selbst eine Stufe runter.
- **Kodierung:** AV1, HEVC oder H.264 auf NVIDIA (NVENC), AMD (AMF) oder Intel (Quick Sync); startet einer nicht, nimmt der nächste auf, bis hin zu x264.
- **Audio:** ein Mixer mit einer Zeile pro Quelle (Spiel, Discord, Musik, Mikrofon, jede App oder jedes Gerät), jede mit eigener Lautstärke und auf Wunsch eigener Spur.
- **Kamera:** deine Webcam oder dein Handy in einer Ecke (eckig oder rund) oder oben in einem 9:16-Bild, auf Wunsch auch einzeln gespeichert.
- **Aufnahmen:** mit Tastenkürzeln starten, pausieren und stoppen; eine pausierte Aufnahme bleibt eine Datei.
- **Screenshots** mit eigenem Tastenkürzel, gespeichert neben deinen Clips.
- **Bibliothek:** Clips und Screenshots nach Tag, nach Spiel gefiltert; einen Clip direkt in Discord ziehen; ein Ordner-Limit; in OneDrive, Dropbox oder Google Drive speichern und lokale Kopien freigeben.
- **Editor:** Schneiden und Zusammenfügen, Tempo und Ton pro Teil (alle Spuren), in einen Bereich zoomen, Text in vielen Schriften und Stilen, automatische Untertitel, Zeichnen, Formen, Weichzeichnen, Filter und Zuschneiden für Screenshots.
- **Automatische Untertitel:** Whisper auf deiner Grafikkarte. Engine und Modell werden einmal heruntergeladen, nachdem du zugestimmt hast, und lassen sich in den Einstellungen entfernen.
- **Teilen:** X, TikTok, Instagram oder alle zusammen über die Seite der jeweiligen Plattform; Kopieren passend zu Discords 10, 50 oder 500 MB; Kürzen auf einem Bildstreifen und Zuschneiden auf 9:16; Kopien bleiben im Ordner Shared deines Clip-Ordners.
- **Hilfe:** „Bericht speichern“ auf der Statusseite legt Protokolle und Einstellungen als ZIP auf den Desktop, zum Anhängen an ein GitHub-Issue.
- **Sieben Sprachen:** Englisch, Arabisch, Chinesisch, Russisch, Spanisch, Portugiesisch und Deutsch. Beim ersten Start folgt Capture der Windows-Sprache.
- **Leise:** startet mit Windows im Infobereich, ohne Pop-ups oder Töne, außer du schaltest sie ein.

</details>

## Datenschutz

- Keine Telemetrie, keine Analysen, kein Capture-Konto.
- Capture geht nur online, um einmal am Tag auf GitHub nach einer neuen Version zu suchen und sie herunterzuladen (abschaltbar), um über die Seite der jeweiligen Plattform zu posten, was du teilst, und um die automatischen Untertitel einmal herunterzuladen, nachdem du zugestimmt hast (die Engine von GitHub, das Modell von Hugging Face).
- Deine Clips bleiben in deinem Clip-Ordner (synchronisiert nur, wenn du einen OneDrive-, Dropbox- oder Google-Drive-Ordner wählst), deine Einstellungen und Protokolle auf deinem PC. Smart Save und automatische Untertitel hören nur auf deinem PC zu, und dein Smart-Save-Satz wird nur dort aufgenommen.
- Anmeldungen bei den Seiten bleiben in Capture' eigenem Browser auf deinem PC (Microsoft Edge WebView2, von Windows geschützt wie in Edge), nie in den Einstellungen oder Protokollen von Capture. Wenn du dich von einer Seite abmeldest, wirst du auch vom Google-, Apple- oder Facebook-Konto abgemeldet, mit dem du dich dort angemeldet hast.
- **Bericht speichern** enthält die Protokolle und Einstellungen von Capture ohne deinen Windows-Benutzernamen und ohne Fenstertitel, und nie Anmeldungen oder Clips.
- Eine Sicherheitslücke gefunden? Bitte melde sie vertraulich: siehe [SECURITY.md](../SECURITY.md).

## Häufige Fragen

**Ist Capture mit Anti-Cheat sicher?**

Capture liest oder verändert nie den Speicher eines Spiels. Um ein Spiel im Vollbild aufzunehmen (in jedem Modus, damit ein gestrecktes oder exklusives Vollbild nie schwarz ist), nutzt es denselben signierten, Anti-Cheat-kompatiblen Aufnahme-Hook wie OBS Studio, den Riot Vanguard, Easy Anti-Cheat und BattlEye zulassen. Gibt ein Spiel über den Hook einmal kein Bild, nimmt Capture von selbst den Bildschirm auf, sodass kein Clip schwarz ist.

**Erscheint beim Aufnehmen ein gelber Rahmen?**

Unter Windows 11 nicht. Unter Windows 10 zeichnet Windows selbst im Modus **Apps** einen gelben Rahmen um die App und lässt Programme ihn nicht ausblenden; **Ganzer Bildschirm** und **Spiele** zeigen nie einen.

**Meine Clips ruckeln über 60 fps.**

Ein Clip kann nicht flüssiger sein als dein Bildschirm oder dein Spiel: 144 fps auf einem 60-Hz-Bildschirm wiederholen Bilder ungleichmäßig. Capture weist unter der Bildrate darauf hin, und **Automatisch** unter Qualität nimmt nie über der Bildwiederholrate deines Bildschirms auf. 60 passt für YouTube, X, TikTok und Instagram.

**Etwas funktioniert nicht. Was soll ich senden?**

Klicke auf der Statusseite auf **Bericht speichern**: Ein ZIP mit den Protokollen und Einstellungen von Capture landet auf deinem Desktop. Häng es an ein [GitHub-Issue](https://github.com/yasirmz/Capture/issues) an.

## Aus dem Quellcode bauen

<details>
<summary>Für Entwickler</summary>

Capture ist eine .NET-10-App (WPF und WinForms), die **libobs**, die Engine von [OBS Studio](https://obsproject.com), nur mit den nötigen Modulen einbindet und FFmpeg zum Bearbeiten und Teilen nutzt.

```powershell
.\tools\build-whisper.ps1               # once: the auto captions engine (needs the Vulkan SDK and VS Build Tools)
.\tools\release.ps1                     # the Setup, update files and source zip in releases\ (needs vpk 1.2.161)
dotnet run --project tests\Capture.Tests # the tests
```

Der Build kopiert libobs 32.2.2 aus einem installierten OBS Studio.

</details>

## Lizenz

Capture ist freie Software unter der [GNU General Public License v2.0 oder neuer](../LICENSE), derselben Lizenz wie libobs. Jedes Release enthält den vollständigen Quellcode. Komponenten von Drittanbietern und ihre Lizenzen stehen in [THIRD-PARTY-NOTICES.md](../THIRD-PARTY-NOTICES.md).

<sub>Capture basiert auf [Kairos](https://github.com/BasilForge/Kairos) von BasilForge, unter derselben Lizenz.</sub>
