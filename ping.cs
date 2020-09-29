//MCCScript 1.0
if(args.Length == 0) {
	MCC.LoadBot(new PingBot());
} else {
	MCC.LoadBot(new PingBot(args[0]));
}

//MCCScript Extensions

public class PingBot : ChatBot {
    private string player = "";

    public PingBot(string pl) {
        this.player = pl;
    }

    public PingBot() {
	this.player = "";
    }

    public override void Initialize() {
        if(this.player == "") {
            this.player = GetUsername();
        }
        foreach(var e in GetPlayersLatency()) {
            if (String.Equals(this.player, e.Key, StringComparison.OrdinalIgnoreCase)) {
                SendText(this.player + "'s ping is " + e.Value);
            }

        }
    }
}

//Copr. 2020 CheesyBC
