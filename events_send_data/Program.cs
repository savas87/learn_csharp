using System;

namespace Events_Send_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object
            Wort _wort = new Wort();
            Benachrichtiger _benachrichtiger = new Benachrichtiger();

            // abo the event
            _wort.WordChanged += _benachrichtiger.WordChanged;

            // change the word
            _wort.ChangeWord("Savas");
            _wort.ChangeWord("Erbas");

            // stop program
            Console.ReadKey();
        }
        public delegate void WordChangedEventHandler(object sender, WordChangedEventArgs e);
        public class Wort
        {
            // variable
            private string myWord;

            // method
            public void ChangeWord(string txt)
            {
                myWord = txt;
                Console.WriteLine(myWord);
                onWordChanged();
            }

            // event
            public event WordChangedEventHandler WordChanged;

            // protected only call from this class
            // virtual -> can be override 
            protected virtual void onWordChanged()
            {
                if(WordChanged != null)
                {
                    WordChangedEventArgs args = new WordChangedEventArgs();
                    args.Word = myWord;
                    WordChanged(this, args);
                }
            }
        }
        public class Benachrichtiger
        {
            // method
            public void WordChanged(object sender, WordChangedEventArgs e)
            {
                string newWord = e.Word;
                Console.WriteLine("Das neue Wort ist: " + newWord);
            }
        }
        public class WordChangedEventArgs : EventArgs
        {
            public string Word { get; set; }
        }
    }
}
