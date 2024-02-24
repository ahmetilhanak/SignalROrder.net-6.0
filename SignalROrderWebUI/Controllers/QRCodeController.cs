using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace SignalROrderWebUI.Controllers
{
    public class QRCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string value)
        {
            if (value != null)
            {
                using (MemoryStream memorystream = new MemoryStream())
                {
                    QRCodeGenerator createQRCode = new QRCodeGenerator();
                    QRCodeGenerator.QRCode squareCode = createQRCode.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
                    using (Bitmap imageQR = squareCode.GetGraphic(10))
                    {
                        imageQR.Save(memorystream, ImageFormat.Png);
                        ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(memorystream.ToArray());
                    }
                }

            }
           
            return View();
        }
    }
}
