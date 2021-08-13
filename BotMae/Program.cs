using System;
using Telegram.Bot;
using System.Threading;
using System.IO;
using Telegram.Bot.Types.InputFiles;

namespace BotMae
{
    class Program
    {
        private static TelegramBotClient BotClient = new TelegramBotClient("1223836560:AAEuQfbXw861oyI2XgY-gTm1zbyw-aaf-so");

        static void Main(string[] args)
        {
            BotClient.OnMessage += BotClient_OnMessage;

            BotClient.StartReceiving();

            Console.WriteLine("bot iniciado.");
            Console.ReadLine();
        }

        private static void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            #region teste

            //if (e.Message.Text.ToUpper().Equals("OI"))
            //{
            //    BotClient.SendTextMessageAsync(
            //        e.Message.Chat.Id,
            //        $"Como vai? {e.Message.From.FirstName} - {e.Message.From.Id}"
            //        );

            //    BotClient.SendPhotoAsync(
            //        e.Message.Chat.Id,
            //        "https://danbooru.donmai.us/data/sample/8f/9c/__shiina_yuika_nijisanji_drawn_by_ksk_semicha_keisuke__sample-8f9c14e3a4d350ff20d98467bfe555a6.jpg",
            //        "teste img"
            //        );
            //}

            //if (e.Message.Text.ToUpper().Equals("OI 2"))
            //{
            //    FileStream fs = File.OpenRead(@"C:\Users\Igor\Pictures\6yga-Mbm.jpeg");
            //    InputOnlineFile myPhoto = new InputOnlineFile(fs,"teste.jpeg");

            //    BotClient.SendPhotoAsync(
            //        e.Message.Chat.Id,
            //        myPhoto,
            //        "teste img"
            //        );
            //}

            #endregion

            try
            {
                if (e.Message.From.Id.Equals(169699555) &&
                    e.Message.Chat.Id.Equals(169699555))
                {
                    long[] chats = { -1001451777441, -597340963 };
                    long chat_mandou = e.Message.Chat.Id;

                    foreach (long val in chats)
                    {
                        var msg = BotClient.ForwardMessageAsync(
                           val,
                           chat_mandou,
                           e.Message.MessageId
                           ).Result;
                    }

                    Console.WriteLine("msg encaminhada");
                }
                else if (e.Message.From.Id.Equals(181452558) &&
                    e.Message.Chat.Id.Equals(181452558))
                {
                    long[] chats = { -1001451777441, -597340963 };
                    long chat_mandou = e.Message.Chat.Id;

                    foreach (long val in chats)
                    {
                        var msg = BotClient.ForwardMessageAsync(
                           val,
                           chat_mandou,
                           e.Message.MessageId
                           ).Result;
                    }

                    Console.WriteLine("msg encaminhada");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: "+ex.Message);
            }

            Console.WriteLine("foi");
        }
    }
}
