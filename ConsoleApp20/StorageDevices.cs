// Абстрактный класс, представляющий общие свойства и методы для устройств хранения данных.
public abstract class StorageDevice
{
    // Свойства для хранения данных об устройстве.
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }
    public double Capacity { get; set; }
    public int Quantity { get; set; }

    // Конструктор для инициализации устройства.
    public StorageDevice(string manufacturer, string model, string name, double capacity, int quantity)
    {
        Manufacturer = manufacturer;
        Model = model;
        Name = name;
        Capacity = capacity;
        Quantity = quantity;
    }

    // Абстрактные методы для вывода, загрузки и сохранения данных. Реализуются в производных классах.
    public abstract void Print(ILog logger);
    public abstract void Load(ISerialize serializer);
    public abstract void Save(ISerialize serializer);
}

// Интерфейс для логирования сообщений.
public interface ILog
{
    void Print(string message);
}

// Интерфейс для сериализации и десериализации объектов.
public interface ISerialize
{
    void Serialize(StorageDevice device);
    StorageDevice Deserialize();
}
