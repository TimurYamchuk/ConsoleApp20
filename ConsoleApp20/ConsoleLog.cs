// Класс для печати сообщений в консоль, реализующий интерфейс ILog.
public class ConsoleLog : ILog
{
    public void Print(string message)
    {
        Console.WriteLine(message); 
    }
}

// Класс для записи сообщений в файл, реализующий интерфейс ILog.
public class FileLog : ILog
{
    private string _filePath; 

    public FileLog(string filePath)
    {
        _filePath = filePath; 
    }

    public void Print(string message)
    {
        File.AppendAllText(_filePath, message + Environment.NewLine); // Запись сообщения в файл.
    }
}

// Класс для сериализации в формат SOAP, реализующий интерфейс ISerialize.
public class SoapSerialize : ISerialize
{
    public void Serialize(StorageDevice device)
    {
    }

    public StorageDevice Deserialize()
    {
        // Реализация десериализации из формата SOAP.
        return null; 
    }
}

// Класс для сериализации в формат JSON, реализующий интерфейс ISerialize.
public class JSONSerialize : ISerialize
{
    public void Serialize(StorageDevice device)
    {
    }

    public StorageDevice Deserialize()
    {
        // Реализация десериализации из формата JSON.
        return null; 
    }
}

// Класс для сериализации в формат XML, реализующий интерфейс ISerialize.
public class XMLSerialize : ISerialize
{
    public void Serialize(StorageDevice device)
    {
   
    }

    public StorageDevice Deserialize()
    {
        // Реализация десериализации из формата XML.
        return null; 
    }
}
