namespace MyHashSetApp;

class Program
{
    static void Main(string[] args)
    {
        DataStore<string> dataStoreString = new DataStore<string>();
        dataStoreString.Data = "Noah";
        
        DataStore<int> dataStoreInt = new DataStore<int>();
        dataStoreInt.Data = 1;
        
        DataStore<decimal> dataStoreDecimal = new DataStore<decimal>();
        dataStoreDecimal.Data = 2m;
        
        dataStoreDecimal.DataArray[0] = 5m;
        
        dataStoreInt.AddOrUpdate(2, 5);

        Console.WriteLine(dataStoreInt.GetData(2));
        
    }
}

class DataStore<T>
{
    public T Data { get; set; }
    
    public T[] DataArray = new T[10];


    public void AddOrUpdate(int i, T value)
    {
        if(i <= DataArray.Length || i>=0)
        {
            DataArray[i] = value;
        }
    }

    public T GetData(int i)
    {
        if(i  <= DataArray.Length || i>=0)
        {
            return DataArray[i];
        }
        throw new IndexOutOfRangeException();
    }
}
