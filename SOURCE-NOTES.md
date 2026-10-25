# Corrections and source gaps

The PDFs are page-for-page copies of the supplied source. Raw extracted text is retained before code cleanup. Corrections below apply only to editable source files.

## Added practical

Module 1 Practical 4c (AdRotator) appears in the original index only. A [new self-contained Web Forms example](Module-1/Practical-4c-AdRotator/README.md) has been added with its own page, XML ad list, three SVG banners and local destination pages. It was written for this collection and is not extracted from, or a recreation of missing pages in, the original PDF.

## [Module 1 / 1a: MVC Application for Basic Arithmetic Operations](Module-1/Practical-1a-MVC-Arithmetic/README.md)

- Rejoined Bootstrap class names split over PDF lines, such as btn-primary.

Create the ASP.NET Core MVC project ArithmeticMVC as described in the PDF (.NET 6 or .NET 8). Copy the files into matching template folders. Keep the template startup, layout and tag-helper imports. Open /Home/Index.

## [Module 1 / 4a: Student Registration Form](Module-1/Practical-4a-Student-Registration/README.md)

- Rejoined the string "Not Selected" split over PDF lines.

Create an ASP.NET Web Application (.NET Framework), select Web Forms, and name it StudentRegForm. Use the template to generate designer and project files; copy these two files into it. ASP.NET Core templates do not support Web Forms controls.

## [Module 1 / 4b: Registration Form with Validation Controls](Module-1/Practical-4b-Validation-Controls/README.md)

The PDF supplies only ASPX markup. It references Validation.aspx.cs, class StudentRegForm.Validation, and handler btnReg_Click, but does not supply their code. Those pieces and the Web Forms designer must be supplied in a .NET Framework Web Forms project before running this example.

## [Module 1 / 5a: Different Types of Cookies](Module-1/Practical-5a-Cookies/README.md)

- Named the controller file CookieController.cs to match the class; the PDF heading says CookiesController.cs.

Create an ASP.NET Core MVC project named CookieDemo, copy these files into the indicated folders, keep the template startup files, and open /Cookie/Index. The code demonstrates a persistent cookie with a seven-day expiry. A separate session-cookie example is absent despite the stated aim.

## [Module 1 / 5b: Product Table with EF Core (Insert Operation)](Module-1/Practical-5b-EF-Core-Product-Insert/README.md)

- Wrapped the partial connection string in a complete JSON object, closed ConnectionStrings, and rejoined MultipleActiveResultSets.

Create an ASP.NET Core MVC project named WebApplication5 and copy these files, keeping template tag-helper imports. Install Entity Framework Core, SqlServer and Tools packages for the target framework, then follow the PDF migration steps. SQL Server LocalDB and database setup are required. Open /Product/Index; the source startup defaults to a Home route whose controller is not supplied in the PDF.

## [Module 2 / 1a: College Information Portal as PWA](Module-2/Practical-1a-College-Portal-PWA/README.md)

- Saved the plain HTML as index.html to match the manifest (PDF heading: Index.cshtml); normalized CSS/JS/JSON filename casing to match the HTML.

- Changed cache entry /css/site.css to /style.css, matching the supplied stylesheet.

- Removed decorative characters that the PDF text layer could not decode.

HTML, stylesheet, manifest and service worker are supplied. Referenced PNG icons are not supplied by the PDF. Add them at the manifest paths for a complete installable PWA.

## [Module 2 / 1b: PWA with Custom Offline Page](Module-2/Practical-1b-Custom-Offline-Page/README.md)

- Normalized offline.html casing to match the service worker.

- Removed an undecodable decorative icon.

This offline-page extension expects a home page at /, /style.css and worker registration code. Those are not provided in this section. Integrate it with the college portal practical or an existing site.

## [Module 2 / 2a: PWA with Offline Mode using Service Worker](Module-2/Practical-2a-Offline-Service-Worker/README.md)

Only the service worker is provided. The listed HTML, CSS, app.js, icons and offline page, plus registration code, must exist in a host site. Missing listed assets can make precaching fail. Integrate this worker into an existing PWA.

## [Module 2 / 2b: Student Record Management PWA](Module-2/Practical-2b-Student-Records-PWA/README.md)

- Closed the incomplete BSc CS option tag.

- Removed an undecodable heading icon and normalized the HTML filename.

The PDF contains HTML and localStorage logic only. It references manifest.json and /sw.js, but neither is supplied here. Add these and manifest icons for offline page loading and installability. Records are stored in this browser.

## [Module 2 / 3a: HTML Page with Link to manifest.json](Module-2/Practical-3a-HTML-and-Manifest/README.md)

- Repaired the visibly corrupted icons array: removed duplicate text and completed the 512px entry using the same fields as the 192px entry. This completion is inferred; source.pdf preserves the original.

- Removed undecodable status icons and normalized HTML/JSON filename casing.

The source references style.css, /sw.js and PNG icons that are not supplied in this section. Add them to complete the PWA. A manifest alone does not make page loading work offline.

## [Module 2 / 3b: Simple Web API returning Student data in JSON](Module-2/Practical-3b-Student-Web-API/README.md)

Create an ASP.NET Core Web API project named StudentAPI with controllers enabled. Copy the model and controller into it. Startup must register controllers and map controller endpoints. Test GET /api/students and /api/students/1. The PDF does not supply Program.cs or a project file.

## [Module 2 / 4a: PWA Manifest and Push Notifications](Module-2/Practical-4a-Manifest-and-Push-Notifications/README.md)

- Moved the worker push handler into service-worker.js, as directed by the PDF comment, and removed a repeated filename heading.

These are snippets. The source leaves YOUR_VAPID_PUBLIC_KEY as a placeholder and omits urlBase64ToUint8Array, the /api/subscribe backend, push-sending code, HTML entry point, registration code and icons. Remote push needs this setup. The local notification function is a separate demo. No keys or credentials have been generated.

## [Module 2 / 4b: E-Commerce PWA with Product Listing and Offline Cart](Module-2/Practical-4b-E-Commerce-PWA/README.md)

- Restored the missing keyboard-icon closing quote and the opening braces for addToCart and the offline checkout branch.

- Restored the service-worker feature-check closing brace and the missing initial 0 in the cart quantity reduction, which is needed for an empty cart.

- Removed undecodable decorative icons; product names and prices remain intact.

The PDF supplies HTML/cart code but omits manifest.json, /sw.js and PWA icons. Add them for offline page loading and installation. Checkout is only an alert demo: it does not submit orders or queue them on reconnection, despite the original alert wording. The cart uses localStorage.
