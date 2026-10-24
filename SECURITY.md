# Security

## Reporting a vulnerability

Please don't open a public issue for a security problem. Report it privately on GitHub instead: on this repository, open **Security**, then **Report a vulnerability**. Only the maintainer sees it.

Tell us what you found, how to reproduce it, and which Capture version you used (Settings → General, at the foot of the page). We reply as soon as we can and credit you in the release notes if you like.

## Supported versions

Only the latest release gets security fixes. Capture updates itself from inside the app, so the fix reaches you there.

## Getting Capture safely

- Download Capture only from [the releases page](https://github.com/yasirmz/Capture/releases).
- Each release lists the SHA-256 of its files. To check a download, run this in PowerShell and compare the result with the release page:

  ```powershell
  Get-FileHash .\Capture-Setup.exe
  ```

- Updates come from the same releases page over HTTPS, and Velopack checks each update against the checksum the release lists before putting it in.
- The auto captions engine and model are downloaded only after you agree, and Capture checks their SHA-256 before using them.

## What Capture does with your data

See [Privacy](README.md#privacy) in the README: what Capture keeps on your PC, and the only times it goes online.

## Libraries

Capture is built on libobs (OBS Studio), FFmpeg, ONNX Runtime, whisper.cpp, Velopack and Microsoft Edge WebView2. A problem in one of them is best reported to that project too; Capture ships their fixes in its next release.

---

## الإبلاغ عن ثغرة أمنية

لا تفتح بلاغًا عامًا عن مشكلة أمنية. أبلغ عنها بشكل خاص على GitHub: افتح **Security** في هذا المستودع، ثم **Report a vulnerability**. لا يراها إلا المشرف على المشروع.

اذكر ما وجدته، وكيف يمكن تكرار المشكلة، ورقم إصدار Capture الذي استخدمته. لا تصل الإصلاحات الأمنية إلا إلى أحدث إصدار، ويحدّث Capture نفسه من داخل التطبيق.

نزّل Capture من [صفحة الإصدارات](https://github.com/yasirmz/Capture/releases) فقط. تذكر كل نسخة بصمة SHA-256 لملفاتها، وتستطيع مطابقتها بالأمر `Get-FileHash .\Capture-Setup.exe` في PowerShell.
