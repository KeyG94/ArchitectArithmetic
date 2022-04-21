using System;

namespace ReviewMethodOutput
{

    namespace ArchitectArithmetic
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("What monumentum would you like to work with?");
                Console.WriteLine("Teotihucan, Taj Mahal or Al-masjid?");
                // Await response
                string res = Console.ReadLine();

                // Conditional

                if (res != null)
                {
                    switch (res.ToLower())
                    {

                        case "teotihucan":
                            Console.WriteLine($"The plan for that monument costs {CalculateTotalCostTeotihucan()} pesos!");
                            break;
                        case "taj mahal":
                            Console.WriteLine($"The plan for that monument costs { CalculateTotalCostTajMahal()} pesos!");
                            break;
                        case "al-masjid":
                            Console.WriteLine($"The plan for that monument costs { CalculateTotalCostAlMasjid()} pesos!");
                            break;
                        default:
                            Console.WriteLine("Nothing was picked");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Sorry, didnt understand you");
                }

            }

            static double CalculateTotalCostAlMasjid()
            {
                double rectMain = CalculateRectangle(284, 264);
                double rectSmall = CalculateRectangle(180, 106);
                double triangle = CalculateTriangle(264, 84);
                double costOfFloorinMaterial = 180;
                double totalArea = rectMain + rectSmall + triangle;
                double totalCost = costOfFloorinMaterial * totalArea;

                return Math.Round(totalCost, 2);

            }

            static double CalculateTotalCostTajMahal()
            {
                double rect = CalculateRectangle(90.5, 90.5);
                double triangle = CalculateTriangle(24, 24);
                double costOfFloorinMaterial = 180;
                double totalArea = rect - triangle * 4;
                double totalCost = costOfFloorinMaterial * totalArea;

                return Math.Round(totalCost, 2);
            }

            static double CalculateTotalCostTeotihucan()
            {
                double rect = CalculateRectangle(1500, 2500);
                double circle = CalculateCircle(375);
                double triangle = CalculateTriangle(500, 750);
                double costOfFloorinMaterial = 180;
                double totalArea = rect + circle + triangle;
                double totalCost = costOfFloorinMaterial * totalArea;

                return Math.Round(totalCost, 2);
            }

            static double CalculateRectangle(double length, double width)

            {
                double result = length * width;
                return result;
            }

            static double CalculateCircle(double radius)
            {
                double result = Math.PI * Math.Pow(radius, 2);
                return result;
            }

            static double CalculateTriangle(double bottom, double height)
            {
                double result = .5 * bottom * height;
                return result;
            }

        }
    }
}