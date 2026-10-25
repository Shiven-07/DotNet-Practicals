# Module 1 - Practical 4c: AdRotator Control

**Added example:** written to cover the practical listed in the PDF index. The original PDF does not contain its solution. This folder is a self-contained ASP.NET Web Forms website; it has no source.pdf.

[Back to the main index](../../README.md)

## Aim

Display clickable college banners using the ASP.NET AdRotator server control and an XML advertisement file.

## Files

| File | Purpose |
|---|---|
| [Default.aspx](Default.aspx) | Web Form with the AdRotator and a reload link |
| [App_Data/Ads.xml](App_Data/Ads.xml) | Three advertisements, their image/link paths and weights |
| [Web.config](Web.config) | .NET Framework 4.8 configuration |
| [style.css](style.css) | Page styling |
| [Images/admissions.svg](Images/admissions.svg) | Admissions banner |
| [Images/courses.svg](Images/courses.svg) | C#/.NET courses banner |
| [Images/events.svg](Images/events.svg) | Tech Fest banner |
| [Admissions.html](Admissions.html), [Courses.html](Courses.html), [Events.html](Events.html) | Local destinations opened by the banners |

All banner artwork and destination pages are supplied. There are no packages, database connections, external image downloads, or advertising accounts to set up.

## Run in Visual Studio

Use Visual Studio with the **ASP.NET and web development** workload and .NET Framework 4.8 support.

1. Download or clone the repository.
2. Choose **File > Open > Web Site**, then **File System**.
3. Select this **Practical-4c-AdRotator** folder, not the repository root.
4. Open Default.aspx and choose **View in Browser** or run it using IIS Express.
5. Click **Reload banner** several times. Click a banner to open its matching local page.

This uses the Web Site model, so a .csproj or .sln file is not required. The AdRotator does the work declaratively; no code-behind file is needed.

If your lab uses an existing .NET Framework Web Forms project, add Default.aspx as a standalone Web Form and copy App_Data, Images, the CSS and the three HTML pages into that application's root. Keep the project's existing Web.config and framework configuration. Do not copy these files into an ASP.NET Core MVC project.

## Alternative: IIS Express command

If IIS Express is already installed, open PowerShell **in this practical folder** and run:

~~~powershell
& "$env:ProgramFiles\IIS Express\iisexpress.exe" "/path:$($PWD.Path)" /port:8094 /clr:v4.0 /systray:false
~~~

Open **http://localhost:8094/Default.aspx**. Leave that terminal running while testing; press Ctrl+C to stop it. If IIS Express is installed under Program Files (x86), use that installation's executable instead.

Opening the ASPX file directly, a static HTML server, or GitHub Pages will not execute the ASP.NET control.

## Main control

~~~aspx
<asp:AdRotator
    ID="CollegeAds"
    runat="server"
    AdvertisementFile="~/App_Data/Ads.xml"
    Target="_self"
    CssClass="ad-banner" />
~~~

Keep this control inside the server-side form shown in Default.aspx.

## How it works

The control reads Ads.xml and selects one ad for each page request. It renders the chosen image as a link. Reloading selects again; it can select the same banner twice. There is no timed slideshow.

| XML field | Meaning |
|---|---|
| ImageUrl | Banner image path |
| NavigateUrl | Page opened when the banner is clicked |
| AlternateText | Accessible description of the image |
| Keyword | Optional ad category; usable with KeywordFilter |
| Impressions | Relative selection weight, not a view counter |

The weights are **50 : 30 : 20**, so admissions is more likely than the other banners. These are probabilities, not a fixed repeating order or guaranteed totals for a few refreshes. To give the banners equal chances, set every Impressions value to the same positive number.

The ~/ paths start at the ASP.NET application's root. App_Data keeps the XML data inside the application while preventing direct browser access.

## Expected output and checks

- One banner appears beneath **College notice board**.
- Reloading can display admissions, courses or Tech Fest.
- A banner click opens the matching local HTML page; its back button returns to the demo.
- Images fit the page on desktop and mobile.
- The same banner may repeat. A missing image usually means its file path or filename does not match Ads.xml.

## Viva answers

**What is AdRotator?** A Web Forms server control for selecting and displaying an advertisement banner.

**Why use XML?** It keeps ad content separate from the page markup.

**What does runat="server" do?** It lets ASP.NET process the control before returning HTML.

**Which framework is used?** ASP.NET Web Forms on .NET Framework 4.8.

## References

- [Microsoft: AdRotator control](https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols.adrotator?view=netframework-4.8.1)
- [Microsoft: displaying advertisements from XML](https://learn.microsoft.com/en-us/previous-versions/aspnet/d5kd8aka%28v%3Dvs.100%29)
- [Microsoft: running IIS Express](https://learn.microsoft.com/en-us/iis/extensions/using-iis-express/running-iis-express-from-the-command-line)

See [validation notes](../../VALIDATION.md) for the checks actually performed.
