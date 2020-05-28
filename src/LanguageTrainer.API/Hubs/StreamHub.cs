
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace LanguageTrainer.Hubs
{
    public class StreamHub : Hub
    {
        private MemoryStream audio;
        public StreamHub()
        {
            if (audio == null)
            {
                audio = new MemoryStream();
            }
        }

        public async Task SendMessage(string user, string message)
        {
            await ReadAudio();

            if (audio != null)
            {
                await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", user, audio.GetBuffer());
            }
        }

        public async Task ReadAudio()
        {
            using (var reader = new BinaryReader(File.Open("./temp/epa.mp3", FileMode.Open)))
            {
               await reader.BaseStream.CopyToAsync(audio);
            }
        }
    }
}
