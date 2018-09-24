using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talkingClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Please enter the 24hour time-----");
            Console.WriteLine("e.g. 22:12");
            Console.WriteLine("");

                        
            string time = Console.ReadLine();
            try
            {
                string firstHalf = "";
                string lastHalf = "";
                string mornAft = "";

                string[] singles = { "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine " };
                string[] teens = { "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen", "eighteen", "nineteen" };
                string[] tens = { "twenty ", "thirty ", "fourty ", "fifty " };

                if (time.Contains(':'))
                {
                    firstHalf = time.Split(':')[0];
                    lastHalf = time.Substring(3);
                }

                switch (firstHalf)
                {

                    case "01":
                        firstHalf = singles[0];
                        mornAft = "AM ";
                        break;
                    case "02":
                        firstHalf = singles[1];
                        mornAft = "AM ";
                        break;
                    case "03":
                        firstHalf = singles[2];
                        mornAft = "AM ";
                        break;
                    case "04":
                        firstHalf = singles[3];
                        mornAft = "AM ";
                        break;
                    case "05":
                        firstHalf = singles[4];
                        mornAft = "AM ";
                        break;
                    case "06":
                        firstHalf = singles[5];
                        mornAft = "AM ";
                        break;
                    case "07":
                        firstHalf = singles[6];
                        mornAft = "AM ";
                        break;
                    case "08":
                        firstHalf = singles[7];
                        mornAft = "AM ";
                        break;
                    case "09":
                        firstHalf = singles[8];
                        mornAft = "AM ";
                        break;
                    case "10":
                        firstHalf = teens[0];
                        mornAft = "AM ";
                        break;
                    case "11":
                        firstHalf = teens[1];
                        mornAft = "AM ";
                        break;
                    case "12":
                        firstHalf = teens[2];
                        mornAft = "PM ";
                        break;
                    case "13":
                        firstHalf = singles[0];
                        mornAft = "PM ";
                        break;
                    case "14":
                        firstHalf = singles[1];
                        mornAft = "PM ";
                        break;
                    case "15":
                        firstHalf = singles[2];
                        mornAft = "PM ";
                        break;
                    case "16":
                        firstHalf = singles[3];
                        mornAft = "PM ";
                        break;
                    case "17":
                        firstHalf = singles[4];
                        mornAft = "PM ";
                        break;
                    case "18":
                        firstHalf = singles[5];
                        mornAft = "PM ";
                        break;
                    case "19":
                        firstHalf = singles[6];
                        mornAft = "PM ";
                        break;
                    case "20":
                        firstHalf = singles[7];
                        mornAft = "PM ";
                        break;
                    case "21":
                        firstHalf = singles[8];
                        mornAft = "PM ";
                        break;
                    case "22":
                        firstHalf = tens[0];
                        mornAft = "PM ";
                        break;
                    case "23":
                        firstHalf = tens[1];
                        mornAft = "PM ";
                        break;
                    case "24":
                        firstHalf = tens[2];
                        mornAft = "AM ";
                        break;

                    default:
                        firstHalf = "not a correct time!";
                        break;
                }

                switch (lastHalf.Substring(0, 1))
                {
                    case "0":
                        switch (lastHalf.Substring(1))
                        {
                            case "0":
                                lastHalf = "";
                                break;
                            case "1":
                                lastHalf = singles[0];
                                break;
                            case "2":
                                lastHalf = singles[1];
                                break;
                            case "3":
                                lastHalf = singles[2];
                                break;
                            case "4":
                                lastHalf = singles[3];
                                break;
                            case "5":
                                lastHalf = singles[4];
                                break;
                            case "6":
                                lastHalf = singles[5];
                                break;
                            case "7":
                                lastHalf = singles[6];
                                break;
                            case "8":
                                lastHalf = singles[7];
                                break;
                            case "9":
                                lastHalf = singles[8];
                                break;
                            default:
                                lastHalf = "not a correct time!";
                                break;

                        }
                        break;

                    case "1":
                        switch (lastHalf.Substring(1))
                        {
                            case "0":
                                lastHalf = teens[0];
                                break;
                            case "1":
                                lastHalf = teens[1];
                                break;
                            case "2":
                                lastHalf = teens[2];
                                break;
                            case "3":
                                lastHalf = teens[3];
                                break;
                            case "4":
                                lastHalf = teens[4];
                                break;
                            case "5":
                                lastHalf = teens[5];
                                break;
                            case "6":
                                lastHalf = teens[6];
                                break;
                            case "7":
                                lastHalf = teens[7];
                                break;
                            case "8":
                                lastHalf = teens[8];
                                break;
                            case "9":
                                lastHalf = teens[9];
                                break;
                            default:
                                lastHalf = "not a correct time!";
                                break;

                        }
                        break;
                    case "2":
                        switch (lastHalf.Substring(1))
                        {
                            case "0":
                                lastHalf = tens[0];
                                break;
                            case "1":
                                lastHalf = tens[0] + singles[0];
                                break;
                            case "2":
                                lastHalf = tens[0] + singles[1];
                                break;
                            case "3":
                                lastHalf = tens[0] + singles[2];
                                break;
                            case "4":
                                lastHalf = tens[0] + singles[3];
                                break;
                            case "5":
                                lastHalf = tens[0] + singles[4];
                                break;
                            case "6":
                                lastHalf = tens[0] + singles[5];
                                break;
                            case "7":
                                lastHalf = tens[0] + singles[6];
                                break;
                            case "8":
                                lastHalf = tens[0] + singles[7];
                                break;
                            case "9":
                                lastHalf = tens[0] + singles[8];
                                break;
                            default:
                                lastHalf = "not a correct time!";
                                break;

                        }
                        break;

                    case "3":
                        switch (lastHalf.Substring(1))
                        {
                            case "0":
                                lastHalf = tens[1];
                                break;
                            case "1":
                                lastHalf = tens[1] + singles[0];
                                break;
                            case "2":
                                lastHalf = tens[1] + singles[1];
                                break;
                            case "3":
                                lastHalf = tens[1] + singles[2];
                                break;
                            case "4":
                                lastHalf = tens[1] + singles[3];
                                break;
                            case "5":
                                lastHalf = tens[1] + singles[4];
                                break;
                            case "6":
                                lastHalf = tens[1] + singles[5];
                                break;
                            case "7":
                                lastHalf = tens[1] + singles[6];
                                break;
                            case "8":
                                lastHalf = tens[1] + singles[7];
                                break;
                            case "9":
                                lastHalf = tens[1] + singles[8];
                                break;
                            default:
                                lastHalf = "not a correct time!";
                                break;

                        }
                        break;

                    case "4":
                        switch (lastHalf.Substring(1))
                        {
                            case "0":
                                lastHalf = tens[2];
                                break;
                            case "1":
                                lastHalf = tens[2] + singles[0];
                                break;
                            case "2":
                                lastHalf = tens[2] + singles[1];
                                break;
                            case "3":
                                lastHalf = tens[2] + singles[2];
                                break;
                            case "4":
                                lastHalf = tens[2] + singles[3];
                                break;
                            case "5":
                                lastHalf = tens[2] + singles[4];
                                break;
                            case "6":
                                lastHalf = tens[2] + singles[5];
                                break;
                            case "7":
                                lastHalf = tens[2] + singles[6];
                                break;
                            case "8":
                                lastHalf = tens[2] + singles[7];
                                break;
                            case "9":
                                lastHalf = tens[2] + singles[8];
                                break;
                            default:
                                lastHalf = "not a correct time!";
                                break;

                        }
                        break;

                    case "5":
                        switch (lastHalf.Substring(1))
                        {
                            case "0":
                                lastHalf = tens[3];
                                break;
                            case "1":
                                lastHalf = tens[3] + singles[0];
                                break;
                            case "2":
                                lastHalf = tens[3] + singles[1];
                                break;
                            case "3":
                                lastHalf = tens[3] + singles[2];
                                break;
                            case "4":
                                lastHalf = tens[3] + singles[3];
                                break;
                            case "5":
                                lastHalf = tens[3] + singles[4];
                                break;
                            case "6":
                                lastHalf = tens[3] + singles[5];
                                break;
                            case "7":
                                lastHalf = tens[3] + singles[6];
                                break;
                            case "8":
                                lastHalf = tens[3] + singles[7];
                                break;
                            case "9":
                                lastHalf = tens[3] + singles[8];
                                break;
                            default:
                                lastHalf = "not a correct time!";
                                break;


                        }
                        break;
                    default:
                        lastHalf = "not a correct time!";
                        break;

                }
                if(firstHalf.Equals("not a correct time!") || lastHalf.Equals("not a correct time!"))
                    {
                    Console.WriteLine("Incorrect time!");
                    Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("It is " + firstHalf + lastHalf + mornAft);
                        Console.ReadLine();
                    }
               
            }

            catch(Exception e)
            {
                string error = "error! " + e;
                Console.WriteLine(error);
                Console.ReadLine();

            }
            
            




        }
    }
}
