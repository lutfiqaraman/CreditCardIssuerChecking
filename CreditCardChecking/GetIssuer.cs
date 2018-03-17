using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardChecking
{
    public class GetIssuer
    {
        long CreditCardNumber;

        public GetIssuer(long CCNumber)
        {
            CreditCardNumber = CCNumber;
        }

        public string CheckIssuer()
        {
            string CardType = "Unknown";
            var strCardNumber = CreditCardNumber.ToString();

            //Check American Express
            if (strCardNumber.Substring(0, 2) == "34" || strCardNumber.Substring(0, 2) == "37")
            {
                if (strCardNumber.Length == 15)
                    CardType = "AMEX";
            }

            //Check Discover Credit Card
            if (strCardNumber.Substring(0, 4) == "6011")
            {
                if (strCardNumber.Length == 16)
                    CardType = "Discover";
            }

            //Check Visa Credit Card
            if (strCardNumber.Substring(0, 1) == "4")
            {
                if (strCardNumber.Length == 13 || strCardNumber.Length == 16)
                    CardType = "VISA";
            }


            //Check Matercard Credit Card
            if (
                strCardNumber.Substring(0, 2) == "51" || strCardNumber.Substring(0, 2) == "52" ||
                strCardNumber.Substring(0, 2) == "53" || strCardNumber.Substring(0, 2) == "54" ||
                strCardNumber.Substring(0, 2) == "55"
                )
            {
                if (strCardNumber.Length == 16)
                    CardType = "Mastercard";
            }

            return CardType;
        }
    }
}
