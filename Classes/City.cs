namespace ClassesPract2.Classes;

using System.Text.RegularExpressions;
public class CreditCard()
{
    private string cardNumber;
    private string cardHolder;
    private string cvc;
    private string expiryDate;
    private int money;

    public string CardNumber
    {
        get => cardNumber;
        set
        {
            if (!Regex.IsMatch(value, @"^\d{16}$"))
            {
                throw new ArgumentException("Card number must be 16 digits long");
            }
            cardNumber = value;
        }
    }

    public string CVC
    {
        get => cvc;
        set
        {
            if (!Regex.IsMatch(value, @"^\d{3}$"))
            {
                throw new ArgumentException("CVC must be 3 digits long");
            }
            cvc = value;
        }
    }

    public string ExpiryDate
    {
        get => expiryDate;
        set 
        {
            if (!Regex.IsMatch(value, @"^\d{2}/\d{2}$"))
            {
                throw new ArgumentException("Expiry date must be in the format MM/YY");
            }
            expiryDate = value;
        }
    }

    public string CardHolder
    {
        get => cardHolder;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Card holder cannot be empty");
            }
            cardHolder = value;
        }
    }
    
    public int Money
    {
        get => money;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }
    }
    public CreditCard(string cardNumber, string cardHolder, string cvc, string expiryDate, int money) : this()
    {
        CardNumber = cardNumber;
        CardHolder = cardHolder;
        CVC = cvc;
        ExpiryDate = expiryDate;
        Money = money;
    }
    public override string ToString()
    {
        return $"Card Number: {CardNumber}\nCard Holder: {CardHolder}\nCVC: {CVC}\nExpiry Date: {ExpiryDate}\nMoney: {Money}";
    }
    
    public static CreditCard operator +(CreditCard card, int amount)
    {
        card.Money += amount;
        return card;
    }
    public static CreditCard operator -(CreditCard card, int amount)
    {
        if (card.Money < amount)
        {
            throw new InvalidOperationException("Insufficient funds");
        }
        card.Money -= amount;
        return card;
    }
    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        return card1.CardNumber == card2.CardNumber;
    }
    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return !(card1 == card2);
    }
    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.Money > card2.Money;
    }
    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.Money < card2.Money;
    }
    public override bool Equals(object obj)
    {
        if (obj is CreditCard card)
        {
            return this == card;
        }
        return false;
    }
}