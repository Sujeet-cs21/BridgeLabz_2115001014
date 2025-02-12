using System;

namespace PP_11_02_25
{
    class TextState
    {
        public string Content;
        public TextState Prev;
        public TextState Next;

        public TextState(string content)
        {
            Content = content;
        }
    }

    class Class8
    {
        private TextState current;
        private int maxHistory;
        private int historyCount;

        public Class8(int historyLimit = 10)
        {
            current = null;
            maxHistory = historyLimit;
            historyCount = 0;
        }

        public void AddState(string content)
        {
            TextState newState = new TextState(content);
            if (current != null)
            {
                newState.Prev = current;
                current.Next = newState;
            }
            current = newState;
            historyCount++;

            if (historyCount > maxHistory)
            {
                RemoveOldestState();
            }
        }

        private void RemoveOldestState()
        {
            TextState temp = current;
            while (temp.Prev != null)
            {
                temp = temp.Prev;
            }
            if (temp.Next != null)
            {
                temp.Next.Prev = null;
            }
            historyCount--;
        }

        public void Undo()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Undo: " + current.Content);
            }
            else
            {
                Console.WriteLine("No more undo operations available.");
            }
        }

        public void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Redo: " + current.Content);
            }
            else
            {
                Console.WriteLine("No more redo operations available.");
            }
        }

        public void DisplayCurrentState()
        {
            if (current != null)
            {
                Console.WriteLine("Current State: " + current.Content);
            }
            else
            {
                Console.WriteLine("No text available.");
            }
        }

        public static void Main8()
        {
            Class8 editor = new Class8();

            editor.AddState("Hello");
            editor.AddState("Hello World");
            editor.AddState("Hello World!");

            editor.DisplayCurrentState();

            editor.Undo();
            editor.Undo();
            editor.Redo();

            editor.DisplayCurrentState();
        }
    }

}
