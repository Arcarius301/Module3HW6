using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class MessageBox
    {
        public event Action<State> OnClosed;

        public async void Open()
        {
            var random = new Random();
            Console.WriteLine("Открыто окно");
            await Task.Delay(3000);
            Console.WriteLine("Окно было закрыто пользователем");

            OnClosed?.Invoke((State)random.Next(2));
        }
    }
}
