using System;
using System.Collections;
using System.Collections.Generic;
using Linq;

public class login{
  
  public string[] emails = new string[5]{
    "simon.smith@campioncollege.com",
    "soleil.simms@campioncollege.com",
    "nathanael.simpson@campioncollege.com",
    "zoe.shelton@campioncollege.com",
    "bryandre.sterling@campioncollege.com"
  };
  public static void Main(string[] args; string emaill){
    check(emaill)
    if(check == false){
      main.js;
    }
    else{
      index.html;
    }
  }
  
  public static bool check (email){
    if(emails.FindIndexOf(email) != null){
      return true;
    }
    else{
      return false;
    }
    
  }
}