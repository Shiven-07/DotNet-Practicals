# Module 2 - Practical 3a: HTML Page with Link to manifest.json

To create an HTML page as the starting point of a PWA application and link it to a manifest.json file for app configuration. Index.html <!DOCTYPE html> <html lang="en"> <head> <meta charset="UTF-8" /> <meta name="viewport" content="width=device-width, initial-scale=1.0" /> <meta name="description" content="My Progressive Web App" /> <meta name="theme-color" content="#1F4E79" /> <!-- Link to manifest.json --> <link rel="manifest" href="manifest.json" /> <!-- Icon for iOS --> <link rel="apple-touch-icon" href="icons/icon-192.png" /> <title>My PWA</title> <link rel="stylesheet" href="style.css" /> </head> <body> <div id="app"> <h1>Welcome to My PWA</h1> <p>This app works online and offline!</p> <p id="status">Checking connection...</p> </div> <script> // Check online status function updateStatus() { document.getElementById('status').textContent =

[Back to index](../../README.md) | [Original practical PDF](source.pdf) | [Unedited extracted text](source-text.txt)

Original PDF pages **67-70** (printed pages 64-67). The PDF includes its existing output screenshots where present.

## Code files

- [index.html](index.html)
- [manifest.json](manifest.json)

## Setup and source limitations

The source references style.css, /sw.js and PNG icons that are not supplied in this section. Add them to complete the PWA. A manifest alone does not make page loading work offline.

Serve each completed PWA from its own site root on localhost or HTTPS. The original code uses root-relative paths such as /sw.js; these need adjustment when deploying beneath a GitHub Pages repository path. Uploading code to a GitHub repository only stores the files.

## Extraction notes

Page headers, footers and output labels were removed from code. Code split between pages was joined. The original PDF and raw extracted text remain available for comparison.

- Repaired the visibly corrupted icons array: removed duplicate text and completed the 512px entry using the same fields as the 192px entry. This completion is inferred; source.pdf preserves the original.
- Removed undecodable status icons and normalized HTML/JSON filename casing.

## Validation

See [VALIDATION.md](../../VALIDATION.md) for checks performed and what has not been run. These are source examples to place in the appropriate project, not complete Visual Studio solutions.
