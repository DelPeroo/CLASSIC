public class Auto
{
    public string _marka { get; private set; }
    public int _speed { get; private set; }
    public bool _sostoyanie { get; private set; }

    public Auto(string marka, int speed, bool sostoyanie)
    {
        _marka = marka;
        _speed = speed;
        _sostoyanie = sostoyanie;
    }



    public void Boost(int booost)
    {
        if (_sostoyanie == true)
        {

            _speed = _speed + booost;
            Console.WriteLine($"Машина {_marka} ускорилась на {booost} км/ч и теперь ее скорость - {_speed} км/ч");
            if (_speed > 300)
            {
                Console.WriteLine($"Ты разбил свою {_marka} на скорости {_speed} км/ч");
                _sostoyanie = false;
                _marka = "разбита";
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Введи марку авто");
        string marka = Console.ReadLine();

        Auto auto_1 = new Auto(marka, 0, true);
        while (true)
        {
            Console.WriteLine("На сколько хочешь ускориться");
            int booost = int.Parse(Console.ReadLine());
            auto_1.Boost(booost);
            if (auto_1._sostoyanie == false)
            {
                break;
            }

        }

    }
}