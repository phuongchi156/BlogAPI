namespace ConsoleApp1;

public class GuessGame
{
    public void Main()
    {
        Console.WriteLine("Xin chào mừng");
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Số bí mật từ 1-100
        int guess, count = 0;
        do
        {
            Console.WriteLine("Nhap so mong đợi");
            guess = int.Parse(Console.ReadLine());
            count++;

            if (guess == secretNumber)
            {
                Console.WriteLine("Chúc mừng bạn đã đoán đúng");
                break;
            }
            else if(guess < secretNumber)
            {
                Console.WriteLine("Lớn hơn");
            }
            else
            {
                Console.WriteLine("Nhỏ hơn");
            }
        }
        while(guess != secretNumber);
        if(count < 5)
        {
            Console.WriteLine("Xuất sắc");
        }
        else if (count < 10)
        {
            Console.WriteLine("KHán giả");
        }
        else
        {
            Console.WriteLine("Tạm biệt");
        }
        Console.WriteLine("Số bí mật "+secretNumber);
    }
}
