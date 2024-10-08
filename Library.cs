﻿using CSharp_OOP_Lab_06;
using Library_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;


[Serializable]
public class Library : ISerializable
{
    private List<Book> books = new List<Book>();
    private List<User> users = new List<User>();
    public List<Book> Books { get => books; set => books = value; }
    public List<User> Users { get => users; set => users = value; }
    public Library()
    {
        
    }
    public void addBook(Book book)
    {
        books.Add(book);
    }
    public List<Book> find(string keyword)
    {
        List<Book> result = new List<Book>();
        foreach (Book b in books)
            if (b.find(keyword))
                result.Add(b);
        return result;
    }
    public void addUser(User user)
    {
        users.Add(user);
    }
    public string ChooseUser(string idUser)
    {
        string builder = "";
        foreach (User user in users)
        {
            if (user.IdUser == idUser)
            {
                builder = $"Chào mừng {user} tới với library";
                break;
            }
            else
            {
                builder = "No User Found";
            }
        }
        return builder;
    }
    public bool CheckIdUser(string idUser)
    {
        bool check = false;
        foreach (User user in users)
        {
            if (user.IdUser == idUser)
                check = true;
        }
        return check;
    }
    public string PrintBooks()
    {
        StringBuilder builder = new StringBuilder();
        foreach (Book book in books)
        {
            builder.AppendLine(book.ToString());
        }
        return builder.ToString();
    }
    public bool CheckUserLogin(string u, string v)
    {
        foreach (User user in users)
        {
            if (u == user.Username && v == user.IdUser)
            {
                return true;
            }
        }
        return false;
    }
    public void BorrowBook(string id, byte count)
    {
        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                book.BorrowBook(count);
            }
        }
    }
    public void ReturnBook(string id, byte count)
    {
        foreach (Book book in books)
        {
            if (book.Id == id) { book.ReturnBook(count); }
        }
    }
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Books", Books);
        info.AddValue("Users", Users);
    }
    public Library(SerializationInfo info, StreamingContext context)
    {
        Books = (List<Book>)info.GetValue("Books", typeof(List<Book>));
        Users = (List<User>)info.GetValue("Users", typeof(List<User>));
    }
}