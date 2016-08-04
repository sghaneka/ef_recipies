using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EF.DataAccess.Contexts;
using EF.DataAccess.Models.Albums;

namespace EF.Test
{
    [TestClass]
    public class ManyToManyFieldsTests
    {
        [TestInitialize]
        public void Init()
        {
            using (var context = new AlbumContext())
            {
                var albums = context.Albums;
                context.Albums.RemoveRange(albums);

                var artists = context.Artists;
                context.Artists.RemoveRange(artists);

                context.SaveChanges();
            }

            using (var context = new AlbumContext())
            {
                var artist = new Artist { FirstName = "Alan", LastName = "Jackson" };
                var album1 = new Album { AlbumName = "Drive" };
                var album2 = new Album { AlbumName = "Live at Texas Stadium" };
                artist.Albums.Add(album1);
                artist.Albums.Add(album2);
                context.Artists.Add(artist);

                // add an album for two artists
                var artist1 = new Artist { FirstName = "Tobby", LastName = "Keith" };
                var artist2 = new Artist { FirstName = "Merle", LastName = "Haggard" };
                var album = new Album { AlbumName = "Honkytonk University" };
                context.Albums.Add(album);
                album.Artists.Add(artist1);
                album.Artists.Add(artist2);


                //context.Artists.Add(artist1);
                //context.Artists.Add(artist2);

                context.SaveChanges();
            }
        }

        [TestCleanup]
        public void CleanUp()
        {

        }

        [TestMethod]
        public void Album_Many_To_Many_Works()
        {
            using (var context = new AlbumContext())
            {
                // there are three artists in the db
                int artistsCount = context.Artists.ToList().Count;
                Assert.AreEqual(artistsCount, 3);
            }
        }
    }
}
