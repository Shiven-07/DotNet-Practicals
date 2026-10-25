<%@ Page Language="C#" %>
<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Practical 4c - AdRotator</title>
    <link rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <main class="card">
            <p class="eyebrow">MODULE 1 / PRACTICAL 4c</p>
            <h1>College notice board</h1>
            <p>One banner is selected from an XML advertisement file on each page request.</p>

            <!-- ASP.NET reads Ads.xml and renders one clickable image. -->
            <asp:AdRotator
                ID="CollegeAds"
                runat="server"
                AdvertisementFile="~/App_Data/Ads.xml"
                Target="_self"
                CssClass="ad-banner" />

            <div class="actions">
                <asp:HyperLink
                    ID="ReloadLink"
                    runat="server"
                    NavigateUrl="~/Default.aspx"
                    CssClass="button">Reload banner</asp:HyperLink>
                <span>Click the banner to open its information page.</span>
            </div>
            <p class="note">Selection is random. The same banner can appear again after a reload.</p>
            <p class="footer">Sample college notices for an ASP.NET Web Forms practical.</p>
        </main>
    </form>
</body>
</html>
