# Module 2 - Practical 2b: Student Record Management PWA

To create a Student Record Management Progressive Web Application with offline support and installability. Index.html <!DOCTYPE html> <html lang="en"> <head> <meta charset="UTF-8"> <meta name="viewport" content="width=device-width, initial-scale=1.0"> <title>Student Records PWA</title> <link rel="manifest" href="manifest.json" /> <meta name="theme-color" content="#2E75B6" /> <style> body { font-family: Arial, sans-serif; max-width: 600px; margin: auto; padding: 20px; } input, select { width: 100%; padding: 8px; margin: 5px 0; box-sizing: border-box; } button { background: #2E75B6;

[Back to index](../../README.md) | [Original practical PDF](source.pdf) | [Unedited extracted text](source-text.txt)

Original PDF pages **62-66** (printed pages 59-63). The PDF includes its existing output screenshots where present.

## Code files

- [index.html](index.html)

## Setup and source limitations

The PDF contains HTML and localStorage logic only. It references manifest.json and /sw.js, but neither is supplied here. Add these and manifest icons for offline page loading and installability. Records are stored in this browser.

Serve each completed PWA from its own site root on localhost or HTTPS. The original code uses root-relative paths such as /sw.js; these need adjustment when deploying beneath a GitHub Pages repository path. Uploading code to a GitHub repository only stores the files.

## Extraction notes

Page headers, footers and output labels were removed from code. Code split between pages was joined. The original PDF and raw extracted text remain available for comparison.

- Closed the incomplete BSc CS option tag.
- Removed an undecodable heading icon and normalized the HTML filename.

## Validation

See [VALIDATION.md](../../VALIDATION.md) for checks performed and what has not been run. These are source examples to place in the appropriate project, not complete Visual Studio solutions.
