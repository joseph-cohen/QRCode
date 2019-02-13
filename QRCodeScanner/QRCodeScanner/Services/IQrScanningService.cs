using System;
namespace QRCodeScanner.Service
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
