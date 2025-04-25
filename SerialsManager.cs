using System.Management;

namespace WinFormsApp2;

public class SerialsManager
{
    public ManagementObjectSearcher UsbSearcher { get; } =
        new("SELECT * FROM Win32_DiskDrive WHERE InterfaceType='USB'");

    private readonly List<string> _allowedSerials = [];

    public void LoadDefaultSerials()
    {
        string[] standardSerials = ["AA00000000000489"];
        foreach (var serial in standardSerials)
        {
            if (!_allowedSerials.Contains(serial))
            {
                _allowedSerials.Add(serial);
            }
        }
    }

    public void LoadAllowedSerials()
    {
        if (!File.Exists("id.pas")) return;
        
        using var reader = new StreamReader("id.pas");

        while (reader.ReadLine() is { } line)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var decryptedSerial = EncryptionHelper.Decrypt(line.Trim());
            _allowedSerials.Add(decryptedSerial);
        }
    }

    public int GetQuantityOfMountedAndAllowedDevices()
    {
        var allowedQuantity = 0;
        
        foreach (var o in UsbSearcher.Get())
        {
            var drive = (ManagementObject)o;
            var serial = drive["SerialNumber"]?.ToString() ?? "";
            var sizeGb = GetSizeInGb(drive);

            if (_allowedSerials.Contains(serial) && sizeGb >= 1)
            {
                allowedQuantity++;
            }
        }

        return allowedQuantity;
    }

    public void WriteSerial(string serialToWrite)
    {
        using var writer = new StreamWriter("id.pas", true);
        foreach (var o in UsbSearcher.Get())
        {
            var drive = (ManagementObject)o;
            if (drive["DeviceID"]?.ToString() != serialToWrite) continue;

            var serial = drive["SerialNumber"]?.ToString();
            if (serial == null || _allowedSerials.Contains(serial)) continue;
            var encryptedSerial = EncryptionHelper.Encrypt(serial);
            writer.WriteLine(encryptedSerial);
        }
    }

    public static double GetSizeInGb(ManagementObject drive)
    {
        double sizeGb = 0;
        if (drive["Size"] != null && double.TryParse(drive["Size"].ToString(), out var sizeBytes))
        {
            sizeGb = Math.Round(sizeBytes / 1073741824.0, 1);
        }
        return sizeGb;
    }
}