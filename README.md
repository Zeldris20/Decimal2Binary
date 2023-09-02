had issues with the math, it would keep giving me the wrong answer " 10010101 is = to 21 " when its 149

static int BinaryToDecimal(string binary)
    {
        int decimalNumber = 0;

        for (int i = binary.Length - 1, exponent = 0; i >= 0; i--, exponent++)
        {
            int digit = binary[i] - '0'; // Convert the character '0' or '1' to the corresponding integer.
            decimalNumber += digit * (int)Math.Pow(2, exponent);
        }

        thats the code and I realised it was a problem with my calculations so instead I changed it to this 

        static int BinaryToDecimal(string binary)
    {
        int decimalNumber = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            char binaryDigit = binary[binary.Length - 1 - i];
            if (binaryDigit == '1')
            {
                decimalNumber |= (1 << i);
            }
        }

        return decimalNumber;
