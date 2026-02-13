using System;
using System.Linq;
using System.Text;

namespace Tib.Api.CryptographyService
{
  /// <summary>
  /// Cross-platform solution for generating random numbers or characters.
  /// </summary>
  public static class Randomizer
  {
    /// <summary>
    /// Randomly generates a positive number (from 0 to max) of the specified type.
    /// </summary>
    /// <typeparam name="T">Numeric type to generate</typeparam>
    /// <param name="max">Maximum value of the generated number</param>
    /// <returns>Random number value</returns>
    public static T GetRandomNumber<T>(T max) where T : struct, IComparable, IComparable<T>, IEquatable<T>, IFormattable
    {
      return GetRandomNumber<T>((T)(dynamic)0, max);
    }

    /// <summary>
    /// Randomly generates a number (from min to max) of the specified type.
    /// </summary>
    /// <typeparam name="T">Numeric type to generate</typeparam>
    /// <param name="min">Minimum value of the generated number</param>
    /// <param name="max">Maximum value of the generated number</param>
    /// <returns>Random number value</returns>
    public static T GetRandomNumber<T>(T min, T max) where T : struct, IComparable, IComparable<T>, IEquatable<T>, IFormattable
    {
      return (T)(((Convert.ToDecimal(BitConverter.ToUInt64(Guid.NewGuid().ToByteArray(), 8)) / UInt64.MaxValue) * Convert.ToDecimal((dynamic)max - min)) + Convert.ToDecimal(min));
    }

    /// <summary>
    /// Returns a random string of the specified length.
    /// </summary>
    /// <param name="numberOfCharacter">Number of characters to generate</param>
    /// <param name="codeType">Type of characters to generate. (Letters are lowercase)</param>
    /// <returns>A string containing only letters (lowercase) and/or digits</returns>
    public static string GetRandomString(int numberOfCharacter, RandomCodeTypeEnum codeType)
    {
      Guid guid = Guid.NewGuid();
      byte[] bytes = guid.ToByteArray();
      StringBuilder sb = new StringBuilder();

      //Precision loss of 2x (16 bytes to numberOfCharacter bytes)
      foreach (byte byteValue in bytes.Take(numberOfCharacter))
      {
        //Precision loss of 7.15x.
        byte useByte;

        switch (codeType)
        {
          case RandomCodeTypeEnum.LowerLettersOnly:
            useByte = (byte)(byteValue / 9.84);
            break;
          case RandomCodeTypeEnum.UpperLettersOnly:
            useByte = (byte)((byteValue / 9.84) + 26);
            break;
          case RandomCodeTypeEnum.LettersOnly:
            useByte = (byte)(byteValue / 4.92);
            break;
          case RandomCodeTypeEnum.NumbersOnly:
            useByte = (byte)((byteValue / 25.6) + 52);
            break;
          case RandomCodeTypeEnum.LettersAndNumbers:
          default:
            useByte = (byte)(byteValue / 4.15);
            break;
        }

        switch (useByte)
        {
          case 0: sb.Append("a"); break;
          case 1: sb.Append("b"); break;
          case 2: sb.Append("c"); break;
          case 3: sb.Append("d"); break;
          case 4: sb.Append("e"); break;
          case 5: sb.Append("f"); break;
          case 6: sb.Append("g"); break;
          case 7: sb.Append("h"); break;
          case 8: sb.Append("i"); break;
          case 9: sb.Append("j"); break;
          case 10: sb.Append("k"); break;
          case 11: sb.Append("l"); break;
          case 12: sb.Append("m"); break;
          case 13: sb.Append("n"); break;
          case 14: sb.Append("o"); break;
          case 15: sb.Append("p"); break;
          case 16: sb.Append("q"); break;
          case 17: sb.Append("r"); break;
          case 18: sb.Append("s"); break;
          case 19: sb.Append("t"); break;
          case 20: sb.Append("u"); break;
          case 21: sb.Append("v"); break;
          case 22: sb.Append("w"); break;
          case 23: sb.Append("x"); break;
          case 24: sb.Append("y"); break;
          case 25: sb.Append("z"); break;
          case 26: sb.Append("A"); break;
          case 27: sb.Append("B"); break;
          case 28: sb.Append("C"); break;
          case 29: sb.Append("D"); break;
          case 30: sb.Append("E"); break;
          case 31: sb.Append("F"); break;
          case 32: sb.Append("G"); break;
          case 33: sb.Append("H"); break;
          case 34: sb.Append("I"); break;
          case 35: sb.Append("J"); break;
          case 36: sb.Append("K"); break;
          case 37: sb.Append("L"); break;
          case 38: sb.Append("M"); break;
          case 39: sb.Append("N"); break;
          case 40: sb.Append("O"); break;
          case 41: sb.Append("P"); break;
          case 42: sb.Append("Q"); break;
          case 43: sb.Append("R"); break;
          case 44: sb.Append("S"); break;
          case 45: sb.Append("T"); break;
          case 46: sb.Append("U"); break;
          case 47: sb.Append("V"); break;
          case 48: sb.Append("W"); break;
          case 49: sb.Append("X"); break;
          case 50: sb.Append("Y"); break;
          case 51: sb.Append("Z"); break;
          case 52: sb.Append("0"); break;
          case 53: sb.Append("1"); break;
          case 54: sb.Append("2"); break;
          case 55: sb.Append("3"); break;
          case 56: sb.Append("4"); break;
          case 57: sb.Append("5"); break;
          case 58: sb.Append("6"); break;
          case 59: sb.Append("7"); break;
          case 60: sb.Append("8"); break;
          case 61: sb.Append("9"); break;
        }
      }
      return sb.ToString();
    }

  }
}
