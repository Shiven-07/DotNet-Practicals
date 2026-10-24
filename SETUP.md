# Setup guide

## Uploading this folder to GitHub

1. Extract the ZIP. Open the DotNet-Practicals folder.
2. In your GitHub repository, upload the **contents** of that folder, so README.md, Module-1, Module-2 and the original PDF are at the repository root.
3. For browser uploads, use separate batches: the root files first, then the Module-1 folder, then the Module-2 folder. Preserve those module folder names and their contents.
4. Commit the uploaded files. The README becomes your clickable practical index.

Do not upload only the ZIP if you want to browse individual programs on GitHub. Files have been prepared locally; a remote GitHub repository has not been created or updated.

## C# console programs

Create a separate Console App for each practical and replace its Program.cs. Match the project name to the namespace shown in the source, or keep the namespace as written. Open a terminal or use Ctrl+F5 to run; the samples use Console.ReadKey() at the end. Do not paste several practicals into one project because each has its own entry point.

## ASP.NET Core MVC and API examples

Create the appropriate project in Visual Studio, then copy the supplied model, controller and view files into matching folders. Keep generated startup, project and shared view files unless the practical supplies a replacement. MVC forms using asp-for and asp-action need the template's tag-helper imports. The arithmetic practical specifies .NET 6 or .NET 8. Use your lab's installed framework and package versions.

The API sample needs controller registration and mapping in startup. EF Core additionally requires SQL Server LocalDB, matching EF Core packages, the connection string and migrations. Refer to the original PDF for those steps.

## ASP.NET Web Forms

Use an ASP.NET Web Application **(.NET Framework)** with Web Forms, as stated in the PDF. Let Visual Studio create the project and designer files. Read the validation practical's missing-code note before running it.

## PWA examples

Read each practical's missing-assets note first. Serve a completed example on localhost or HTTPS with that example at the site root. Do not open the HTML by double-clicking and expect service workers to work. Root-relative paths must be adapted for deployment below a repository subdirectory. Keeping files in a GitHub repository does not run ASP.NET, provision a database or complete missing PWA files.

## Package scope

This is an organized extraction of the supplied practical book with documented syntax cleanup, not complete generated Visual Studio solutions. No original output screenshot has been recreated. Original screenshots are not evidence of a new test run. See VALIDATION.md for the actual checks.
