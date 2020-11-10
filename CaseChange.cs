using System;
using System.Text;

class CaseChange{

    public static void Main(String[] args){
        
        String sentence = "This sentence looks funny";

        Console.WriteLine(changeString(sentence));
        
    }

    // Alternates the casing of characters in a phrase with the first letter being uppercase
    private static String changeString(String sentence){
        StringBuilder sb = new StringBuilder();
        int counter = 0; // custom counter that increments when the current character is a letter
        // look through every character and space in the String
        for(int i = 0; i < sentence.Length; i++){
            // if the current index is a space, append a space but dont increment counter
            if(Char.IsWhiteSpace(sentence[i])){
                sb.Append(" ");
            }
            // if the current index is a letter, go in else bracket
            else{
                // first letter is uppercase, so every even letter will be uppercase
                if(counter % 2 == 0){
                    sb.Append(Char.ToUpper(sentence[i]));
                    counter++;
                }
                // every odd letter will be lowercase
                else{
                    sb.Append(Char.ToLower(sentence[i]));
                    counter++;
                }
            }
        }
        return sb.ToString();
    }
}
