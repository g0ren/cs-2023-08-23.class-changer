namespace CW
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Class with int");
            var cwi = new ClassWithInt();
            Console.WriteLine("Before change");
            Console.WriteLine(cwi.MyInt);
            Console.WriteLine("After change");
            ClassChanger.ChangePrivateField(cwi);
            Console.WriteLine(cwi.MyInt);
            Console.WriteLine();
            
            Console.WriteLine("Class with string");
            var cws = new ClassWithString();
            Console.WriteLine("Before change");
            Console.WriteLine(cws.MyString);
            Console.WriteLine("After change");
            ClassChanger.ChangePrivateField(cws);
            Console.WriteLine(cws.MyString);
            Console.WriteLine();
            
            Console.WriteLine("Class with bool");
            var cwb = new ClassWithBool();
            Console.WriteLine("Before change");
            Console.WriteLine(cwb.MyBool);
            Console.WriteLine("After change");
            ClassChanger.ChangePrivateField(cwb);
            Console.WriteLine(cwb.MyBool);
            Console.WriteLine();

            Console.WriteLine("Class with many different attributes (the ones that should be modified marked with *)");
            var cwma = new ClassWithManyAttributes();
            Console.WriteLine("Before change");
            Console.WriteLine($"MyBool {cwma.MyBool}");
            Console.WriteLine($"MyBool2* {cwma.MyBool2}");
            Console.WriteLine($"MyInt {cwma.MyInt}");
            Console.WriteLine($"MyInt2* {cwma.MyInt2}");
            Console.WriteLine($"MyString* {cwma.MyString}");
            Console.WriteLine($"MyString2 {cwma.MyString2}");
            
            Console.WriteLine("After change");
            ClassChanger.ChangePrivateFieldIfAttributeSet(cwma);
            Console.WriteLine($"MyBool {cwma.MyBool}");
            Console.WriteLine($"MyBool2* {cwma.MyBool2}");
            Console.WriteLine($"MyInt {cwma.MyInt}");
            Console.WriteLine($"MyInt2* {cwma.MyInt2}");
            Console.WriteLine($"MyString* {cwma.MyString}");
            Console.WriteLine($"MyString2 {cwma.MyString2}");
        }
    }
}