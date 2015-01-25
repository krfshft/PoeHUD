using System;

namespace PoeHUD.Framework.Helpers
{
	public static class ConvertHelper
	{
		public static string ToShorten(double value, string format = "0")
		{
			if (value >= 1000000)
			{
				return string.Concat((value / 1000000).ToString(format), "M");
			}

			if (value >= 1000)
			{
				value = Math.Round((float)value / (float)1000, 2);
				return string.Concat(value.ToString("F1"), "K");
			}

			return value.ToString(format);
		}
	}
}