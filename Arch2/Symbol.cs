using System;
using System.Runtime.CompilerServices;

namespace Arch2
{
    public class MyString
    {
        public string value;

        public char this[int parameter]
        {
            get { return this.value[parameter]; }
        }

        public MyString AddSymbol(char symbolToAdd)
        {
            MyString newString = new MyString();
            newString.value = this.value + symbolToAdd.ToString();
            return newString;
        }

        public MyString AddSymbolToStart(char symbolToAdd)
        {
            MyString newString = new MyString();
            newString.value = symbolToAdd.ToString() + this.value;
            return newString;
        }

        public MyString RemoveBySymbol(char SymbolToRemove)
        {
            MyString newString = new MyString();
            for (int i = 0; i < this.value.Length; i++)
            {
                if (this.value[i] != SymbolToRemove)
                {
                    newString.value = newString.value + this.value[i];
                }
            }
            return newString;
        }
        
        public MyString RemoveByIndex(int IndexToRemove)
        {
            MyString newString = new MyString();
            for (int i = 0; i < this.value.Length; i++)
            {
                if (i != IndexToRemove)
                {
                    newString.value = newString.value + this.value[i];
                }
            }
            return newString;
        }

        public MyString ToLower()
        {
            MyString newString = new MyString();
            for (int i = 0; i < this.value.Length; i++)
            {
                switch (this.value[i])
                {
                    case 'A':
                        newString.value = newString.value + 'a';
                        break;
                    case 'B':
                        newString.value = newString.value + 'b';
                        break;
                    case 'C':
                        newString.value = newString.value + 'c';
                        break;
                    case 'D':
                        newString.value = newString.value + 'd';
                        break;
                    case 'E':
                        newString.value = newString.value + 'e';
                        break;
                    case 'F':
                        newString.value = newString.value + 'f';
                        break;
                    case 'G':
                        newString.value = newString.value + 'g';
                        break;
                    case 'H':
                        newString.value = newString.value + 'h';
                        break;
                    case 'I':
                        newString.value = newString.value + 'i';
                        break;
                    case 'J':
                        newString.value = newString.value + 'j';
                        break;
                    case 'K':
                        newString.value = newString.value + 'k';
                        break;
                    case 'L':
                        newString.value = newString.value + 'l';
                        break;
                    case 'M':
                        newString.value = newString.value + 'm';
                        break;
                    case 'N':
                        newString.value = newString.value + 'n';
                        break;
                    case 'O':
                        newString.value = newString.value + 'o';
                        break;
                    case 'P':
                        newString.value = newString.value + 'p';
                        break;
                    case 'Q':
                        newString.value = newString.value + 'q';
                        break;
                    case 'R':
                        newString.value = newString.value + 'r';
                        break;
                    case 'S':
                        newString.value = newString.value + 's';
                        break;
                    case 'T':
                        newString.value = newString.value + 't';
                        break;
                    case 'U':
                        newString.value = newString.value + 'u';
                        break;
                    case 'V':
                        newString.value = newString.value + 'v';
                        break;
                    case 'W':
                        newString.value = newString.value + 'w';
                        break;
                    case 'X':
                        newString.value = newString.value + 'x';
                        break;
                    case 'Y':
                        newString.value = newString.value + 'y';
                        break;
                    case 'Z':
                        newString.value = newString.value + 'z';
                        break;
                    default:
                        newString.value = newString.value + this.value[i];
                        break;
                }
            }

            return newString;
        }


        public MyString ToHigher()
        {
            MyString newString = new MyString();
            for (int i = 0; i < this.value.Length; i++)
            {
                switch (this.value[i])
                {
                    case 'a':
                        newString.value = newString.value + 'A';
                        break;
                    case 'b':
                        newString.value = newString.value + 'B';
                        break;
                    case 'c':
                        newString.value = newString.value + 'C';
                        break;
                    case 'd':
                        newString.value = newString.value + 'D';
                        break;
                    case 'e':
                        newString.value = newString.value + 'E';
                        break;
                    case 'f':
                        newString.value = newString.value + 'F';
                        break;
                    case 'g':
                        newString.value = newString.value + 'G';
                        break;
                    case 'h':
                        newString.value = newString.value + 'H';
                        break;
                    case 'i':
                        newString.value = newString.value + 'I';
                        break;
                    case 'j':
                        newString.value = newString.value + 'J';
                        break;
                    case 'k':
                        newString.value = newString.value + 'K';
                        break;
                    case 'l':
                        newString.value = newString.value + 'L';
                        break;
                    case 'm':
                        newString.value = newString.value + 'M';
                        break;
                    case 'n':
                        newString.value = newString.value + 'N';
                        break;
                    case 'o':
                        newString.value = newString.value + 'O';
                        break;
                    case 'p':
                        newString.value = newString.value + 'P';
                        break;
                    case 'q':
                        newString.value = newString.value + 'Q';
                        break;
                    case 'r':
                        newString.value = newString.value + 'R';
                        break;
                    case 's':
                        newString.value = newString.value + 'S';
                        break;
                    case 't':
                        newString.value = newString.value + 'T';
                        break;
                    case 'u':
                        newString.value = newString.value + 'U';
                        break;
                    case 'v':
                        newString.value = newString.value + 'V';
                        break;
                    case 'w':
                        newString.value = newString.value + 'W';
                        break;
                    case 'x':
                        newString.value = newString.value + 'X';
                        break;
                    case 'y':
                        newString.value = newString.value + 'Y';
                        break;
                    case 'z':
                        newString.value = newString.value + 'Z';
                        break;
                    default:
                        newString.value = newString.value + this.value[i];
                        break;
                }
            }

            return newString;
        }
        
        




    }
    
}



