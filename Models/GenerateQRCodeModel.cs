using System.ComponentModel.DataAnnotations;

namespace GenerateQRCodeASpNetCoreMVC6.Models
{
    public class GenerateQRCodeModel
    {
        [Display(Name ="Enter QR Code Text")]
        public string QRCodeText { get; set; }
    }
}
