/* Считать с консоли строку, сотоящую из
цифр и латинских букв.

Сформировать новую строку, состоящую
из букв исходной сторки. */


string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true) //проверяем явл ли символ буквенным
        {
            letters = letters + e; // привяжет букву к зачению e
        }
        return letters;
    }
}
string str = Console.ReadLine();
string result = GetLettersFromString(str);// вункцию GetLetters поместили в переменную result
Console.WriteLine(result);