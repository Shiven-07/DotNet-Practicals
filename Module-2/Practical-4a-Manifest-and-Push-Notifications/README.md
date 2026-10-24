# Module 2 - Practical 4a: PWA Manifest and Push Notifications

To create a PWA with a complete Web App Manifest file (app name, icons, start URL, display mode)and implement Push Notifications.

[Back to index](../../README.md) | [Original practical PDF](source.pdf) | [Unedited extracted text](source-text.txt)

Original PDF pages **74-77** (printed pages 71-74). The PDF includes its existing output screenshots where present.

## Code files

- [manifest.json](manifest.json)
- [push-notification.js](push-notification.js)
- [service-worker.js](service-worker.js)

## Setup and source limitations

These are snippets. The source leaves YOUR_VAPID_PUBLIC_KEY as a placeholder and omits urlBase64ToUint8Array, the /api/subscribe backend, push-sending code, HTML entry point, registration code and icons. Remote push needs this setup. The local notification function is a separate demo. No keys or credentials have been generated.

Serve each completed PWA from its own site root on localhost or HTTPS. The original code uses root-relative paths such as /sw.js; these need adjustment when deploying beneath a GitHub Pages repository path. Uploading code to a GitHub repository only stores the files.

## Extraction notes

Page headers, footers and output labels were removed from code. Code split between pages was joined. The original PDF and raw extracted text remain available for comparison.

- Moved the worker push handler into service-worker.js, as directed by the PDF comment, and removed a repeated filename heading.

## Validation

See [VALIDATION.md](../../VALIDATION.md) for checks performed and what has not been run. These are source examples to place in the appropriate project, not complete Visual Studio solutions.
