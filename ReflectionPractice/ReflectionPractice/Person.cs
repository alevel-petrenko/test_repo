﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractice
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public BankCardInfo CardInfo { get; set; }
        [SecureData] 
        // action filter
        public string Password { get; set; }
    }

    public class BankCardInfo
    {
        [SecureData] 
        // action filter
        public string Cvv { get; set; }
        public string Pin { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
    }

    public class SecureData : Attribute
    {

    }
}