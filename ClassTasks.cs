using System;
using System.Collections.Generic;

namespace _0406Practice
{
    public class EvenNum
    {
        private int Value { get; }
        public EvenNum(int value)
        {
            Value = (value % 2 == 0) ? value : -1;

        }
        public override string ToString()
        {
            return Value.ToString();
        }


    }
    public class NotEvenNum
    {
        private int Value { get; }
        public NotEvenNum(int value)
        {
            Value = (value % 2 != 0) ? value : -1;

        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class Triangl
    {
        private int _angle1 { get; set; }
        private int _angle2 { get; set; }
        private int _angle3 { get; set; }
        private int _side1 { get; set; }
        private int _side2 { get; set; }
        private int _side3 { get; set; }

        public Triangl()
        {
            _angle1 = 0;
            _angle2 = 0;
            _angle3 = 0;
            _side1 = 0;
            _side2 = 0;
            _side3 = 0;
        }
        public Triangl(int angle1, int angle2, int angle3, int side1, int side2, int side3)
        {
            _angle1 = angle1;
            _angle2 = angle2;
            _angle3 = angle3;
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public void ShowTriangl()
        {
            Console.WriteLine("Parameters are not specified !");
        }

        public void ShowTriangl(int angle1, int angle2, int angle3, int side1, int side2, int side3)
        {
            Console.WriteLine($"Angle 1 :{_angle1}; Angle 2 :{_angle2}; Angle 3 :{_angle3};");
            Console.WriteLine($"Side 1:{_side1},Side 2:{_side2}; Side 3:{_side3}");
        }

    }
    public class PseudoText
    {
        private string UserLetters1 { get; set; }
        private string UserLetters2 { get; set; }

        private int NumbersWords { get; set; }


        public PseudoText(string userLetters1, string userLetters2, int numbersWords)
        {
            UserLetters1 = userLetters1;
            UserLetters2 = userLetters2;
            NumbersWords = numbersWords;

        }

        public int RandLengthWord()
        {

            Random rnd = new Random();

            return rnd.Next(3, 10);
        }

        public int RandIndex(int end)
        {
            Random rnd = new Random();

            return rnd.Next(0, end);
        }

        public char[] RandomChar()
        {
            char[] arr1and2 = new char[UserLetters1.Length + UserLetters2.Length];

            char[] charArray1 = UserLetters1.ToCharArray();
            char[] charArray2 = UserLetters2.ToCharArray();

            Random rnd = new Random();

            Array.Copy(charArray1, 0, arr1and2, 0, charArray1.Length);
            Array.Copy(charArray2, 0, arr1and2, charArray1.Length, charArray2.Length);


            return arr1and2;
        }

        public string BildSentence()
        {
            List<string> arrWords = new List<string>();

            Random rnd = new Random();

            int num = NumbersWords;

            while (num > 0)
            {
                int length = rnd.Next(3, 9);

                char[] arrWord = new char[length];

                for (int i = 0; i < length; i++)
                {
                    Random rnd2 = new Random();

                    int index = rnd.Next(0, UserLetters1.Length + UserLetters2.Length);

                    char[] arr = new char[(UserLetters1.Length + UserLetters2.Length)];
                    arr = RandomChar();
                    arrWord[i] = arr[index];
                }

                arrWords.Add(new string(arrWord));

                num--;

            }

            string sentence = string.Join(" ", arrWords) + ".";

            string sentenceNew = char.ToUpper(sentence[0]) + sentence.Substring(1);


            return sentenceNew;

        }

        public void ShowSentence()
        {
            Console.WriteLine($"New sentence: {BildSentence()}");
        }


    }


}
