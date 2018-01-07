﻿using System;
using NUnit.Framework;

namespace OhioBox.Time.Tests
{
	[TestFixture]
	public class FiscalDateExtensionsTests
	{
		[TestCase("2/1/2015", 1, 1, 1, 2015)]
		[TestCase("2/28/2015", 4, 1, 1, 2015)]
		[TestCase("3/1/2015", 5, 2, 1, 2015)]
		[TestCase("4/4/2015", 9, 2, 1, 2015)]
		[TestCase("4/5/2015", 10, 3, 1, 2015)]
		[TestCase("5/2/2015", 13, 3, 1, 2015)]
		[TestCase("5/3/2015", 14, 4, 2, 2015)]
		[TestCase("5/30/2015", 17, 4, 2, 2015)]
		[TestCase("5/31/2015", 18, 5, 2, 2015)]
		[TestCase("7/4/2015", 22, 5, 2, 2015)]
		[TestCase("7/5/2015", 23, 6, 2, 2015)]
		[TestCase("8/1/2015", 26, 6, 2, 2015)]
		[TestCase("8/2/2015", 27, 7, 3, 2015)]
		[TestCase("8/29/2015", 30, 7, 3, 2015)]
		[TestCase("8/30/2015", 31, 8, 3, 2015)]
		[TestCase("10/3/2015", 35, 8, 3, 2015)]
		[TestCase("10/4/2015", 36, 9, 3, 2015)]
		[TestCase("10/31/2015", 39, 9, 3, 2015)]
		[TestCase("11/1/2015", 40, 10, 4, 2015)]
		[TestCase("11/28/2015", 43, 10, 4, 2015)]
		[TestCase("11/29/2015", 44, 11, 4, 2015)]
		[TestCase("1/2/2016", 48, 11, 4, 2015)]
		[TestCase("1/3/2016", 49, 12, 4, 2015)]
		[TestCase("1/30/2016", 52, 12, 4, 2015)]
		[TestCase("1/31/2016", 1, 1, 1, 2016)]
		[TestCase("2/27/2016", 4, 1, 1, 2016)]
		[TestCase("2/28/2016", 5, 2, 1, 2016)]
		[TestCase("4/2/2016", 9, 2, 1, 2016)]
		[TestCase("4/3/2016", 10, 3, 1, 2016)]
		[TestCase("4/30/2016", 13, 3, 1, 2016)]
		[TestCase("5/1/2016", 14, 4, 2, 2016)]
		[TestCase("5/28/2016", 17, 4, 2, 2016)]
		[TestCase("5/29/2016", 18, 5, 2, 2016)]
		[TestCase("7/2/2016", 22, 5, 2, 2016)]
		[TestCase("7/3/2016", 23, 6, 2, 2016)]
		[TestCase("7/30/2016", 26, 6, 2, 2016)]
		[TestCase("7/31/2016", 27, 7, 3, 2016)]
		[TestCase("8/27/2016", 30, 7, 3, 2016)]
		[TestCase("8/28/2016", 31, 8, 3, 2016)]
		[TestCase("10/1/2016", 35, 8, 3, 2016)]
		[TestCase("10/2/2016", 36, 9, 3, 2016)]
		[TestCase("10/29/2016", 39, 9, 3, 2016)]
		[TestCase("10/30/2016", 40, 10, 4, 2016)]
		[TestCase("11/26/2016", 43, 10, 4, 2016)]
		[TestCase("11/27/2016", 44, 11, 4, 2016)]
		[TestCase("12/31/2016", 48, 11, 4, 2016)]
		[TestCase("1/1/2017", 49, 12, 4, 2016)]
		[TestCase("1/28/2017", 52, 12, 4, 2016)]
		[TestCase("1/29/2017", 1, 1, 1, 2017)]
		[TestCase("2/25/2017", 4, 1, 1, 2017)]
		[TestCase("2/26/2017", 5, 2, 1, 2017)]
		[TestCase("4/1/2017", 9, 2, 1, 2017)]
		[TestCase("4/2/2017", 10, 3, 1, 2017)]
		[TestCase("4/29/2017", 13, 3, 1, 2017)]
		[TestCase("4/30/2017", 14, 4, 2, 2017)]
		[TestCase("5/27/2017", 17, 4, 2, 2017)]
		[TestCase("5/28/2017", 18, 5, 2, 2017)]
		[TestCase("6/30/2017", 22, 5, 2, 2017)]
		[TestCase("7/1/2017", 22, 5, 2, 2017)]
		[TestCase("7/2/2017", 23, 6, 2, 2017)]
		[TestCase("7/29/2017", 26, 6, 2, 2017)]
		[TestCase("7/30/2017", 27, 7, 3, 2017)]
		[TestCase("8/26/2017", 30, 7, 3, 2017)]
		[TestCase("8/27/2017", 31, 8, 3, 2017)]
		[TestCase("9/30/2017", 35, 8, 3, 2017)]
		[TestCase("10/1/2017", 36, 9, 3, 2017)]
		[TestCase("10/28/2017", 39, 9, 3, 2017)]
		[TestCase("10/29/2017", 40, 10, 4, 2017)]
		[TestCase("11/25/2017", 43, 10, 4, 2017)]
		[TestCase("11/26/2017", 44, 11, 4, 2017)]
		[TestCase("12/30/2017", 48, 11, 4, 2017)]
		[TestCase("12/31/2017", 49, 12, 4, 2017)]
		[TestCase("2/3/2018", 53, 12, 4, 2017)]
		[TestCase("2/4/2018", 1, 1, 1, 2018)]
		[TestCase("3/3/2018", 4, 1, 1, 2018)]
		[TestCase("3/4/2018", 5, 2, 1, 2018)]
		[TestCase("4/7/2018", 9, 2, 1, 2018)]
		[TestCase("4/8/2018", 10, 3, 1, 2018)]
		[TestCase("5/5/2018", 13, 3, 1, 2018)]
		[TestCase("5/6/2018", 14, 4, 2, 2018)]
		[TestCase("6/2/2018", 17, 4, 2, 2018)]
		[TestCase("6/3/2018", 18, 5, 2, 2018)]
		[TestCase("7/7/2018", 22, 5, 2, 2018)]
		[TestCase("7/8/2018", 23, 6, 2, 2018)]
		[TestCase("8/4/2018", 26, 6, 2, 2018)]
		[TestCase("8/5/2018", 27, 7, 3, 2018)]
		[TestCase("9/1/2018", 30, 7, 3, 2018)]
		[TestCase("9/2/2018", 31, 8, 3, 2018)]
		[TestCase("10/6/2018", 35, 8, 3, 2018)]
		[TestCase("10/7/2018", 36, 9, 3, 2018)]
		[TestCase("11/3/2018", 39, 9, 3, 2018)]
		[TestCase("11/4/2018", 40, 10, 4, 2018)]
		[TestCase("12/1/2018", 43, 10, 4, 2018)]
		[TestCase("12/2/2018", 44, 11, 4, 2018)]
		[TestCase("1/5/2019", 48, 11, 4, 2018)]
		[TestCase("1/6/2019", 49, 12, 4, 2018)]
		[TestCase("2/2/2019", 52, 12, 4, 2018)]
		[TestCase("2/3/2019", 1, 1, 1, 2019)]
		[TestCase("3/2/2019", 4, 1, 1, 2019)]
		[TestCase("3/3/2019", 5, 2, 1, 2019)]
		[TestCase("4/6/2019", 9, 2, 1, 2019)]
		[TestCase("4/7/2019", 10, 3, 1, 2019)]
		[TestCase("5/4/2019", 13, 3, 1, 2019)]
		[TestCase("5/5/2019", 14, 4, 2, 2019)]
		[TestCase("5/31/2019", 17, 4, 2, 2019)]
		[TestCase("6/1/2019", 17, 4, 2, 2019)]
		[TestCase("6/2/2019", 18, 5, 2, 2019)]
		[TestCase("7/6/2019", 22, 5, 2, 2019)]
		[TestCase("7/7/2019", 23, 6, 2, 2019)]
		[TestCase("8/3/2019", 26, 6, 2, 2019)]
		[TestCase("8/4/2019", 27, 7, 3, 2019)]
		[TestCase("8/31/2019", 30, 7, 3, 2019)]
		[TestCase("9/1/2019", 31, 8, 3, 2019)]
		[TestCase("10/5/2019", 35, 8, 3, 2019)]
		[TestCase("10/6/2019", 36, 9, 3, 2019)]
		[TestCase("11/2/2019", 39, 9, 3, 2019)]
		[TestCase("11/3/2019", 40, 10, 4, 2019)]
		[TestCase("11/30/2019", 43, 10, 4, 2019)]
		[TestCase("12/1/2019", 44, 11, 4, 2019)]
		[TestCase("1/4/2020", 48, 11, 4, 2019)]
		[TestCase("1/5/2020", 49, 12, 4, 2019)]
		[TestCase("2/1/2020", 52, 12, 4, 2019)]
		[TestCase("2/2/2020", 1, 1, 1, 2020)]
		[TestCase("2/29/2020", 4, 1, 1, 2020)]
		[TestCase("3/1/2020", 5, 2, 1, 2020)]
		[TestCase("4/4/2020", 9, 2, 1, 2020)]
		[TestCase("4/5/2020", 10, 3, 1, 2020)]
		[TestCase("5/2/2020", 13, 3, 1, 2020)]
		[TestCase("5/3/2020", 14, 4, 2, 2020)]
		[TestCase("5/30/2020", 17, 4, 2, 2020)]
		[TestCase("5/31/2020", 18, 5, 2, 2020)]
		[TestCase("7/4/2020", 22, 5, 2, 2020)]
		[TestCase("7/5/2020", 23, 6, 2, 2020)]
		[TestCase("7/6/2020", 23, 6, 2, 2020)]
		[TestCase("7/7/2020", 23, 6, 2, 2020)]
		[TestCase("7/8/2020", 23, 6, 2, 2020)]
		[TestCase("7/9/2020", 23, 6, 2, 2020)]
		[TestCase("7/10/2020", 23, 6, 2, 2020)]
		[TestCase("7/11/2020", 23, 6, 2, 2020)]
		[TestCase("7/12/2020", 24, 6, 2, 2020)]
		[TestCase("7/13/2020", 24, 6, 2, 2020)]
		[TestCase("7/14/2020", 24, 6, 2, 2020)]
		[TestCase("7/15/2020", 24, 6, 2, 2020)]
		[TestCase("7/16/2020", 24, 6, 2, 2020)]
		[TestCase("7/17/2020", 24, 6, 2, 2020)]
		[TestCase("7/18/2020", 24, 6, 2, 2020)]
		[TestCase("7/19/2020", 25, 6, 2, 2020)]
		[TestCase("7/20/2020", 25, 6, 2, 2020)]
		[TestCase("7/21/2020", 25, 6, 2, 2020)]
		[TestCase("7/22/2020", 25, 6, 2, 2020)]
		[TestCase("7/23/2020", 25, 6, 2, 2020)]
		public void GetFiscalMetaData_WhenCalled_ShouldReturnCorrectMetaData(DateTime date, int week, int month, int quarter, int year)
		{
			var result = date.GetFiscalMetaData();

			Assert.That(result.Year, Is.EqualTo(year));
			Assert.That(result.Quarter, Is.EqualTo(quarter));
			Assert.That(result.Month, Is.EqualTo(month));
			Assert.That(result.Week, Is.EqualTo(week));
		}
	}
}
