﻿using ExamProject.Constants;
using ExamProject.Extentions;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<object> Ingredients { get; set; }
    public TimeSpan ReadyIn { get; set; }
    public int CategoryId { get; set; }
    public long ChatId { get; set; }
}
