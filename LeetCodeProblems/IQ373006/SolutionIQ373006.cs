using System;
using System.Collections.Generic;

namespace LeetCodeProblems.IQ373006
{
    public class SolutionIQ373006
    {
        public Dictionary<string, List<string>> Solve(Dictionary<string, List<string>> userSongs,
            Dictionary<string, List<string>> songGenres)
        {
            var songs = new Dictionary<string, string>();
            foreach (var songGenre in songGenres)
            {
                foreach (var song in songGenre.Value)
                {
                    songs.Add(song, songGenre.Key);
                }
            }


            var result = new Dictionary<string, List<string>>();

            foreach (var user in userSongs)
            {
                var userGenres = new Dictionary<string, int>();
                foreach (var song in user.Value)
                {
                    if (songs.TryGetValue(song, out var genre))
                    {
                        int genreCount;
                        userGenres.TryGetValue(genre, out genreCount);
                        userGenres[genre] = genreCount + 1;
                    }
                }

                var maxCount = 0;
                var favorite = result[user.Key] = new List<string>();
                foreach (var userGenre in userGenres)
                {
                    if (maxCount == userGenre.Value)
                    {
                        favorite.Add(userGenre.Key);
                    }
                    else if (maxCount < userGenre.Value)
                    {
                        favorite.Clear();
                        favorite.Add(userGenre.Key);
                        maxCount = userGenre.Value;
                    }
                    
                }
            }

            return result;
        }
    }
}