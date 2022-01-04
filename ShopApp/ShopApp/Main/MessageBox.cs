using System;
using System.Threading.Tasks;

namespace ShopApp.Main
{
    public class MessageBox
    {
        private readonly Random _random = new Random();
        public event Action<State> StateNotify;
        public async void Open()
        {
            Console.WriteLine("The window was opened");
            await Task.Delay(3000);
            Console.WriteLine("The window was closed");
            var randomNumber = _random.Next(2);
            switch (randomNumber)
            {
                case 0:
                    StateNotify?.Invoke(State.Ok);
                    break;
                case 1:
                    StateNotify?.Invoke(State.Cancel);
                    break;
            }
        }
    }
}
