using System;
using System.Threading.Tasks;

namespace ShopApp.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var messageBox = new MessageBox();

            var tcs = new TaskCompletionSource();

            messageBox.StateNotify += (state) =>
            {
                if (state != State.Ok)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Cancel");
                }

                tcs.SetResult();
            };

            messageBox.Open();
            tcs.Task.GetAwaiter().GetResult();
        }
    }
}
