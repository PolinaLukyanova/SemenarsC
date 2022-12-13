// В тексте нужно все пробелы заменить черточками, маленькие 
// буквы "к" заменить большими "К", а большие "С" заменить маленькими "с"

string text = " – Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде," 
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "fuhfh"
// .           012
// s[3] // f          вызов символа по индексу


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length; //получить длину строки, кол-во символов
    for (int i = 0; i < length; i++)  // используя цикл for проходим 
    // от 0 символа до конца строки делая слудующее действие
    {
        // если текущий символ совпал с тем символом который 
        // мы хотим заменить, то в результат должны положить  
        // новое значиние в виде строки $"{newValue}"

        if (text[i] == oldValue) result = result + $"{newValue}";
        // если же совпадений нет то в result надо добавить текущий символ
        else result = result + $"{text[i]}";
    }
    return result; //вернуть результат

}
// запустим программу, присвоим новые значения
string newText = Replace(text, ' ', '|'); 
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'к', 'К'); 
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'с', 'С'); 
Console.WriteLine(newText);


