
using System.Text.Json;

var priceList = new PriceList();

// Добавляем устройства
priceList.AddDevice(new Flash("SanDisk", "Ultra", "Flash Drive", 64, 10, 100));
priceList.AddDevice(new DVD("Sony", "DVD-R", "DVD Disk", 4.7, 20, 16));
priceList.AddDevice(new RemovableHDD("Seagate", "Backup Plus", "Removable HDD", 500, 5, 5400));

// Печать списка через ConsoleLog
ILog logger = new ConsoleLog();
priceList.PrintDevices(logger);

// Удаление устройства по критерию
priceList.RemoveDevice(d => d.Name == "DVD Disk");

// Сохранение списка в JSON
ISerialize serializer = new JSONSerialize();
priceList.SaveDevices(serializer);

// Загрузка списка
priceList.LoadDevices(serializer);
