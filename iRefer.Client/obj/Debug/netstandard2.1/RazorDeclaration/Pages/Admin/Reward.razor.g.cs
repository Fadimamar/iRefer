#pragma checksum "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73fb75d755435e29e5c7118c4326b6e95f71c18a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace iRefer.Client.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using iRefer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using iRefer.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using iRefer.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using iRefer.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\_Imports.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor"
using Pages.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor"
using QRCoder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Reward")]
    public partial class Reward : iRefer.Client.Pages.Admin.RewardComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 180 "C:\Users\fmamar\source\repos\iRefer2\iRefer.Client\Pages\Admin\Reward.razor"
      


    public void GenerateQRCode()
    {


        string CouponID = "Sample Coupon";
        if (!string.IsNullOrEmpty(CouponID))
        {
            MemoryStream ms = new MemoryStream();

            QRCodeGenerator oQRCodeGenerator = new QRCodeGenerator();
            QRCodeData oQRCodeDate = oQRCodeGenerator.CreateQrCode(CouponID, QRCodeGenerator.ECCLevel.Q);
            QRCode oQRCode = new QRCode(oQRCodeDate);
            Bitmap oBitmap = oQRCode.GetGraphic(20);
            oBitmap.Save(ms, ImageFormat.Png);


        }

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591