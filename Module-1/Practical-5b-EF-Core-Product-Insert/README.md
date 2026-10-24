# Module 1 - Practical 5b: Product Table with EF Core (Insert Operation)

To create a Product table in SQL Server and perform Insert Operation using Entity Framework Core in an ASP.NET Core application.

[Back to index](../../README.md) | [Original practical PDF](source.pdf) | [Unedited extracted text](source-text.txt)

Original PDF pages **44-48** (printed pages 41-45). The PDF includes its existing output screenshots where present.

## Code files

- [Models/Product.cs](Models/Product.cs)
- [Models/Data/AppDbContext.cs](Models/Data/AppDbContext.cs)
- [Controllers/ProductController.cs](Controllers/ProductController.cs)
- [appsettings.json](appsettings.json)
- [Program.cs](Program.cs)
- [Views/Product/Index.cshtml](Views/Product/Index.cshtml)

## Setup and source limitations

Create an ASP.NET Core MVC project named WebApplication5 and copy these files, keeping template tag-helper imports. Install Entity Framework Core, SqlServer and Tools packages for the target framework, then follow the PDF migration steps. SQL Server LocalDB and database setup are required. Open /Product/Index; the source startup defaults to a Home route whose controller is not supplied in the PDF.

## Extraction notes

Page headers, footers and output labels were removed from code. Code split between pages was joined. The original PDF and raw extracted text remain available for comparison.

- Wrapped the partial connection string in a complete JSON object, closed ConnectionStrings, and rejoined MultipleActiveResultSets.

## Validation

See [VALIDATION.md](../../VALIDATION.md) for checks performed and what has not been run. These are source examples to place in the appropriate project, not complete Visual Studio solutions.
