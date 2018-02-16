using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstDotNetProject
{
    class MathematicalOperationClass : MathematicalOperationInterface
    {
        public void AddingTwoNumbers(float number1, float number2)
        {

            Console.WriteLine("Addition of Two number is: {0}", (number1 + number2));
        }

        public void AddingThreeNumbers(float number1, float number2, float number3)
        {

            Console.WriteLine("Addition of Three number is: {0}", (number1 + number2 + number3));
        }


        public void SubstractingTwoNumbers(float number1, float number2)
        {
            Console.WriteLine("Substraction of Two number is: {0}", (number1 - number2));
        }

        public void MultiplicationOfTwoNumbers(float number1, float number2)
        {
            Console.WriteLine("Multiplication of Two number is: {0}", (number1 * number2));
        }

        public void MultiplicationOfThreeNumbers(float number1, float number2, float number3)
        {
            Console.WriteLine("Multiplication of Three number is: {0}", (number1 * number2 * number3));
        }


        public void DivisionOfNumbers(float numbner1, float number2)
        {
            float outputDiv = 0.0f;
            try
            {
                outputDiv = numbner1 / number2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("you entered '0' as a value \n denominator value must not be '0' :{0}", e);
            }

            Console.WriteLine("Division of Two number is: {0}", outputDiv);
        }


        public void BubbleSort(int length)
        {
            int i, j;
            float temp;
            float[] givenArray = new float[length];
            Console.WriteLine("Enter the value in the array");
            for (i = 0; i < givenArray.Length; i++)
            {
                givenArray[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Array Before sorting is: \n");
            for (i = 0; i < givenArray.Length; i++)
            {
                Console.Write(givenArray[i]);
            }

            for (i = 0; i <= givenArray.Length - 1; i++)
            {
                for (j = i + 1; j < givenArray.Length; j++)
                {
                    if (givenArray[j] < givenArray[i])
                    {

                        temp = givenArray[i];
                        givenArray[i] = givenArray[j];
                        givenArray[j] = temp;
                    }
                }

            }
            Console.Write(" \n");
            Console.WriteLine("Araay After Sorting: \n");
            for (i = 0; i < givenArray.Length; i++)
            {
                Console.Write(givenArray[i]);
            }


        }


        public void ArraySum(int length1, int length2)
        {
            int i, j, temp = 0;
            if (length1 > length2)
            {
                temp = length1 - length2;
                float[] firstArray = new float[length1];
                float[] secondArray = new float[length2 + temp];
                Console.WriteLine("Enter value in the first array");
                for (i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Enter value in the Second array");
                for (i = 0; i < length2; i++)
                {
                    secondArray[i] = Convert.ToInt16(Console.ReadLine());
                }
                float[] sumArray = new float[firstArray.Length];
                for (i = 0; i < sumArray.Length; i++)
                {

                    sumArray[i] = firstArray[i] + secondArray[i];
                }
                Console.WriteLine("Sum of the two arrays are: ");
                for (i = 0; i < sumArray.Length; i++)
                {
                    Console.Write(sumArray[i]);
                }
                Console.WriteLine();
            }
            else if (length1 < length2)
            {
                temp = length2 - length1;
                float[] firstArray = new float[length1 + temp];
                float[] secondArray = new float[length2];
                Console.WriteLine("Enter value in the first array");
                for (i = 0; i < length1; i++)
                {
                    firstArray[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Enter value in the Second array");
                for (i = 0; i < secondArray.Length; i++)
                {
                    secondArray[i] = Convert.ToInt16(Console.ReadLine());
                }
                float[] sumArray = new float[firstArray.Length];
                for (i = 0; i < sumArray.Length; i++)
                {

                    sumArray[i] = firstArray[i] + secondArray[i];
                }
                Console.WriteLine("Sum of the two arrays are: ");
                for (i = 0; i < sumArray.Length; i++)
                {
                    Console.Write(sumArray[i]);
                }
                Console.WriteLine();
            }
            else
            {
                float[] firstArray = new float[length1];
                float[] secondArray = new float[length2];
                Console.WriteLine("Enter value in the first array");
                for (i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Enter value in the Second array");
                for (i = 0; i < secondArray.Length; i++)
                {
                    secondArray[i] = Convert.ToInt16(Console.ReadLine());
                }
                float[] sumArray = new float[firstArray.Length];
                for (i = 0; i < sumArray.Length; i++)
                {

                    sumArray[i] = firstArray[i] + secondArray[i];
                }
                Console.WriteLine("Sum of the two arrays are: ");
                for (i = 0; i < sumArray.Length; i++)
                {
                    Console.Write(sumArray[i]);
                }
                Console.WriteLine();
            }
        }  
            
          
        public void CharacterConcatenate(int length)
        {

            char[] charArray = new char[length];
            int i;
            Console.WriteLine("Enter value in the  array");
            for (i = 0; i < charArray.Length; i++)
            {
                charArray[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine();
            String conOutput = new string(charArray);
            Console.WriteLine("concatenation fo the char array is:" + conOutput);
            Console.ReadLine();
        }


        public void SumOfElements(int lengthArray)
        {
            float[] sumArray = new float[lengthArray];
            int i;
            float result = 0;
            Console.WriteLine("Enter value in the  array");
            for (i = 0; i < lengthArray; i++)
            {
                sumArray[i] = Convert.ToInt16(Console.ReadLine());
                result = result + sumArray[i];
            }
            Console.WriteLine("\n Sum of the elements of the array is:{0}", result);
        }


        public void ConcatenateString(int length)
        {
            string[] conStringArray = new string[length];
            int i;
            string conStringResult = null;
            Console.WriteLine("Enter value in the  array");
            for (i = 0; i < conStringArray.Length; i++)
            {
                conStringArray[i] = Console.ReadLine();
                conStringResult = conStringResult + conStringArray[i];
            }
            Console.WriteLine("\n Concatenate of the given strings  is:" + conStringResult);
        }
    }
}
