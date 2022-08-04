/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше лтбо равна 3 символа*/

void ShowArray (string []array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
		
	Console.WriteLine()	;
}

string[] NewLengthArray (string[] array)
{
    string [] newArray = new string[array.Length];
    int wordlength = 3;
	for (int i = 0; i < array.Length; i++)
		if (array[i].Length <= wordlength)
			newArray[i] = array[i];
	
	return newArray;
}

string[] ourArray = {"Tishe", "myshi", "kot","na","kryshe",};

Console.WriteLine("Given array is: [" + string.Join(", ", ourArray) + "]");

string[] newArray = NewLengthArray(ourArray);

Console.Write("New array is: ");
ShowArray(newArray);