﻿
namespace DiningHall.Models;

public class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int PreparationTime { get; set; }
    public int Complexity { get; set; }
    public string? CookingApparatus { get; set; }
}