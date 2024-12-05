// Класс для флеш-памяти, наследуется от StorageDevice.
public class Flash : StorageDevice
{
    public double UsbSpeed { get; set; } // Скорость USB.

    public Flash(string manufacturer, string model, string name, double capacity, int quantity, double usbSpeed)
        : base(manufacturer, model, name, capacity, quantity)
    {
        UsbSpeed = usbSpeed;
    }

    public override void Print(ILog logger) { /* Печать информации о флеш-памяти */ }
    public override void Load(ISerialize serializer) { /* Загрузка данных */ }
    public override void Save(ISerialize serializer) { /* Сохранение данных */ }
}

public class DVD : StorageDevice
{
    public double WriteSpeed { get; set; } // Скорость записи.

    public DVD(string manufacturer, string model, string name, double capacity, int quantity, double writeSpeed)
        : base(manufacturer, model, name, capacity, quantity)
    {
        WriteSpeed = writeSpeed;
    }

    public override void Print(ILog logger) { /* Печать информации о DVD-диске */ }
    public override void Load(ISerialize serializer) { /* Загрузка данных */ }
    public override void Save(ISerialize serializer) { /* Сохранение данных */ }
}

public class RemovableHDD : StorageDevice
{
    public double SpindleSpeed { get; set; } // Скорость вращения шпинделя.

    public RemovableHDD(string manufacturer, string model, string name, double capacity, int quantity, double spindleSpeed)
        : base(manufacturer, model, name, capacity, quantity)
    {
        SpindleSpeed = spindleSpeed;
    }

    public override void Print(ILog logger) { /* Печать информации о HDD */ }
    public override void Load(ISerialize serializer) { /* Загрузка данных */ }
    public override void Save(ISerialize serializer) { /* Сохранение данных */ }
}
