﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if ((daysUntilExpiration == 10) || (daysUntilExpiration > 6))
{
    
    Console.WriteLine($" Your subscription will expire soon in " + daysUntilExpiration + ". Renew now! " );
}
else if ((daysUntilExpiration <= 5) || (daysUntilExpiration > 2))
{
    discountPercentage = 10;
    Console.WriteLine($" your subscrition expires in " + daysUntilExpiration );
    Console.WriteLine($"Renew now and save " + discountPercentage + " Percent");
}
else if (((daysUntilExpiration < 2)))
{
    discountPercentage = 20;
    Console.WriteLine(" Your subscription expires within a day! ");
    Console.WriteLine("Renew now and save " + discountPercentage + "Percent");
}
else if ((((daysUntilExpiration == 0))))
{
    Console.WriteLine(" Your subscription has expired! ");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}





