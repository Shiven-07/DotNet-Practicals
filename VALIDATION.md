# Validation

Checks performed on the packaged files:

- All 24 split PDFs reopened successfully. Their 83 practical pages match the original page content streams, dimensions, extracted text and embedded image data. The source index and module-divider pages remain available in the complete original PDF.
- The full original PDF is byte-for-byte unchanged.
- The first and last pages of every split PDF were rendered and visually reviewed (48 page renders). Existing formatting and screenshots are preserved.
- All 11 console Program.cs files compiled successfully against the installed .NET 8 reference assemblies with the local C# compiler.
- All 21 C# source files passed Roslyn syntax parsing.
- All 5 standalone JavaScript files and all 4 inline JavaScript blocks passed Node syntax checks.
- All 4 source JSON files parsed successfully.
- The main index, practical README links and ZIP integrity were checked.

## Limits of these checks

Compilation and syntax checks are not end-to-end application tests. The original console programs were not interactively executed. ASP.NET Core MVC/API/EF, Web Forms and browser PWA projects were not built or run end to end. Razor/ASPX rendering, SQL insertion, service-worker caching, PWA installation and real push delivery have not been verified.

Many practicals are snippets that need template files or assets not supplied by the PDF. Each README lists those gaps. The original PDF output images are reference material, not screenshots from these checks.

See [SOURCE-NOTES.md](SOURCE-NOTES.md) for all changes made to the extracted code.
