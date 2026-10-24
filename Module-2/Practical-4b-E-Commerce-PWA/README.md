# Module 2 - Practical 4b: E-Commerce PWA with Product Listing and Offline Cart

To develop an E-Commerce Progressive Web Application with product listing and offline cart functionality using Service Worker and local Storage.

[Back to index](../../README.md) | [Original practical PDF](source.pdf) | [Unedited extracted text](source-text.txt)

Original PDF pages **78-87** (printed pages 75-84). The PDF includes its existing output screenshots where present.

## Code files

- [index.html](index.html)

## Setup and source limitations

The PDF supplies HTML/cart code but omits manifest.json, /sw.js and PWA icons. Add them for offline page loading and installation. Checkout is only an alert demo: it does not submit orders or queue them on reconnection, despite the original alert wording. The cart uses localStorage.

Serve each completed PWA from its own site root on localhost or HTTPS. The original code uses root-relative paths such as /sw.js; these need adjustment when deploying beneath a GitHub Pages repository path. Uploading code to a GitHub repository only stores the files.

## Extraction notes

Page headers, footers and output labels were removed from code. Code split between pages was joined. The original PDF and raw extracted text remain available for comparison.

- Restored the missing keyboard-icon closing quote and the opening braces for addToCart and the offline checkout branch.
- Restored the service-worker feature-check closing brace and the missing initial 0 in the cart quantity reduction, which is needed for an empty cart.
- Removed undecodable decorative icons; product names and prices remain intact.

## Validation

See [VALIDATION.md](../../VALIDATION.md) for checks performed and what has not been run. These are source examples to place in the appropriate project, not complete Visual Studio solutions.
