string[] array1 = {"a", "ab", "abc", "abcd", "12345", "Moscow", "Ru"}; // first array
List<string> array2 = new List<string>(); // second array

for (int i = 0; i < array1.Length; i++){
    if(array1[i].Length <= 3){ // if lenght of current string <= 3, then add this string to the seccond array
        array2.Add(array1[i]);
    }
}

Console.WriteLine(String.Join("; ", array2)); //print second array