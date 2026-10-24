# Module 2 - Practical 1a: College Information Portal as PWA

To create a simple website for a College Information Portal and convert it into a Progressive Web Application (PWA) by adding a Service Worker and Web App Manifest.

[Back to index](../../README.md) | [Original practical PDF](source.pdf) | [Unedited extracted text](source-text.txt)

Original PDF pages **50-56** (printed pages 47-53). The PDF includes its existing output screenshots where present.

## Code files

- [index.html](index.html)
- [style.css](style.css)
- [service-worker.js](service-worker.js)
- [manifest.json](manifest.json)

## Setup and source limitations

HTML, stylesheet, manifest and service worker are supplied. Referenced PNG icons are not supplied by the PDF. Add them at the manifest paths for a complete installable PWA.

Serve each completed PWA from its own site root on localhost or HTTPS. The original code uses root-relative paths such as /sw.js; these need adjustment when deploying beneath a GitHub Pages repository path. Uploading code to a GitHub repository only stores the files.

## Extraction notes

Page headers, footers and output labels were removed from code. Code split between pages was joined. The original PDF and raw extracted text remain available for comparison.

- Saved the plain HTML as index.html to match the manifest (PDF heading: Index.cshtml); normalized CSS/JS/JSON filename casing to match the HTML.
- Changed cache entry /css/site.css to /style.css, matching the supplied stylesheet.
- Removed decorative characters that the PDF text layer could not decode.

## Validation

See [VALIDATION.md](../../VALIDATION.md) for checks performed and what has not been run. These are source examples to place in the appropriate project, not complete Visual Studio solutions.
