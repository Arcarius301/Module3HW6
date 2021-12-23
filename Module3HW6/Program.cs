using System;
using System.Threading.Tasks;

namespace Module3HW6
{
    public class Program
    {
        private static readonly TaskCompletionSource _tcs = new TaskCompletionSource();

        public static async Task Main(string[] args)
        {
            var messageBox = new MessageBox();
            messageBox.OnClosed += DisplayMessage;
            messageBox.Open();
            await _tcs.Task;
        }

        public static void DisplayMessage(State state)
        {
            Console.WriteLine(state == State.Ok ? "Операция была подтверждена" : "Операция была отклонена");
            _tcs.SetResult();
        }
    }
}
