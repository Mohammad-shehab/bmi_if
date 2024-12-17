Console.WriteLine("Enter your weight: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your height: ");
double height_cm = Convert.ToDouble(Console.ReadLine());
double height_m = height_cm / 100;
double bmi = (weight /  Math.Pow(height_m,2));
Console.WriteLine("Your BMI is: " + bmi );
string BMIState="";
if  (bmi <18.5)
{
    BMIState = "underweight";
}
else if (bmi >= 18.5 && bmi <= 24.9)
{
    BMIState = "healthy";
}
else if (bmi >= 25.0 && bmi <= 29.9)
{
    BMIState = "overweight";
}
else if (bmi >= 30)
{
    BMIState = "obese";
}
else
{
    Console.WriteLine("Error");
}
Console.WriteLine("You are " + BMIState);

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Enter your Age: ");
double age = Convert.ToDouble(Console.ReadLine());
string BMIState2 = "";

if (bmi >= 19 && bmi <= 24 && age >=19 && age<=24 )
{
    BMIState2 = "Healthy";
}
else if (bmi >= 20 && bmi <= 25 && age >= 25 && age <= 34)
{
    BMIState2 = "Healthy";
}
else if (bmi >= 21 && bmi <= 26 && age >= 35 && age <= 44)
{
    BMIState2 = "Healthy";
}
else if (bmi >= 22 && bmi <= 27 && age >= 45 && age <= 54)
{
    BMIState2 = "Healthy";
}
else if (bmi >= 23 && bmi <= 28 && age >= 55 && age <= 64)
{
    BMIState2 = "Healthy";
}
else if (bmi >= 24 && bmi <= 29 && age >= 65)
{
    BMIState2 = "Healthy";
}
else
{
    BMIState2 = " Not Healthy";
}
Console.WriteLine("You are " + BMIState2);