using System.Text;

namespace StringMethods
{
	public class MyString
	{

		#region Split
		public string[] SplitArray(string str, char character = ' ')
		{
			string[] myarr = new string[str.Length + 1];
			int arrayCount = 0;
			StringBuilder word = new StringBuilder();
			for (int i = 0; i < str.Length; i++)//Alma.
			{
				if (str[i] != character)
				{
					word.Append(str[i]);

					if (i ==  str.Length - 1)
					{
						myarr[arrayCount] = word.ToString();
						arrayCount++;
					}
					continue;
				}

				myarr[arrayCount] = word.ToString();//Alma
				word = new StringBuilder();// "ARMUD   "
				arrayCount++;
			}
			Array.Resize(ref myarr, arrayCount);

			return myarr;

		}
		#endregion

		#region Substring

		#region Substring(int startIndex)
		public string MySubstring(string word, int index)
		{
			if (index < 0)
			{
				throw new Exception("StartIndex cannot be less than zero");
			}
			else if (index > word.Length)
			{
				throw new Exception("StartIndex cannot be larger than length of string");
			}
			StringBuilder result = new StringBuilder();
			for (int i = index; i < word.Length; i++)
			{
				result.Append(word[i]);
			}
			return result.ToString();
		}
		#endregion

		#region Substring(int index, int length)

		public string MySubstring(string word, int index, int length)
		{
			if (index < 0)
			{
				throw new Exception("StartIndex cannot be less than zero");
			}
			else if (index > word.Length)
			{
				throw new Exception("StartIndex cannot be larger than length of string");
			}
			if (length < 0)
			{
				throw new Exception("Length cannot be less than zero");
			}
			else if (index + length > word.Length)
			{
				throw new Exception("Index and length must refer to a location within the string. ");
			}

			StringBuilder result = new StringBuilder();
			for (int i = index; i < index + length; i++)
			{
				result.Append(word[i]);
			}
			return result.ToString();
		}

		#endregion
		#endregion

		#region Replace

		public string MyReplace(string word, char oldChar, char newChar)
		{
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] == oldChar)
				{
					result.Append(newChar);
					continue;
				}
				result.Append(word[i]);
			}
			return result.ToString();
		}
		#endregion

	}
}