using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer.Extentions
{
    public static class Extensions
    {
		/// <summary>
		/// Capitalize the text
		/// </summary>
		/// <param text: ="text"></param>
		/// <returns>Capitalized text</returns>
		public static string Capitalize(this string text)
		{
			char firstLetter = Char.ToUpper(text[0]);
			StringBuilder stringBuilder = new StringBuilder(text);
			stringBuilder[0] = firstLetter;
			return stringBuilder.ToString();
		}
	}
}
