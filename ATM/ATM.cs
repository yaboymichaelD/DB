public class ATM
{
    public Card card { get; private set; }

    private bool isLogged;

    public ATM()
    {
        this.card = null;
        this.isLogged = false;
    }

    public void InsertCard(Card card)
    {
        if (card == null) throw new Exception();
        this.card = card;
    }

    public void GiveBackCard()
    {
        this.card = null;
    }

    public bool LogIn(string pin)
    {
        if(this.card == null) throw new Exception("Unable to log in because no card has been inserted.");

        if(!this.isLogged) throw new Exception("User is already logged-in");

        if(this.card.CheckPin(pin)) 
        {
            this.logged = true;
            return true;
        }
        else
        {
            return false;
        }
    
    }

    
}