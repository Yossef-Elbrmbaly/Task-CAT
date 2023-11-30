 string inputstring;
    int i, len, vowels, consonants;
    Console.Write("Enter Your word : ");
    inputstring=Console.ReadLine(); 
    vowels = 0;
    consonants = 0;
    len = inputstring.Length;
 
    for(i = 0; i < len; i++)
    {
         
        if (inputstring[i] == 'a' || inputstring[i] == 'e' || 
            inputstring[i] == 'i' || inputstring[i] == 'o' || 
            inputstring[i] == 'u' || inputstring[i] == 'A' || 
            inputstring[i] == 'E' || inputstring[i] == 'I' || 
            inputstring[i] == 'O' || inputstring[i] == 'U')
        {
             
            vowels++;
        }
         

        else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') || 
                 (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
        {
             
            consonants++;
        }
    }
     
    Console.WriteLine("count of vowel = " + vowels);
    Console.WriteLine("count of consonant = " + consonants);