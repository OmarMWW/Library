using System;
using System.Collections.Generic;

internal static class Library
{
    private static List<Mediatype> medias = new List<Mediatype>();

    public static void AddMedia(Mediatype mediatype)
    {
        medias.Add(mediatype);
    }

    public static List<Mediatype> GetMedias() { return medias; }
}