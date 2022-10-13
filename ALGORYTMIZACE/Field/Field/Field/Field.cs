namespace Field;

public class Field
{
    private int[] arrayField;

    public void AddValue(int pos, int value)
    {
        int[] temp = new int[arrayField.Length + 1];

        for (int i = 0; i < temp.Length; i++)
        {
            if(i == pos - 1)
                temp[i] = value;
            else if(i > pos - 1)
                temp[i] = arrayField[i-1];
            else
                temp[i] = arrayField[i];
        }

        arrayField = new int[temp.Length];
        arrayField = temp;
        WriteOut(arrayField);
    }

    public void RemoveValue(int pos)
    {
        pos /= 2;//????????
        int[] temp = new int[arrayField.Length - 1];

        for (int i = 0; i < temp.Length; i++)
        {
            if (i >= pos)
                temp[i] = arrayField[i + 1];
            else
                temp[i] = arrayField[i];
        }

        arrayField = new int[temp.Length];
        arrayField = temp;
        WriteOut(arrayField);
    }

    private void WriteOut(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
                Console.ForegroundColor = ConsoleColor.White;
            else
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public void FillArray(int size)
    {
        Random r = new Random();
        arrayField = new int[size];
        for (int i = 0; i < arrayField.Length; i++)
        {
            arrayField[i] = r.Next(0, 9);
        }

        WriteOut(arrayField);
    }

    public void Divide()
    {
        int[] tempOne = new int[arrayField.Length/2];
        int[] tempTwo = new int[arrayField.Length/2];

        for (int i = 0; i < arrayField.Length; i++)
        {
            if (i % 2 == 0)
                tempOne[i / 2] = arrayField[i];
            else
                tempTwo[i / 2] = arrayField[i];
        }
        WriteOut(tempOne);
        WriteOut(tempTwo);
    }

    public void Join(int[] first, int[] second)
    {
        int[] joined = new int[first.Length + second.Length];

        if (first.Length != second.Length)
        {
            int[] shorter = first.Length < second.Length ? first : second;
            int[] longer = first.Length > second.Length ? first : second;
            
            
            for (int i = 0; i < shorter.Length * 2; i++)
            {
                if (i % 2 == 0)
                    joined[i] = first[i / 2];
                else
                    joined[i] = second[i / 2];
            }

            for (int i = 0; i < longer.Length - shorter.Length; i++)
            {
                joined[i + shorter.Length*2] = longer[i + shorter.Length];
            }
        }
        else
        {
            for (int i = 0; i < joined.Length; i++)
            {
                if (i % 2 == 0)
                    joined[i] = first[i / 2];
                else
                    joined[i] = second[i / 2];
            }
        }
        
        WriteOut(first);
        WriteOut(second);
        WriteOut(joined);
    }
}