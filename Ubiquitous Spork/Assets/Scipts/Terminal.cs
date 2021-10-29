using System;
using System.Collections.Generic;

public static class Terminal
{
    public const int Columns = 40;
    public const int Rows = 30;
    private static List<byte> cells;
    private static int writeIndex = 0;
    private static string inputBuffer="";
    private static List<byte> GetCells()
    {
        if (cells == null)
        {
            cells = new List<byte>();
            while (cells.Count < Columns * Rows)
            {
                cells.Add(32);
            }
        }
        return cells;
    }
    public static byte GetCell(int column, int row)
    {
        return GetCells()[column + row * Columns];
    }
    private static void Scroll()
    {
        for(int row=0;  row<Rows;++row)
        {
            for(int column=0; column<Columns;++column)
            {
                if(row<Rows-1)
                {
                    GetCells()[row * Columns + column] = GetCells()[row * Columns + column + Columns];
                }
                else
                {
                    GetCells()[row * Columns + column] = 32;
                }
            }
        }
    }
    private static void Write(byte character)
    {
        GetCells()[writeIndex] = character;
        writeIndex++;
        if(writeIndex==Columns*Rows)
        {
            writeIndex -= Columns;
            Scroll();
        }
    }
    public static void ClearInputBuffer()
    {
        inputBuffer = "";
    }
    public static Action<string> HandleInputLine;
    public static void Write(string text, bool addToInputBuffer)
    {
        foreach (var ch in text)
        {
            if (addToInputBuffer && ch == '\b')
            {
                if(inputBuffer.Length>0)
                {
                    inputBuffer = inputBuffer.Substring(0, inputBuffer.Length - 1);
                    writeIndex--;
                    Write(32);
                    writeIndex--;
                }
            }
            else if (ch == '\r' || ch == '\n')
            {
                do
                {
                    Write(32);
                } while (writeIndex % Columns !=0 );
                if (addToInputBuffer)
                {
                    HandleInputLine(inputBuffer);
                    ClearInputBuffer();
                }
            }
            else
            {
                Write((byte)ch);
                if(addToInputBuffer)
                {
                    inputBuffer += ch;
                }
            }
        }
    }
}
