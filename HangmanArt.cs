public class HangmanArt
{
    public static string[] stages = new string[]
    {
        @"
  +---+
  |   |
      |
      |
      |
      |
=========
", 
        @"
  +---+
  |   |
  O   |
      |
      |
      |
=========
", 
        @"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========
", 
        @"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========
", 
        @"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========
", 
        @"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========
", 
        @"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
=========
"
        // Add more stages if needed
    };

    public static string logo = @"
 _                                             
| |                                            
| |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
| '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
|_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/
";
}
