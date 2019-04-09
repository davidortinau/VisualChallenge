using System.Collections.Generic;

namespace VisualChallenge.Model
{
    public class VisualChallengePageModel
    {
        public IEnumerable<Coin> Coins { get; set; }

        public VisualChallengePageModel()
        {
            Coins = new List<Coin> {
                new Coin{Name="Bitcoin", ShortName="BTC", Image="bitcoin.png", Value="-0.02%"},
                new Coin{Name="Ethereum", ShortName="ETH", Image="ethereum.png", Value="-0.86%"},
                new Coin{Name="Litecoin", ShortName="LTC", Image="litecoin.png", Value="-1.02%"}
            };
        }
    }
}
