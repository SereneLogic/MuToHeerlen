using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MuToHeerlen
{
    class Class_Mural
    {
        public int Mural_Id;
        public string Mural_Name;
        public string Mural_Artist;
        public int Mural_Year;
        public string Mural_Location;
        public string Mural_Description_NL;
        public string Mural_Description_EN;


        //Constructor
        public Class_Mural(int A, string B, string C, int D, string E, string F, string G)
        {
            Mural_Id = A;
            Mural_Name = B;
            Mural_Artist = C;
            Mural_Year = D;
            Mural_Location = E;
            Mural_Description_NL = F;
            Mural_Description_EN = G;
        }
    }

}