using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using iRefer.Shared.Models;
using System.IO;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace iRefer.Client.Pages.Admin
{
    public partial class RewardComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }
        protected string QRCodeStr { get; set; }
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        bool _RewardsExpires;
        protected bool RewardsExpires
        {
            get
            {
                return _RewardsExpires;
            }
            set
            {
                if (!object.Equals(_RewardsExpires, value))
                {
                    _RewardsExpires = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        bool _CouponSelected;
        protected bool CouponSelected
        {
            get
            {
                return _CouponSelected;
            }
            set
            {
                if (!object.Equals(_CouponSelected, value))
                {
                    _CouponSelected = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        bool _CashSelected;
        protected bool CashSelected
        {
            get
            {
                return _CashSelected;
            }
            set
            {
                if (!object.Equals(_CashSelected, value))
                {
                    _CashSelected = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        bool _CustomSelected;
        protected bool CustomSelected
        {
            get
            {
                return _CustomSelected;
            }
            set
            {
                if (!object.Equals(_CustomSelected, value))
                {
                    _CustomSelected = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        bool _PointsSelected;
        protected bool PointsSelected
        {
            get
            {
                return _PointsSelected;
            }
            set
            {
                if (!object.Equals(_PointsSelected, value))
                {
                    _PointsSelected = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        int _SelectedOption;
        protected int SelectedOption
        {
            get
            {
                return _SelectedOption;
            }
            set
            {
                if (!object.Equals(_SelectedOption, value))
                {
                    _SelectedOption = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
            
        }

        protected async System.Threading.Tasks.Task Load()
        {
            RewardsExpires = true;

            CouponSelected = true;

            CashSelected = false;

            CustomSelected = false;

            PointsSelected = false;

            SelectedOption = 0;
            
        }

        protected async System.Threading.Tasks.Task Radiobuttonlist1Change(int args)
        {
            SelectedOption = args;
            
            if (args==(int)RewardTypes.Coupon)
            {
                CouponSelected = true;
              

               
            }
            else
            {
                CouponSelected = false;
            }
            if (args == (int)RewardTypes.Points)
            {
                PointsSelected = true;
            }
            else
            {
                PointsSelected = false;
            }
            if (args == (int)RewardTypes.Cash)
            {
                CashSelected = true;
            }
            else
            {
                CashSelected = false;
            }
            if (args == (int)RewardTypes.Custom)
            {
                CustomSelected = true;
            }
            else
            {
                CustomSelected = false;
            };
        }
  //public void GenerateQRCode()
  //      {
  //          string CouponID = "Sample Coupon";
  //          if (!string.IsNullOrEmpty(CouponID)) 
  //          {
  //              using(MemoryStream ms=new MemoryStream())
  //              {
  //                  QRCodeGenerator oQRCodeGenerator = new QRCodeGenerator();
  //                  QRCodeData oQRCodeDate = oQRCodeGenerator.CreateQrCode(CouponID, QRCodeGenerator.ECCLevel.Q);
  //                  QRCode oQRCode = new QRCode(oQRCodeDate);
  //                  using (Bitmap oBitmap = oQRCode.GetGraphic(20))
  //                  {
  //                      oBitmap.Save(ms, ImageFormat.Png);
  //                      QRCodeStr = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                       
  //                  }

  //              }
  //          }
  //      }
    
    }
}