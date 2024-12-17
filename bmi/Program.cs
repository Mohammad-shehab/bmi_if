Console.WriteLine("Enter your weight: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your height: ");
double height_cm = Convert.ToDouble(Console.ReadLine());
double height_m = height_cm / 100;
double bmi = (weight /  Math.Pow(height_m,2));
Console.WriteLine("Your BMI is: " + bmi );
if  (bmi <18.5)
{
    Console.WriteLine("you are underweight");
}
else if (bmi >= 18.5 && bmi <= 24.9)
{
    Console.WriteLine("you are healthy");
}
else if (bmi >= 25.0 && bmi <= 29.9)
{
    Console.WriteLine("you are overweight");
}
else if (bmi >= 30)
{
    Console.WriteLine("you are obese");
}
else
{
    Console.WriteLine("Error");
}


string BMIState = Convert.ToString(bmi);

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Enter your Age: ");
double age = Convert.ToDouble(Console.ReadLine());


if (bmi >= 19 && bmi <= 24 && age >=19 && age<=24 )
{
    Console.WriteLine("You are Healthy");
}
else if (bmi >= 20 && bmi <= 25 && age >= 25 && age <= 34)
{
    Console.WriteLine("You are Healthy");
}
else if (bmi >= 21 && bmi <= 26 && age >= 35 && age <= 44)
{
    Console.WriteLine("You are Healthy");
}
else if (bmi >= 22 && bmi <= 27 && age >= 45 && age <= 54)
{
    Console.WriteLine("You are Healthy");
}
else if (bmi >= 23 && bmi <= 28 && age >= 55 && age <= 64)
{
    Console.WriteLine("You are Healthy");
}
else if (bmi >= 24 && bmi <= 29 && age >= 65)
{
    Console.WriteLine("You are Healthy");
    
}
else
{
    Console.WriteLine("You are not Healthy");
}
string BMIState2 = Convert.ToString(bmi);