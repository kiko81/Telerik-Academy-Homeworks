﻿namespace ExtractArtists
{
    using System;
    using System.Collections;
    using System.Xml;

    public static class ExtractArtisits
    {
        private const string PathToFile = "../../../catalog.xml";

        public static void Main()
        {
            var doc = new XmlDocument();
            doc.Load(PathToFile);

            var root = doc.DocumentElement;

            var artists = new Hashtable();

            foreach (XmlElement album in root)
            {
                if (artists.ContainsKey(album["artist"].InnerText))
                {
                    artists[album["artist"].InnerText] = (int)artists[album["artist"].InnerText] + 1;
                }
                else
                {
                    artists.Add(album["artist"].InnerText, 1);
                }
            }

            foreach (DictionaryEntry artist in artists)
            {
                Console.WriteLine("{0} - {1} albums", artist.Key, artist.Value);
            }
        }
    }
}
