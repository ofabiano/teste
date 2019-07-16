using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string x = Environment.GetEnvironmentVariable("XPTO");
            Console.WriteLine(string.Format("XPTO: {0}", x));

            Environment.SetEnvironmentVariable("XPTO", "aaa");
            x = Environment.GetEnvironmentVariable("XPTO");
            Console.WriteLine(string.Format("XPTO: {0}", x));
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;

//namespace Fabot
//{

//    class Config
//    {
//        public int offSet
//        {
//            get
//            {
//                int offset = 0;
//                int.TryParse(Environment.GetEnvironmentVariable("BOT_OFFSET"), out offset);
//                return offset;
//            }
//        }
//    }

//    class TelegramUpdate
//    {
//        public int update_id { get; set; }
//        public TelegramMessage message { get; set; }
//        //??? edited_message Message Optional.New version of a message that is known to the bot and was edited
//        //??? channel_post    Message Optional. New incoming channel post of any kind — text, photo, sticker, etc.
//        //??? edited_channel_post Message Optional.New version of a channel post that is known to the bot and was edited
//        //??? inline_query    InlineQuery Optional. New incoming inline query
//        //??? chosen_inline_result ChosenInlineResult  Optional.The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.
//        //??? callback_query CallbackQuery   Optional.New incoming callback query
//        //??? shipping_query ShippingQuery   Optional.New incoming shipping query. Only for invoices with flexible price
//        //??? pre_checkout_query PreCheckoutQuery    Optional.New incoming pre-checkout query. Contains full information about checkout
//        //??? poll
//    }

//    class TelegramMessage
//    {
//        public int message_id { get; set; }
//        public TelegramUser from { get; set; }
//        public TelegramChat chat { get; set; }
//        //date Integer Date the message was sent in Unix time
//        //forward_from    User Optional. For forwarded messages, sender of the original message
//        //forward_from_chat   Chat Optional. For messages forwarded from channels, information about the original channel
//        //forward_from_message_id Integer Optional. For messages forwarded from channels, identifier of the original message in the channel
//        //forward_signature String  Optional.For messages forwarded from channels, signature of the post author if present
//        //forward_sender_name String Optional. Sender's name for messages forwarded from users who disallow adding a link to their account in forwarded messages
//        //forward_date Integer Optional.For forwarded messages, date the original message was sent in Unix time
//        //reply_to_message Message Optional.For replies, the original message.Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.
//        //edit_date Integer Optional.Date the message was last edited in Unix time
//        //media_group_id String  Optional.The unique identifier of a media message group this message belongs to
//        //author_signature    String Optional. Signature of the post author for messages in channels
//        public string text { get; set; }
//        //entities Array of MessageEntity  Optional.For text messages, special entities like usernames, URLs, bot commands, etc.that appear in the text
//        //caption_entities Array of MessageEntity  Optional.For messages with a caption, special entities like usernames, URLs, bot commands, etc.that appear in the caption
//        //audio Audio   Optional.Message is an audio file, information about the file
//        //document Document    Optional.Message is a general file, information about the file
//        //animation Animation   Optional.Message is an animation, information about the animation. For backward compatibility, when this field is set, the document field will also be set
//        //game    Game Optional. Message is a game, information about the game. More about games »
//        //photo Array of PhotoSize  Optional.Message is a photo, available sizes of the photo
//        //sticker Sticker Optional. Message is a sticker, information about the sticker
//        //video Video   Optional.Message is a video, information about the video
//        //voice Voice   Optional.Message is a voice message, information about the file
//        //video_note VideoNote   Optional.Message is a video note, information about the video message
//        //caption String Optional. Caption for the animation, audio, document, photo, video or voice, 0-1024 characters
//        //contact Contact Optional. Message is a shared contact, information about the contact
//        //location Location    Optional.Message is a shared location, information about the location
//        //venue Venue   Optional.Message is a venue, information about the venue
//        //poll Poll    Optional.Message is a native poll, information about the poll
//        //new_chat_members Array of User   Optional.New members that were added to the group or supergroup and information about them (the bot itself may be one of these members)
//        //left_chat_member User    Optional.A member was removed from the group, information about them(this member may be the bot itself)
//        //new_chat_title String  Optional.A chat title was changed to this value
//        //new_chat_photo  Array of PhotoSize Optional.A chat photo was change to this value
//        //delete_chat_photo   True Optional. Service message: the chat photo was deleted
//        //group_chat_created  True Optional. Service message: the group has been created
//        //supergroup_chat_created True Optional. Service message: the supergroup has been created.This field can‘t be received in a message coming through updates, because bot can’t be a member of a supergroup when it is created.It can only be found in reply_to_message if someone replies to a very first message in a directly created supergroup.
//        //channel_chat_created True    Optional.Service message: the channel has been created.This field can‘t be received in a message coming through updates, because bot can’t be a member of a channel when it is created.It can only be found in reply_to_message if someone replies to a very first message in a channel.
//        //migrate_to_chat_id Integer Optional.The group has been migrated to a supergroup with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.
//        //migrate_from_chat_id Integer Optional.The supergroup has been migrated from a group with the specified identifier. This number may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.
//        //pinned_message Message Optional.Specified message was pinned. Note that the Message object in this field will not contain further reply_to_message fields even if it is itself a reply.
//        //invoice Invoice Optional.Message is an invoice for a payment, information about the invoice. More about payments »
//        //successful_payment SuccessfulPayment   Optional.Message is a service message about a successful payment, information about the payment. More about payments »
//        //connected_website String  Optional.The domain name of the website on which the user has logged in. More about Telegram Login »
//        //passport_data PassportData    Optional.Telegram Passport data
//        //reply_markup    InlineKeyboardMarkup Optional. Inline keyboard attached to the message. login_url buttons are represented as ordinary url buttons
//    }

//    class TelegramUser
//    {
//        public int id { get; set; }
//        public bool is_bot { get; set; }
//        public string first_name { get; set; }
//        public string last_name { get; set; }
//        public string username { get; set; }
//        public string language_code { get; set; }
//    }

//    class TelegramChat
//    {
//        public int id { get; set; }
//        public string type { get; set; }
//        public string title { get; set; }
//        public string username { get; set; }
//        public string first_name { get; set; }
//        public string last_name { get; set; }
//        public string all_members_are_administrators { get; set; }
//        //photo ChatPhoto   Optional.Chat photo. Returned only in getChat.
//        public string description { get; set; }
//        public string invite_link { get; set; }
//        //pinned_message Message Optional.Pinned message, for groups, supergroups and channels.Returned only in getChat.
//        public string sticker_set_name { get; set; }
//        public bool can_set_sticker_set { get; set; }
//    }

//    class Program
//    {
//        static Config _config;
//        const string _configFile = @"C:\Users\cs131641\ownCloud\ArquitetoSolução\Telegram\Fabot\config.json";
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Bot Telegram");
//            Console.WriteLine("=============================================");

//            _config = new Config();
//            using (StreamReader file = File.OpenText(_configFile))
//            {
//                JsonSerializer serializer = new JsonSerializer();
//                _config = (Config)serializer.Deserialize(file, typeof(Config));
//            }

//            while (true)
//            {
//                ExibirLog("Lendo mensagens");
//                GetUpdateAsync().GetAwaiter().GetResult();
//                System.Threading.Thread.Sleep(5000);
//            }
//        }

//        static async Task GetUpdateAsync()
//        {
//            var client = new HttpClient();
//            var response = await client.GetAsync(string.Format("https://api.telegram.org/bot788033758:AAGRSABPB0DOVW1jYMfv70z17yF48U0uMjI/getUpdates?offset={0}", _config.offSet));
//            response.EnsureSuccessStatusCode();

//            var definition = new
//            {
//                ok = false,
//                result = new List<TelegramUpdate>()
//            };

//            var jsonReturned = await response.Content.ReadAsStringAsync();
//            var dataReturned = JsonConvert.DeserializeAnonymousType(jsonReturned, definition);
//            ExibirLog(string.Format("Mensagens recebidas: {0}", dataReturned.result.Count));
//            foreach (TelegramUpdate update in dataReturned.result)
//            {
//                if (update.message != null)
//                {
//                    ExibirLog(string.Format("Mensagem recebida: {0}", update.message.text));
//                    Task sendTask = SendMessageAsync(update.message.chat, string.Format("Olá {0}, você me enviou a mensagem '{1}', mas eu ainda não sei responder...", update.message.from.first_name, update.message.text));
//                    _config.offSet = update.update_id + 1;
//                    File.WriteAllText(_configFile, JsonConvert.SerializeObject(_config));
//                }
//                else
//                {
//                    ExibirLog(string.Format("Tipo de mensagem retorno desconhecido no update_id: {0}", update.update_id));
//                }

//            }
//        }

//        static async Task SendMessageAsync(TelegramChat chat, string msg)
//        {
//            var client = new HttpClient();
//            var parameters = new
//            {
//                chat_id = chat.id,
//                text = msg
//            };
//            var response = await client.PostAsync(
//                "https://api.telegram.org/bot788033758:AAGRSABPB0DOVW1jYMfv70z17yF48U0uMjI/sendMessage",
//                new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8, "application/json")
//                );
//            response.EnsureSuccessStatusCode();
//            ExibirLog(string.Format("Mensagens enviada para {0}: {1}", chat.username, msg));
//        }

//        static void ExibirLog(string texto)
//        {
//            Console.WriteLine(string.Format("{0} {1}", DateTime.Now, texto));
//        }
//    }
//}
