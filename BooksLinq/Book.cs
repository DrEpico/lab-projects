﻿using System;

public class Book
{
	public int Id {  get; set; }
	public string Title { get; set; }
	public string Author { get; set; }
	public int PageCount { get; set; }
	public string Publisher { get; set; }
	public int PublishedYear { get; set; }
	public string Genre { get; set; }
	public bool IsClassic { get; set; }

	public Book()
	{
		Id = 0;
		Title = "Unknown";
		Author = "Unknown";
		PageCount = 0; 
		Publisher = "Unknown";
		PublishedYear = 0;
		Genre = "Unknown";
		IsClassic = false;
	}

	public Book(int id, string title, string author, int pageCount, string author, 
		int pageCount, string publisher, int publishedYear, string genre)
	{
		Id = id;
		Title = title;
		Author = author;
		PageCount = pageCount;
		Publisher = publisher;
		PublishedYear = publishedYear;
		Genre = genre;
		IsClassic = true;
	}

	public override string ToString()
	{
		return $"{Id}: {Author} ({PublishedYear}). {Title}. {Publisher}." + 
			$"\n Pages: {PageCount}, Genre: {Genre}, Classic: {IsClassic}";
	}


	
}
