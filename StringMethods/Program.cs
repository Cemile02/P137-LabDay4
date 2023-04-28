using StringMethods;

Console.WriteLine("Hello World");


#region Split(char c)
//string str = "aaaa";
//string[] arr = str.Split('a');//
//foreach (var item in arr)
//{
//	Console.WriteLine(item+1);
//}


//string str = "Alma.Armud.Heyva";
//MyString myString = new MyString();
//string[] answerArray = myString.SplitArray(str, 'a');
//foreach (var item in answerArray)
//{
//	Console.WriteLine(item);
//}
#endregion


#region Substring

#region Substring(int startIndex)
string str = "Alma";
//Console.WriteLine(str.Substring(3));

MyString myString = new MyString();
Console.WriteLine(myString.MySubstring(str, 11));
#endregion

#region Substring(int index, int length)

//string str = "Alma";
//Console.WriteLine(str.Substring(1,4));

//string str = "Alma";
//MyString myString=new MyString();
//Console.WriteLine(myString.MySubstring(str,1,3));
#endregion
#endregion


#region Replace

//string str = "nana";
//Console.WriteLine(str.Replace('s', 'b'));

//string str = "nana";
//MyString myString = new MyString();
//Console.WriteLine(myString.MyReplace(str,'n', '.'));
#endregion


#region DateTime ve Timespan
//DateTime date1 = new DateTime(2023, 04, 28, 16, 18, 00,300);
//DateTime date2 = new DateTime(2023, 04, 28, 16, 18, 00,300);

//int result=DateTime.Compare(date1, date2);
//Console.WriteLine(result);  // beraber olanda  0


//DateTime date1 = new DateTime(2023, 04, 30, 16, 18, 00, 300);
//DateTime date2 = new DateTime(2023, 04, 28, 16, 18, 00, 300);

//int result = DateTime.Compare(date1, date2);
//Console.WriteLine(result);// date1 boyukdur date2 ---> 1


//DateTime date1 = new DateTime(2023, 04, 22, 16, 18, 00, 300);
//DateTime date2 = new DateTime(2023, 04, 28, 16, 18, 00, 300);

//int result = DateTime.Compare(date1, date2);
//Console.WriteLine(result);  // date1< date2  ---> -1

//DateTime date1 = new DateTime(2023, 04, 30, 16, 18, 00, 300);
//DateTime date2 = new DateTime(2023, 04, 28, 16, 18, 00, 300);
//TimeSpan time = date1 - date2;
//int days=time.Days;


//TimeSpan time1 = TimeSpan.FromDays(12.2);
//Console.WriteLine( time1);
#endregion

