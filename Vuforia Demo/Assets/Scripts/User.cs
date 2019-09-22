using System;

namespace pocos
{
    [Serializable]
    public class User
    {
//        result: {
//  "Email": "jawaller@asu.edu", 
//  "Favorite_Color": "FF8017", 
//  "Favorite_Hobby": "Pancakes", 
//  "Field": "Software Engineering", 
//  "Name": "Jacob Wallert", 
//  "Nametag": "jawaller@asu.edu.nametag", 
//  "Superpower": "Overthinking"
//}
        public string Name;
        public string Email;
        public string Favorite_Color;
        public string Superpower;
        public string Field;
        public string Favorite_Hobby;

        public User(string n, string e,string c,string p, string f, string h)
        {
            Name = n;
            Email = e;
            Favorite_Color = c;
            Superpower = p;
            Field = f;
            Favorite_Hobby = h;
        }
    }
}
