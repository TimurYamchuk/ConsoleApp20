// Класс для хранения списка устройств хранения.
public class PriceList
{
    public List<StorageDevice> Devices { get; set; } // Список устройств хранения.

    // Конструктор для инициализации списка устройств.
    public PriceList()
    {
        Devices = new List<StorageDevice>();
    }

    // Метод для добавления устройства в список.
    public void AddDevice(StorageDevice device)
    {
        Devices.Add(device);
    }

    // Метод для удаления устройства по заданному критерию.
    public void RemoveDevice(Func<StorageDevice, bool> criteria)
    {
        Devices.RemoveAll(new Predicate<StorageDevice>(criteria));
    }

    // Метод для печати всех устройств, используя логгер.
    public void PrintDevices(ILog logger)
    {
        foreach (var device in Devices)
        {
            device.Print(logger);
        }
    }

    // Метод для сохранения всех устройств с помощью сериализатора.
    public void SaveDevices(ISerialize serializer)
    {
        foreach (var device in Devices)
        {
            device.Save(serializer);
        }
    }

    // Метод для загрузки устройства с помощью сериализатора и добавления его в список.
    public void LoadDevices(ISerialize serializer)
    {
        var device = serializer.Deserialize();
        if (device != null)
        {
            Devices.Add(device);
        }
    }
}
