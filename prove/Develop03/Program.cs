using System;

class Program
{
    static void Main(string[] args)
    {
        Reference jonh = new Reference("Jonh", 3, 16, 16);
        Scripture scripture = new Scripture("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        scripture.SetReference(jonh.ShowReference());
        scripture.StartMemorize();

         

        /*
    
        Scripture  (GetRenderedText, Display, HideWords) - to hold a whole scripture and to show rendered versions of it whenever it is called to do that.
        Reference  (Reference, GetScriptureText) - To hold reference's information and use it to load and return a text scripture.
        Word (Hide, Show) - to hold a single word from a scripture        
        Attributes of Scripture:
            _text: string
            _reference: Reference
            _listWord: List
            _reference: Reference
            _isCompletelyHidden: bool
        Attributes of Reference:
            _book: string
            _chapter: int
            _verse_start: int
            _verse_end: int
        Attributes of Word:
            _isHidden: bool
            _isCompletelyHidden: bool
            _text: string
            _renderedText: string
        */
    }
}