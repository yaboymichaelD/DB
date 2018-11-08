using System;

public class LogInProcess
{
    public Card Card { get; private set; }

    private bool isLogged;

    public LogInProcess()
    {
        this.Card = null;
        this.isLogged = false;
    }

    public void InsertCard(Card card)
    {
        if (card == null)
            throw new Exception();
        this.Card = card;
    }

    public void GiveBackCard()
    {
        this.Card = null;
    }

    public bool LogIn(string pin)
    {
        if(this.Card == null)
            throw new Exception("Unable to log in because no card has been inserted.");

        if(!this.isLogged)
            throw new Exception("User is already logged-in");

        if(this.Card.CheckPin(pin)) 
        {
            this.isLogged = true;
            return true;
        }
        else
        {
            return false;
        }
    
    }

    
}