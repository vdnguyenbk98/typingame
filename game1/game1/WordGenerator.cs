using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class WordGenerator
    { 
        private static string[] wordList = { "0","1","2","3","4","5","6","7","8","9",
            "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","P","Q","R","S","T","U","V","W","X","Y","Z",
             "am","is","sore","filthy","boat","fresh","friendly","mask","supreme","lie","strong","bulb","produce","tongue","spot","exultant","cabbage"
             ,"temporary","branch","romantic","middle","lunch","hose","erect","salty","boast","preach","head","shade","bait","warm","hot"
             ,"holistic","handle","fragile","whistle","heavy","tart","sweater","potato","dirty","badge","woebegone","neat","whole","bag"
             ,"exercise","faithful","humor","desert","moan"};
        
        public static string GetRandomWord()
        {
            Random rd = new Random();
            int indexRandom = rd.Next(wordList.Length);
            string randomWord = wordList[indexRandom];
            return randomWord;
        }
    }
}
