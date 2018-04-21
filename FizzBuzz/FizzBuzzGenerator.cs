using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public List<String> Generate()
        {
            var list = new List<String>();

            for (int i = 1; i <= 10_000; i++)
            {
                //list.Add(Resolve(i));
                list.Add(ResolvePatternMatching(i));
            }

            return list;
        }

        private (bool multipleOfThree, bool multipleOfFive) IsMultipleOf3or5(int i)
        {
            return (i % 3 == 0, i % 5 == 0);
        }

        private string ResolvePatternMatching(int i)
        {
            switch (IsMultipleOf3or5(i))
            {
                case var status when status.multipleOfThree && status.multipleOfFive:
                    return "FizzBuzz";

                case var status when status.multipleOfThree:
                    return "Fizz";

                case var status when status.multipleOfFive:
                    return "Buzz";

                default:
                    return i.ToString();
            }
        }

        private string Resolve(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return i.ToString();
            }
        }

        private void DoTheThingWithTheSTring(string s)
        {
            //int _ = 42;
            //string _ = "fourty-two";

            var isItAnInt = int.TryParse(s, out _);
        }

        private void Other()
        {
            int _ = 42;
            Console.WriteLine(_);
        }

        public void Refactoring(object someObject)
        {
            SomeType myObject;

            //if (someObject is SomeType)
            //{
            //    myObject = someObject as SomeType;
            //}

            myObject = someObject as SomeType;
            if (myObject != null)
            {
                myObject.SomeMethod(SomeType.Colors.Red);
            }
        }
    }

    internal class SomeType
    {
        public enum Colors
        {
            Red, Blue, Yellow
        }

        public void SomeMethod(Colors someColor)
        {
            switch (someColor)
            {
                case Colors.Red:
                    break;

                case Colors.Blue:
                    break;
            }
        }
    }
}