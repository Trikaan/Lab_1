using System.Diagnostics;
using System.Management;

namespace WinFormsApp2;

public partial class Form1 : Form
{
    private readonly SerialsManager _serialsManager = new();
    
    public Form1()
    {
        InitializeComponent();
        
        _serialsManager.LoadDefaultSerials();
        LoadAllowedSerials();
        CheckMountingOfAllowedDevices();
    }

    private void LoadAllowedSerials()
    {
        try
        {
            _serialsManager.LoadAllowedSerials();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Помилка при читанні файлу ідентифікаторів: " + ex.Message);
            Process.GetCurrentProcess().Kill();
        }
    }
    
    private void CheckMountingOfAllowedDevices()
    {
        var allowedQuantity = _serialsManager.GetQuantityOfMountedAndAllowedDevices();
        if (allowedQuantity > 0)
        {
            MessageBox.Show("Ваш цифровий пароль прийнято!", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Не знайдено дозволеного USB-накопичувача!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Process.GetCurrentProcess().Kill();
        }
    }
    
    private void Form1_Load(object sender, EventArgs e)
    {
        foreach (var o in _serialsManager.UsbSearcher.Get())
        {
            var drive = (ManagementObject)o;
            comboBox1.Items.Add(drive["DeviceID"]?.ToString() ?? string.Empty);
        }
    }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        button1.Enabled = true;

        foreach (var o in _serialsManager.UsbSearcher.Get())
        {
            var drive = (ManagementObject)o;
            if (drive["DeviceID"]?.ToString() != comboBox1.Text) continue;
            
            LabelModel.Text = drive["Model"]?.ToString();
            LabelDescription.Text = drive["Description"]?.ToString();
            LabelSerial.Text = drive["SerialNumber"]?.ToString();
            LabelSize.Text = SerialsManager.GetSizeInGb(drive) + " Гб.";
        }
    }

    /// <summary>
    /// Обробка кліку по кнопці – збереження серійного номера вибраного накопичувача
    /// </summary>
    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var selectedSerial = comboBox1.Text;
            _serialsManager.WriteSerial(selectedSerial);
            MessageBox.Show("Ідентифікатор USB-накопичувача збережено!", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Помилка при збереженні ідентифікатора: " + ex.Message);
        }
        Process.GetCurrentProcess().Kill();
    }
}