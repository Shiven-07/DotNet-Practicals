# Module 2 - Practical 1b: PWA with Custom Offline Page

To create a PWA that displays a custom offline page when the user is not connected to the internet.

[Back to index](../../README.md) | [Original practical PDF](source.pdf) | [Unedited extracted text](source-text.txt)

Original PDF pages **57-59** (printed pages 54-56). The PDF includes its existing output screenshots where present.

## Code files

- [offline.html](offline.html)
- [service-worker.js](service-worker.js)

## Setup and source limitations

This offline-page extension expects a home page at /, /style.css and worker registration code. Those are not provided in this section. Integrate it with the college portal practical or an existing site.

Serve each completed PWA from its own site root on localhost or HTTPS. The original code uses root-relative paths such as /sw.js; these need adjustment when deploying beneath a GitHub Pages repository path. Uploading code to a GitHub repository only stores the files.

## Extraction notes

Page headers, footers and output labels were removed from code. Code split between pages was joined. The original PDF and raw extracted text remain available for comparison.

- Normalized offline.html casing to match the service worker.
- Removed an undecodable decorative icon.

## Validation

See [VALIDATION.md](../../VALIDATION.md) for checks performed and what has not been run. These are source examples to place in the appropriate project, not complete Visual Studio solutions.
