using System;

// Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').
// Ribonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').
// Create a funciton which translates a given DNA string into RNA.

class Program
{
  public static void Main()
  {
    string sampleData = "gcat";
    Console.Write(convertToRna(sampleData));
  }

  static string convertToRna(string dna)
  {
    string result = "";
    for(int i=0; i < dna.Length; i++)
    {
      if (Char.ToUpper(dna[i]) == 'T')
      {
        result +='U';
      }
      else
      {
        result +=Char.ToUpper((dna[i]));
      }
    }
    return result;
  }

}
