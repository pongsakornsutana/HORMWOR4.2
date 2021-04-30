using System;

namespace home3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please Input your half DNA sequence :");
            string halfDNASequence = Console.ReadLine();
            IsValidSequence(halfDNASequence);
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                    IncorrectDNA(halfDNASequence);
                }
            }
            return true;
            correctDNA(halfDNASequence);
        }
        static void correctDNA(string halfDNASequence)
        {
            Console.WriteLine("Current half DNA sequence is :{0}", halfDNASequence);
            Console.WriteLine("Do you want to Replicate it? (Y/N):");
            char answer = char.Parse(Console.ReadLine());
            switch (answer)
            {
                case 'Y':
                    {
                        ReplicateSeqeunce(halfDNASequence);
                    }
                    break;
                case 'N':
                    {
                        return;
                    }
                    break;
                default:
                    {
                        Console.Write("Please Input Y/N");
                        return;
                    }
                    break;
            }

        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
            Console.Write("Replicate half DNA sequence :{0}", result);
        }
        static void IncorrectDNA(string halfDNASequence)
        {
            Console.Write("Do you want to prcess another sequnece? (Y/N) :");
            char answer = char.Parse(Console.ReadLine());
            switch (answer)
            {
                case 'Y':
                    {
                        return;
                    }
                    break;
                case 'N':
                    {
                        return;
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Please Input Y/N");
                        return;
                    }
                    break;
            }

        }
    }
}