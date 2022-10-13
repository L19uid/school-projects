// See https://aka.ms/new-console-template for more information

using DefaultNamespace;

TextDisplay textDisplay = new TextDisplay();
Diary diary = new Diary();

Diary.Load();
do
{
    Console.Clear();;

    textDisplay.Info();
    textDisplay.WriteOutDiary();
    diary.HandleInput(InputHandler.HandleInput());
} while (true);

