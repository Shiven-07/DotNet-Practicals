# Module 2 - Practical 2a: PWA with Offline Mode using Service Worker

To develop a PWA that works in offline mode using Service Worker with cache-first strategy.

[Back to index](../../README.md) | [Original practical PDF](source.pdf) | [Unedited extracted text](source-text.txt)

Original PDF pages **60-61** (printed pages 57-58). The PDF includes its existing output screenshots where present.

## Code files

- [service-worker.js](service-worker.js)

## Setup and source limitations

Only the service worker is provided. The listed HTML, CSS, app.js, icons and offline page, plus registration code, must exist in a host site. Missing listed assets can make precaching fail. Integrate this worker into an existing PWA.

Serve each completed PWA from its own site root on localhost or HTTPS. The original code uses root-relative paths such as /sw.js; these need adjustment when deploying beneath a GitHub Pages repository path. Uploading code to a GitHub repository only stores the files.

## Extraction notes

Page headers, footers and output labels were removed from code. Code split between pages was joined. The original PDF and raw extracted text remain available for comparison.

## Validation

See [VALIDATION.md](../../VALIDATION.md) for checks performed and what has not been run. These are source examples to place in the appropriate project, not complete Visual Studio solutions.
