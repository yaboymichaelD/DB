using ATM;
// <copyright file="CardFactory.cs">Copyright ©  2018</copyright>

using System;
using Microsoft.Pex.Framework;

/// <summary>A factory for Card instances</summary>
public static partial class CardFactory
{
    /// <summary>A factory for Card instances</summary>
    [PexFactoryMethod(typeof(global::Card))]
    public static global::Card Create(
        string cardNumber_s,
        string pin_s1,
        DateTime expiryDate_dt,
        int cvc_i,
        global::CardType type_i1_,
        Account account_account
    )
    {
        global::Card card = new global::Card
                                (cardNumber_s, pin_s1, expiryDate_dt, cvc_i, type_i1_, account_account);
        return card;

        // TODO: Edit factory method of Card
        // This method should be able to configure the object in all possible ways.
        // Add as many parameters as needed,
        // and assign their values to each field by using the API.
    }
}
