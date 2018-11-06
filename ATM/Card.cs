using System;

public class Card
{
    public string CardNumber{get; set;}
    private string Pin{get; set;}
    public DateTime ExpiryDate{get;}
    public int Cvc{get;}
    public CardType type{get;}
    private int nbTries;
    public bool IsBlocked
    {
        get{ return this.nbTries >= MAXNBTRIES; }
    }

    private const int MAXNBTRIES = 3;

    public Card(string cardNumber, string pin, DateTime expiryDate, int cvc, CardType type)
    {
        this.CardNumber = cardNumber;
        this.Pin = pin;
        this.ExpiryDate = ExpiryDate;
        this.type = type;
        this.nbTries = 0;
    }


    public bool PerformPinCheck(string pin)
    {
        if(this.IsBlocked)
            throw new Exception("This card is blocked.");
        
        if(this.Pin == pin)
        {
            this.nbTries = 0;
            return true;
        }
        else
        {
            this.nbTries++;
            return false;
        }
    }


}
    