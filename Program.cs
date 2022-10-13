void Menu(){
    Console.WriteLine("Choose a number, whether to calculate two numbers of your choice, speak to me, or see a cat.");
    Console.WriteLine("1. use addition. 2. use subtraction 3. use multiplication 4. use division 5. cat picture 6. tell me something 7. exit");
    string response = Console.ReadLine();
    if(response == "1")
    additionFunction();
    if(response == "2")
    subtractionFunction();
    if(response == "3")
    multiplicationFunction();
    if(response == "4")
    divisionFunction();
    if(response == "5")
    kitty();
    if(response == "6")
    talkToMe();
    if(response == "7"){
    Console.WriteLine("Thank you hasta luego");
    System.Environment.Exit(0);
    }
else{
Menu();
}
}
Menu();
void additionFunction(){
    Console.Write("Choose a number.");
    int userNumberOneAddition=int.Parse(Console.ReadLine());
    Console.Write("Choose another number.");
    int userNumberTwoAddition=int.Parse(Console.ReadLine());
    int additionResult=userNumberOneAddition + userNumberTwoAddition;
    Console.WriteLine(additionResult);
}
void subtractionFunction(){
    Console.Write("Choose a number.");
    int userNumberOneSubtraction=int.Parse(Console.ReadLine());
    Console.Write("Choose another number.");
    int userNumberTwoSubtraction=int.Parse(Console.ReadLine());
    int subtractionResult=userNumberOneSubtraction - userNumberTwoSubtraction;
    Console.WriteLine(subtractionResult);
}
void multiplicationFunction(){
    Console.Write("Choose a number.");
     int userNumberOneMultiplication=int.Parse(Console.ReadLine());
     Console.Write("Choose another number.");
     int userNumberTwoMultiplication=int.Parse(Console.ReadLine());
     int multiplicationResult=userNumberOneMultiplication * userNumberTwoMultiplication;
     Console.WriteLine(multiplicationResult);
}
void divisionFunction(){
    Console.Write("Choose a number.");
    int userNumberOneDivision=int.Parse(Console.ReadLine());
    Console.Write("Choose another number.");
    int userNumberTwoDivision=int.Parse(Console.ReadLine());
    int divisionResult=userNumberOneDivision / userNumberTwoDivision;
    Console.WriteLine(divisionResult);
}
void kitty()
{
    Console.WriteLine("<(^..^)>");
}
void talkToMe(){
    Console.WriteLine("Talk to me.");
    string response = Console.ReadLine();
}