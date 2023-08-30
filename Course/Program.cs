﻿using Course.Entities;

Console.Write("Room number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Check-in date (dd/MM/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());
Console.Write("Check-out date (dd/MM/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());


if (checkOut <= checkIn)
{
    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
}
else
{
    Reservation reservation = new(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation: ");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());
}