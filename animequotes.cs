        [Command("quote")]
        public async Task animequoteAsync()

        {

            var client = new HttpClient();
            var url = "https://animechan.vercel.app/api/random";
            var result = await client.GetStringAsync(url);
            var AnimeQuoteObject = JsonConvert.DeserializeObject<AnimeQuoteModel>(result);


            var embed = new EmbedBuilder()
                .WithTitle("Anime Quote")
                .AddField("Anime", $"{AnimeQuoteObject.anime}", true)
                .AddField("Character", $"{AnimeQuoteObject.character}", true)
                .AddField("Quote", $"{AnimeQuoteObject.quote}", false)
                .WithColor(new Color(252, 255, 84))
                .Build();

            await ReplyAsync(embed: embed);
        }

        public class AnimeQuoteModel
        {
            public string anime { get; set; }
            public string character { get; set; }
            public string quote { get; set; }
        }
