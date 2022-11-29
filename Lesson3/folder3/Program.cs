string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            + "Tellus elementum sagittis vitae et. Ultrices eros in cursus turpis massa tincidunt."
            + "Scelerisque viverra mauris in aliquam sem. Sem integer vitae justo eget magna fermentum iaculis eu. Varius morbi enim nunc faucibus a."
            + "Consequat semper viverra nam libero justo laoreet."
            + "Suspendisse sed nisi lacus sed viverra. Varius sit amet mattis vulputate enim nulla.";

string Replace(string text, char oldValue, char newValue)
{
    string rez = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) rez += $"{newValue}";
        else rez += $"{text[i]}";

    }
    return rez;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'l', 'L');
System.Console.WriteLine(newText);